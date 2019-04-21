using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using pGina.Plugin.MFLoginPlugin.Entities;
using pGina.Plugin.MFLoginPlugin.Entities.Keys;
using Emgu.CV;
using Emgu.CV.Face;
using Emgu.CV.Structure;
using System.Threading;
using System.IO;

namespace pGina.Plugin.MFLoginPlugin.Entities.ManagementForms
{
    public partial class FaceRecognitionKeyManagementForm : Form
    {
        private static ILog m_logger = LogManager.GetLogger("MFLoginPlugin");
        public string Description = "Face";
        public new string Name = null; //face owner name
        public string Password;
        public string Serial;
        public bool Inverted = false;
        public bool IsValid = false;
        private string KeyDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "/pGina.fork/Plugins/FaceKey/";
        public int Sensivity=5000;

        public FaceRecognitionKeyManagementForm(string userName)
        {
            InitializeComponent();
            description_textBox.Text = Description;
            description_textBox.Text += " of " + userName;
            Name = userName;
            KeyDirectory += Name;
            serial_textBox.Text = KeyDirectory +"/"+Name+ ".rcg";
            Serial = serial_textBox.Text;

            if (registeredFaces_listView.LargeImageList == null) registeredFaces_listView.LargeImageList = new ImageList();
            createdKeys_listBox.Items.AddRange(DBHelper.ReadKeys("FaceRecognitionKey"));
            
            CameraCapture = new VideoCapture()
            {
                FlipHorizontal = true
            };
            if (!CameraCapture.IsOpened)
            {
                MessageBox.Show("Camera is not available");
                Close();
            }
            Application.Idle += VideoCaptureProcess;
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                EyeDetector = new CascadeClassifier(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "/pGina.fork/Plugins/" + "haarcascade_eye.xml");
                FaceDetector = new CascadeClassifier(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "/pGina.fork/Plugins/" + "haarcascade_frontalface_default.xml");

                if (Directory.Exists(KeyDirectory))
                {
                    foreach (String filePath in Directory.GetFiles(KeyDirectory))
                    {
                        if (!filePath.EndsWith(".jpg")) continue;
                        Mat m = new Mat(filePath);
                        TrainingImages.Add(m.ToImage<Gray,byte>());
                        TrainingNumbers.Add(100);
                        registeredFaces_listView.LargeImageList.Images.Add(m.Bitmap);
                        registeredFaces_listView.Items.Add(Name, registeredFaces_listView.LargeImageList.Images.Count - 1);
                    }
                }

                if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "/pGina.fork/Plugins/FaceKey/DataSet"))
                {
                    foreach (String filePath in Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "/pGina.fork/Plugins/FaceKey/DataSet"))
                    {
                        if (!filePath.EndsWith(".jpg")) continue;
                        Image<Gray, byte> im = new Image<Gray,byte>(filePath);
                        FileInfo info = new FileInfo(filePath);
                        int num = int.Parse(info.Name.Substring("Personne".Length, 2));
                        Rectangle[] faces = FaceDetector.DetectMultiScale(im);
                        if (faces.Count() == 0) continue;
                        DefaultTrainingImages.Add(im.GetSubRect(faces[0]).Resize(100,100, Emgu.CV.CvEnum.Inter.Cubic));
                        DefaultTrainingNumbers.Add(num);
                        //registeredFaces_listView.LargeImageList.Images.Add(m.Bitmap);
                        //registeredFaces_listView.Items.Add(""+(num), registeredFaces_listView.LargeImageList.Images.Count - 1);
                    }
                }
                // add false faces to training images
            }
            catch (Exception ex) { MessageBox.Show("Unable to load stored data: " + ex.Message); }
        }
        private void ok_button_Click(object sender, EventArgs e)
        {
            Description = description_textBox.Text;
            Inverted = inverted_checkBox.Checked;
            Serial = serial_textBox.Text;
            bool verified = false;
            //
            // photos shouldn't be saved like this.... but we may need to retrain the face recognizer.... but....
            //
            try
            {
                if (!Directory.Exists(KeyDirectory)) Directory.CreateDirectory(KeyDirectory);
                for (int i = 0; i < TrainingImages.Count; i++)
                {
                    if (TrainingNumbers[i]==100)
                        TrainingImages[i].Save(KeyDirectory + "/" + i + ".jpg");
                    //avoid random images save
                }
            }
            finally { verified = true; }
            if (!Directory.EnumerateFiles(KeyDirectory).Any(s => s.EndsWith(Name + ".rcg")))
            {
                MessageBox.Show("Face recognizer not configured");
                verified = false;
            }
            if (verified)
            {
                IsValid = true;
                Close();
            }
        }

        private void createdKeys_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Key key = ((Key)createdKeys_listBox.SelectedItem);
            serial_textBox.Text = key.Serial;
            Serial = key.Serial;
            sensivity_trackBar.Value = int.Parse(key.Data);
            Name = key.Data;
            inverted_checkBox.Checked = key.Inverted;
            description_textBox.Text = Name+": "+key.Description;
            keyConfig_groupBox.Enabled = false;
        }

        public VideoCapture CameraCapture;
        public Image<Bgr, byte> CurrentFrame;
        Image<Gray, byte> CleanFrame;
        CascadeClassifier EyeDetector;
        CascadeClassifier FaceDetector;

        List<Tuple<Rectangle, bool>> DetectedFaces = new List<Tuple<Rectangle, bool>>();
        // for correct or incorrect faces
        // depends on eyes
        List<Rectangle> DetectedEyes = new List<Rectangle>();

        List<Image<Gray,byte>> TrainingImages = new List<Image<Gray, byte>>();
        List<Image<Gray, byte>> DefaultTrainingImages = new List<Image<Gray, byte>>();
        List<int> TrainingNumbers = new List<int>();
        List<int> DefaultTrainingNumbers = new List<int>();

        public void DetectFacesAndEyes()
        {
            DetectedFaces.Clear();
            Rectangle[] faces = FaceDetector.DetectMultiScale(CurrentFrame);
            foreach (Rectangle face in faces)
            {
                DetectedEyes.Clear();
                CurrentFrame.Draw(face, new Bgr(Color.Orange));
                Rectangle[] eyes = EyeDetector.DetectMultiScale(CurrentFrame);
                foreach (Rectangle eye in eyes)
                {
                    if (face.Contains(eye) && eye.Top < (face.Top + face.Height / 2))
                    {
                        DetectedEyes.Add(eye);
                    }
                }
                if (DetectedEyes.Count == 2 && DetectedEyes.Any(x => x.Left < (face.Left + face.Width / 2))
                    && DetectedEyes.Any(x => x.Right > (face.Right - face.Width / 2))
                    && Math.Abs((DetectedEyes[0].Top + DetectedEyes[0].Height / 2) -
                    (DetectedEyes[1].Top + DetectedEyes[1].Height / 2)) < DetectedEyes[0].Height)
                // 2 eyes, left and right, aligned horizontally
                {
                    DetectedFaces.Add(new Tuple<Rectangle, bool>(face, true));
                    CurrentFrame.Draw(face, new Bgr(Color.Red));
                    CurrentFrame.Draw(DetectedEyes[0], new Bgr(Color.Blue), 2);
                    CurrentFrame.Draw(DetectedEyes[1], new Bgr(Color.Blue), 2);
                }
                else
                {
                    DetectedFaces.Add(new Tuple<Rectangle, bool>(face, false));
                }
            }
        }
        public Rectangle RecognizeFaces() // both for configuration and checks
        {
            try
            {
                EigenFaceRecognizer recognizer = new EigenFaceRecognizer(threshold: Sensivity);
                if (TrainingImages.Count >= 1)
                {
                    recognizer.Load(Serial);
                    //Draw the label for each face detected and recognized
                    foreach (Tuple<Rectangle, bool> face in DetectedFaces)
                    {
                        if (face.Item2)
                        {
                            Image<Gray, byte> im = CleanFrame.GetSubRect(face.Item1).Resize(100, 100, Emgu.CV.CvEnum.Inter.Cubic);
                            FaceRecognizer.PredictionResult Result = recognizer.Predict(im);
                            if (Result.Label != -1)
                            {
                                string name = ((Result.Label == 100) ? Name : Result.Label.ToString());
                                name += ". Difference: " + Math.Round(Result.Distance).ToString();
                                CurrentFrame.Draw(name, new Point(face.Item1.X - 4, face.Item1.Y - 4), Emgu.CV.CvEnum.FontFace.HersheyPlain, 1, new Bgr(Color.Green));
                                CurrentFrame.Draw(face.Item1, new Bgr(Color.Green), 1);
                                try
                                {
                                    Rectangle mainFace = DetectedFaces.FindLast(x => x.Item1.Contains(CurrentFrame.Width / 2, CurrentFrame.Height / 2)).Item1;
                                    CurrentFrame.Draw(mainFace, new Bgr(Color.Green), 4);
                                    // Successful recognition
                                    return mainFace;
                                    // all actions are performed with this face
                                }
                                catch { }//no face in the center
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { m_logger.Error("Unable to recognize face during config: "+ex.Message); }
            return Rectangle.Empty;
        }
        private void VideoCaptureProcess(object sender, EventArgs e)
        {
            if (!ContainsFocus) return; // quit
            CurrentFrame = CameraCapture.QueryFrame().ToImage<Bgr, byte>();
            CleanFrame = CurrentFrame.Convert<Gray, byte>();
            DetectFacesAndEyes();
            if (RecognizeFaces()!=Rectangle.Empty)
            {
                // check for eye blink here
                // implementation pending
            }

            pictureBox.Image = CurrentFrame.Bitmap;
            Thread.Sleep(50);
        }

        private void FaceRecognitionKeyManagementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Idle -= VideoCaptureProcess;
            CameraCapture.Dispose();
        }
        private void addFace_button_Click(object sender, EventArgs e)
        {
            Image<Gray,byte> im = CleanFrame.GetSubRect(DetectedFaces.Last().Item1).Resize(100, 100, Emgu.CV.CvEnum.Inter.Cubic);
            TrainingImages.Add(im);
            TrainingNumbers.Add(100); // we need only 1 person
            registeredFaces_listView.LargeImageList.Images.Add(TrainingImages.Last().Bitmap);
            registeredFaces_listView.Items.Add(Name, registeredFaces_listView.LargeImageList.Images.Count - 1);
            EigenFaceRecognizer recognizer = new EigenFaceRecognizer(threshold: Sensivity);
            Image<Gray,byte>[] training_elements = TrainingImages.Concat(DefaultTrainingImages).ToArray();
            int[] training_numbers = TrainingNumbers.Concat<int>(DefaultTrainingNumbers).ToArray();
            recognizer.Train(training_elements, training_numbers);
            if (!Directory.Exists(KeyDirectory)) Directory.CreateDirectory(KeyDirectory);
            recognizer.Save(Serial);
        }

        private void testKey_button_Click(object sender, EventArgs e)
        {
            if (FaceRecognitionKey.CheckFaceKey(Serial)) MessageBox.Show("Success!");
            CameraCapture = new VideoCapture
            {
                FlipHorizontal = true
            };
        }

        private void sensivity_trackBar_Scroll(object sender, EventArgs e)
        {
            Sensivity = sensivity_trackBar.Maximum - sensivity_trackBar.Value; // invert "security level" into "sensivity"
            // trackBar supports only min to max values
            EigenFaceRecognizer recognizer = new EigenFaceRecognizer(threshold: Sensivity, numComponents:10);
            Image<Gray, byte>[] training_elements = TrainingImages.Concat(DefaultTrainingImages).ToArray();
            int[] training_numbers = TrainingNumbers.Concat<int>(DefaultTrainingNumbers).ToArray();
            recognizer.Train(training_elements, training_numbers);
            if (!Directory.Exists(KeyDirectory)) Directory.CreateDirectory(KeyDirectory);
            recognizer.Save(Serial);
        }
    }
}

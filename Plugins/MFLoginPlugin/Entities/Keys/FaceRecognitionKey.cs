using System;
using System.Collections.Generic;
using System.Text;
using pGina.Plugin.MFLoginPlugin.Entities.ManagementForms;
using log4net;
using Emgu.CV;
using System.Linq;
using System.IO;
using Emgu.CV.Structure;
using Emgu.CV.Face;
using System.Drawing;
using pGina.Shared.Settings;

namespace pGina.Plugin.MFLoginPlugin.Entities.Keys
{
    class FaceRecognitionKey : Key
    {
        ILog m_logger = LogManager.GetLogger("MFLoginPlugin");
        dynamic m_settings = new pGinaDynamicSettings(MFLoginPlugin.SimpleUuid);
        public FaceRecognitionKey(ulong kid) : base(kid) { Type = "FaceRecognitionKey"; } // specific key
        public override bool AddKey(string userName = "")
        {
            FaceRecognitionKeyManagementForm managementForm = new FaceRecognitionKeyManagementForm(userName);
            managementForm.ShowDialog();
            if (!managementForm.IsValid) return false;
            Description = managementForm.Description;
            Inverted = managementForm.Inverted;
            Password = managementForm.Password;
            Serial = managementForm.Serial;
            Data = ""+managementForm.Sensivity;
            return true;
        }
        public override bool CheckKey(string password)
        {
            bool success = false;
			try
			{
                success = CheckFaceKey(Serial, (int)m_settings.MaxAuthTimeSeconds, int.Parse(Data));
            }
			catch (Exception e) { m_logger.Error("FaceRecognitionKey: "+e.Message); }
            if (Inverted) success = !success;
            m_logger.Info("FaceRecognition of " + Description + "; Inverted: " + Inverted + "; Success: " + success);
            return success;
        }

        public static bool CheckFaceKey(string recognizerPath, int maxTimeSeconds = 10, int sensivity = 5000)
        {
            List <Tuple<Rectangle, bool>> DetectedFaces = new List<Tuple<Rectangle, bool>>();
            // for correct or incorrect faces
            // depends on eyes
            VideoCapture CameraCapture = new VideoCapture();
            CameraCapture.FlipHorizontal = true;
            Image<Gray, byte> CurrentFrame;
            CascadeClassifier FaceDetector = new CascadeClassifier(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)+"/pGina.fork/Plugins/"+"haarcascade_frontalface_default.xml");
            CascadeClassifier EyeDetector = new CascadeClassifier(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "/pGina.fork/Plugins/" + "haarcascade_eye.xml");

            DateTime finish = DateTime.Now.AddSeconds(maxTimeSeconds);
            while (DateTime.Now < finish)
            {
                CurrentFrame = CameraCapture.QueryFrame().ToImage<Gray, byte>();
                Rectangle[] faces = FaceDetector.DetectMultiScale(CurrentFrame);
                foreach (Rectangle face in faces)
                {
                    Rectangle[] eyes = EyeDetector.DetectMultiScale(CurrentFrame);
                    List<Rectangle> DetectedEyes = new List<Rectangle>();
                    foreach (Rectangle eye in eyes)
                    {
                        if (face.Contains(eye) && eye.Top < (face.Top + face.Height / 2))
                        {
                            DetectedEyes.Add(eye);
                        }
                    }
                    if (DetectedEyes.Count < 4 && DetectedEyes.Any(x => x.Left < (face.Left + face.Width / 2))
                        && DetectedEyes.Any(x => x.Right > (face.Right - face.Width / 2))
                        && Math.Abs((DetectedEyes[0].Top + DetectedEyes[0].Height / 2) -
                        (DetectedEyes[1].Top + DetectedEyes[1].Height / 2)) < DetectedEyes[0].Height)
                    // 2 eyes, left and right one, aligned horizontally. some 'false' eyes may exist
                    {
                        DetectedFaces.Add(new Tuple<Rectangle, bool>(face, true));
                    }
                    else
                    {
                        DetectedFaces.Add(new Tuple<Rectangle, bool>(face, false));
                    }
                } // DetectedFaces contains correct faces now
                EigenFaceRecognizer recognizer = new EigenFaceRecognizer(threshold: sensivity);
                recognizer.Load(recognizerPath);
                
                foreach (Tuple<Rectangle, bool> face in DetectedFaces)
                {
                    if (face.Item2)
                    {
                        Image<Gray, byte> im = CurrentFrame.GetSubRect(face.Item1).Resize(100, 100, Emgu.CV.CvEnum.Inter.Cubic);
                        FaceRecognizer.PredictionResult Result = recognizer.Predict(im.Mat);
                        if (Result.Label != -1)
                        {
                            try
                            {
                                Rectangle mainFace = DetectedFaces.FindLast(x => x.Item1.Contains(CurrentFrame.Width / 2, CurrentFrame.Height / 2)).Item1;
                                // Successful recognition
                                CameraCapture.Dispose();
                                return true;
                                // all actions are performed with this face
                            }
                            catch { }//no face in the center
                        }
                    }
                }
            }
            CameraCapture.Dispose();
            return false;
        }
    }
}
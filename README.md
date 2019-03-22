# pGina

pGina is a pluggable Open Source GINA and CredentialProvider replacement.
Plugins are written in managed code and allow for user authentication, session
management and login time actions.

## This fork

This fork is supposed to work with multi-factor login plugin. Recommended configuration: all plugins except for MFLogin disabled.
MFLogin plugin allows you to create different authentication methods for each user.
You can use combination of other plugins to get MFLogin plugin functionality but that doesn't work well.

Each authentication method has up to 5 keys required for the user to log in.
Keys include:
* Connectable devices (USB Flash, camera, any other device with a serial number)
* Password
* HTTP(S) request
* Bluetooth devices

Plugin has its own password protected database.
Windows users can be added to pGina from the configuration tool. User password is set to a huge random string then.

## License

Copyright (c) 2016, pGina Team

All Rights Reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met:

 * Redistributions of source code must retain the above copyright notice, this 
   list of conditions and the following disclaimer.
 * Redistributions in binary form must reproduce the above copyright notice, 
   this list of conditions and the following disclaimer in the documentation 
   and/or other materials provided with the distribution.
 * Neither the name of the pGina Team nor the names of its contributors may 
   be used to endorse or promote products derived from this software without 
   specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE
FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

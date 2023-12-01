using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterCreator
{
    internal class LoginHandler
    {

        private string _username;
        private string _password;
        private string _filepath;
        private string _error;

        string[] fields;

        public string Username
        { 
            get { return _username; } 
            set {  _username = value; } 
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string FilePath
        {
            get { return _filepath; }
            set { _filepath = value; }
        }

        public string Error
        {
            get { return _error; }
            set { _error = value; }
        }

        // paremeterized constructor
        public LoginHandler(string password, string username)
        {
            _username = username;
            _password = password;
        }
        
        // method to check if the dnd password is found
        public bool Check()
        {
            StreamReader SR = null;
            Error = string.Empty;

            try
            {
                SR = new StreamReader(FilePath); SR.ReadToEnd(); 
                
                while (!SR.EndOfStream)
                {
                    string line = SR.ReadLine();
                    fields = line.Split(',');

                    if (fields[0] == Password && fields[1] == Username)
                    {
                        return true;
                    }
                    else
                    {
                        // do nothing
                    }
                }
                Error = "Username and/or Password are incorrect";
                return false;

            } 
            catch (Exception ex) 
            {
                Error = ex.Message;
                return false;
            }

           finally 
            { 
                if (SR != null)
                {
                    SR.Close();
                } 
                     
            }
        }

    }
}

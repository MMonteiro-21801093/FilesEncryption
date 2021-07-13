using System;
 
using System.IO;
 
namespace FileEncryption
{
    class FileOption
    {

        public void cipherFile()
        {
            message("Enter the file to encrypt.");
            string file = Console.ReadLine();
            if (file != "")
            {
                string output = treatFileOutput(file);
                Cipher cipher = new Cipher();

                if (cipher.EncryptFile(file, output))
                {
                    File.Delete(file);
                    message("Encrypted file successfully.");

                }
                else
                {
                    message("Error, file not encrypted.");
                }
            }
        }
        private   string treatFileOutput(string file)
        {
            string output = "";
            string[] wfield = file.Split('\\');
            for (int i = 0; i < wfield.Length; i++)
            {
                output += (i < wfield.Length - 1) ? wfield[i] + "\\" : "_" + wfield[i];
            }
            return output;
        }

        public void decipherFile()
        {
            {
                message("Enter the file to be decrypted.");
                string file = Console.ReadLine();
                if (file != "")
                {
                    string output = file.Replace("_", "");
                    Cipher cipher = new Cipher();
                    if (cipher.DecryptFile(file, output))
                    {
                        File.Delete(file);
                        message("File successfully decrypted.");
                    }
                    else

                    {
                        message("Error, file not decrypted.");
                    }
                }
            }
        }

        public void decipherFolder()
        {
            message("Enter the file to be decrypted.");
            string file = Console.ReadLine();
            if (file != "")
            {
                string output = file.Replace("_", "");
                Cipher cipher = new Cipher();
                if (cipher.DecryptFile(file, output))
                {
                    File.Delete(file);
                    message("File,"+ file +" successfully decrypted.");
                }
                else

                {
                    message("Error," + file + " file not decrypted.");
                }
            }
        }

        public void cipherFolder()
        {
            message("Introduce the folder to encrypt.");
            string dir = Console.ReadLine();
            string[] files = Directory.GetFiles(@dir, "*", SearchOption.AllDirectories);
            if (dir != "")
            {
                Cipher cipher = new Cipher();
                foreach (string file in files)
                {
                    Console.WriteLine("Encrypting => " + file);
                    string output = treatFileOutput(file);
                    if (cipher.EncryptFile(file, output))
                    {
                        File.Delete(file);
                        message("Encrypted " + file + " file successfully.");

                    }
                    else
                    {
                        message("Error, " + file + "  file not encrypted.");
                    }
                }



            }
        }

        private void message(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}

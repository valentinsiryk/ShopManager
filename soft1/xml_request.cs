using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;

using System.IO;
using System.Net;

namespace soft1
{
    public class xml_request
    {
        public string getResponse(string req)
        {
            try
            {
                WebRequest request = WebRequest.Create(req); // Create a request for the URL. 
                request.Credentials = CredentialCache.DefaultCredentials; // If required by the server, set the credentials.

                WebResponse response = request.GetResponse(); // Get the response.
                Stream dataStream = response.GetResponseStream(); // Get the stream containing content returned by the server.
                
                StreamReader reader = new StreamReader(dataStream); // Open the stream using a StreamReader for easy access.
                string responseFromServer = reader.ReadToEnd(); // Read the content.
                reader.Close(); // Clean up the streams and the response.
                response.Close(); // Clean up the streams and the response.

                return responseFromServer;
            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString(), "Error!");
                return "error";
            }

         }

        public void saveToFile(string text)
        {
            string path = @".\response.xml";

            try
            {
                if (File.Exists(path))
                    File.Delete(path);

                // Create the file.
                using (FileStream fs = File.Create(path))
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes(text);
                    fs.Write(info, 0, info.Length); // Add some information to the file.
                }

                /*// Open the stream and read it back.
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }*/
            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString(), "Error!");
            }
            
        }
    }
}

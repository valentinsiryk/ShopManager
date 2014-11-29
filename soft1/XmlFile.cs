using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Xml;
using System.Windows.Forms;

namespace soft1
{
    class XmlFile
    {
        public string getResponseFromServer(string req)
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
    }
}

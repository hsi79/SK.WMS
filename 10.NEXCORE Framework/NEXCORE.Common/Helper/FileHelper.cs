using System;
using System.Collections;
using System.Data;
using System.Text;
using System.Web;
using System.IO;

namespace NEXCORE.Common
{
    public static class FileHelper
    {
        #region File Read/Writ To/From Oracle DataBase (TFILE table)

        public static byte[] WriteFileToDB(string filePath, out int size)
        {
            FileStream fs = null;
            byte[] ImageData = null;
            size = 0;
            try
            {
                // provide read access to the file
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);

                // Create a byte array of file stream length
                ImageData = new byte[fs.Length];

                //Read block of bytes from stream into the byte array
                size = fs.Read(ImageData, 0, System.Convert.ToInt32(fs.Length));
            }
            catch { }
            finally
            {
                //Close the File Stream
                fs.Close();
            }
            return ImageData;
        }

        public static string ReadFileFromDB(int index, string saveFilePath, byte[] binValue)
        {
            string fileName = string.Empty;
            // Save the retrieved image to the DestinationLoc in the file system
            FileStream fs = null;
            try
            {
                // Create a byte array
                byte[] byteData = new byte[0];

                // fetch the value of Oracle parameter into the byte array - binValue

                // get the length of the byte array
                int ArraySize = new int();
                ArraySize = binValue.GetUpperBound(0);

                // Write the Blob data fetched from database to the filesystem at the
                // destination location
                fs = new FileStream(saveFilePath, FileMode.OpenOrCreate, FileAccess.Write);
                fs.Write(binValue, 0, ArraySize);
            }
            catch { }
            finally
            {
                fs.Close();
            }

            return fileName;
        }

        #endregion

    }
}
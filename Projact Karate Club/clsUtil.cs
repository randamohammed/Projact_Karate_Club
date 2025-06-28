using System;
using System.IO;
using System.Windows.Forms;
namespace DVLDSluotion
{
    public class clsUtil
    {
        private static bool CreateFolderIfDoesNotExist(string destFolderName)
        {
            if (!Directory.Exists(destFolderName))
            {
                try
                {

                    System.IO.Directory.CreateDirectory(destFolderName);
                    return true;
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Error creating folder: " + Ex.Message);
                    return false;
                }
            }
            return true;
        }

        private static string GenerateGUID()
        {
            Guid Newguid = new Guid();
            return Newguid.ToString();
        }

        private static string ReplaceFileNameWithGUID(string sourceFile)
        {
            FileInfo info = new FileInfo(sourceFile);
            string Extin = info.Extension;
            return GenerateGUID() + Extin;
        }

        public static bool CopyImageinFloder(ref string sourceFileName)
        {
            string destFolderName = @"D:\Pictures\Randa\Karate_Images\";
            string destFileName = destFolderName + ReplaceFileNameWithGUID(sourceFileName);

            if (!CreateFolderIfDoesNotExist(destFolderName))
            {
                return false;
            }
            else
            {
                try
                {
                    File.Copy(sourceFileName, destFileName, true);
                    sourceFileName = destFileName;
                    return true;
                }
                catch (Exception iox)
                {
                    MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }



            }

            return false;
        }
        public static bool CopyCertificateinFloder(ref string sourceFileName)
        {
            string destFolderName = @"D:\Pictures\Randa\Member_Certificate_Images\";
            string destFileName = destFolderName + ReplaceFileNameWithGUID(sourceFileName);

            if (!CreateFolderIfDoesNotExist(destFolderName))
            {
                return false;
            }
            else
            {
                try
                {
                    File.Copy(sourceFileName, destFileName, true);
                    sourceFileName = destFileName;
                    return true;
                }
                catch (Exception iox)
                {
                    MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }



            }

            return false;
        }
    }

}

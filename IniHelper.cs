using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace AfterburnerMonitor
{
    public class IniHelper
    {
        public string inipath;
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, bool val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        public IniHelper(string INIPath)
        {
            inipath = INIPath;
        }

        public void IniWriteValue(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, this.inipath);
        }

        public void IniWriteValue(string Section, string Key, bool boolValue)
        {
            WritePrivateProfileString(Section, Key, boolValue, this.inipath);
        }

        public string IniReadValue(string Section, string Key)
        {
            StringBuilder temp = new StringBuilder(500);
            int i = GetPrivateProfileString(Section, Key, "", temp, 500, this.inipath);
            return temp.ToString();
        }

        public bool ExistINIFile()
        {
            return File.Exists(inipath);
        }

        public List<string>fFileList(string srcPath)
        {
            List<string> fList = new List<string>();


            //Get a list of files in the source directory, which is an array containing files and directory paths
            string[] fileList = Directory.GetFiles(srcPath);
            foreach (string sItem in fileList)
            {
                if ("*.jpg *.bmp *.gif".IndexOf(sItem.Substring(sItem.Length - 3, 3)) > 0)
                {
                    fList.Add(sItem);
                }

            }

            return fList;
        }
    }
}

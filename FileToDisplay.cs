using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class FileToDisplay
    {
        private string dir;
        private string path;

        public string Dir
        {
            get { return dir; }
            set { dir = value; }
        }
        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        public FileToDisplay()
        {
            Dir = null;
            Path = null;
        }
        public FileToDisplay(string directory, string file)
        {
            Dir = directory;
            Path = file;
        }
    }
}

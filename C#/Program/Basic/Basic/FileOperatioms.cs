using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class FileOperatioms
    {
        public FileOperatioms()
        {
          
        }

        public void create()
        {
            FileInfo fi = new FileInfo("F:\\kanini\\C#\\Program\\Basic\\sample.txt");
            using StreamWriter str = fi.CreateText();
            Console.WriteLine("File has been created");
            str.WriteLine("hi");
        }
        public void Delete()
        {
            FileInfo fi = new FileInfo("F:\\kanini\\C#\\Program\\Basic\\sample.txt");
           fi.Delete();
        }
        public void CopyMoveFile() {
            FileInfo fi = new FileInfo("F:\\kanini\\C#\\Program\\Basic\\sample.txt");
            fi.CopyTo("F:\\kanini\\C#\\Program\\Basic\\tem\\sample.txt");
                }
        public void Move()
        {
            FileInfo fi = new FileInfo("F:\\kanini\\C#\\Program\\Basic\\sample.txt");
            fi.MoveTo("F:\\kanini\\C#\\Program\\Basic\\tem1\\sample.txt");
        }
        public void FileProperties()
        {
            FileInfo fi = new FileInfo("F:\\kanini\\C#\\Program\\Basic\\sample.txt");
            Console.WriteLine(fi. Name);
            Console.WriteLine(fi.CreationTime);
            Console.WriteLine(fi.LastAccessTime);   
            Console.WriteLine(fi.LastWriteTime);
           Console.WriteLine(fi.Exists);
            Console.WriteLine(fi.Extension);
            Console.WriteLine(fi.Attributes);

        }

    }

}

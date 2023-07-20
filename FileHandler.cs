using System;
namespace _20JulyIDisposableEx1
{
    public class FileHandler : IDisposable
    {
        File fileObject = null;
        static int totalFiles = 0;
        bool disposedvalue;
        public FileHandler(string fileName)
        {
            if(fileObject == null)
            {
                totalFiles++;
                fileObject = new File(fileName);
            }
            Console.WriteLine("File Created");
            Console.WriteLine("Number of files are:"+totalFiles);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposedvalue)
            {
                if(disposing)
                { totalFiles = 0; }
            }
            Console.WriteLine("File {0} has been disposed",fileObject.Name);
            fileObject = null;
            disposedvalue = true;
        } 
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        public void GetFileDetails()
        {
            Console.WriteLine(fileObject.Name+"file has been created Successfully");
        }
        FileHandler()
        {
            Dispose(false);
        }
    }
}

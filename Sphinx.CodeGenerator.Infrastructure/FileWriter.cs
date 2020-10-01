using System;
using System.IO;

namespace Sphinx.CodeGenerator.Infrastructure
{
    public class FileWriter
    {
        
        public void WriteFileToPath(string path,string name, string content)
        {
            var pathName = path +"/"+ name;
            using (StreamWriter sw = File.CreateText(pathName))
            {
                sw.Write(content);
                sw.Close();
            }
        }
    }
}
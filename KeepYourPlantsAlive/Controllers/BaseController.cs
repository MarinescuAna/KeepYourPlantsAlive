using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepYourPlantsAlive.Controllers
{
    public class BaseController
    {
        private StreamReader _streamReader;
        private StreamWriter _streamWriter;
        protected List<string> ReadFromFileByPath(string filePath)
        {
            try
            {
                _streamReader = new StreamReader(filePath);
                var lines = new List<string>();
                var line = string.Empty;
                while ((line = _streamReader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
                return lines;
            }
            catch (Exception ex)
            {
                return new List<string>();
            }
            finally
            {
                _streamReader.Close();
            }
        }

        protected void WriteLine(string content, string filePath)
        {
            try
            {
                _streamWriter = new StreamWriter(filePath, append: true);
                _streamWriter.WriteLine(content);
            }
            finally
            {
                _streamWriter.Close();
            }
        }

    }
}

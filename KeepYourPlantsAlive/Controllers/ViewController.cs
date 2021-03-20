using KeepYourPlantsAlive.Common;
using KeepYourPlantsAlive.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepYourPlantsAlive.Controllers
{
    public class ViewController:BaseController
    {
        private readonly string _flowerName;
        public ViewController(string flowerName)
        {
            _flowerName = flowerName;
        }
        public List<string> ReadWaterDates()
        {
            return ReadFromFileByPath(FilePaths.WaterDatesPath+_flowerName+ConstString.Txt);
        }
        public List<Entry> ReadValues()
        {
            var lines = ReadFromFileByPath(FilePaths.ValuesReadPath + _flowerName + ConstString.Txt);
            List<Entry> entries = new List<Entry>();

            foreach(var line in lines)
            {
                var splitResult = line.Split('#');
                entries.Add(new Entry { 
                    DateTime=DateTime.Parse(splitResult[0]),
                    Min=int.Parse(splitResult[1]),
                    Max= int.Parse(splitResult[2])
                });
            }

            return entries;
        }
        public void WriteValueWater()
        {
            WriteLine(DateTime.Now.ToString().Split(' ')[0], FilePaths.WaterDatesPath + _flowerName + ConstString.Txt);
        }
        public void WriteValue(string min, string max)
        {
            WriteLine(DateTime.Now+"#"+min+"#"+max
                , FilePaths.ValuesReadPath + _flowerName + ConstString.Txt);
        }
    }
}

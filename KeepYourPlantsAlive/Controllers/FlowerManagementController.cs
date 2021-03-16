using KeepYourPlantsAlive.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepYourPlantsAlive.Controllers
{
    public class FlowerManagementController: BaseController
    {
        public bool AddNewFlower(string content)
        {
            var flowers = ReadFromFileByPath(FilePaths.FlowersNamePath);
            if(flowers.Count > 0)
            {
                if (flowers.Exists(u => u.Equals(content)))
                {
                    return false;
                }
            }

            WriteLine(content, FilePaths.FlowersNamePath);
            return true;
        }
    }
}

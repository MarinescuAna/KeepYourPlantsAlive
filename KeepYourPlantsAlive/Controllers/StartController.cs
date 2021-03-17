using KeepYourPlantsAlive.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepYourPlantsAlive.Controllers
{
    public class StartController:BaseController
    {
        public List<string> ReadFlowerNames()
        {
            return ReadFromFileByPath(FilePaths.FlowersNamePath);
        }
    }
}

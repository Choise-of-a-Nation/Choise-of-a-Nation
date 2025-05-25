using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Clasess.Profile
{
    [Serializable]
    public class Achievements
    {
        public int Id;
        public string Name;
        public string NameEng;
        public string Description;
        public string DescriptionEng;
        public string IconUrl;
        public bool isOk = false;
    }
}

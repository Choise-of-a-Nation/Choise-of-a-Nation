﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Clasess.Chois
{
    [Serializable]
    public class ElementChoise
    {
        public int Id;
        public string Name;
        public List<Parametrs> Result = new List<Parametrs>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm
{
    public class Campo
    {
        public int numero {get; set;}
        public string iso {get; set;}
		public string gantry { get; set; }
        public string col { get; set; }
		public int X { get; set; }
        public int Y { get; set; }
        public int X1 { get; set; }
        public int X2 { get; set; }
        public int Y1 { get; set; }
        public int Y2 { get; set; }
        public string camilla {get; set;}
        public string WDG { get; set; }
        public string WDG_ori { get; set; }
        public string SldFile { get; set; }
        public Double TrayFactor { get; set; }
        public Double MU { get; set; }
        public Double Weight { get; set; }
        public Double SSD { get; set; }    }
}
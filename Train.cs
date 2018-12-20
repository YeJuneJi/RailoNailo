using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailoNailo
{
    class Train
    {
        private int adultcharge;
        private string arrplacename;
        private string arrplandtime;
        private string depplacename;
        private string depplandtime;
        private string traingradename;

        public int Adultcharge { get => adultcharge; set => adultcharge = value; }
        public string Arrplacename { get => arrplacename; set => arrplacename = value; }
        public string Arrplandtime { get => arrplandtime; set => arrplandtime = value; }
        public string Depplacename { get => depplacename; set => depplacename = value; }
        public string Depplandtime { get => depplandtime; set => depplandtime = value; }
        public string Traingradename { get => traingradename; set => traingradename = value; }
    }
}

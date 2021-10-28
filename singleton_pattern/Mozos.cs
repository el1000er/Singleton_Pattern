using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton_pattern
{
    public class Mozos
    {
        private List<string> mozos = new List<string>();
        private int proximoMozo = 0;
        public Mozos()
        {
            mozos.Add("Tim");
            mozos.Add("Sue");
            mozos.Add("Alan");
            mozos.Add("Mary");
        }

        public string ProximoMozo()
        {
            string output = mozos[proximoMozo];
            proximoMozo += 1;
            if (proximoMozo >= mozos.Count)
            {
                proximoMozo = 0;
            }
            return output;
        }

    }
}

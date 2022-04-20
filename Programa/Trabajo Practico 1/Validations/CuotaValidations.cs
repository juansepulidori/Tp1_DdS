using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    internal class CuotaValidations
    {
        public bool ValidarMonto(float m1, float m2)
        {
            if (m1 < 1 || m2 < 1) return true;
            return false;

        }
    }
}

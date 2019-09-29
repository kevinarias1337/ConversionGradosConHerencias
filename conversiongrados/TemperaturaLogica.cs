using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversiongrados
{
    class TemperaturaLogica :Conversion
    {
        public double convertirFarenheit()
        {
            return (this.getGrados() * 9 / 5 + 32);
        }

        public double convertirCelcius()
        {
            return (this.getGrados() - 32) * 5 / 9;
        }
    }
}

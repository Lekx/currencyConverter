using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace currencyConverter
{
    class tipoCambio
    {


        public double conversionPesoADolar(string peso, string cambio) 
        {
            DialogResult mensaje;
            double pesoConvertido;
            double cambioConvertido;

            

            if (peso != "" && cambio != "")
            {
                if (peso != "0" && cambio != "0")
                {
                    if (Double.TryParse(peso, out pesoConvertido) && Double.TryParse(cambio, out cambioConvertido))
                    {
                        return pesoConvertido / cambioConvertido;
                    }
                    else
                    {
                        mensaje = MessageBox.Show("Oops! Solo se aceptan valores numericos.");
                        return 0;
                    }
                }
                else
                {
                       
                    mensaje = MessageBox.Show("Oops! Ninguno de los campos puede ser 0.");
                    return 0;
                }
            }
            else
            {
                mensaje = MessageBox.Show("Oops! Ninguno de los campos pueden estar vacios.");
                return 0;
            }
       
        }
    }
}


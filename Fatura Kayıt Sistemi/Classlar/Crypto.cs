using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs_Programı
{
    class Crypto
    {
       
        public  string Encrypt(long input_)
        {
            string  output = "";
            try
            {
               
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return output;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rationnel
{
    public struct SRationnel
    {
        private readonly int denominateur;
        private readonly int numerateur;

        public override string ToString()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                if (denominateur < 0)
                {
                    sb.AppendFormat("{0}", -numerateur);
                    sb.Append("/");
                    sb.AppendFormat("{0}", -denominateur);
                }
                else
                {
                    sb.AppendFormat("{0}", numerateur);
                    sb.Append("/");

                    sb.AppendFormat("{0}", denominateur);
                }
                

                return (sb.ToString());
            }
            catch (Exception e)
            {
                throw e;
            }




        }
        public SRationnel(int d, int n)
        {
            numerateur = n;
            if (d == 0)
                throw new Exception("impossible d'avoir un dénominateur nul");
            denominateur = d;

            

        }

        public static explicit operator double(SRationnel sRationnel)
        {
            return Convert.ToDouble(((double)sRationnel));
        }

        public static implicit operator SRationnel(int i)
        {
            return new SRationnel();
        }
    }

    
   
}

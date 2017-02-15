using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop1
{
    class Dice
    {
        private int faceup;
        public Dice()
        {
            Throw();
        }

        public int Faceup
        {
            get
            {
                return faceup;
            }


        }
        Random random = new Random();
        public void Throw()
        {
            faceup = random.Next(1, 6);
        }

        public String StrFace
        {
            get
                { 
            return Faceup.ToString();
            }

        }

    

    }
}

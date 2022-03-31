using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNorVida
{
    class Calculations
    {
        //method to calculate VRAC
        public void CalculerVrac()
        {
            float mVRAC;
            float mcv1 ;
            float mce1 ;
            float vc1 ;

            mcv1 = Globals.mcv1;
            mce1 = Globals.mce1;
            vc1 = Globals.vc1;

            mVRAC = (mce1 - mcv1) / vc1;
            Globals.mVrac = mVRAC;

     
        }

     

    }
}

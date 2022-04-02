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
            float moyenneVrac;

            float mVRAC1;
            float mcv1 ;
            float mce1 ;
            float vc1 ;

            float mVRAC2;
            float mcv2;
            float mce2;
            float vc2;

            float mVRAC3;
            float mcv3;
            float mce3;
            float vc3;

            mcv1 = Globals.mcv1;
            mce1 = Globals.mce1;
            vc1 = Globals.vc1;

            mcv2 = Globals.mcv2;
            mce2 = Globals.mce2;
            vc2 = Globals.vc2;

            mcv3 = Globals.mcv3;
            mce3 = Globals.mce3;
            vc3 = Globals.vc3;

            mVRAC1 = (mce1 - mcv1) / vc1;
            Globals.vrac1 = mVRAC1;

            mVRAC2 = (mce2 - mcv2) / vc2;
            Globals.vrac2 = mVRAC2;

            mVRAC3 = (mce3 - mcv3) / vc3;
            Globals.vrac3 = mVRAC3;

            //method to calculate MoyenneVrac

            moyenneVrac = (mVRAC1 + mVRAC2 + mVRAC3) / 3;
            Globals.mVrac = moyenneVrac;


        }

        //method to calculate porosité
        public void CalculerPorosite()
        {
            float moyennePoro;


            float moyenneVrac;
            moyenneVrac = Globals.mVrac;


            float mvreelle1;
            float mvreelle2;
            float mvreelle3;

            float pi1;
            float pi2;
            float pi3;

            mvreelle1 = Globals.mvreelle1;
            mvreelle2 = Globals.mvreelle2;
            mvreelle3 = Globals.mvreelle3;

            pi1 = ((mvreelle1 - moyenneVrac) / mvreelle1)  *  100;
            Globals.pi1 = pi1;

            pi2 = ((mvreelle2 - moyenneVrac) / mvreelle2) * 100;
            Globals.pi2 = pi2;

            pi3 = ((mvreelle3 - moyenneVrac) / mvreelle3) * 100;
            Globals.pi3 = pi3;

            //method to calculate MoyenneVrac

            moyennePoro = (pi1 + pi2 + pi3) / 3;
            Globals.mporosite = moyennePoro;

        }
     

    }
}

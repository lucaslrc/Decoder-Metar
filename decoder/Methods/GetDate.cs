using System;

namespace Decoder.Methods
{
    public class GetDate
    {
        public string[] GetDateMetar(string Metar)
        {
            //2019112211 - METAR SBKP 221100Z 05005KT CAVOK 25/16 Q1015=
            Console.WriteLine(Metar.Substring(0, 4).ToCharArray());

            

            return null;
        }
    }
}
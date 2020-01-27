using System;
using System.Text;

namespace Decoder.Methods
{
    public class DecoderMetar
    {
        private GetDate          Date           = new GetDate();
        private GetType          Type           = new GetType();
        private GetHour          Hour           = new GetHour();
        private GetTemperature   Temperature    = new GetTemperature();
        private GetDewPoint      DewPoint       = new GetDewPoint();
        private GetPression      Pression       = new GetPression();
        private GetVisibility    Visibility     = new GetVisibility();
        private GetWindDirection WindDirection  = new GetWindDirection();
        private GetWindSpeed     WindSpeed      = new GetWindSpeed();
        private GetWeather       Weather        = new GetWeather();

        public string Decoder(string Metar)
        {
            //2019112517 - METAR SBBR 251700Z 26007KT 8000 -RA VCTS FEW010 BKN030 FEW035CB BKN100 20/19 Q1016=

            //Removing White Spaces of string.
            string  LineMetar = Metar.Replace(" ", "");
            //2019112517-METARSBBR251700Z26007KT8000-RAVCTSFEW010BKN030FEW035CBBKN10020/19Q1016=

            string  CutDateCode = LineMetar.Substring(0, 10),
                    CutTypeCode = LineMetar.Substring(LineMetar.IndexOf(CutDateCode.Substring(9)), 7);
                    // CutIcaoCode = LineMetar.Substring(LineMetar.IndexOf(CutTypeCode.Substring(4)), 6).Replace(CutTypeCode.Substring(4), string.Empty),
                    // CutHourCode = LineMetar.Substring(LineMetar.IndexOf(CutIcaoCode.Substring(3)), 8).Replace(CutIcaoCode.Substring(3), string.Empty),
                    // CutWindCode = LineMetar.Substring(LineMetar.IndexOf(CutHourCode.Substring(3)), 17).Replace(CutHourCode.Substring(3), string.Empty);
                    // CutPrecipitationCode = LineMetar.Substring(LineMetar.IndexOf(CutHourCode.Substring(0)));
            return $"{CutDateCode}\n{CutTypeCode}\n";
        }
    }
}
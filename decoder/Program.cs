using System;
using Decoder.Methods;
using System.Globalization;

namespace Decoder
{
    class Program
    {
        static void Main(string[] args)
        {
            DecoderMetar Decoder = new DecoderMetar();
            // string Input = string.Empty;

            // Console.WriteLine("Hello! Insert a METAR code for decoder (without whitespaces):\n");

            // Input = Console.ReadLine();

            Console.WriteLine(Decoder.Decoder("2019112517 - METAR SBBR 251700Z 26007KT 8000 -RA VCTS FEW010 BKN030 FEW035CB BKN100 20/19 Q1016="));
        }
    }
}

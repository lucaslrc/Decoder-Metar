using Decoder.Models;
using System.Collections.Generic;

namespace Decoder.Helpers
{
    public class ListTypeMetars
    {
        public List<TypeModel> Type = new List<TypeModel>() 
        {
            new TypeModel { TagMetar = "METAR" },
            new TypeModel { TagMetar = "SPECI" },
            new TypeModel { TagMetar = "COR" }
        };
    }
}
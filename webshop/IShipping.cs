using System.Collections.Generic;

namespace HemtentaTdd2017.webshop
{
    public interface IShipping
    { 
        // double Height { get; set; }
        // double Length { get; set; }
        // double Weight { get; set; }
        decimal TotalCost { get; }
        bool ShipsTo(string country);
    }
}
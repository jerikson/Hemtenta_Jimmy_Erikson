using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemtentaTdd2017.webshop
{
    public class Shipping : IShipping 
    {
        public decimal TotalCost => _shippingCost + _vat;
        private decimal _vat = 0;
        private decimal _shippingCost { get; set; }

        public bool ShipsTo(string country)
        {
            if (!string.IsNullOrWhiteSpace(country))
            {
                country = country.ToLower();
                if (!Supported.Keys.Contains(country)) return false;
                _shippingCost = Supported[country];
                return true;
            }
            throw new Exception("Selected country is null or whitespace");
        }

        public readonly Dictionary<string, int> Supported = new Dictionary<string, int>
        {
            {"sweden", 100},
            {"denmark", 135},
            {"norway", 240},
            {"finland", 680}
        };
    }
}

//List<string> isoNames = new List<string>();
//List<string> currencies = new List<string>();
//var regions = CultureInfo.GetCultures(CultureTypes.SpecificCultures).Select(x => new RegionInfo(x.LCID));
//var asd = regions.FirstOrDefault(region => region.EnglishName.Contains(country));
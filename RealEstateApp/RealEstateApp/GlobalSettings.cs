using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp
{
    public class GlobalSettings
    {
        public static GlobalSettings Instance { get; } = new GlobalSettings();

        public string ImageBaseUrl => "https://dbroadfootpluralsight.blob.core.windows.net/files/";
        public string NoImageUrl => ImageBaseUrl + "no_image.jpg";
    }
}

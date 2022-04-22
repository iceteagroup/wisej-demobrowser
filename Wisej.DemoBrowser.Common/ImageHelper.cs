using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wisej.DemoBrowser.Common
{
    public static class ImageHelper
    {
        private static Random Random = new Random();
        
        public static string PEOPLE_PATH = "resource.wx/Wisej.DemoBrowser.Common/Images/People/";

        public static string GetRandomPerson()
        {
            return Path.Combine(PEOPLE_PATH, $"{Random.Next(1, 25)}.jpg");
        }
    }
}

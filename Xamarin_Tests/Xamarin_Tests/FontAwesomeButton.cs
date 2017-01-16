using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin_Tests
{
    public class FontAwesomeButton : Button
    {
        public FontAwesomeButton()
        {
            FontFamily = Device.OnPlatform(null, "FontAwesome", "/Assets/Fonts/fontawesome-webfont.ttf#FontAwesome");

        }
    }
}

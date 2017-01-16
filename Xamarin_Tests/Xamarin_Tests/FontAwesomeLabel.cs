using Xamarin.Forms;

namespace Xamarin_Tests
{
    //https://www.devdashboard.com/280/using-font-icons-for-xamarin-forms
    public class FontAwesomeLabel : Label
    {
        public FontAwesomeLabel()
        {
            FontFamily = Device.OnPlatform(null, "FontAwesome", "/Assets/Fonts/fontawesome-webfont.ttf#FontAwesome");
        }
    }
}

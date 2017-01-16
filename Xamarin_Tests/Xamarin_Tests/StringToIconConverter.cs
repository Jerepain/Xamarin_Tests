//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Xamarin.Forms;

//namespace Xamarin_Tests
//{
//    public class StringToIconConverter : IValueConverter
//    {
//        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
//        {
//            string result;
//            return IconsDictionary.TryGetValue(value, out result);
//        }

//        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
//        {
//            throw new NotImplementedException();
//        }

//        public enum Icons
//        {
//            Corbeille,

//        }


//        public Dictionary<Icons, string> IconsDictionary = new Dictionary<Icons, string>
//        {
//            {Icons.Corbeille, FontAwesomeIcon.FaTrash.ToString()}
//    }
//        }
//    }
//}

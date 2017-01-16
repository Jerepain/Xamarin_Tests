using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Xamarin_Tests
{
   public  class MainViewModel
    {
        public string Image { get; set; }
        public ICommand LabelCommand { get; set; }

        public MainViewModel()
        {
            Image = FontAwesomeIcon.FaTrash.ToString();
            LabelCommand = new Command(test);
        }

        private void test()
        {
    
        }
    }
}

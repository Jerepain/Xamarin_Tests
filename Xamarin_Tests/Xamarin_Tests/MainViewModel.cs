using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Prism.Mvvm;
using Xamarin.Forms;

namespace Xamarin_Tests
{
    public class MainViewModel : BindableBase
    {
        private ImageSource _photo;
        public string Image { get; set; }

        public ImageSource Photo
        {
            get
            {
                return _photo;
            }
            set
            {

                SetProperty(ref _photo, value);
            }
        }

        public ICommand LabelCommand { get; set; }

        public MainViewModel()
        {
            Image = FontAwesomeIcon.FaTrash.ToString();

            LabelCommand = new Command(async () => await test());

        }

        private async Task test()
        {
            await CrossMedia.Current.Initialize();
            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported) return;

            var options = new StoreCameraMediaOptions()
            {
                Directory = "Sample",
                Name = "test.jpg",

            };


            var file = await CrossMedia.Current.TakePhotoAsync(options);
            if (file == null)
                return;


            Photo = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                file.Dispose();
                return stream;
            });
        }
    }
}

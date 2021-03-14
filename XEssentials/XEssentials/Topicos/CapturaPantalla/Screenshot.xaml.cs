using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XEssentials.Topicos.CapturaPantalla
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Screenshot : ContentPage
    {
        public Screenshot()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            var screenshot = await Xamarin.Essentials.Screenshot.CaptureAsync();
            var stream = await screenshot.OpenReadAsync();

            ImageScreenshot.Source = ImageSource.FromStream(() => stream);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XEssentials.Topicos.FilePicker
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FilePicker : ContentPage
    {
        public FilePicker()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                // Also we can select the type of file tha we allow.
                // See the documentation.
                //var file2 = await Xamarin.Essentials.FilePicker.PickAsync(
                //    new Xamarin.Essentials.PickOptions
                //    {
                //        FileTypes = new Xamarin.Essentials.FilePickerFileType()
                //    }); ;

                var file = await Xamarin.Essentials.FilePicker.PickAsync();
                if (file == null)
                    return;

                LabelFile.Text = file.FileName;
            }
            catch (Exception exc)
            {
                
            }
        }
    }
}
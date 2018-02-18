using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyListApp_5
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
            //BindingContext = new ContentPageViewModel();
        }

        private void myButton_Clicked(object sender, EventArgs e)
        {
            myLabel.Text = myEntry.Text;
        }
    }

    
    
}

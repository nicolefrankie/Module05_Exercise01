using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Module05_Exercise01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void OpenExercise01_Entry(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Exercise01_Entry());
        }
        private async void OpenExercise01_Picker(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Exercie01_Picker());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileTest3 {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddAlarm : ContentPage {
        public TimeSpan time;

        public AddAlarm() {
            InitializeComponent();
        }

        private async void OnButtonClick(object sender, EventArgs e) {
            time = timePicker.Time;
            await Navigation.PopModalAsync();
        }
    }
}
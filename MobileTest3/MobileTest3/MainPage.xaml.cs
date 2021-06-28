using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileTest3 {
    public partial class MainPage : ContentPage {
        ObservableCollection<Time> alarms;
        AddAlarm addAlarmPage;

        public MainPage() {
            InitializeComponent();

            alarms = new ObservableCollection<Time>();
            AlarmView.ItemsSource = alarms;
        }
        
        public ObservableCollection<Time> Alarms { get { return alarms; } }

        private async void OnButtonClick(object sender, EventArgs e) {
            Application.Current.ModalPopping += HandleModalPopping;
            addAlarmPage = new AddAlarm();
            await Navigation.PushModalAsync(addAlarmPage);
        }

        private void HandleModalPopping(object sender, ModalPoppingEventArgs e) {
            if (e.Modal == addAlarmPage) {
                var time = addAlarmPage.time;

                alarms.Add(new Time { time = time });

                addAlarmPage = null;
                Application.Current.ModalPopping -= HandleModalPopping;
            }
        }
    }
}


using System;
using Xamarin.Forms;

namespace XamlClockPage
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //Device.StartTimer lo usamos para disparar un evento periodico
            //que en este caso, es para actualizar la hora y fecha
            Device.StartTimer(TimeSpan.FromSeconds(1), OnTimerTick);
        }

        bool OnTimerTick()
        {
            //Iniciamos la variable de tiempo
            DateTime dt = DateTime.Now;
            //asignamos al texto el Tiempo(T) y Fecha (D)
            //usamos ToString() para pasarlo a String
            timeLabel.Text = dt.ToString("T");
            dateLabel.Text = dt.ToString("D");
            return true;
        }
    }
}

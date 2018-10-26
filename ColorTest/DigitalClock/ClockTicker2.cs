using System;
using System.Windows.Threading;
using System.ComponentModel;



namespace DigitalClock
{
    class ClockTicker2 : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public DateTime DateTime
        {
            get { return DateTime.Now; }
        }

        public ClockTicker2()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += TimerOnTick;
            timer.Interval = TimeSpan.FromSeconds(0.1);
            timer.Start();
        }

        void TimerOnTick(object sender, EventArgs e)
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DateTime"));

        }
    }
}

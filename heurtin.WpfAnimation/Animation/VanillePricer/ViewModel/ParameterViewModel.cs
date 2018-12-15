using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace heurtin.WpfAnimation.Animation.VanillePricer.ViewModel
{
    public class ParameterViewModel : INotifyPropertyChanged
    {


        private double _strike;
        private double _stock;
        private int _day;
        private double _vol;
        private double _interestRate;

        public double Strike
        {
            get { return _strike; }
            set
            {
                _strike = value;
                NotifyPropertyChanged();
            }
        }

        public double Stock
        {
            get { return _stock; }
            set
            {
                _stock = value;
                NotifyPropertyChanged();
            }
        }
        public int Day
        {
            get { return _day; }
            set
            {
                _day = value;
                NotifyPropertyChanged();
            }
        }
        public double Vol
        {
            get { return _vol; }
            set
            {
                _vol = value;
                NotifyPropertyChanged();
            }
        }
        public double InterestRate
        {
            get { return _interestRate; }
            set
            {
                _interestRate = value;
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

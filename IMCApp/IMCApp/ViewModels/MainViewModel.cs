using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace IMCApp.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private double _height;

        public double Height
        {
            get { return _height; }
            set { SetProperty(ref _height, value); }
        }

        private double _weight;

        public double Weight
        {
            get { return _weight; }
            set { SetProperty(ref _weight, value); }
        }

        private string _result;
        public string Result
        {
            get { return _result; }
            set { SetProperty(ref _result, value); }
        }

        public ICommand CalculateCommand { get; private set; }

        public MainViewModel()
        {
            Height = 0;
            Weight = 0;

            CalculateCommand = new Command(Calculate);
        }

        void Calculate()
        {
            if (Height == 0 || Height == null || Weight == 0 || Weight == null)
            {
                Result = null;
            }
            else
            {
                Result = (Weight / (Height * Height)).ToString();
            }
        }
    }
}

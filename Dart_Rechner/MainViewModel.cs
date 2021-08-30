using System;
using System.Windows;
using System.Xml.Xsl;

namespace Dart_Rechner
{
    public class MainViewModel : ViewModelBase
    {
        private String _buttonText;

        public string ButtonText
        {
            get { return _buttonText; }
            set 
            { 
                SetProperty<string>(ref _buttonText, value, nameof(ButtonText));
            }
        }        

        private DelegateCommand _startCalculatorCommand;

        public DelegateCommand StartCalculatorCommand
        {
            get
            {
                return _startCalculatorCommand ??= new DelegateCommand(StartCalculator);
            }
        }

        public MainViewModel()
        {
            _buttonText = "Hallo";
        }

        private void StartCalculator(object viewModel)
        {
            Settings win = new Settings();
            win.Show();
            

        }
    }
}

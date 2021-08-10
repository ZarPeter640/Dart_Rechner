using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Dart_Rechner
{
    public class MainViewModel : ViewModelBase
    {
        private String _buttonText;

        public string ButtonText
        {
            get { return _buttonText; }
            set { 
                SetProperty<string>(ref _buttonText, value, nameof(ButtonText));
            }
        }
        //public ICommand StartCalculatorCommand { get; }

        

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
            //_startCalculator = new DelegateCommand(StartCalculator);
            _buttonText = "Hallo";
        }

        private void StartCalculator(object commandParameter)
        {
            ButtonText = "Huhu";
        }
    }
}

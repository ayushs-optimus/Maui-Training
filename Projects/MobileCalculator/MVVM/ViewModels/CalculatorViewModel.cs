using Dangl.Calculator;
using System.ComponentModel;
using System.Windows.Input;

namespace MobileCalculator.MVVM.ViewModels;

public class CalculatorViewModel : INotifyPropertyChanged
{
    public string Result {
        get
        {
            return _result;
        }
        set
        {
            _result = value;
            PropertyChanged!.Invoke(this, new PropertyChangedEventArgs(nameof(Result)));
        }
    } 
    public string Formula { 
        get
        {
            return _formula;
        }
        set
        {
            _formula = value;
            PropertyChanged!.Invoke(this,new PropertyChangedEventArgs(nameof(Formula)));
        }
    }
    private string _formula = string.Empty;
    private string _result = "0";
    public ICommand OperationalCommand => new Command((number) => { Formula += (string)number; });
    public ICommand ResetCommand => new Command(() =>
    {
        Result = "0";
        Formula = "";
    });

    public ICommand BackspaceCommand => new Command(() =>
    {
        if (_formula.Length > 0)
        {
            Formula = Formula.Substring(0, Formula.Length - 1);
        }
    });

    public ICommand CalculateCommand => new Command(() =>
    {
        if(_formula.Length > 0)
        {
            var calculator = Calculator.Calculate(Formula);
            Result = calculator.Result.ToString();
        }
    });
    public event PropertyChangedEventHandler? PropertyChanged;
}

using PropertyChanged;
using System.Collections.ObjectModel;
using System.Transactions;
using System.Windows.Input;
using UnitsNet;

namespace MAUIVerter.MVVM.ViewModels;

[AddINotifyPropertyChangedInterface]
public class ConverterViewModel
{
    public string Quantitys { get; set; } = string.Empty;
    public ObservableCollection<string>? FromMeasure { get; set; }
    public ObservableCollection<string>? ToMeasure { get; set; }
    
    public string FromCurrentMeasure { get; set; }
    public string ToCurrentMeasure { get; set; }
    public int FromCurrentMeasureIndex { get; set; } = 0;
    public int ToCurrentMeasureIndex { get; set; } = 0;
    public double FromValue { get; set; } = 1;
    public double ToValue { get; set; }

    ICommand ReturnCommand => new Command(() =>
    {
        Convert();
    });

    public ConverterViewModel(string element)
    {
        Quantitys = element;
        FromMeasure = LoadMeasure();
        ToMeasure = LoadMeasure();
        FromCurrentMeasure = FromMeasure.FirstOrDefault();
        ToCurrentMeasure = ToMeasure.Skip(1).FirstOrDefault();
        Convert();
    }
    public void Convert()
    {
        FromCurrentMeasure = FromMeasure[FromCurrentMeasureIndex];
        ToCurrentMeasure = ToMeasure[ToCurrentMeasureIndex];
        var result = UnitConverter.ConvertByName(FromValue, Quantitys, FromCurrentMeasure, ToCurrentMeasure);
        ToValue = result;

    }
    private ObservableCollection<string> LoadMeasure()
    {
        var types = Quantity.Infos.FirstOrDefault(x => x.Name == Quantitys).UnitInfos.Select(x => x.Name).ToList();
        return new ObservableCollection<string>(types);
    }
}

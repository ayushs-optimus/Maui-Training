using BMI_Calculator.MVVM.Models;

namespace BMI_Calculator.MVVM.ViewModel;

public class BMIViewModel
{
    public BMI BMI { get; set; }
    public BMIViewModel()
    {
        BMI = new BMI
        {
            Height = 180,
            Weight = 70
        };
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppTutorial2.Services
{
    public class ConvertDoubleToColor : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            double nota = (double)value!;
            return nota <= 6.9 ? Color.FromRgb(255, 0, 0) : Color.FromRgba(0, 38, 255, 255); 
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

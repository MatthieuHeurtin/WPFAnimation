using heurtin.WpfAnimation.Animation.CruveDrawer;
using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace heurtin.WpfAnimation.Animation.CurveDawer.Converter
{
    [ValueConversion(typeof(double[]), typeof(PointCollection))]
    public class DoubleArrayToPointsConverter : IValueConverter
    {


        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            ObservableCollection<double> values = value as ObservableCollection<double>;
            
            PointCollection points = new PointCollection(values.Count);
            for (int i = 0; i < values.Count; i++)
            {
                double x = (i * CurveDrawer.Scale)  + CurveDrawer.Scale ;
                double y = (values[i] * CurveDrawer.Scale) + CurveDrawer.Scale;
                points.Add(new Point(x,-y));
            }
            return points;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

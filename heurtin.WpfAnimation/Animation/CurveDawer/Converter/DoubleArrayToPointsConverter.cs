using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace heurtin.WpfAnimation.Animation.CurveDawer.Converter
{
    [ValueConversion(typeof(double[]), typeof(PointCollection))]
    public class DoubleArrayToPointsConverter : IValueConverter
    {

        private double _scale = 1;

        public double Scale
        {
            get { return _scale; }
            set { _scale = value; }
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double[] values = value as double[];
            if (values == null)
            {
                throw new ArgumentException("value", "Must be double[]");
            }

            PointCollection points = new PointCollection(values.Length);
            for (int i = 0; i < values.Length; ++i)
            {
                double x = i * 100 / values.Length;
                double y = values[i] * Scale ;
                points.Add(new Point(x, y));
            }

            return points;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

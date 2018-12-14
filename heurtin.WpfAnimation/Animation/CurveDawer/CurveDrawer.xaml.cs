using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace heurtin.WpfAnimation.Animation.CruveDrawer
{
    /// <summary>
    /// Interaction logic for CurveDrawer.xaml
    /// </summary>
    public partial class CurveDrawer : Window, IAnimation
    {

        public static string GetComment()
        {
            return "A Simple program to draw curves";
        }

        public double[] Output { get; set; }


        public CurveDrawer()
        {
            InitializeComponent();

            DataContext = this;

            int size = 100;
            Output = new double[size];
            for (int i =0; i< size; i++)
            {
                Output[i] = 2 * i;
            }
        }


        // Draw a simple graph.
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            DrawY();
            DrawX();

        }

        private void DrawY()
        {
            const double margin = 2;
            double xmin = margin;
            double xmax = myCan.Width - margin;
            double ymin = margin;
            double ymax = myCan.Height - margin;
            const double step = 10;


            var YLine = new LineGeometry(new Point(xmin, ymin), new Point(xmin, ymax));

            GeometryGroup YAxisGeo = new GeometryGroup();
            YAxisGeo.Children.Add(YLine);


            for (double x = xmin + step;
                x <= myCan.Width - step; x += step)
            {
                YAxisGeo.Children.Add(new LineGeometry(
                    new Point(x, ymax - margin / 2),
                    new Point(x, ymax + margin / 2)));
            }

            Path YAxis = new Path();
            YAxis.StrokeThickness = 1;
            YAxis.Stroke = Brushes.Black;
            YAxis.Data = YAxisGeo;

            myCan.Children.Add(YAxis);
        }


        private void DrawX()
        {
            const double margin = 2;
            double xmin = margin;
            double xmax = myCan.Width - margin;
            double ymin = margin;
            double ymax = myCan.Height - margin;
            const double step = 10;


            var YLine = new LineGeometry(new Point(xmin, ymin), new Point(xmax, ymin));

            GeometryGroup YAxisGeo = new GeometryGroup();
            YAxisGeo.Children.Add(YLine);


            for (double y = step; y <= myCan.Height - step; y += step)
            {
                YAxisGeo.Children.Add(new LineGeometry(
                    new Point(xmin - margin / 2, y),
                    new Point(xmin + margin / 2, y)));
            }

            Path YAxis = new Path();
            YAxis.StrokeThickness = 1;
            YAxis.Stroke = Brushes.Black;
            YAxis.Data = YAxisGeo;

            myCan.Children.Add(YAxis);
        }
    }
}

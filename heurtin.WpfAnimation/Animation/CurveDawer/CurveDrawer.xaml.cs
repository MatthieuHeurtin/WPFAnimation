using System;
using System.Collections.ObjectModel;
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
            return "A try of drawing a Cos using Polyline. To complicated, it must exist WPF libraries to draw math curves";
        }

        public ObservableCollection<double> Output { get; set; }




        public static int Scale = 2;

        public CurveDrawer()
        {
            InitializeComponent();

            DataContext = this;

            DrawAxis();
        }

        private void DrawAxis()
        {
            myCan.Children.Clear();
            DrawX();
            DrawY();
            myCan.Children.Add(myLine);
            int size = 100;
            Output = new ObservableCollection<double>();
            for (int i = 0; i < size; i++)
            {
                Output.Add( Math.Cos(i));
            }
            
        }

        private void DrawY()
        {
            const double margin = 2;
            double xmin = margin;
            double ymin = margin;
            int _scale = Scale;
            

            GeometryGroup YAxisGeo = new GeometryGroup();
            for (double y = ymin+ _scale; y <= myCan.Height - _scale; y += _scale)
            {
                YAxisGeo.Children.Add(new LineGeometry(
                    new Point( xmin - margin / 2, y),
                    new Point( xmin + margin / 2, y)));
            }

            Path YAxis = new Path();
            YAxis.StrokeThickness = 0.5;
            YAxis.Stroke = Brushes.Black;
            YAxis.Data = YAxisGeo;

            myCan.Children.Add(YAxis);
        }


        private void DrawX()
        {
            const double margin = 2;
            double xmax = myCan.Width - margin;
            double ymax = myCan.Height - margin;
            int _scale = Scale;

            GeometryGroup XAxisGeo = new GeometryGroup();

            for (double x = _scale; x <= myCan.Width- _scale; x += _scale)
            {
                XAxisGeo.Children.Add(new LineGeometry(
                    new Point(x , ymax/2 - margin / 2),
                    new Point(x , ymax/2 + margin / 2)));
            }

            Path XAxis = new Path();
            XAxis.StrokeThickness = 0.5;
            XAxis.Stroke = Brushes.Black;
            XAxis.Data = XAxisGeo;

            myCan.Children.Add(XAxis);
        }

        private void Button_ClickDecrease(object sender, RoutedEventArgs e)
        {
            if (Scale > 2)
            {
                Scale--;
                DrawAxis();
            }
        }


        private void Button_ClickIncrease(object sender, RoutedEventArgs e)
        {

            if (Scale < 15)
            {
                Scale++;
                DrawAxis();
            }
        }
    }
}

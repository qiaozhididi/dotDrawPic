using ClosedXML.Excel;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Globalization; // 用于double.Parse  

using System.IO;


namespace dotPic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            DrawPointsFromCsv();
        }
        private void DrawPointsFromCsv()
        {

        }

        private PointCollection ConvertToIntPoints(int[,] intPoints)
        {
            PointCollection points = new PointCollection();
            for (int i = 0; i < intPoints.GetLength(0); i++)
            {
                points.Add(new Point(intPoints[i, 0], intPoints[i, 1]));
            }
            return points;
        }


    }
}
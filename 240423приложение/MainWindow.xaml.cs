using FourangleClasses.Classes;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FourangleClasses.Classes;

namespace WpfLR2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSolve_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("ЧЕТЫРЕХУГОЛЬНИК");
            ClsFourangle fourangle2 = new ClsFourangle(-5, 4, 8, 6, 9, -4, -4, -3);

            fourangle2.SidesCalculation();
            fourangle2.DiagonalsCalculation();
            Console.WriteLine($"Периметр четырёхугольника ={fourangle2.Perimetr()}");
            Console.WriteLine($"Площадь четырёхугольника ={fourangle2.Ploshad()}");

            ClsParallelogram parall = new ClsParallelogram();
            parall.KeyboardInput();
            parall.SidesCalculation();
            parall.DiagonalsCalculation();
            Console.WriteLine($"Периметр параллелограмма ={parall.Perimetr()}");
            Console.WriteLine($"Площадь параллелограмма ={parall.Ploshad()}");

            ClsRectangle rect = new ClsRectangle();
            rect.KeyboardInput();
            rect.SidesCalculation();
            rect.DiagonalsCalculation();
            Console.WriteLine($"Периметр прямоугольника ={rect.Perimetr()}");
            Console.WriteLine($"Площадь прямоугольника ={rect.Ploshad()}");

            ClsRhomb rhomb = new ClsRhomb();
            rhomb.KeyboardInput();
            rhomb.SidesCalculation();
            rhomb.DiagonalsCalculation();
            Console.WriteLine($"Периметр ромба ={rhomb.Perimetr()}");
            Console.WriteLine($"Площадь ромба ={rhomb.Ploshad()}");
            LstResult.Items.Clear();
        }
    }
}

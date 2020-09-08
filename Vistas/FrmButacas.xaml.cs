using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for FrmButacas.xaml
    /// </summary>
    public partial class FrmButacas : Window
    {
        public FrmButacas()
        {
            InitializeComponent();
            //SuperMario();
            init_panels();
        }
        public void init_panels()
        {
            int iRow = -1;
            foreach(RowDefinition row in butacaGrd.RowDefinitions)
            {
                iRow++;
                int iCol= -1;
                foreach (ColumnDefinition col in butacaGrd.ColumnDefinitions)
                {
                    //Creamos un panel por cada definicion de row y column
                    iCol++;
                    Border panel = new Border();
                    Grid.SetColumn(panel, iCol);
                    Grid.SetRow(panel, iRow);
                    
                    Button butt = new Button();
                    Grid.SetColumn(butt, iCol);
                    Grid.SetRow(butt, iRow);
                    butt.Content = "col: " + iCol + " row: " + iRow;
                    panel.Child = butt;
                    /*
                    //Creamos un label que va a decir la posicion de cada panel
                    Label lbl = new Label();
                    lbl.Content = "col: " + iCol + " row: " + iRow;
                    lbl.VerticalAlignment = VerticalAlignment.Center;
                    panel.Child = lbl;
                    */
                    //eventos del Mouse
                    panel.MouseEnter += Panel_MouseEnter;
                    panel.MouseLeave += Panel_MouseLeave;
                    //butt.MouseEnter += PruebaHover;
                    panel.Child.MouseLeftButtonDown += AgregarButaca;
                    butt.MouseDoubleClick += AgregarButaca;
                    panel.Margin = new Thickness(1);
                    panel.Background = new SolidColorBrush(Color.FromArgb(100, 100, 100, 100));
                    butacaGrd.Children.Add(panel);
                }
            }
        }
        private void Panel_MouseLeave(object sender, MouseEventArgs e)
        {
            Border panel = sender as Border;
            panel.BorderThickness = new Thickness(0);
        }
        private void Panel_MouseEnter(object sender, MouseEventArgs e)
        {
            Border panel = sender as Border;
            panel.BorderThickness = new Thickness(1);
            panel.BorderBrush = new SolidColorBrush(Color.FromArgb(200, 20, 20, 20));
            string sCol = " col=" + Grid.GetColumn(panel);
            string sRow = " row=" + Grid.GetRow(panel);
            //lblStatus.Content = 
        }
        private void PruebaHover(object sender, MouseEventArgs e)
        {
            Console.Beep();
            MessageBox.Show(((Button)sender).Content.ToString());
            
        }
        private void AgregarButaca(object sender, MouseButtonEventArgs e)
        {
            Console.Beep();
            MessageBox.Show("XD");
            
            MessageBox.Show(((Button)sender).Content.ToString());
            Button butt = sender as Button;
            butt.Background = Brushes.Blue;
            
             

        }

        private void SuperMario()
        {
            Console.Beep(659, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(523, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(375); Console.Beep(392, 125); Thread.Sleep(375); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(375); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125); Thread.Sleep(1125); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125);
        }
        private void AddOrRemove(object sender, MouseButtonEventArgs e)
        {
            //XD
        }
    }
}

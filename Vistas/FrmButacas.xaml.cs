using System;
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

                    //Creamos un label que va a decir la posicion de cada panel
                    Label lbl = new Label();
                    lbl.Content = "col: " + iCol + " row: " + iRow;
                    lbl.VerticalAlignment = VerticalAlignment.Center;
                    panel.Child = lbl;

                    //eventos del Mouse
                    panel.MouseEnter += Panel_MouseEnter;
                    panel.MouseLeave += Panel_MouseLeave;
                    panel.MouseLeftButtonDown += AgregarButaca;
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
        private void AgregarButaca(object sender, MouseButtonEventArgs e)
        {
            Border panel = sender as Border;
            panel.BorderThickness = new Thickness(1);
            panel.BorderBrush = new SolidColorBrush(Color.FromArgb(200, 20, 20, 20));
        }


        private void AddOrRemove(object sender, MouseButtonEventArgs e)
        {
            //XD
        }
    }
}

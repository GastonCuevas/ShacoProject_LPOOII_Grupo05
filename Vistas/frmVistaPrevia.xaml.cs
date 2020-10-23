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
    /// Interaction logic for frmVistaPrevia.xaml
    /// </summary>
    public partial class frmVistaPrevia : Window
    {
        public frmVistaPrevia()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog pdlg = new PrintDialog();
            if (pdlg.ShowDialog() == true) 
            {
                pdlg.PrintDocument(((IDocumentPaginatorSource)DocMain).DocumentPaginator,"Imprimir");
            }
        }
    }
}

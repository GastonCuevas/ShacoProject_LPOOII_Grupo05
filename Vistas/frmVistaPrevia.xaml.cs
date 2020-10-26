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
using ClasesBase;

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

        public CollectionViewSource usuarios;

        public frmVistaPrevia(CollectionViewSource vista_usuarios)
        {
            InitializeComponent();
            usuarios = vista_usuarios;

            Binding binding = new Binding();
            binding.Source = usuarios;
            BindingOperations.SetBinding(grdUsuarios, ListView.ItemsSourceProperty, binding);
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

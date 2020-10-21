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
using System.Collections.ObjectModel;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for frmUsuarios.xaml
    /// </summary>
    public partial class frmUsuarios : Window
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        CollectionView Vista;
        ObservableCollection<Usuario> listaUsuario;
        Int32 index = 0;
        int tamaño = 0;

        //Conjunto de métodos de comportamiento de los botones para moverse por la lista
        private void btnFirts_Click(object sender, RoutedEventArgs e)
        {
            Vista.MoveCurrentToFirst();
            index = 0;
            actualizar();
        }

        private void index0() 
        {
            Vista.MoveCurrentToFirst();
            index = 0;
            actualizar();
        }

        private void btnPrevius_Click(object sender, RoutedEventArgs e)
        {
            Vista.MoveCurrentToPrevious();
            index--;

            if(Vista.IsCurrentBeforeFirst)
            {
                Vista.MoveCurrentToLast();
                index = tamaño - 1;
            }
            actualizar();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            Vista.MoveCurrentToNext();
            index++;

            if (Vista.IsCurrentAfterLast)
            {
                Vista.MoveCurrentToFirst();
                index = 0;
            }
            actualizar();
        }

        private void btnLast_Click(object sender, RoutedEventArgs e)
        {
            Vista.MoveCurrentToLast();
            index = tamaño - 1;
            actualizar();
        }

        private void actualizar() 
        {
            txtIndex.Text = Convert.ToString(index+1);
        }

        //Carga del canvas listaUsuarios
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ObjectDataProvider odp = (ObjectDataProvider)this.Resources["LIST_USER"];
            listaUsuario = odp.Data as ObservableCollection<Usuario>;

            Vista = (CollectionView)CollectionViewSource.GetDefaultView(canvas_content.DataContext);
            actulizarContador();
        }

        private void actulizarContador() 
        {
            tamaño = listaUsuario.Count;
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            Usuario oUsuario = new Usuario();

            oUsuario.Usu_NombreUsuario = txtNombreUsuario.Text;
            oUsuario.Usu_Contraseña = txtContraseña.Text;
            oUsuario.Usu_ApellidoNombre = txtApellidoNombre.Text;
            oUsuario.Rol_Codigo = txtCodigo.Text;

            listaUsuario.Add(oUsuario);

            MessageBox.Show("Usuario Agregado con éxito");
            Vista.MoveCurrentToLast();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el Usuario?:\n" + txtNombreUsuario.Text, "Eliminar", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                listaUsuario.RemoveAt(index);
                limpiarCampos();
                btnGuardar.IsEnabled = false;
                btnEliminar.IsEnabled = false;
                btnCancelar.IsEnabled = false;
                index0();
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            txtNombreUsuario.Text = "";
            txtContraseña.Text = "";
            txtApellidoNombre.Text = "";
            txtCodigo.Text = "";
            btnGuardar.IsEnabled = false;
            btnEliminar.IsEnabled = false;
            btnCancelar.IsEnabled = false;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("¿Desea modificar el Usuario?:\n" + txtNombreUsuario.Text, "Eliminar", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                listaUsuario[index].Usu_NombreUsuario = txtNombreUsuario.Text;
                listaUsuario[index].Usu_Contraseña = txtContraseña.Text;
                listaUsuario[index].Usu_ApellidoNombre = txtApellidoNombre.Text;
                listaUsuario[index].Rol_Codigo = txtCodigo.Text;
                btnGuardar.IsEnabled = false;
                btnEliminar.IsEnabled = false;
                btnCancelar.IsEnabled = false;
                index0();
                limpiarCampos();
            }  
        }

        private void btnSeleccionar_Click(object sender, RoutedEventArgs e)
        {
            txtNombreUsuario.Text = listaUsuario[index].Usu_NombreUsuario;
            txtContraseña.Text = listaUsuario[index].Usu_Contraseña;
            txtApellidoNombre.Text = listaUsuario[index].Usu_ApellidoNombre;
            txtCodigo.Text = listaUsuario[index].Rol_Codigo;
            btnGuardar.IsEnabled = true;
            btnEliminar.IsEnabled = true;
            btnCancelar.IsEnabled = true;
        }

        private void limpiarCampos() 
        {
            txtNombreUsuario.Text = "";
            txtContraseña.Text = "";
            txtApellidoNombre.Text = "";
            txtCodigo.Text = "";
        }
    }
}

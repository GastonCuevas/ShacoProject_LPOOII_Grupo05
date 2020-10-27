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
            txtIndex.Text = "Index: " + Convert.ToString(index+1);
        }

        //Carga del canvas listaUsuarios
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cargarGrilla();
            
        }

        //Método que actualiza la variable que representa el tamaño de la lista
        private void actulizarContador() 
        {
            tamaño = listaUsuario.Count;
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            if (txtNombreUsuario.Text != "" && txtContraseña.Text != "" && txtApellidoNombre.Text != "")
            {
                Usuario oUsuario = new Usuario();
                oUsuario.Usu_NombreUsuario = txtNombreUsuario.Text;
                oUsuario.Usu_Contraseña = txtContraseña.Text;
                oUsuario.Usu_ApellidoNombre = txtApellidoNombre.Text;
                oUsuario.Rol_Codigo = cbCodigo.Text;
                listaUsuario.Add(oUsuario);
                TrabajarUsuario.AgregarUsuario(oUsuario);
                MessageBox.Show("Usuario Agregado con éxito");
                cargarGrilla();
                index0();
                limpiarCampos();
            }
            else {
                MessageBox.Show("¡Complete TODOS los campos!");
            }
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el Usuario?:\n" + txtNombreUsuario.Text, "Eliminar", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                TrabajarUsuario.EliminarUsuario(buscarID(index));
                listaUsuario.RemoveAt(index);
                limpiarCampos();
                btnGuardar.IsEnabled = false;
                btnEliminar.IsEnabled = false;
                btnCancelar.IsEnabled = false;
                index0();
                cargarGrilla();
                mostrarNavegacion();
                btnAgregar.IsEnabled = true;
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            txtNombreUsuario.Text = "";
            txtContraseña.Text = "";
            txtApellidoNombre.Text = "";
            cbCodigo.Text = "";
            btnGuardar.IsEnabled = false;
            btnEliminar.IsEnabled = false;
            btnCancelar.IsEnabled = false;
            btnAgregar.IsEnabled = true;
            mostrarNavegacion();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("¿Desea modificar el Usuario?:\n" + txtNombreUsuario.Text, "Modificar", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Usuario oUsuario = new Usuario();
                oUsuario.Usu_NombreUsuario = txtNombreUsuario.Text;
                oUsuario.Usu_Contraseña = txtContraseña.Text;
                oUsuario.Usu_ApellidoNombre = txtApellidoNombre.Text;
                oUsuario.Rol_Codigo = cbCodigo.Text;
                oUsuario.Usu_ID = buscarID(index);
                listaUsuario[index] = oUsuario;
                TrabajarUsuario.ModificarUsuario(oUsuario);
                MessageBox.Show("¡Se modificó con éxito!");
                btnGuardar.IsEnabled = false;
                btnEliminar.IsEnabled = false;
                btnCancelar.IsEnabled = false;
                btnAgregar.IsEnabled = true;
                cargarGrilla();
                index0();
                limpiarCampos();
                mostrarNavegacion();
            }  
        }

        private void btnSeleccionar_Click(object sender, RoutedEventArgs e)
        {
            txtNombreUsuario.Text = listaUsuario[index].Usu_NombreUsuario;
            txtContraseña.Text = listaUsuario[index].Usu_Contraseña;
            txtApellidoNombre.Text = listaUsuario[index].Usu_ApellidoNombre;
            cbCodigo.Text = listaUsuario[index].Rol_Codigo;
            btnGuardar.IsEnabled = true;
            btnEliminar.IsEnabled = true;
            btnCancelar.IsEnabled = true;
            btnAgregar.IsEnabled = false;
            ocultarNavegacion();
        }

        private void limpiarCampos() 
        {
            txtNombreUsuario.Text = "";
            txtContraseña.Text = "";
            txtApellidoNombre.Text = "";
            cbCodigo.Text = "";
        }

        private void cargarGrilla()
        {
            ObjectDataProvider odp = (ObjectDataProvider)this.Resources["LIST_USER"];
            listaUsuario = odp.Data as ObservableCollection<Usuario>;
            Vista = (CollectionView)CollectionViewSource.GetDefaultView(canvas_content.DataContext);
            actulizarContador();
        }

        //Devuelve el ID de Usuario dependiendo del index
        private int buscarID(int index){
            return listaUsuario[index].Usu_ID;
        }

        //Comportamiento de los botones de navegación
        private void ocultarNavegacion() {
            btnFirts.IsEnabled = false;
            btnPrevius.IsEnabled = false;
            btnLast.IsEnabled = false;
            btnNext.IsEnabled = false;
        }

        private void mostrarNavegacion()
        {
            btnFirts.IsEnabled = true;
            btnPrevius.IsEnabled = true;
            btnLast.IsEnabled = true;
            btnNext.IsEnabled = true;
        }

        //Abre el listado de Usuarios
        private void btnListado_Click(object sender, RoutedEventArgs e)
        {
            ListadoUsuario oListadoUsuarios = new ListadoUsuario();
            oListadoUsuarios.Show();
        }
    }
}

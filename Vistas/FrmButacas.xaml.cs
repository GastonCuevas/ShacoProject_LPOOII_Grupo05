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
using ClasesBase;
using System.Data;
using System.Data.SqlClient;
using System.Collections.ObjectModel;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for FrmButacas.xaml
    /// </summary>
    public partial class FrmButacas : Window
    {
        DataTable ocupados = new DataTable();
        Sala sala = new Sala();
        ObservableCollection<int> listaEncontrados = new ObservableCollection<int>();
        ObservableCollection<int> listadoAsientosOcupados = new ObservableCollection<int>();
        Proyeccion proyeccion = new Proyeccion();
        public FrmButacas()
        {
            InitializeComponent();
        }
        public FrmButacas(Sala oSala, Proyeccion oProyeccion)
        {
            proyeccion = oProyeccion;
            sala = oSala;
            MessageBox.Show(sala.Sala_Columnas.ToString());
            ocupados = TrabajarTicket.traerTicketsProyeccion(proyeccion.Pro_Codigo);
            obtenerButacas(ocupados);
            InitializeComponent();
        }

        void obtenerButacas(DataTable dt){
            foreach(DataRow row in dt.Rows){
                listaEncontrados.Add(Convert.ToInt32(row["BUT_ID"]));
            }
            listadoAsientosOcupados = obtenerAsientos(listaEncontrados);
        }

        private ObservableCollection<int> obtenerAsientos(ObservableCollection<int> listaID) {
            Butaca oButaca = new Butaca();
            ObservableCollection<int> auxEncontrados = new ObservableCollection<int>();
            foreach (int item in listaID)
            {
                int suma;
                oButaca = new Butaca();
                oButaca = TrabajarButaca.traerButaca(item);
                suma = oButaca.But_Fila * oButaca.But_Nro;
                auxEncontrados.Add(suma);
            }
            return auxEncontrados;
        }



        Button btn(int i)
        {
            Button b = new Button();
            if (listadoAsientosOcupados.Count != 0)
            {
                for (int j = 0; j <= listadoAsientosOcupados.Count; j++)
                {
                    if (i != listadoAsientosOcupados[j])
                    {
                        b.Name = "butaca" + i.ToString();
                        b.Width = (1000 / sala.Sala_Columnas);
                        b.Height = (520 / sala.Sala_Filas);
                        b.Content = i.ToString();
                        b.Click += b_Click;

                    }
                    else
                    {
                        b.Name = "butaca" + i.ToString();
                        b.Width = (1000 / sala.Sala_Columnas);
                        b.Height = (520 / sala.Sala_Filas);
                        b.Content = i.ToString();
                        b.Background = Brushes.Gray;
                    }
                }
            }
            else {
                b.Name = "butaca" + i.ToString();
                b.Width = (1000 / sala.Sala_Columnas);
                b.Height = (520 / sala.Sala_Filas);
                b.Content = i.ToString();
                b.Click += b_Click;
            }

            
            return b;
        }
        void b_Click(object sender, EventArgs e)
        {
            Console.Beep();
            Button b = (Button)sender;
            if (MessageBox.Show("Desea seleccionar esta butaca?", b.Name.ToString(), MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {

                b.Background = Brushes.Gray;
            }
        }

        private void SuperMario()
        {
            Console.Beep(659, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(523, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(375); Console.Beep(392, 125); Thread.Sleep(375); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(375); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125); Thread.Sleep(1125); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125);
        }

        private void cargarButacas(int numeroSala) 
        {
            int butacas = 0;

            DataTable dt = TrabajarSala.traerSalas();
            for (int i = 0; i < dt.Rows.Count; i++) 
            {
                if(dt.Rows[i]["sala_nrosala"].ToString().Equals(numeroSala.ToString()))
                {
                    butacas = (int)dt.Rows[i]["sala_cantbutacas"];
                }
            }
            int n = butacas;
            MessageBox.Show("Cantidad Butacas: " + n.ToString());
            wrpButaca.Children.Clear();
            for (int i = 1; i <= n; i++)
            {
                wrpButaca.Children.Add(btn(i));

            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cargarButacas(sala.Sala_NroSala);
        }
    }
}

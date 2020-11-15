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
        private ObservableCollection<int> listaEncontrados = new ObservableCollection<int>();
        private ObservableCollection<int> listadoAsientosOcupados = new ObservableCollection<int>();
        private ObservableCollection<ButacaTicket> listadoButacasTickets = new ObservableCollection<ButacaTicket>();
        frmTickets oFrmTickets;

        Proyeccion proyeccion = new Proyeccion();
        public FrmButacas()
        {
            InitializeComponent();
        }
        public FrmButacas(Sala oSala, Proyeccion oProyeccion,frmTickets formulario)
        {
            oFrmTickets = formulario;
            proyeccion = oProyeccion;
            sala = oSala;
            ocupados = TrabajarTicket.traerTicketsProyeccion(proyeccion.Pro_Codigo);
            obtenerButacas(ocupados);
            InitializeComponent();
        }

        void obtenerButacas(DataTable dt){

            foreach(DataRow row in dt.Rows){
                listaEncontrados.Add(Convert.ToInt32(row["BUT_ID"]));
            }
            //MessageBox.Show(listaEncontrados.Count.ToString());
        }

        ButtonButaca btn(int i)
        {
            ButtonButaca b = new ButtonButaca();

            b.Name = "butaca" + (i+1).ToString();
            b.Width = (1000 / sala.Sala_Columnas);
            b.Height = (500 / sala.Sala_Filas);
            b.Content = (i+1).ToString();
            b.ButacaId = listadoButacasTickets[i].But_ID;
            b.Click += b_Click;
            b.Background = Brushes.Green;

            if (listaEncontrados.Count > 0)
            {
                for (int j = 0; j < listaEncontrados.Count; j++)
                {
                    //MessageBox.Show(i.ToString()+"||"+listadoAsientosOcupados[j].ToString());
                    if (b.ButacaId == listaEncontrados[j])
                    {
                        //MessageBox.Show("Pinté rojo butaca: "+ i.ToString());
                        b.Background = Brushes.Red;
                    }                        
                }
            }
     
            return b;
        }

        void b_Click(object sender, EventArgs e)
        {
            Console.Beep();
            ButtonButaca b = (ButtonButaca)sender;
            if (MessageBox.Show("Desea seleccionar esta butaca?", "Butaca " + b.Content.ToString(), MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Butaca oButaca = TrabajarButaca.traerButaca(b.ButacaId);
                b.Background = Brushes.Red;
                oFrmTickets.butacaSeleccionadaId = b.ButacaId;
                oFrmTickets.lblNumBut.Content = "Butaca Seleccionada: Fila: " + oButaca.But_Fila + " - Número: " + oButaca.But_Nro;
                this.Close();
            }
        }

        private void SuperMario()
        {
            Console.Beep(659, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(523, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(375); Console.Beep(392, 125); Thread.Sleep(375); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(375); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125); Thread.Sleep(1125); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125);
        }

        private void cargarButacas(int numeroSala) 
        {
            int butacas = 0;
            ObservableCollection<int> butacas_id = new ObservableCollection<int>();

            DataTable dt = TrabajarSala.traerSalas();
            for (int i = 0; i < dt.Rows.Count; i++) 
            {
                if(dt.Rows[i]["sala_nrosala"].ToString().Equals(numeroSala.ToString()))
                {
                    butacas = (int)dt.Rows[i]["sala_cantbutacas"];
                }
            }

            DataTable dtButacas = TrabajarButaca.traerButacaSala(numeroSala);
            for (int i = 0; i < dtButacas.Rows.Count; i++) 
            {
                butacas_id.Add((int)dtButacas.Rows[i]["but_id"]);
            }


            int n = butacas;
            wrpButaca.Children.Clear();
            for (int i = 0; i < n; i++)
            {
                listadoButacasTickets.Add(new ButacaTicket(butacas_id[i],i+1));
                wrpButaca.Children.Add(btn(i));
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cargarButacas(sala.Sala_NroSala);
        }
    }
}

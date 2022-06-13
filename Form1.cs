using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;


namespace Project_SerialPort
{
    public partial class Form1 : Form
    {
        private delegate void DelegadoAcceso(string acceso);
        private string strBufferIn;
        private string strBufferOut;
        public Form1()
        {
            InitializeComponent();
        }

        private void AccesoForm(string accion)
        {
            strBufferIn = accion;
            //________________________Datos que ingresan_____________

            if (strBufferIn == "CR")
            {
                txtDatosRecibidos.Text = "<CR>\n"; //SOLUCION BARATA
                // + Environment.NewLine; --SIRVE PARA FINALIZAR LA FRASE. 
                //falta hacer que termine la linea... lo que sigue manda el mensaje al enviado
                // spPuertos.WriteLine(strBufferIn);
                //verificar el ReadLines()
            }
            else
            {
                txtDatosRecibidos.Text = strBufferIn;
            }
        }

        private void AccesoInterrupcion(string accion)
        {
            DelegadoAcceso Var_DelegadoAcceso;
            Var_DelegadoAcceso = new DelegadoAcceso(AccesoForm);
            object[] arg = { accion };
            base.Invoke(Var_DelegadoAcceso, arg);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            strBufferIn = "";
            strBufferOut = "";
            BtnConectar.Enabled = false;
            BtnEnviarDatos.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string[] PuertosDisponibles = SerialPort.GetPortNames();

            CboPuertos.Items.Clear();

            foreach (string puerto_simple in PuertosDisponibles)
            {
                CboPuertos.Items.Add(puerto_simple);
            }

            if (CboPuertos.Items.Count > 0)
            {
                CboPuertos.SelectedIndex = 0;
                if (CboPuertos.Items.Count <= 1)
                {
                    MessageBox.Show(CboPuertos.Items.Count + " Puerto encontrado");
                }
                else {
                    MessageBox.Show(CboPuertos.Items.Count + " Puertos encontrados");
                }
                
                BtnConectar.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se han detectado Puertos");
                CboPuertos.Items.Clear();
                CboPuertos.Text = "               ";
                strBufferIn = "";
                strBufferOut = "";
                BtnConectar.Enabled = false;
                BtnEnviarDatos.Enabled = false;
            }
        }


        /* EVENTOS DEL BOTON CONECTAR/DESCONECTAR */
        private void BtnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                /* CONECTAR */
                if (BtnConectar.Text == "Conectar")
                {
                    spPuertos.BaudRate = Int32.Parse(CboBaudRate.Text);
                    spPuertos.DataBits = Int32.Parse(cboDataBits.Text);
                    spPuertos.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cboStopBits.Text);
                    spPuertos.Parity = (Parity)Enum.Parse(typeof(Parity), cboParityB.Text);
                    //spPuertos.DataBits = 8;
                    //spPuertos.Parity = Parity.None;
                    // spPuertos.StopBits = StopBits.One;
                    spPuertos.Handshake = Handshake.None;
                    spPuertos.PortName = CboPuertos.Text;

                    try
                    {
                        spPuertos.Open();
                        BtnConectar.Text = "Desconectar";
                        BtnEnviarDatos.Enabled = true;
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message.ToString());

                    }

                }
                /* DESCONECTAR */
                else if (BtnConectar.Text == "Desconectar")
                {
                    spPuertos.Close();
                    BtnConectar.Text = "Conectar";
                    BtnEnviarDatos.Enabled = true;
                }
            }
            /* MANEJO DE ERROR */
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
        }




        /* EVENTOS DEL txtEnviarDatos y btn */
        private void BtnEnviarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                spPuertos.DiscardOutBuffer();
                strBufferOut = txtEnviarDatos.Text; //Aqui se modifica el formato de la cadena de texto
                spPuertos.Write(strBufferOut);
            }
            /*  MANEJO DE ERROR*/
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
        }

        /* EVENTOS DEL txt */
        private void DatoRecibido(object sender, SerialDataReceivedEventArgs e)
        {
            AccesoInterrupcion(spPuertos.ReadExisting());

            /*string Data_in = spPuertos.ReadExisting();
            MessageBox.Show(Data_in);
            txtDatosRecibidos.Text = Data_in;*/
        }




        private void chBxAccesPoint_CheckedChanged(object sender, EventArgs e)
        {
            if (chBxAccesPoint.Checked)
            {
                cbxModos.Enabled = false;
                cbxServTCP.Enabled = false;
                cbxTipoConx.Enabled = false;
                MessageBox.Show("Módulo Configurado como Acceso Point");

            }
            else
            {
                cbxModos.Enabled = true;
                cbxServTCP.Enabled = true;
                cbxTipoConx.Enabled = true;
            }
        }

        private void cbxServTCP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxTipoConx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxModos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblModos_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gBxAccesPoint_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDatosRecibidos.Text = "";
        }
    }
}

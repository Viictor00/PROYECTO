using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using WindowsFormsApplication1;



namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        
        string conectado;
        Socket server;
      

        
        public Form2(string nombre, Socket server1)
        {
            InitializeComponent();
            conectado = nombre;
            server = server1; 
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MessageBox.Show(conectado); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (PartidasGanadas.Checked)
            {
                string mensaje = "3/" + conectado;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                MessageBox.Show(mensaje);
            }
            else if (PartidasJugadas.Checked)
            {
                string mensaje = "4/" + conectado;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                MessageBox.Show(mensaje);

            }
            else if (tiempoJugado.Checked)
            {
                // Enviamos nombre 
                string mensaje = "5/" + conectado;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                MessageBox.Show(mensaje);

            }
            else if (conectadosLista.Checked)
            {
                // Enviamos nombre 
                string mensaje = "6/" + conectado;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                MessageBox.Show(mensaje);

            }

        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            //Mensaje de desconexión
            string mensaje = "0/";

            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            // Nos desconectamos
            this.BackColor = Color.Gray;
            server.Shutdown(SocketShutdown.Both);
            server.Close();
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();


        }




    }
}

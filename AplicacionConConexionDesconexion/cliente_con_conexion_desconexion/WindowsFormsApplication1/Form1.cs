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
   

    public partial class Form1 : Form
    {
        
        public static Socket server;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Creamos un IPEndPoint con el ip del servidor y puerto del servidor 
            //al que deseamos conectarnos
            IPAddress direc = IPAddress.Parse("192.168.56.4");
            IPEndPoint ipep = new IPEndPoint(direc, 9040);
            

            //Creamos el socket 
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ipep);//Intentamos conectar el socket
                this.BackColor = Color.Green;
                MessageBox.Show("Conectado");

            }
            catch (SocketException ex)
            {
                //Si hay excepcion imprimimos error y salimos del programa con return 
                MessageBox.Show("No he podido conectar con el servidor");
                return;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
          //Miramos si el nombre está o no antes de hacer alguna operación 

            if (string.IsNullOrEmpty(nombre.Text) == false)
            {
                if (iniciarSesion.Checked)
                {
                    try
                    {
                        // Enviamos nombre y contraseña
                        string mensaje = "1/" + nombre.Text + "/" + passwordBox.Text;
                        // Enviamos al servidor el nombre tecleado
                        byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                        server.Send(msg);

                        //Recibimos la respuesta del servidor
                        byte[] msg2 = new byte[80];
                        server.Receive(msg2);

                        mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                        MessageBox.Show(mensaje);
                        if (mensaje == nombre.Text+ ": has iniciado sesion con exito")
                        {
                            //Abrimos un segundo formulario con las operaciones disponibles
         
                            Form2 form2 = new Form2(nombre.Text, server);
                            form2.Show();
                            this.Hide();
                        }
                       
                    }
                    catch (NullReferenceException)
                    {
                        MessageBox.Show("Introduce todos los datos");
                    }

                }


                else if (crearCuenta.Checked && nombre.Text != null)
                {
                    try
                    {
                        // Enviamos nombre y contraseña 
                        string mensaje = "2/" + nombre.Text + "/" + passwordBox.Text;
                        // Enviamos al servidor el nombre tecleado
                        byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                        server.Send(msg);

                        //Recibimos la respuesta del servidor
                        byte[] msg2 = new byte[80];
                        server.Receive(msg2);
                        mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                        MessageBox.Show(mensaje);
                        //COmparamos el mensaje 
                        if (mensaje == "El usuario "+nombre.Text+" ha sido creado.")
                        {
                            //Abrimos un segundo formulario con las opciones disponibles 
                            Form2 form2 = new Form2(nombre.Text, server);
                            form2.Show();
                            this.Hide();
                        }
                    }
                    catch (NullReferenceException)
                    {
                        MessageBox.Show("Introduce los datos correctamente");
                    }
                }

             
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //Mensaje de desconexión
                string mensaje = "0/";

                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                // Nos desconectamos
                this.BackColor = Color.Gray;
                server.Shutdown(SocketShutdown.Both);
                server.Close();
            }
            catch
            {
                MessageBox.Show("Has de tener una conexión establecida"); 
            }

        }

   

     
    }
}

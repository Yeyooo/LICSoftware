using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_Fixed
{
    public partial class Error_Report : Form
    {
        private MailMessage mensaje;
        private SmtpClient cliente;

        public Error_Report()
        {
            InitializeComponent();
        }

        private void Enviar_Reporte_Click(object sender, EventArgs e)
        {
            mensaje = new MailMessage();
            mensaje.To.Add("falvarezortiz@hotmail.com");

            //Asunto
            mensaje.Subject = Asunto_TextBox.Text;
            mensaje.SubjectEncoding = Encoding.UTF8;

            //Correo desde donde se enviara
            if (Mensaje_TextBox.Text == "")
            {
                MessageBox.Show("Se debe adjuntar una descripcion del Problema", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                mensaje.Body = Mensaje_TextBox.Text;
                mensaje.BodyEncoding = Encoding.UTF8;
                mensaje.IsBodyHtml = false;
                //CORREO DESDE DONDE ENVIAREMOS POR DEFECTO EL NUESTRO

                mensaje.From = new MailAddress("falvarezortiz20@gmail.com");
                //CLIENTE DEL CORREO
                cliente = new SmtpClient();
                //CREAR LAS CREDENCIALES
                cliente.Credentials = new NetworkCredential("falvarezortiz20@gmail.com", "felipe2-");

                //ESTO ES POR SI SE ENVIA DESDE GMAIL
                cliente.Port = 587;
                cliente.EnableSsl = true;

                cliente.Host = "smtp.gmail.com";

                //ENVIAR CORREO

                try
                {
                    cliente.Send(mensaje);
                    DialogResult resultado = MessageBox.Show("Mensaje Enviado con exito a los desarrolladores. Muchas Gracias !", "Confirmación De Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (resultado == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Imposible enviar mensaje, error a la conexion de internet", "ERROR FATAL", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }

        }
    }
}

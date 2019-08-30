using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AdministradorTareas
{
    public partial class Form1 : Form
    {
        Thread hilo;
        delegate void delegado(int valor);

        public Form1()
        {
            InitializeComponent();



            hilo = new Thread(new ThreadStart(Proceso1));
            hilo.Start();
            hilo = new Thread(new ThreadStart(Proceso2));
            hilo.Start();
            hilo = new Thread(new ThreadStart(Proceso3));
            hilo.Start();
            hilo = new Thread(new ThreadStart(Proceso4));
            hilo.Start();
        }
        private void Proceso1()
        {

        }
        private void Proceso2()
        {

        }
        private void Proceso3()
        {

        }
        private void Proceso4()
        {

        }
    }
}

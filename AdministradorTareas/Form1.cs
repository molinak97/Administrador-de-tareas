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
        delegate void delegado(int valor);
        Thread Tarea1, Tarea2, Tarea3;


        public Form1()
        {
            InitializeComponent();
            Tarea1 = new Thread(new ThreadStart(Proceso1));
            Tarea2 = new Thread(new ThreadStart(Proceso2));
            Tarea3 = new Thread(new ThreadStart(Proceso3));
            for (int x = 1; x <= 3; x++)
            {
                ListViewItem item = new ListViewItem("Proceso " + x);
                item.SubItems.Add(Tarea1.ThreadState.ToString());
                listView1.Items.Add(item);
            }
            listView1.Items[0].Selected = true;
            listView1.Select();
            Run();
        }
        private void Proceso1()
        {
            for(int i=0; i<=10000; i++)
            {

            }
        }
        private void Proceso2()
        {
            for (int i = 0; i <= 10000; i++)
            {

            }
        }
        private void Proceso3()
        {
            for (int i = 0; i <= 10000; i++)
            {

            }
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            Validar();
            switch (listView1.FocusedItem.Index)
            {
                case 0:
                    Tarea1.Start();
                    listView1.Items[0].SubItems[1].Text = Tarea1.ThreadState.ToString();
                    break;
                case 1:
                    Tarea2.Start();
                    listView1.Items[1].SubItems[1].Text = Tarea2.ThreadState.ToString();
                    break;
                case 2:
                    Tarea3.Start();
                    listView1.Items[2].SubItems[1].Text = Tarea3.ThreadState.ToString();
                    break;
                default:
                    break;
            }
        }
        private void buttonStop_Click(object sender, EventArgs e)
        {
            Validar();
            switch (listView1.FocusedItem.Index)
            {
                case 0:
                    Tarea1.Abort();
                    listView1.Items[0].SubItems[1].Text = Tarea1.ThreadState.ToString();
                    break;
                case 1:
                    Tarea2.Abort();
                    listView1.Items[1].SubItems[1].Text = Tarea2.ThreadState.ToString();
                    break;
                case 2:
                    Tarea2.Start();
                    listView1.Items[2].SubItems[1].Text = Tarea3.ThreadState.ToString();
                    break;
                default:
                    break;
            }
        }
        private void buttonWait_Click(object sender, EventArgs e)
        {
            Validar();
            switch (listView1.FocusedItem.Index)
            {
                case 0:
                    Tarea1.Suspend();
                    listView1.Items[0].SubItems[1].Text = Tarea1.ThreadState.ToString();
                    break;
                case 1:
                    Tarea2.Suspend();
                    listView1.Items[1].SubItems[1].Text = Tarea2.ThreadState.ToString();
                    break;
                case 2:
                    Tarea3.Suspend();
                    listView1.Items[2].SubItems[1].Text = Tarea3.ThreadState.ToString();
                    break;
                default:
                    break;
            }
        }
        private void buttonResume_Click(object sender, EventArgs e)
        {
            Validar();
            switch (listView1.FocusedItem.Index)
            {
                case 0:
                    Tarea1.Resume();
                    listView1.Items[0].SubItems[1].Text = Tarea1.ThreadState.ToString();
                    break;
                case 1:
                    Tarea2.Resume();
                    listView1.Items[1].SubItems[1].Text = Tarea2.ThreadState.ToString();
                    break;
                case 2:
                    Tarea3.Resume();
                    listView1.Items[2].SubItems[1].Text = Tarea3.ThreadState.ToString();
                    break;
                default:
                    break;
            }
        }
        private void Run()
        {
            Tarea1.Start();
            listView1.Items[0].SubItems[1].Text = Tarea1.ThreadState.ToString();
        }
        private void Validar()
        {
            listView1.Items[0].SubItems[1].Text = Tarea1.ThreadState.ToString();
            listView1.Items[1].SubItems[1].Text = Tarea1.ThreadState.ToString();
            listView1.Items[2].SubItems[1].Text = Tarea1.ThreadState.ToString();
        }

    }
}

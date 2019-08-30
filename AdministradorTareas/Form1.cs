﻿using System;
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
            while (true) ;
        }
        private void Proceso2()
        {
            while (true) ;
        }
        private void Proceso3()
        {
            while (true) ;
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            switch (listView1.FocusedItem.Index)
            {
                case 0:
                    if (listView1.Items[0].SubItems[1].Text == "Running")
                    {
                        MessageBox.Show("Esta tarea ya esta en ejecucion");
                    }
                    else if (listView1.Items[0].SubItems[1].Text == "Aborted")
                    {
                        MessageBox.Show("Esta tarea ya esta suspendida");
                    }
                    else if (listView1.Items[0].SubItems[1].Text == "Suspended")
                    {
                        MessageBox.Show("Esta tarea se encuentra suspendida");
                    }
                    else
                    {
                        Tarea1.Start();
                        listView1.Items[0].SubItems[1].Text = Tarea1.ThreadState.ToString();
                    }
                    break;
                case 1:
                    if (listView1.Items[1].SubItems[1].Text == "Running")
                    {
                        MessageBox.Show("Esta tarea ya esta en ejecucion");
                    }
                    else if (listView1.Items[1].SubItems[1].Text == "Aborted")
                    {
                        MessageBox.Show("Esta tarea ya esta suspendida");
                    }
                    else if (listView1.Items[1].SubItems[1].Text == "Suspended")
                    {
                        MessageBox.Show("Esta tarea se encuentra suspendida");
                    }
                    else
                    {
                        Tarea2.Start();
                        listView1.Items[1].SubItems[1].Text = Tarea2.ThreadState.ToString();
                    }
                    break;
                case 2:
                    if (listView1.Items[2].SubItems[1].Text == "Running")
                    {
                        MessageBox.Show("Esta tarea ya esta en ejecucion");
                    }
                    else if (listView1.Items[2].SubItems[1].Text == "Aborted")
                    {
                        MessageBox.Show("Esta tarea ya esta suspendida");
                    }
                    else if (listView1.Items[2].SubItems[1].Text == "Suspended")
                    {
                        MessageBox.Show("Esta tarea se encuentra suspendida");
                    }
                    else
                    {
                        Tarea3.Start();
                        listView1.Items[2].SubItems[1].Text = Tarea3.ThreadState.ToString();
                    }
                    break;
                default:
                    break;
            }
        }
        private void buttonStop_Click(object sender, EventArgs e)
        {
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
            switch (listView1.FocusedItem.Index)
            {
                case 0:
                    if (listView1.Items[0].SubItems[1].Text == "Aborted")
                    {
                        MessageBox.Show("Esta tarea ya esta suspendida");
                    }
                    else
                    {
                        Tarea1.Suspend();
                        listView1.Items[0].SubItems[1].Text = Tarea1.ThreadState.ToString();
                    }
                    break;
                case 1:
                    if (listView1.Items[1].SubItems[1].Text == "Aborted")
                    {
                        MessageBox.Show("Esta tarea ya esta suspendida");
                    }
                    else
                    {
                        Tarea2.Suspend();
                        listView1.Items[1].SubItems[1].Text = Tarea2.ThreadState.ToString();
                    }
                    break;
                case 2:
                    if (listView1.Items[2].SubItems[1].Text == "Aborted")
                    {
                        MessageBox.Show("Esta tarea ya esta suspendida");
                    }
                    else
                    {
                        Tarea3.Suspend();
                        listView1.Items[2].SubItems[1].Text = Tarea3.ThreadState.ToString();
                    }
                    break;
                default:
                    break;
            }
        }
        private void buttonResume_Click(object sender, EventArgs e)
        {
            switch (listView1.FocusedItem.Index)
            {
                case 0:
                    if (listView1.Items[0].SubItems[1].Text == "Aborted")
                    {
                        MessageBox.Show("Esta tarea ya esta suspendida");
                    }
                    else if(listView1.Items[0].SubItems[1].Text == "Running")
                    {
                        MessageBox.Show("Esta tarea ya esta en ejecucion");
                    }
                    else
                    {
                        Tarea1.Resume();
                        listView1.Items[0].SubItems[1].Text = Tarea1.ThreadState.ToString();
                    }
                    break;
                case 1:
                    if (listView1.Items[1].SubItems[1].Text == "Aborted")
                    {
                        MessageBox.Show("Esta tarea ya esta suspendida");
                    }
                    else if (listView1.Items[1].SubItems[1].Text == "Running")
                    {
                        MessageBox.Show("Esta tarea ya esta en ejecucion");
                    }
                    else
                    {
                        Tarea2.Resume();
                        listView1.Items[1].SubItems[1].Text = Tarea2.ThreadState.ToString();
                    }
                    break;
                case 2:
                    if (listView1.Items[2].SubItems[1].Text == "Aborted")
                    {
                        MessageBox.Show("Esta tarea ya esta suspendida");
                    }
                    else if (listView1.Items[2].SubItems[1].Text == "Running")
                    {
                        MessageBox.Show("Esta tarea ya esta en ejecucion");
                    }
                    else
                    {
                        Tarea3.Resume();
                        listView1.Items[2].SubItems[1].Text = Tarea3.ThreadState.ToString();
                    }
                    break;
                default:
                    break;
            }
        }
        private void Run()
        {
            Tarea1.Start();
            listView1.Items[0].SubItems[1].Text = Tarea1.ThreadState.ToString();
            Tarea2.Start();
            listView1.Items[1].SubItems[1].Text = Tarea2.ThreadState.ToString();
            Tarea3.Start();
            listView1.Items[2].SubItems[1].Text = Tarea3.ThreadState.ToString();
        }
    }
}

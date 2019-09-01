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
using System.Diagnostics;

namespace AdministradorTareas
{
    public partial class Form1 : Form
    {
        Thread thread1, thread2;
        private Process[] process;
        private Queue<Process> colaProcesos;//cola de procesos


        public Form1()
        {
            InitializeComponent();
            thread1 = new Thread(new ThreadStart(CProceso));
            thread2 = new Thread(new ThreadStart(CProceso));
            colaProcesos = new Queue<Process>();

            process = Process.GetProcesses();
            foreach (Process p in process)
            {
                colaProcesos.Enqueue(p);//Encolar Procesos
            }
            AddProceso();
            dataGridProceso.Rows[0].Selected = true;//Buscas el inicio 
            dataGridProceso.Select();//Seleccinas el inicio
        }
        private void CProceso()
        {
            while (true)
            Thread.Sleep(100);
        }
        private void AddProceso()
        {
            Process process = colaProcesos.Dequeue();
            dataGridProceso.Rows.Add(process.ProcessName, System.Threading.ThreadState.Running);
        }
        private void Run(Thread thread)
        {
            if (thread.ThreadState == System.Threading.ThreadState.Suspended)
            {
                thread.Resume();
            }
            else if (thread.ThreadState == System.Threading.ThreadState.WaitSleepJoin)
            {
                thread.Resume();
            }
            else
            {
                thread.Start();
            }
        }
        private void Suspend(Thread thread)
        {
            if (thread.ThreadState == System.Threading.ThreadState.Running)
            {
                thread.Suspend();
            }
        }
        private void Stop(ref Thread thread)
        {
                thread.Abort();
                Console.WriteLine(thread.ThreadState);
                thread = new Thread(new ThreadStart(CProceso));
                Console.WriteLine(thread.ThreadState);

        }
        private void buttonResume_Click(object sender, EventArgs e)
        {
            //switch (listView1.FocusedItem.Index)
            //{
            //    case 0:
            //        if (listView1.Items[0].SubItems[1].Text == "Aborted")
            //        {
            //            MessageBox.Show("Esta tarea ya esta suspendida");
            //        }
            //        else if (listView1.Items[0].SubItems[1].Text == "Running")
            //        {
            //            MessageBox.Show("Esta tarea ya esta en ejecucion");
            //        }
            //        else
            //        {
            //            Tarea1.Resume();
            //            listView1.Items[0].SubItems[1].Text = Tarea1.ThreadState.ToString();
            //        }
            //        break;
            //    case 1:
            //        if (listView1.Items[1].SubItems[1].Text == "Aborted")
            //        {
            //            MessageBox.Show("Esta tarea ya esta suspendida");
            //        }
            //        else if (listView1.Items[1].SubItems[1].Text == "Running")
            //        {
            //            MessageBox.Show("Esta tarea ya esta en ejecucion");
            //        }
            //        else
            //        {
            //            Tarea2.Resume();
            //            listView1.Items[1].SubItems[1].Text = Tarea2.ThreadState.ToString();
            //        }
            //        break;
            //    case 2:
            //        if (listView1.Items[2].SubItems[1].Text == "Aborted")
            //        {
            //            MessageBox.Show("Esta tarea ya esta suspendida");
            //        }
            //        else if (listView1.Items[2].SubItems[1].Text == "Running")
            //        {
            //            MessageBox.Show("Esta tarea ya esta en ejecucion");
            //        }
            //        else
            //        {
            //            Tarea3.Resume();
            //            listView1.Items[2].SubItems[1].Text = Tarea3.ThreadState.ToString();
            //        }
            //        break;
            //    default:
            //        break;
            //}
        }
        private void buttonWait_Click(object sender, EventArgs e)
        {
            //switch (listView1.FocusedItem.Index)
            //{
            //    case 0:
            //        if (listView1.Items[0].SubItems[1].Text == "Aborted")
            //        {
            //            MessageBox.Show("Esta tarea ya esta suspendida");
            //        }
            //        else
            //        {
            //            Tarea1.Suspend();
            //            listView1.Items[0].SubItems[1].Text = Tarea1.ThreadState.ToString();
            //        }
            //        break;
            //    case 1:
            //        if (listView1.Items[1].SubItems[1].Text == "Aborted")
            //        {
            //            MessageBox.Show("Esta tarea ya esta suspendida");
            //        }
            //        else
            //        {
            //            Tarea2.Suspend();
            //            listView1.Items[1].SubItems[1].Text = Tarea2.ThreadState.ToString();
            //        }
            //        break;
            //    case 2:
            //        if (listView1.Items[2].SubItems[1].Text == "Aborted")
            //        {
            //            MessageBox.Show("Esta tarea ya esta suspendida");
            //        }
            //        else
            //        {
            //            Tarea3.Suspend();
            //            listView1.Items[2].SubItems[1].Text = Tarea3.ThreadState.ToString();
            //        }
            //        break;
            //    default:
            //        break;
            //}
        }
        private void buttonStop_Click(object sender, EventArgs e)
        {
            //switch (listView1.FocusedItem.Index)
            //{
            //    case 0:
            //        Tarea1.Abort();
            //        listView1.Items[0].SubItems[1].Text = Tarea1.ThreadState.ToString();
            //        break;
            //    case 1:
            //        Tarea2.Abort();
            //        listView1.Items[1].SubItems[1].Text = Tarea2.ThreadState.ToString();
            //        break;
            //    case 2:
            //        Tarea2.Start();
            //        listView1.Items[2].SubItems[1].Text = Tarea3.ThreadState.ToString();
            //        break;
            //    default:
            //        break;
            //}
        }
        //private void buttonRun_Click(object sender, EventArgs e)
        //{
        //switch (listView1.FocusedItem.Index)
        //{
        //    case 0:
        //        if (listView1.Items[0].SubItems[1].Text == "Running")
        //        {
        //            MessageBox.Show("Esta tarea ya esta en ejecucion");
        //        }
        //        else if (listView1.Items[0].SubItems[1].Text == "Aborted")
        //        {
        //            MessageBox.Show("Esta tarea ya esta suspendida");
        //        }
        //        else if (listView1.Items[0].SubItems[1].Text == "Suspended")
        //        {
        //            MessageBox.Show("Esta tarea se encuentra suspendida");
        //        }
        //        else
        //        {
        //            Tarea1.Start();
        //            listView1.Items[0].SubItems[1].Text = Tarea1.ThreadState.ToString();
        //        }
        //        break;
        //    case 1:
        //        if (listView1.Items[1].SubItems[1].Text == "Running")
        //        {
        //            MessageBox.Show("Esta tarea ya esta en ejecucion");
        //        }
        //        else if (listView1.Items[1].SubItems[1].Text == "Aborted")
        //        {
        //            MessageBox.Show("Esta tarea ya esta suspendida");
        //        }
        //        else if (listView1.Items[1].SubItems[1].Text == "Suspended")
        //        {
        //            MessageBox.Show("Esta tarea se encuentra suspendida");
        //        }
        //        else
        //        {
        //            Tarea2.Start();
        //            listView1.Items[1].SubItems[1].Text = Tarea2.ThreadState.ToString();
        //        }
        //        break;
        //    case 2:
        //        if (listView1.Items[2].SubItems[1].Text == "Running")
        //        {
        //            MessageBox.Show("Esta tarea ya esta en ejecucion");
        //        }
        //        else if (listView1.Items[2].SubItems[1].Text == "Aborted")
        //        {
        //            MessageBox.Show("Esta tarea ya esta suspendida");
        //        }
        //        else if (listView1.Items[2].SubItems[1].Text == "Suspended")
        //        {
        //            MessageBox.Show("Esta tarea se encuentra suspendida");
        //        }
        //        else
        //        {
        //            Tarea3.Start();
        //            listView1.Items[2].SubItems[1].Text = Tarea3.ThreadState.ToString();
        //        }
        //        break;
        //    default:
        //        break;
        //}
        //}
    }
}

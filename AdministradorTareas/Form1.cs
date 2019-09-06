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
using System.Timers;

namespace AdministradorTareas
{
    public partial class Form1 : Form
    {
        Thread thread1, thread2;
        private Process[] process;
        private Queue<Process> colaProcesos;//cola de procesos
        private static System.Timers.Timer aTimer;       

        public Form1()
        {
            InitializeComponent();
            thread1 = new Thread(new ThreadStart(CProceso));
            //thread2 = new Thread(new ThreadStart(CProceso));
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
            TimerRun();
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
                AddProceso();
            //Console.WriteLine(thread.ThreadState);
        }
        private void buttonResume_Click(object sender, EventArgs e)
        {
            Run(thread1);
            dataGridProceso.CurrentRow.Cells[1].Value = thread1.ThreadState;
        }
        private void buttonWait_Click(object sender, EventArgs e)
        {
            Suspend(thread1);
            dataGridProceso.CurrentRow.Cells[1].Value = thread1.ThreadState;
        }
        private void buttonStop_Click(object sender, EventArgs e)
        {
            Stop(ref thread1);
            dataGridProceso.CurrentRow.Cells[1].Value = thread1.ThreadState;           
        }
        private static void TimerRun()
        {
            Random rnd = new Random();
            int Timers = rnd.Next(90000, 100000);
            aTimer = new System.Timers.Timer(Timers);
        }
    }
}

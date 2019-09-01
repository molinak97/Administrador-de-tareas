namespace AdministradorTareas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonWait = new System.Windows.Forms.Button();
            this.buttonResume = new System.Windows.Forms.Button();
            this.dataGridProceso = new System.Windows.Forms.DataGridView();
            this.Proceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProceso)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administrador de Procesos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(291, 136);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(126, 35);
            this.buttonStop.TabIndex = 4;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonWait
            // 
            this.buttonWait.Location = new System.Drawing.Point(291, 99);
            this.buttonWait.Name = "buttonWait";
            this.buttonWait.Size = new System.Drawing.Size(126, 31);
            this.buttonWait.TabIndex = 5;
            this.buttonWait.Text = "Wait";
            this.buttonWait.UseVisualStyleBackColor = true;
            this.buttonWait.Click += new System.EventHandler(this.buttonWait_Click);
            // 
            // buttonResume
            // 
            this.buttonResume.Location = new System.Drawing.Point(291, 59);
            this.buttonResume.Name = "buttonResume";
            this.buttonResume.Size = new System.Drawing.Size(126, 34);
            this.buttonResume.TabIndex = 6;
            this.buttonResume.Text = "Resume";
            this.buttonResume.UseVisualStyleBackColor = true;
            this.buttonResume.Click += new System.EventHandler(this.buttonResume_Click);
            // 
            // dataGridProceso
            // 
            this.dataGridProceso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProceso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Proceso,
            this.Estado});
            this.dataGridProceso.Location = new System.Drawing.Point(28, 59);
            this.dataGridProceso.Name = "dataGridProceso";
            this.dataGridProceso.Size = new System.Drawing.Size(244, 252);
            this.dataGridProceso.TabIndex = 7;
            // 
            // Proceso
            // 
            this.Proceso.HeaderText = "Proceso";
            this.Proceso.Name = "Proceso";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 323);
            this.Controls.Add(this.dataGridProceso);
            this.Controls.Add(this.buttonResume);
            this.Controls.Add(this.buttonWait);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Administrador de procesos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProceso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonWait;
        private System.Windows.Forms.Button buttonResume;
        private System.Windows.Forms.DataGridView dataGridProceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}


namespace ProcessManager
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lv_Processes = new System.Windows.Forms.ListView();
            this.Pid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProcessName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CountOfThreads = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_AddProcess = new System.Windows.Forms.Button();
            this.btn_KillProcess = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.Memory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lv_Processes
            // 
            this.lv_Processes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProcessName,
            this.Pid,
            this.Memory,
            this.CountOfThreads});
            this.lv_Processes.Location = new System.Drawing.Point(12, 12);
            this.lv_Processes.Name = "lv_Processes";
            this.lv_Processes.Size = new System.Drawing.Size(428, 323);
            this.lv_Processes.TabIndex = 0;
            this.lv_Processes.UseCompatibleStateImageBehavior = false;
            this.lv_Processes.View = System.Windows.Forms.View.Details;
            // 
            // Pid
            // 
            this.Pid.Text = "PID";
            this.Pid.Width = 79;
            // 
            // ProcessName
            // 
            this.ProcessName.Text = "Name";
            this.ProcessName.Width = 151;
            // 
            // CountOfThreads
            // 
            this.CountOfThreads.Text = "Threads";
            this.CountOfThreads.Width = 83;
            // 
            // btn_AddProcess
            // 
            this.btn_AddProcess.Location = new System.Drawing.Point(12, 347);
            this.btn_AddProcess.Name = "btn_AddProcess";
            this.btn_AddProcess.Size = new System.Drawing.Size(118, 23);
            this.btn_AddProcess.TabIndex = 1;
            this.btn_AddProcess.Text = "Добавить задачу";
            this.btn_AddProcess.UseVisualStyleBackColor = true;
            this.btn_AddProcess.Click += new System.EventHandler(this.btn_AddProcess_Click);
            // 
            // btn_KillProcess
            // 
            this.btn_KillProcess.Location = new System.Drawing.Point(260, 347);
            this.btn_KillProcess.Name = "btn_KillProcess";
            this.btn_KillProcess.Size = new System.Drawing.Size(95, 23);
            this.btn_KillProcess.TabIndex = 2;
            this.btn_KillProcess.Text = "Снять задачу";
            this.btn_KillProcess.UseVisualStyleBackColor = true;
            this.btn_KillProcess.Click += new System.EventHandler(this.btn_KillProcess_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(361, 347);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(79, 23);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.Text = "Закрыть";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(136, 347);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(118, 23);
            this.btn_Update.TabIndex = 4;
            this.btn_Update.Text = "Обновить список";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // Memory
            // 
            this.Memory.Text = "Memory Used";
            this.Memory.Width = 93;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 382);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_KillProcess);
            this.Controls.Add(this.btn_AddProcess);
            this.Controls.Add(this.lv_Processes);
            this.Name = "FormMain";
            this.Text = "Менеджер процессов Windows";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_Processes;
        private System.Windows.Forms.ColumnHeader Pid;
        private System.Windows.Forms.ColumnHeader ProcessName;
        private System.Windows.Forms.ColumnHeader CountOfThreads;
        private System.Windows.Forms.Button btn_AddProcess;
        private System.Windows.Forms.Button btn_KillProcess;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.ColumnHeader Memory;
    }
}


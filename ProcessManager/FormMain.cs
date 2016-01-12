using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using log4net.Config; 

namespace ProcessManager
{
    public partial class FormMain : Form
    {
        public static readonly ILog log = LogManager.GetLogger(typeof(FormMain));  
        public FormMain()
        {
            log.Info("Менеджер процесів запущено");
            InitializeComponent();
            ViewListOfTasks();
        }
        public void ViewListOfTasks()
        {
            lv_Processes.Items.Clear();
            var lstOfProcesses = from proc in Process.GetProcesses() 
                                 orderby proc.PagedMemorySize64 descending
                                 select proc;
            ShowProcesses(lstOfProcesses);
            log.Info("Список запущених процесів відображено");
        }
        private void ShowProcesses(IOrderedEnumerable<Process> lstOfProcesses)
        {
            foreach (var proc in lstOfProcesses)
            {
                lv_Processes.Items.Add(String.Format("{0}.exe", proc.ProcessName)).SubItems.AddRange(new string[]
                {proc.Id.ToString(),(proc.PagedMemorySize64/(1024*1024)).ToString()+"M", 
                 proc.Threads.Count.ToString()});
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            ViewListOfTasks();
            log.Info("Оновлення списку процесів");
            lv_Processes.Focus();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_KillProcess_Click(object sender, EventArgs e)
        {
            log.Warn("Намагання знищити процес");
            log.Error("Неможливо знищити процесс через відсутність прав");
            if (lv_Processes.SelectedItems.Count != 0)
            {
                var confirmation = MessageBox.Show("Убить процесс?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation == DialogResult.Yes)
                {
                    try { KillTasks(lv_Processes.SelectedItems); }
                    catch (InvalidOperationException) 
                    {
                        
                        MessageBox.Show("Не достаточно прав для выполнения"); 
                    }
                }   
            }
            else
                MessageBox.Show("Выберите процесс для завершения", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private void KillTasks(ListView.SelectedListViewItemCollection selectedItems)
        {
            var tasksNames = GetTaskNameToKill(selectedItems);
            foreach (var taskName in tasksNames)
                foreach (var procToKill in Process.GetProcessesByName(taskName))
                {
                    procToKill.Kill();
                }
            btn_Update.PerformClick();
        }
        private List<string> GetTaskNameToKill(ListView.SelectedListViewItemCollection selectedItems)
        {
            List<string> tasksToKill = new List<string>();
            foreach (ListViewItem item in selectedItems)
            {
                tasksToKill.Add(item.Text.Substring(0, item.Text.Length - 4));
            }
            return tasksToKill;
        }

        private void btn_AddProcess_Click(object sender, EventArgs e)
        {
            String nameOfProsses;
            if (FormAddProcess.InputTask(out nameOfProsses))
                try
                {
                    Process.Start(nameOfProsses);
                }
                catch
                {
                    MessageBox.Show("Неизвестный параметр");
                }
            ViewListOfTasks();
            lv_Processes.Focus();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessManager
{
    public partial class FormAddProcess : Form
    { 
        private static FormAddProcess formAddProcess = new FormAddProcess();

        private bool _enabled;
        private String _temp;
        public FormAddProcess()
        {
            InitializeComponent();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            _temp = this.tb_Name.Text;
            _enabled = true;
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            _enabled = false;
            this.Close();
        }
        public static bool InputTask(out String nameOfProsses)
        {
            formAddProcess.ShowDialog();
            nameOfProsses = formAddProcess._temp;
            return formAddProcess._enabled;
        }
    }
}

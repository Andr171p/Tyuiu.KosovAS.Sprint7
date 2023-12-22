using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.KosovAS.Sprint7.Project.V4
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void buttonInfo_KAS_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonLibrary_KAS_Click(object sender, EventArgs e)
        {
            FormLibrary formLibrary = new FormLibrary();
            formLibrary.ShowDialog();
        }

        private void buttonTask_KAS_Click(object sender, EventArgs e)
        {
            FormTask formTask = new FormTask();
            formTask.ShowDialog();
        }
    }
}

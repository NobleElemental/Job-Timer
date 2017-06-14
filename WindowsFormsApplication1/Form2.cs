using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.JobTimer' table. You can move, or remove it, as needed.
            this.jobTimerTableAdapter1.Fill(this.database1DataSet1.JobTimer);
            // TODO: This line of code loads data into the 'database1DataSet.JobTimer' table. You can move, or remove it, as needed.

        }

        private void jobTimerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jobTimerBindingSource.EndEdit();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recall
{
    public partial class Form2 : Form
    {
        event Action ss;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppData.connectionString = ConnectionStringTextBox.Text;
            AppData.InvokeTextChanged();
            //StreamWriter ws = File.AppendText("C:\\File.txt");
            this.Close();
        }
    }
}

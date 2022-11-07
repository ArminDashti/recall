using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace recall
{
    public partial class add_form : Form
    {
        public add_form()
        {
            InitializeComponent();
        }

        private void titleone_TextChanged(object sender, EventArgs e)
        {

        }

        private async void addbutton_Click(object sender, EventArgs e)
        {
            //Form form = new Form1();
            //form.Npg

            NpgsqlConnection dbc = Form1.dataBaseConnection;
            string titleone = this.titleone.Text;
            string titletwo = this.titletwo.Text;
            string source = this.source.Text;
            string typetext = this.typetext.Text;
            int instime = Int32.Parse(this.instime.Text);
            await using (var cmd = new NpgsqlCommand("INSERT INTO  (title_one, title_two, ins_time, _type, _source) VALUES (@t1, @t2, @i, @ty, @s)", dbc))
            {
                cmd.Parameters.AddWithValue("t1", titleone);
                cmd.Parameters.AddWithValue("t2", titletwo);
                cmd.Parameters.AddWithValue("i", instime);
                cmd.Parameters.AddWithValue("ty", typetext);
                cmd.Parameters.AddWithValue("s", source);
                await cmd.ExecuteNonQueryAsync();
            }
                MessageBox.Show("Done");
        }
    }
}

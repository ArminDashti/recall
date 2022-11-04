using Npgsql;
using System.Text.RegularExpressions;
namespace recall
{
    public partial class Form1 : Form
    {
        private NpgsqlConnection? dataBaseConnection;
        private Regex regex;

        public Form1()
        {
            InitializeComponent();
        }
        //Host=localhost;Username=postgres;Password=2142;Database=postgres
        private async void InitializeConnection()
        {
            if(!AppData.connectionString.Equals(""))
            {
                dataBaseConnection = new NpgsqlConnection(AppData.connectionString);
                await dataBaseConnection.OpenAsync();
                FetchData();
            }

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            FetchData();
        }


        private async void FetchData()
        {
            try
            {

                await using (var cmd = new NpgsqlCommand("SELECT * FROM test ORDER BY random() LIMIT 1", dataBaseConnection))
                //await using (var cmd = new NpgsqlCommand("SELECT * FROM recall", dataBaseConnection))
                await using (var reader = await cmd.ExecuteReaderAsync())
                    while (await reader.ReadAsync())
                    {
                        richTextBox1.Text = reader.GetValue(0).ToString();
                        richTextBox2.Text = reader.GetValue(1).ToString();
                    }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private async void Form1_Load(object sender, EventArgs e)
        {
            InitializeConnection();
            AppData.onStringChanged += InitializeConnection;
            regex = new Regex("[\u0600-\u06ff]|[\u0750-\u077f]|[\ufb50-\ufc3f]|[\ufe70-\ufefc]");

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (regex.IsMatch(richTextBox2.Text))
            {
                richTextBox2.RightToLeft = RightToLeft.Yes;
            }
            else
            {
                richTextBox2.RightToLeft = RightToLeft.No;

            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (regex.IsMatch(richTextBox1.Text))
            {
                richTextBox1.RightToLeft = RightToLeft.Yes;
            }
            else
            {
                richTextBox1.RightToLeft = RightToLeft.No;

            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 settings = new Form2();
            settings.Show();
        }
    }
}
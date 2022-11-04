using Npgsql;
using System.Data;

namespace recall
{

    public partial class Form1 : Form
    {
        NpgsqlConnection dataBaseConnection;
        public Form1()
        {
            InitializeComponent();
        }

        async Task InitializeConnection()
        {
            var dataGetter = new conection_database();
            dataBaseConnection = await dataGetter.GetConnection();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                await using (var cmd = new NpgsqlCommand("SELECT * FROM recall ORDER BY random() LIMIT 1", dataBaseConnection))
                await using (var reader = await cmd.ExecuteReaderAsync())
                    while (await reader.ReadAsync())
                    {
                        richTextBox1.Text = reader.GetValue(1).ToString();
                        richTextBox2.Text = reader.GetValue(2).ToString();
                    }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
             InitializeConnection();
        }
    }

    //private async void button1_Click(object sender, EventArgs e)
    //{
    //    await using (var cmd = new NpgsqlCommand("SELECT * FROM recall ORDER BY random() LIMIT 1", conn));
    //    await using (var reader = await cmd.ExecuteReaderAsync()) ;
    //    while (await reader.ReadAsync())
    //    {
    //        richTextBox1.Text = reader.GetValue(1).ToString();
    //        richTextBox2.Text = reader.GetValue(2).ToString();
    //    }
    //}

    //private async void Form1_Load(object sender, EventArgs e)
    //{
    //    var ac = new conection_database();
    //    var d = ac.GetConnection;
    //    conn.OpenAsync();
    //}

    //private void richTextBox1_TextChanged(object sender, EventArgs e)
    //{

    //}

    //private void add_Click(object sender, EventArgs e)
    //{

    //}
}

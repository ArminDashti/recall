using Npgsql;

namespace recall
{
    public partial class Form1 : Form
    {
        private NpgsqlConnection? dataBaseConnection;

        public Form1()
        {
            InitializeComponent();
        }

        private async void InitializeConnection()
        {
            var connString = "Host=localhost;Username=postgres;Password=2142;Database=postgres";
            dataBaseConnection = new NpgsqlConnection(connString);
            await dataBaseConnection.OpenAsync();
            FetchData();
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
        }
    }
}
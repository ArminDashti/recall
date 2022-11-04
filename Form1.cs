using Npgsql;
using System.Data;

namespace recall
{

    public partial class Form1 : Form
    {
        NpgsqlConnection d;
        public Form1()
        {
            InitializeComponent();
        }
    }

    private async void button1_Click(object sender, EventArgs e)
    {
        await using (var cmd = new NpgsqlCommand("SELECT * FROM recall ORDER BY random() LIMIT 1", conn));
        await using (var reader = await cmd.ExecuteReaderAsync()) ;
        while (await reader.ReadAsync())
        {
            richTextBox1.Text = reader.GetValue(1).ToString();
            richTextBox2.Text = reader.GetValue(2).ToString();
        }
    }

    private async void Form1_Load(object sender, EventArgs e)
    {
        var ac = new conection_database();
        var d = ac.ccc;
        conn.OpenAsync();
    }

    private void richTextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void add_Click(object sender, EventArgs e)
    {

    }
}

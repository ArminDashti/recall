using Npgsql;
using System;
using System.Text.RegularExpressions;
namespace recall
{
    public partial class MainWindow : Form
    {
        public static NpgsqlConnection? dataBaseConnection;
        private Regex regex;
        private Int64 _id;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void update_table(int id, string title1, string title2, string _source, string _type)
        {

        }
        private async void InitializeConnection()
        {
            var connString = "Host=localhost;Username=;Password=;Database=";
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

                await using (var cmd = new NpgsqlCommand("SELECT * FROM ORDER BY random() LIMIT 1", dataBaseConnection))
                await using (var reader = await cmd.ExecuteReaderAsync())
                    while (await reader.ReadAsync())
                    {
                        id_form_recall.Text = reader.GetValue(0).ToString();
                        titleTextBox.Text = reader.GetValue(1).ToString();
                        titletwo.Text = reader.GetValue(2).ToString();
                        source_recall_form.Text = reader.GetValue(3).ToString();
                        type_recall_form.Text = reader.GetValue(4).ToString();
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
            regex = new Regex("[\u0600-\u06ff]|[\u0750-\u077f]|[\ufb50-\ufc3f]|[\ufe70-\ufefc]");

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (regex.IsMatch(titletwo.Text))
            {
                titletwo.RightToLeft = RightToLeft.Yes;
            }
            else
            {
                titletwo.RightToLeft = RightToLeft.No;

            }
        }

        private void add_Click(object sender, EventArgs e)
        { 
            Form settingsForm = new add_form();
            settingsForm.Show();
        }

        private async void update_form_recall_Click(object sender, EventArgs e)
        {
            await using (var cmd = new NpgsqlCommand("UPDATE  SET title_one = @t1, title_two=@t2, _type=@_ty, _source=@s WHERE id = @_id", dataBaseConnection))
            {
                cmd.Parameters.AddWithValue("t1", titleTextBox.Text);
                cmd.Parameters.AddWithValue("t2", titletwo.Text);
                cmd.Parameters.AddWithValue("s", source_recall_form.Text);
                cmd.Parameters.AddWithValue("_ty", type_recall_form.Text);
                cmd.Parameters.AddWithValue("_id", Convert.ToInt64(id_form_recall.Text));
                await cmd.ExecuteNonQueryAsync();
            }
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (regex.IsMatch(titleTextBox.Text))
            {
                titleTextBox.RightToLeft = RightToLeft.Yes;
            }
            else
            {
                titleTextBox.RightToLeft = RightToLeft.No;

            }
        }
    }
}
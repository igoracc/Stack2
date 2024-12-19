using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Izvjestaji
{
    public partial class frmIzvjestaj : Form
    {
        /// <summary>
        /// private string connectionString = "Data Source=LUKIML21325\\SQL2017;Initial Catalog=IGOR;Integrated Security=True";
        /// </summary>
        private string connectionString = "Data Source=LUKIML21325\\SQL2017;Initial Catalog=IGOR;User ID=sa;Password=12!?qwQW;";
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        private BindingSource bindingSource;  // Dodaj BindingSource varijablu

        public frmIzvjestaj()
        {
            InitializeComponent();

            // Inicijalizacija komponenata
            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter(
                 "SELECT Id, Datum, Zadatak, Vrijeme, Tip, " +
                 "CASE WHEN Tip = 1 THEN 'Podrska' " +
                 "WHEN Tip = 2 THEN 'Dorada' " +
                 "WHEN Tip = 3 THEN 'Edukacija' " +
                 "ELSE 'N/A' END AS TipOpis " +
                 "FROM Izvjestaj order by datum desc ,ID desc    ", connection);
            dataTable = new DataTable();
            bindingSource = new BindingSource();  // Inicijaliziraj BindingSource

            dataGridView1.AutoGenerateColumns = false;  // Onemogući automatsko generisanje kolona

            // Povezivanje događaja Form Load s metodom
            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Poziv metode za učitavanje podataka
            LoadData();

            // Postavljanje BindingSource-a kao izvor podataka za DataGridView
            bindingSource.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource;

            FilterDataByDate(dtFilter.Value);

            checkBox2.Checked = true;

        }

        private void LoadData()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                dataTable.Clear();  // Očisti trenutne podatke kako bi se izbjeglo dupliranje
                adapter.Fill(dataTable);
                bindingSource.ResetBindings(false);  // Osvježi podatke u BindingSource-u
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO Izvjestaj (Datum, Zadatak, Vrijeme, Tip) VALUES (@Datum, @Zadatak, @Vrijeme, @Tip)", connection))
                {
                    command.Parameters.AddWithValue("@Datum", dateTimePicker1.Value);
                    command.Parameters.AddWithValue("@Zadatak", textBox1.Text);
                    command.Parameters.AddWithValue("@Vrijeme", numericUpDown1.Value);
                    int tip = 1;
                    if (radioButton2.Checked) tip = 2;
                    else if (radioButton3.Checked) tip = 3;
                    command.Parameters.AddWithValue("@Tip", tip);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadData();

                textBox1.Text = "";
                numericUpDown1.Value = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonIzmijeni_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        int id = Convert.ToInt32(row.Cells["Id"].Value);

                        using (SqlCommand command = new SqlCommand("UPDATE Izvjestaj SET Datum = @Datum, Zadatak = @Zadatak, Vrijeme = @Vrijeme, Tip = @Tip WHERE Id = @Id", connection))
                        {
                            command.Parameters.AddWithValue("@Datum", dateTimePicker1.Value);
                            command.Parameters.AddWithValue("@Zadatak", textBox1.Text);
                            command.Parameters.AddWithValue("@Vrijeme", numericUpDown1.Value);
                            int tip = 1;
                            if (radioButton2.Checked) tip = 2;
                            else if (radioButton3.Checked) tip = 3;
                            command.Parameters.AddWithValue("@Tip", tip);
                            command.Parameters.AddWithValue("@Id", id);

                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();

                            MessageBox.Show("Uspješno ažuriran red", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Nije odabran red za izmjenu.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        int id = Convert.ToInt32(row.Cells["Id"].Value);

                        // Show confirmation message box
                        DialogResult result = MessageBox.Show("Da li želite izbrisati stavku?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            using (SqlCommand command = new SqlCommand("DELETE FROM Izvjestaj WHERE Id = @Id", connection))
                            {
                                command.Parameters.AddWithValue("@Id", id);

                                connection.Open();
                                command.ExecuteNonQuery();
                                connection.Close();
                            }
                        }
                    }
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Nije odabran red za brisanje.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                // Provjeri da li je kliknuta validna ćelija (ne zaglavlje)
                if (e.RowIndex >= 0)
                {
                    // Dohvati odabrani red iz DataGridView-a
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                    // Postavi vrijednosti iz odabranog reda u odgovarajuće kontrole
                    dateTimePicker1.Value = Convert.ToDateTime(selectedRow.Cells["Datum"].Value);
                    textBox1.Text = selectedRow.Cells["Zadatak"].Value.ToString();
                    numericUpDown1.Value = Convert.ToDecimal(selectedRow.Cells["Vrijeme"].Value);

                    // Postavi vrijednost za Tip u odgovarajući RadioButton
                    int tip = Convert.ToInt32(selectedRow.Cells["Tip"].Value);
                    if (tip == 1) radioButton1.Checked = true;
                    else if (tip == 2) radioButton2.Checked = true;
                    else if (tip == 3) radioButton3.Checked = true;
                }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value += 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value -= 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            textBox1.Text = Clipboard.GetText();    
            numericUpDown1.Focus();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(textBox1.Text);

        }

        private void dtFilter_ValueChanged(object sender, EventArgs e)
        {
            FilterDataByDate(dtFilter.Value);
        }


        private void FilterDataByDate(DateTime selectedDate)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                // Očisti trenutne podatke kako bi se izbjeglo dupliranje
                dataTable.Clear();

                // Priprema SQL upita sa filtriranjem po datumu
                string query = "SELECT Id, Datum, Zadatak, Vrijeme, Tip, " +
                               "CASE WHEN Tip = 1 THEN 'Podrska' " +
                               "WHEN Tip = 2 THEN 'Dorada' " +
                               "WHEN Tip = 3 THEN 'Edukacija' " +
                               "ELSE 'N/A' END AS TipOpis " +
                               "FROM Izvjestaj ";


                if (checkBox1.Checked == true)
                {
                    query = query + "WHERE CAST(Datum AS DATE) = @SelectedDate ";
                }
                else if (checkBox2.Checked == true)
                {
                    query = query + "WHERE CAST(Datum AS DATE) >= @SelectedDate AND CAST(Datum AS DATE) <= @SelectedDate2 "; 
                }




                query = query + "ORDER BY Datum DESC, ID DESC";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SelectedDate", selectedDate.Date);

                    if (checkBox2.Checked == true)
                    {
                        command.Parameters.AddWithValue("@SelectedDate2", dtDoDatuma.Value);
                    }

                    adapter.SelectCommand = command;  // Postavi upit za adapter
                    adapter.Fill(dataTable);  // Učitaj podatke
                }

                bindingSource.ResetBindings(false);  // Osvježi podatke u BindingSource-u
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }


            CalculateTotalHours();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            FilterDataByDate(dtFilter.Value);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked ==true)
            {
                timer1.Enabled = true;  

            }else
            {
                timer1.Enabled=false;
            }



        }



        private void CalculateTotalHours()
        {
            int totalHours = 0;

            // Pretpostavljamo da je dataGridView1 tvoj DataGrid
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Proveri da li je red validan (nije novi red)
                if (row.Cells["Vrijeme"].Value != null)
                {
                    // Proverimo da li je vrednost integer
                    if (int.TryParse(row.Cells["Vrijeme"].Value.ToString(), out int hoursValue))
                    {
                        totalHours += hoursValue; // Saberi sate
                    }
                }
            }

            // Prikazuj zbir u numUkupno
            numUkupno.Value = totalHours; // Postavi vrednost u NumericUpDown
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            try
            {
                textBox1.Text = Clipboard.GetText();
            }
            catch (Exception)
            {

                ///throw;
            }





        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            FilterDataByDate(dtFilter.Value);

        }
    }
}

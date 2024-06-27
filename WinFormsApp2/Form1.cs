using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MedicationRegistry
{
    public partial class Form1 : Form
    {
        private List<Medication> medications = new List<Medication>();

        public Form1()
        {
            InitializeComponent();
            UpdateDataGridView();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Medication medication = new Medication
            {
                Название = nameTextBox.Text,
                Производитель = manufacturerTextBox.Text,
                Количество = int.Parse(quantityTextBox.Text),
                Цена = decimal.Parse(priceTextBox.Text)
            };
            medications.Add(medication);
            UpdateDataGridView();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (medicationsDataGridView.SelectedRows.Count > 0)
            {
                int index = medicationsDataGridView.SelectedRows[0].Index;
                medications.RemoveAt(index);
                UpdateDataGridView();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (medicationsDataGridView.SelectedRows.Count > 0)
            {
                int index = medicationsDataGridView.SelectedRows[0].Index;
                Medication medication = medications[index];
                medication.Название = nameTextBox.Text;
                medication.Производитель = manufacturerTextBox.Text;
                medication.Количество = int.Parse(quantityTextBox.Text);
                medication.Цена = decimal.Parse(priceTextBox.Text);
                UpdateDataGridView();
            }
        }

        private void UpdateDataGridView()
        {
            medicationsDataGridView.DataSource = null;
            medicationsDataGridView.DataSource = medications;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void medicationsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class Medication
    {
        public string Название { get; set; }
        public string Производитель { get; set; }
        public int Количество { get; set; }
        public decimal Цена{ get; set; }

        public override string ToString()
        {
            return $"{Название} - {Производитель} - {Количество} - {Цена:C}";
        }
    }
}

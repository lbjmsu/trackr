using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trackrForms.trackrDBDataSetTableAdapters;

namespace trackrForms
{
    public partial class CreateHabit : Form
    {
        public CreateHabit()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (typeNameComboBox.SelectedItem.ToString() == "Numerical")
            {
                pos_negLabel.Visible = true;
                pos_negComboBox.Visible = true;
                thresholdLabel.Visible = true;
                thresholdNumericUpDown.Visible = true;
                more_lessLabel.Visible = false;
            }
            else
            {
                pos_negLabel.Visible = false;
                pos_negComboBox.Visible = false;
                thresholdLabel.Visible = false;
                thresholdNumericUpDown.Visible = false;
                more_lessLabel.Visible = false;
            }
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (pos_negComboBox.SelectedItem.ToString() == "Positive")
            {
                more_lessLabel.Text = "or more";
                more_lessLabel.Visible = true;
            }
            else if (pos_negComboBox.SelectedItem.ToString() == "Negative")
            {
                more_lessLabel.Text = "or less";
                more_lessLabel.Visible = true;
            }
            else
            {
                more_lessLabel.Visible = false;
            }
            
        }

        private void createHabitButton_Click(object sender, EventArgs e)
        {
            //  Create table both to test and retrieve largest ID value for insertion into the table.
            trackrDBDataSet.habitTableDataTable newTable = new trackrDBDataSet.habitTableDataTable();
            habitTableTableAdapter.Fill(newTable);

            //  Insert value based on the user input
            habitTableTableAdapter.Insert(Int32.Parse(newTable.Rows[newTable.Rows.Count - 1].ItemArray[0].ToString())+1,
                habitNameTextBox.Text, typeNameComboBox.Text, Int32.Parse(thresholdNumericUpDown.Value.ToString()),
                pos_negComboBox.Text == "Positive", true, 0);

            //  Greater than 0 means that successful updates have occurred. This is 0 so I'm guessing no updates succeeded, however, the output
            //      db changed successfully.
            MessageBox.Show(habitTableTableAdapter.Update(trackrDBDataSet1).ToString());

            //  Fill table again to show more proof that the table was locally updated, as according to the program (Shows RowsCount, ID of newest row)
            habitTableTableAdapter.Fill(newTable);
            MessageBox.Show(newTable.Rows.Count.ToString() + " " + newTable.Rows[2].ItemArray[0]);

            //  Close form
            Close();
        }
    }
}

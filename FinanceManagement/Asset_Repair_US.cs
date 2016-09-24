using MetroFramework;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceManagement
{
    public partial class Asset_Repair_US : Form
    {
        int rowindex;
        String cclick;
        public Asset_Repair_US()
        {
            InitializeComponent();
        }

        private void radioButton_cannot_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_done_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_pending_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_repair_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox_repairid_TextChanged(object sender, EventArgs e)
        {
            FillSpecificRepair();

            if (textBox_repairid.Text.Length > 3)
            {
                if ((String.IsNullOrWhiteSpace(textBox_repairid.Text)) || (textBox_repairid.Text == " ") || (textBox_repairid.Text[0] != 'R') || (textBox_repairid.Text[1] != 'I') || (textBox_repairid.Text[2] != 'D'))
                    errorProvider1.SetError(textBox_repairid, "Eg: RID000");
                else
                    errorProvider1.Clear();
            }
            try
            {

                DBConnects connection = new DBConnects();
                connection.OpenConnection();

                MySqlConnection returnConn = new MySqlConnection();
                returnConn = connection.GetConnection();

                string query = "SELECT * FROM asset_repair WHERE Repair_ID = '" + textBox_repairid.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, returnConn);

                try
                {

                    using (MySqlDataReader read = cmd.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            String ainsurance;
                            String awarranty;
                            String astatus;
                            //comboBox_property.Text = read.GetString("Property").ToString();
                            textBox_assetID.Text = read.GetString("Asset_ID").ToString();
                            dateTimePicker_repair.Text = read.GetString("Job_Date").ToString();
                            textBox_serialnumber.Text = read.GetString("Serial_Number").ToString();

                            ainsurance = read.GetString("Insurance_Status").ToString();
                            if (ainsurance == "Yes")
                                checkBox_insurance.Checked = true;
                            else
                                checkBox_insurance.Checked = false;

                            awarranty = read.GetString("Warranty_Status").ToString();
                            if (awarranty == "Yes")
                                checkBox_warranty.Checked = true;
                            else
                                checkBox_warranty.Checked = false;

                            astatus = read.GetString("Job_Status").ToString();
                            if (astatus == "Pending")
                                radioButton_pending.Checked = true;
                            else if (astatus == "Done")
                                radioButton_done.Checked = true;
                            else
                                radioButton_cannot.Checked = true;

                            richTextBox_problem.Text = read.GetString("Problem_Specified").ToString();
                        }

                    }

                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this,ex.Message);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this,ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox_warranty_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_insurance_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox_problem_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_serialnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_assetID_TextChanged(object sender, EventArgs e)
        {
            FillSpecific();
            if (textBox_assetID.Text.Length > 3)
            {
                if ((String.IsNullOrWhiteSpace(textBox_assetID.Text)) || (textBox_assetID.Text == " ") || (textBox_assetID.Text[0] != 'A') || (textBox_assetID.Text[1] != 'I') || (textBox_assetID.Text[2] != 'D'))
                    errorProvider1.SetError(textBox_assetID, "Eg: AID000");
                else
                    errorProvider1.Clear();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Asset_Repair_US_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        public void FillGrid()
        {
            FinManagement dba = new FinManagement();
            DataSet ds = dba.getAll("asset_repair");
            dataGridView2.DataSource = ds.Tables["asset_repair"].DefaultView;
        }

        public void FillSpecific()
        {
            String passetid;
            passetid = textBox_assetID.Text;
            FinManagement dba = new FinManagement();
            DataSet ds = dba.getSpecificAID("asset_repair", passetid);
            dataGridView2.DataSource = ds.Tables["asset_repair"].DefaultView;
        }

        public void FillSpecificRepair()
        {
            String prepairid;
            prepairid = textBox_repairid.Text;
            FinManagement dba = new FinManagement();
            DataSet ds = dba.getSpecificRID("asset_repair", prepairid);
            dataGridView2.DataSource = ds.Tables["asset_repair"].DefaultView;
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = dataGridView2.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView2.Rows[rowindex];
            cclick = Convert.ToString(selectedRow.Cells["Repair_ID"].Value);
            textBox_repairid.Text = cclick;
            if ((cclick == " ") || (cclick == null) || (cclick == ""))
            {
                textBox_repairid.Clear();
                textBox_assetID.Clear();
                textBox_serialnumber.Clear();
                checkBox_insurance.Checked = false;
                checkBox_warranty.Checked = false;
                radioButton_cannot.Checked = false;
                radioButton_done.Checked = false;
                radioButton_pending.Checked = false;
                richTextBox_problem.Clear();
            }
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = dataGridView2.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView2.Rows[rowindex];
            cclick = Convert.ToString(selectedRow.Cells["repair"].Value);
            textBox_repairid.Text = cclick;
            if ((cclick == " ") || (cclick == null) || (cclick == ""))
            {
                textBox_repairid.Clear();
                textBox_assetID.Clear();
                textBox_serialnumber.Clear();
                checkBox_insurance.Checked = false;
                checkBox_warranty.Checked = false;
                radioButton_cannot.Checked = false;
                radioButton_done.Checked = false;
                radioButton_pending.Checked = false;
                richTextBox_problem.Clear();
            }


        }

        private void button_back_Click_1(object sender, EventArgs e)
        {
            AssetRepair asset = new AssetRepair();
            asset.Show();
            this.Close();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            if ((textBox_assetID.Text == "") || (textBox_assetID.Text == " "))
                MetroMessageBox.Show(this,"Please provide a Asset ID");
            FillSpecific();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            String message = "";
            String passetID = " ";
            String pserial = " ";
            String pdescription = " ";
            String pinsurance = "No";
            String pwarranty = "No";
            String pstatus = "";
            String pjobdate = "";
            try
            {
                if (textBox_repairid.Text.Length > 3)
                {
                    if ((String.IsNullOrWhiteSpace(textBox_repairid.Text)) || (textBox_repairid.Text == " ") || (textBox_repairid.Text[0] != 'R') || (textBox_repairid.Text[1] != 'I') || (textBox_repairid.Text[2] != 'D'))
                        errorProvider1.SetError(textBox_repairid, "Eg: RID000");
                    else
                        errorProvider1.Clear();
                }

                passetID = textBox_assetID.Text;
                if ((String.IsNullOrWhiteSpace(passetID)) || (passetID == " ") || (passetID[0] != 'A') || (passetID[1] != 'I') || (passetID[2] != 'D'))
                    message += "Valid Asset ID\n";

                if (textBox_serialnumber.ReadOnly == false)
                {
                    if (String.IsNullOrWhiteSpace(textBox_serialnumber.Text))
                        message += "Serial Number\n";
                    else
                        pserial = textBox_serialnumber.Text;
                }
                else
                    pserial = " "; ;

                if (radioButton_pending.Checked)
                    pstatus = "Pending";
                else if (radioButton_done.Checked)
                    pstatus = "Done";
                else
                    pstatus = "Cannot";

                pjobdate = dateTimePicker_repair.Value.ToString("yyyy-MM-dd");

                if (checkBox_insurance.Checked)
                    pinsurance = "Yes";

                if (checkBox_warranty.Checked)
                    pwarranty = "Yes";

                if (String.IsNullOrWhiteSpace(richTextBox_problem.Text) || richTextBox_problem.Text == "Please enter the problem specified")
                    message += "Description";
                else
                    pdescription = richTextBox_problem.Text;

                if (message == "")
                {
                    DialogResult result;
                    result = MetroMessageBox.Show(this,"Do you want to Proceed?", "Please confirm the update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            DBConnects connection = new DBConnects();
                            connection.OpenConnection();

                            MySqlConnection returnConn = new MySqlConnection();
                            returnConn = connection.GetConnection();

                            string query = "UPDATE asset_repair SET Job_Date ='" + pjobdate + "', Job_Status='" + pstatus + "', Problem_Specified ='" + richTextBox_problem.Text + "', Serial_Number='" + textBox_serialnumber.Text + "', Warranty_Status='" + pwarranty + "', Insurance_Status='" + pinsurance + "' where Repair_ID='" + textBox_repairid.Text + "'";

                            MySqlCommand cmd = new MySqlCommand(query, returnConn);
                            cmd.Connection = returnConn;
                            cmd.ExecuteNonQuery();
                            connection.CloseConnection();
                            MessageBox.Show("Asset information updated");

                            //refresh
                            textBox_repairid.Clear();
                            textBox_assetID.Clear();
                            textBox_serialnumber.Clear();
                            checkBox_insurance.Checked = false;
                            checkBox_warranty.Checked = false;
                            radioButton_cannot.Checked = false;
                            radioButton_done.Checked = false;
                            radioButton_pending.Checked = false;
                            richTextBox_problem.Clear();
                        }
                        catch (Exception ex)
                        {
                            MetroMessageBox.Show(this,ex.Message);
                        }
                    }
                }
                else
                    MetroMessageBox.Show(this,"" + message, "Please Provide", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this,ex.Message);
            }

            FillGrid();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            FillGrid();
            textBox_repairid.Clear();
            textBox_assetID.Clear();
            textBox_serialnumber.Clear();
            checkBox_insurance.Checked = false;
            checkBox_warranty.Checked = false;
            radioButton_cannot.Checked = false;
            radioButton_done.Checked = false;
            radioButton_pending.Checked = false;
            richTextBox_problem.Clear();
        }

    }
}

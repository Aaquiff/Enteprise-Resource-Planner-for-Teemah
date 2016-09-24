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
    public partial class Asset_US : Form
    {
        int rowindex;
        String cclick;
        public Asset_US()
        {
            InitializeComponent();
        }

        public void FillGrid()
        {
            FinManagement dba = new FinManagement();
            DataSet ds = dba.getAll("asset");
            dataGridView2.DataSource = ds.Tables["asset"].DefaultView;
        }

        private void Asset_US_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillGrid();
            textBox_assetID.Clear();
            comboBox_property.SelectedIndex = -1;
            textBox_serialnumber.Clear();
            textBox_ownership.Clear();
            textBox_value.Clear();
            checkBox_insurance.Checked = false;
            checkBox_warranty.Checked = false;
            checkBox_status.Checked = false;
            textBox_lifetime.Clear();
            textBox_usage.Clear();
            richTextBox_description.Clear();
        }

        private void textBox_assetID_TextChanged(object sender, EventArgs e)
        {
            FillSpecificAID();
            if (textBox_assetID.Text.Length > 3)
            {
                if ((String.IsNullOrWhiteSpace(textBox_assetID.Text)) || (textBox_assetID.Text == " ") || (textBox_assetID.Text[0] != 'A') || (textBox_assetID.Text[1] != 'I') || (textBox_assetID.Text[2] != 'D'))
                    errorProvider1.SetError(textBox_assetID, "Eg: AID000");
                else
                    errorProvider1.Clear();
            }
            try
            {

                DBConnects connection = new DBConnects();
                connection.OpenConnection();

                MySqlConnection returnConn = new MySqlConnection();
                returnConn = connection.GetConnection();

                string query = "SELECT * FROM asset WHERE Asset_ID = '" + textBox_assetID.Text + "'";
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
                            comboBox_property.Text = read.GetString("Property").ToString();
                            textBox_serialnumber.Text = read.GetString("Serial_Number").ToString();
                            textBox_ownership.Text = read.GetString("Ownership").ToString();
                            textBox_value.Text = read.GetString("Asset_Value").ToString();

                            ainsurance = read.GetString("Insurance").ToString();
                            if (ainsurance == "Yes")
                                checkBox_insurance.Checked = true;
                            else
                                checkBox_insurance.Checked = false;

                            awarranty = read.GetString("Warranty").ToString();
                            if (awarranty == "Yes")
                                checkBox_warranty.Checked = true;
                            else
                                checkBox_warranty.Checked = false;

                            astatus = read.GetString("Active_Status").ToString();
                            if (astatus == "Active")
                                checkBox_status.Checked = true;
                            else
                                checkBox_status.Checked = false;

                            textBox_lifetime.Text = read.GetString("Life_Time").ToString();
                            textBox_usage.Text = read.GetString("Year_Usage").ToString();
                            richTextBox_description.Text = read.GetString("Description").ToString();
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

        public void FillSpecific()
        {
            String pproperty;
            pproperty = comboBox_property.Text;
            FinManagement dba = new FinManagement();
            DataSet ds = dba.getSpecific("asset", pproperty);
            dataGridView2.DataSource = ds.Tables["asset"].DefaultView;
        }

        public void FillSpecificAID()
        {
            String passetid;
            passetid = textBox_assetID.Text;
            FinManagement dba = new FinManagement();
            DataSet ds = dba.getSpecificAID("asset", passetid);
            dataGridView2.DataSource = ds.Tables["asset"].DefaultView;
        }

        public bool IsDigit(String temp)
        {
            bool result = false;
            for (int i = 0; i < temp.Length; i++)
            {
                char c = temp[i];
                if (c >= '0' && c <= '9')
                    result = true;

                else
                {
                    result = false;
                    break;
                }


            }
            return result;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void textBox_ownership_TextChanged(object sender, EventArgs e)
        {
            if (IsDigit(textBox_ownership.Text))
                errorProvider1.SetError(textBox_ownership, "Cannot contain digits");
            else
                errorProvider1.Clear();
        }

        private void textBox_value_TextChanged(object sender, EventArgs e)
        {
            if (!IsDigit(textBox_value.Text))
                errorProvider1.SetError(textBox_value, "Cannot contain letter");
            else
                errorProvider1.Clear();
        }

        private void textBox_lifetime_TextChanged(object sender, EventArgs e)
        {
            if (!IsDigit(textBox_lifetime.Text))
                errorProvider1.SetError(textBox_lifetime, "Cannot contain letter");
            else
                errorProvider1.Clear();
        }

        private void textBox_usage_TextChanged(object sender, EventArgs e)
        {
            if (!IsDigit(textBox_lifetime.Text))
                errorProvider1.SetError(textBox_lifetime, "Cannot contain letter");
            else
                errorProvider1.Clear();
        }

        private void comboBox_property_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_property.SelectedIndex != -1)
            {
                String temp = comboBox_property.SelectedItem.ToString();

                if (temp == "Building")
                    textBox_serialnumber.ReadOnly = true;
                else if (temp == "Land")
                    textBox_serialnumber.ReadOnly = true;
                else
                    textBox_serialnumber.ReadOnly = false;
            }
        }

        private void textBox_serialnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = dataGridView2.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView2.Rows[rowindex];
            cclick = Convert.ToString(selectedRow.Cells["asset"].Value);
            textBox_assetID.Text = cclick;
            if ((cclick == " ") || (cclick == null) || (cclick == ""))
            {
                comboBox_property.SelectedItem = -1;
                textBox_serialnumber.Clear();
                textBox_ownership.Clear();
                textBox_value.Clear();
                checkBox_insurance.Checked = false;
                checkBox_warranty.Checked = false;
                checkBox_status.Checked = false;
                textBox_lifetime.Clear();
                textBox_usage.Clear();
                richTextBox_description.Clear();
            }
        }

        private void button_back_Click_1(object sender, EventArgs e)
        {
            AssetManagement asset = new AssetManagement();
            this.Close();
            asset.Show();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            FillSpecific();
        }

        private void button_update_Click_1(object sender, EventArgs e)
        {
            //textBox_assetID.ReadOnly = true;
            String message = "";
            //variable declaration to get the entered values
            String pproperty = " ";
            String passetID = " ";
            String pserial = "Not rated";
            String pownership = " ";
            double pvalue = 0;
            int plifeTime = 0;
            int pusage = 0;
            String pdescription = " ";
            String pinsurance = "No";
            String pwarranty = "No";
            String pstatus = "Inactive";

            try
            {
                passetID = textBox_assetID.Text;
                if ((String.IsNullOrWhiteSpace(passetID)) || (passetID == " ") || (passetID[0] != 'A') || (passetID[1] != 'I') || (passetID[2] != 'D'))
                    message += "Valid Asset ID\n";

                if (comboBox_property.SelectedIndex == -1)
                    message += "Property\n";
                else
                    pproperty = comboBox_property.SelectedItem.ToString();

                if (textBox_serialnumber.ReadOnly == false)
                {
                    if (String.IsNullOrWhiteSpace(textBox_serialnumber.Text))
                        message += "Serial Number\n";
                    else
                        pserial = textBox_serialnumber.Text;
                }
                else
                    pserial = "Not rated";

                if (String.IsNullOrWhiteSpace(textBox_ownership.Text) || (IsDigit(textBox_ownership.Text)))
                    message += "Ownership\n";
                else
                    pownership = textBox_ownership.Text;

                if (String.IsNullOrWhiteSpace(textBox_value.Text) || (!IsDigit(textBox_value.Text)))
                    message += "Value\n";
                else
                    pvalue = Convert.ToDouble(textBox_value.Text);

                if (checkBox_insurance.Checked)
                    pinsurance = "Yes";

                if (checkBox_warranty.Checked)
                    pwarranty = "Yes";

                if (checkBox_status.Checked)
                    pstatus = "Active";

                if (String.IsNullOrWhiteSpace(textBox_lifetime.Text) || (!IsDigit(textBox_lifetime.Text)))
                    message += "Life-Time\n";
                else
                    plifeTime = Convert.ToInt16(textBox_lifetime.Text);

                if (String.IsNullOrWhiteSpace(textBox_usage.Text) || (!IsDigit(textBox_usage.Text)))
                    message += "Usage\n";
                else
                    pusage = Convert.ToInt16(textBox_usage.Text);

                if (String.IsNullOrWhiteSpace(richTextBox_description.Text) || richTextBox_description.Text == "Type all other wanted details here")
                    message += "Description";
                else
                    pdescription = richTextBox_description.Text;

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

                            string query = "UPDATE asset SET Property='" + comboBox_property.Text + "', Serial_Number='" + textBox_serialnumber.Text + "', Ownership='" + textBox_ownership.Text + "', Asset_Value='" + textBox_value.Text + "', Insurance='" + pinsurance + "', Warranty='" + pwarranty + "', Active_Status='" + pstatus + "', Life_Time='" + textBox_lifetime.Text + "', Year_Usage ='" + textBox_usage.Text + "', Description='" + richTextBox_description.Text + "' where Asset_ID='" + textBox_assetID.Text + "'";

                            MySqlCommand cmd = new MySqlCommand(query, returnConn);
                            cmd.Connection = returnConn;
                            cmd.ExecuteNonQuery();
                            connection.CloseConnection();
                            MessageBox.Show("Asset information updated");

                            //refresh
                            FillGrid();
                            comboBox_property.SelectedItem = -1;
                            textBox_serialnumber.Clear();
                            textBox_ownership.Clear();
                            textBox_value.Clear();
                            checkBox_insurance.Checked = false;
                            checkBox_warranty.Checked = false;
                            checkBox_status.Checked = false;
                            textBox_lifetime.Clear();
                            textBox_usage.Clear();
                            richTextBox_description.Clear();
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
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FillGrid();
            textBox_assetID.Clear();
            comboBox_property.SelectedIndex = -1;
            textBox_serialnumber.Clear();
            textBox_ownership.Clear();
            textBox_value.Clear();
            checkBox_insurance.Checked = false;
            checkBox_warranty.Checked = false;
            checkBox_status.Checked = false;
            textBox_lifetime.Clear();
            textBox_usage.Clear();
            richTextBox_description.Clear();
        }
    }
}

using MetroFramework;
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
    public partial class AssetManagement : Form
    {
        public AssetManagement()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            String temp = comboBox_property.SelectedItem.ToString();

            if (temp == "Building")
                textBox_serialnumber.ReadOnly = true;
            else if (temp == "Land")
                textBox_serialnumber.ReadOnly = true;
            else
                textBox_serialnumber.ReadOnly = false;
        }

        private void richTextBox_description_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox_description_Click(object sender, EventArgs e)
        {
            richTextBox_description.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_serialnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_insurance_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_warranty_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox_assetID_TextChanged(object sender, EventArgs e)
        {
            if (textBox_assetID.Text.Length > 3)
            {
                if ((String.IsNullOrWhiteSpace(textBox_assetID.Text)) || (textBox_assetID.Text == " ") || (textBox_assetID.Text[0] != 'A') || (textBox_assetID.Text[1] != 'I') || (textBox_assetID.Text[2] != 'D'))
                    errorProvider1.SetError(textBox_assetID, "Eg: AID000");
                else
                    errorProvider1.Clear();
            }

        }

        //checking whether a string value contains all digits
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

        private void textBox_ownership_TabIndexChanged(object sender, EventArgs e)
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
            if (!IsDigit(textBox_usage.Text))
                errorProvider1.SetError(textBox_usage, "Cannot contain letter");
            else
                errorProvider1.Clear();
        }

        public void FillGrid()
        {
            FinManagement dba = new FinManagement();
            DataSet ds = dba.getAll("asset");
            dataGridView2.DataSource = ds.Tables["asset"].DefaultView;
        }

        private void button_back_Click_1(object sender, EventArgs e)
        {
            this.Close();
            FinanceManagementDashBoard finance = new FinanceManagementDashBoard();
            finance.Show();
        }

        private void button_add_Click_1(object sender, EventArgs e)
        {
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
                    result = MetroMessageBox.Show(this,"You wish to Continue?", "Valid Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        FinManagement add = new FinManagement();
                        add.addAsset(passetID, pproperty, pserial, pownership, pvalue, pinsurance, pwarranty, pstatus, plifeTime, pusage, pdescription);

                        FillGrid();
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
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Asset_US asset = new Asset_US();
            this.Close();
            asset.Show();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            this.Close();
            AssetRepair repair = new AssetRepair();
            repair.Show();
        }

    }
}

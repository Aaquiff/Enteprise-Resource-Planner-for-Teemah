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
    public partial class AssetRepair : Form
    {
        public AssetRepair()
        {
            InitializeComponent();
        }

        private void richTextBox_problem_Click(object sender, EventArgs e)
        {
            richTextBox_problem.Clear();
        }

        private void AssetRepair_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void textBox_repairid_TextChanged(object sender, EventArgs e)
        {
            if (textBox_repairid.Text.Length > 3)
            {
                if ((String.IsNullOrWhiteSpace(textBox_repairid.Text)) || (textBox_repairid.Text == " ") || (textBox_repairid.Text[0] != 'R') || (textBox_repairid.Text[1] != 'I') || (textBox_repairid.Text[2] != 'D'))
                    errorProvider1.SetError(textBox_repairid, "Eg: RID000");
                else
                    errorProvider1.Clear();
            }
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

        public void FillGrid()
        {
            FinManagement dba = new FinManagement();
            DataSet ds = dba.getAll("asset_repair");
            dataGridView2.DataSource = ds.Tables["asset_repair"].DefaultView;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            AssetManagement asset = new AssetManagement();
            asset.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillGrid();
            textBox_repairid.Clear();
            textBox_assetID.Clear();
            textBox_serialnumber.Clear();
            checkBox_insurance.Checked = false;
            checkBox_warranty.Checked = false;
            richTextBox_problem.Clear();
            radioButton_pending.Checked = false;
            radioButton_done.Checked = false;
            radioButton_cannot.Checked = false;
        }

        private void button_add_Click_1(object sender, EventArgs e)
        {
            String message = "";
            String prepairid;
            String passetid;
            String pjobdate;
            String pserial = " ";
            String pstatus = " ";
            String pinsurance = "No";
            String pwarranty = "No";
            String pproblem = " ";
            try
            {
                prepairid = textBox_repairid.Text;
                if ((String.IsNullOrWhiteSpace(prepairid)) || (prepairid == " ") || (prepairid[0] != 'R') || (prepairid[1] != 'I') || (prepairid[2] != 'D'))
                    message += "Valid Repair ID\n";

                passetid = textBox_assetID.Text;
                if ((String.IsNullOrWhiteSpace(passetid)) || (passetid == " ") || (passetid[0] != 'A') || (passetid[1] != 'I') || (passetid[2] != 'D'))
                    message += "Valid Asset ID\n";

                pjobdate = dateTimePicker_repair.Value.ToString("yyyy-MM-dd");

                if (String.IsNullOrWhiteSpace(textBox_serialnumber.Text))
                    message += "Serial Number\n";
                else
                    pserial = textBox_serialnumber.Text;

                if (radioButton_pending.Checked)
                    pstatus = radioButton_pending.Text;
                else if (radioButton_done.Checked)
                    pstatus = radioButton_done.Text;
                else if (radioButton_cannot.Checked)
                    pstatus = radioButton_cannot.Text;
                else
                    message += "Job Status\n";

                if (checkBox_insurance.Checked)
                    pinsurance = "Yes";

                if (checkBox_warranty.Checked)
                    pwarranty = "Yes";

                if (String.IsNullOrWhiteSpace(richTextBox_problem.Text) || richTextBox_problem.Text == "Please enter the problem specified")
                    message += "Problem Specified\n";
                else
                    pproblem = richTextBox_problem.Text;

                if (message == "")
                {
                    DialogResult result;
                    result = MetroMessageBox.Show(this,"You wish to Continue?", "Valid Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        FinManagement add = new FinManagement();
                        if (add.addAssetRepair(prepairid, passetid, pjobdate, pstatus, pproblem, pserial, pwarranty, pinsurance))
                        {
                            textBox_repairid.Clear();
                            textBox_assetID.Clear();
                            textBox_serialnumber.Clear();
                            checkBox_insurance.Checked = false;
                            checkBox_warranty.Checked = false;
                            richTextBox_problem.Clear();
                            radioButton_pending.Checked = false;
                            radioButton_done.Checked = false;
                            radioButton_cannot.Checked = false;
                            FillGrid();
                        }
                    }
                }
                else
                    MetroMessageBox.Show(this,"" + message, "Please Provide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FillGrid();


            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this,ex.Message);
            }
        }

        private void button_search_Click_1(object sender, EventArgs e)
        {
            Asset_Repair_US asset = new Asset_Repair_US();
            asset.ShowDialog();
            //this.Close();
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            if (textBox_assetID.Text == "" || textBox_assetID.Text == " ")
                MetroMessageBox.Show(this, "Please Enter a Asset ID");
            else
            {
                String assetid = textBox_assetID.Text;
                AssetRepairReport rep = new AssetRepairReport(assetid);
                rep.Show();
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            AssetRepairReport rep = new AssetRepairReport();
            rep.Show(); 
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProductProcessManagement
{
    public partial class workOrder : Form
    {

        private int workOrderId;
        public workOrder()
        {
            workOrderId = -1;
            InitializeComponent();
        }



        public workOrder(int TworkOrderId)
        {
            InitializeComponent();
            workOrderId = TworkOrderId;
            loadDetails();
            setvViewMode();
            loadRemarks();
        }

        private void loadDetails()
        {
            //Query DB and put reuslts
            productName.Text = "";
            quantity.Text = "" + "0 units";
            textBox12.Text = "";
            startDate.Text = "";
            reference.Text = "";
            notes.Text = "";
            try
            {

                DBConnect connection = new DBConnect();
                connection.OpenConnection();

                MySqlConnection returnConn = new MySqlConnection();
                returnConn = connection.GetConnection();

                string query = "SELECT w.workOrderId,w.productId,w.quantity,w.status,w.state,w.notes,w.exportPoint,w.startDate,w.endDate,w.reference,p.name FROM WorkOrders w,Products p WHERE w.workOrderId = " + workOrderId + " and w.productId = p.productId";
                MySqlCommand cmd = new MySqlCommand(query, returnConn);
                //cmd.CommandType = CommandType.Text; //default
                //MySqlDataReader read;

                using (MySqlDataReader read = cmd.ExecuteReader())
                {

                    while (read.Read())
                    {
                        int checkReference = read.GetOrdinal("reference");
                        productName.Text = read.GetString("name").ToString();
                        quantity.Text = read.GetInt32("quantity") + " units";
                        startDate.Text = Convert.ToDateTime(read["startDate"]).ToString("dd-MM-yyyy");
                        notes.Text = read.GetString("notes").ToString();
                        textBox12.Text = read.GetString("exportPoint").ToString();
                        label8.Text = read.GetString("exportPoint").ToString();
                        reference.Text = read.IsDBNull(checkReference) ? string.Empty : "#" + read.GetString("reference").ToString();
                        label1.Text = "Work Order: #" + read.GetInt32("workOrderId");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while laoding WorkOrder!");
                //MessageBox.Show(ex.Message);
            }
        }

        private void setvViewMode() { 
            //Enable and disbale elements
            //textBox12.Enabled = false;
            label8.Visible = true;
            textBox12.Visible = false;
            notes.ReadOnly = true;
            buttonCancel.Visible = false;
            button2Edit.Visible = false;
            buttonReset.Visible = false;
            buttonInitEdit.Visible = true;
       }

        private void setEditMode() {
            //textBox12.Enabled = true;
            label8.Visible = false;
            textBox12.Visible = true;
            notes.ReadOnly = false;
            buttonCancel.Visible = true;
            button2Edit.Visible = true;
            buttonReset.Visible = true;
            buttonInitEdit.Visible = false;
        }


        private void loadRemarks() { 
            //QUeyery DB for Remarks
            try
            {
                DBConnect conn = new DBConnect();
                conn.OpenConnection();
                string query = "";

                MySqlConnection returnConn = new MySqlConnection();
                returnConn = conn.GetConnection();


                query = "select remarkId as 'Remark Id',title as 'Title',status as 'Status' from Remarks WHERE reference = " + workOrderId + " AND archived = 0";

                //cmd.ExecuteNonQuery();
                MySqlCommand cmd = new MySqlCommand(query, returnConn);

                DataTable dt = new DataTable();
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                ada.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                conn.CloseConnection();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while laoding Remarks!");
                //MessageBox.Show(ex.Message);
            }
        }


        private void addRemark() { 
            //Add Remakr Window

            Remarks.remark remarkWindow = new Remarks.remark(workOrderId,true);
            remarkWindow.FormClosed += new FormClosedEventHandler(remarksEdited);
            remarkWindow.Show();
        }


        private void editWorkOrder() {
           
                try
                {
                    DBConnect connection = new DBConnect();
                    connection.OpenConnection();
                    MySqlConnection returnConn = new MySqlConnection();
                    returnConn = connection.GetConnection();


                    string query = "UPDATE WorkOrders SET notes='" + notes.Text + "', exportPoint='" + textBox12.Text + "' WHERE workOrderId =" + workOrderId;
                    MySqlCommand cmd = new MySqlCommand(query, returnConn);
                    //cmd.CommandType = CommandType.Text; //default

                    //connection.OpenConnection();
                    cmd.ExecuteNonQuery();
                    connection.CloseConnection();

                    MessageBox.Show("Work order has been edited!");
                    loadRemarks();

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong while deleting the Remark!");
                    //MessageBox.Show(ex.Message);
                }
            
        
        }


        private void deleteRemark() { 
            //Delete Remakr SQL
            if (getSelectedRemark() > -1)
            {

                DialogResult dr = MessageBox.Show("All data related to the remark will be deleted! Do you wish to continue?", "Do you wish to continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes) {
                    try
                    {
                        DBConnect connection = new DBConnect();
                        connection.OpenConnection();
                        MySqlConnection returnConn = new MySqlConnection();
                        returnConn = connection.GetConnection();


                        string query = "DELETE FROM Remarks WHERE remarkId=" + getSelectedRemark();
                        MySqlCommand cmd = new MySqlCommand(query, returnConn);
                        //cmd.CommandType = CommandType.Text; //default

                        //connection.OpenConnection();
                        cmd.ExecuteNonQuery();
                        connection.CloseConnection();

                        MessageBox.Show("Remark has been deleted!");
                        loadRemarks();

                    }

                    catch (Exception ex)
                    {
                        //MessageBox.Show("Something went wrong while deleting the Remark!");
                        MessageBox.Show(ex.Message);
                    }
                }

            }
            else
            {
                MessageBox.Show("Please select a remark!");
            }

        }

        private void editRemark() { 
            //Edit Remark Window
            if (getSelectedRemark() > -1)
            {
                Remarks.remark remarkWindow = new Remarks.remark(getSelectedRemark());
                remarkWindow.FormClosed += new FormClosedEventHandler(remarksEdited);
                remarkWindow.Show();
            }
            else {
                MessageBox.Show("Please select a remark!");
            }

        }

        void remarksEdited(object sender, FormClosedEventArgs e)
        {
            loadRemarks();
        }

        private int getSelectedRemark()
        {
            try
            {
                int selected = dataGridView1.CurrentCell.RowIndex;
                var remarkId = -1;
                if (Int32.TryParse(dataGridView1.Rows[selected].Cells[0].Value.ToString(), out remarkId))
                {
                    return remarkId;
                }
                else
                {
                    MessageBox.Show("Soemthing went wrong!");
                    return -1;
                }
            }
            catch (Exception ex) {

                //MessageBox.Show("Please select a remark!");
                return -1;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addRemark();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            deleteRemark();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            editRemark();
        }

        private void buttonInitEdit_Click(object sender, EventArgs e)
        {
            setEditMode();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            loadDetails();
        }

        private void button2Edit_Click(object sender, EventArgs e)
        {
            editWorkOrder();
            setvViewMode();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            setvViewMode();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

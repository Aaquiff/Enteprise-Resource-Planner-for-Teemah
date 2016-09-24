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


namespace ProductProcessManagement.Remarks
{
    public partial class remark : Form
    {

        private int remarkId;
        private bool add;
        private bool archived;
        private int priority;
        private int workOrderId;
        public remark()
        {
            remarkId = -1;
            workOrderId = -1;
            add = true;
            archived = false;
            priority = 5;
            InitializeComponent();
            initAdd();
        }

        public remark(int TworkOrderId,bool dummy)
        {
            //Starting from Work Order Id
            workOrderId = TworkOrderId;
            remarkId = -1;
            add = true;
            priority = 5;
            InitializeComponent();
            initAdd();
        
        }
        public remark(int TremarkId)
        {
            remarkId = TremarkId;
            add = false;
            archived = false;
            priority = 5;
            InitializeComponent();
            initView(remarkId);
            loadRemark();

        }

        private void loadRemark()
        {
            //Init Reamrk
            if (remarkId > -1) {
                try
                {

                    DBConnect connection = new DBConnect();
                    connection.OpenConnection();

                    MySqlConnection returnConn = new MySqlConnection();
                    returnConn = connection.GetConnection();

                    string query = "SELECT * FROM Remarks WHERE remarkId = " + remarkId;
                    MySqlCommand cmd = new MySqlCommand(query, returnConn);
                    //cmd.CommandType = CommandType.Text; //default
                    //MySqlDataReader read;

                    using (MySqlDataReader read = cmd.ExecuteReader())
                    {

                        while (read.Read())
                        {
                            int checkReference = read.GetOrdinal("reference");
                            int checkNotes = read.GetOrdinal("notes");
                            textBoxTitle.Text = read.GetString("title").ToString();
                            numericUpDownPriority.Value = read.GetInt32("priority");
                            labelPriority.Text = ""  + read.GetInt32("priority");
                            priority = read.GetInt32("priority");
                            label9.Text = Convert.ToDateTime(read["created"]).ToString("dd-MM-yyyy");
                            comboBoxStatus.Text = read.GetString("status").ToString();
                            labelStatus.Text = read.GetString("status").ToString();
                            archived = read.GetBoolean("archived");
                            label7.Text = archived ? "| Archived" : "| Not Archived";
                            richTextBoxNotes.Text = read.IsDBNull(checkNotes) ? string.Empty : read.GetString("notes").ToString();
                            referenceLabel.Text = read.IsDBNull(checkReference) ? "N/A" : "#" + read.GetString("reference").ToString();
                        }

                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Something went wrong while laoding Remark!");
                    MessageBox.Show(ex.Message);
                }
                refreshQuickActions();
            }

        }

        private void loadStatuses() { 
        //Hardcoded in the design
        
        }

        private void clear() {
            textBoxTitle.Text = ""; //Title
            numericUpDownPriority.Value = 5; //Priority
            label9.Text = DateTime.Now.ToString("dd-MM-yyyy");
            comboBoxStatus.Text = "Not Reviewed";
            richTextBoxNotes.Text = ""; //Notes
        }

        private void reset() {
            if (add)
            {
                clear();
            }
            else {
                loadRemark();
            }
        
        }

        private void refreshView() {
            //Don't know why i wrote this method!
        
        }

        private void initView(int TremarkId)
        {
            add = false;
            remarkId = TremarkId;
            createButton.Visible = false; // Craete
            clearButton.Visible = false; //Clear
            resetButton.Visible = false; // Rest
            initEditButton.Visible = true; // Init Edit
            confirmEdit.Visible = false; // Confirm Edit
            panel5.Visible = true; //hiding Dock
            richTextBoxNotes.ReadOnly = true;

            textBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            //textBoxTitle.Enabled = true;
            textBoxTitle.ReadOnly = true;
            labelPriority.Visible = true;
            numericUpDownPriority.Visible = false;
            labelStatus.Visible = true;
            comboBoxStatus.Visible = false;
            button1.Visible = false;
            loadRemark();
        }

        private void initEdit()
        {
            add = false;
            createButton.Visible = false; // Craete
            clearButton.Visible = false; //Clear
            resetButton.Visible = true; // Craete
            initEditButton.Visible = false; // Craete
            confirmEdit.Visible = true; // Craete
            panel5.Visible = true; //hiding Dock
            richTextBoxNotes.ReadOnly = false;

            textBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBoxTitle.ReadOnly = false;
            labelPriority.Visible = false;
            numericUpDownPriority.Visible = true;
            labelStatus.Visible = false;
            comboBoxStatus.Visible = true;
            button1.Visible = true;
        }

        private void initAdd() {
            remarkId = -1;
            add = true;
            if (workOrderId > -1)
            {
                referenceLabel.Text = "Work Order: #" + workOrderId;
            }
            else {
                referenceLabel.Text = "None";
            }
            label7.Visible = false;
            createButton.Visible = true; // Craete
            clearButton.Visible = true; //Clear
            resetButton.Visible = false; // Craete
            initEditButton.Visible = false; // Craete
            confirmEdit.Visible = false; // Craete
            panel5.Visible = false; //hiding Dock

            textBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBoxTitle.ReadOnly = false;
            labelPriority.Visible = false;
            numericUpDownPriority.Visible = true;
            labelStatus.Visible = false;
            comboBoxStatus.Visible = true;
            button1.Visible = false;
            clear();
            richTextBoxNotes.ReadOnly = false;
        }

        private void initAdd(int workOrderId)
        {
            initAdd();
            referenceLabel.Text = "Work Order: #" + workOrderId;

        }


        private void refreshQuickActions() {
            //loadRemark();
            if (archived)
            {
                buttonUnArchive.Visible = true;
                buttonArchive.Visible = false;
            }
            else {
                buttonUnArchive.Visible = false;
                buttonArchive.Visible = true;
            }

            if (priority >= 8) {
                buttonLowPrioritize.Visible = true;
                buttonHighPrioritize.Visible = false;
            }
            else if (priority <= 3)
            {
                buttonLowPrioritize.Visible = false;
                buttonHighPrioritize.Visible = true;
            }
            else {
                buttonLowPrioritize.Visible = true;
                buttonHighPrioritize.Visible = true;
            }

            //Can be labelStatus.Text as well
            if (labelStatus.Text == "Reviewed")
            {
                notCompleteButton.Visible = true;
                buttonComplete.Visible = false;
            }
            else {
                notCompleteButton.Visible = false;
                buttonComplete.Visible = true;
            }


        }


        private void highPrioritize() {
            try
            {
                DBConnect connection = new DBConnect();
                connection.OpenConnection();

                MySqlConnection returnConn = new MySqlConnection();
                returnConn = connection.GetConnection();

                string query = "UPDATE Remarks SET priority= 8 WHERE remarkId =" + remarkId;

                MySqlCommand cmd = new MySqlCommand(query, returnConn);
                cmd.Connection = returnConn;
                cmd.ExecuteNonQuery();
                connection.CloseConnection();
                MessageBox.Show("Remark is marked as High Priority Remark");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Something went wrong while executing the action!");
                MessageBox.Show(ex.Message);
                //throw;
            }
            loadRemark();
        
        }

        private void lowPrioritize() {
            try
            {
                DBConnect connection = new DBConnect();
                connection.OpenConnection();

                MySqlConnection returnConn = new MySqlConnection();
                returnConn = connection.GetConnection();

                string query = "UPDATE Remarks SET priority= 3 WHERE remarkId =" + remarkId;

                MySqlCommand cmd = new MySqlCommand(query, returnConn);
                cmd.Connection = returnConn;
                cmd.ExecuteNonQuery();
                connection.CloseConnection();
                MessageBox.Show("Remark is marked as Low Priority Remark");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Something went wrong while executing the action!");
                MessageBox.Show(ex.Message);
                //throw;
            }
            loadRemark();
        }

        private void markCompleted() {
            try
            {
                DBConnect connection = new DBConnect();
                connection.OpenConnection();

                MySqlConnection returnConn = new MySqlConnection();
                returnConn = connection.GetConnection();

                string query = "UPDATE Remarks SET status = 'Reviewed' WHERE remarkId =" + remarkId;

                MySqlCommand cmd = new MySqlCommand(query, returnConn);
                cmd.Connection = returnConn;
                cmd.ExecuteNonQuery();
                connection.CloseConnection();
                MessageBox.Show("Remark is marked Reviewed");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Something went wrong while executing the action!");
                MessageBox.Show(ex.Message);
                //throw;
            }
            loadRemark();
        }


        private void markNotCompleted() {
            try
            {
                DBConnect connection = new DBConnect();
                connection.OpenConnection();

                MySqlConnection returnConn = new MySqlConnection();
                returnConn = connection.GetConnection();

                string query = "UPDATE Remarks SET status = 'Not Reviewed' WHERE remarkId =" + remarkId;

                MySqlCommand cmd = new MySqlCommand(query, returnConn);
                cmd.Connection = returnConn;
                cmd.ExecuteNonQuery();
                connection.CloseConnection();
                MessageBox.Show("Remark is marked not Reviewed");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Something went wrong while executing the action!");
                MessageBox.Show(ex.Message);
                //throw;
            }
            loadRemark();
        
        }

        private void archive() {
            try
            {
                DBConnect connection = new DBConnect();
                connection.OpenConnection();

                MySqlConnection returnConn = new MySqlConnection();
                returnConn = connection.GetConnection();

                string query = "UPDATE Remarks SET archived= 1 WHERE remarkId ='" + remarkId + "'";

                MySqlCommand cmd = new MySqlCommand(query, returnConn);
                cmd.Connection = returnConn;
                cmd.ExecuteNonQuery();
                connection.CloseConnection();
                MessageBox.Show("Remark is Archived");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Something went wrong while executing the action!");
                MessageBox.Show(ex.Message);
                //throw;
            }
            loadRemark();
        
        }

        private void unArchive() {
            try
            {
                DBConnect connection = new DBConnect();
                connection.OpenConnection();

                MySqlConnection returnConn = new MySqlConnection();
                returnConn = connection.GetConnection();

                string query = "UPDATE Remarks SET archived= 0 WHERE remarkId ='" + remarkId + "'";

                MySqlCommand cmd = new MySqlCommand(query, returnConn);
                cmd.Connection = returnConn;
                cmd.ExecuteNonQuery();
                connection.CloseConnection();
                MessageBox.Show("Remark is UnArchived");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Something went wrong while executing the action!");
                MessageBox.Show(ex.Message);
                //throw;
            }
            loadRemark();
        
        }

        private void createRemark() {
            try
            {
                DBConnect connection = new DBConnect();
                connection.OpenConnection();
                MySqlConnection returnConn = new MySqlConnection();
                returnConn = connection.GetConnection();

                string query = "insert into Remarks(title,status,priority,created,lastAction,notes,reference,archived) values(@1,@2,@3,@4,@5,@6,@7,@8)";
                MySqlCommand cmd = new MySqlCommand(query, returnConn);
                //cmd.CommandType = CommandType.Text; //default


                //textBoxTitle.Text = ""; //Title
                //numericUpDownPriority.Value = 5; //Priority
                //label9.Text = DateTime.Now.ToString("dd-MM-yyyy");
                //comboBoxStatus.SelectedText = String.Empty;
                //richTextBoxNotes.Text = ""; //Notes

                cmd.Parameters.AddWithValue("@1", textBoxTitle.Text);
                cmd.Parameters.AddWithValue("@2", "Not Reviewed");
                cmd.Parameters.AddWithValue("@3", numericUpDownPriority.Value);
                cmd.Parameters.AddWithValue("@4", DateTime.Now.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@5", DateTime.Now.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@6", richTextBoxNotes.Text);
                if (workOrderId > -1)
                {
                    cmd.Parameters.AddWithValue("@7", workOrderId);
                    
                }
                else {
                    cmd.Parameters.AddWithValue("@7", "null");
                }
                cmd.Parameters.AddWithValue("@8", "0");

                cmd.ExecuteNonQuery();
                connection.CloseConnection();
                
                MessageBox.Show("Remark has been created");
                this.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Something went wrong while executing the action!");
                MessageBox.Show(ex.Message);
                //throw;
            }

        
        }

        private void editRemark() {
                
            try
            {
                DBConnect connection = new DBConnect();
                connection.OpenConnection();

                MySqlConnection returnConn = new MySqlConnection();
                returnConn = connection.GetConnection();

                string query = "UPDATE Remarks SET title = '" + textBoxTitle.Text + "', notes = '" + richTextBoxNotes.Text + "', priority = " + numericUpDownPriority.Value + ", status = '" + comboBoxStatus.Text + "'  WHERE remarkId =" + remarkId;

                MySqlCommand cmd = new MySqlCommand(query, returnConn);
                cmd.Connection = returnConn;
                cmd.ExecuteNonQuery();

                connection.CloseConnection();
                MessageBox.Show("Remark has been edited");
                loadRemark();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Something went wrong while executing the action!");
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void buttonHighPrioritize_Click(object sender, EventArgs e)
        {
            highPrioritize();
        }

        private void buttonLowPrioritize_Click(object sender, EventArgs e)
        {
            lowPrioritize();
        }

        private void notCompleteButton_Click(object sender, EventArgs e)
        {
            markNotCompleted();
        }

        private void buttonUnArchive_Click(object sender, EventArgs e)
        {
            unArchive();
        }

        private void buttonComplete_Click(object sender, EventArgs e)
        {
            markCompleted();
        }

        private void buttonArchive_Click(object sender, EventArgs e)
        {
            archive();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            createRemark();
            
        }

        private void confirmEdit_Click(object sender, EventArgs e)
        {
            editRemark();
            initView(remarkId);
        }

        private void initEditButton_Click(object sender, EventArgs e)
        {
            initEdit();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cancel Button
            initView(remarkId);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


    }

    
}

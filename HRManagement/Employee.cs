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
using System.Text.RegularExpressions;
using MySQLDatabaseAccess;

namespace HRManagement
{
    public partial class Employee : Form
    {
        #region properties
        String gender,q5;
        String dep, first2,emp;
        String ini;
        
        String pw = "1234";
        Double basSal,otTot,etf,epf;
        int ss;
        DataTable dataset;
        #endregion

        public Employee()
        {
            InitializeComponent();
                Emp_txt.Text = Connection.getUserIdFromConnectionString();
                getDetails();

            
        }

        #region methods

        public bool isEmpty()
        {
            if (First_txt.Text == " ")
            {
                MessageBox.Show("FirstName can't be null");
                return false;
            }
            else if (Last_txt.Text == " ")
            {
                MessageBox.Show("LastName can't be null");
                return false;
            }
            else if (Nat_txt.Text == " ")
            {
                MessageBox.Show("Nationality can't be null");
                return false;
            }
            else if (NIC_txt.Text == " ")
            {
                MessageBox.Show("NIC can't be null");
                return false;
            }
            else if (Add_txt.Text == " ")
            {
                MessageBox.Show("Address can't be null");
                return false;
            }
            else if (Mob_txt.Text == " ")
            {
                MessageBox.Show("MobileNo can't be null");
                return false;
            }
            else if (Email_txt.Text == " ")
            {
                MessageBox.Show("Email can't be null");
                return false;
            }
            else if (Posi_combo.Text == " ")
            {
                MessageBox.Show("Position can't be null");
                return false;
            }
            else
                return true;
        }

        public bool checkMail()
        {
            string pattern = null;
            pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            if (!Regex.IsMatch(Email_txt.Text, pattern))
            {
                MessageBox.Show("Not a valid Email address ");
                return false;
            }
            return true;
        }

        public bool checkNIC()
        {
            string pattern = null;
            pattern = "/^[0-9]{9}[vVxX]$/";

            if (!Regex.IsMatch(NIC_txt.Text, pattern))
            {
                MessageBox.Show("Not a valid NIC Number ");
                return false;
            }
            return true;
        }

        public bool checkMobile()
        {
            if (Mob_txt.MaxLength != 15)
            {
                MessageBox.Show("Mobile Number should have 10 digits");
                return false;
            }
            return true;
        }

        public int getNewId()
        {
            String s = "select max(EmpId) from itp.employee;";
            MySqlConnection MyConn = ConnectionOld.getConnection();
            MySqlCommand SelectCommand = new MySqlCommand(s, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = SelectCommand.ExecuteReader();
            
            while (MyReader.Read())
            {

                ss = MyReader.GetInt32("max(EmpId)");
            }
           
            int n = ss + 1;
            return n;
        }

        public void Insert()
        {
            isEmpty();
            checkMail();
            //checkNIC();
            //checkMobile();
            String us = assignUserName();
            int val = getNewId();
            Double sal = Double.Parse(this.textBox5.Text);
            String query = "insert into itp.employee(EmpId,FirstName,LastName,Nationality,Email,MobileNo,NIC,Position,DepId,Gender,DOB,Address,UserName,Password,BasicSalary) values('" + this.Emp_txt.Text + "','" + this.First_txt.Text + "','" + this.Last_txt.Text + "','" + this.Nat_txt.Text + "','" + this.Email_txt.Text + "','" + this.Mob_txt.Text + "','" + this.NIC_txt.Text + "','" + this.Posi_combo.Text + "','" + dep + "','" + gender + "','" + this.dateTimePicker1.Text + "','" + this.Add_txt.Text + "','" + us + "','" + pw + "','" + sal + "'); ";
            MySqlConnection connDatabase = ConnectionOld.getConnection();
            MySqlCommand cmdDatabase = new MySqlCommand(query, connDatabase);
            MySqlCommand createUser = new MySqlCommand("CREATE_USER",connDatabase);
            createUser.CommandType = CommandType.StoredProcedure;
            createUser.Parameters.AddWithValue("user_id_", this.Emp_txt.Text);
            createUser.Parameters.AddWithValue("password_",pw);
            
            try
            {
                connDatabase.Open();
                cmdDatabase.ExecuteNonQuery();
                createUser.ExecuteNonQuery();
                MessageBox.Show("Records are saved successfully\n" + this.First_txt.Text +  this.Last_txt.Text +  " 's Username is " + us);
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public String assignUserName() 
        {
            String fn = this.First_txt.Text;
            String user = ini + this.Emp_txt.Text +fn;
            return user;

        }

         public void getDetails()
        {
             MySqlConnection MyConn = ConnectionOld.getConnection();
                MySqlCommand SelectCommand = new MySqlCommand("select * from itp.employee where EmpId = '" + Connection.getUserIdFromConnectionString() + "' ;", MyConn);
                MySqlDataReader MyReader;
                MyConn.Open();
                MyReader = SelectCommand.ExecuteReader();

                while (MyReader.Read())
                {
                    Emp_txt.Text = MyReader.GetInt32("EmpId").ToString();
                    First_txt.Text = MyReader.GetString("FirstName");
                    Last_txt.Text = MyReader.GetString("LastName");
                    dateTimePicker1.Text = MyReader.GetString("DOB");
                    Nat_txt.Text = MyReader.GetString("Nationality");
                    NIC_txt.Text = MyReader.GetString("NIC");
                    Add_txt.Text = MyReader.GetString("Address");
                    Email_txt.Text = MyReader.GetString("Email");
                    Mob_txt.Text = MyReader.GetInt32("MobileNo").ToString();
                    Posi_combo.Text = MyReader.GetString("Position");
                    Dep_txt.Text = MyReader.GetString("DepId");
                    textBox5.Text = MyReader.GetDouble("BasicSalary").ToString();
                    String gender = MyReader.GetChar("Gender").ToString();

                    if (gender == "M")
                    {
                        radioButton1.Checked = true;
                    }
                    else
                    {
                        radioButton2.Checked = true;
                    }

                }
        }

        public void setDetails()
        {
            
            String q2 = "update itp.employee set FirstName ='" + this.First_txt.Text + "', LastName ='" + this.Last_txt.Text + "',Gender ='" + gender + "', Address ='" + this.Add_txt.Text + "', MobileNo ='" + this.Mob_txt.Text + "', Email ='" + this.Email_txt.Text + "' where EmpId = '"+Connection.getUserIdFromConnectionString()+"' ";
            MySqlConnection connDatabase = ConnectionOld.getConnection();
            MySqlCommand cmdDatabase = new MySqlCommand(q2, connDatabase);
            MySqlDataReader myReader;

            try
            {
                connDatabase.Open();
                myReader = cmdDatabase.ExecuteReader();
                MessageBox.Show("Records are edited successfully");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void refreshHRLeaveTable()
        {
            if (tabCheckLeaveRequests.Text == "Check Leave Requests")
            {

                MySqlConnection connDatabase = ConnectionOld.getConnection();
                MySqlCommand q4 = new MySqlCommand("select EmpId,RequestedDate,StartDate,EndDate,NoOfDays,Type,Reason,Status from leave_view where Status = @status;", connDatabase);
                q4.Parameters.AddWithValue("@status", "Pending");

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = q4;
                    DataTable dataset = new DataTable();
                    sda.Fill(dataset);
                    BindingSource bSource = new BindingSource();

                    bSource.DataSource = dataset;
                    dataGridView3.DataSource = bSource;
                    //sda.Update(dataset);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

         public void refreshEmpLeaveTable()
        {
            if (tabSendLeaveRequests.Text == "Send Leave Requests")
            {

                MySqlConnection connDatabase = ConnectionOld.getConnection();
                MySqlCommand q4 = new MySqlCommand("select RequestedDate,StartDate,EndDate,NoOfDays,Type,Reason,Status from leave_view where EmpId = @empid ;", connDatabase);
                q4.Parameters.AddWithValue("@empId", Connection.getUserIdFromConnectionString());
                try
                {
                    
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = q4;
                    DataTable dataset = new DataTable();
                    sda.Fill(dataset);
                    BindingSource bSource = new BindingSource();

                    bSource.DataSource = dataset;
                    dataGridView1.DataSource = bSource;
                    //sda.Update(dataset);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

         public void displayDataGridViewSearch()
         {
             q5 = "select EmpId,FirstName,LastName,Position,DepId,Address,MobileNo,Email from itp.employee ;";
             MySqlConnection connDatabase = ConnectionOld.getConnection();
             MySqlCommand q4 = new MySqlCommand(q5, connDatabase);

             try
             {
                 MySqlDataAdapter sda = new MySqlDataAdapter();
                 sda.SelectCommand = q4;
                 dataset = new DataTable();
                 sda.Fill(dataset);
                 BindingSource bSource = new BindingSource();

                 bSource.DataSource = dataset;
                 dataGridView2.DataSource = bSource;
                 //sda.Update(dataset);
             }

             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
         }

        
         /*public String createSalId()
         {
             String s = "select max(SalId) from itp.salary;";
             MySqlConnection MyConn = Connection.getConnection();
             MySqlCommand SelectCommand = new MySqlCommand(s, MyConn);
             MySqlDataReader MyReader;
             MyConn.Open();
             MyReader = SelectCommand.ExecuteReader();
             String ss;
             while (MyReader.Read())
             {

                 String ss = MyReader.GetString("max(SalId)");
             }
                String sss = ss.Substring(0, 2);
                int id = Int32.Parse(ss.Substring(2, 3));
                int sal = id + 1;
                String salnew = sss + sal;
                
            
             return salnew;

         }*/

        #endregion

        #region events

        private void Add_Click(object sender, EventArgs e)
        {
            First_txt.Text = " ";
            Last_txt.Text = " ";
            radioButton2.Checked = false;
            this.dateTimePicker1.Value = DateTime.Now;
            Add_txt.Text = " ";
            Mob_txt.Text = "+(94)";
            Email_txt.Text = " ";
            Nat_txt.Text = " ";
            NIC_txt.Text = " ";
            Posi_combo.Text = " ";
            Dep_txt.Text = " ";
            textBox5.Text = " ";
            radioButton1.Checked = true;

            int val = getNewId();
            Emp_txt.Text = val.ToString();
            Save.Show();
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "M";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "F";
        }

        private void Posi_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            String position = this.Posi_combo.Text;
            if (position == "Employee")
            {
                dep = "Service";
                ini = "SR";
            }
            else if (position == "Driver")
            {
                dep = "Distribution";
                ini = "DT";
            }
            else if (position == "Sales Manager")
            {
                dep = "Sales";
                ini = "SL";
            }
            else if (position == "Finance Manager")
            {
                dep = "Finance";
                ini = "FM";
            }
            else if (position == "HR Manager")
            {
                dep = "Human Resource";
                ini = "HR";
            }

            Dep_txt.Text = dep;
        }

       private void Edit_Click(object sender, EventArgs e)
        {
             setDetails();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            

            First_txt.Text = " ";
            Last_txt.Text = " ";
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            Add_txt.Text = " ";
            Mob_txt.Text = " ";
            Email_txt.Text = " ";
            
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabCheckLeaveRequests);
            tabControl1.TabPages.Remove(tabViewSalary);

            MySqlConnection con = ConnectionOld.getConnection();
            MySqlCommand sc = new MySqlCommand("select role from user_role_tab where user = @user", con);
                sc.Parameters.AddWithValue("@user", Connection.getUserIdFromConnectionString());
                try
                {
                    con.Open();
                    MySqlDataReader read = sc.ExecuteReader();
                    while (read.Read())
                    {
                        string role = read.GetString("role");
                        switch (role)
                        {
                        case "HR Manager": AddNewEmp.Show();
                                            Save.Show();
                                            tabControl1.TabPages.Remove(tabSendLeaveRequests);
                                            this.tabViewSalary.Text = "Calculate Salary";
                                             tabControl1.TabPages.Add(tabCheckLeaveRequests);
                                             tabControl1.TabPages.Add(tabViewSalary);
                                             Rem.Show();
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }

            /* first2 = Login.un.Substring(0, 2);
            if (tabControl1.SelectedIndex == 0 && first2 != "HR")
            {
                AddNewEmp.Hide();
                Rem.Hide();
                Emp_txt.ReadOnly = true;
                First_txt.ReadOnly = true;
                Last_txt.ReadOnly = true;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                dateTimePicker1.Enabled = false;
                Nat_txt.ReadOnly = true;
                NIC_txt.ReadOnly = true;
                Add_txt.ReadOnly = false;
                Mob_txt.ReadOnly = false;
                Email_txt.ReadOnly = false;
                Posi_combo.Enabled = false;
            }

            if (tabControl1.SelectedIndex == 1 && first2 != "HR")
            {
                Calculate.Hide();
                button2.Hide();
            }

            if (first2 != "HR")
            {
                tabControl1.TabPages.Remove(tabPage5);
                tabControl1.TabPages.Remove(tabPage2);
            }
            else
            {
                tabControl1.TabPages.Remove(tabPage3);
                this.tabPage2.Text = "Calculate Salary";
            }

            if (tabPage4.Text == "Search Employees" && first2 == "HR")
            {
                Rem.Show();
            }*/

           

          
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Insert();
            
        }

        private void Search_Click(object sender, EventArgs e)
        {
            displayDataGridViewSearch();
          
        }

        private void Rem_Click_1(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dataGridView2.SelectedRows[0];

                emp = row.Cells["EmpId"].Value.ToString();
            }


            String q2 = "delete from itp.employee where EmpId ='" + emp + "' ";
            MySqlConnection connDatabase = ConnectionOld.getConnection();
            MySqlCommand cmdDatabase = new MySqlCommand(q2, connDatabase);
            MySqlDataReader myReader;

            try
            {
                connDatabase.Open();
                myReader = cmdDatabase.ExecuteReader();
                MessageBox.Show("Record is deleted successfully");
                displayDataGridViewSearch();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            refreshEmpLeaveTable();
            refreshHRLeaveTable();


            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime start = Convert.ToDateTime(dateTimePicker3.Text);
            DateTime end = Convert.ToDateTime(dateTimePicker2.Text);
            
            String query = "insert into `leave`(Type,Reason,StartDate,EndDate,RequestedDate,Status,EmpId) values('" + this.Type_combo.Text + "','" + this.Reason.Text + "', @date1 , @date2 , CURDATE(),'Pending', '"+ Connection.getUserIdFromConnectionString()+"')";
            MySqlConnection connDatabase = ConnectionOld.getConnection();
            MySqlCommand cmdDatabase = new MySqlCommand(query, connDatabase);
            MySqlParameter param = new MySqlParameter("@date1", MySqlDbType.Date);
            param.Value = dateTimePicker3.Value;
            MySqlParameter param2 = new MySqlParameter("@date2", MySqlDbType.Date);
            param2.Value = dateTimePicker2.Value;
            cmdDatabase.Parameters.Add(param);
            cmdDatabase.Parameters.Add(param2);

            try
            {
                connDatabase.Open();
                cmdDatabase.ExecuteNonQuery();
                MessageBox.Show("Records are saved successfully\n");
                refreshEmpLeaveTable();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

         private void button6_Click(object sender, EventArgs e)
        {
            String q2 = "update itp.leave set Status ='Accepted' where EmpId = '" + emp + "' ";
            MySqlConnection connDatabase = ConnectionOld.getConnection();
            MySqlCommand cmdDatabase = new MySqlCommand(q2, connDatabase);
            MySqlDataReader myReader;

            try
            {
                connDatabase.Open();
                myReader = cmdDatabase.ExecuteReader();
                MessageBox.Show("You have accepted the request");
                refreshHRLeaveTable();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String q2 = "update itp.leave set Status ='Denied' where EmpId = '" + emp + "' ";
            MySqlConnection connDatabase = ConnectionOld.getConnection();
            MySqlCommand cmdDatabase = new MySqlCommand(q2, connDatabase);
            MySqlDataReader myReader;

            try
            {
                connDatabase.Open();
                myReader = cmdDatabase.ExecuteReader();
                MessageBox.Show("You have rejected the request");
                refreshHRLeaveTable();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dataGridView3.SelectedRows[0];

                emp = row.Cells["EmpId"].Value.ToString();

                MySqlConnection MyConn = ConnectionOld.getConnection();
                MySqlCommand SelectCommand = new MySqlCommand("select FirstName,DepId from itp.employee where EmpId = '" + emp + "' ;", MyConn);
                MySqlDataReader MyReader;
                MyConn.Open();
                MyReader = SelectCommand.ExecuteReader();

                while (MyReader.Read())
                {
                    textBox11.Text = MyReader.GetString("FirstName");
                    textBox12.Text = MyReader.GetString("DepId");

                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection MyConn = ConnectionOld.getConnection();
            MySqlCommand SelectCommand = new MySqlCommand("select * from itp.employee where EmpId = '" + textBox1.Text + "' ;", MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = SelectCommand.ExecuteReader();

            while (MyReader.Read())
            {
                name.Text = MyReader.GetString("FirstName");
                textBox2.Text = MyReader.GetString("DepId");
                textBox3.Text = MyReader.GetString("Position");
                textBox7.Text = MyReader.GetString("BasicSalary");
            }




        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            Double net = (basSal + otTot) - (etf + epf);
            // MessageBox.Show("salary is " + net);
            textBox10.Text = net.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            basSal = Double.Parse(textBox7.Text);
            otTot = (basSal / 240) * Double.Parse(textBox4.Text) * 1.5;
            textBox6.Text = otTot.ToString();
            // MessageBox.Show("salary is " + otTot);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                etf = Double.Parse(textBox7.Text) * 0.03;
                epf = Double.Parse(textBox7.Text) * 0.08;
                textBox8.Text = etf.ToString();
                textBox9.Text = epf.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //String SalId = createSalId();
            //MessageBox.Show("salId " + SalId);
            String query = "insert into itp.salary(EmpId,OTHours,NetSalary,GivenDate) values('" + textBox1.Text + "','" + textBox4.Text + "','" + textBox10.Text + "',CURDATE()); ";
            MySqlConnection connDatabase = ConnectionOld.getConnection();
            MySqlCommand cmdDatabase = new MySqlCommand(query, connDatabase);
            MySqlDataReader myReader;

            try
            {
                connDatabase.Open();
                myReader = cmdDatabase.ExecuteReader();
                MessageBox.Show("Records are saved successfully");

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dataset);
            DV.RowFilter = string.Format("FirstName like '%{0}%'", textBox13.Text);
            dataGridView2.DataSource = DV;
        }

        private void selection_txt_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dataset);
            DV.RowFilter = string.Format("DepId like '%{0}%'", selection_txt.Text);
            dataGridView2.DataSource = DV;
        }

        #endregion

       

       

        

     
        

       
       
        

       

        

       

       

        

        

         }
}

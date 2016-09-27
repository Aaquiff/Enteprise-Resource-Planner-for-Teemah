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
using MetroFramework;
using FrameworkControls.Classes;


namespace HRManagement
{
    public partial class Employee : Form
    {
        #region properties
        String gender,q5;
        String dep, first2,emp;
        String ini;
        MySqlConnection con = ConnectionOld.getConnection();
        String pw = "1234";
        String mon,salMonth;
        String nat;
        Double basSal,otTot,etf,epf;
        int ss;
        MySqlDataAdapter sda = new MySqlDataAdapter();
        DataTable datasetOT = new DataTable();
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
                //MessageBox.Show("FirstName can't be null");
                PanException.Show(this.MdiParent, "Validation Error", "FirstName can't be null");
                return false;
            }
            else if (Last_txt.Text == " ")
            {
               // MessageBox.Show("LastName can't be null");
                PanException.Show(this.MdiParent, "Validation Error", "LastName can't be null");
                return false;
            }
            else if (nat == null)
            {
                //MessageBox.Show("Nationality can't be null");
                PanException.Show(this.MdiParent, "Validation Error", "Nationality can't be null");
                return false;
            }
            else if (NIC_txt.Text == " ")
            {
                //MessageBox.Show("NIC can't be null");
                PanException.Show(this.MdiParent, "Validation Error", "NIC can't be null");
                return false;
            }
            else if (Add_txt.Text == " ")
            {
                //MessageBox.Show("Address can't be null");
                PanException.Show(this.MdiParent, "Validation Error", "Address can't be null");
                return false;
            }
            else if (Mob_txt.Text == "(__) __-_______")
            {
                //MessageBox.Show("MobileNo can't be null");
                PanException.Show(this.MdiParent, "Validation Error", "MobileNo can't be null");
                return false;
            }
            else if (Email_txt.Text == " ")
            {
                //MessageBox.Show("Email can't be null");
                PanException.Show(this.MdiParent, "Validation Error", "Email can't be null");
                return false;
            }
            else if (Posi_combo.Text == " ")
            {
                //MessageBox.Show("Position can't be null");
                PanException.Show(this.MdiParent, "Validation Error", "Position can't be null");
                return false;
            }
            else
                return true;
        }

        /*public bool checkMail()
        {
            string pattern = null;
            pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            if (!Regex.IsMatch(Email_txt.Text, pattern))
            {
                
                return false;
            }
            return true;
        }*/
        //bool checkMail(string email)
        //{
        //    try
        //    {
        //        var addr = new System.Net.Mail.MailAddress(email);
        //        return addr.Address == email;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}
        
        public static bool checkMail(String s)
        {
            try
            {
                int num = s.IndexOf('@');
                int num2 = s.IndexOf('.');

                if (!string.IsNullOrEmpty(s) && (s[0] != ' ' || s[0] != '\t' || s[0] != '.'))
                {
                    if (s.EndsWith(".com") || s.EndsWith(".lk"))
                    {
                        if (num < num2 && (num + 1) != num2)
                        {
                            return true;
                        }
                        else
                        {
                            PanException.Show(null, "invalid email id", "error");
                            return false;
                        }
                }
                    else
                    {
                        PanException.Show(null, "enter a valid email id", "error");
                        return false;
                    }
                }
                else
                {
                    PanException.Show(null, "enter a valid email id", "error");
                    return false;
                }

            }
            catch
            {
                return false;
            }
        }

        /*public bool checkNIC()
        {
            string pattern = null;
            pattern = "^[0-9]{9}[vVxX]$";

            if (!Regex.IsMatch(NIC_txt.Text, pattern))
            {
                return false;
            }
            return true;
        }*/
        public bool checkNIC(String str)
        {
            if ((str.Count(char.IsDigit) == 9) && // only 9 digits
                (str.EndsWith("X", StringComparison.OrdinalIgnoreCase)
                 || str.EndsWith("V", StringComparison.OrdinalIgnoreCase)) && //a letter at the end 'x' or 'v'
                (str[2] != '4' && str[2] != '9')) //3rd digit can not be equal to 4 or 9
            {
                //Valid
                return true;

            }
            else
            {
                //invalid
                return false;
            }
        }
       /* public bool checkMobile()
        {
            if (Mob_txt.TextLength < 7 && Mob_txt.TextLength > 15)
            {
                return false;
            }
            return true;
        }
        */
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

        public void getNoOfLeaveDays()
        {
            try
            {
                String a = "select COALESCE(sum(NoOfDays),0) from itp.leave_view where EmpId = '" + Connection.getUserIdFromConnectionString() + "' and Status = 'Accepted' and Type = 'Annual' ;";
                String c = "select COALESCE(sum(NoOfDays),0) from itp.leave_view where EmpId = '" + Connection.getUserIdFromConnectionString() + "' and Status = 'Accepted' and Type = 'Casual';";
            MySqlConnection MyConn = ConnectionOld.getConnection();
            MySqlCommand SelectCommandAnnual = new MySqlCommand(a, MyConn);
            MySqlCommand SelectCommandCasual = new MySqlCommand(c, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = SelectCommandAnnual.ExecuteReader();

            if (MyReader.Read())
            {
                
                    labRemAnnual.Text = (14 - MyReader.GetInt32(0)).ToString();
                
            }
            MyConn.Close();
            MyReader = null;
            MyConn.Open();
            MyReader = SelectCommandCasual.ExecuteReader();

            if (MyReader.Read())
            {
                int x;
                
                    x = MyReader.GetInt32(0);
                    labRemCasual.Text = (7 - x).ToString();
                
            }
            }
            catch (MySqlException ex)
            {
                PanException.Show(this.MdiParent,ex);
            }
        }

        public void Insert()
        {
            isEmpty();
           
             if (!checkMail(this.Email_txt.Text))
            {
                //MessageBox.Show("Not a valid Email address ");
                PanException.Show(this.MdiParent, "Validation Error", "Not a valid Email address");
                return;
            }
            else if (labNationality.Text == "NIC" &&(!checkNIC(this.NIC_txt.Text)))
            {
                //MessageBox.Show("Not a valid NIC Number ");
                PanException.Show(this.MdiParent, "Validation Error", "Not a valid NIC Number");
                return;
            }
            else if (Double.Parse(textBox5.Text) < 10000)
            {
                //MessageBox.Show("Basic Salary should be above 10000");
                PanException.Show(this.MdiParent, "Validation Error", "Basic Salary should be above 10000");
                return;
            }
            /*if (!checkMobile())
            {
                MessageBox.Show("Mobile Number should have 10 digits");
                return;
            }*/
            String us = assignUserName();
            int val = getNewId();
            Double sal = Double.Parse(this.textBox5.Text);
            String query = "insert into itp.employee(EmpId,FirstName,LastName,Nationality,Email,MobileNo,NIC,Position,DepId,Gender,DOB,Address,UserName,Password,BasicSalary) values('" + this.Emp_txt.Text + "','" + this.First_txt.Text + "','" + this.Last_txt.Text + "','" + nat + "','" + this.Email_txt.Text + "','" + this.Mob_txt.Text + "','" + this.NIC_txt.Text + "','" + this.Posi_combo.Text + "','" + dep + "','" + gender + "','" + this.dateTimePicker1.Text + "','" + this.Add_txt.Text + "','" + us + "','" + pw + "','" + sal + "'); ";
            MySqlConnection connDatabase = ConnectionOld.getConnection();
            MySqlCommand cmdDatabase = new MySqlCommand(query, connDatabase);
            MySqlCommand createUser = new MySqlCommand("CREATE_USER",connDatabase);
            createUser.CommandType = CommandType.StoredProcedure;
            createUser.Parameters.AddWithValue("user_id_", this.Emp_txt.Text);
            createUser.Parameters.AddWithValue("password_",pw);
            createUser.Parameters.AddWithValue("name_", this.First_txt.Text + " " + this.Last_txt.Text);
            
            try
            {
                connDatabase.Open();
                cmdDatabase.ExecuteNonQuery();
                createUser.ExecuteNonQuery();
                //MessageBox.Show("Records are saved successfully\n" + this.First_txt.Text +  this.Last_txt.Text +  " 's Username is " + us);
                PanMessage.Show(this.MdiParent, "Success", "Records are saved successfully\n" + this.First_txt.Text + this.Last_txt.Text + " 's Username is " + us);
                
            }

            catch (MySqlException ex)
            {
                PanException.Show(this.MdiParent,ex);
            }
        }

        public String assignUserName() 
        {
            String fn = this.First_txt.Text;
            String user = ini + this.Emp_txt.Text +fn;
            return user;

        }

        //public void getMonthComboValues()
        //{
        //    String[] m = {"January","February","March","April","May","June","July","August","September","October","November","December"};   
            
        //        MySqlConnection MyConn = ConnectionOld.getConnection();
        //        MySqlCommand SelectCommand = new MySqlCommand("select distinct Month from ot;", MyConn);
        //        MySqlDataReader MyReader;
        //        MyConn.Open();
        //        MyReader = SelectCommand.ExecuteReader();

        //        while (MyReader.Read())
        //        {
        //            String mon = MyReader.GetString("Month");
        //            for (int i = 0; i < m.Length; i++)
        //            {
        //                if (mon != m[0])
        //                {
        //                    combo_Month.Items.Add(mon);
        //                }


        //            }
 
        //        }
        //}
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
                    
                    if ( (MyReader.GetString("Nationality") == "SriLankan") )
                    {
                        combo_Nat.Text = "SriLankan";

                    }
                    else
                    {
                        combo_Nat.Text = "Foreigner";
                        Nat_txt.Text = MyReader.GetString("Nationality");
                    }

                    NIC_txt.Text = MyReader.GetString("NIC");
                    Add_txt.Text = MyReader.GetString("Address");
                    Email_txt.Text = MyReader.GetString("Email");
                    Mob_txt.Text = MyReader.GetString("MobileNo");
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
                //MessageBox.Show("Records are edited successfully");
                PanMessage.Show(this.MdiParent, "Success", "Records are edited successfully");
            }

            catch (MySqlException ex)
            {
                PanException.Show(this.MdiParent,ex);
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

                catch (MySqlException ex)
                {
                    PanException.Show(this.MdiParent,ex);
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

                catch (MySqlException ex)
                {
                    PanException.Show(this.MdiParent,ex);
                }
            }

        }

         public void refreshOtTable()
         {
             //MessageBox.Show("Hello");
             MySqlConnection connDatabase = ConnectionOld.getConnection();
             MySqlCommand q4 = new MySqlCommand(@"select e.EmpId,FirstName,LastName,o.OTHours 
                                                    from employee e 
                                                    LEFT OUTER JOIN (
                                                    select EmpId,OTHours from ot where Month = '"+ mon +"' ) o ON o.EmpId =e.EmpId;",

                 connDatabase);
             //q4.Parameters.AddWithValue("@mon", mon);
            
             
             try
             {
                 
                // MySqlDataAdapter sda = new MySqlDataAdapter();
                 sda.SelectCommand = q4;
                 //DataTable dataset = new DataTable();
                 datasetOT.Clear();
                 sda.Fill(datasetOT);
                 //BindingSource bSource = new BindingSource();

                 bindingSource1.DataSource = datasetOT;
                 dataGridView4.DataSource = bindingSource1;
                 
                 //sda.Update(dataset);
             }

             catch (MySqlException ex)
             {
                 PanException.Show(this.MdiParent,ex);
             }
         }

         public void defaultOtTable()
         {
             MySqlConnection connDatabase = ConnectionOld.getConnection();
             MySqlCommand q4 = new MySqlCommand("select e.EmpId,FirstName,LastName,o.OTHours from employee e LEFT OUTER JOIN ot o ON e.EmpId = o.EmpId where o.Month = @mon;", connDatabase);
             q4.Parameters.AddWithValue("@mon", "January");

             try
             {
                 //MySqlDataAdapter sda = new MySqlDataAdapter();
                 sda.SelectCommand = q4;
                 //DataTable dataset = new DataTable();
                 datasetOT.Clear();
                 sda.Fill(datasetOT);
                 //BindingSource bSource = new BindingSource();

                 bindingSource1.DataSource = datasetOT;
                 dataGridView4.DataSource = bindingSource1;
                 //sda.Update(dataset);
             }

             catch (MySqlException ex)
             {
                 PanException.Show(this.MdiParent,ex);
             }
         }

         public void refreshSalaryTable()
         {
             MySqlConnection connDatabase = ConnectionOld.getConnection();
             MySqlCommand q4 = new MySqlCommand("select Month,NetSalary from salary where EmpId = @empid ;", connDatabase);
             q4.Parameters.AddWithValue("@empId", Connection.getUserIdFromConnectionString());
             try
             {

                 MySqlDataAdapter sal = new MySqlDataAdapter();
                 sal.SelectCommand = q4;
                 DataTable dt = new DataTable();
                 sal.Fill(dt);
                 BindingSource bSal = new BindingSource();

                 bSal.DataSource = dt;
                 metroGrid1.DataSource = bSal;
                 //sda.Update(dataset);
             }

             catch (MySqlException ex)
             {
                 PanException.Show(this.MdiParent,ex);
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

             catch (MySqlException ex)
             {
                 PanException.Show(this.MdiParent,ex);
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
            groupBox4.Hide();
            First_txt.Text = " ";
            Last_txt.Text = " ";
            radioButton2.Checked = false;
            this.dateTimePicker1.Value = DateTime.Now;
            Add_txt.Text = " ";
            Mob_txt.Text = "+(94)";
            Email_txt.Text = " ";
            Nat_txt.Text = " ";
            NIC_txt.Text = " ";
            Posi_combo.SelectedIndex = -1;
            Dep_txt.Text = " ";
            textBox5.Text = " ";
            radioButton1.Checked = true;
           

            int val = getNewId();
            Emp_txt.Text = val.ToString();
            Save.Show();
            Edit.Hide();
           
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
            else if (position == "Finished Good Manager")
            {
                dep = "Products";
                ini = "PD";
            }
            else if (position == "Product Process Manager")
            {
                dep = "Products";
                ini = "PD";
            }
            else if (position == "Raw Materials Manager")
            {
                dep = "Materials";
                ini = "RM";
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
            Emp_txt.ReadOnly = true;
            dateTimePicker3.MinDate = DateTime.Now.AddDays(1);
            dateTimePicker2.MinDate = dateTimePicker3.MinDate.AddDays(1);
            dateTimePicker2.MaxDate = DateTime.Now.AddMonths(2);
            refreshSalaryTable();
            combo_Month.SelectedIndex = 0;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            AddOT.TabPages.Remove(tabCheckLeaveRequests);
            AddOT.TabPages.Remove(tabAddOT);
            //AddOT.TabPages.Remove(tabCalSalary);

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
                                            AddOT.TabPages.Remove(tabSendLeaveRequests);
                                            //AddOT.TabPages.Remove(tabViewSalary);
                                            //this.tabViewSalary.Text = "Calculate Salary";
                                             AddOT.TabPages.Add(tabCheckLeaveRequests);
                                             AddOT.TabPages.Add(tabAddOT);
                                             //AddOT.TabPages.Add(tabCalSalary);
                                             Rem.Show();
                                            //Emp_txt.ReadOnly = false;
                                            First_txt.ReadOnly = false;
                                            Last_txt.ReadOnly = false;
                                            //radioButton1.Enabled = true;
                                            //radioButton2.Enabled = true;
                                            dateTimePicker1.Enabled = true;
                                            Nat_txt.ReadOnly = false;
                                            NIC_txt.ReadOnly = false;
                                            Add_txt.ReadOnly = false;
                                            Mob_txt.ReadOnly = false;
                                            Email_txt.ReadOnly = false;
                                            Posi_combo.Enabled = true;
                                            textBox5.ReadOnly = false;
                                            combo_Nat.Enabled = true;
                            break;
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    PanException.Show(this.MdiParent,ex);
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
           // displayDataGridViewSearch();
          
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
                //MessageBox.Show("Record is deleted successfully");
                PanMessage.Show(this.MdiParent, "Record Deleted" ,"Record is deleted successfully");
                displayDataGridViewSearch();
            }

            catch (MySqlException ex)
            {
                PanException.Show(this.MdiParent,ex);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_Month.SelectedIndex = 0;
            refreshEmpLeaveTable();
            refreshHRLeaveTable();
            displayDataGridViewSearch();

            defaultOtTable();
            refreshSalaryTable();
            getNoOfLeaveDays();
            //getMonthComboValues();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int Annual = Int32.Parse(labRemAnnual.Text);
            int Casual = Int32.Parse(labRemCasual.Text);


            DateTime endDate = dateTimePicker2.Value;
            DateTime startDate = dateTimePicker3.Value;

            TimeSpan tspan = endDate - startDate;

            int differenceInDays = tspan.Days;
           
            if ((this.Type_combo.Text == "Annual") && (differenceInDays > Annual))
            {
                PanException.Show(this.MdiParent, "Annual leave", "You are exceeding the number of remaining annual days");
                return;
            }

            if ((this.Type_combo.Text == "Casual") && (differenceInDays > Casual))
            {
                PanException.Show(this.MdiParent, "Casual leave", "You are exceeding the number of remaining casual days");
                return;
            }



           

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
                //MessageBox.Show("Records are saved successfully\n");
                PanMessage.Show(this.MdiParent, "Success", "Your leave request has been sent");
                refreshEmpLeaveTable();

            }

            catch (MySqlException ex)
            {
                PanException.Show(this.MdiParent,ex);
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
                //MessageBox.Show("You have accepted the request");
                PanMessage.Show(this.MdiParent, "Leave Request", "Leave request accepted");
                
                refreshHRLeaveTable();
            }

            catch (MySqlException ex)
            {
                PanException.Show(this.MdiParent,ex);
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
                //MessageBox.Show("You have rejected the request");
                PanMessage.Show(this.MdiParent, "Leave Request", "Leave request rejected");
                refreshHRLeaveTable();
            }

            catch (MySqlException ex)
            {
                PanException.Show(this.MdiParent,ex);
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

       
        private void Ot_Save_Click(object sender, EventArgs e)
        {
            
            MySqlCommand ic = new MySqlCommand("INSERT INTO ot (EmpId,OTHours,Month) VALUES (@empid,@ot,'" + mon + "')", con);
            ic.Parameters.Add("@empid", MySqlDbType.Int32, 200, "EmpId");
            ic.Parameters.Add("@ot", MySqlDbType.Float, 200, "OTHours");
            

            MySqlCommand uc = new MySqlCommand("INSERT INTO ot (EmpId,OTHours,Month) VALUES (@empid,@ot,'"+mon+"')", con);
            uc.Parameters.Add("@empid", MySqlDbType.Int32, 200, "EmpId");
            uc.Parameters.Add("@ot", MySqlDbType.Float,200,"OTHours");
            

            sda.InsertCommand = ic;
            sda.UpdateCommand = uc;
            this.Validate();
            bindingSource1.EndEdit();
            sda.Update(datasetOT);
            //MessageBox.Show("OT Hours Added");
            PanMessage.Show(this.MdiParent, "OT Hours", "OT hours have been added");
        }

        private void combo_Month_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void combo_Month_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            String month = this.combo_Month.Text;
            switch (month)
            {
                case "January"  : mon = "January"; break;
                case "February" : mon = "February"; break;
                case "March"    : mon = "March"; break;
                case "April"    : mon = "April"; break;
                case "May"      : mon = "May"; break;
                case "June"     : mon = "June"; break;
                case "July"     : mon = "July"; break;
                case "August"   : mon = "August"; break;
                case "September": mon = "September"; break;
                case "October"  : mon = "October"; break;
                case "November" : mon = "November"; break;
                case "December" : mon = "December"; break;

            }
            //MessageBox.Show(mon);
            refreshOtTable();
           
        }

      

        private void combo_Nat_SelectedIndexChanged(object sender, EventArgs e)
        {
            String comboNat = this.combo_Nat.Text;
            if (comboNat == "SriLankan")
            {
                labNationality.Text = "NIC";
                //Nat_txt.Enabled = false;
                labMention.Hide();
                nat = "SriLankan";
                Nat_txt.Hide();
            }
            else
            {
                nat = this.Nat_txt.Text;
                labNationality.Text = "Passport No";
                labMention.Show();
                Nat_txt.Show();
                Nat_txt.Enabled = true;
            }
        }

        private void dataGridView3_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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

       
        private void button2_Click_1(object sender, EventArgs e)
        {
            SalaryReportViewer viewer = new SalaryReportViewer();
            viewer.ShowDialog();
        }

        private void CalSalary_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                MySqlCommand command = new MySqlCommand("calcSalary", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("_month", salMonth);
                command.ExecuteScalar();
                
                //MessageBox.Show("Salary is calculated for "+salMonth);
                PanMessage.Show(this.MdiParent, "Salary", "Salary is calculated for " + salMonth);
            }
            catch (MySqlException ex)
            {
                PanException.Show(this.MdiParent, ex);
            }
            finally
            {
                con.Close();
            }

        }

        private void comboSalMonth_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            salMonth = this.comboSalMonth.Text;
           
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker3.Value.AddDays(1);
        }

      

      
  
       
        

       

        

       

       

        

        

         }
}

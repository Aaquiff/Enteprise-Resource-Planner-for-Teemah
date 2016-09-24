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
    class FinManagement
    {
        //common variables
        private String assetID;
        private String serial;
        private String insurance;
        private String warranty;
        private String description;
        private int budgetyear;

        //variables for Asset Management
        private String property;
        private String ownership;
        private double value;
        private int lifeTime;
        private int usage;
        private String status;

        //variables for Asset Repair
        private String repairedid;
        private String jobdate;
        private String repairstatus;
        private String problem;

        //variables for Budget
        private String startdate;
        private String enddate;
        private double tot;
        private double employee;
        private double maintanance;
        private double marketing;
        private double transport;

        //variable for Expenses
        private String aproved;
        private String category;
        private String specification;
        private double amount;
        private String edate;

        //methods for Asset Management

        //populate all
        public DataSet getAll(String ptable)
        {
            DBConnects connection = new DBConnects();
            connection.OpenConnection();
            MySqlConnection returnConn = new MySqlConnection();
            returnConn = connection.GetConnection();

            if (returnConn.State.ToString() == "Closed")
            {
                returnConn.Open();
            }

            MySqlCommand newCmd = returnConn.CreateCommand();
            newCmd.Connection = returnConn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from " + ptable;

            MySqlDataAdapter da = new MySqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, ptable);

            returnConn.Close();

            return ds;

        }

        //populate specific Property 
        public DataSet getSpecific(String ptable, String property)
        {
            DBConnects connection = new DBConnects();
            connection.OpenConnection();
            MySqlConnection returnConn = new MySqlConnection();
            returnConn = connection.GetConnection();

            if (returnConn.State.ToString() == "Closed")
            {
                returnConn.Open();
            }

            MySqlCommand newCmd = returnConn.CreateCommand();
            newCmd.Connection = returnConn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from " + ptable + " where Property like '" + property + "'";

            MySqlDataAdapter da = new MySqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, ptable);

            returnConn.Close();

            return ds;

        }

        //populate specific Asset_ID 
        public DataSet getSpecificAID(String ptable, String passetid)
        {
            DBConnects connection = new DBConnects();
            connection.OpenConnection();
            MySqlConnection returnConn = new MySqlConnection();
            returnConn = connection.GetConnection();

            if (returnConn.State.ToString() == "Closed")
            {
                returnConn.Open();
            }

            MySqlCommand newCmd = returnConn.CreateCommand();
            newCmd.Connection = returnConn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from " + ptable + " where Asset_ID like '" + passetid + "%'";

            MySqlDataAdapter da = new MySqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, ptable);

            returnConn.Close();

            return ds;

        }

        //populate specific Repair_ID 
        public DataSet getSpecificRID(String ptable, String prepairid)
        {
            DBConnects connection = new DBConnects();
            connection.OpenConnection();
            MySqlConnection returnConn = new MySqlConnection();
            returnConn = connection.GetConnection();

            if (returnConn.State.ToString() == "Closed")
            {
                returnConn.Open();
            }

            MySqlCommand newCmd = returnConn.CreateCommand();
            newCmd.Connection = returnConn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from " + ptable + " where Repair_ID like '" + prepairid + "%'";

            MySqlDataAdapter da = new MySqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, ptable);

            returnConn.Close();

            return ds;

        }

        //populate specific Budget_ID 
        public DataSet getSpecificBID(String ptable, String pbudgetYear)
        {
            DBConnects connection = new DBConnects();
            connection.OpenConnection();
            MySqlConnection returnConn = new MySqlConnection();
            returnConn = connection.GetConnection();

            if (returnConn.State.ToString() == "Closed")
            {
                returnConn.Open();
            }

            MySqlCommand newCmd = returnConn.CreateCommand();
            newCmd.Connection = returnConn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from " + ptable + " where Budget_Year like '" + pbudgetYear + "'";

            MySqlDataAdapter da = new MySqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, ptable);

            returnConn.Close();

            return ds;

        }

        //Add new asset to the database
        public bool addAsset(String passetID, String pproperty, String pserial, String pownership, double pvalue, String pinsurance, String pwarranty, String pstatus, int plifetime, int pusage, String pdescription)
        {
            this.assetID = passetID;
            this.property = pproperty;
            this.serial = pserial;
            this.ownership = pownership;
            this.value = pvalue;
            this.insurance = pinsurance;
            this.warranty = pwarranty;
            this.status = pstatus;
            this.lifeTime = plifetime;
            this.usage = pusage;
            this.description = pdescription;
            try
            {

                DBConnects connection = new DBConnects();
                connection.OpenConnection();
                MySqlConnection returnConn = new MySqlConnection();
                returnConn = connection.GetConnection();

                string query = "INSERT INTO asset (Asset_ID, Property, Serial_Number, Ownership, Asset_Value, Insurance, Warranty, Active_Status, Life_Time, Year_Usage, Description) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11)";
                MySqlCommand cmd = new MySqlCommand(query, returnConn);

                cmd.Parameters.AddWithValue("@1", this.assetID);
                cmd.Parameters.AddWithValue("@2", this.property);
                cmd.Parameters.AddWithValue("@3", this.serial);
                cmd.Parameters.AddWithValue("@4", this.ownership);
                cmd.Parameters.AddWithValue("@5", this.value);
                cmd.Parameters.AddWithValue("@6", this.insurance);
                cmd.Parameters.AddWithValue("@7", this.warranty);
                cmd.Parameters.AddWithValue("@8", this.status);
                cmd.Parameters.AddWithValue("@9", this.lifeTime);
                cmd.Parameters.AddWithValue("@10", this.usage);
                cmd.Parameters.AddWithValue("@11", this.description);

                cmd.ExecuteNonQuery();
                connection.CloseConnection();

                MessageBox.Show("New Asset added to the database");
                return true;

            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //asset repair auto serial fill

        //add new repair jobs
        public bool addAssetRepair(String prepairid, String passetid, String pjobdate, String pstatus, String pproblem, String pserial, String pwarranty, String pinsurance)
        {

            this.repairedid = prepairid;
            this.assetID = passetid;
            this.jobdate = pjobdate;
            this.repairstatus = pstatus;
            this.problem = pproblem;
            this.serial = pserial;
            this.warranty = pwarranty;
            this.insurance = pinsurance;

            try
            {


                DBConnects connection = new DBConnects();
                connection.OpenConnection();
                MySqlConnection returnConn = new MySqlConnection();
                returnConn = connection.GetConnection();

                string query = "INSERT INTO asset_repair (Repair_ID, Asset_ID, Job_Date, Job_Status, Problem_Specified, Serial_Number, Warranty_Status, Insurance_Status) VALUES (@1, @2, @3, @4, @5, @6, @7, @8)";
                MySqlCommand cmd = new MySqlCommand(query, returnConn);

                cmd.Parameters.AddWithValue("@1", this.repairedid);
                cmd.Parameters.AddWithValue("@2", this.assetID);
                cmd.Parameters.AddWithValue("@3", this.jobdate);
                cmd.Parameters.AddWithValue("@4", this.repairstatus);
                cmd.Parameters.AddWithValue("@5", this.problem);
                cmd.Parameters.AddWithValue("@6", this.serial);
                cmd.Parameters.AddWithValue("@7", this.warranty);
                cmd.Parameters.AddWithValue("@8", this.insurance);

                cmd.ExecuteNonQuery();
                connection.CloseConnection();

                MessageBox.Show("New Asset repair status added to the database");
                return true;

            }

            catch (MySqlException)
            {
                MessageBox.Show("Check Repair ID and Asset ID");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Add new budget to the database
        public bool addBudget(int pbudgetyear, String pstartdate, String penddate, double pemployee, double pmaintanance, double pmarketing, double ptransport, String pdescription, double ptot)
        {
            this.budgetyear = pbudgetyear;
            this.startdate = pstartdate;
            this.enddate = penddate;
            this.employee = pemployee;
            this.maintanance = pmaintanance;
            this.marketing = pmarketing;
            this.transport = ptransport;
            this.description = pdescription;
            this.tot = ptot;
            try
            {

                DBConnects connection = new DBConnects();
                connection.OpenConnection();
                MySqlConnection returnConn = new MySqlConnection();
                returnConn = connection.GetConnection();

                string query = "INSERT INTO fms_budget (Budget_Year, Budget_Start_Date, Budget_End_Date, Employee_Cost, Maintanance_Cost, Marketing_Cost, Transport_Cost, Description, Total_Value) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9)";
                MySqlCommand cmd = new MySqlCommand(query, returnConn);

                cmd.Parameters.AddWithValue("@1", this.budgetyear);
                cmd.Parameters.AddWithValue("@2", this.startdate);
                cmd.Parameters.AddWithValue("@3", this.enddate);
                cmd.Parameters.AddWithValue("@4", this.employee);
                cmd.Parameters.AddWithValue("@5", this.maintanance);
                cmd.Parameters.AddWithValue("@6", this.marketing);
                cmd.Parameters.AddWithValue("@7", this.transport);
                cmd.Parameters.AddWithValue("@8", this.description);
                cmd.Parameters.AddWithValue("@9", this.tot);

                cmd.ExecuteNonQuery();
                connection.CloseConnection();

                MessageBox.Show("New Budget added to the database");
                return true;

            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Add new expenses to the database
        public bool addExpenses(int pbudgetyear, String paproved, String pcategory, String pspecification, double pamount, String pdate, String pdescription)
        {
            this.budgetyear = pbudgetyear;
            this.aproved = paproved;
            this.category = pcategory;
            this.specification = pspecification;
            this.amount = pamount;
            this.edate = pdate;
            this.description = pdescription;
            try
            {

                DBConnects connection = new DBConnects();
                connection.OpenConnection();
                MySqlConnection returnConn = new MySqlConnection();
                returnConn = connection.GetConnection();

                string query = "INSERT INTO fms_expenses (Budget_Year, Aproved_By, Expense_Category, Expense_Specification, Expense_Amount, Expense_Date, Description) VALUES (@1, @2, @3, @4, @5, @6, @7)";
                MySqlCommand cmd = new MySqlCommand(query, returnConn);

                cmd.Parameters.AddWithValue("@1", this.budgetyear);
                cmd.Parameters.AddWithValue("@2", this.aproved);
                cmd.Parameters.AddWithValue("@3", this.category);
                cmd.Parameters.AddWithValue("@4", this.specification);
                cmd.Parameters.AddWithValue("@5", this.amount);
                cmd.Parameters.AddWithValue("@6", this.edate);
                cmd.Parameters.AddWithValue("@7", this.description);

                cmd.ExecuteNonQuery();
                connection.CloseConnection();
                return true;

            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

    }

}

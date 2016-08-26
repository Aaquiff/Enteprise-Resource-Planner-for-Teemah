using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace SalesManagement.Class_files
{
    public class validate
    {
        public static bool isEmpty(String s)
        {
            try
            {
                if (s.Length > 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("One or more fields are empty", "Error");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return false;
            }
        }

        public static bool isEmpty(String s1, String s2, String s3, String s4, String s5, String s6)
        {
            if (s1.Length == 0 || s2.Length == 0 || s3.Length == 0 || s4.Length == 0 || s5.Length == 0 || s6.Length == 0)
            {
                MessageBox.Show(null, "One or more fields are empty", "Error");
                return false;
            }
            else
            {
                return true;
            }

        }

        public static bool isNic(String s)
        {
            bool x = false;

            if (s.Length == 10)
            {
                if ((s.IndexOf('V')) >= 0 || (s.IndexOf('v')) >= 0)
                {
                    if ((s[9] == 'v') || (s[9] == 'V'))
                    {
                        for (int i = 0; i < s.Length - 1; i++)
                        {
                            if (validate.isNumber(i.ToString()))
                            {
                                x = true;
                            }
                            else
                            {
                                x = false;
                            }
                        }

                        if (x == true)
                            return true;
                        else
                            return false;
                    }
                    else
                    {
                        MessageBox.Show(null, "Invalid NIC Number", "Error");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show(null, "Invalid NIC Number", "Error");
                    return false;
                }
            }
            else
            {
                MessageBox.Show(null, "Invalid NIC Number", "Error");
                return false;
            }
        }

        public static bool isContact(String s)
        {
            try
            {
                if (s.Length == 10)
                {
                    if (!Regex.IsMatch(s, "^[0-9]+$"))
                    {
                        MessageBox.Show(null, "Contact number consists invalid characters", "Error");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    MessageBox.Show("Contact Number must have 10 digits", "Error");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return false;
            }
        }

        public static bool isChar(String s)
        {
            try
            {
                if (!Regex.IsMatch(s, "^[a-zA-Z]+$"))
                {
                    MessageBox.Show(null, "One or more fields has an invalid value", "Error");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return false;
            }

        }

        public static bool isNumber(String s)
        {
            try
            {
                if (!Regex.IsMatch(s, "^[0-9]+$"))
                {
                    MessageBox.Show(null, "One or more fields has an invalid value", "Error");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return false;
            }
        }

        public static bool isEmail(String s)
        {
            try
            {
                int num = s.IndexOf('@');
                int num2 = s.IndexOf('.');

                if (!String.IsNullOrEmpty(s) && (s[0] != ' ' || s[0] != '\t' || s[0] != '.'))
                {
                    if (s.EndsWith(".com") || s.EndsWith(".lk"))
                    {
                        if (num < num2 && (num + 1) != num2)
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show(null, "Invalid Email ID", "Error");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show(null, "Enter a valid Email ID", "Error");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show(null, "Enter a valid Email ID", "Error");
                    return false;
                }

            }
            catch
            {
                return false;
            }
        }
    }
}

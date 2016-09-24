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

        public static bool isNic(String str)
        {
            //bool x = false;

            //if (s.Length == 10)
            //{
            //    if ((s.IndexOf('V')) >= 0 || (s.IndexOf('v')) >= 0)
            //    {
            //        if ((s[9] == 'v') || (s[9] == 'V'))
            //        {
            //            for (int i = 0; i < s.Length - 1; i++)
            //            {
            //                if (validate.isNumber(i.ToString()))
            //                {
            //                    x = true;
            //                }
            //                else
            //                {
            //                    x = false;
            //                }
            //            }

            //            if (x == true)
            //                return true;
            //            else
            //                return false;
            //        }
            //        else
            //        {
            //            MessageBox.Show(null, "Invalid NIC Number", "Error");
            //            return false;
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show(null, "Invalid NIC Number", "Error");
            //        return false;
            //    }
            //}
            //else
            //{
            //    MessageBox.Show(null, "Invalid NIC Number", "Error");
            //    return false;
            //}

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

        #region isNumber
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
        #endregion

        public static bool isEmail(String s)
        {
            //try
            //{
            //    int num = s.IndexOf('@');
            //    int num2 = s.IndexOf('.');

            //    if (!string.IsNullOrEmpty(s) && (s[0] != ' ' || s[0] != '\t' || s[0] != '.'))
            //    {
            //        if (s.EndsWith(".com") || s.EndsWith(".lk"))
            //        {
            //            if (num < num2 && (num + 1) != num2)
            //            {
            //                return true;
            //            }
            //            else
            //            {
            //               MessageBox.Show(null, "invalid email id", "error");
            //                return false;
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show(null, "enter a valid email id", "error");
            //            return false;
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show(null, "enter a valid email id", "error");
            //        return false;
            //    }

            //}
            //catch
            //{
            //    return false;
            //}

            try
            {
                var addr = new System.Net.Mail.MailAddress(s);
                return addr.Address == s;
            }
            catch
            {
                return false;
            }
        }
    }
}

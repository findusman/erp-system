using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace GEN.GEN_GEN.GenericClasses
{
    public class cls_MessageBox
    {
        public string space = "                                           ";

        public string insert_msg = "Your information has been inserted successfully." + Environment.NewLine + Environment.NewLine + "Thanks";
        public string update_msg = "Your Information Has Been Updated Successfully." + Environment.NewLine + Environment.NewLine + "Thanks";
        public string delete_msg = "Your Information Has Been Deleted Successfully." + Environment.NewLine + Environment.NewLine + "Thanks";
        public string save_msg = "Your Information Has Been Saved Successfully." + Environment.NewLine + Environment.NewLine + "Thanks";


        public string question_insert_msg = "Are You Sure To Insert The Information." + Environment.NewLine + Environment.NewLine + "Thanks";
        public string question_insert_print_msg = "Are You Sure To Insert And Prin." + Environment.NewLine + Environment.NewLine + "Thanks";
        public string question_print_msg = "Are You Sure To Preview The Information." + Environment.NewLine + Environment.NewLine + "Thanks";

        public string question_update_msg = "Are You Sure To Update The Information." + Environment.NewLine + Environment.NewLine + "Thanks";
        public string question_delete_msg = "Are You Sure To Delete The Information." + Environment.NewLine + Environment.NewLine + "Thanks";
        public string question_save_msg = "Are You Sure To Save The Information." + Environment.NewLine + Environment.NewLine + "Thanks";

        public string error_insert_msg = "Your Information Has Been Not Inserted Successfully." + Environment.NewLine + Environment.NewLine + "Thanks";
        public string error_update_msg = "Your Information Has Been Not Updated Successfully." + Environment.NewLine + Environment.NewLine + "Thanks";
        public string error_delete_msg = "Your Information Has Been Not Deleted Successfully." + Environment.NewLine + Environment.NewLine + "Thanks";
        public string error_save_msg = "Your Information Has Been Not Saved Successfully." + Environment.NewLine + Environment.NewLine + "Thanks";
        public string error_selection_msg = "First select a record in order to perform action." + Environment.NewLine + Environment.NewLine + "Thanks";
        public string error_ID_msg = "First provide a unique ID in order to perform action." + Environment.NewLine + Environment.NewLine + "Thanks";
        public string error_Name_msg = "First provide a Name in order to perform action." + Environment.NewLine + Environment.NewLine + "Thanks";
        public string error_BLL_msg = "There's an error in BLL or in store procedure." + Environment.NewLine + Environment.NewLine + "Thanks";
        public string error_Login_msg = "Your Login ID or Password are wrong." + Environment.NewLine + Environment.NewLine + "Thanks";
       
          public string error_Initialization_msg = "There's an error in Initialization." + Environment.NewLine + Environment.NewLine + "Thanks";
       
          public string error_VP_msg = "Kindly provide values in proper format." + Environment.NewLine + Environment.NewLine + "Thanks";
        public string error_TB_msg = "There's no data against this ID." + Environment.NewLine + Environment.NewLine + "Thanks";
        public string error_DEF_Table_No_provide_msg = "Kindly provide some data to be save." + Environment.NewLine + Environment.NewLine + "Thanks";
        public string error_notAllowedToOpenScreen = "You don't have rights to open this screen." + Environment.NewLine + Environment.NewLine + "Thanks";
        public string grid_insert_msg = "Please Provide Some Data to Insert." + Environment.NewLine + Environment.NewLine + "Thanks";

     
        public string error_insert_rights = "You don't have the rights to insert this record." + Environment.NewLine + Environment.NewLine + "Thanks";
        public string error_update_rights = "You don't have the rights to update this record." + Environment.NewLine + Environment.NewLine + "Thanks";
        public string error_delete_rights = "You don't have the rights to delete this record." + Environment.NewLine + Environment.NewLine + "Thanks";
        public string error_preview_rights = "You don't have the rights to preview this report." + Environment.NewLine + Environment.NewLine + "Thanks";
        public string error_save_rights = "You don't have the rights to save this record." + Environment.NewLine + Environment.NewLine + "Thanks";


        public string error_provide_val = " Please provide values first. " + Environment.NewLine + Environment.NewLine + "Thanks";
        public string error_pass_missmatched = " Password do not matched. " + Environment.NewLine + Environment.NewLine + "Thanks";

        public string error_invalidLog = " Invalid Login ID or Name. " + Environment.NewLine + Environment.NewLine + "Thanks";
        public string error_RightsSelection = " Please Provide a Role First . " + Environment.NewLine + Environment.NewLine + "Thanks";
        public string error_NumOfBranch = " Please Provide Valid Branches First . " + Environment.NewLine + Environment.NewLine + "Thanks";
        public string error_ProvidePass = " Please Provide a Password First . " + Environment.NewLine + Environment.NewLine + "Thanks";
        public string error_ProvideName = " Please Provide a Name First . " + Environment.NewLine + Environment.NewLine + "Thanks";
        public string error_loginFromcompany = " Please Login from a Company First ." + Environment.NewLine + Environment.NewLine + "Thanks";
        public string error_accessdenied = " You cannot modify your own rights ." + Environment.NewLine + Environment.NewLine + "Thanks";
        public string error_cannot_use = " You Cannot Use this Name ." + Environment.NewLine + Environment.NewLine + "Thanks";
        public string error_cannot_modify = " You are Unauthorized to Modify this Right." + Environment.NewLine + Environment.NewLine + "Thanks";
        public string error_debit_credit_not_equal = "Your net debit and credit is not equal." + Environment.NewLine + Environment.NewLine + "Thanks";

        public string error_code_exceed = " Your Chart of Account Code Limit is Exceeded." + Environment.NewLine + Environment.NewLine + "Thanks";
        public string error_code_not_Provided = "Chart of Account Code is Not Provided." + Environment.NewLine + Environment.NewLine + "Thanks";
          public string error_Not_Enough_Stock_To_Sale = "You don't have enough stock to sale." + Environment.NewLine + Environment.NewLine + "Thanks";



        


        public static bool question = true;
        public static bool success = true;
        public static bool errror = true;
        public bool applyRights = false;

        public static string Get_Msg_Return = "";

        public static string question_title = "IM MS";
        public static string success_title = "IM MS";
        public static string error_title = "IM MS";
        public static string save_title = "IM MS";
        public static string rights_title = "IM MS";


        public string MessageBoxStatic(string type)
        {
            if (applyRights)
            {
                if (type == "I_R")
                {
                    XtraMessageBox.Show(error_insert_rights, rights_title, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                else if (type == "U_R")
                {
                    XtraMessageBox.Show(error_update_rights, rights_title, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }


                else if (type == "D_R")
                {
                    XtraMessageBox.Show(error_delete_rights, rights_title, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }


                else if (type == "S_R")
                {
                    XtraMessageBox.Show(error_save_rights, rights_title, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                else if (type == "P_R")
                {
                    XtraMessageBox.Show(error_preview_rights, rights_title, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                if (type == "C_E")
                {
                    XtraMessageBox.Show(error_code_exceed, rights_title, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }

            if (question == true)
            {
                if (type == "I_Q")
                {
                    if (XtraMessageBox.Show(question_insert_msg, question_title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    {
                        return "no";

                    }
                    else
                    {

                        return "yes";
                    }


                }


                else if (type == "U_Q")
                {

                    if (XtraMessageBox.Show(question_update_msg, question_title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    {
                        return "no";

                    }
                    else
                    {

                        return "yes";
                    }
                }

                else if (type == "D_Q")
                {

                    if (XtraMessageBox.Show(question_delete_msg, question_title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    {
                        return "no";

                    }
                    else
                    {

                        return "yes";
                    }
                }

                else if (type == "S_Q")
                {

                    if (XtraMessageBox.Show(question_save_msg, question_title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    {
                        return "no";

                    }
                    else
                    {

                        return "yes";
                    }
                }


            }
            //else
            //{

            //    return "NoQuestion";
            //}


            if (success == true)
            {
                if (type == "I_S")
                {
                    XtraMessageBox.Show(insert_msg, success_title, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else if (type == "U_S")
                {
                    XtraMessageBox.Show(update_msg, success_title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (type == "D_S")
                {
                    XtraMessageBox.Show(delete_msg, success_title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (type == "S_S")
                {
                    XtraMessageBox.Show(insert_msg, success_title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                //return "ok";

            }


            if (errror == true)
            {
                if (type == "I_E")
                {
                    XtraMessageBox.Show(error_insert_msg, error_title, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                if (type == "G_E")
                {
                    XtraMessageBox.Show(grid_insert_msg, error_title, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                else if (type == "U_E")
                {
                    XtraMessageBox.Show(error_update_msg, error_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (type == "D_E")
                {
                    XtraMessageBox.Show(error_delete_msg, error_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (type == "S_E")
                {
                    XtraMessageBox.Show(error_save_msg, error_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (type == "I_RE")
                {
                    XtraMessageBox.Show(error_insert_rights, error_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (type == "D_RE")
                {
                    XtraMessageBox.Show(error_delete_rights, error_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (type == "U_RE")
                {
                    XtraMessageBox.Show(error_update_rights, error_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (type == "P_RE")
                {
                    XtraMessageBox.Show(error_preview_rights, error_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (type == "SE_E")
                {
                    XtraMessageBox.Show(error_selection_msg, error_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (type == "BLL_E")
                {
                    XtraMessageBox.Show(error_BLL_msg, error_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (type == "Key_Are_Not_Properly_Loaded")
                {
                      XtraMessageBox.Show("Keys are not loaded Properly", error_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (type == "Login_E")
                {
                      XtraMessageBox.Show(error_Login_msg, error_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (type == "INI_E")
                {
                      XtraMessageBox.Show(error_Initialization_msg, error_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (type == "VP_E")
                {
                    XtraMessageBox.Show(error_VP_msg, error_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (type == "TB_E")
                {
                    XtraMessageBox.Show(error_TB_msg, error_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (type == "Not Enough Stock To Sale")
                {
                      XtraMessageBox.Show(error_Not_Enough_Stock_To_Sale, error_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return "ok";

            }


            return "";
        }


        public string MessageBoxDynamics(string message, string type)
        {

            if (question == true)
            {
                if (type == "I_Q")
                {
                    if (XtraMessageBox.Show(message, question_title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    {
                        return "no";

                    }


                }


                else if (type == "U_Q")
                {

                    if (XtraMessageBox.Show(message, question_title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    {
                        return "no";

                    }
                }

                else if (type == "D_Q")
                {

                    if (XtraMessageBox.Show(message, question_title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    {
                        return "no";

                    }
                }

                else if (type == "S_Q")
                {

                    if (XtraMessageBox.Show(message, question_title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    {
                        return "no";

                    }
                }

                else if (type == "D_R")
                {
                    if (XtraMessageBox.Show(message, question_title, MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        return "no";

                    }


                }

            }


            if (success == true)
            {
                if (type == "I_S")
                {
                    XtraMessageBox.Show(message, success_title, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else if (type == "U_S")
                {
                    XtraMessageBox.Show(message, success_title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (type == "D_S")
                {
                    XtraMessageBox.Show(message, success_title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (type == "S_S")
                {
                    XtraMessageBox.Show(message, success_title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                //  return "ok";

            }


            if (errror == true)
            {
                if (type == "I_E")
                {
                    XtraMessageBox.Show(message, error_title, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                else if (type == "U_E")
                {
                    XtraMessageBox.Show(message, error_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (type == "D_E")
                {
                    XtraMessageBox.Show(message, error_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (type == "S_E")
                {
                    XtraMessageBox.Show(message, error_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                return "ok";

            }


            return "";
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using Gen_FormSub;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraEditors.Controls;
using System.Drawing;




#region MAin Namespace Use For Calling
namespace GEN.GEN_GEN.GenericClasses.Form
{


    public class Gen_Form : IDisposable
    {

        public static object checkDbNull(object val)
        {
            if (val.GetType() == typeof(System.DBNull))
                return null;
            return val;
        }

        #region ToolTipVariables


        public String ToolTipSave = "";
        public String ToolTipDelete = "";
        public String ToolTipUpdate = "";
        public String ToolTipExit = "";
        public String ToolTipList = "";
        public String ToolTipRefresh = "";
        public String ToolTipRefres_A = "";
        public String ToolTipPrint = "";
        public String ToolTipPreview = "";
        public String ToolTipLoad = "";
        public String ToolTipExport = "";
        public String ToolTipChild = "";
        public String ToolTipSibling = "";


        public String ToolTipTitleSave = "";
        public String ToolTipTitleDelete = "";
        public String ToolTipTitleUpdate = "";
        public String ToolTipTitleExit = "";
        public String ToolTipTitleList = "";
        public String ToolTipTitleRefresh = "";
        public String ToolTipTitleRefres_A = "";
        public String ToolTipTitlePrint = "";
        public String ToolTipTitlePreview = "";
        public String ToolTipTitleLoad = "";
        public String ToolTipTitleExport = "";
        public String ToolTipTitleChild = "";
        public String ToolTipTitleSibling = "";



        #endregion




        #region AllObjects variables


        bool Refreshed;
        XtraForm XtraForm;
        internal List<SimpleButton> Listbtn = new List<SimpleButton>();
        List<Control> AllControlsList = new List<Control>();


        Gen_Apperance objApp = new Gen_Apperance();
        Gen_ShortKey objShk = new Gen_ShortKey();
        Gen_Formatting objFrt = new Gen_Formatting();
        Gen_Refresh objRef = new Gen_Refresh();



        public void Dispose()
        {
            if (XtraForm != null)
            {
                XtraForm.Dispose();
                XtraForm = null;

            }


        }

        #endregion





        #region  Constructor / initilization of All Controls. Getting All Controls here
        public Gen_Form(XtraForm objfrm)
        {
            XtraForm = objfrm;
            Listbtn.Clear();
            XtraForm.KeyPreview = true;

            var Clst = from controls in objfrm.Controls.OfType<Control>()
                       select controls;






            // System.Drawing.Font = new Font("Arial", 8, FontStyle.Bold);




            //get buttons
            var btns = from controls in Clst.OfType<SimpleButton>()
                       select controls;

            foreach (SimpleButton btn in btns)
            {

                try
                {



                    btn.Font = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));



                    if (btn.Text == "Refresh_A" || btn.Tag == "Refresh_A")
                    {
                        btn.Size = new System.Drawing.Size(5, 5);
                        btn.Visible = false;
                        btn.ToolTip = ToolTipRefres_A;
                        btn.ToolTipTitle = ToolTipTitleRefres_A;
                        btn.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
                    }


                    if (btn.Text == "Save" || btn.Tag == "Save")
                    {
                        btn.Image = System.Drawing.Image.FromFile(Environment.CurrentDirectory + "//save.ico");
                        btn.ImageLocation = ImageLocation.MiddleLeft;
                        btn.ToolTip = ToolTipSave;
                        btn.ToolTipTitle = ToolTipTitleSave;
                        btn.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;

                    }


                    else if (btn.Text == "Print" || btn.Tag == "Print")
                    {
                    
                        //btn.Image = System.Drawing.Image.FromFile(Environment.CurrentDirectory + "//print.ico");
                        //btn.ImageLocation = ImageLocation.MiddleLeft;
                        //btn.ToolTip = ToolTipPrint;
                        //btn.ToolTipTitle = ToolTipTitlePrint;
                        //btn.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;

                    }


                    else if (btn.Text == "Refresh" || btn.Tag == "Refresh")
                    {
                        btn.Image = System.Drawing.Image.FromFile(Environment.CurrentDirectory + "//refresh.ico");
                        btn.ImageLocation = ImageLocation.MiddleLeft;
                        btn.ToolTip = ToolTipRefresh;
                        btn.ToolTipTitle = ToolTipTitleRefresh;
                        btn.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;

                    }


                    else if (btn.Text == "Delete" || btn.Tag == "Delete")
                    {
                        btn.Image = System.Drawing.Image.FromFile(Environment.CurrentDirectory + "//delete.ico");
                        btn.ImageLocation = ImageLocation.MiddleLeft;
                        btn.ToolTip = ToolTipDelete;
                        btn.ToolTipTitle = ToolTipTitleDelete;
                        btn.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
                    }

                    else if (btn.Text == "Update" || btn.Tag == "Update")
                    {
                        btn.Image = System.Drawing.Image.FromFile(Environment.CurrentDirectory + "//update.ico");
                        btn.ImageLocation = ImageLocation.MiddleLeft;
                        btn.ToolTip = ToolTipUpdate;
                        btn.ToolTipTitle = ToolTipTitleUpdate;
                        btn.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
                    }

                    else if (btn.Text == "List" || btn.Tag == "List")
                    {
                        btn.Image = System.Drawing.Image.FromFile(Environment.CurrentDirectory + "//list.ico");
                        btn.ImageLocation = ImageLocation.MiddleCenter;
                        btn.Size = new System.Drawing.Size(40, 22);
                        //btn.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                        btn.ToolTip = ToolTipList;
                        btn.ToolTipTitle = ToolTipTitleList;
                        btn.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
                    }

                    else if (btn.Text == "Exit" || btn.Tag == "Exit")
                    {
                        btn.Image = System.Drawing.Image.FromFile(Environment.CurrentDirectory + "//exit.ico");
                        btn.ImageLocation = ImageLocation.MiddleLeft;
                        btn.ToolTip = ToolTipExit;
                        btn.ToolTipTitle = ToolTipTitleExit;
                        btn.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;

                    }

                    else if (btn.Text == "Preview" || btn.Tag == "Preview")
                    {
                        btn.Image = System.Drawing.Image.FromFile(Environment.CurrentDirectory + "//preview.ico");
                        btn.ImageLocation = ImageLocation.MiddleLeft;
                        btn.ToolTip = ToolTipPreview;
                        btn.ToolTipTitle = ToolTipTitlePreview;
                        btn.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;

                    }

                    else if (btn.Text == "Export" || btn.Tag == "Export")
                    {
                        btn.Image = System.Drawing.Image.FromFile(Environment.CurrentDirectory + "//export.ico");
                        btn.ImageLocation = ImageLocation.MiddleLeft;
                        btn.ToolTip = ToolTipExport;
                        btn.ToolTipTitle = ToolTipTitleExport;
                        btn.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;

                    }


                    else if (btn.Text == "Add Child" || btn.Tag == "Child")
                    {
                        btn.Image = System.Drawing.Image.FromFile(Environment.CurrentDirectory + "//child.ico");
                        btn.ImageLocation = ImageLocation.MiddleLeft;
                        btn.ToolTip = ToolTipChild;
                        btn.ToolTipTitle = ToolTipTitleChild;
                        btn.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;

                    }


                    else if (btn.Text == "Add Sibling" || btn.Tag == "Sibling")
                    {
                        btn.Image = System.Drawing.Image.FromFile(Environment.CurrentDirectory + "//sibling.ico");
                        btn.ImageLocation = ImageLocation.MiddleLeft;
                        btn.ToolTip = ToolTipSibling;
                        btn.ToolTipTitle = ToolTipTitleSibling;
                        btn.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;

                    }


                    else if (btn.Text == "Load" || btn.Tag == "Load")
                    {

                        btn.Image = System.Drawing.Image.FromFile(Environment.CurrentDirectory + "//sibling.ico");
                        btn.ImageLocation = ImageLocation.MiddleLeft;
                        btn.ToolTip = ToolTipLoad;
                        btn.ToolTipTitle = ToolTipTitleLoad;
                        btn.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;

                    }

                    Listbtn.Add(btn);


                }
                catch
                {


                }

            }




            GetAllControls(Clst);



            //get All LookUpEdit
            var Clst1 = from controls in AllControlsList.OfType<GridLookUpEdit>()
                        select controls;
            foreach (GridLookUpEdit C in Clst1)
            {

                C.EditValueChanged += new EventHandler(EditValueChanged);

            }


        }


        #endregion



        #region Recursive Function To Get All controls


        void GetAllControls(IEnumerable<Control> Clst)
        {



            try
            {


                foreach (Control ctrl in Clst)
                {


                    AllControlsList.Add(ctrl);



                    var Child = from controls in ctrl.Controls.OfType<Control>()
                                select controls;
                    if (!Object.ReferenceEquals(Child, null))
                    {

                        if (Child.Count() > 0)
                        {
                            GetAllControls(Child);
                        }

                    }

                }





            }
            catch
            {


            }

        }
        #endregion



        #region Events Here

        private void EditValueChanged(object sender, EventArgs e)
        {



            if (Refreshed)
            {
                GridLookUpEdit btn = (GridLookUpEdit)sender;
                if (btn.Properties.DataSource != null && btn.Properties.Editable == true)
                {
                    btn.EditValue = btn.Properties.GetKeyValue(0);

                }
            }



        }

        #endregion



        #region FocusValidateFunction CAlling

        public void ApplyFocusValidate(Control c)
        {


            try
            {
                objFrt.ApplyFocusValidate(c);


            }
            catch
            {

                throw;
            }


        }

        #endregion

        #region FormatFunction CAlling

        public void Formatting()
        {


            try
            {
                objFrt.applyFormatAndAppearance(XtraForm, AllControlsList);


            }
            catch
            {

                throw;
            }


        }

        #endregion

        #region ApperanceFunction CAlling

        public void Appreance()
        {


            try
            {
                objApp.ApplyApperance(XtraForm, AllControlsList);


            }
            catch
            {

                throw;
            }


        }
        #endregion
        #region ShortcutFunction CAlling
        public void ShortKey(KeyEventArgs e)
        {

            try
            {


                objShk.ApplyShortCut(e, Listbtn, AllControlsList);

            }
            catch (Exception ex)
            {


            }


        }
        #endregion
        #region RefreshFunction CAlling
        public void GenRefresh()
        {




            try
            {

                Refreshed = true;
                objRef.DoRefresh(XtraForm, AllControlsList);
                Refreshed = false;


            }
            catch (Exception ex)
            {


            }



        }

        #endregion




    }



}


#endregion



#region NameSapve GRidViewSub.  Contain  Apperance / Shorcut/Formating


namespace Gen_FormSub
{






    #region formating Class

    public class Gen_Formatting
    {

        String D1 = "yyyy/MM/dd";
        String D2 = "yyyy/dd/MM";
        String D3 = "dd/MM/yyyy";
        String D4 = "MM/dd/yyyy";
        String D5 = "yyyy/MM/dd HH:mm:ss";
        String N1 = "n1";
        String N2 = "n2";
        String N3 = "n3";
        String N4 = "n4";





        bool ContainType(Type Tp, List<Control> List)
        {



            foreach (Control c in List)
            {

                if (Tp == c.GetType())
                {
                    return true;

                }
            }

            return false;

        }

        public void ApplyFocusValidate(Control _Control)
        {

            try
            {

                try
                {





                    if (typeof(TextEdit) == _Control.GetType())
                    {
                        TextEdit _ControlTextBox = (TextEdit)_Control;

                        if (_ControlTextBox.Text == String.Empty)
                        {
                            _ControlTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
                            _ControlTextBox.Properties.Appearance.BorderColor = Color.Red;
                        }
                        else
                        {
                            _ControlTextBox.Properties.Appearance.BorderColor = Color.Transparent;
                        }
                    }


                    else if (typeof(MemoEdit) == _Control.GetType())
                    {
                        MemoEdit _ControlTextBox = (MemoEdit)_Control;

                        if (_ControlTextBox.Text == String.Empty)
                        {
                            _ControlTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
                            _ControlTextBox.Properties.Appearance.BorderColor = Color.Red;
                        }
                        else
                        {
                            _ControlTextBox.Properties.Appearance.BorderColor = Color.Transparent;
                        }
                    }


                    else if (typeof(ComboBoxEdit) == _Control.GetType())
                    {
                        ComboBoxEdit _ControlComboBox = (ComboBoxEdit)_Control;

                        if (_ControlComboBox.Text == String.Empty)
                        {
                            _ControlComboBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
                            _ControlComboBox.Properties.Appearance.BorderColor = Color.Red;
                        }
                        else
                        {
                            _ControlComboBox.Properties.Appearance.BorderColor = Color.Transparent;
                        }
                    }


                    else if (typeof(GridLookUpEdit) == _Control.GetType())
                    {
                        GridLookUpEdit _Controllookupedit = (GridLookUpEdit)_Control;

                        if (_Controllookupedit.EditValue == null)
                        {
                            _Controllookupedit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
                            _Controllookupedit.Properties.Appearance.BorderColor = Color.Red;
                        }
                        else
                        {
                            _Controllookupedit.Properties.Appearance.BorderColor = Color.Transparent;
                        }
                    }



                }
                catch
                {


                }

            }
            catch
            {


            }


        }

        void _ControlValidated(object sender, EventArgs e)
        {
            ApplyFocusValidate((Control)sender);
        }


        public void DoFormatting(XtraForm frm, List<Control> List)
        {



            //Text
            if (ContainType(typeof(TextEdit), List))
            {

                var Clst1 = from controls in List.OfType<TextEdit>()
                            select controls;

                foreach (TextEdit C in Clst1)
                {

                    if (C.EditorTypeName == "TextEdit")
                    {


                        string tmpTag = C.Tag.ToString();
                        string[] tmpTagArray = tmpTag.Split('_');

                        if (tmpTagArray[0] != "N")
                        {
                            C.BorderStyle = BorderStyles.HotFlat;

                            if (C.Tag != null && C.Tag.ToString() != "ZZZ")
                            {

                                C.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                                C.Properties.Mask.UseMaskAsDisplayFormat = true;
                            }



                            if (C.Tag == "D")
                            {


                                C.Properties.Mask.EditMask = "d";

                            }

                            if (C.Tag == "N1")
                            {

                                C.Properties.Mask.EditMask = "n1";
                            }

                            else if (C.Tag == "N2")
                            {
                                C.Properties.Mask.EditMask = "n2";
                            }


                            else if (C.Tag == "N3")
                            {
                                C.Properties.Mask.EditMask = "n3";
                            }

                            else if (C.Tag == "N4")
                            {
                                C.Properties.Mask.EditMask = "n4";

                            }
                            else if (C.Tag == "N5")
                            {
                                C.Properties.Mask.EditMask = "n5";
                            }
                        }
                    }
                }

            }





            //Spinedit
            if (ContainType(typeof(SpinEdit), List))
            {



                var Clst1 = from controls in List.OfType<SpinEdit>()
                            select controls;

                foreach (SpinEdit C in Clst1)
                {
                    if (C.EditorTypeName == "SpinEdit")
                    {

                        if (C.Tag != null && C.Tag.ToString() != "ZZZ")
                        {


                            C.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                            C.Properties.Mask.UseMaskAsDisplayFormat = true;
                        }
                        if (C.Tag == "N1")
                        {
                            C.Properties.Mask.EditMask = "n1";
                        }

                        else if (C.Tag == "N2")
                        {
                            C.Properties.Mask.EditMask = "n2";
                        }


                        else if (C.Tag == "N3")
                        {
                            C.Properties.Mask.EditMask = "n3";
                        }

                        else if (C.Tag == "N4")
                        {
                            C.Properties.Mask.EditMask = "n4";

                        }
                        else if (C.Tag == "N5")
                        {
                            C.Properties.Mask.EditMask = "n5";
                        }

                    }
                }

            }




            //  Date
            if (ContainType(typeof(DateEdit), List))
            {



                var Clst1 = from controls in List.OfType<DateEdit>()
                            select controls;

                foreach (DateEdit C in Clst1)
                {
                    if (C.EditorTypeName == "DateEdit")
                    {

                        if (C.Tag != null && C.Tag.ToString() != "ZZZ")
                        {
                            C.DateTime = DateTime.Now;
                            C.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
                            C.Properties.Mask.UseMaskAsDisplayFormat = true;

                        }



                        if (C.Tag == "D1")
                        {
                            C.Properties.Mask.EditMask = D1;
                        }

                        else if (C.Tag == "D2")
                        {
                            C.Properties.Mask.EditMask = D2;
                        }


                        else if (C.Tag == "D3")
                        {
                            C.Properties.EditMask = D3;
                        }

                        else if (C.Tag == "D4")
                        {
                            C.Properties.EditMask = D4;

                        }
                        else if (C.Tag == "D5")
                        {
                            C.Properties.EditMask = D5;
                        }

                    }
                }
            }




        }
        public void applyFormatAndAppearance(XtraForm frm, List<Control> List)
        {



            //Text
            if (ContainType(typeof(TextEdit), List))
            {

                var Clst1 = from controls in List.OfType<TextEdit>()
                            select controls;

                foreach (TextEdit C in Clst1)
                {

                    if (C.EditorTypeName == "TextEdit")
                    {


                        string tmpTag = C.Tag.ToString();
                        string[] tmpTagArray = tmpTag.Split('_');


                        //if (tmpTagArray.Length > 2)
                        //{
                        //    if (tmpTagArray[2] != "N")
                        //    {

                        //        C.Validated += new EventHandler(_ControlValidated);

                        //    }
                        //}

                        if (tmpTagArray[1] != "N")
                        {
                            C.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                            C.Properties.AppearanceFocused.Options.UseBorderColor = true;
                            C.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
                            C.Font = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                        }

                        if (tmpTagArray[0] != "N")
                        {


                            C.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                            C.Properties.Mask.UseMaskAsDisplayFormat = true;




                            if (tmpTagArray[0] == "D")
                            {

                                C.Properties.Mask.EditMask = "d";

                            }

                            else if (tmpTagArray[0] == "N1")
                            {

                                C.Properties.Mask.EditMask = N1;
                            }

                            else if (tmpTagArray[0] == "N2")
                            {
                                C.Properties.Mask.EditMask = N2;
                            }


                            else if (tmpTagArray[0] == "N3")
                            {
                                C.Properties.Mask.EditMask = N3;
                            }

                            else if (tmpTagArray[0] == "N4")
                            {
                                C.Properties.Mask.EditMask = N4;

                            }

                        }
                    }
                }

            }






            //SpinEdit
            if (ContainType(typeof(SpinEdit), List))
            {

                var Clst1 = from controls in List.OfType<SpinEdit>()
                            select controls;

                foreach (SpinEdit C in Clst1)
                {

                    if (C.EditorTypeName == "SpinEdit")
                    {


                        string tmpTag = C.Tag.ToString();
                        string[] tmpTagArray = tmpTag.Split('_');



                        //if (tmpTagArray.Length > 2)
                        //{
                        //    if (tmpTagArray[2] != "N")
                        //    {

                        //        C.Validated += new EventHandler(_ControlValidated);

                        //    }
                        //}

                        if (tmpTagArray[1] != "N")
                        {
                            C.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                            C.Properties.AppearanceFocused.Options.UseBorderColor = true;
                            C.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
                            C.Font = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                        }

                        if (tmpTagArray[0] != "N")
                        {


                            C.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                            C.Properties.Mask.UseMaskAsDisplayFormat = true;




                            if (tmpTagArray[0] == "D")
                            {

                                C.Properties.Mask.EditMask = "d";

                            }

                            else if (tmpTagArray[0] == "N1")
                            {

                                C.Properties.Mask.EditMask = N1;
                            }

                            else if (tmpTagArray[0] == "N2")
                            {
                                C.Properties.Mask.EditMask = N2;
                            }


                            else if (tmpTagArray[0] == "N3")
                            {
                                C.Properties.Mask.EditMask = N3;
                            }

                            else if (tmpTagArray[0] == "N4")
                            {
                                C.Properties.Mask.EditMask = N4;

                            }

                        }
                    }
                }

            }



            //DateEdit
            if (ContainType(typeof(DateEdit), List))
            {

                var Clst1 = from controls in List.OfType<DateEdit>()
                            select controls;

                foreach (DateEdit C in Clst1)
                {

                    if (C.EditorTypeName == "DateEdit")
                    {


                        string tmpTag = C.Tag.ToString();
                        string[] tmpTagArray = tmpTag.Split('_');




                        //if (tmpTagArray.Length > 2)
                        //{
                        //    if (tmpTagArray[2] != "N")
                        //    {

                        //        C.Validated += new EventHandler(_ControlValidated);

                        //    }
                        //}

                        if (tmpTagArray[1] != "N")
                        {
                            C.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                            C.Properties.AppearanceFocused.Options.UseBorderColor = true;
                            C.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
                            C.Font = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                        }

                        if (tmpTagArray[0] != "N")
                        {


                            C.DateTime = DateTime.Now;
                            C.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
                            C.Properties.Mask.UseMaskAsDisplayFormat = true;




                            if (C.Tag == "D1")
                            {
                                C.Properties.Mask.EditMask = D1;
                            }

                            else if (C.Tag == "D2")
                            {
                                C.Properties.Mask.EditMask = D2;
                            }


                            else if (C.Tag == "D3")
                            {
                                C.Properties.EditMask = D3;
                            }

                            else if (C.Tag == "D4")
                            {
                                C.Properties.EditMask = D4;

                            }
                            else if (C.Tag == "D5")
                            {
                                C.Properties.EditMask = D5;
                            }
                        }
                    }

                }





            }











            //MemoEdit
            if (ContainType(typeof(MemoEdit), List))
            {

                var Clst1 = from controls in List.OfType<MemoEdit>()
                            select controls;

                foreach (MemoEdit C in Clst1)
                {

                    if (C.EditorTypeName == "MemoEdit")
                    {


                        string tmpTag = C.Tag.ToString();
                        string[] tmpTagArray = tmpTag.Split('_');




                        //if (tmpTagArray.Length > 2)
                        //{
                        //    if (tmpTagArray[2] != "N")
                        //    {

                        //        C.Validated += new EventHandler(_ControlValidated);

                        //    }
                        //}

                        if (tmpTagArray[1] != "N")
                        {
                            C.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                            C.Properties.AppearanceFocused.Options.UseBorderColor = true;
                            C.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
                            C.Font = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                        }

                        if (tmpTagArray[0] != "N")
                        {


                            C.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                            C.Properties.Mask.UseMaskAsDisplayFormat = true;




                            if (tmpTagArray[0] == "D")
                            {

                                C.Properties.Mask.EditMask = "d";

                            }

                            else if (tmpTagArray[0] == "N1")
                            {

                                C.Properties.Mask.EditMask = N1;
                            }

                            else if (tmpTagArray[0] == "N2")
                            {
                                C.Properties.Mask.EditMask = N2;
                            }


                            else if (tmpTagArray[0] == "N3")
                            {
                                C.Properties.Mask.EditMask = N3;
                            }

                            else if (tmpTagArray[0] == "N4")
                            {
                                C.Properties.Mask.EditMask = N4;

                            }

                        }
                    }
                }

            }


            //ComboBoxEdit
            if (ContainType(typeof(ComboBoxEdit), List))
            {

                var Clst1 = from controls in List.OfType<ComboBoxEdit>()
                            select controls;

                foreach (ComboBoxEdit C in Clst1)
                {

                    if (C.EditorTypeName == "ComboBoxEdit")
                    {


                        string tmpTag = C.Tag.ToString();
                        string[] tmpTagArray = tmpTag.Split('_');





                        //if (tmpTagArray.Length > 2)
                        //{
                        //    if (tmpTagArray[2] != "N")
                        //    {

                        //        C.Validated += new EventHandler(_ControlValidated);

                        //    }
                        //}


                        if (tmpTagArray[1] != "N")
                        {
                            C.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                            C.Properties.AppearanceFocused.Options.UseBorderColor = true;
                            C.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
                            C.Font = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                        }

                        if (tmpTagArray[0] != "N")
                        {


                            C.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                            C.Properties.Mask.UseMaskAsDisplayFormat = true;




                            if (tmpTagArray[0] == "D")
                            {

                                C.Properties.Mask.EditMask = "d";

                            }

                            else if (tmpTagArray[0] == "N1")
                            {

                                C.Properties.Mask.EditMask = N1;
                            }

                            else if (tmpTagArray[0] == "N2")
                            {
                                C.Properties.Mask.EditMask = N2;
                            }


                            else if (tmpTagArray[0] == "N3")
                            {
                                C.Properties.Mask.EditMask = N3;
                            }

                            else if (tmpTagArray[0] == "N4")
                            {
                                C.Properties.Mask.EditMask = N4;

                            }

                        }
                    }
                }

            }

            //GridLookUpEdit
            if (ContainType(typeof(GridLookUpEdit), List))
            {

                var Clst1 = from controls in List.OfType<GridLookUpEdit>()
                            select controls;

                foreach (GridLookUpEdit C in Clst1)
                {

                    if (C.EditorTypeName == "GridLookUpEdit")
                    {


                        string tmpTag = C.Tag.ToString();
                        string[] tmpTagArray = tmpTag.Split('_');


                        //if (tmpTagArray.Length > 2)
                        //{
                        //    if (tmpTagArray[2] != "N")
                        //    {

                        //        C.Validated += new EventHandler(_ControlValidated);

                        //    }
                        //}

                        if (tmpTagArray[1] != "N")
                        {
                            C.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                            C.Properties.AppearanceFocused.Options.UseBorderColor = true;
                            C.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
                            C.Font = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                        }

                        if (tmpTagArray[0] != "N")
                        {


                            C.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                            C.Properties.Mask.UseMaskAsDisplayFormat = true;




                            if (tmpTagArray[0] == "D")
                            {

                                C.Properties.Mask.EditMask = "d";

                            }

                            else if (tmpTagArray[0] == "N1")
                            {

                                C.Properties.Mask.EditMask = N1;
                            }

                            else if (tmpTagArray[0] == "N2")
                            {
                                C.Properties.Mask.EditMask = N2;
                            }


                            else if (tmpTagArray[0] == "N3")
                            {
                                C.Properties.Mask.EditMask = N3;
                            }

                            else if (tmpTagArray[0] == "N4")
                            {
                                C.Properties.Mask.EditMask = N4;

                            }

                        }
                    }
                }

            }





            //RadioButton
            if (ContainType(typeof(RadioButton), List))
            {

                var Clst1 = from controls in List.OfType<RadioButton>()
                            select controls;

                foreach (RadioButton C in Clst1)
                {



                    string tmpTag = C.Tag.ToString();
                    string[] tmpTagArray = tmpTag.Split('_');



                    if (tmpTagArray[0] != "N")
                    {

                        C.Font = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    }




                }

            }



            //CheckEdit
            if (ContainType(typeof(CheckEdit), List))
            {

                var Clst1 = from controls in List.OfType<CheckEdit>()
                            select controls;

                foreach (CheckEdit C in Clst1)
                {



                    string tmpTag = C.Tag.ToString();
                    string[] tmpTagArray = tmpTag.Split('_');



                    if (tmpTagArray[0] != "N")
                    {

                        C.Font = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    }




                }

            }



            //LabelControl
            //if (ContainType(typeof(LabelControl), List))
            //{

            //    var Clst1 = from controls in List.OfType<LabelControl>()
            //                select controls;

            //    foreach (LabelControl C in Clst1)
            //    {



            //        //string tmpTag = C.Tag.ToString();
            //        //string[] tmpTagArray = tmpTag.Split('_');



            //        //if (tmpTagArray[0] != "N")
            //        //{

            //            C.Font = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            //        //}




            //    }

            //}

        }
    }
    #endregion


    #region Apprennce Class
    public class Gen_Apperance
    {



        bool ContainType(Type Tp, List<Control> List)
        {



            foreach (Control c in List)
            {

                if (Tp == c.GetType())
                {
                    return true;

                }
            }

            return false;

        }



        public void ApplyApperance(XtraForm frm, List<Control> List)
        {

            try
            {



                //Gridlook
                if (ContainType(typeof(GridLookUpEdit), List))
                {



                    var Clst1 = from controls in List.OfType<GridLookUpEdit>()
                                select controls;
                    foreach (GridLookUpEdit C in Clst1)
                    {

                        C.Font = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


                    }


                }




                //radio
                if (ContainType(typeof(RadioGroup), List))
                {
                    //
                    var Clst = from controls in List.OfType<RadioGroup>()
                               select controls;
                    foreach (RadioGroup C in Clst)
                    {

                        C.Font = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


                    }
                }


                //TCombo
                if (ContainType(typeof(ComboBoxEdit), List))
                {
                    //
                    var Clst = from controls in List.OfType<ComboBoxEdit>()
                               select controls;
                    foreach (ComboBoxEdit C in Clst)
                    {

                        C.Font = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


                    }
                }










                //Spin
                if (ContainType(typeof(LabelControl), List))
                {
                    //
                    var Clst = from controls in List.OfType<LabelControl>()
                               select controls;
                    foreach (LabelControl C in Clst)
                    {

                        C.Font = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    }
                }

                //Spin
                if (ContainType(typeof(SpinEdit), List))
                {
                    //
                    var Clst = from controls in List.OfType<SpinEdit>()
                               select controls;
                    foreach (SpinEdit C in Clst)
                    {

                        C.Font = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    }
                }


                //Date
                if (ContainType(typeof(DateEdit), List))
                {
                    //
                    var Clst = from controls in List.OfType<DateEdit>()
                               select controls;
                    foreach (DateEdit C in Clst)
                    {

                        C.Font = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


                    }
                }

                //Memo
                if (ContainType(typeof(MemoEdit), List))
                {
                    //
                    var Clst = from controls in List.OfType<MemoEdit>()
                               select controls;
                    foreach (MemoEdit C in Clst)
                    {

                        C.Font = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


                    }
                }


                //Text
                if (ContainType(typeof(TextEdit), List))
                {
                    //
                    var Clst = from controls in List.OfType<TextEdit>()
                               select controls;
                    foreach (TextEdit C in Clst)
                    {
                        if (C.EditorTypeName == "TextEdit")
                        {
                            C.Font = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        }

                    }
                }



            }
            catch (Exception)
            {

                throw;
            }

        }

    }

    #endregion



    #region Shortcut Class

    public class Gen_ShortKey
    {

        int index = 0;
        SimpleButton btn = new SimpleButton();

        bool ContainType(Type Tp, List<Control> List)
        {



            foreach (Control c in List)
            {

                if (Tp == c.GetType())
                {
                    return true;

                }
            }

            return false;

        }

        public void ApplyShortCut(KeyEventArgs e, List<SimpleButton> lst, List<Control> AllControl)
        {




            if (e.Control && e.KeyCode == Keys.S)
            {

                index = lst.FindIndex(p => p.Text == "Save" || p.Tag == "Save");
                btn = lst[index];
                btn.PerformClick();


            }

            else if (e.Control && e.KeyCode == Keys.D)
            {

                index = lst.FindIndex(p => p.Text == "Delete" || p.Tag == "Delete");
                btn = lst[index];
                btn.PerformClick();


            }


            else if (e.KeyCode == Keys.F5)
            {

                index = lst.FindIndex(p => p.Text == "Refresh_A" || p.Tag == "Refresh_A");
                btn = lst[index];
                btn.Visible = true;
                btn.PerformClick();
                btn.Visible = false;

            }

            else if (e.Control && e.KeyCode == Keys.R)
            {


                index = lst.FindIndex(p => p.Text == "Refresh" || p.Tag == "Refresh");
                btn = lst[index];
                btn.PerformClick();


            }


            else if (e.Control && e.KeyCode == Keys.P)
            {

                index = lst.FindIndex(p => p.Text == "Print" || p.Tag == "Print");
                btn = lst[index];
                btn.PerformClick();


            }

            else if (e.Control && e.KeyCode == Keys.E)
            {

                index = lst.FindIndex(p => p.Text == "Exit" || p.Tag == "Exit");
                btn = lst[index];
                btn.PerformClick();


            }

            else if (e.Control && e.KeyCode == Keys.L)
            {

                index = lst.FindIndex(p => p.Text == "List" || p.Tag == "List");
                btn = lst[index];
                btn.PerformClick();


            }


            else if (e.Control && e.KeyCode == Keys.U)
            {

                index = lst.FindIndex(p => p.Text == "Update");
                btn = lst[index];
                btn.PerformClick();


            }







            else if (e.Control && e.KeyCode == Keys.Right)
            {
                //datanavigator
                if (ContainType(typeof(DataNavigator), AllControl))
                {

                    var Clst1 = from controls in AllControl.OfType<DataNavigator>()
                                select controls;
                    foreach (DataNavigator C in Clst1)
                    {


                        if (C.Enabled == true)
                        {

                            if (C.Position == C.Buttons.CurrencyManager.Count - 1)
                            {
                                C.Buttons.DoClick(C.Buttons.First);
                            }
                            else
                            {
                                C.Buttons.DoClick(C.Buttons.Last);
                            }

                        }



                    }



                }


            }

            else if (e.KeyCode == Keys.Right)
            {
                //datanavigator
                if (ContainType(typeof(DataNavigator), AllControl))
                {

                    var Clst1 = from controls in AllControl.OfType<DataNavigator>()
                                select controls;
                    foreach (DataNavigator C in Clst1)
                    {

                        if (C.Enabled == true)
                        {
                            if (C.Position == C.Buttons.CurrencyManager.Count - 1)
                            {
                                C.Buttons.DoClick(C.Buttons.First);
                            }
                            else
                            {
                                C.Buttons.DoClick(C.Buttons.Next);
                            }

                        }



                    }



                }


            }



            else if (e.Control && e.KeyCode == Keys.Left)
            {
                //datanavigator
                if (ContainType(typeof(DataNavigator), AllControl))
                {

                    var Clst1 = from controls in AllControl.OfType<DataNavigator>()
                                select controls;
                    foreach (DataNavigator C in Clst1)
                    {

                        if (C.Enabled == true)
                        {

                            if (C.Position == 0)
                            {
                                C.Buttons.DoClick(C.Buttons.Last);
                            }
                            else
                            {
                                C.Buttons.DoClick(C.Buttons.First);
                            }
                        }


                    }



                }


            }


            else if (e.KeyCode == Keys.Left)
            {
                //datanavigator
                if (ContainType(typeof(DataNavigator), AllControl))
                {

                    var Clst1 = from controls in AllControl.OfType<DataNavigator>()
                                select controls;
                    foreach (DataNavigator C in Clst1)
                    {

                        if (C.Enabled == true)
                        {
                            if (C.Position == 0)
                            {
                                C.Buttons.DoClick(C.Buttons.Last);
                            }
                            else
                            {
                                C.Buttons.DoClick(C.Buttons.Prev);
                            }

                        }



                    }



                }


            }


        }
    }
    #endregion
    #region Refresh Class
    public class Gen_Refresh
    {





        bool ContainType(Type Tp, List<Control> List)
        {



            foreach (Control c in List)
            {

                if (Tp == c.GetType())
                {
                    return true;

                }
            }

            return false;

        }









        public void DoRefresh(XtraForm frm, List<Control> List)
        {



            //Gridlook
            if (ContainType(typeof(GridLookUpEdit), List))
            {



                var Clst1 = from controls in List.OfType<GridLookUpEdit>()
                            select controls;
                foreach (GridLookUpEdit C in Clst1)
                {

                    if (C.Properties.DataSource != null && C.Properties.Editable == true)
                    {
                        C.EditValue = C.Properties.GetKeyValue(0);
                    }



                }








            }







            //radio
            if (ContainType(typeof(RadioGroup), List))
            {
                //
                var Clst = from controls in List.OfType<RadioGroup>()
                           select controls;
                foreach (RadioGroup C in Clst)
                {

                    C.SelectedIndex = 0;


                }
            }




            //TCombo
            if (ContainType(typeof(ComboBoxEdit), List))
            {
                //
                var Clst = from controls in List.OfType<ComboBoxEdit>()
                           select controls;
                foreach (ComboBoxEdit C in Clst)
                {

                    C.SelectedIndex = 0;


                }
            }



            //Check
            if (ContainType(typeof(CheckEdit), List))
            {
                //
                var Clst = from controls in List.OfType<CheckEdit>()
                           select controls;
                foreach (CheckEdit C in Clst)
                {
                    if (C.Tag != "N_N")
                    {
                        if (C.Tag == "T")
                            C.Checked = true;
                        else if (C.Tag == "F")
                            C.Checked = false;
                    }


                }
            }



            //Spin
            if (ContainType(typeof(SpinEdit), List))
            {
                //
                var Clst = from controls in List.OfType<SpinEdit>()
                           select controls;
                foreach (SpinEdit C in Clst)
                {

                    C.Value = 0;


                }
            }


            //Date
            if (ContainType(typeof(DateEdit), List))
            {
                //
                var Clst = from controls in List.OfType<DateEdit>()
                           select controls;
                foreach (DateEdit C in Clst)
                {

                    C.EditValue = DateTime.Now;


                }
            }

            //Memo
            if (ContainType(typeof(MemoEdit), List))
            {
                //
                var Clst = from controls in List.OfType<MemoEdit>()
                           select controls;
                foreach (MemoEdit C in Clst)
                {

                    C.Text = String.Empty;


                }
            }


            //Text
            if (ContainType(typeof(TextEdit), List))
            {
                //
                var Clst = from controls in List.OfType<TextEdit>()
                           select controls;
                foreach (TextEdit C in Clst)
                {
                    if (C.EditorTypeName == "TextEdit")
                    {
                        C.EditValue = String.Empty;
                    }

                }
            }



            //PictureEdit
            if (ContainType(typeof(PictureEdit), List))
            {
                //
                var Clst = from controls in List.OfType<PictureEdit>()
                           select controls;
                foreach (PictureEdit C in Clst)
                {
                    if (C.EditorTypeName == "PictureEdit")
                    {
                        C.Image = null;
                    }

                }
            }



        }

    }


    #endregion

}

#endregion
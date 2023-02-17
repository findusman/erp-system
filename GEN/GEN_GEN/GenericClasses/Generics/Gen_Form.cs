using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using Gen_FormSub;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraEditors.Controls;










#region MAin Namespace Use For Calling
namespace GEN
{


    public class Gen_Form : IDisposable
    {


        #region AllObjects variables


        bool Refreshed;
        XtraForm XtraForm;
        List<SimpleButton> Listbtn = new List<SimpleButton>();
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

                    if (btn.Text == "Refresh_A")
                    {
                        btn.Size = new System.Drawing.Size(5, 5);
                        btn.Visible = false;
                    }

             
              if (btn.Text == "Save")
              {
                  btn.Image = System.Drawing.Image.FromFile(Environment.CurrentDirectory + "//save.ico");
                  btn.ImageLocation = ImageLocation.MiddleLeft;

              }


              else if (btn.Text == "Print")
              {
                  btn.Image = System.Drawing.Image.FromFile(Environment.CurrentDirectory + "//print.ico");
                  btn.ImageLocation = ImageLocation.MiddleLeft;
              }


              else if (btn.Text == "Refresh")
              {
                  btn.Image = System.Drawing.Image.FromFile(Environment.CurrentDirectory + "//refresh.ico");
                  btn.ImageLocation = ImageLocation.MiddleLeft;
                 
              }


              else if (btn.Text == "Delete")
              {
                  btn.Image = System.Drawing.Image.FromFile(Environment.CurrentDirectory + "//delete.ico");
                  btn.ImageLocation = ImageLocation.MiddleLeft;
              }

              else if (btn.Text == "Update")
              {
                  btn.Image = System.Drawing.Image.FromFile(Environment.CurrentDirectory + "//update.ico");
                  btn.ImageLocation = ImageLocation.MiddleLeft;
              }

              else if (btn.Text == "...")
              {
                  btn.Image = System.Drawing.Image.FromFile(Environment.CurrentDirectory + "//list.ico");
                  btn.ImageLocation = ImageLocation.MiddleLeft;
                  btn.Size = new System.Drawing.Size(40, 22);
                  //btn.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
              }

              else if (btn.Text == "Exit")
              {
                  btn.Image = System.Drawing.Image.FromFile(Environment.CurrentDirectory + "//exit.ico");
                  btn.ImageLocation = ImageLocation.MiddleLeft;

              }

              else if (btn.Text == "Preview")
              {
                  btn.Image = System.Drawing.Image.FromFile(Environment.CurrentDirectory + "//preview.ico");
                  btn.ImageLocation = ImageLocation.MiddleLeft;

              }

              else if (btn.Text == "Export")
              {
                  btn.Image = System.Drawing.Image.FromFile(Environment.CurrentDirectory + "//export.ico");
                  btn.ImageLocation = ImageLocation.MiddleLeft;

              }


              else if (btn.Text == "Add Child")
              {
                  btn.Image = System.Drawing.Image.FromFile(Environment.CurrentDirectory + "//child.ico");
                  btn.ImageLocation = ImageLocation.MiddleLeft;

              }


              else if (btn.Text == "Add Sibling")
              {
                  btn.Image = System.Drawing.Image.FromFile(Environment.CurrentDirectory + "//sibling.ico");
                  btn.ImageLocation = ImageLocation.MiddleLeft;

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



        #region FormatFunction CAlling

        public void Formatting()
        {


            try
            {
                objFrt.DoFormatting(XtraForm, AllControlsList);
               
               
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

               
                    objShk.ApplyShortCut(e, Listbtn);
                
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





            //Spinedit
            if (ContainType(typeof(SpinEdit), List))
            {



                var Clst1 = from controls in List.OfType<SpinEdit>()
                            select controls;
              
                foreach (SpinEdit C in Clst1)
                {
                    if (C.Tag != null && C.Tag.ToString() != "ZZZ")
                    {
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


          //  Date
            if (ContainType(typeof(DateEdit), List))
            {



                var Clst1 = from controls in List.OfType<DateEdit>()
                            select controls;
                
                foreach (DateEdit C in Clst1)
                {
                    if (C.Tag != null && C.Tag.ToString() != "ZZZ")
                    {
                        C.DateTime = DateTime.Now;
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
                    var Clst = from controls in frm.Controls.OfType<RadioGroup>()
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
                    var Clst = from controls in frm.Controls.OfType<ComboBoxEdit>()
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
                    var Clst = from controls in frm.Controls.OfType<LabelControl>()
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
                    var Clst = from controls in frm.Controls.OfType<SpinEdit>()
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
                    var Clst = from controls in frm.Controls.OfType<DateEdit>()
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
                    var Clst = from controls in frm.Controls.OfType<MemoEdit>()
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
                    var Clst = from controls in frm.Controls.OfType<TextEdit>()
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

            public void ApplyShortCut(KeyEventArgs e, List<SimpleButton> lst)
            {




                if (e.Control && e.KeyCode == Keys.S)
                {

                    index = lst.FindIndex(p => p.Text == "Save");
                    btn = lst[index];
                    btn.PerformClick();


                }

                else if (e.Control && e.KeyCode == Keys.D)
                {

                    index = lst.FindIndex(p => p.Text == "Delete");
                    btn = lst[index];
                    btn.PerformClick();


                }


                else if (e.KeyCode == Keys.F5)
                {

                    index = lst.FindIndex(p => p.Text == "Refresh_A");
                    btn = lst[index];
                    btn.Visible = true;
                    btn.PerformClick();
                    btn.Visible = false;

                }

                else if (e.Control && e.KeyCode == Keys.R)
                {


                    index = lst.FindIndex(p => p.Text == "Refresh");
                    btn = lst[index];
                    btn.PerformClick();


                }


                else if (e.Control && e.KeyCode == Keys.P)
                {

                    index = lst.FindIndex(p => p.Text == "Print");
                    btn = lst[index];
                    btn.PerformClick();


                }

                else if (e.Control && e.KeyCode == Keys.E)
                {

                    index = lst.FindIndex(p => p.Text == "Exit");
                    btn = lst[index];
                    btn.PerformClick();


                }

                else if (e.Control && e.KeyCode == Keys.L)
                {

                    index = lst.FindIndex(p => p.Text == "List");
                    btn = lst[index];
                    btn.PerformClick();


                }


                else if (e.Control && e.KeyCode == Keys.U)
                {

                    index = lst.FindIndex(p => p.Text == "Update");
                    btn = lst[index];
                    btn.PerformClick();


                }

            }


        }
    #endregion
    #region Regresh Class
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
                    var Clst = from controls in frm.Controls.OfType<RadioGroup>()
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
                    var Clst = from controls in frm.Controls.OfType<ComboBoxEdit>()
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
                    var Clst = from controls in frm.Controls.OfType<CheckEdit>()
                               select controls;
                    foreach (CheckEdit C in Clst)
                    {

                        C.Checked = false;


                    }
                }



                //Spin
                if (ContainType(typeof(SpinEdit), List))
                {
                    //
                    var Clst = from controls in frm.Controls.OfType<SpinEdit>()
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
                    var Clst = from controls in frm.Controls.OfType<DateEdit>()
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
                    var Clst = from controls in frm.Controls.OfType<MemoEdit>()
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
                    var Clst = from controls in frm.Controls.OfType<TextEdit>()
                               select controls;
                    foreach (TextEdit C in Clst)
                    {
                        if (C.EditorTypeName == "TextEdit")
                        {
                            C.Text = String.Empty;
                        }

                    }
                }



                //PictureEdit
                if (ContainType(typeof(PictureEdit), List))
                {
                    //
                    var Clst = from controls in frm.Controls.OfType<PictureEdit>()
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
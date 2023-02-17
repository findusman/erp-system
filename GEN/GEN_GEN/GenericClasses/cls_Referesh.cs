using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace GEN.GEN_GEN.GenericClasses
{
  public  class cls_Referesh
    {


      public static string Refresh(XtraForm form)
      {

          foreach (Control controls in form.Controls)
          {
              //  if (controls is LookUpEdit)
              //{

              //    LookUpEdit lae = new LookUpEdit();
              //    lae = (LookUpEdit)controls;
              //    lae.EditValue = select_value;
              //}
              if (controls is ComboBoxEdit && controls.Tag != "N_C")
              {

                  ComboBoxEdit cm = new ComboBoxEdit();
                  cm = (ComboBoxEdit)controls;
                  cm.SelectedIndex = 0;
              }
              else if (controls is LookUpEdit && controls.Tag != "N_C")
              {
                  LookUpEdit cm = new LookUpEdit();
                  cm = (LookUpEdit)controls;
                  cm.ItemIndex = 0;

              }
              else if (controls is DateEdit && controls.Tag != "N_C")
              {

                  controls.Text = DateTime.Now.ToShortDateString();

              }



              else if (controls is TextEdit && controls.Tag != "N_C")
              {

                  controls.Text = "";

              }










              //if (controls is PanelControl )
              //{
              //    PanelControl obj_panel_control = new PanelControl();

              //    obj_panel_control = (PanelControl)controls;

              //    foreach (Control pn_controls in obj_panel_control.Controls)
              //    {

              //        if (pn_controls is ComboBoxEdit)
              //        {

              //            ComboBoxEdit cm = new ComboBoxEdit();
              //            cm = (ComboBoxEdit)pn_controls;
              //            cm.SelectedIndex = 0;
              //        }

              //        else if (pn_controls is LookUpEdit)
              //        {

              //            LookUpEdit lae = new LookUpEdit();
              //            lae = (LookUpEdit)pn_controls;
              //            lae.EditValue = select_value;
              //        }


              //        else if (pn_controls is TextEdit)
              //        {

              //            pn_controls.Text = "";

              //        }



              //        else if (pn_controls is DateEdit)
              //        {

              //            pn_controls.Text = DateTime.Now.ToShortDateString(); ;

              //        }




              //    }

              //}







              if (controls is GroupControl && controls.Tag != "N_C")
              {
                  GroupControl obj_group_control = new GroupControl();

                  obj_group_control = (GroupControl)controls;

                  foreach (Control gr_controls in obj_group_control.Controls)
                  {

                      if (gr_controls is PanelControl && gr_controls.Tag != "N_C")
                      {
                          PanelControl obj_panel_control = new PanelControl();

                          obj_panel_control = (PanelControl)gr_controls;

                          foreach (Control pn_controls in obj_panel_control.Controls)
                          {


                              //if (pn_controls is LookUpEdit)
                              //{

                              //    LookUpEdit lae = new LookUpEdit();
                              //    lae = (LookUpEdit)pn_controls;
                              //    lae.EditValue = select_value;
                              //}

                              if (pn_controls is ComboBoxEdit && pn_controls.Tag != "N_C")
                              {

                                  ComboBoxEdit cm = new ComboBoxEdit();
                                  cm = (ComboBoxEdit)pn_controls;
                                  cm.SelectedIndex = 0;
                              }
                              else if (pn_controls is LookUpEdit && pn_controls.Tag != "N_C")
                              {
                                  LookUpEdit lae = new LookUpEdit();
                                  lae = (LookUpEdit)pn_controls;
                                  lae.ItemIndex = 0;

                              }

                              else if (pn_controls is DateEdit && pn_controls.Tag != "N_C")
                              {

                                  pn_controls.Text = DateTime.Now.ToShortDateString();

                              }




                              else if (pn_controls is TextEdit && pn_controls.Tag != "N_C")
                              {

                                  pn_controls.Text = "";

                              }



                              else if (pn_controls is DateEdit && pn_controls.Tag != "N_C")
                              {

                                  pn_controls.Text = DateTime.Now.ToShortDateString();

                              }




                          }

                      }


                      //if (gr_controls is LookUpEdit)
                      //{

                      //    LookUpEdit lae = new LookUpEdit();
                      //    lae = (LookUpEdit)gr_controls;
                      //    lae.EditValue = select_value;
                      //}


                      else if (gr_controls is ComboBoxEdit && gr_controls.Tag != "N_C")
                      {

                          ComboBoxEdit cm = new ComboBoxEdit();
                          cm = (ComboBoxEdit)gr_controls;
                          cm.SelectedIndex = 0;
                      }
                      else if (gr_controls is LookUpEdit && gr_controls.Tag != "N_C")
                      {
                          LookUpEdit lae = new LookUpEdit();
                          lae = (LookUpEdit)gr_controls;
                          lae.ItemIndex = 0;

                      }

                      else if (gr_controls is DateEdit && gr_controls.Tag != "N_C")
                      {

                          gr_controls.Text = DateTime.Now.ToShortDateString();

                      }


                      else if (gr_controls is TextEdit && gr_controls.Tag != "N_C")
                      {

                          gr_controls.Text = "";

                      }

                  }

              }

          }


          return "";
      }


    }
}

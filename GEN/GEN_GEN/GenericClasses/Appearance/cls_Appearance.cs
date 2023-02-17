using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace GEN.GEN_GEN.GenericClasses.Appearance
{
      public class cls_Appearance
      {
            //Font("Tahoma", 9, FontStyle.Regular);

            static public Font GO_RepositoryGridLookUpHeaderAppearance_Fona = new Font("Tahoma", 9, FontStyle.Regular);
            static public void applyFocusAppreanceTextEdit(Control pControl)
            {


                  if (pControl.GetType() == typeof(TextEdit))
                  {
                        TextEdit textEdit = (TextEdit)pControl;
                        textEdit.Properties.Appearance.BorderColor = Color.Red;
                        textEdit.Focus();
                        textEdit.EditValueChanged += new System.EventHandler(TextEdit_EditValueChanged);
                        textEdit.Properties.AppearanceFocused.BorderColor = Color.Empty;
                  }
                  if (pControl.GetType() == typeof(GridLookUpEdit))
                  {
                        GridLookUpEdit gridLookUpEdit = (GridLookUpEdit)pControl;
                        gridLookUpEdit.Properties.Appearance.BorderColor = Color.Red;
                        gridLookUpEdit.Focus();
                        gridLookUpEdit.EditValueChanged += new System.EventHandler(TextEdit_EditValueChanged);
                        gridLookUpEdit.Properties.AppearanceFocused.BorderColor = Color.Empty;
                  }

            }

            static private void TextEdit_EditValueChanged(object sender, EventArgs e)
            {
                  if (sender.GetType() == typeof(GridLookUpEdit))
                  {
                        TextEdit textEdit = (TextEdit)sender;
                        if (textEdit.Text != "")
                        {

                              textEdit.Properties.Appearance.BorderColor = Color.Empty;
                              textEdit.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));

                        }
                  }

                  if (sender.GetType() == typeof(GridLookUpEdit))
                  {
                        GridLookUpEdit textEdit = (GridLookUpEdit)sender;
                        if (textEdit.EditValue != null)
                        {

                              textEdit.Properties.Appearance.BorderColor = Color.Empty;
                              textEdit.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));

                        }
                  }
                 
            }
      }




}

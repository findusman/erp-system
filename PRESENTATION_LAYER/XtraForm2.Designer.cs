namespace PRESENTATION_LAYER
{
      partial class XtraForm2
      {
            /// <summary>
            /// Required designer variable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;

            /// <summary>
            /// Clean up any resources being used.
            /// </summary>
            /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            protected override void Dispose(bool disposing)
            {
                  if (disposing && (components != null))
                  {
                        components.Dispose();
                  }
                  base.Dispose(disposing);
            }

            #region Windows Form Designer generated code

            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
                  this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
                  this.SuspendLayout();
                  // 
                  // simpleButton1
                  // 
                  this.simpleButton1.Location = new System.Drawing.Point(13, 13);
                  this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
                  this.simpleButton1.Name = "simpleButton1";
                  this.simpleButton1.Size = new System.Drawing.Size(112, 34);
                  this.simpleButton1.TabIndex = 0;
                  this.simpleButton1.Text = "simpleButton1";
                  // 
                  // XtraForm2
                  // 
                  this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
                  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                  this.ClientSize = new System.Drawing.Size(735, 597);
                  this.Controls.Add(this.simpleButton1);
                  this.Margin = new System.Windows.Forms.Padding(4);
                  this.Name = "XtraForm2";
                  this.Text = "XtraForm2";
                  this.ResumeLayout(false);

            }

            #endregion

            private DevExpress.XtraEditors.SimpleButton simpleButton1;
      }
}
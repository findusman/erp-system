namespace PRESENTATION_LAYER
{
      partial class XtraForm4
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
                  this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
                  this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
                  this.buttonEdit1 = new DevExpress.XtraEditors.ButtonEdit();
                  ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).BeginInit();
                  this.SuspendLayout();
                  // 
                  // simpleButton1
                  // 
                  this.simpleButton1.Location = new System.Drawing.Point(108, 105);
                  this.simpleButton1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
                  this.simpleButton1.Name = "simpleButton1";
                  this.simpleButton1.Size = new System.Drawing.Size(168, 50);
                  this.simpleButton1.TabIndex = 0;
                  this.simpleButton1.Text = "simpleButton1";
                  // 
                  // simpleButton2
                  // 
                  this.simpleButton2.Location = new System.Drawing.Point(336, 121);
                  this.simpleButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                  this.simpleButton2.Name = "simpleButton2";
                  this.simpleButton2.Size = new System.Drawing.Size(112, 34);
                  this.simpleButton2.TabIndex = 1;
                  this.simpleButton2.Text = "simpleButton2";
                  // 
                  // simpleButton3
                  // 
                  this.simpleButton3.Location = new System.Drawing.Point(336, 163);
                  this.simpleButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                  this.simpleButton3.Name = "simpleButton3";
                  this.simpleButton3.Size = new System.Drawing.Size(112, 34);
                  this.simpleButton3.TabIndex = 2;
                  this.simpleButton3.Text = "simpleButton3";
                  // 
                  // buttonEdit1
                  // 
                  this.buttonEdit1.Location = new System.Drawing.Point(336, 204);
                  this.buttonEdit1.Name = "buttonEdit1";
                  this.buttonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
                  this.buttonEdit1.Size = new System.Drawing.Size(112, 26);
                  this.buttonEdit1.TabIndex = 3;
                  // 
                  // XtraForm4
                  // 
                  this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
                  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                  this.ClientSize = new System.Drawing.Size(626, 523);
                  this.Controls.Add(this.buttonEdit1);
                  this.Controls.Add(this.simpleButton3);
                  this.Controls.Add(this.simpleButton2);
                  this.Controls.Add(this.simpleButton1);
                  this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
                  this.Name = "XtraForm4";
                  this.Text = "XtraForm4";
                  this.Load += new System.EventHandler(this.XtraForm4_Load);
                  ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).EndInit();
                  this.ResumeLayout(false);

            }

            #endregion

            private DevExpress.XtraEditors.SimpleButton simpleButton1;
            private DevExpress.XtraEditors.SimpleButton simpleButton2;
            private DevExpress.XtraEditors.SimpleButton simpleButton3;
            private DevExpress.XtraEditors.ButtonEdit buttonEdit1;
      }
}
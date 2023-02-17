namespace PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Message
{
    partial class frmMessages
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
            this.uC_TBL_PRODUCTS_gridLookUpForProdcuts1 = new PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.User_Controls.TBL_PRODUCTS.UC_TBL_PRODUCTS_gridLookUpForProdcuts();
            this.GridControl_messages = new DevExpress.XtraGrid.GridControl();
            this.GridView_Messages = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl_messages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Messages)).BeginInit();
            this.SuspendLayout();
            // 
            // uC_TBL_PRODUCTS_gridLookUpForProdcuts1
            // 
            this.uC_TBL_PRODUCTS_gridLookUpForProdcuts1.Location = new System.Drawing.Point(504, 221);
            this.uC_TBL_PRODUCTS_gridLookUpForProdcuts1.Name = "uC_TBL_PRODUCTS_gridLookUpForProdcuts1";
            this.uC_TBL_PRODUCTS_gridLookUpForProdcuts1.Size = new System.Drawing.Size(8, 8);
            this.uC_TBL_PRODUCTS_gridLookUpForProdcuts1.TabIndex = 0;
            // 
            // GridControl_messages
            // 
            this.GridControl_messages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControl_messages.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.GridControl_messages.Location = new System.Drawing.Point(0, 0);
            this.GridControl_messages.MainView = this.GridView_Messages;
            this.GridControl_messages.Margin = new System.Windows.Forms.Padding(4);
            this.GridControl_messages.Name = "GridControl_messages";
            this.GridControl_messages.Size = new System.Drawing.Size(834, 512);
            this.GridControl_messages.TabIndex = 20;
            this.GridControl_messages.TabStop = false;
            this.GridControl_messages.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridView_Messages});
            // 
            // GridView_Messages
            // 
            this.GridView_Messages.GridControl = this.GridControl_messages;
            this.GridView_Messages.Name = "GridView_Messages";
            // 
            // frmMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 512);
            this.Controls.Add(this.GridControl_messages);
            this.Controls.Add(this.uC_TBL_PRODUCTS_gridLookUpForProdcuts1);
            this.Name = "frmMessages";
            this.Text = "frmMessages";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.GridControl_messages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Messages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GEN_PRESENTATION_LAYER.User_Controls.TBL_PRODUCTS.UC_TBL_PRODUCTS_gridLookUpForProdcuts uC_TBL_PRODUCTS_gridLookUpForProdcuts1;
        public DevExpress.XtraGrid.GridControl GridControl_messages;
        public DevExpress.XtraGrid.Views.Grid.GridView GridView_Messages;
    }
}
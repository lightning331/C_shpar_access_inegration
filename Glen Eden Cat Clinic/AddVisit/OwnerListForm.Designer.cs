
namespace Glen_Eden_Cat_Clinic.AddVisit
{
    partial class OwnerListForm
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
            this.ReturnButton = new System.Windows.Forms.Button();
            this.listOwner = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ReturnButton
            // 
            this.ReturnButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ReturnButton.Location = new System.Drawing.Point(390, 399);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(75, 23);
            this.ReturnButton.TabIndex = 3;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            // 
            // listOwner
            // 
            this.listOwner.AutoArrange = false;
            this.listOwner.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listOwner.FullRowSelect = true;
            this.listOwner.GridLines = true;
            this.listOwner.HideSelection = false;
            this.listOwner.Location = new System.Drawing.Point(28, 28);
            this.listOwner.Name = "listOwner";
            this.listOwner.Size = new System.Drawing.Size(437, 337);
            this.listOwner.TabIndex = 2;
            this.listOwner.UseCompatibleStateImageBehavior = false;
            this.listOwner.View = System.Windows.Forms.View.Details;
            this.listOwner.DoubleClick += new System.EventHandler(this.listOwner_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Owner ID";
            this.columnHeader1.Width = 68;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Last Name";
            this.columnHeader2.Width = 154;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "First Name";
            this.columnHeader3.Width = 157;
            // 
            // OwnerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 437);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.listOwner);
            this.Name = "OwnerListForm";
            this.Text = "Owner List";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.ListView listOwner;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}
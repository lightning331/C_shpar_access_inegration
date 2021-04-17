
namespace Glen_Eden_Cat_Clinic.AddVisit
{
    partial class VeterinarianListForm
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
            this.listview1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ReturnButton
            // 
            this.ReturnButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ReturnButton.Location = new System.Drawing.Point(389, 396);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(75, 23);
            this.ReturnButton.TabIndex = 5;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            // 
            // listview1
            // 
            this.listview1.AutoArrange = false;
            this.listview1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listview1.FullRowSelect = true;
            this.listview1.GridLines = true;
            this.listview1.HideSelection = false;
            this.listview1.Location = new System.Drawing.Point(27, 25);
            this.listview1.Name = "listview1";
            this.listview1.Size = new System.Drawing.Size(437, 337);
            this.listview1.TabIndex = 4;
            this.listview1.UseCompatibleStateImageBehavior = false;
            this.listview1.View = System.Windows.Forms.View.Details;
            this.listview1.DoubleClick += new System.EventHandler(this.listview1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "veterinarian ID";
            this.columnHeader1.Width = 91;
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
            // VeterinarianListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 434);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.listview1);
            this.Name = "VeterinarianListForm";
            this.Text = "VeterinarianListForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.ListView listview1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}
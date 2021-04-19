
namespace Glen_Eden_Cat_Clinic.RemoveTreatment
{
    partial class RemoveTreatmentForm
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
            this.AssignTreatmentButton = new System.Windows.Forms.Button();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BirthDate = new System.Windows.Forms.DateTimePicker();
            this.labelCatName = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label_CatName = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelVisitID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelOwnerLastName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelOwnerFirstName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AssignTreatmentButton
            // 
            this.AssignTreatmentButton.Location = new System.Drawing.Point(169, 372);
            this.AssignTreatmentButton.Name = "AssignTreatmentButton";
            this.AssignTreatmentButton.Size = new System.Drawing.Size(115, 31);
            this.AssignTreatmentButton.TabIndex = 69;
            this.AssignTreatmentButton.Text = "Remove Treatment";
            this.AssignTreatmentButton.UseVisualStyleBackColor = true;
            this.AssignTreatmentButton.Click += new System.EventHandler(this.AssignTreatmentButton_Click);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantity";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Treatment Description";
            this.columnHeader2.Width = 193;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Treatment Id";
            this.columnHeader1.Width = 84;
            // 
            // BirthDate
            // 
            this.BirthDate.CustomFormat = "MM/dd/yyyy";
            this.BirthDate.Enabled = false;
            this.BirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthDate.Location = new System.Drawing.Point(370, 20);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(153, 20);
            this.BirthDate.TabIndex = 56;
            // 
            // labelCatName
            // 
            this.labelCatName.AutoSize = true;
            this.labelCatName.Location = new System.Drawing.Point(82, 49);
            this.labelCatName.Name = "labelCatName";
            this.labelCatName.Size = new System.Drawing.Size(35, 13);
            this.labelCatName.TabIndex = 55;
            this.labelCatName.Text = "label3";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(25, 147);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(537, 158);
            this.listView1.TabIndex = 64;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Assigned Treatment";
            // 
            // label_CatName
            // 
            this.label_CatName.AutoSize = true;
            this.label_CatName.Location = new System.Drawing.Point(19, 49);
            this.label_CatName.Name = "label_CatName";
            this.label_CatName.Size = new System.Drawing.Size(57, 13);
            this.label_CatName.TabIndex = 52;
            this.label_CatName.Text = "Cat Name:";
            // 
            // buttonReturn
            // 
            this.buttonReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonReturn.Location = new System.Drawing.Point(315, 372);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(115, 31);
            this.buttonReturn.TabIndex = 70;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BirthDate);
            this.groupBox1.Controls.Add(this.labelOwnerFirstName);
            this.groupBox1.Controls.Add(this.labelOwnerLastName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelCatName);
            this.groupBox1.Controls.Add(this.label_CatName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelVisitID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labelDescription);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(25, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 77);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visit Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Visit ID:";
            // 
            // labelVisitID
            // 
            this.labelVisitID.AutoSize = true;
            this.labelVisitID.Location = new System.Drawing.Point(64, 25);
            this.labelVisitID.Name = "labelVisitID";
            this.labelVisitID.Size = new System.Drawing.Size(35, 13);
            this.labelVisitID.TabIndex = 47;
            this.labelVisitID.Text = "label3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Visit Description:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(206, 24);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(35, 13);
            this.labelDescription.TabIndex = 49;
            this.labelDescription.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Visit Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Owner Last Name:";
            // 
            // labelOwnerLastName
            // 
            this.labelOwnerLastName.AutoSize = true;
            this.labelOwnerLastName.Location = new System.Drawing.Point(239, 49);
            this.labelOwnerLastName.Name = "labelOwnerLastName";
            this.labelOwnerLastName.Size = new System.Drawing.Size(35, 13);
            this.labelOwnerLastName.TabIndex = 55;
            this.labelOwnerLastName.Text = "label3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(310, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Owner First Name:";
            // 
            // labelOwnerFirstName
            // 
            this.labelOwnerFirstName.AutoSize = true;
            this.labelOwnerFirstName.Location = new System.Drawing.Point(411, 49);
            this.labelOwnerFirstName.Name = "labelOwnerFirstName";
            this.labelOwnerFirstName.Size = new System.Drawing.Size(35, 13);
            this.labelOwnerFirstName.TabIndex = 55;
            this.labelOwnerFirstName.Text = "label3";
            // 
            // RemoveTreatmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 430);
            this.Controls.Add(this.AssignTreatmentButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.groupBox1);
            this.Name = "RemoveTreatmentForm";
            this.Text = "Remove Treatment";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AssignTreatmentButton;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.DateTimePicker BirthDate;
        private System.Windows.Forms.Label labelCatName;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_CatName;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelVisitID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelOwnerFirstName;
        private System.Windows.Forms.Label labelOwnerLastName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
    }
}
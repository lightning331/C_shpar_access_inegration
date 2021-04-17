
namespace Glen_Eden_Cat_Clinic.UpdateCat
{
    partial class UpdateCatForm
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
            this.comboCatGender = new System.Windows.Forms.ComboBox();
            this.BirthDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textCatBreed = new System.Windows.Forms.TextBox();
            this.textCatID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textCatName = new System.Windows.Forms.TextBox();
            this.labelCatName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelCatID = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.textOwnerFirstName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textOwnerLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UpdateCatButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboCatGender
            // 
            this.comboCatGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCatGender.FormattingEnabled = true;
            this.comboCatGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboCatGender.Location = new System.Drawing.Point(85, 92);
            this.comboCatGender.Name = "comboCatGender";
            this.comboCatGender.Size = new System.Drawing.Size(200, 21);
            this.comboCatGender.TabIndex = 5;
            // 
            // BirthDate
            // 
            this.BirthDate.CustomFormat = "MM/dd/yyyy";
            this.BirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthDate.Location = new System.Drawing.Point(85, 161);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(200, 20);
            this.BirthDate.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Date of Birth:";
            // 
            // textCatBreed
            // 
            this.textCatBreed.Location = new System.Drawing.Point(85, 126);
            this.textCatBreed.Name = "textCatBreed";
            this.textCatBreed.Size = new System.Drawing.Size(200, 20);
            this.textCatBreed.TabIndex = 1;
            // 
            // textCatID
            // 
            this.textCatID.Location = new System.Drawing.Point(85, 23);
            this.textCatID.Name = "textCatID";
            this.textCatID.ReadOnly = true;
            this.textCatID.Size = new System.Drawing.Size(200, 20);
            this.textCatID.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Breed:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Gender:";
            // 
            // textCatName
            // 
            this.textCatName.Location = new System.Drawing.Point(85, 57);
            this.textCatName.Name = "textCatName";
            this.textCatName.Size = new System.Drawing.Size(200, 20);
            this.textCatName.TabIndex = 1;
            // 
            // labelCatName
            // 
            this.labelCatName.AutoSize = true;
            this.labelCatName.Location = new System.Drawing.Point(44, 60);
            this.labelCatName.Name = "labelCatName";
            this.labelCatName.Size = new System.Drawing.Size(38, 13);
            this.labelCatName.TabIndex = 0;
            this.labelCatName.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboCatGender);
            this.groupBox2.Controls.Add(this.BirthDate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textCatBreed);
            this.groupBox2.Controls.Add(this.textCatID);
            this.groupBox2.Controls.Add(this.labelCatID);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textCatName);
            this.groupBox2.Controls.Add(this.labelCatName);
            this.groupBox2.Location = new System.Drawing.Point(28, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 251);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cat Details";
            // 
            // labelCatID
            // 
            this.labelCatID.AutoSize = true;
            this.labelCatID.Location = new System.Drawing.Point(63, 26);
            this.labelCatID.Name = "labelCatID";
            this.labelCatID.Size = new System.Drawing.Size(19, 13);
            this.labelCatID.TabIndex = 0;
            this.labelCatID.Text = "Id:";
            // 
            // buttonReturn
            // 
            this.buttonReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonReturn.Location = new System.Drawing.Point(292, 394);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(115, 31);
            this.buttonReturn.TabIndex = 13;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            // 
            // textOwnerFirstName
            // 
            this.textOwnerFirstName.Location = new System.Drawing.Point(292, 19);
            this.textOwnerFirstName.Name = "textOwnerFirstName";
            this.textOwnerFirstName.ReadOnly = true;
            this.textOwnerFirstName.Size = new System.Drawing.Size(111, 20);
            this.textOwnerFirstName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(228, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "First Name:";
            // 
            // textOwnerLastName
            // 
            this.textOwnerLastName.Location = new System.Drawing.Point(85, 19);
            this.textOwnerLastName.Name = "textOwnerLastName";
            this.textOwnerLastName.ReadOnly = true;
            this.textOwnerLastName.Size = new System.Drawing.Size(121, 20);
            this.textOwnerLastName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textOwnerFirstName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textOwnerLastName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(28, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 49);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Owner";
            // 
            // UpdateCatButton
            // 
            this.UpdateCatButton.Location = new System.Drawing.Point(146, 394);
            this.UpdateCatButton.Name = "UpdateCatButton";
            this.UpdateCatButton.Size = new System.Drawing.Size(115, 31);
            this.UpdateCatButton.TabIndex = 0;
            this.UpdateCatButton.Text = "Update Cat";
            this.UpdateCatButton.UseVisualStyleBackColor = true;
            this.UpdateCatButton.Click += new System.EventHandler(this.UpdateCatButton_Click);
            // 
            // UpdateCatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 451);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UpdateCatButton);
            this.Name = "UpdateCatForm";
            this.Text = "Update Cat";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboCatGender;
        private System.Windows.Forms.DateTimePicker BirthDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textCatBreed;
        private System.Windows.Forms.TextBox textCatID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCatName;
        private System.Windows.Forms.Label labelCatName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelCatID;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.TextBox textOwnerFirstName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textOwnerLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button UpdateCatButton;
    }
}
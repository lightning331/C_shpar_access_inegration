
namespace Glen_Eden_Cat_Clinic.UpdateVisit
{
    partial class UpdateVisitForm
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
            this.buttonReturn = new System.Windows.Forms.Button();
            this.UpdateVisitButton = new System.Windows.Forms.Button();
            this.textFee = new System.Windows.Forms.TextBox();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.VisitDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textVisitID = new System.Windows.Forms.TextBox();
            this.textCat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonReturn
            // 
            this.buttonReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonReturn.Location = new System.Drawing.Point(259, 341);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(115, 31);
            this.buttonReturn.TabIndex = 18;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            // 
            // UpdateVisitButton
            // 
            this.UpdateVisitButton.Location = new System.Drawing.Point(113, 341);
            this.UpdateVisitButton.Name = "UpdateVisitButton";
            this.UpdateVisitButton.Size = new System.Drawing.Size(115, 31);
            this.UpdateVisitButton.TabIndex = 0;
            this.UpdateVisitButton.Text = "Update Visit";
            this.UpdateVisitButton.UseVisualStyleBackColor = true;
            this.UpdateVisitButton.Click += new System.EventHandler(this.UpdateVisitButton_Click);
            // 
            // textFee
            // 
            this.textFee.Location = new System.Drawing.Point(113, 155);
            this.textFee.Name = "textFee";
            this.textFee.Size = new System.Drawing.Size(100, 20);
            this.textFee.TabIndex = 17;
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(113, 85);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(200, 20);
            this.textDescription.TabIndex = 16;
            // 
            // VisitDate
            // 
            this.VisitDate.CustomFormat = "MM/dd/yyyy";
            this.VisitDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.VisitDate.Location = new System.Drawing.Point(113, 120);
            this.VisitDate.Name = "VisitDate";
            this.VisitDate.Size = new System.Drawing.Size(200, 20);
            this.VisitDate.TabIndex = 15;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Current",
            "Paid"});
            this.comboBoxStatus.Location = new System.Drawing.Point(112, 187);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(137, 21);
            this.comboBoxStatus.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Visit Fee($):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Visit Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Visit Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cat Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Visit ID:";
            // 
            // textVisitID
            // 
            this.textVisitID.Location = new System.Drawing.Point(115, 49);
            this.textVisitID.Name = "textVisitID";
            this.textVisitID.ReadOnly = true;
            this.textVisitID.Size = new System.Drawing.Size(81, 20);
            this.textVisitID.TabIndex = 20;
            // 
            // textCat
            // 
            this.textCat.Location = new System.Drawing.Point(113, 219);
            this.textCat.Name = "textCat";
            this.textCat.ReadOnly = true;
            this.textCat.Size = new System.Drawing.Size(81, 20);
            this.textCat.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Owner Last Name:";
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(113, 254);
            this.textLastName.Name = "textLastName";
            this.textLastName.ReadOnly = true;
            this.textLastName.Size = new System.Drawing.Size(81, 20);
            this.textLastName.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Owner First Name:";
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(113, 289);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.ReadOnly = true;
            this.textFirstName.Size = new System.Drawing.Size(81, 20);
            this.textFirstName.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(66, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Status:";
            // 
            // UpdateVisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 411);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.textCat);
            this.Controls.Add(this.textVisitID);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.UpdateVisitButton);
            this.Controls.Add(this.textFee);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.VisitDate);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateVisitForm";
            this.Text = "Update Visit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button UpdateVisitButton;
        private System.Windows.Forms.TextBox textFee;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.DateTimePicker VisitDate;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textVisitID;
        private System.Windows.Forms.TextBox textCat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.Label label9;
    }
}
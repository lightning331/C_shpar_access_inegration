
namespace Glen_Eden_Cat_Clinic.AddVisit
{
    partial class AddVisitForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.VisitDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textFee = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddVisitButton = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textOwnerId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textOwnerLastName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textOwnerFirstName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textCatId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textCatName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textVeterFirstName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textVeterLastName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textVeterId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // VisitDate
            // 
            this.VisitDate.CustomFormat = "MM/dd/yyyy";
            this.VisitDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.VisitDate.Location = new System.Drawing.Point(107, 211);
            this.VisitDate.Name = "VisitDate";
            this.VisitDate.Size = new System.Drawing.Size(200, 20);
            this.VisitDate.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Visit Date:";
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(107, 247);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(200, 20);
            this.textDescription.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Visit Description:";
            // 
            // textFee
            // 
            this.textFee.Location = new System.Drawing.Point(107, 284);
            this.textFee.Name = "textFee";
            this.textFee.Size = new System.Drawing.Size(100, 20);
            this.textFee.TabIndex = 4;
            this.textFee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textFee_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Visit Fee($):";
            // 
            // AddVisitButton
            // 
            this.AddVisitButton.Location = new System.Drawing.Point(139, 365);
            this.AddVisitButton.Name = "AddVisitButton";
            this.AddVisitButton.Size = new System.Drawing.Size(115, 31);
            this.AddVisitButton.TabIndex = 0;
            this.AddVisitButton.Text = "Add Visit";
            this.AddVisitButton.UseVisualStyleBackColor = true;
            this.AddVisitButton.Click += new System.EventHandler(this.AddVisitButton_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(285, 365);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(115, 31);
            this.buttonReturn.TabIndex = 5;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textOwnerFirstName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textOwnerLastName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textOwnerId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 49);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Owner";
            // 
            // textOwnerId
            // 
            this.textOwnerId.Location = new System.Drawing.Point(28, 16);
            this.textOwnerId.Name = "textOwnerId";
            this.textOwnerId.ReadOnly = true;
            this.textOwnerId.Size = new System.Drawing.Size(58, 20);
            this.textOwnerId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name:";
            // 
            // textOwnerLastName
            // 
            this.textOwnerLastName.Location = new System.Drawing.Point(176, 16);
            this.textOwnerLastName.Name = "textOwnerLastName";
            this.textOwnerLastName.ReadOnly = true;
            this.textOwnerLastName.Size = new System.Drawing.Size(121, 20);
            this.textOwnerLastName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(319, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "First Name:";
            // 
            // textOwnerFirstName
            // 
            this.textOwnerFirstName.Location = new System.Drawing.Point(383, 16);
            this.textOwnerFirstName.Name = "textOwnerFirstName";
            this.textOwnerFirstName.ReadOnly = true;
            this.textOwnerFirstName.Size = new System.Drawing.Size(111, 20);
            this.textOwnerFirstName.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textCatId);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textCatName);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(17, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 50);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Id:";
            // 
            // textCatId
            // 
            this.textCatId.Location = new System.Drawing.Point(28, 19);
            this.textCatId.Name = "textCatId";
            this.textCatId.ReadOnly = true;
            this.textCatId.Size = new System.Drawing.Size(58, 20);
            this.textCatId.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(116, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Cat Name:";
            // 
            // textCatName
            // 
            this.textCatName.Location = new System.Drawing.Point(176, 19);
            this.textCatName.Name = "textCatName";
            this.textCatName.ReadOnly = true;
            this.textCatName.Size = new System.Drawing.Size(121, 20);
            this.textCatName.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textVeterFirstName);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textVeterLastName);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textVeterId);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(17, 125);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(509, 66);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Veterinarian";
            // 
            // textVeterFirstName
            // 
            this.textVeterFirstName.Location = new System.Drawing.Point(387, 23);
            this.textVeterFirstName.Name = "textVeterFirstName";
            this.textVeterFirstName.ReadOnly = true;
            this.textVeterFirstName.Size = new System.Drawing.Size(111, 20);
            this.textVeterFirstName.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(323, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "First Name:";
            // 
            // textVeterLastName
            // 
            this.textVeterLastName.Location = new System.Drawing.Point(180, 23);
            this.textVeterLastName.Name = "textVeterLastName";
            this.textVeterLastName.ReadOnly = true;
            this.textVeterLastName.Size = new System.Drawing.Size(121, 20);
            this.textVeterLastName.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(117, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Last Name:";
            // 
            // textVeterId
            // 
            this.textVeterId.Location = new System.Drawing.Point(32, 23);
            this.textVeterId.Name = "textVeterId";
            this.textVeterId.ReadOnly = true;
            this.textVeterId.Size = new System.Drawing.Size(58, 20);
            this.textVeterId.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Id:";
            // 
            // AddVisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 408);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.AddVisitButton);
            this.Controls.Add(this.textFee);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.VisitDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "AddVisitForm";
            this.Text = "Add Visit";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker VisitDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textFee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddVisitButton;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textOwnerFirstName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textOwnerLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textOwnerId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textCatId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textCatName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textVeterFirstName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textVeterLastName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textVeterId;
        private System.Windows.Forms.Label label12;
    }
}
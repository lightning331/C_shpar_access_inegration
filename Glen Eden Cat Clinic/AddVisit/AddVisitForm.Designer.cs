
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
            this.comboBoxOwner = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxVeterinarian = new System.Windows.Forms.ComboBox();
            this.VisitDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textFee = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddVisitButton = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Owner:";
            // 
            // comboBoxOwner
            // 
            this.comboBoxOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOwner.FormattingEnabled = true;
            this.comboBoxOwner.Location = new System.Drawing.Point(102, 30);
            this.comboBoxOwner.Name = "comboBoxOwner";
            this.comboBoxOwner.Size = new System.Drawing.Size(137, 21);
            this.comboBoxOwner.TabIndex = 0;
            this.comboBoxOwner.SelectedIndexChanged += new System.EventHandler(this.comboBoxOwner_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cat:";
            // 
            // comboBoxCat
            // 
            this.comboBoxCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCat.FormattingEnabled = true;
            this.comboBoxCat.Location = new System.Drawing.Point(102, 68);
            this.comboBoxCat.Name = "comboBoxCat";
            this.comboBoxCat.Size = new System.Drawing.Size(137, 21);
            this.comboBoxCat.TabIndex = 1;
            this.comboBoxCat.SelectedIndexChanged += new System.EventHandler(this.comboBoxCat_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Veterinarian:";
            // 
            // comboBoxVeterinarian
            // 
            this.comboBoxVeterinarian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVeterinarian.FormattingEnabled = true;
            this.comboBoxVeterinarian.Location = new System.Drawing.Point(102, 105);
            this.comboBoxVeterinarian.Name = "comboBoxVeterinarian";
            this.comboBoxVeterinarian.Size = new System.Drawing.Size(137, 21);
            this.comboBoxVeterinarian.TabIndex = 1;
            this.comboBoxVeterinarian.SelectedIndexChanged += new System.EventHandler(this.comboBoxVeterinarian_SelectedIndexChanged);
            // 
            // VisitDate
            // 
            this.VisitDate.CustomFormat = "MM/dd/yyyy";
            this.VisitDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.VisitDate.Location = new System.Drawing.Point(102, 143);
            this.VisitDate.Name = "VisitDate";
            this.VisitDate.Size = new System.Drawing.Size(200, 20);
            this.VisitDate.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Visit Date:";
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(102, 179);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(200, 20);
            this.textDescription.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Visit Description:";
            // 
            // textFee
            // 
            this.textFee.Location = new System.Drawing.Point(102, 216);
            this.textFee.Name = "textFee";
            this.textFee.Size = new System.Drawing.Size(100, 20);
            this.textFee.TabIndex = 4;
            this.textFee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textFee_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Visit Fee($):";
            // 
            // AddVisitButton
            // 
            this.AddVisitButton.Location = new System.Drawing.Point(102, 325);
            this.AddVisitButton.Name = "AddVisitButton";
            this.AddVisitButton.Size = new System.Drawing.Size(115, 31);
            this.AddVisitButton.TabIndex = 5;
            this.AddVisitButton.Text = "Add Visit";
            this.AddVisitButton.UseVisualStyleBackColor = true;
            this.AddVisitButton.Click += new System.EventHandler(this.AddVisitButton_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(248, 325);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(115, 31);
            this.buttonReturn.TabIndex = 5;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // AddVisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 406);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.AddVisitButton);
            this.Controls.Add(this.textFee);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.VisitDate);
            this.Controls.Add(this.comboBoxVeterinarian);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxCat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxOwner);
            this.Controls.Add(this.label1);
            this.Name = "AddVisitForm";
            this.Text = "Add Visit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxOwner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxVeterinarian;
        private System.Windows.Forms.DateTimePicker VisitDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textFee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddVisitButton;
        private System.Windows.Forms.Button buttonReturn;
    }
}

namespace Glen_Eden_Cat_Clinic.DeleteVisit
{
    partial class DeleteVisitForm
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
            this.DeleteVisitButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelVisitID = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelVisitFee = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonReturn
            // 
            this.buttonReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonReturn.Location = new System.Drawing.Point(294, 330);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(115, 31);
            this.buttonReturn.TabIndex = 34;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            // 
            // DeleteVisitButton
            // 
            this.DeleteVisitButton.Location = new System.Drawing.Point(148, 330);
            this.DeleteVisitButton.Name = "DeleteVisitButton";
            this.DeleteVisitButton.Size = new System.Drawing.Size(115, 31);
            this.DeleteVisitButton.TabIndex = 21;
            this.DeleteVisitButton.Text = "Delete Visit";
            this.DeleteVisitButton.UseVisualStyleBackColor = true;
            this.DeleteVisitButton.Click += new System.EventHandler(this.DeleteVisitButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Visit Fee($):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Visit Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Visit Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(101, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Visit ID:";
            // 
            // labelVisitID
            // 
            this.labelVisitID.AutoSize = true;
            this.labelVisitID.Location = new System.Drawing.Point(148, 42);
            this.labelVisitID.Name = "labelVisitID";
            this.labelVisitID.Size = new System.Drawing.Size(35, 13);
            this.labelVisitID.TabIndex = 39;
            this.labelVisitID.Text = "label3";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(147, 76);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(35, 13);
            this.labelDescription.TabIndex = 40;
            this.labelDescription.Text = "label3";
            // 
            // labelVisitFee
            // 
            this.labelVisitFee.AutoSize = true;
            this.labelVisitFee.Location = new System.Drawing.Point(147, 146);
            this.labelVisitFee.Name = "labelVisitFee";
            this.labelVisitFee.Size = new System.Drawing.Size(35, 13);
            this.labelVisitFee.TabIndex = 41;
            this.labelVisitFee.Text = "label3";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(148, 113);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(35, 13);
            this.labelDate.TabIndex = 40;
            this.labelDate.Text = "label3";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(145, 179);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(35, 13);
            this.labelStatus.TabIndex = 41;
            this.labelStatus.Text = "label3";
            // 
            // DeleteVisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 398);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelVisitFee);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelVisitID);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.DeleteVisitButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Name = "DeleteVisitForm";
            this.Text = "Delete Visit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button DeleteVisitButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelVisitID;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelVisitFee;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelStatus;
    }
}
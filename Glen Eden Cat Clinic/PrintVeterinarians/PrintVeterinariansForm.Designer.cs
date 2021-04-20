
namespace Glen_Eden_Cat_Clinic.PrintVeterinarians
{
    partial class PrintVeterinariansForm
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
            this.buttonPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(217, 149);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(117, 39);
            this.buttonPrint.TabIndex = 1;
            this.buttonPrint.Text = "Print Veterinarians";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // PrintVeterinariansForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 344);
            this.Controls.Add(this.buttonPrint);
            this.Name = "PrintVeterinariansForm";
            this.Text = "Print Veterinarians";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPrint;
    }
}
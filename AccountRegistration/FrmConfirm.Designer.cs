using System.ComponentModel;

namespace AccountRegistration
{
    partial class FrmConfirm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfirm));
            this.label1 = new System.Windows.Forms.Label();
            this.StudentNumber = new System.Windows.Forms.Label();
            this.Program = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MiddleName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ContactNumber = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // StudentNumber
            // 
            resources.ApplyResources(this.StudentNumber, "StudentNumber");
            this.StudentNumber.Name = "StudentNumber";
            // 
            // Program
            // 
            resources.ApplyResources(this.Program, "Program");
            this.Program.Name = "Program";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // LastName
            // 
            resources.ApplyResources(this.LastName, "LastName");
            this.LastName.Name = "LastName";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // FirstName
            // 
            resources.ApplyResources(this.FirstName, "FirstName");
            this.FirstName.Name = "FirstName";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // MiddleName
            // 
            resources.ApplyResources(this.MiddleName, "MiddleName");
            this.MiddleName.Name = "MiddleName";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // Age
            // 
            resources.ApplyResources(this.Age, "Age");
            this.Age.Name = "Age";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // ContactNumber
            // 
            resources.ApplyResources(this.ContactNumber, "ContactNumber");
            this.ContactNumber.Name = "ContactNumber";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // Address
            // 
            resources.ApplyResources(this.Address, "Address");
            this.Address.Name = "Address";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // SubmitButton
            // 
            resources.ApplyResources(this.SubmitButton, "SubmitButton");
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // FrmConfirm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ContactNumber);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.MiddleName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Program);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StudentNumber);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfirm";
            this.ShowIcon = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.Load += new System.EventHandler(this.FrmConfirm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button SubmitButton;

        private System.Windows.Forms.Label MiddleName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label ContactNumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label label16;

        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label StudentNumber;
        private System.Windows.Forms.Label Program;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}
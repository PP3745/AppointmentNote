using System;
using System.Drawing;
using System.Windows.Forms;

namespace AppointmentNote
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblAppointmentID;
        private TextBox txtAppointmentID;
        private Label lblSubject;
        private TextBox txtSubject;
        private Label lblImportance;
        private ComboBox cmbImportance;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Button btnAdd;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            lblAppointmentID = new Label();
            txtAppointmentID = new TextBox();
            lblSubject = new Label();
            txtSubject = new TextBox();
            lblImportance = new Label();
            cmbImportance = new ComboBox();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            btnAdd = new Button();

            SuspendLayout();

            // Form
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Text = "โปรเเกรมบันทึกการนัดหมาย";

            // lblAppointmentID
            lblAppointmentID.AutoSize = true;
            lblAppointmentID.Location = new Point(20, 24);
            lblAppointmentID.Name = "lblAppointmentID";
            lblAppointmentID.Size = new Size(220, 20);
            lblAppointmentID.Text = "รหัสนัดหมาย (AppointmentID):";

            // txtAppointmentID
            txtAppointmentID.Location = new Point(260, 20);
            txtAppointmentID.Name = "txtAppointmentID";
            txtAppointmentID.Size = new Size(300, 27);
            txtAppointmentID.TabIndex = 0;

            // lblSubject
            lblSubject.AutoSize = true;
            lblSubject.Location = new Point(20, 70);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(140, 20);
            lblSubject.Text = "หัวข้อ (Subject):";

            // txtSubject
            txtSubject.Location = new Point(260, 66);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(300, 27);
            txtSubject.TabIndex = 1;

            // lblImportance
            lblImportance.AutoSize = true;
            lblImportance.Location = new Point(20, 116);
            lblImportance.Name = "lblImportance";
            lblImportance.Size = new Size(180, 20);
            lblImportance.Text = "ความสำคัญ (Importance):";

            // cmbImportance
            cmbImportance.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbImportance.Items.AddRange(new object[] { "Low", "Medium", "High" });
            cmbImportance.Location = new Point(260, 112);
            cmbImportance.Name = "cmbImportance";
            cmbImportance.Size = new Size(200, 28);
            cmbImportance.TabIndex = 2;

            // lblStatus
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(20, 162);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(120, 20);
            lblStatus.Text = "สถานะ (Status):";

            // cmbStatus
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Items.AddRange(new object[] { "Planned", "Confirmed", "Completed" });
            cmbStatus.Location = new Point(260, 158);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(200, 28);
            cmbStatus.TabIndex = 3;

            // btnAdd
            btnAdd.Location = new Point(260, 210);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 35);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += new EventHandler(this.btnAdd_Click);

            // Add controls to form
            Controls.Add(lblAppointmentID);
            Controls.Add(txtAppointmentID);
            Controls.Add(lblSubject);
            Controls.Add(txtSubject);
            Controls.Add(lblImportance);
            Controls.Add(cmbImportance);
            Controls.Add(lblStatus);
            Controls.Add(cmbStatus);
            Controls.Add(btnAdd);

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}

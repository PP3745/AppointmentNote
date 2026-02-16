using System;
using System.Windows.Forms;

namespace AppointmentNote
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            var id = txtAppointmentID.Text.Trim();
            var subject = txtSubject.Text.Trim();

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(subject))
            {
                MessageBox.Show("กรุณากรอกข้อมูลในช่อง รหัสนัดหมาย และ หัวข้อ", "การตรวจสอบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var importance = cmbImportance.SelectedItem?.ToString() ?? "(ไม่ระบุ)";
            var status = cmbStatus.SelectedItem?.ToString() ?? "(ไม่ระบุ)";

            var summary = $"รหัสการนัด: {id}\nหัวข้อ: {subject}\nความสำคัญ: {importance}\nสถานะ: {status}";

            MessageBox.Show(summary, "รายละเอียดการนัดหมาย", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

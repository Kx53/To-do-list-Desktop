using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite; //Newly Added
using System.IO; //Newly Added
using System.Windows.Forms;

namespace Todolist
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        DataSet data = new DataSet();
        SQLiteConnection conn;
        string conStr = "Data Source=D:\\Projects\\Programming\\To-do-list\\Todolist\\Todolist\\database\\tasks.sqlite;";

        private void Main_Load(object sender, EventArgs e)
        {
            showData();
            rdoStatusAll.Checked = true; // เลือกไว้ก่อน
            btnUpdate.Enabled = false;
        }
        private void showData()
        {
            conn = new SQLiteConnection(conStr);
            conn.Open();

            string sql = "SELECT * FROM Tasks";
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

            data.Tables.Clear(); // ล้างก่อนเผื่อเรียกหลายรอบ
            adapter.Fill(data, "tasks");
            dgvTasks.DataSource = data.Tables["tasks"];

            conn.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(conStr);
            conn.Open();

            string sql = "INSERT INTO Tasks (Description, StartDate, DueDate, IsCompleted) " +
                         "VALUES (@desc, @start, @due, @done)";

            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@desc", txtTask.Text);
            cmd.Parameters.AddWithValue("@start", dtpStartDate.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@due", dtpDueDate.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@done", 0); // เพิ่มใหม่ = Pending

            int result = cmd.ExecuteNonQuery();
            if (result == -1)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: ไม่สามารถเพิ่มข้อมูลได้");
            }

            conn.Close();
            showData(); // โหลดข้อมูลใหม่
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count > 0)
            {
                // ดึงค่า Id จากแถวที่เลือก
                int id = Convert.ToInt32(dgvTasks.SelectedRows[0].Cells["Id"].Value);

                // ยืนยันก่อนลบ
                DialogResult result = MessageBox.Show("คุณต้องการลบงานนี้หรือไม่?", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    conn = new SQLiteConnection(conStr);
                    conn.Open();

                    string sql = "DELETE FROM Tasks WHERE Id = @id";
                    SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    showData(); // โหลดข้อมูลใหม่
                }
            }
            else
            {
                MessageBox.Show("กรุณาเลือกแถวที่ต้องการลบ");
            }
        }

        private void dgvTasks_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // ตรวจว่าเป็นคอลัมน์ Checkbox หรือไม่
            if (dgvTasks.Columns[e.ColumnIndex].Name == "colIsDone")
            {
                int id = Convert.ToInt32(dgvTasks.Rows[e.RowIndex].Cells["Id"].Value);
                bool isChecked = Convert.ToBoolean(dgvTasks.Rows[e.RowIndex].Cells["colIsDone"].Value);

                conn = new SQLiteConnection(conStr);
                conn.Open();

                string sql = "UPDATE Tasks SET IsCompleted = @done WHERE Id = @id";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@done", isChecked ? 1 : 0);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }

        private void dgvTasks_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvTasks.IsCurrentCellDirty)
            {
                dgvTasks.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void FilterData(string whereClause)
        {
            conn = new SQLiteConnection(conStr);
            conn.Open();

            string sql = "SELECT * FROM Tasks";
            if (!string.IsNullOrEmpty(whereClause))
            {
                sql += " WHERE " + whereClause;
            }

            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

            data.Tables.Clear();
            adapter.Fill(data, "tasks");
            dgvTasks.DataSource = data.Tables["tasks"];

            conn.Close();
        }

        private void rdoStatusAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoStatusAll.Checked)
                FilterData(""); // ไม่มีเงื่อนไข
        }

        private void rdoStatusPending_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoStatusPending.Checked)
                FilterData("IsCompleted = 0");
        }

        private void rdoStatusComplete_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoStatusComplete.Checked)
                FilterData("IsCompleted = 1");
        }

        private void dgvTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTasks.Rows[e.RowIndex];

                txtTask.Text = row.Cells["colDescription"].Value.ToString();
                dtpStartDate.Value = DateTime.Parse(row.Cells["colStartDate"].Value.ToString());
                dtpDueDate.Value = DateTime.Parse(row.Cells["colDueDate"].Value.ToString());

                btnUpdate.Enabled = true; // เปิดปุ่ม
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvTasks.SelectedRows[0].Cells["Id"].Value);

                conn = new SQLiteConnection(conStr);
                conn.Open();

                string sql = "UPDATE Tasks SET Description = @desc, StartDate = @start, DueDate = @due WHERE Id = @id";

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@desc", txtTask.Text);
                cmd.Parameters.AddWithValue("@start", dtpStartDate.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@due", dtpDueDate.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
                conn.Close();

                showData(); // รีเฟรช
                MessageBox.Show("อัปเดตสำเร็จ");
            }
            else
            {
                MessageBox.Show("กรุณาเลือก Task ที่ต้องการแก้ไข");
            }
            btnUpdate.Enabled = false; // ปิดอีกครั้งหลังจากอัปเดต
        }

        private void dgvTasks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvTasks.Columns[e.ColumnIndex].Name == "colStatus")
            {
                var row = dgvTasks.Rows[e.RowIndex];
                if (row.Cells["colIsDone"].Value != null)
                {
                    bool isDone = Convert.ToBoolean(row.Cells["colIsDone"].Value);
                    e.Value = isDone ? "Complete" : "Pending";
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
namespace Todolist
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.txtTask = new System.Windows.Forms.TextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.AppName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoStatusAll = new System.Windows.Forms.RadioButton();
            this.rdoStatusPending = new System.Windows.Forms.RadioButton();
            this.rdoStatusComplete = new System.Windows.Forms.RadioButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.colIsDone = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(135, 90);
            this.txtTask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(204, 29);
            this.txtTask.TabIndex = 0;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(135, 129);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(204, 29);
            this.dtpStartDate.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(759, 43);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 31);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Task";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AppName
            // 
            this.AppName.AutoSize = true;
            this.AppName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.AppName.Location = new System.Drawing.Point(35, 28);
            this.AppName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(127, 32);
            this.AppName.TabIndex = 3;
            this.AppName.Text = "To Do List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(166)))), ((int)(((byte)(167)))));
            this.label1.Location = new System.Drawing.Point(37, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Task";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(166)))), ((int)(((byte)(167)))));
            this.label2.Location = new System.Drawing.Point(37, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Due Date";
            // 
            // dgvTasks
            // 
            this.dgvTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIsDone,
            this.Id,
            this.colDescription,
            this.colStartDate,
            this.colDueDate,
            this.colStatus});
            this.dgvTasks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvTasks.Location = new System.Drawing.Point(369, 90);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.Size = new System.Drawing.Size(636, 489);
            this.dgvTasks.TabIndex = 6;
            this.dgvTasks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTasks_CellClick);
            this.dgvTasks.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTasks_CellFormatting);
            this.dgvTasks.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTasks_CellValueChanged);
            this.dgvTasks.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvTasks_CurrentCellDirtyStateChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(869, 43);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 31);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Location = new System.Drawing.Point(135, 168);
            this.dtpDueDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(204, 29);
            this.dtpDueDate.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(166)))), ((int)(((byte)(167)))));
            this.label3.Location = new System.Drawing.Point(37, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Start Date";
            // 
            // rdoStatusAll
            // 
            this.rdoStatusAll.AutoSize = true;
            this.rdoStatusAll.Location = new System.Drawing.Point(45, 372);
            this.rdoStatusAll.Name = "rdoStatusAll";
            this.rdoStatusAll.Size = new System.Drawing.Size(47, 25);
            this.rdoStatusAll.TabIndex = 14;
            this.rdoStatusAll.TabStop = true;
            this.rdoStatusAll.Text = "All";
            this.rdoStatusAll.UseVisualStyleBackColor = true;
            this.rdoStatusAll.CheckedChanged += new System.EventHandler(this.rdoStatusAll_CheckedChanged);
            // 
            // rdoStatusPending
            // 
            this.rdoStatusPending.AutoSize = true;
            this.rdoStatusPending.Location = new System.Drawing.Point(45, 432);
            this.rdoStatusPending.Name = "rdoStatusPending";
            this.rdoStatusPending.Size = new System.Drawing.Size(87, 25);
            this.rdoStatusPending.TabIndex = 15;
            this.rdoStatusPending.TabStop = true;
            this.rdoStatusPending.Text = "Pending";
            this.rdoStatusPending.UseVisualStyleBackColor = true;
            this.rdoStatusPending.CheckedChanged += new System.EventHandler(this.rdoStatusPending_CheckedChanged);
            // 
            // rdoStatusComplete
            // 
            this.rdoStatusComplete.AutoSize = true;
            this.rdoStatusComplete.Location = new System.Drawing.Point(45, 491);
            this.rdoStatusComplete.Name = "rdoStatusComplete";
            this.rdoStatusComplete.Size = new System.Drawing.Size(100, 25);
            this.rdoStatusComplete.TabIndex = 16;
            this.rdoStatusComplete.TabStop = true;
            this.rdoStatusComplete.Text = "Complete";
            this.rdoStatusComplete.UseVisualStyleBackColor = true;
            this.rdoStatusComplete.CheckedChanged += new System.EventHandler(this.rdoStatusComplete_CheckedChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(135, 216);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 29);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // colIsDone
            // 
            this.colIsDone.DataPropertyName = "IsCompleted";
            this.colIsDone.FillWeight = 20F;
            this.colIsDone.HeaderText = "";
            this.colIsDone.Name = "colIsDone";
            this.colIsDone.Width = 50;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // colDescription
            // 
            this.colDescription.DataPropertyName = "Description";
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Width = 200;
            // 
            // colStartDate
            // 
            this.colStartDate.DataPropertyName = "StartDate";
            this.colStartDate.HeaderText = "Start Date";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.Width = 120;
            // 
            // colDueDate
            // 
            this.colDueDate.DataPropertyName = "DueDate";
            this.colDueDate.HeaderText = "End Date";
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.Width = 120;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1028, 613);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.rdoStatusComplete);
            this.Controls.Add(this.rdoStatusPending);
            this.Controls.Add(this.rdoStatusAll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvTasks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AppName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.txtTask);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "To Do List";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdoStatusAll;
        private System.Windows.Forms.RadioButton rdoStatusPending;
        private System.Windows.Forms.RadioButton rdoStatusComplete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsDone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}


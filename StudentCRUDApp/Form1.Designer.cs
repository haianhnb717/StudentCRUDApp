namespace StudentCRUDApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dgvStudents = new DataGridView();
            txtCode = new TextBox();
            txtName = new TextBox();
            txtBirthDate = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnLoad = new Button();
            lblCode = new Label();
            lblName = new Label();
            lblBirthDate = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(12, 130);
            dgvStudents.MultiSelect = false;
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.RowHeadersVisible = false;
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.RowTemplate.Height = 25;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(560, 250);
            dgvStudents.TabIndex = 0;
            dgvStudents.CellClick += dgvStudents_CellClick;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(128, 15);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(200, 27);
            txtCode.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(128, 45);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 27);
            txtName.TabIndex = 2;
            // 
            // txtBirthDate
            // 
            txtBirthDate.Location = new Point(128, 75);
            txtBirthDate.Name = "txtBirthDate";
            txtBirthDate.Size = new Size(200, 27);
            txtBirthDate.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(340, 15);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 25);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(340, 45);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 25);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(340, 75);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 25);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(460, 45);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(100, 25);
            btnLoad.TabIndex = 7;
            btnLoad.Text = "Reload";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Location = new Point(15, 18);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(102, 20);
            lblCode.TabIndex = 8;
            lblCode.Text = "Student Code:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(15, 48);
            lblName.Name = "lblName";
            lblName.Size = new Size(107, 20);
            lblName.TabIndex = 9;
            lblName.Text = "Student Name:";
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(15, 78);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(79, 20);
            lblBirthDate.TabIndex = 10;
            lblBirthDate.Text = "Birth Date:";
            // 
            // Form1
            // 
            ClientSize = new Size(584, 391);
            Controls.Add(lblBirthDate);
            Controls.Add(lblName);
            Controls.Add(lblCode);
            Controls.Add(btnLoad);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtBirthDate);
            Controls.Add(txtName);
            Controls.Add(txtCode);
            Controls.Add(dgvStudents);
            Name = "Form1";
            Text = "Student Management";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBirthDate;
    }
}

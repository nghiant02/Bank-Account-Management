namespace PRN211PE_SU22_DEMO
{
    partial class Management
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
            dgvListAccount = new DataGridView();
            lable1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtAccountID = new TextBox();
            txtAccountName = new TextBox();
            txtBranchName = new TextBox();
            cbAccountType = new ComboBox();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvListAccount).BeginInit();
            SuspendLayout();
            // 
            // dgvListAccount
            // 
            dgvListAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListAccount.Location = new Point(12, 32);
            dgvListAccount.Name = "dgvListAccount";
            dgvListAccount.RowHeadersWidth = 51;
            dgvListAccount.RowTemplate.Height = 29;
            dgvListAccount.Size = new Size(776, 188);
            dgvListAccount.TabIndex = 0;
            dgvListAccount.CellDoubleClick += dgvListAccount_CellDoubleClick;
            // 
            // lable1
            // 
            lable1.AutoSize = true;
            lable1.Location = new Point(116, 256);
            lable1.Name = "lable1";
            lable1.Size = new Size(78, 20);
            lable1.TabIndex = 1;
            lable1.Text = "AccountID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 295);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 2;
            label2.Text = "AccountName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(116, 335);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 3;
            label3.Text = "BranchName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(116, 373);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 4;
            label4.Text = "AccountType";
            // 
            // txtAccountID
            // 
            txtAccountID.Location = new Point(224, 256);
            txtAccountID.Name = "txtAccountID";
            txtAccountID.Size = new Size(151, 27);
            txtAccountID.TabIndex = 5;
            // 
            // txtAccountName
            // 
            txtAccountName.Location = new Point(224, 295);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.Size = new Size(151, 27);
            txtAccountName.TabIndex = 6;
            // 
            // txtBranchName
            // 
            txtBranchName.Location = new Point(224, 335);
            txtBranchName.Name = "txtBranchName";
            txtBranchName.Size = new Size(151, 27);
            txtBranchName.TabIndex = 7;
            // 
            // cbAccountType
            // 
            cbAccountType.FormattingEnabled = true;
            cbAccountType.Location = new Point(224, 373);
            cbAccountType.Name = "cbAccountType";
            cbAccountType.Size = new Size(151, 28);
            cbAccountType.TabIndex = 8;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(173, 446);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 9;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(317, 446);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(438, 446);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(478, 256);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(607, 256);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(159, 27);
            textBox1.TabIndex = 13;
            // 
            // Management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 507);
            Controls.Add(textBox1);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(cbAccountType);
            Controls.Add(txtBranchName);
            Controls.Add(txtAccountName);
            Controls.Add(txtAccountID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lable1);
            Controls.Add(dgvListAccount);
            Name = "Management";
            Text = "Management";
            ((System.ComponentModel.ISupportInitialize)dgvListAccount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvListAccount;
        private Label lable1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAccountID;
        private TextBox txtAccountName;
        private TextBox txtBranchName;
        private ComboBox cbAccountType;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSearch;
        private TextBox textBox1;
    }
}
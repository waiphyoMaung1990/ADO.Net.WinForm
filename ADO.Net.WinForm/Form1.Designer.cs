namespace ADO.Net.WinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            label1 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label2 = new Label();
            txtGender = new TextBox();
            label3 = new Label();
            txtCity = new TextBox();
            label4 = new Label();
            txtIsActive = new TextBox();
            label5 = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSlect = new Button();
            dgvEntities = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            FName = new DataGridViewTextBoxColumn();
            LName = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            IsActive = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvEntities).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 30);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "FirstName";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(117, 27);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(117, 76);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 79);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "LastName";
            // 
            // txtGender
            // 
            txtGender.Location = new Point(305, 30);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(100, 23);
            txtGender.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(227, 33);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 4;
            label3.Text = "Gender";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(305, 76);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(100, 23);
            txtCity.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(227, 79);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 6;
            label4.Text = "City";
            // 
            // txtIsActive
            // 
            txtIsActive.Location = new Point(503, 30);
            txtIsActive.Name = "txtIsActive";
            txtIsActive.Size = new Size(100, 23);
            txtIsActive.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(425, 33);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 8;
            label5.Text = "IsActive";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(628, 33);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(713, 33);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(628, 79);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSlect
            // 
            btnSlect.Location = new Point(713, 79);
            btnSlect.Name = "btnSlect";
            btnSlect.Size = new Size(75, 23);
            btnSlect.TabIndex = 13;
            btnSlect.Text = "Select";
            btnSlect.UseVisualStyleBackColor = true;
            btnSlect.Click += btnSlect_Click;
            // 
            // dgvEntities
            // 
            dgvEntities.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dgvEntities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEntities.Columns.AddRange(new DataGridViewColumn[] { Id, FName, LName, Gender, City, IsActive });
            dgvEntities.Location = new Point(81, 148);
            dgvEntities.Name = "dgvEntities";
            dgvEntities.RowTemplate.Height = 25;
            dgvEntities.Size = new Size(644, 150);
            dgvEntities.TabIndex = 14;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // FName
            // 
            FName.HeaderText = "FirstName";
            FName.Name = "FName";
            // 
            // LName
            // 
            LName.HeaderText = "LastName";
            LName.Name = "LName";
            // 
            // Gender
            // 
            Gender.HeaderText = "Gender";
            Gender.Name = "Gender";
            // 
            // City
            // 
            City.HeaderText = "City";
            City.Name = "City";
            // 
            // IsActive
            // 
            IsActive.HeaderText = "IsActive";
            IsActive.Name = "IsActive";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvEntities);
            Controls.Add(btnSlect);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtIsActive);
            Controls.Add(label5);
            Controls.Add(txtCity);
            Controls.Add(label4);
            Controls.Add(txtGender);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(label2);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvEntities).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label2;
        private TextBox txtGender;
        private Label label3;
        private TextBox txtCity;
        private Label label4;
        private TextBox txtIsActive;
        private Label label5;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSlect;
        private DataGridView dgvEntities;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn FName;
        private DataGridViewTextBoxColumn LName;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn IsActive;
    }
}

namespace DapperWinForm
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
            IsActive = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            LName = new DataGridViewTextBoxColumn();
            FName = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            dgvEntities = new DataGridView();
            City = new DataGridViewTextBoxColumn();
            btnSlect = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            txtIsActive = new TextBox();
            label5 = new Label();
            txtCity = new TextBox();
            label4 = new Label();
            txtGender = new TextBox();
            label3 = new Label();
            txtLastName = new TextBox();
            label2 = new Label();
            txtFirstName = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEntities).BeginInit();
            SuspendLayout();
            // 
            // IsActive
            // 
            IsActive.HeaderText = "IsActive";
            IsActive.Name = "IsActive";
            // 
            // Gender
            // 
            Gender.HeaderText = "Gender";
            Gender.Name = "Gender";
            // 
            // LName
            // 
            LName.HeaderText = "LastName";
            LName.Name = "LName";
            // 
            // FName
            // 
            FName.HeaderText = "FirstName";
            FName.Name = "FName";
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // dgvEntities
            // 
            dgvEntities.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dgvEntities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEntities.Columns.AddRange(new DataGridViewColumn[] { Id, FName, LName, Gender, City, IsActive });
            dgvEntities.Location = new Point(64, 183);
            dgvEntities.Name = "dgvEntities";
            dgvEntities.RowTemplate.Height = 25;
            dgvEntities.Size = new Size(644, 150);
            dgvEntities.TabIndex = 29;
            // 
            // City
            // 
            City.HeaderText = "City";
            City.Name = "City";
            // 
            // btnSlect
            // 
            btnSlect.Location = new Point(696, 114);
            btnSlect.Name = "btnSlect";
            btnSlect.Size = new Size(75, 23);
            btnSlect.TabIndex = 28;
            btnSlect.Text = "Select";
            btnSlect.UseVisualStyleBackColor = true;
            btnSlect.Click += btnSlect_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(611, 114);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(696, 68);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 26;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(611, 68);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 25;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtIsActive
            // 
            txtIsActive.Location = new Point(486, 65);
            txtIsActive.Name = "txtIsActive";
            txtIsActive.Size = new Size(100, 23);
            txtIsActive.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(408, 68);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 23;
            label5.Text = "IsActive";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(288, 111);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(100, 23);
            txtCity.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(210, 114);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 21;
            label4.Text = "City";
            // 
            // txtGender
            // 
            txtGender.Location = new Point(288, 65);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(100, 23);
            txtGender.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(210, 68);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 19;
            label3.Text = "Gender";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(100, 111);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 114);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 17;
            label2.Text = "LastName";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(100, 62);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 65);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 15;
            label1.Text = "FirstName";
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

        private DataGridViewTextBoxColumn IsActive;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn LName;
        private DataGridViewTextBoxColumn FName;
        private DataGridViewTextBoxColumn Id;
        private DataGridView dgvEntities;
        private DataGridViewTextBoxColumn City;
        private Button btnSlect;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private TextBox txtIsActive;
        private Label label5;
        private TextBox txtCity;
        private Label label4;
        private TextBox txtGender;
        private Label label3;
        private TextBox txtLastName;
        private Label label2;
        private TextBox txtFirstName;
        private Label label1;
    }
}

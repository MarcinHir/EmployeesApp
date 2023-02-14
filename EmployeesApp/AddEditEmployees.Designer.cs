namespace EmployeesApp
{
    partial class AddEditEmployees
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
            this.lbId = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbSalary = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.tbComments = new System.Windows.Forms.TextBox();
            this.dtpStartingWork = new System.Windows.Forms.DateTimePicker();
            this.lbStartWorkingDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(16, 13);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(97, 16);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "Id Pracownika :";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(16, 56);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(38, 16);
            this.lbFirstName.TabIndex = 1;
            this.lbFirstName.Text = "Imię :";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(16, 98);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(71, 16);
            this.lbLastName.TabIndex = 2;
            this.lbLastName.Text = "Nazwisko :";
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.Location = new System.Drawing.Point(16, 143);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(55, 16);
            this.lbSalary.TabIndex = 3;
            this.lbSalary.Text = "Pensja :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Uwagi :";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(38, 385);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 80);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfirm.Location = new System.Drawing.Point(203, 385);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(125, 80);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Zatwierdź";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(132, 13);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(196, 22);
            this.tbId.TabIndex = 7;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(132, 56);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(196, 22);
            this.tbFirstName.TabIndex = 8;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(132, 92);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(196, 22);
            this.tbLastName.TabIndex = 9;
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(132, 136);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(196, 22);
            this.tbSalary.TabIndex = 10;
            // 
            // tbComments
            // 
            this.tbComments.Location = new System.Drawing.Point(132, 238);
            this.tbComments.Multiline = true;
            this.tbComments.Name = "tbComments";
            this.tbComments.Size = new System.Drawing.Size(196, 126);
            this.tbComments.TabIndex = 11;
            // 
            // dtpStartingWork
            // 
            this.dtpStartingWork.Location = new System.Drawing.Point(132, 184);
            this.dtpStartingWork.Name = "dtpStartingWork";
            this.dtpStartingWork.Size = new System.Drawing.Size(196, 22);
            this.dtpStartingWork.TabIndex = 12;
            // 
            // lbStartWorkingDate
            // 
            this.lbStartWorkingDate.AutoSize = true;
            this.lbStartWorkingDate.Location = new System.Drawing.Point(16, 190);
            this.lbStartWorkingDate.Name = "lbStartWorkingDate";
            this.lbStartWorkingDate.Size = new System.Drawing.Size(104, 16);
            this.lbStartWorkingDate.TabIndex = 13;
            this.lbStartWorkingDate.Text = "Zatrudniony Od :";
            // 
            // AddEditEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 485);
            this.Controls.Add(this.lbStartWorkingDate);
            this.Controls.Add(this.dtpStartingWork);
            this.Controls.Add(this.tbComments);
            this.Controls.Add(this.tbSalary);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbSalary);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.lbId);
            this.Name = "AddEditEmployees";
            this.Text = "AddEditEmployees";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbSalary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.TextBox tbComments;
        private System.Windows.Forms.DateTimePicker dtpStartingWork;
        private System.Windows.Forms.Label lbStartWorkingDate;
    }
}
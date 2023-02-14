namespace EmployeesApp
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
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.btnFireEmployee = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.cbIsWorking = new System.Windows.Forms.ComboBox();
            this.lbWorking = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddEmployee.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddEmployee.Location = new System.Drawing.Point(13, 13);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(183, 39);
            this.btnAddEmployee.TabIndex = 0;
            this.btnAddEmployee.Text = "Dodaj Pracownika";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEditEmployee.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEditEmployee.Location = new System.Drawing.Point(13, 58);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(183, 39);
            this.btnEditEmployee.TabIndex = 1;
            this.btnEditEmployee.Text = "Edytuj Dane";
            this.btnEditEmployee.UseVisualStyleBackColor = false;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // btnFireEmployee
            // 
            this.btnFireEmployee.BackColor = System.Drawing.Color.Red;
            this.btnFireEmployee.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFireEmployee.Location = new System.Drawing.Point(13, 103);
            this.btnFireEmployee.Name = "btnFireEmployee";
            this.btnFireEmployee.Size = new System.Drawing.Size(183, 39);
            this.btnFireEmployee.TabIndex = 2;
            this.btnFireEmployee.Text = "Zwolnij Pracownika";
            this.btnFireEmployee.UseVisualStyleBackColor = false;
            this.btnFireEmployee.Click += new System.EventHandler(this.btnFireEmployee_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(202, 13);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.RowTemplate.Height = 24;
            this.dgvEmployees.Size = new System.Drawing.Size(1018, 425);
            this.dgvEmployees.TabIndex = 4;
            // 
            // cbIsWorking
            // 
            this.cbIsWorking.FormattingEnabled = true;
            this.cbIsWorking.Location = new System.Drawing.Point(13, 184);
            this.cbIsWorking.Name = "cbIsWorking";
            this.cbIsWorking.Size = new System.Drawing.Size(183, 24);
            this.cbIsWorking.TabIndex = 5;
            // 
            // lbWorking
            // 
            this.lbWorking.AutoSize = true;
            this.lbWorking.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbWorking.Location = new System.Drawing.Point(54, 156);
            this.lbWorking.Name = "lbWorking";
            this.lbWorking.Size = new System.Drawing.Size(102, 16);
            this.lbWorking.TabIndex = 6;
            this.lbWorking.Text = "Wybierz z listy :";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 450);
            this.Controls.Add(this.lbWorking);
            this.Controls.Add(this.cbIsWorking);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.btnFireEmployee);
            this.Controls.Add(this.btnEditEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Name = "Main";
            this.Text = "System Kadrowy";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnFireEmployee;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.ComboBox cbIsWorking;
        private System.Windows.Forms.Label lbWorking;
    }
}


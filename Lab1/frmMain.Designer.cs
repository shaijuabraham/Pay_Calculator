namespace Lab1
{
    partial class frmMain
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
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.lblDIsplay = new System.Windows.Forms.Label();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.btnCalculatePay = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gboxEmployeePay = new System.Windows.Forms.GroupBox();
            this.gboxEmployeePay.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.AutoSize = true;
            this.lblHourlyRate.Location = new System.Drawing.Point(8, 54);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(100, 13);
            this.lblHourlyRate.TabIndex = 0;
            this.lblHourlyRate.Text = "Enter Hourly Rate : ";
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Location = new System.Drawing.Point(8, 86);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(110, 13);
            this.lblHoursWorked.TabIndex = 1;
            this.lblHoursWorked.Text = "Enter Hours Worked :";
            // 
            // lblDIsplay
            // 
            this.lblDIsplay.AutoSize = true;
            this.lblDIsplay.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDIsplay.Location = new System.Drawing.Point(229, 16);
            this.lblDIsplay.Name = "lblDIsplay";
            this.lblDIsplay.Size = new System.Drawing.Size(79, 19);
            this.lblDIsplay.TabIndex = 2;
            this.lblDIsplay.Text = "TOTAL PAY";
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Location = new System.Drawing.Point(124, 51);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(84, 20);
            this.txtHourlyRate.TabIndex = 3;
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Location = new System.Drawing.Point(124, 86);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(84, 20);
            this.txtHoursWorked.TabIndex = 4;
            // 
            // btnCalculatePay
            // 
            this.btnCalculatePay.Location = new System.Drawing.Point(16, 165);
            this.btnCalculatePay.Name = "btnCalculatePay";
            this.btnCalculatePay.Size = new System.Drawing.Size(75, 23);
            this.btnCalculatePay.TabIndex = 5;
            this.btnCalculatePay.Text = "Calculate Pay";
            this.btnCalculatePay.UseVisualStyleBackColor = true;
            this.btnCalculatePay.Click += new System.EventHandler(this.btnCalculatePay_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(129, 165);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(254, 165);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gboxEmployeePay
            // 
            this.gboxEmployeePay.Controls.Add(this.txtHoursWorked);
            this.gboxEmployeePay.Controls.Add(this.txtHourlyRate);
            this.gboxEmployeePay.Controls.Add(this.lblDIsplay);
            this.gboxEmployeePay.Controls.Add(this.lblHoursWorked);
            this.gboxEmployeePay.Controls.Add(this.lblHourlyRate);
            this.gboxEmployeePay.Location = new System.Drawing.Point(5, 12);
            this.gboxEmployeePay.Name = "gboxEmployeePay";
            this.gboxEmployeePay.Size = new System.Drawing.Size(469, 132);
            this.gboxEmployeePay.TabIndex = 8;
            this.gboxEmployeePay.TabStop = false;
            this.gboxEmployeePay.Text = "Employee Pay";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(497, 220);
            this.Controls.Add(this.gboxEmployeePay);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculatePay);
            this.Name = "frmMain";
            this.Text = "Shaiju Rajan";
            this.gboxEmployeePay.ResumeLayout(false);
            this.gboxEmployeePay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.Label lblDIsplay;
        private System.Windows.Forms.TextBox txtHourlyRate;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.Button btnCalculatePay;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gboxEmployeePay;
    }
}


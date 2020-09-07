namespace TelRazgovor
{
    partial class TelRazgovor
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDlitRazg = new System.Windows.Forms.Label();
            this.lblNumNed = new System.Windows.Forms.Label();
            this.txtBDlitRazg = new System.Windows.Forms.TextBox();
            this.txtBNumNed = new System.Windows.Forms.TextBox();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDlitRazg
            // 
            this.lblDlitRazg.AutoSize = true;
            this.lblDlitRazg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDlitRazg.Location = new System.Drawing.Point(52, 66);
            this.lblDlitRazg.Name = "lblDlitRazg";
            this.lblDlitRazg.Size = new System.Drawing.Size(126, 40);
            this.lblDlitRazg.TabIndex = 0;
            this.lblDlitRazg.Text = "Длительность\r\nразговора(мин)";
            this.lblDlitRazg.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNumNed
            // 
            this.lblNumNed.AutoSize = true;
            this.lblNumNed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumNed.Location = new System.Drawing.Point(52, 172);
            this.lblNumNed.Name = "lblNumNed";
            this.lblNumNed.Size = new System.Drawing.Size(154, 20);
            this.lblNumNed.TabIndex = 1;
            this.lblNumNed.Text = "Номер для недели\r\n";
            // 
            // txtBDlitRazg
            // 
            this.txtBDlitRazg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBDlitRazg.Location = new System.Drawing.Point(278, 80);
            this.txtBDlitRazg.Name = "txtBDlitRazg";
            this.txtBDlitRazg.Size = new System.Drawing.Size(100, 26);
            this.txtBDlitRazg.TabIndex = 2;
            this.txtBDlitRazg.TextChanged += new System.EventHandler(this.txtBDlitRazg_TextChanged);
            this.txtBDlitRazg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBDlitRazg_KeyPress);
            // 
            // txtBNumNed
            // 
            this.txtBNumNed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBNumNed.Location = new System.Drawing.Point(278, 166);
            this.txtBNumNed.Name = "txtBNumNed";
            this.txtBNumNed.Size = new System.Drawing.Size(100, 26);
            this.txtBNumNed.TabIndex = 3;
            this.txtBNumNed.TextChanged += new System.EventHandler(this.txtBNumNed_TextChanged);
            this.txtBNumNed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBNumNed_KeyPress);
            // 
            // btnEquals
            // 
            this.btnEquals.Enabled = false;
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEquals.Location = new System.Drawing.Point(47, 267);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(116, 35);
            this.btnEquals.TabIndex = 4;
            this.btnEquals.Text = "Вычисление";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(345, 267);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 35);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // TelRazgovor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 331);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.txtBNumNed);
            this.Controls.Add(this.txtBDlitRazg);
            this.Controls.Add(this.lblNumNed);
            this.Controls.Add(this.lblDlitRazg);
            this.Name = "TelRazgovor";
            this.Text = "Телефонный разговор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDlitRazg;
        private System.Windows.Forms.Label lblNumNed;
        private System.Windows.Forms.TextBox txtBDlitRazg;
        private System.Windows.Forms.TextBox txtBNumNed;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnExit;
    }
}


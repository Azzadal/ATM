namespace ATM
{
    partial class ATM
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
            this.input = new System.Windows.Forms.TextBox();
            this.getCash = new System.Windows.Forms.Button();
            this.check5000 = new System.Windows.Forms.CheckBox();
            this.check2000 = new System.Windows.Forms.CheckBox();
            this.check1000 = new System.Windows.Forms.CheckBox();
            this.check500 = new System.Windows.Forms.CheckBox();
            this.check200 = new System.Windows.Forms.CheckBox();
            this.check100 = new System.Windows.Forms.CheckBox();
            this.check50 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(87, 59);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(132, 20);
            this.input.TabIndex = 0;
            // 
            // getCash
            // 
            this.getCash.Location = new System.Drawing.Point(87, 86);
            this.getCash.Name = "getCash";
            this.getCash.Size = new System.Drawing.Size(75, 23);
            this.getCash.TabIndex = 1;
            this.getCash.Text = "getCash";
            this.getCash.UseVisualStyleBackColor = true;
            this.getCash.Click += new System.EventHandler(this.getCash_Click);
            // 
            // check5000
            // 
            this.check5000.AutoSize = true;
            this.check5000.Location = new System.Drawing.Point(74, 186);
            this.check5000.Name = "check5000";
            this.check5000.Size = new System.Drawing.Size(50, 17);
            this.check5000.TabIndex = 2;
            this.check5000.Text = "5000";
            this.check5000.UseVisualStyleBackColor = true;
            this.check5000.CheckedChanged += new System.EventHandler(this.check5000_CheckedChanged);
            // 
            // check2000
            // 
            this.check2000.AutoSize = true;
            this.check2000.Location = new System.Drawing.Point(74, 209);
            this.check2000.Name = "check2000";
            this.check2000.Size = new System.Drawing.Size(50, 17);
            this.check2000.TabIndex = 3;
            this.check2000.Text = "2000";
            this.check2000.UseVisualStyleBackColor = true;
            this.check2000.CheckedChanged += new System.EventHandler(this.check2000_CheckedChanged);
            // 
            // check1000
            // 
            this.check1000.AutoSize = true;
            this.check1000.Location = new System.Drawing.Point(74, 233);
            this.check1000.Name = "check1000";
            this.check1000.Size = new System.Drawing.Size(50, 17);
            this.check1000.TabIndex = 4;
            this.check1000.Text = "1000";
            this.check1000.UseVisualStyleBackColor = true;
            this.check1000.CheckedChanged += new System.EventHandler(this.check1000_CheckedChanged);
            // 
            // check500
            // 
            this.check500.AutoSize = true;
            this.check500.Location = new System.Drawing.Point(74, 257);
            this.check500.Name = "check500";
            this.check500.Size = new System.Drawing.Size(44, 17);
            this.check500.TabIndex = 5;
            this.check500.Text = "500";
            this.check500.UseVisualStyleBackColor = true;
            this.check500.CheckedChanged += new System.EventHandler(this.check500_CheckedChanged);
            // 
            // check200
            // 
            this.check200.AutoSize = true;
            this.check200.Location = new System.Drawing.Point(74, 281);
            this.check200.Name = "check200";
            this.check200.Size = new System.Drawing.Size(44, 17);
            this.check200.TabIndex = 6;
            this.check200.Text = "200";
            this.check200.UseVisualStyleBackColor = true;
            this.check200.CheckedChanged += new System.EventHandler(this.check200_CheckedChanged);
            // 
            // check100
            // 
            this.check100.AutoSize = true;
            this.check100.Location = new System.Drawing.Point(74, 305);
            this.check100.Name = "check100";
            this.check100.Size = new System.Drawing.Size(44, 17);
            this.check100.TabIndex = 7;
            this.check100.Text = "100";
            this.check100.UseVisualStyleBackColor = true;
            this.check100.CheckedChanged += new System.EventHandler(this.check100_CheckedChanged);
            // 
            // check50
            // 
            this.check50.AutoSize = true;
            this.check50.Location = new System.Drawing.Point(74, 329);
            this.check50.Name = "check50";
            this.check50.Size = new System.Drawing.Size(38, 17);
            this.check50.TabIndex = 8;
            this.check50.Text = "50";
            this.check50.UseVisualStyleBackColor = true;
            this.check50.CheckedChanged += new System.EventHandler(this.check50_CheckedChanged);
            // 
            // ATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.check50);
            this.Controls.Add(this.check100);
            this.Controls.Add(this.check200);
            this.Controls.Add(this.check500);
            this.Controls.Add(this.check1000);
            this.Controls.Add(this.check2000);
            this.Controls.Add(this.check5000);
            this.Controls.Add(this.getCash);
            this.Controls.Add(this.input);
            this.Name = "ATM";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button getCash;
        private System.Windows.Forms.CheckBox check5000;
        private System.Windows.Forms.CheckBox check2000;
        private System.Windows.Forms.CheckBox check1000;
        private System.Windows.Forms.CheckBox check500;
        private System.Windows.Forms.CheckBox check200;
        private System.Windows.Forms.CheckBox check100;
        private System.Windows.Forms.CheckBox check50;
    }
}


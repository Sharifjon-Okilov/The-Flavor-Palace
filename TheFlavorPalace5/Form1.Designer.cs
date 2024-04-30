namespace TheFlavorPalace5
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.drinks = new System.Windows.Forms.ComboBox();
            this.txtEggQuant = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChickQuant = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblEggQuality = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.lbl_EggQuality = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSendRequest = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Coral;
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.drinks);
            this.groupBox1.Controls.Add(this.txtEggQuant);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtChickQuant);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(23, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtCustomerName.Location = new System.Drawing.Point(184, 76);
            this.txtCustomerName.Multiline = true;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(109, 23);
            this.txtCustomerName.TabIndex = 5;
            // 
            // drinks
            // 
            this.drinks.BackColor = System.Drawing.Color.LavenderBlush;
            this.drinks.FormattingEnabled = true;
            this.drinks.Location = new System.Drawing.Point(184, 33);
            this.drinks.Name = "drinks";
            this.drinks.Size = new System.Drawing.Size(109, 21);
            this.drinks.TabIndex = 4;
            this.drinks.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtEggQuant
            // 
            this.txtEggQuant.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtEggQuant.Location = new System.Drawing.Point(126, 47);
            this.txtEggQuant.Multiline = true;
            this.txtEggQuant.Name = "txtEggQuant";
            this.txtEggQuant.Size = new System.Drawing.Size(37, 23);
            this.txtEggQuant.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "How many egg?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "How many chicken?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtChickQuant
            // 
            this.txtChickQuant.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtChickQuant.Location = new System.Drawing.Point(126, 17);
            this.txtChickQuant.Multiline = true;
            this.txtChickQuant.Name = "txtChickQuant";
            this.txtChickQuant.Size = new System.Drawing.Size(37, 23);
            this.txtChickQuant.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Lavender;
            this.btnSubmit.Location = new System.Drawing.Point(19, 76);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(155, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Receive this request from a:";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblEggQuality
            // 
            this.lblEggQuality.AutoSize = true;
            this.lblEggQuality.Location = new System.Drawing.Point(90, 187);
            this.lblEggQuality.Name = "lblEggQuality";
            this.lblEggQuality.Size = new System.Drawing.Size(0, 13);
            this.lblEggQuality.TabIndex = 6;
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(23, 207);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(317, 173);
            this.listBox.TabIndex = 8;
            // 
            // lbl_EggQuality
            // 
            this.lbl_EggQuality.AutoSize = true;
            this.lbl_EggQuality.Location = new System.Drawing.Point(90, 174);
            this.lbl_EggQuality.Name = "lbl_EggQuality";
            this.lbl_EggQuality.Size = new System.Drawing.Size(0, 13);
            this.lbl_EggQuality.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Result";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnSendRequest
            // 
            this.btnSendRequest.BackColor = System.Drawing.Color.Lavender;
            this.btnSendRequest.Location = new System.Drawing.Point(78, 136);
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.Size = new System.Drawing.Size(205, 23);
            this.btnSendRequest.TabIndex = 11;
            this.btnSendRequest.Text = "Send all Customer request to the Cook";
            this.btnSendRequest.UseVisualStyleBackColor = false;
            this.btnSendRequest.Click += new System.EventHandler(this.btnSendRequest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(365, 400);
            this.Controls.Add(this.btnSendRequest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_EggQuality);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.lblEggQuality);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtChickQuant;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblEggQuality;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label lbl_EggQuality;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox drinks;
        private System.Windows.Forms.TextBox txtEggQuant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSendRequest;
        private System.Windows.Forms.TextBox txtCustomerName;
    }
}


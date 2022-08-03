namespace CPAstertaxer
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelInNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBoxIPconAMI = new System.Windows.Forms.TextBox();
            this.textBox1InAgentNum = new System.Windows.Forms.TextBox();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.buttonConAMI = new System.Windows.Forms.Button();
            this.buttonDelQue = new System.Windows.Forms.Button();
            this.buttonWhoQue = new System.Windows.Forms.Button();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPasswd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.dataGridViewQueue = new System.Windows.Forms.DataGridView();
            this.buttonAgentsDBase = new System.Windows.Forms.Button();
            this.textBoxNamedBase = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUserBase = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPasswdBase = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.buttonAgentAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQueue)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInNum
            // 
            this.labelInNum.AutoSize = true;
            this.labelInNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInNum.Location = new System.Drawing.Point(12, 204);
            this.labelInNum.Name = "labelInNum";
            this.labelInNum.Size = new System.Drawing.Size(167, 13);
            this.labelInNum.TabIndex = 15;
            this.labelInNum.Text = "Номер таксиста (Number of taxi)";
            this.labelInNum.Click += new System.EventHandler(this.labelInNum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "IP-адрес Диспетчера (IP address)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 64);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 17);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "192.168.1.79";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBoxIPconAMI
            // 
            this.textBoxIPconAMI.Location = new System.Drawing.Point(15, 42);
            this.textBoxIPconAMI.Name = "textBoxIPconAMI";
            this.textBoxIPconAMI.Size = new System.Drawing.Size(198, 20);
            this.textBoxIPconAMI.TabIndex = 29;
            this.textBoxIPconAMI.TextChanged += new System.EventHandler(this.textBoxIPconAMI_TextChanged_1);
            // 
            // textBox1InAgentNum
            // 
            this.textBox1InAgentNum.Location = new System.Drawing.Point(15, 220);
            this.textBox1InAgentNum.Name = "textBox1InAgentNum";
            this.textBox1InAgentNum.Size = new System.Drawing.Size(198, 20);
            this.textBox1InAgentNum.TabIndex = 30;
            this.textBox1InAgentNum.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAbout.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonAbout.Location = new System.Drawing.Point(360, 313);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(114, 38);
            this.buttonAbout.TabIndex = 32;
            this.buttonAbout.Text = "О программе\r\n(About)";
            this.buttonAbout.UseVisualStyleBackColor = false;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(119, 64);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(89, 17);
            this.checkBox2.TabIndex = 36;
            this.checkBox2.Text = "192.168.1.69";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_1);
            // 
            // buttonConAMI
            // 
            this.buttonConAMI.BackColor = System.Drawing.Color.DarkBlue;
            this.buttonConAMI.Location = new System.Drawing.Point(228, 25);
            this.buttonConAMI.Name = "buttonConAMI";
            this.buttonConAMI.Size = new System.Drawing.Size(114, 74);
            this.buttonConAMI.TabIndex = 23;
            this.buttonConAMI.Text = "Добавить таксиста в очередь \r\n(Add taxi in queue)";
            this.buttonConAMI.UseVisualStyleBackColor = false;
            this.buttonConAMI.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonDelQue
            // 
            this.buttonDelQue.BackColor = System.Drawing.Color.Red;
            this.buttonDelQue.Location = new System.Drawing.Point(228, 177);
            this.buttonDelQue.Name = "buttonDelQue";
            this.buttonDelQue.Size = new System.Drawing.Size(114, 74);
            this.buttonDelQue.TabIndex = 1;
            this.buttonDelQue.Text = "Удалить таксиста из очереди\r\n(Delete taxi from queue)";
            this.buttonDelQue.UseVisualStyleBackColor = false;
            this.buttonDelQue.Click += new System.EventHandler(this.buttonDelQue_Click);
            // 
            // buttonWhoQue
            // 
            this.buttonWhoQue.BackColor = System.Drawing.Color.Blue;
            this.buttonWhoQue.Location = new System.Drawing.Point(228, 101);
            this.buttonWhoQue.Name = "buttonWhoQue";
            this.buttonWhoQue.Size = new System.Drawing.Size(114, 74);
            this.buttonWhoQue.TabIndex = 10;
            this.buttonWhoQue.Text = "Кто в очереди\r\n(Who is queue)";
            this.buttonWhoQue.UseVisualStyleBackColor = false;
            this.buttonWhoQue.Click += new System.EventHandler(this.buttonWhoQue_Click);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(15, 114);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(166, 20);
            this.textBoxLogin.TabIndex = 37;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            // 
            // textBoxPasswd
            // 
            this.textBoxPasswd.Location = new System.Drawing.Point(15, 168);
            this.textBoxPasswd.Name = "textBoxPasswd";
            this.textBoxPasswd.Size = new System.Drawing.Size(166, 20);
            this.textBoxPasswd.TabIndex = 38;
            this.textBoxPasswd.TextChanged += new System.EventHandler(this.textBoxPasswd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Логин (Login)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Пароль (Password)";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(119, 96);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(44, 17);
            this.checkBox3.TabIndex = 41;
            this.checkBox3.Text = "root";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(119, 150);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(49, 17);
            this.checkBox4.TabIndex = 42;
            this.checkBox4.Text = "taxer";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // dataGridViewQueue
            // 
            this.dataGridViewQueue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQueue.Location = new System.Drawing.Point(12, 257);
            this.dataGridViewQueue.Name = "dataGridViewQueue";
            this.dataGridViewQueue.Size = new System.Drawing.Size(330, 97);
            this.dataGridViewQueue.TabIndex = 43;
            this.dataGridViewQueue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQueue_CellContentClick_2);
            // 
            // buttonAgentsDBase
            // 
            this.buttonAgentsDBase.BackColor = System.Drawing.Color.Blue;
            this.buttonAgentsDBase.Location = new System.Drawing.Point(360, 101);
            this.buttonAgentsDBase.Name = "buttonAgentsDBase";
            this.buttonAgentsDBase.Size = new System.Drawing.Size(114, 74);
            this.buttonAgentsDBase.TabIndex = 46;
            this.buttonAgentsDBase.Text = "Кто из таксистов зарегистрирован в Диспетчере (Who is registered to Dispetcher)";
            this.buttonAgentsDBase.UseVisualStyleBackColor = false;
            this.buttonAgentsDBase.Click += new System.EventHandler(this.buttonAgentsDBase_Click);
            // 
            // textBoxNamedBase
            // 
            this.textBoxNamedBase.Location = new System.Drawing.Point(584, 42);
            this.textBoxNamedBase.Name = "textBoxNamedBase";
            this.textBoxNamedBase.Size = new System.Drawing.Size(166, 20);
            this.textBoxNamedBase.TabIndex = 47;
            this.textBoxNamedBase.TextChanged += new System.EventHandler(this.textBoxNamedBase_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(581, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Имя БД (Name of dBase)";
            // 
            // textBoxUserBase
            // 
            this.textBoxUserBase.Location = new System.Drawing.Point(584, 114);
            this.textBoxUserBase.Name = "textBoxUserBase";
            this.textBoxUserBase.Size = new System.Drawing.Size(167, 20);
            this.textBoxUserBase.TabIndex = 49;
            this.textBoxUserBase.TextChanged += new System.EventHandler(this.textBoxUserBase_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(581, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Имя юзера (Name of user dBase)";
            // 
            // textBoxPasswdBase
            // 
            this.textBoxPasswdBase.Location = new System.Drawing.Point(584, 168);
            this.textBoxPasswdBase.Name = "textBoxPasswdBase";
            this.textBoxPasswdBase.Size = new System.Drawing.Size(166, 20);
            this.textBoxPasswdBase.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(582, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Пароль (Password of user dBase)";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(584, 64);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(62, 17);
            this.checkBox5.TabIndex = 53;
            this.checkBox5.Text = "asterisk";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // buttonAgentAdd
            // 
            this.buttonAgentAdd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAgentAdd.Location = new System.Drawing.Point(360, 25);
            this.buttonAgentAdd.Name = "buttonAgentAdd";
            this.buttonAgentAdd.Size = new System.Drawing.Size(114, 74);
            this.buttonAgentAdd.TabIndex = 54;
            this.buttonAgentAdd.Text = "Зарегистрировать таксиста в Диспетчере (Registering in Dispetcher)";
            this.buttonAgentAdd.UseVisualStyleBackColor = false;
            this.buttonAgentAdd.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(763, 363);
            this.Controls.Add(this.buttonAgentAdd);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxPasswdBase);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxUserBase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxNamedBase);
            this.Controls.Add(this.buttonAgentsDBase);
            this.Controls.Add(this.dataGridViewQueue);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPasswd);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.buttonWhoQue);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.buttonDelQue);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonConAMI);
            this.Controls.Add(this.textBox1InAgentNum);
            this.Controls.Add(this.textBoxIPconAMI);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelInNum);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CPAstertaxer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQueue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBoxIPconAMI;
        private System.Windows.Forms.TextBox textBox1InAgentNum;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button buttonConAMI;
        private System.Windows.Forms.Button buttonDelQue;
        private System.Windows.Forms.Button buttonWhoQue;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPasswd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        public System.Windows.Forms.DataGridView dataGridViewQueue;
        private System.Windows.Forms.Button buttonAgentsDBase;
        private System.Windows.Forms.TextBox textBoxNamedBase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxUserBase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPasswdBase;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Button buttonAgentAdd;
    }
}


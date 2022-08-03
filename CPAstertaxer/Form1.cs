using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Data.OleDb;

namespace CPAstertaxer
{
    public partial class Form1 : Form
    {
        public string server, DataNum, Login, Password, dBaseName, UserBase, PasswdBase;
        public Int32 port = 5038;
        public Int32 portBase = 3306;
        static class Data
        {
            public static string Res { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCondBase_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) server = "192.168.1.79";
                else server = textBoxIPconAMI.Text;
            if (checkBox2.Checked == true) server = "192.168.1.69";
                else server = textBoxIPconAMI.Text;
            if (checkBox3.Checked == true) Login = "root";
                else Login = textBoxLogin.Text;
            if (checkBox4.Checked == true) Password = "taxer";
                else Password = textBoxPasswd.Text;

                DataNum = textBox1InAgentNum.Text;

                if (server == "" || DataNum == "" || Login == "" || Password == "")
            {
                MessageBox.Show("Введите IP-адрес Диспетчера, логин, пароль, телефон таксиста для добавления в очередь \nInput IP-address Dispatcher of taxi, login, password, phone of agent for add to queue");
                return;
            }
                AMIConnect amicon = new AMIConnect();
                amicon.AMIcon(server, DataNum, Login, Password);
        }

        public string textBoxIPconAMI_TextChanged(object sender, EventArgs e)
        {
            return textBoxIPconAMI.Text;
        }

        private void richTextBoxQue_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridViewDateAMI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void richTextBoxDataAMI_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewDataAMI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void textBoxInNumQue_TextChanged(object sender, EventArgs e)
        {
            
        }

        public string textBox1InAgentNum_TextChanged(object sender, EventArgs e)
        {
            return textBoxIPconAMI.Text;
        }

        private void buttonDelQue_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) server = "192.168.1.79";
                else server = textBoxIPconAMI.Text;
            if (checkBox2.Checked == true) server = "192.168.1.69";
                else server = textBoxIPconAMI.Text;
            if (checkBox3.Checked == true) Login = "root";
                else Login = textBoxLogin.Text;
            if (checkBox4.Checked == true) Password = "taxer";
                else Password = textBoxPasswd.Text;
            //else
                //server = textBoxIPconAMI.Text;
                DataNum = textBox1InAgentNum.Text;
                //Login = textBoxLogin.Text;
                //Password = textBoxPasswd.Text;

                if (server == "" || DataNum == "" || Login == "" || Password == "")
            {
                MessageBox.Show("Введите IP-адрес Диспетчера, логин, пароль, телефон таксиста для удаления из очереди \nInput IP-address Dispatcher of taxi, login, password, phone of agent for delete from queue");
                return;
            }

            AMIDelete amidel = new AMIDelete();
            amidel.AMIdel(server, DataNum, Login, Password);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void buttonWhoQue_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) server = "192.168.1.79";
                else server = textBoxIPconAMI.Text;
            if (checkBox2.Checked == true) server = "192.168.1.69";
                else server = textBoxIPconAMI.Text;
            if (checkBox3.Checked == true) Login = "root";
                else Login = textBoxLogin.Text;
            if (checkBox4.Checked == true) Password = "taxer";
                else Password = textBoxPasswd.Text;
            //else
                //server = textBoxIPconAMI.Text;
                //Login = textBoxLogin.Text;
                //Password = textBoxPasswd.Text;

            if (server == "" || Login == "" || Password == "")
            {
                MessageBox.Show("Введите IP-адрес Диспетчера, логин, пароль \nInput IP-address Dispatcher of taxi, login, password");
                return;
            }
            WhoQueue whoque = new WhoQueue();
            whoque.WhoQue(server);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = true;
            checkBox2.Enabled = false;
            textBoxIPconAMI.Enabled = false;
        }

        public void richTextBoxMySQL_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void richTextBoxAMI_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonClearFieldQue_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonTabAgent_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonInTabAgent_Click(object sender, EventArgs e)
        {

        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\t\nПанель управления Диспетчером такси.\t\nВ данной версии работают три кнопки, добавления в очередь, удаления из очереди и данных кто в очереди.\t\nСочетание клавиш Ctrl+C, копирует в буфер список агентов очереди.\t\nВерсия 1.1 Copyright of Blablatov\t \n\nControl panel for management to Dispatcher of taxi. \t\nIn this version have three buttons for add to queue, delete from queue, data about who is queue \t\nVersion 1.1 Copyright of Blablatov (https//vk.com/astertaxer)");
        }

        public void dataGridViewQueue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void textBoxQueue_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewQueue_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxQueue_TextChanged_1(object sender, EventArgs e)
        {
            //textBoxQueue.Show();
            this.Show();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Enabled = true;
            checkBox1.Enabled = false;
            textBoxIPconAMI.Enabled = false;
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            checkBox2.Enabled = true;
            checkBox1.Enabled = false;
            textBoxIPconAMI.Enabled = false;
        }

        private void textBoxIPconAMI_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPasswd_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox3.Enabled = true;
            textBoxLogin.Enabled = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
           checkBox4.Enabled = true;
           textBoxPasswd.Enabled = false;
        }

        private void labelInNum_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void dataGridViewQueue_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void buttonAgentsDBase_Click(object sender, EventArgs e)
        {
            string marker = "CheckWhoReg";
            if (checkBox1.Checked == true) server = "192.168.1.79";
            else server = textBoxIPconAMI.Text;
            if (checkBox2.Checked == true) server = "192.168.1.69";
            else server = textBoxIPconAMI.Text;
            if (checkBox3.Checked == true) Login = "root";
            else Login = textBoxLogin.Text;
            if (checkBox4.Checked == true) Password = "taxer";
            else Password = textBoxPasswd.Text;
            if (checkBox5.Checked == true) dBaseName = "asterisk";
            else dBaseName = textBoxNamedBase.Text;

            if (server == "" || Login == "" || Password == "" || dBaseName == "")
            {
                MessageBox.Show("Введите IP-адрес Диспетчера, логин, пароль \nInput IP-address Dispatcher of taxi, login, password");
                return;
            }

            MysqlConSelect QueryBase = new MysqlConSelect();
            QueryBase.SelectGet(server, portBase, dBaseName, Login, Password, marker);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            checkBox5.Enabled = true;
            textBoxNamedBase.Enabled = false;
        }

        private void textBoxNamedBase_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUserBase_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            //string marker = "RegToDB";
            if (checkBox1.Checked == true) server = "192.168.1.79";
            else server = textBoxIPconAMI.Text;
            if (checkBox2.Checked == true) server = "192.168.1.69";
            else server = textBoxIPconAMI.Text;
            if (checkBox3.Checked == true) Login = "root";
            else Login = textBoxLogin.Text;
            if (checkBox4.Checked == true) Password = "taxer";
            else Password = textBoxPasswd.Text;
            if (checkBox5.Checked == true) dBaseName = "asterisk";
            else dBaseName = textBoxNamedBase.Text;

            DataNum = textBox1InAgentNum.Text;

            if (server == "" || Login == "" || Password == "" || dBaseName == "" || DataNum == "")
            {
                MessageBox.Show("Введите IP-адрес Диспетчера, логин, пароль, телефон таксиста для регистрации в диспетчере \nInput IP-address, login, password phone of agent for add to Dispatcher of taxi");
                return;
            }

            MysqlConInsert InsertBase = new MysqlConInsert();
            InsertBase.InsertSet(server, portBase, dBaseName, Login, Password, DataNum);
        }
    }
}

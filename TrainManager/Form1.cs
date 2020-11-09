using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace TrainManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string password;
        string login;
        public void WriteToFile(string login, string password)
        {
            string pass = "..\\..\\Info.txt";
            if (File.Exists(pass))
            {
                File.Delete(pass);
                using (BinaryWriter writer = new BinaryWriter(new FileStream(pass, FileMode.OpenOrCreate)))
                {
                  
                    writer.Write(Encode(login));
                    writer.Write(Encode(password));
                }
            }
        }
        public void ReadFromFile()
        {
            string pass = "..\\..\\Info.txt";
            if (File.Exists(pass))
            {
                using (BinaryReader reader = new BinaryReader(new FileStream(pass, FileMode.OpenOrCreate)))
                {
                    
                    login = reader.ReadString();
                    password = reader.ReadString();
                }
            }
        }
        string Encode(string text)
        {
            StringBuilder line= new StringBuilder();
            
            for (int i = 0; i < text.Length; i++)
            {
                line.Append((char)(text[i] + 3));
            }
            return line.ToString();
        }
        string Decode(string text)
        {
            StringBuilder line = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                line.Append((char)(text[i] - 3));
            }
            return line.ToString();
        }
        private void btnLog_Click(object sender, EventArgs e)
        {
            WriteToFile("Admin", "Admin");
            ReadFromFile();
            if (logBox.Text == Decode(login) && passBox.Text == Decode(password))
            {
                trainForm trForm = new trainForm();
                trForm.Show();
                this.Hide();
                atention.Visible = false;
                trForm.FormClosing += TrainForm_FormClosing;
            }
            else
            {
                atention.Visible = true;
                logBox.Clear();
                passBox.Clear();
            }
          
        }
        private void TrainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trainForm trForm = new trainForm();
            trForm.Show();
            this.Hide();
            atention.Visible = false;
            trForm.FormClosing += TrainForm_FormClosing;
            trForm.doUserView();
        }
    }
}

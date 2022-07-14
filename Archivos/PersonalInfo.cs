using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivos
{
    public partial class PersonalInfo : Form
    {
        private string Line;
        private readonly string RouteFile = "data.txt"; 
        public PersonalInfo()
        {
            InitializeComponent();
            Line = String.Empty;
            if (!File.Exists(RouteFile))
            {
                StreamWriter Writer = new(RouteFile, true);
                Writer.WriteLine("Name,Lastname,Identification");
                Writer.Close();
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty || textBox2.Text != String.Empty || textBox3.Text != String.Empty)
            {
                Line = String.Format("{0},{1},{2}", textBox1.Text, textBox2.Text, textBox3.Text);
            }
            if (Line != String.Empty)
            {
                StreamWriter Writer = new(RouteFile, true);
                Writer.WriteLine(Line);
                MessageBox.Show("Line Saved");
                Writer.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader Reader = new(RouteFile);
            string? Line = Reader.ReadLine();
            bool wasFound = false;
            while (Line != null)
            {
                string[] fields = Line.Split(',');
                if (fields[2] == textBox4.Text)
                {
                    textBox5.Text = fields[0];
                    textBox6.Text = fields[1];
                    wasFound = true;
                    break;
                }
                Line = Reader.ReadLine();
            } 
            if(!wasFound)
            {
                textBox5.Text = String.Empty;
                textBox6.Text = String.Empty;
            }
            Reader.Close();
        }
    }
}

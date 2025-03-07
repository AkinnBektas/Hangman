using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _152120211066_152120211068
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> siparişler = new List<string> ();
        int siparişlerSayi = 0;
        List<string> pilavlarrrrrrrr = new List<string> {"Sade Pilav (Porsiyon)",
                                                         "Nohutlu Pilav (Porsiyon)",
                                                         "Mercimekli Pilav (Porsiyon)",
                                                         "Fasulyeli Pilav (Porsiyon)",
                                                         "Bezelyeli Pilav (Porsiyon)",
                                                         "Tavuklu Pilav (Porsiyon)",
                                                         "Dönerli Pilav (Porsiyon)",
                                                         "Kavurmalı Pilav (Porsiyon)",
                                                         "Biftekli Pilav (Porsiyon)",
                                                         "Kestaneli Pilav (Porsiyon)",
                                                         "Acem Pilav (Porsiyon)",
                                                         "Özbek Pilav (Porsiyon)",
                                                         "Maklube}" };
        List<string> iller = new List<string> { "Eskişehir", "Bursa" };

        public int shoeSize()
        {
            
            return 5;
        }

        private bool IsLet(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (!char.IsLetter(c) || c == ' ')
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsNumeric(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (!char.IsDigit(c) || c == ' ')
                {
                    return false;
                }
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string i in iller)
            {
                comboBoxİl.Items.Add(i);
            }

            foreach (string y in pilavlarrrrrrrr)
            {
                comboBoxYemek.Items.Add(y);
            }
        }

        List<string> esk = new List<string> {"Odunpazarı", "Tepebaşı"};
        List<string> bursa = new List<string> {"Osmangazi", "Nilüfer" };

        private void comboBoxİl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxİl.SelectedIndex == 0)
            {
                comboBoxİlçe.Items.Clear();
                foreach (string s in esk)
                {
                    comboBoxİlçe.Items.Add(s);
                }
            }
            else if(comboBoxİl.SelectedIndex == 1)
            {
                comboBoxİlçe.Items.Clear();
                foreach (string s in bursa)
                {
                    comboBoxİlçe.Items.Add(s);
                }
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (!IsLet(textBoxName.Text))
            {
                MessageBox.Show(textBoxName.Text + " is not valid key", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxName.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(numericUpDown1.Value == 0)
            {
                MessageBox.Show("Bir porsiyon seçmeniz gerekmektedir", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                siparişler.Add("!");
                siparişler.Add(DateTime.Now.ToString());
                siparişler.Add(textBoxName.Text);
                siparişler.Add(textBoxTel.Text);
                siparişler.Add(comboBoxYemek.SelectedItem.ToString() + " " + numericUpDown1.Value.ToString());
                siparişler.Add(comboBoxİl.SelectedItem.ToString());
                siparişler.Add(comboBoxİlçe.SelectedItem.ToString());
               
                siparişlerSayi++;

                comboBoxSiparişler.Items.Add((siparişlerSayi).ToString() + ". Sipariş");
                
                textBoxName.Clear();
                textBoxTel.Clear();
                comboBoxYemek.SelectedIndex = -1;
                comboBoxİl.SelectedIndex = -1;
                comboBoxİlçe.SelectedIndex = -1;
            }
        }

        private void textBoxTel_TextChanged(object sender, EventArgs e)
        {
            if (!IsNumeric(textBoxTel.Text))
            {
                MessageBox.Show("", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxTel.Clear();
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.DeepSkyBlue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightSkyBlue;
        }

        private void comboBoxSiparişler_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Text = "";
            int wanted = comboBoxSiparişler.SelectedIndex + 1;
            int flag = 0 , i= 0;

            while(flag < wanted)
            {
                if (siparişler[i] == "!")
                {
                    flag++;
                }
                i++;
            }

            for(int j = i; j < i+6;j++)
            {
                label5.Text += siparişler[j] + Environment.NewLine;
            }
        }
    }
}

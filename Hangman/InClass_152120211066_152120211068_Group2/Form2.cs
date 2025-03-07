using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace InClass_152120211066_152120211068_Group2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            radioKolay.Checked = true;
            radioSüresiz.Checked = true;
            radioEvet.Checked = true;
        }
       
        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            string filepath = "ayarlar.txt";
            string line = string.Empty;

            line = comboBox1.SelectedItem.ToString().ToUpper() + ",";

            if (radioKolay.Checked)
            {
                line += "KOLAY" + ",";
            }
            if (radioOrta.Checked)
            {
                line += "ORTA" + ",";
            }
            if (radioZor.Checked)
            {
                line += "ZOR" + ",";
            }

            if (radioSüresiz.Checked)
            {
                line += "SÜRESİZ" + ",";
            }
            if (radioSüreli.Checked)
            {
                line += "SÜRELİ" + ",";
            }

            if (radioEvet.Checked)
            {
                line += "İPUÇLU" + ",";
            }
            if (radioHayır.Checked)
            {
                line += "İPUÇSUZ" + ",";
            }

            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filepath, true))
                {                    
                    file.WriteLine(line);
                }                
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Bir hata oluştu", ex);
            }

            oyun oyun = new oyun();
            oyun.Show();
            this.Hide();
        }
    }
}

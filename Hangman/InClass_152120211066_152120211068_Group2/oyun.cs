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
using InClass_152120211066_152120211068_Group2.Properties;
using System.Runtime;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace InClass_152120211066_152120211068_Group2
{
    public partial class oyun : Form
    {
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

        public oyun()
        {
            InitializeComponent();
            timer1.Start();
            timer1.Interval = 1000;
        }

        int puan = 100;
        int image = 0;
        int remainingTime = 30;
        bool timerStart = true;

        static Random rnd = new Random();
        int randomSayi = 0;

        static List<string> words = new List<string> { "baker", "school", "phone", "animal", "computer", "medicine", "kitchen" };

        static List<string> clues = new List<string> { "A person who makes bread, cakes, and pastries.",
                                                "Learn and Study.",
                                                "It is used to communicate.",
                                                "A living creature.",
                                                "An electronic device for storing and processing data.",
                                                "Substances used for cure diseases.",
                                                "A room or area where food is prepared and cooked."};

        static List<string> wordsB = new List<string> { "sun", "light ", "energy", "biology", "density", "ecosystem", "photosynthesis", "sustainability", "biochemistry" };

        static List<string> cluesB = new List<string> {
                                                "The star at the center of our solar system.",
                                                "The natural agent that makes things visible.",
                                                "The ability to do work or cause change.",
                                                "The study of living organisms and their interactions with each other and their environments.",
                                                "The mass per unit volume of a substance.",
                                                "Community of living organisms",
                                                "The process by which green plants and some other organisms use sunlight to synthesize foods.",
                                                "The ability to maintain or endure something over the long term.",
                                                "The branch of science that deals with the chemical processes and substances in living organisms."};

        static List<string> wordsH = new List<string> { "cat", "dog", "fish", "elephant ", "butterfly ", "alligator ", "hippopotamus", "hummingbird", "porcupinefish " };

        static List<string> cluesH = new List<string> {
                                                "Soft fur, a short snout, and retractable claws.",
                                                "Barking, howling, or whining",
                                                "A limbless cold-blooded vertebrate animal with gills and fins living wholly in water.",
                                                "Long trunk, tusks, and large ears",
                                                "Flying insect with large, often colorful wings",
                                                "A large reptile with a broad head and powerful jaws, found in freshwater habitats.",
                                                "A large, herbivorous mammal with a barrel-shaped body, short legs, and a large mouth, found in sub-Saharan Africa.",
                                                "A small colorful bird with a long slender bill and the ability to hover in mid-air while feeding on nectar." ,
                                                "A spiny-bodied fish with the ability to inflate itself when threatened, found in tropical seas."};

        static List<string> wordsT = new List<string> { "mouse", "device", "button", "keyboard", "software", "download", "headphones", "cybersecurity ", "programming" };

        static List<string> cluesT = new List<string> {
                                        "A pointing device used to interact with a computer.",
                                        "Any piece of equipment or machinery that has a specific function.",
                                        "A small, usually circular object on a device that can be pressed to perform a specific action.",
                                        "A set of keys on a computer or typewriter that you press to produce letters, numbers, or symbols.",
                                        "Programs and other operating information used by a computer.",
                                        "The process of receiving data from a remote system, typically a server, to a local system, such as a computer or smartphone.",
                                        "A pair of small speakers worn over the ears, typically to listen to audio from a computer, music player, or other electronic device without disturbing others.",
                                        "refers to the practice of protecting computer systems, networks, and data from digital attacks.",
                                        "The process of creating a set of instructions that tell a computer how to perform a task, often referred to as coding."};

        static List<string> wrongGueses = new List<string>();

        string word = string.Empty;
        string clue = string.Empty;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (File.Exists("ayarlar.txt"))
            {
                string settings = string.Empty;

                using (StreamReader reader = new StreamReader("ayarlar.txt"))
                {
                    settings = reader.ReadLine();
                }


                settings = settings.Substring(0, settings.Length - 1);

                string[] settingParts = settings.Split(',');

                string category = settingParts[0];
                string difficulty = settingParts[1];
                string time = settingParts[2];
                string clueE = settingParts[3];


                if (timer1.Enabled)
                {
                    if (clueE == "İPUÇSUZ")
                    {
                        buttonİpucu.Visible = false;
                    }
                    if (time == "SÜRESİZ")
                    {
                        timer1.Stop();
                        label4.Visible = false;
                    }

                    if (timerStart)
                    {
                        if (difficulty == "KOLAY")
                        {
                            randomSayi = rnd.Next(0, 2);
                        }
                        if(difficulty == "ORTA")
                        {
                            randomSayi = rnd.Next(3, 5);
                        }
                        if(difficulty == "ZOR")
                        {
                            randomSayi = rnd.Next(6, 8);
                        }
                        if(category == "BİLİM")
                        {
                            word = wordsB[randomSayi];
                            clue = cluesB[randomSayi];
                        }
                        if (category == "TEKNOLOJİ")
                        {
                            word = wordsT[randomSayi];
                            clue = cluesT[randomSayi];
                        }
                        if (category == "HAYVAN")
                        {
                            word = wordsH[randomSayi];
                            clue = cluesH[randomSayi];
                        }                       

                        label4.Text = "Süre: " + remainingTime;
                        label3.Text = settings;
                        string hidden = "";
                        for (int i = 0; i < word.Length; i++)
                        {
                            hidden += "_";
                            hidden += " ";
                        }
                        hidden.Trim();
                        labelLength.Text = "Kelime Uzunluğu: " + word.Length;
                        labelWord.Text = hidden;

                        timerStart = false;
                    }
                    remainingTime--;
                    label4.Text = "Süre: " + remainingTime;
                    if (remainingTime == 0)
                    {
                        this.BackColor = Color.Red;
                        timer1.Stop();
                        DialogResult result = MessageBox.Show("Süre Bitti! Oyunu kaybettin, yeniden oynamak ister misin?", "Oyunu Kaybettin!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        File.Delete("ayarlar.txt");
                        if (result == DialogResult.Yes)
                        {
                            Application.Restart();
                        }
                        else
                        {
                            Application.Exit();
                        }
                    }
                }
            }
            else
            {
                if (timer1.Enabled)
                {
                    word = words[randomSayi];
                    clue = clues[randomSayi];
                    label4.Visible = false;
                    label3.Text = "Oyun normal ayarlarda başlatıldı!";
                    string hidden = "";
                    for (int i = 0; i < word.Length; i++)
                    {
                        hidden += "_";
                        hidden += " ";
                    }
                    hidden.Trim();
                    labelLength.Text = "Kelime Uzunluğu: " + word.Length;
                    labelWord.Text = hidden;
                    timer1.Stop();
                }
            }

        }


        private void buttonTahmin_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim()=="")
            {
                MessageBox.Show("Lütfen bir karakter giriniz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
            }
            else
            {
                textBox1.Text = textBox1.Text.Trim();
                bool found = false;
                bool alreadyWrong = false;

                string hidden = labelWord.Text;
                hidden = hidden.Replace(" ", "");

                string newHidden = "";

                for (int i = 0; i < word.Length; i++)
                {
                    if (textBox1.Text.ToLower() == word[i].ToString())
                    {
                        newHidden += textBox1.Text.ToLower() + " ";
                        found = true;
                    }
                    else
                    {

                        newHidden += hidden[i] + " ";
                    }
                }
                if (newHidden.Replace(" ", "") == word)
                {
                    textBox1.Clear();

                    labelWord.Text = newHidden;

                    this.BackColor = Color.Green;
                    DialogResult result = MessageBox.Show("Tebrikler oyunu kazandın, yeniden oynamak ister misin?", "Oyunu Kazandın!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    File.Delete("ayarlar.txt");
                    if (result == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }

                if (!found)
                {
                    foreach (string i in wrongGueses)
                    {
                        if (i == textBox1.Text.ToLower())
                        {
                            alreadyWrong = true;
                            break;
                        }
                    }
                    if (!alreadyWrong)
                    {
                        if (puan > 10)
                        {
                            puan -= 10;
                            pictureBox1.Image = Image.FromFile("C:\\Users\\ASUS\\Desktop\\InClass_152120211066_152120211068_Group2\\man-" + image.ToString() + ".jpg");
                            image++;
                            wrongGueses.Add(textBox1.Text);
                            labelWrong.Text += " " + textBox1.Text.ToLower() + ",";
                            labelPuan.Text = "Puan: " + puan + " P";
                        }
                        else
                        {
                            puan -= 10;
                            labelPuan.Text = "Puan: " + puan + " P";
                            pictureBox1.Image = Image.FromFile("C:\\Users\\ASUS\\Desktop\\InClass_152120211066_152120211068_Group2\\man-" + image.ToString() + ".jpg");
                            image++;

                            this.BackColor = Color.Red;
                            DialogResult result = MessageBox.Show("Oyunu kaybettin, yeniden oynamak ister misin?", "Oyunu Kaybettin!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            File.Delete("ayarlar.txt");
                            if (result == DialogResult.Yes)
                            {
                                Application.Restart();
                            }
                            else
                            {
                                Application.Exit();
                            }
                        }
                    }
                }

                textBox1.Clear();

                labelWord.Text = newHidden;
            }
        }

        private void buttonBitir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Oyunu gerçekten bitirmek istiyor musunuz?", "Oyunu Bitir!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                File.Delete("ayarlar.txt");
                Application.Exit();
            }
        }

        private void buttonİpucu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(clue, "İpucu!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!IsLet(textBox1.Text))
            {
                MessageBox.Show(textBox1.Text + " izin verilmeyen karakter", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
            }
        }
        
    }
}

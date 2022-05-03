using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sdfsdf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            
        }

        double suma = 0;
        int j = 0;
        private bool przyciskdalej = false;
        private bool przyciskdalej2 = false;
        int i = 1;
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void button1_Click(object sender, EventArgs e)//PLUS
        {
            double wynik1;
            double wynik2;
            int L, L2, L3, L4;
            


            if (j < 1)//petla jesli za 1 razem zostanie wcisniety przycisk to nie dodaje znaku +
            {


                if//jezeli beda wypelnione 3 pola to oblicza :
                  (int.TryParse(textBox4.Text, out L) && int.TryParse(textBox3.Text, out L2) && int.TryParse(textBox2.Text, out L3))
                {
                   
                    wynik1 = Math.Pow(L, L2);
                    wynik2 = wynik1 * L3;
                    label11.Text = String.Format("{0:f1}", wynik2);

                    suma = suma + wynik2;
                    
                    string wynik = suma.ToString();
                    label10.Text = String.Format("{0:f1}", wynik);



                    //1textbox
                    string newItem =label11.Text;
                    List<String> newItemList = new List<string>();
                    newItemList.Add(newItem);
                    for (int i = 0; i < newItemList.Count; i++)
                    {
                        textBox7.Text += newItemList[i] + "\n"; // this will add the text to your box
                    }
                    //2textbox
                    string newItem3 = textBox2.Text + "*" + textBox4.Text + "^" + textBox3.Text;
                    List<String> newItemList3 = new List<string>();
                    newItemList3.Add(newItem3);
                    for (int i = 0; i < newItemList3.Count; i++)
                    {
                        textBox1.Text += newItemList3[i] + "\n"; // this will add the text to your box
                    }
                    
                    textBox2.Clear();
                    textBox3.Text = String.Format("{0:g1}", L2 - 1);
                    label4.Text = String.Format("{0:g1}", L2 - 1);
                    if (L2 - 1 <= 0)
                    {
                        textBox3.Text = null;
                        label4.Text = null;
                    }


                }//jezeli beda wypelnione 2 pola to:
                else if (int.TryParse(textBox4.Text, out L) && int.TryParse(textBox3.Text, out L2))
                {
                    wynik1 = Math.Pow(L, L2);
                    label11.Text = String.Format("{0:f1}", wynik1);

                    suma = suma + wynik1;
                    string wynik = suma.ToString();
                    label10.Text = String.Format("{0:f1}", wynik);
                    //1textbox
                    //tworzy liste ktora wyswietla ciag znakow w textboxach
                    string newItem =label11.Text;
                    List<String> newItemList = new List<string>();
                    newItemList.Add(newItem);
                    for (int i = 0; i < newItemList.Count; i++)
                    {
                        textBox7.Text += newItemList[i] + "\n"; // this will add the text to your box
                    }
                    //2textbox
                    string newItem3 = textBox4.Text + "^" + textBox3.Text;
                    List<String> newItemList3 = new List<string>();
                    newItemList3.Add(newItem3);
                    for (int i = 0; i < newItemList3.Count; i++)
                    {
                        textBox1.Text += newItemList3[i] + "\n"; // this will add the text to your box
                    }
                    textBox2.Clear();
                    textBox3.Text = String.Format("{0:g1}", L2 - 1);
                    label4.Text = String.Format("{0:g1}", L2 - 1);
                    if (L2 - 1 <= 0)
                    {
                        textBox3.Text = null;
                        label4.Text = null;
                    }
                }


                //jezeli bedzie wypelnione pole wyraz wolny to oblicza:
                else if (int.TryParse(textBox6.Text, out L4))
                {

                    suma = suma + L4;
                    string wynik = suma.ToString();
                    label10.Text = String.Format("{0:f1}", wynik);

                    label11.Text = String.Format("{0:f1}", L4);

                    string newItem = textBox6.Text;
                    List<String> newItemList = new List<string>();
                    newItemList.Add(newItem);
                    for (int i = 0; i < newItemList.Count; i++)
                    {
                        textBox7.Text += newItemList[i] + "\n"; // this will add the text to your box
                    }

                    string newItem2 = textBox6.Text;
                    List<String> newItemList2 = new List<string>();
                    newItemList2.Add(newItem2);
                    for (int i = 0; i < newItemList2.Count; i++)
                    {
                        textBox1.Text += newItemList2[i] + "\n"; // this will add the text to your box
                    }
                    textBox6.Clear();

                }
                j++;
            }


            else//przycisk wcisniety wiecej niz raz
            {

                if//jezeli beda wypelnione 3 pola za po przycisnieciu przycisku 2 raz i wiecej to:
                (int.TryParse(textBox4.Text, out L) && int.TryParse(textBox3.Text, out L2) && int.TryParse(textBox2.Text, out L3))
                {
                    wynik1 = Math.Pow(L, L2);
                    wynik2 = wynik1 * L3;
                    label11.Text = String.Format("{0:f1}", wynik2);

                    suma = suma + wynik2;
                    string wynik = suma.ToString();
                    label10.Text = String.Format("{0:f1}", wynik);
                    //1textbox
                    //tworzy liste ktora wyswietla ciag znakow w textboxach
                    string newItem = "+" + label11.Text;
                    List<String> newItemList = new List<string>();
                    newItemList.Add(newItem);
                    for (int i = 0; i < newItemList.Count; i++)
                    {
                        textBox7.Text += newItemList[i] + "\n"; // this will add the text to your box
                    }
                    //2textbox
                    string newItem3 = "+" + textBox2.Text + "*" + textBox4.Text + "^" + textBox3.Text;
                    List<String> newItemList3 = new List<string>();
                    newItemList3.Add(newItem3);
                    for (int i = 0; i < newItemList3.Count; i++)
                    {
                        textBox1.Text += newItemList3[i] + "\n"; // this will add the text to your box
                    }
                    textBox2.Clear();
                    textBox3.Text = String.Format("{0:g1}", L2 - 1);
                    label4.Text = String.Format("{0:g1}", L2 - 1);
                    if (L2 - 1 <= 0)
                    {
                        textBox3.Text = null;
                        label4.Text = null;
                    }
                }
                //jezeli beda wypelnione 2 pola to :
                else if (int.TryParse(textBox4.Text, out L) && int.TryParse(textBox3.Text, out L2))
                {
                    wynik1 = Math.Pow(L, L2);
                    label11.Text = String.Format("{0:f1}", wynik1);

                    suma = suma + wynik1;
                    string wynik = suma.ToString();
                    label10.Text = String.Format("{0:f1}", wynik);
                    //1textbox
                    //tworzy liste ktora wyswietla ciag znakow w textboxach
                    string newItem = "+" + label11.Text;
                    List<String> newItemList = new List<string>();
                    newItemList.Add(newItem);
                    for (int i = 0; i < newItemList.Count; i++)
                    {
                        textBox7.Text += newItemList[i] + "\n"; // this will add the text to your box
                    }
                    //2textbox
                    string newItem3 = "+" + textBox4.Text + "^" + textBox3.Text;
                    List<String> newItemList3 = new List<string>();
                    newItemList3.Add(newItem3);
                    for (int i = 0; i < newItemList3.Count; i++)
                    {
                        textBox1.Text += newItemList3[i] + "\n"; // this will add the text to your box
                    }
                    textBox2.Clear();
                    textBox3.Text = String.Format("{0:g1}", L2 - 1);
                    label4.Text = String.Format("{0:g1}", L2 - 1);
                    if (L2 - 1 <= 0)
                    {
                        textBox3.Text = null;
                        label4.Text = null;
                    }
                }

                //jezeli bedzie wypelniony wyraz wolny :
                else if (int.TryParse(textBox6.Text, out L4))
                {

                    suma = suma + L4;
                    string wynik = suma.ToString();
                    label10.Text = String.Format("{0:f1}", wynik);
                    int.TryParse(textBox6.Text, out L4);
                    label11.Text = String.Format("{0:f1}", L4);
                    //lista
                    string newItem = "+" + textBox6.Text;
                    List<String> newItemList = new List<string>();
                    newItemList.Add(newItem);
                    for (int i = 0; i < newItemList.Count; i++)
                    {
                        textBox7.Text += newItemList[i] + "\n"; // this will add the text to your box
                    }

                    string newItem2 = "+" + textBox6.Text;
                    List<String> newItemList2 = new List<string>();
                    newItemList2.Add(newItem2);
                    for (int i = 0; i < newItemList2.Count; i++)
                    {
                        textBox1.Text += newItemList2[i] + "\n"; // this will add the text to your box
                    }
                    textBox6.Clear();

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            double wynik1;
            double wynik2;
            int L, L2, L3, L4;

            //gdy sa wszystkie wypelnione
            if
                (int.TryParse(textBox4.Text, out L) && int.TryParse(textBox3.Text, out L2) && int.TryParse(textBox2.Text, out L3))
            {
                wynik1 = Math.Pow(L, L2);
                wynik2 = wynik1 * L3;
                label11.Text = String.Format("{0:f1}", wynik2);

                suma = suma - wynik2;
                string wynik = suma.ToString();
                label10.Text = String.Format("{0:f1}", wynik);
                //1textbox
                //tworzy liste ktora wyswietla ciag znakow w textboxach
                string newItem = "-" + label11.Text;
                List<String> newItemList = new List<string>();
                newItemList.Add(newItem);
                for (int i = 0; i < newItemList.Count; i++)
                {
                    textBox7.Text += newItemList[i] + "\n"; // this will add the text to your box
                }
                //2textbox
                string newItem3 = "-" + textBox2.Text + "*" + textBox4.Text + "^" + textBox3.Text;
                List<String> newItemList3 = new List<string>();
                newItemList3.Add(newItem3);
                for (int i = 0; i < newItemList3.Count; i++)
                {
                    textBox1.Text += newItemList3[i] + "\n"; // this will add the text to your box
                }
                textBox2.Clear();
                textBox3.Text = String.Format("{0:g1}", L2 - 1);
                label4.Text = String.Format("{0:g1}", L2 - 1);
                if (L2 - 1 <= 0)
                {
                    textBox3.Text = null;
                    label4.Text = null;
                }
            }
            //bez liczby przed x
            else if (int.TryParse(textBox4.Text, out L) && int.TryParse(textBox3.Text, out L2))
            {
                wynik1 = Math.Pow(L, L2);
                label11.Text = String.Format("{0:f1}", wynik1);

                suma = suma - wynik1;
                string wynik = suma.ToString();
                label10.Text = String.Format("{0:f1}", wynik);
                //1textbox
                //tworzy liste ktora wyswietla ciag znakow w textboxach
                string newItem = "-" + label11.Text;
                List<String> newItemList = new List<string>();
                newItemList.Add(newItem);
                for (int i = 0; i < newItemList.Count; i++)
                {
                    textBox7.Text += newItemList[i] + "\n"; // this will add the text to your box
                }
                //2textbox
                string newItem3 = "-" + textBox4.Text + "^" + textBox3.Text;
                List<String> newItemList3 = new List<string>();
                newItemList3.Add(newItem3);
                for (int i = 0; i < newItemList3.Count; i++)
                {
                    textBox1.Text += newItemList3[i] + "\n"; // this will add the text to your box
                }
                textBox2.Clear();
                textBox3.Text = String.Format("{0:g1}", L2 - 1);
                label4.Text = String.Format("{0:g1}", L2 - 1);
                if (L2 - 1 <= 0)
                {
                    textBox3.Text = null;
                    label4.Text = null;
                }
            }
           

            else if (int.TryParse(textBox6.Text, out L4))
            {

                suma = suma - L4;
                string wynik = suma.ToString();
                label10.Text = String.Format("{0:f1}", wynik);

                int.TryParse(textBox6.Text, out L4);
                label11.Text = String.Format("{0:f1}", L4);
                //lista
                string newItem = "-" + textBox6.Text;
                List<String> newItemList = new List<string>();
                newItemList.Add(newItem);
                for (int i = 0; i < newItemList.Count; i++)
                {
                    textBox7.Text += newItemList[i] + "\n"; // this will add the text to your box
                }

                string newItem2 = "-" + textBox6.Text;
                List<String> newItemList2 = new List<string>();
                newItemList2.Add(newItem2);
                for (int i = 0; i < newItemList2.Count; i++)
                {
                    textBox1.Text += newItemList2[i] + "\n"; // this will add the text to your box
                }
                textBox6.Clear();

            }
        }



        private void label10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                textBox1.Clear();
                textBox7.Clear();
                textBox1.Clear();
                textBox4.Clear();
                textBox3.Clear();
                textBox2.Clear();
                textBox6.Clear();
                label10.Text = ("0");
                suma = 0;

            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {



        }

        private void label6_Click(object sender, EventArgs e)
        {
           
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Podaj wartość x");

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
        }



    

        private void button7_Click(object sender, EventArgs e)
        {
            double wynik1;
            double wynik2;
            int L, L2, L3, L4;

            if (j < 1)//petla jesli za 1 razem zostanie wcisniety przycisk to nie dodaje znaku 
            {
                if
                   (int.TryParse(textBox2.Text, out L) && int.TryParse(textBox4.Text, out L2))
                {
                    wynik1 = L * L2;
                    int.TryParse(textBox3.Text, out L3);
                    wynik2 = Math.Pow(wynik1, L3);
                    label11.Text = String.Format("{0:f1}", wynik2);

                    suma = suma + wynik2;
                    string wynik = suma.ToString();

                    label10.Text = wynik;
                    //1textbox
                    string newItem = label11.Text;
                    List<String> newItemList = new List<string>();
                    newItemList.Add(newItem);
                    for (int i = 0; i < newItemList.Count; i++)
                    {
                        textBox7.Text += newItemList[i] + "\n"; // this will add the text to your box
                    }
                    //2textbox
                    string newItem2 = textBox2.Text + "*" + textBox4.Text + "^" + textBox3.Text;
                    List<String> newItemList2 = new List<string>();
                    newItemList2.Add(newItem2);
                    for (int i = 0; i < newItemList2.Count; i++)
                    {
                        textBox1.Text += newItemList2[i] + "\n"; // this will add the text to your box
                    }
                    textBox3.Clear();
                    textBox2.Clear();


                }

                else if (int.TryParse(textBox6.Text, out L4))
                {

                    suma = suma + L4;
                    string wynik = suma.ToString();
                    label10.Text = wynik;

                    int.TryParse(textBox6.Text, out L4);
                    label11.Text = String.Format("{0:f1}", L4);

                    string newItem = textBox6.Text;
                    List<String> newItemList = new List<string>();
                    newItemList.Add(newItem);
                    for (int i = 0; i < newItemList.Count; i++)
                    {
                        textBox7.Text += newItemList[i] + "\n"; // this will add the text to your box
                    }

                    string newItem2 = textBox6.Text;
                    List<String> newItemList2 = new List<string>();
                    newItemList2.Add(newItem2);
                    for (int i = 0; i < newItemList2.Count; i++)
                    {
                        textBox1.Text += newItemList2[i] + "\n"; // this will add the text to your box
                    }
                    textBox6.Clear();

                }
                j++;
            }
            else
            {

                if
                   (int.TryParse(textBox2.Text, out L) && int.TryParse(textBox4.Text, out L2))
                {

                    wynik1 = L * L2;
                    int.TryParse(textBox3.Text, out L3);
                    wynik2 = Math.Pow(wynik1, L3);
                    label11.Text = String.Format("{0:f1}", wynik2);
                    suma = suma - wynik2;
                    string wyniczek = suma.ToString();

                    label10.Text = wyniczek;

                    string newItem = "-" + wynik2;
                    List<String> newItemList = new List<string>();
                    newItemList.Add(newItem);
                    for (int i = 0; i < newItemList.Count; i++)
                    {
                        textBox7.Text += newItemList[i] + "\n"; // this will add the text to your box
                    }

                    string newItem2 = "-" + textBox2.Text + "*" + textBox4.Text + "^" + textBox3.Text;
                    List<String> newItemList2 = new List<string>();
                    newItemList2.Add(newItem2);
                    for (int i = 0; i < newItemList2.Count; i++)
                    {
                        textBox1.Text += newItemList2[i] + "\n"; // this will add the text to your box
                    }
                    textBox3.Clear();
                    textBox2.Clear();


                }

                else if (int.TryParse(textBox6.Text, out L4))
                {

                    suma = suma - L4;
                    string wynik = suma.ToString();
                    label10.Text = wynik;

                    int.TryParse(textBox6.Text, out L4);
                    label11.Text = String.Format("{0:f1}", L4);

                    string newItem = "-" + textBox6.Text;
                    List<String> newItemList = new List<string>();
                    newItemList.Add(newItem);
                    for (int i = 0; i < newItemList.Count; i++)
                    {
                        textBox7.Text += newItemList[i] + "\n"; // this will add the text to your box
                    }

                    string newItem2 = "-" + textBox6.Text;
                    List<String> newItemList2 = new List<string>();
                    newItemList2.Add(newItem2);
                    for (int i = 0; i < newItemList2.Count; i++)
                    {
                        textBox1.Text += newItemList2[i] + "\n"; // this will add the text to your box
                    }
                    textBox6.Clear();

                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            if (przyciskdalej == false && przyciskdalej2 == false)
                if (textBox4.Text == "0" && textBox4.Text != null)
                {
                    textBox4.Text = "1";
                }
                else
                {
                    textBox4.Text = textBox4.Text + "1";
                }
            else if (przyciskdalej == true && przyciskdalej2 == true)
            {
                if (textBox2.Text == "0" && textBox2.Text != null)
                {
                    textBox2.Text = "1";
                }
                else
                {
                    textBox2.Text = textBox2.Text + "1";
                }
               
            }
            else if (przyciskdalej == false && przyciskdalej2 == true)
            {
                if (textBox3.Text == "0" && textBox3.Text != null)
                {
                    textBox3.Text = "1";
                }
                else
                {
                    textBox3.Text = textBox3.Text + "1";
                }
            }
            else if (przyciskdalej == true && przyciskdalej2 == false)
            {
                if (textBox6.Text == "0" && textBox6.Text != null)
                {
                    textBox6.Text = "1";
                }
                else
                {
                    textBox6.Text = textBox6.Text + "1";
                }
            }
        }

        private void button5_Click_1(object sender, EventArgs e)//cyfra 2
        {
            if (przyciskdalej == false && przyciskdalej2 == false)
                if (textBox4.Text == "0" && textBox4.Text != null)
                {
                    textBox4.Text = "2";
                }
                else
                {
                    textBox4.Text = textBox4.Text + "2";
                }
            else if (przyciskdalej == true && przyciskdalej2 == true)
            {
                if (textBox2.Text == "0" && textBox2.Text != null)
                {
                    textBox2.Text = "2";
                }
                else
                {
                    textBox2.Text = textBox2.Text + "2";
                }
            }
            else if (przyciskdalej == false && przyciskdalej2 == true)
            {
                if (textBox3.Text == "0" && textBox3.Text != null)
                {
                    textBox3.Text = "2";
                }
                else
                {
                    textBox3.Text = textBox3.Text + "2";
                }
            }
            else if (przyciskdalej == true && przyciskdalej2 == false)
            {
                if (textBox6.Text == "0" && textBox6.Text != null)
                {
                    textBox6.Text = "2";
                }
                else
                {
                    textBox6.Text = textBox6.Text + "2";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (przyciskdalej == false && przyciskdalej2 == false)
                if (textBox4.Text == "0" && textBox4.Text != null)
                {
                    textBox4.Text = "3";
                }
                else
                {
                    textBox4.Text = textBox4.Text + "3";
                }
            else if (przyciskdalej == true && przyciskdalej2 == true)
            {
                if (textBox2.Text == "0" && textBox2.Text != null)
                {
                    textBox2.Text = "3";
                }
                else
                {
                    textBox2.Text = textBox2.Text + "3";
                }
            }
            else if (przyciskdalej == false && przyciskdalej2 == true)
            {
                if (textBox3.Text == "0" && textBox3.Text != null)
                {
                    textBox3.Text = "3";
                }
                else
                {
                    textBox3.Text = textBox3.Text + "3";
                }
            }
            else if (przyciskdalej == true && przyciskdalej2 == false)
            {
                if (textBox6.Text == "0" && textBox6.Text != null)
                {
                    textBox6.Text = "3";
                }
                else
                {
                    textBox6.Text = textBox6.Text + "3";
                }
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {

            if (i == 1)
            {
                przyciskdalej = false;
                przyciskdalej2 = true;
                MessageBox.Show("Podaj stopień wielomianu ");
                i++;
            }
            else if (i == 2)
            {
                przyciskdalej = true;
                przyciskdalej2 = true;
                MessageBox.Show("liczba przed x");
                i++;
            }
            else if (i == 3)
            {
                przyciskdalej = true;
                przyciskdalej2 = false;
                MessageBox.Show("Podaj wyraz wolny");
                i++;
            }
            else if (i == 4)
            {
                przyciskdalej = false;
                przyciskdalej2 = false;
                MessageBox.Show("Podaj wartość wyrazu x");
                i = 1;
            }
        }

        private void button8_Click(object sender, EventArgs e)//kasowanie
        {
            if (przyciskdalej == false && przyciskdalej2 == false)
            {
                if (textBox4.TextLength > 0)
                {
                    textBox4.Text = textBox4.Text.Substring(0, (textBox4.TextLength - 1));
                }
            }
            if (przyciskdalej == true && przyciskdalej2 == true)
            {
                if (textBox2.TextLength > 0)
                {
                    textBox2.Text = textBox2.Text.Substring(0, (textBox2.TextLength - 1));
                }
            }
            if (przyciskdalej == false && przyciskdalej2 == true)
            {
                if (textBox3.TextLength > 0)
                {
                    textBox3.Text = textBox3.Text.Substring(0, (textBox3.TextLength - 1));
                }
            }
            if (przyciskdalej == true && przyciskdalej2 == false)
            {
                if (textBox6.TextLength > 0)
                {
                    textBox6.Text = textBox6.Text.Substring(0, (textBox6.TextLength - 1));
                }
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (przyciskdalej == false && przyciskdalej2 == false)
                if (textBox4.Text == "0" && textBox4.Text != null)
                {
                    textBox4.Text = "4";
                }
                else
                {
                    textBox4.Text = textBox4.Text + "4";
                }
            else if (przyciskdalej == true && przyciskdalej2 == true)
            {
                if (textBox2.Text == "0" && textBox2.Text != null)
                {
                    textBox2.Text = "4";
                }
                else
                {
                    textBox2.Text = textBox2.Text + "4";
                }
            }
            else if (przyciskdalej == false && przyciskdalej2 == true)
            {
                if (textBox3.Text == "0" && textBox3.Text != null)
                {
                    textBox3.Text = "4";
                }
                else
                {
                    textBox3.Text = textBox3.Text + "4";
                }
            }
            else if (przyciskdalej == true && przyciskdalej2 == false)
            {
                if (textBox6.Text == "0" && textBox6.Text != null)
                {
                    textBox6.Text = "4";
                }
                else
                {
                    textBox6.Text = textBox6.Text + "4";
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (przyciskdalej == false && przyciskdalej2 == false)
                if (textBox4.Text == "0" && textBox4.Text != null)
                {
                    textBox4.Text = "5";
                }
                else
                {
                    textBox4.Text = textBox4.Text + "5";
                }
            else if (przyciskdalej == true && przyciskdalej2 == true)
            {
                if (textBox2.Text == "0" && textBox2.Text != null)
                {
                    textBox2.Text = "5";
                }
                else
                {
                    textBox2.Text = textBox2.Text + "5";
                }
            }
            else if (przyciskdalej == false && przyciskdalej2 == true)
            {
                if (textBox3.Text == "0" && textBox3.Text != null)
                {
                    textBox3.Text = "5";
                }
                else
                {
                    textBox3.Text = textBox3.Text + "5";
                }
            }
            else if (przyciskdalej == true && przyciskdalej2 == false)
            {
                if (textBox6.Text == "0" && textBox6.Text != null)
                {
                    textBox6.Text = "5";
                }
                else
                {
                    textBox6.Text = textBox6.Text + "5";
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (przyciskdalej == false && przyciskdalej2 == false)
                if (textBox4.Text == "0" && textBox4.Text != null)
                {
                    textBox4.Text = "6";
                }
                else
                {
                    textBox4.Text = textBox4.Text + "6";
                }
            else if (przyciskdalej == true && przyciskdalej2 == true)
            {
                if (textBox2.Text == "0" && textBox2.Text != null)
                {
                    textBox2.Text = "6";
                }
                else
                {
                    textBox2.Text = textBox2.Text + "6";
                }
            }
            else if (przyciskdalej == false && przyciskdalej2 == true)
            {
                if (textBox3.Text == "0" && textBox3.Text != null)
                {
                    textBox3.Text = "6";
                }
                else
                {
                    textBox3.Text = textBox3.Text + "6";
                }
            }
            else if (przyciskdalej == true && przyciskdalej2 == false)
            {
                if (textBox6.Text == "0" && textBox6.Text != null)
                {
                    textBox6.Text = "6";
                }
                else
                {
                    textBox6.Text = textBox6.Text + "6";
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (przyciskdalej == false && przyciskdalej2 == false)
                if (textBox4.Text == "0" && textBox4.Text != null)
                {
                    textBox4.Text = "7";
                }
                else
                {
                    textBox4.Text = textBox4.Text + "7";
                }
            else if (przyciskdalej == true && przyciskdalej2 == true)
            {
                if (textBox2.Text == "0" && textBox2.Text != null)
                {
                    textBox2.Text = "7";
                }
                else
                {
                    textBox2.Text = textBox2.Text + "7";
                }
            }
            else if (przyciskdalej == false && przyciskdalej2 == true)
            {
                if (textBox3.Text == "0" && textBox3.Text != null)
                {
                    textBox3.Text = "7";
                }
                else
                {
                    textBox3.Text = textBox3.Text + "7";
                }
            }
            else if (przyciskdalej == true && przyciskdalej2 == false)
            {
                if (textBox6.Text == "0" && textBox6.Text != null)
                {
                    textBox6.Text = "7";
                }
                else
                {
                    textBox6.Text = textBox6.Text + "7";
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (przyciskdalej == false && przyciskdalej2 == false)
                if (textBox4.Text == "0" && textBox4.Text != null)
                {
                    textBox4.Text = "8";
                }
                else
                {
                    textBox4.Text = textBox4.Text + "8";
                }
            else if (przyciskdalej == true && przyciskdalej2 == true)
            {
                if (textBox2.Text == "0" && textBox2.Text != null)
                {
                    textBox2.Text = "8";
                }
                else
                {
                    textBox2.Text = textBox2.Text + "8";
                }
            }
            else if (przyciskdalej == false && przyciskdalej2 == true)
            {
                if (textBox3.Text == "0" && textBox3.Text != null)
                {
                    textBox3.Text = "8";
                }
                else
                {
                    textBox3.Text = textBox3.Text + "8";
                }
            }
            else if (przyciskdalej == true && przyciskdalej2 == false)
            {
                if (textBox6.Text == "0" && textBox6.Text != null)
                {
                    textBox6.Text = "8";
                }
                else
                {
                    textBox6.Text = textBox6.Text + "8";
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (przyciskdalej == false && przyciskdalej2 == false)
                if (textBox4.Text == "0" && textBox4.Text != null)
                {
                    textBox4.Text = "9";
                }
                else
                {
                    textBox4.Text = textBox4.Text + "9";
                }
            else if (przyciskdalej == true && przyciskdalej2 == true)
            {
                if (textBox2.Text == "0" && textBox2.Text != null)
                {
                    textBox2.Text = "9";
                }
                else
                {
                    textBox2.Text = textBox2.Text + "9";
                }
            }
            else if (przyciskdalej == false && przyciskdalej2 == true)
            {
                if (textBox3.Text == "0" && textBox3.Text != null)
                {
                    textBox3.Text = "9";
                }
                else
                {
                    textBox3.Text = textBox3.Text + "9";
                }
            }
            else if (przyciskdalej == true && przyciskdalej2 == false)
            {
                if (textBox6.Text == "0" && textBox6.Text != null)
                {
                    textBox6.Text = "9";
                }
                else
                {
                    textBox6.Text = textBox6.Text + "9";
                }
            }
        }

      

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (i == 2)
            {
                przyciskdalej = false;
                przyciskdalej2 = false;
                MessageBox.Show("Podaj wartość wyrazu x ");
                i--;
            }
            else if (i == 3)
            {
                przyciskdalej = false;
                przyciskdalej2 = true;
                MessageBox.Show("Podaj stopień wielomianu");
                i--;
            }
            else if (i == 4)
            {
                przyciskdalej = true;
                przyciskdalej2 = true;
                MessageBox.Show("liczba przed x");
                i--;
            }
            else if (i == 1)
            {
                przyciskdalej = true;
                przyciskdalej2 = false;
                MessageBox.Show("Podaj wyraz wolny");
                i=4;
            }

        }
    }
}



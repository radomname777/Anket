using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1() {InitializeComponent();}

        //string[][] strarr = new string[][]{};
        List<string[]> list1 = new List<string[]>();
        private bool Check()
        {
            string pattern = "^((\\+)|(994)|(\\*)|())[0-9]{9,14}((\\#)|())$";
            Regex regex = new Regex(pattern);
            Regex mail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (N_txt.Text.Length <= 2) Errorname.Visible = true;
            else Errorname.Visible = false;
            if (SN_txt.Text.Length <= 3) surnamerror.Visible = true;
            else surnamerror.Visible = false;
            if (!regex.IsMatch(T_txt.Text))phone_lbl.Visible = true;
            else phone_lbl.Visible = false;
            if (!mail.IsMatch(E_txt.Text)) email_lbl.Visible = true;
            else email_lbl.Visible = false;
            if (!Errorname.Visible && !surnamerror.Visible && !phone_lbl.Visible && !email_lbl.Visible) return true;
            else return false;
        }
        private bool Check2(string a){ return listBox1.Items.Contains(a);}
        private void Person()
        {
            if (!Check2(N_txt.Text))
            {
                int i = 0;
                string[] ar = new string[5];
                foreach (Control gb in this.Controls)
                {
                    if (gb is GroupBox)
                    {
                        foreach (Control tb in gb.Controls)
                        {

                            if (tb is TextBox)
                            {
                                ar[i++] = tb.Text;
                                if (i == 4)
                                {
                                    ar[4] = dateTimePicker1.Text.ToString();
                                    list1.Add(ar);
                                    i = 0;
                                }
                            }
                        }
                    }

                }
                
                listBox1.Items.Clear();
                foreach (var item in list1) { listBox1.Items.Add(item[3]); }
            }
            else MessageBox.Show("this person already exists");

        }
        private bool ListBoxCheck()
        {
            if (listBox1.Items.Count > 0) return true;
            return false;
        }
        void JSONSerializeMethod(string Username1)
        {
                var jsonString = System.Text.Json.JsonSerializer.Serialize(list1);
                File.WriteAllText(Username1 + ".json", jsonString);
            
        }
        private void Serializetetextbox(string[][] Items)
        {
            listBox1.Items.Clear();
            string[] array = new string[Items.Length];
            for (int i = 0; i < Items.Length; i++)array[i] = Items[i][3];
            listBox1.Items.AddRange(array);
        }
        private bool JSONDeserializeMethod2(string filename)
        {
            List<string[]> Item;
            {
                try
                {
                    var stringData = File.ReadAllText(filename + ".json");
                    Item = JsonConvert.DeserializeObject<List<string[]>>(stringData);
                }
                catch (Exception)
                {
                    return false;
                }
            }
            Serializetetextbox(Item.ToArray());
            list1 = Item;

            return true;
        }
        public void Resitem(int num)
        {
            list1.RemoveAt(num);
            listBox1.Items.RemoveAt(num);
            Person();
        }
        private void Button_Click(object sender, EventArgs e)
        {

            if (sender is Button btn)
            {
                if (btn.Tag == "load" || Check())
                {
                    switch (btn.Tag)
                    {
                        case "add":
                            MessageBox.Show("add");
                            Person();
                            break;
                        case "save":
                       
                            if (ListBoxCheck()&&filename_txt.Text.Length>0)JSONSerializeMethod(filename_txt.Text);
                            else return;
                            break;
                        case "load":
                            if (filename_txt.Text.Length>0)if(!JSONDeserializeMethod2(filename_txt.Text)) { MessageBox.Show("No File"); }
                            
                            break;
                        case "Res":
                            Resitem(listBox1.SelectedIndex);
                            deyis.Visible = false;
                            break;

                        default:
                            break;
                    }

                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void Itemsload(string[] str)
        {
            int i = 0;

            foreach (Control gb in this.Controls)
            {
                if (gb is GroupBox)
                {
                    foreach (Control tb in gb.Controls) {
                        if (tb is TextBox)
                        {
                            tb.Text = str[i++];
                            if (i==4) dateTimePicker1.Text = str[i];   
                        }
                    }
                }

            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            deyis.Visible = true;
            foreach (var item in listBox1.SelectedItems)
            {
                foreach (var item2 in list1)
                {
                  //  MessageBox.Show(item.ToString(), item2[3].ToString());
                    if (item.ToString() == item2[3])Itemsload(item2.ToArray());
                }
            }
        }
    }
}
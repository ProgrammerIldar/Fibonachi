
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Fibonachi.Clasess;

namespace Fibonachi
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void FileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Enter.Enabled = false;
            RondomNumers.Enabled = false;
            vichBtn.Enabled = false;
            Save.Enabled = false;
            button1.Enabled = false;
            LoadFile.Enabled = false;
            SotrVozRadio.Enabled = false;
            SortUbRadio.Enabled = false;
            minmaxCombo.Enabled = false;

        }

        

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void ListBoxFib_SelectedIndexChanged(object sender, EventArgs e)
        {
          

            
        }

        void Clear()
        {
            InputFib.Text = "";
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            WorkArray workArray = new WorkArray();
            foreach (var item in workArray.RondomArrayList())
            {
                listBoxFib.Items.Add(item);
            }
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            if (this.InputFib.Text != "")
            {
                    listBoxFib.Items.Add(Int32.Parse(this.InputFib.Text));
                    this.InputFib.Text = "";
               
            }
            else
            {
                MessageBox.Show("Введите значения");
            }
            
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
          
            
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = "Document"; //Имя файла по умолчанию
            dlg.DefaultExt = ".txt"; // Расширение файла по умолчанию
            dlg.Filter = "Text documents (.txt)|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(dlg.FileName);
                
                if(SotrVozRadio.Checked)
                {
                    writer.WriteLine("Ряд Фибоначи до " + InputFib.Text+ " (по возрастанию):");
                }
                else
                
                    writer.WriteLine("Ряд Фибоначи до " + InputFib.Text+ " (по убванию):");
                
                
                for (int i = 0; i < listBoxFib.Items.Count; i++)
                {
                  
                    writer.WriteLine((int)listBoxFib.Items[i]);
                }
                writer.Close();
            }
            dlg.Dispose();
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = ".txt";
            ofd.Filter = "All text File|*.txt";
        }

        // Событие вычисление фибоначи
        private void MetroButton2_Click(object sender, EventArgs e)
        {
            
            
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(comboBox1.SelectedIndex==0)
            {
                vichBtn.Enabled = true;
                Save.Enabled = true;
                button1.Enabled = true;
                LoadFile.Enabled = true;
                SotrVozRadio.Enabled = true;
                SortUbRadio.Enabled = true;
                Enter.Enabled = false;
                RondomNumers.Enabled = false;
                

                MainForm mainForm = new MainForm();
                NameFabFan.Text = "Числа Фибоначи";
                NameInputLabel.Text = "Посчитать до:";
            }

            if(comboBox1.SelectedIndex==1)
            {
                NameFabFan.Text = "Средне арифмитическое число";
                Enter.Enabled = true;
                RondomNumers.Enabled = true;
                vichBtn.Enabled = true;
                button1.Enabled = true;
                SotrVozRadio.Enabled = true;
                SortUbRadio.Enabled = true;
                minmaxCombo.Enabled = true;
                Save.Enabled = false;
                LoadFile.Enabled = false;
            }
           
        }

        private void InputFib_Click(object sender, EventArgs e)
        {
            ToolTip inputTip = new ToolTip();
            inputTip.SetToolTip(InputFib,"Ввод значений в лист" );

           if(InputFib.Text=="")
            {
               // listBoxFib.Items.Clear();
                
            }
        }

       

        private void SortUb_CheckedChanged(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            foreach (var item in listBoxFib.Items)
            {
                list.Add(item);
            }
            list.Sort();
            list.Reverse();

            listBoxFib.Items.Clear();
            foreach (var item in list)
            {
                listBoxFib.Items.Add(item);
            }
        }

        private void SotrVoz_CheckedChanged(object sender, EventArgs e)
        {
           
            ArrayList list = new ArrayList();
            foreach (var item in listBoxFib.Items)
            {
                list.Add(item);
            }
            list.Sort();
           

            listBoxFib.Items.Clear();
            foreach (var item in list)
            {
                listBoxFib.Items.Add(item);
            }
        }

        

        private void Button1_Click_4(object sender, EventArgs e)
        {
            listBoxFib.Items.Clear();
            InputFib.Text = "";
            textBoxValueMax.Text = "";
        }

        private void Button2_Click_2(object sender, EventArgs e)
        {
            ToolTip tvich = new ToolTip();
            tvich.SetToolTip(vichBtn, "Вычисление");

            //Выбор вычисления Фибоначи
            if (comboBox1.SelectedIndex == 0)
            {

                listBoxFib.Items.Clear();
                WorkArray workArray = new WorkArray();
                int a, b, c, num;
                a = 0;
                b = 1;
                listBoxFib.Items.Add(a);
                listBoxFib.Items.Add(b);


                try
                {
                    num = Convert.ToInt32(InputFib.Text);

                    for (int i = 2; i <= num; i++)
                    {
                        c = a + b;
                        listBoxFib.Items.Add(c);
                        a = b;
                        b = c;
                    }

                }

                catch (Exception)
                {
                    if (InputFib.Text == "")
                    {
                        listBoxFib.Items.Clear();
                        MessageBox.Show("Пустая строка введите число");
                    }
                }
            }

            //Выбор для вычисления среднеарифметического
            
            if(comboBox1.SelectedIndex==1)
            {

                try
                {
                    int n = listBoxFib.Items.Count;
                    double sum = 0;
                    for (int i = 0; i < n; i++)
                    {
                        sum = sum + double.Parse(listBoxFib.Items[i].ToString());
                    }

                    double result = sum / n;
                    textBoxValueMax.Text = result.ToString();

                   

                }
                catch (Exception)
                {

                    throw;
                }


            }
        }

        //Загрузить в файл
        private void Button2_Click_3(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
           
            dlg.DefaultExt = ".txt"; // Расширение файла по умолчанию
            dlg.Filter = "Text documents (.txt)|*.txt";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string[]file = File.ReadAllLines(dlg.FileName);

                foreach (var item in file )
                {
                    listBoxFib.Items.Add(item);
                }
                
            }
           
        }

        private void Button2_Click_4(object sender, EventArgs e)
        {
            ToolTip tClouse = new ToolTip();
            tClouse.SetToolTip(helpbtn, "Закрыть программу");
            Application.Exit();

        }

        private void MinmaxCombo_SelectedIndexChanged(object sender, EventArgs e)
        {


            try
            {
                if (minmaxCombo.SelectedIndex == 0)
                {

                    WorkArray workArray = new WorkArray();
                    IList list = this.listBoxFib.Items;
                    string result;
                    result = workArray.MaxValueIntegerToListInt(list).ToString();
                    this.textBoxValueMax.Text = result;


                    this.listBoxFib.Text = result;

                }
                if (minmaxCombo.SelectedIndex == 1)
                {
                    WorkArray workArray = new WorkArray();
                    IList list = this.listBoxFib.Items;
                    string result;
                    result = workArray.MinValueIntegerToListInt(list).ToString();
                    this.textBoxValueMax.Text = result;

                    this.listBoxFib.Text = result;
                    
                }
            }
            catch (Exception)
            {

             
              
              // throw new InitializationException { Message = "Список пуст" };
            }

        }

       

        private void ListBoxFib_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(helpbtn,"Помощь");

            HelpForm helpForm = new HelpForm();
            helpForm.Show();
        }
    }
}

namespace Fibonachi
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.InputFib = new MetroFramework.Controls.MetroTextBox();
            this.listBoxFib = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.NameFabFan = new System.Windows.Forms.Label();
            this.SortUbRadio = new System.Windows.Forms.RadioButton();
            this.SotrVozRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.NameInputLabel = new System.Windows.Forms.Label();
            this.minmaxCombo = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.textBoxValueMax = new MetroFramework.Controls.MetroTextBox();
            this.helpbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LoadFile = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vichBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Enter = new System.Windows.Forms.Button();
            this.RondomNumers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // InputFib
            // 
            this.InputFib.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.InputFib.Location = new System.Drawing.Point(335, 210);
            this.InputFib.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.InputFib.Name = "InputFib";
            this.InputFib.Size = new System.Drawing.Size(300, 35);
            this.InputFib.TabIndex = 5;
            this.InputFib.Click += new System.EventHandler(this.InputFib_Click);
            // 
            // listBoxFib
            // 
            this.listBoxFib.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxFib.FormattingEnabled = true;
            this.listBoxFib.ItemHeight = 25;
            this.listBoxFib.Location = new System.Drawing.Point(298, 439);
            this.listBoxFib.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.listBoxFib.Name = "listBoxFib";
            this.listBoxFib.Size = new System.Drawing.Size(298, 304);
            this.listBoxFib.TabIndex = 10;
            this.listBoxFib.SelectedIndexChanged += new System.EventHandler(this.ListBoxFib_SelectedIndexChanged_1);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Вычисление Фибоначи",
            "Вычислить среднеарефметическое значение"});
            this.comboBox1.Location = new System.Drawing.Point(280, 118);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(588, 33);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // NameFabFan
            // 
            this.NameFabFan.AutoSize = true;
            this.NameFabFan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameFabFan.Location = new System.Drawing.Point(42, 29);
            this.NameFabFan.Name = "NameFabFan";
            this.NameFabFan.Size = new System.Drawing.Size(0, 31);
            this.NameFabFan.TabIndex = 19;
            // 
            // SortUbRadio
            // 
            this.SortUbRadio.AutoSize = true;
            this.SortUbRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortUbRadio.Location = new System.Drawing.Point(541, 385);
            this.SortUbRadio.Name = "SortUbRadio";
            this.SortUbRadio.Size = new System.Drawing.Size(119, 22);
            this.SortUbRadio.TabIndex = 20;
            this.SortUbRadio.TabStop = true;
            this.SortUbRadio.Text = "По убыванию";
            this.SortUbRadio.UseVisualStyleBackColor = true;
            this.SortUbRadio.CheckedChanged += new System.EventHandler(this.SortUb_CheckedChanged);
            // 
            // SotrVozRadio
            // 
            this.SotrVozRadio.AutoSize = true;
            this.SotrVozRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SotrVozRadio.Location = new System.Drawing.Point(329, 385);
            this.SotrVozRadio.Name = "SotrVozRadio";
            this.SotrVozRadio.Size = new System.Drawing.Size(140, 22);
            this.SotrVozRadio.TabIndex = 21;
            this.SotrVozRadio.TabStop = true;
            this.SotrVozRadio.Text = "По возрастанию";
            this.SotrVozRadio.UseVisualStyleBackColor = true;
            this.SotrVozRadio.CheckedChanged += new System.EventHandler(this.SotrVoz_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(62, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "Выберете действия: ";
            // 
            // NameInputLabel
            // 
            this.NameInputLabel.AutoSize = true;
            this.NameInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.NameInputLabel.Location = new System.Drawing.Point(98, 214);
            this.NameInputLabel.Name = "NameInputLabel";
            this.NameInputLabel.Size = new System.Drawing.Size(150, 22);
            this.NameInputLabel.TabIndex = 24;
            this.NameInputLabel.Text = "Ввведите число:";
            // 
            // minmaxCombo
            // 
            this.minmaxCombo.FormattingEnabled = true;
            this.minmaxCombo.ItemHeight = 23;
            this.minmaxCombo.Items.AddRange(new object[] {
            "Максимальное значение",
            "Минимальное значение"});
            this.minmaxCombo.Location = new System.Drawing.Point(335, 273);
            this.minmaxCombo.Name = "minmaxCombo";
            this.minmaxCombo.Size = new System.Drawing.Size(300, 29);
            this.minmaxCombo.TabIndex = 29;
            this.minmaxCombo.SelectedIndexChanged += new System.EventHandler(this.MinmaxCombo_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(335, 324);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 19);
            this.metroLabel1.TabIndex = 30;
            this.metroLabel1.Text = "Значение:";
            // 
            // textBoxValueMax
            // 
            this.textBoxValueMax.Location = new System.Drawing.Point(413, 322);
            this.textBoxValueMax.Name = "textBoxValueMax";
            this.textBoxValueMax.Size = new System.Drawing.Size(56, 23);
            this.textBoxValueMax.TabIndex = 31;
            this.textBoxValueMax.Text = "0";
            // 
            // helpbtn
            // 
            this.helpbtn.BackgroundImage = global::Fibonachi.Properties.Resources._12;
            this.helpbtn.Location = new System.Drawing.Point(894, 24);
            this.helpbtn.Name = "helpbtn";
            this.helpbtn.Size = new System.Drawing.Size(63, 51);
            this.helpbtn.TabIndex = 32;
            this.helpbtn.UseVisualStyleBackColor = true;
            this.helpbtn.Click += new System.EventHandler(this.Button3_Click_1);
            // 
            // button2
            // 
            this.button2.Image = global::Fibonachi.Properties.Resources.shutdown____;
            this.button2.Location = new System.Drawing.Point(624, 685);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 100);
            this.button2.TabIndex = 28;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click_4);
            // 
            // LoadFile
            // 
            this.LoadFile.Image = global::Fibonachi.Properties.Resources.Безымянный;
            this.LoadFile.Location = new System.Drawing.Point(94, 557);
            this.LoadFile.Name = "LoadFile";
            this.LoadFile.Size = new System.Drawing.Size(144, 100);
            this.LoadFile.TabIndex = 27;
            this.LoadFile.UseVisualStyleBackColor = true;
            this.LoadFile.Click += new System.EventHandler(this.Button2_Click_3);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Fibonachi.Properties.Resources.icons8_обратная_численная_сортировка_48;
            this.pictureBox2.Location = new System.Drawing.Point(487, 371);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 50);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Fibonachi.Properties.Resources.icons8_численная_сортировка_48;
            this.pictureBox1.Location = new System.Drawing.Point(265, 371);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 50);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // vichBtn
            // 
            this.vichBtn.Image = ((System.Drawing.Image)(resources.GetObject("vichBtn.Image")));
            this.vichBtn.Location = new System.Drawing.Point(662, 176);
            this.vichBtn.Name = "vichBtn";
            this.vichBtn.Size = new System.Drawing.Size(144, 100);
            this.vichBtn.TabIndex = 23;
            this.vichBtn.UseVisualStyleBackColor = true;
            this.vichBtn.Click += new System.EventHandler(this.Button2_Click_2);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(94, 685);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 100);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_4);
            // 
            // Save
            // 
            this.Save.Image = ((System.Drawing.Image)(resources.GetObject("Save.Image")));
            this.Save.Location = new System.Drawing.Point(94, 440);
            this.Save.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(144, 100);
            this.Save.TabIndex = 14;
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Enter
            // 
            this.Enter.Image = ((System.Drawing.Image)(resources.GetObject("Enter.Image")));
            this.Enter.Location = new System.Drawing.Point(624, 440);
            this.Enter.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(144, 98);
            this.Enter.TabIndex = 11;
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // RondomNumers
            // 
            this.RondomNumers.Image = ((System.Drawing.Image)(resources.GetObject("RondomNumers.Image")));
            this.RondomNumers.Location = new System.Drawing.Point(623, 557);
            this.RondomNumers.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.RondomNumers.Name = "RondomNumers";
            this.RondomNumers.Size = new System.Drawing.Size(143, 100);
            this.RondomNumers.TabIndex = 9;
            this.RondomNumers.UseVisualStyleBackColor = true;
            this.RondomNumers.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 912);
            this.Controls.Add(this.helpbtn);
            this.Controls.Add(this.textBoxValueMax);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.minmaxCombo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LoadFile);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NameInputLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vichBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SotrVozRadio);
            this.Controls.Add(this.SortUbRadio);
            this.Controls.Add(this.NameFabFan);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.listBoxFib);
            this.Controls.Add(this.RondomNumers);
            this.Controls.Add(this.InputFib);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(30, 83, 30, 28);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox InputFib;
        private System.Windows.Forms.ListBox listBoxFib;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label NameFabFan;
        private System.Windows.Forms.RadioButton SortUbRadio;
        private System.Windows.Forms.RadioButton SotrVozRadio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button vichBtn;
#pragma warning disable CS0108 // Член скрывает унаследованный член: отсутствует новое ключевое слово
        private System.Windows.Forms.Button Enter;
#pragma warning restore CS0108 // Член скрывает унаследованный член: отсутствует новое ключевое слово
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NameInputLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button RondomNumers;
        private System.Windows.Forms.Button LoadFile;
        private System.Windows.Forms.Button button2;
        private MetroFramework.Controls.MetroComboBox minmaxCombo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox textBoxValueMax;
        private System.Windows.Forms.Button helpbtn;
    }
}


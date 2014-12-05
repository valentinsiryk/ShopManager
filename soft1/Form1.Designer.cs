namespace soft1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.add = new System.Windows.Forms.Button();
            this.listZakazov = new System.Windows.Forms.ListView();
            this.idZakaza = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listTovarov = new System.Windows.Forms.ListView();
            this.idTovara = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numTovarov = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.DescriptionIn = new System.Windows.Forms.RichTextBox();
            this.listSkladov = new System.Windows.Forms.ListView();
            this.skladList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnOtgruz = new System.Windows.Forms.Button();
            this.comboBoxZakazov = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxTest = new System.Windows.Forms.TextBox();
            this.btnSuccess = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxScladId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTovCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxDescrNewTov = new System.Windows.Forms.RichTextBox();
            this.textBoxNameTov = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnShowCategories = new System.Windows.Forms.Button();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(151, 7);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(131, 23);
            this.add.TabIndex = 2;
            this.add.Text = "Показати/Оновити";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.btnShowAllZakaz);
            // 
            // listZakazov
            // 
            this.listZakazov.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idZakaza});
            this.listZakazov.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listZakazov.FullRowSelect = true;
            this.listZakazov.HideSelection = false;
            this.listZakazov.Location = new System.Drawing.Point(0, 0);
            this.listZakazov.MultiSelect = false;
            this.listZakazov.Name = "listZakazov";
            this.listZakazov.Size = new System.Drawing.Size(142, 318);
            this.listZakazov.SmallImageList = this.imageList1;
            this.listZakazov.TabIndex = 3;
            this.listZakazov.UseCompatibleStateImageBehavior = false;
            this.listZakazov.View = System.Windows.Forms.View.Details;
            this.listZakazov.Click += new System.EventHandler(this.listZakazov_Click);
            // 
            // idZakaza
            // 
            this.idZakaza.Text = "ID Замовлення";
            this.idZakaza.Width = 121;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ok.ico");
            // 
            // listTovarov
            // 
            this.listTovarov.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idTovara,
            this.columnHeader3,
            this.numTovarov,
            this.columnHeader2});
            this.listTovarov.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listTovarov.FullRowSelect = true;
            this.listTovarov.HideSelection = false;
            this.listTovarov.Location = new System.Drawing.Point(0, 0);
            this.listTovarov.MultiSelect = false;
            this.listTovarov.Name = "listTovarov";
            this.listTovarov.Size = new System.Drawing.Size(441, 201);
            this.listTovarov.TabIndex = 5;
            this.listTovarov.UseCompatibleStateImageBehavior = false;
            this.listTovarov.View = System.Windows.Forms.View.Details;
            this.listTovarov.Click += new System.EventHandler(this.listTovarov_Click);
            // 
            // idTovara
            // 
            this.idTovara.Text = "ID товара";
            this.idTovara.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Назва";
            this.columnHeader3.Width = 200;
            // 
            // numTovarov
            // 
            this.numTovarov.Text = "Кількість";
            this.numTovarov.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Оброблено";
            this.columnHeader2.Width = 80;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(5, 41);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listZakazov);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(587, 318);
            this.splitContainer1.SplitterDistance = 142;
            this.splitContainer1.TabIndex = 6;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listTovarov);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.DescriptionIn);
            this.splitContainer2.Size = new System.Drawing.Size(441, 318);
            this.splitContainer2.SplitterDistance = 201;
            this.splitContainer2.TabIndex = 6;
            // 
            // DescriptionIn
            // 
            this.DescriptionIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptionIn.Location = new System.Drawing.Point(0, 0);
            this.DescriptionIn.Name = "DescriptionIn";
            this.DescriptionIn.ReadOnly = true;
            this.DescriptionIn.Size = new System.Drawing.Size(441, 113);
            this.DescriptionIn.TabIndex = 0;
            this.DescriptionIn.Text = "Опис товару...";
            // 
            // listSkladov
            // 
            this.listSkladov.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.skladList,
            this.columnHeader1});
            this.listSkladov.FullRowSelect = true;
            this.listSkladov.HideSelection = false;
            this.listSkladov.Location = new System.Drawing.Point(599, 41);
            this.listSkladov.MultiSelect = false;
            this.listSkladov.Name = "listSkladov";
            this.listSkladov.Size = new System.Drawing.Size(174, 261);
            this.listSkladov.TabIndex = 7;
            this.listSkladov.UseCompatibleStateImageBehavior = false;
            this.listSkladov.View = System.Windows.Forms.View.Details;
            // 
            // skladList
            // 
            this.skladList.Text = "Склад";
            this.skladList.Width = 80;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "В наявності";
            this.columnHeader1.Width = 80;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(598, 308);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(76, 20);
            this.numericUpDown1.TabIndex = 8;
            // 
            // btnOtgruz
            // 
            this.btnOtgruz.Location = new System.Drawing.Point(598, 334);
            this.btnOtgruz.Name = "btnOtgruz";
            this.btnOtgruz.Size = new System.Drawing.Size(76, 23);
            this.btnOtgruz.TabIndex = 9;
            this.btnOtgruz.Text = "Відгрузити";
            this.btnOtgruz.UseVisualStyleBackColor = true;
            this.btnOtgruz.Click += new System.EventHandler(this.btnOtgruz_Click);
            // 
            // comboBoxZakazov
            // 
            this.comboBoxZakazov.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.comboBoxZakazov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxZakazov.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxZakazov.FormattingEnabled = true;
            this.comboBoxZakazov.Items.AddRange(new object[] {
            "Активні замовлення",
            "Резервовані"});
            this.comboBoxZakazov.Location = new System.Drawing.Point(6, 8);
            this.comboBoxZakazov.Name = "comboBoxZakazov";
            this.comboBoxZakazov.Size = new System.Drawing.Size(141, 21);
            this.comboBoxZakazov.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(684, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Get response in .XML";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(787, 394);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxTest);
            this.tabPage1.Controls.Add(this.btnSuccess);
            this.tabPage1.Controls.Add(this.comboBoxZakazov);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Controls.Add(this.btnOtgruz);
            this.tabPage1.Controls.Add(this.add);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.listSkladov);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(779, 368);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Замовлення";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxTest
            // 
            this.textBoxTest.Location = new System.Drawing.Point(466, 7);
            this.textBoxTest.Name = "textBoxTest";
            this.textBoxTest.Size = new System.Drawing.Size(212, 20);
            this.textBoxTest.TabIndex = 13;
            this.textBoxTest.Visible = false;
            // 
            // btnSuccess
            // 
            this.btnSuccess.Location = new System.Drawing.Point(680, 308);
            this.btnSuccess.Name = "btnSuccess";
            this.btnSuccess.Size = new System.Drawing.Size(93, 49);
            this.btnSuccess.TabIndex = 12;
            this.btnSuccess.Text = "Виконати замовлення";
            this.btnSuccess.UseVisualStyleBackColor = true;
            this.btnSuccess.Click += new System.EventHandler(this.btnSuccess_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(779, 368);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Додавання нових...";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.comboBox3);
            this.groupBox4.Location = new System.Drawing.Point(526, 181);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(247, 182);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Додати підкатегорію";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(46, 134);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Додати!";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Назва підкатегорії";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(15, 105);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(211, 20);
            this.textBox4.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Категорія";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(46, 49);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(164, 21);
            this.comboBox3.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(526, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 168);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Додати категорію";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Назва категроії";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(46, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Додати!";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(22, 53);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(204, 20);
            this.textBox3.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(0, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 182);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxScladId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxCategory);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxTovCount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.richTextBoxDescrNewTov);
            this.groupBox1.Controls.Add(this.textBoxNameTov);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btnShowCategories);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 356);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додати товар";
            // 
            // textBoxScladId
            // 
            this.textBoxScladId.Location = new System.Drawing.Point(118, 261);
            this.textBoxScladId.Name = "textBoxScladId";
            this.textBoxScladId.Size = new System.Drawing.Size(42, 20);
            this.textBoxScladId.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Кількість";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(250, 260);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 56);
            this.button3.TabIndex = 1;
            this.button3.Text = "ДОДАТИ ТОВАР";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Категорія";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(72, 90);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(165, 21);
            this.comboBoxCategory.TabIndex = 2;
            this.comboBoxCategory.TextChanged += new System.EventHandler(this.comboBoxCategory_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Склад";
            // 
            // textBoxTovCount
            // 
            this.textBoxTovCount.Location = new System.Drawing.Point(118, 296);
            this.textBoxTovCount.Name = "textBoxTovCount";
            this.textBoxTovCount.Size = new System.Drawing.Size(111, 20);
            this.textBoxTovCount.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Назва товара";
            // 
            // richTextBoxDescrNewTov
            // 
            this.richTextBoxDescrNewTov.Location = new System.Drawing.Point(11, 183);
            this.richTextBoxDescrNewTov.Name = "richTextBoxDescrNewTov";
            this.richTextBoxDescrNewTov.Size = new System.Drawing.Size(468, 58);
            this.richTextBoxDescrNewTov.TabIndex = 6;
            this.richTextBoxDescrNewTov.Text = "Опис товару...";
            // 
            // textBoxNameTov
            // 
            this.textBoxNameTov.Location = new System.Drawing.Point(12, 149);
            this.textBoxNameTov.Name = "textBoxNameTov";
            this.textBoxNameTov.Size = new System.Drawing.Size(467, 20);
            this.textBoxNameTov.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Підкатегорія";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(252, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // btnShowCategories
            // 
            this.btnShowCategories.Location = new System.Drawing.Point(145, 31);
            this.btnShowCategories.Name = "btnShowCategories";
            this.btnShowCategories.Size = new System.Drawing.Size(192, 27);
            this.btnShowCategories.TabIndex = 0;
            this.btnShowCategories.Text = "Оновити список категорій";
            this.btnShowCategories.UseVisualStyleBackColor = true;
            this.btnShowCategories.Click += new System.EventHandler(this.btnShowCategories_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 419);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = " ";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ListView listZakazov;
        private System.Windows.Forms.ColumnHeader idZakaza;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listTovarov;
        private System.Windows.Forms.ColumnHeader idTovara;
        private System.Windows.Forms.ColumnHeader numTovarov;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listSkladov;
        private System.Windows.Forms.ColumnHeader skladList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnOtgruz;
        private System.Windows.Forms.ComboBox comboBoxZakazov;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox DescriptionIn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSuccess;
        private System.Windows.Forms.TextBox textBoxTest;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnShowCategories;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTovCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxDescrNewTov;
        private System.Windows.Forms.TextBox textBoxNameTov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBoxScladId;
    }
}


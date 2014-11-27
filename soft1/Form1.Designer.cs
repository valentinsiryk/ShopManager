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
            this.btnAllZakaz = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.listZakazov = new System.Windows.Forms.ListView();
            this.idZakaza = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numberInXml = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listTovarov = new System.Windows.Forms.ListView();
            this.idTovara = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numTovarov = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.successNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listSkladov = new System.Windows.Forms.ListView();
            this.skladList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnOtgruz = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAllZakaz
            // 
            this.btnAllZakaz.Location = new System.Drawing.Point(316, 12);
            this.btnAllZakaz.Name = "btnAllZakaz";
            this.btnAllZakaz.Size = new System.Drawing.Size(84, 27);
            this.btnAllZakaz.TabIndex = 0;
            this.btnAllZakaz.Text = "GET XML";
            this.btnAllZakaz.UseVisualStyleBackColor = true;
            this.btnAllZakaz.Click += new System.EventHandler(this.btnGetXml);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(13, 277);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(131, 23);
            this.add.TabIndex = 2;
            this.add.Text = "Показать/Обновить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.btnShowAllZakaz);
            // 
            // listZakazov
            // 
            this.listZakazov.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idZakaza,
            this.numberInXml});
            this.listZakazov.FullRowSelect = true;
            this.listZakazov.Location = new System.Drawing.Point(3, 41);
            this.listZakazov.MultiSelect = false;
            this.listZakazov.Name = "listZakazov";
            this.listZakazov.Size = new System.Drawing.Size(138, 141);
            this.listZakazov.SmallImageList = this.imageList1;
            this.listZakazov.TabIndex = 3;
            this.listZakazov.UseCompatibleStateImageBehavior = false;
            this.listZakazov.View = System.Windows.Forms.View.Details;
            this.listZakazov.Click += new System.EventHandler(this.listZakazov_Click);
            // 
            // idZakaza
            // 
            this.idZakaza.Text = "ID Zakaza";
            this.idZakaza.Width = 121;
            // 
            // numberInXml
            // 
            this.numberInXml.Width = 68;
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
            this.numTovarov,
            this.successNum});
            this.listTovarov.FullRowSelect = true;
            this.listTovarov.Location = new System.Drawing.Point(37, 23);
            this.listTovarov.MultiSelect = false;
            this.listTovarov.Name = "listTovarov";
            this.listTovarov.Size = new System.Drawing.Size(233, 171);
            this.listTovarov.TabIndex = 5;
            this.listTovarov.UseCompatibleStateImageBehavior = false;
            this.listTovarov.View = System.Windows.Forms.View.Details;
            this.listTovarov.Click += new System.EventHandler(this.listTovarov_Click);
            // 
            // idTovara
            // 
            this.idTovara.Text = "ID Tovara";
            this.idTovara.Width = 66;
            // 
            // numTovarov
            // 
            this.numTovarov.Text = "Num";
            // 
            // successNum
            // 
            this.successNum.Text = "Success Num";
            this.successNum.Width = 85;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 47);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listZakazov);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listTovarov);
            this.splitContainer1.Size = new System.Drawing.Size(433, 210);
            this.splitContainer1.SplitterDistance = 144;
            this.splitContainer1.TabIndex = 6;
            // 
            // listSkladov
            // 
            this.listSkladov.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.skladList,
            this.columnHeader1});
            this.listSkladov.FullRowSelect = true;
            this.listSkladov.Location = new System.Drawing.Point(467, 70);
            this.listSkladov.MultiSelect = false;
            this.listSkladov.Name = "listSkladov";
            this.listSkladov.Size = new System.Drawing.Size(141, 136);
            this.listSkladov.TabIndex = 7;
            this.listSkladov.UseCompatibleStateImageBehavior = false;
            this.listSkladov.View = System.Windows.Forms.View.Details;
            // 
            // skladList
            // 
            this.skladList.Text = "Sklad";
            this.skladList.Width = 63;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Наличие";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(467, 212);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(62, 20);
            this.numericUpDown1.TabIndex = 8;
            // 
            // btnOtgruz
            // 
            this.btnOtgruz.Location = new System.Drawing.Point(535, 209);
            this.btnOtgruz.Name = "btnOtgruz";
            this.btnOtgruz.Size = new System.Drawing.Size(75, 23);
            this.btnOtgruz.TabIndex = 9;
            this.btnOtgruz.Text = "Отгрузить";
            this.btnOtgruz.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Активные заказы",
            "Резервы"});
            this.comboBox1.Location = new System.Drawing.Point(13, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Text = "Тип заказов...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 416);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnOtgruz);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.listSkladov);
            this.Controls.Add(this.add);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnAllZakaz);
            this.Name = "Form1";
            this.Text = " ";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAllZakaz;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ListView listZakazov;
        private System.Windows.Forms.ColumnHeader idZakaza;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listTovarov;
        private System.Windows.Forms.ColumnHeader idTovara;
        private System.Windows.Forms.ColumnHeader numTovarov;
        private System.Windows.Forms.ColumnHeader successNum;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listSkladov;
        private System.Windows.Forms.ColumnHeader skladList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnOtgruz;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ColumnHeader numberInXml;
    }
}


﻿namespace soft1
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
            this.btnSuccess = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxTest = new System.Windows.Forms.TextBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAllZakaz
            // 
            this.btnAllZakaz.Location = new System.Drawing.Point(293, 19);
            this.btnAllZakaz.Name = "btnAllZakaz";
            this.btnAllZakaz.Size = new System.Drawing.Size(84, 23);
            this.btnAllZakaz.TabIndex = 0;
            this.btnAllZakaz.Text = "GET XML";
            this.btnAllZakaz.UseVisualStyleBackColor = true;
            this.btnAllZakaz.Click += new System.EventHandler(this.btnGetXml);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(156, 19);
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
            this.idZakaza});
            this.listZakazov.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listZakazov.FullRowSelect = true;
            this.listZakazov.HideSelection = false;
            this.listZakazov.Location = new System.Drawing.Point(0, 0);
            this.listZakazov.MultiSelect = false;
            this.listZakazov.Name = "listZakazov";
            this.listZakazov.Size = new System.Drawing.Size(151, 318);
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
            this.listTovarov.Size = new System.Drawing.Size(278, 221);
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
            // columnHeader3
            // 
            this.columnHeader3.Text = "Название";
            this.columnHeader3.Width = 66;
            // 
            // numTovarov
            // 
            this.numTovarov.Text = "Count";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Отгружено";
            this.columnHeader2.Width = 71;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(28, 56);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listZakazov);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(433, 318);
            this.splitContainer1.SplitterDistance = 151;
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
            this.splitContainer2.Size = new System.Drawing.Size(278, 318);
            this.splitContainer2.SplitterDistance = 221;
            this.splitContainer2.TabIndex = 6;
            // 
            // DescriptionIn
            // 
            this.DescriptionIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptionIn.Location = new System.Drawing.Point(0, 0);
            this.DescriptionIn.Name = "DescriptionIn";
            this.DescriptionIn.ReadOnly = true;
            this.DescriptionIn.Size = new System.Drawing.Size(278, 93);
            this.DescriptionIn.TabIndex = 0;
            this.DescriptionIn.Text = "Описание товара...";
            // 
            // listSkladov
            // 
            this.listSkladov.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.skladList,
            this.columnHeader1});
            this.listSkladov.FullRowSelect = true;
            this.listSkladov.HideSelection = false;
            this.listSkladov.Location = new System.Drawing.Point(467, 56);
            this.listSkladov.MultiSelect = false;
            this.listSkladov.Name = "listSkladov";
            this.listSkladov.Size = new System.Drawing.Size(157, 259);
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
            this.numericUpDown1.Location = new System.Drawing.Point(466, 321);
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
            this.btnOtgruz.Location = new System.Drawing.Point(467, 347);
            this.btnOtgruz.Name = "btnOtgruz";
            this.btnOtgruz.Size = new System.Drawing.Size(75, 23);
            this.btnOtgruz.TabIndex = 9;
            this.btnOtgruz.Text = "Отгрузить";
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
            "Активные заказы",
            "Резервы"});
            this.comboBoxZakazov.Location = new System.Drawing.Point(29, 21);
            this.comboBoxZakazov.Name = "comboBoxZakazov";
            this.comboBoxZakazov.Size = new System.Drawing.Size(121, 21);
            this.comboBoxZakazov.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(535, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Get XML Doc Stream";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(7, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(696, 421);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxTest);
            this.tabPage1.Controls.Add(this.btnSuccess);
            this.tabPage1.Controls.Add(this.comboBoxZakazov);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btnAllZakaz);
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Controls.Add(this.btnOtgruz);
            this.tabPage1.Controls.Add(this.add);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.listSkladov);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(688, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSuccess
            // 
            this.btnSuccess.Location = new System.Drawing.Point(548, 321);
            this.btnSuccess.Name = "btnSuccess";
            this.btnSuccess.Size = new System.Drawing.Size(76, 49);
            this.btnSuccess.TabIndex = 12;
            this.btnSuccess.Text = "Выполнить заказ";
            this.btnSuccess.UseVisualStyleBackColor = true;
            this.btnSuccess.Click += new System.EventHandler(this.btnSuccess_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(688, 395);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxTest
            // 
            this.textBoxTest.Location = new System.Drawing.Point(383, 19);
            this.textBoxTest.Name = "textBoxTest";
            this.textBoxTest.Size = new System.Drawing.Size(146, 20);
            this.textBoxTest.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 438);
            this.Controls.Add(this.tabControl1);
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
    }
}


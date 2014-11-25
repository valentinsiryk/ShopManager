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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAllZakaz
            // 
            this.btnAllZakaz.Location = new System.Drawing.Point(12, 12);
            this.btnAllZakaz.Name = "btnAllZakaz";
            this.btnAllZakaz.Size = new System.Drawing.Size(100, 44);
            this.btnAllZakaz.TabIndex = 0;
            this.btnAllZakaz.Text = "Все заказы";
            this.btnAllZakaz.UseVisualStyleBackColor = true;
            this.btnAllZakaz.Click += new System.EventHandler(this.btnAllZakaz_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(12, 247);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 2;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // listZakazov
            // 
            this.listZakazov.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idZakaza});
            this.listZakazov.Location = new System.Drawing.Point(18, 80);
            this.listZakazov.Name = "listZakazov";
            this.listZakazov.Size = new System.Drawing.Size(174, 139);
            this.listZakazov.SmallImageList = this.imageList1;
            this.listZakazov.TabIndex = 3;
            this.listZakazov.UseCompatibleStateImageBehavior = false;
            this.listZakazov.View = System.Windows.Forms.View.Details;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 311);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listZakazov);
            this.Controls.Add(this.add);
            this.Controls.Add(this.btnAllZakaz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAllZakaz;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ListView listZakazov;
        private System.Windows.Forms.ColumnHeader idZakaza;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
    }
}


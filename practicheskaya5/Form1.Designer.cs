﻿namespace practicheskaya5
{
    partial class Form1
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Third3 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Second2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.First1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.incValue1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.Button();
            this.tretye = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.vtoroe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pervoe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задатьЗначенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сгенерироватьЗначеняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.увеличитьВсеЗнчениеНа1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.увеличитьВсеЗначенияНаВведенноеЗначениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.incValue2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Third3);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.Second2);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.First1);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox4.Location = new System.Drawing.Point(23, 390);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(459, 84);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Итоговые значения";
            // 
            // Third3
            // 
            this.Third3.Location = new System.Drawing.Point(306, 45);
            this.Third3.Name = "Third3";
            this.Third3.ReadOnly = true;
            this.Third3.Size = new System.Drawing.Size(137, 26);
            this.Third3.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(302, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 20);
            this.label16.TabIndex = 9;
            this.label16.Text = "Секунды";
            // 
            // Second2
            // 
            this.Second2.Location = new System.Drawing.Point(163, 45);
            this.Second2.Name = "Second2";
            this.Second2.ReadOnly = true;
            this.Second2.Size = new System.Drawing.Size(137, 26);
            this.Second2.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(159, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 20);
            this.label15.TabIndex = 6;
            this.label15.Text = "Минуты";
            // 
            // First1
            // 
            this.First1.Location = new System.Drawing.Point(20, 45);
            this.First1.Name = "First1";
            this.First1.ReadOnly = true;
            this.First1.Size = new System.Drawing.Size(137, 26);
            this.First1.TabIndex = 3;
            this.First1.TextChanged += new System.EventHandler(this.First1_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Часы";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button5.Location = new System.Drawing.Point(493, 293);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(204, 26);
            this.button5.TabIndex = 15;
            this.button5.Text = "Увеличить секунды";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button8.Location = new System.Drawing.Point(246, 278);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(204, 57);
            this.button8.TabIndex = 17;
            this.button8.Text = "Сгенерировать значения";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // incValue1
            // 
            this.incValue1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.incValue1.Location = new System.Drawing.Point(532, 261);
            this.incValue1.Name = "incValue1";
            this.incValue1.Size = new System.Drawing.Size(137, 26);
            this.incValue1.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(559, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Значение";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.input);
            this.groupBox1.Controls.Add(this.tretye);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.vtoroe);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pervoe);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(23, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 321);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Задать значения";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 26);
            this.button1.TabIndex = 10;
            this.button1.Text = "Вывести";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(30, 247);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(137, 26);
            this.input.TabIndex = 8;
            this.input.Text = "Ввести";
            this.input.UseVisualStyleBackColor = true;
            this.input.Click += new System.EventHandler(this.button1_Click);
            // 
            // tretye
            // 
            this.tretye.Location = new System.Drawing.Point(30, 198);
            this.tretye.Name = "tretye";
            this.tretye.Size = new System.Drawing.Size(137, 26);
            this.tretye.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Третье ";
            // 
            // vtoroe
            // 
            this.vtoroe.Location = new System.Drawing.Point(30, 139);
            this.vtoroe.Name = "vtoroe";
            this.vtoroe.Size = new System.Drawing.Size(137, 26);
            this.vtoroe.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Второе";
            // 
            // pervoe
            // 
            this.pervoe.Location = new System.Drawing.Point(30, 80);
            this.pervoe.Name = "pervoe";
            this.pervoe.Size = new System.Drawing.Size(137, 26);
            this.pervoe.TabIndex = 1;
            this.pervoe.TextChanged += new System.EventHandler(this.pervoe_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Первое ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.действияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(720, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задатьЗначенияToolStripMenuItem,
            this.сгенерироватьЗначеняToolStripMenuItem,
            this.увеличитьВсеЗнчениеНа1ToolStripMenuItem,
            this.увеличитьВсеЗначенияНаВведенноеЗначениеToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // задатьЗначенияToolStripMenuItem
            // 
            this.задатьЗначенияToolStripMenuItem.Name = "задатьЗначенияToolStripMenuItem";
            this.задатьЗначенияToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.задатьЗначенияToolStripMenuItem.Text = "Задать все значения";
            this.задатьЗначенияToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // сгенерироватьЗначеняToolStripMenuItem
            // 
            this.сгенерироватьЗначеняToolStripMenuItem.Name = "сгенерироватьЗначеняToolStripMenuItem";
            this.сгенерироватьЗначеняToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.сгенерироватьЗначеняToolStripMenuItem.Text = "Сгенерировать значения";
            this.сгенерироватьЗначеняToolStripMenuItem.Click += new System.EventHandler(this.button8_Click);
            // 
            // увеличитьВсеЗнчениеНа1ToolStripMenuItem
            // 
            this.увеличитьВсеЗнчениеНа1ToolStripMenuItem.Name = "увеличитьВсеЗнчениеНа1ToolStripMenuItem";
            this.увеличитьВсеЗнчениеНа1ToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.увеличитьВсеЗнчениеНа1ToolStripMenuItem.Text = "Умножить значения на 2";
            this.увеличитьВсеЗнчениеНа1ToolStripMenuItem.Click += new System.EventHandler(this.button6_Click);
            // 
            // увеличитьВсеЗначенияНаВведенноеЗначениеToolStripMenuItem
            // 
            this.увеличитьВсеЗначенияНаВведенноеЗначениеToolStripMenuItem.Name = "увеличитьВсеЗначенияНаВведенноеЗначениеToolStripMenuItem";
            this.увеличитьВсеЗначенияНаВведенноеЗначениеToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.увеличитьВсеЗначенияНаВведенноеЗначениеToolStripMenuItem.Text = "Увеличить все значения на введенное число";
            this.увеличитьВсеЗначенияНаВведенноеЗначениеToolStripMenuItem.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(246, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 26);
            this.button2.TabIndex = 20;
            this.button2.Text = "Увеличить первое на 1 ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.Location = new System.Drawing.Point(246, 184);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 26);
            this.button3.TabIndex = 21;
            this.button3.Text = "Увеличить второе на 1 ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button4.Location = new System.Drawing.Point(246, 220);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(204, 26);
            this.button4.TabIndex = 22;
            this.button4.Text = "Увеличить третье на 1 ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button7.Location = new System.Drawing.Point(493, 180);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(204, 26);
            this.button7.TabIndex = 25;
            this.button7.Text = "Увеличить минуты";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // incValue2
            // 
            this.incValue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.incValue2.Location = new System.Drawing.Point(532, 148);
            this.incValue2.Name = "incValue2";
            this.incValue2.Size = new System.Drawing.Size(137, 26);
            this.incValue2.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(559, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Значение";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 507);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.incValue2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.incValue1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox Third3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Second2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox First1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox incValue1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button input;
        private System.Windows.Forms.TextBox tretye;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox vtoroe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pervoe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задатьЗначенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сгенерироватьЗначеняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem увеличитьВсеЗнчениеНа1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem увеличитьВсеЗначенияНаВведенноеЗначениеToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox incValue2;
        private System.Windows.Forms.Label label2;
    }
}


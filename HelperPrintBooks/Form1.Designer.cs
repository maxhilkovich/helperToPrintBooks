namespace HelperPrintBooks
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelIncorrect = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstPage = new System.Windows.Forms.TextBox();
            this.secondPage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonResult = new System.Windows.Forms.Button();
            this.textHowMatchPage = new System.Windows.Forms.TextBox();
            this.textPagePrintAll = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radiobuttonHowDo = new System.Windows.Forms.RadioButton();
            this.radiobuttonResult = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxSide1 = new System.Windows.Forms.ListBox();
            this.listBoxSide2 = new System.Windows.Forms.ListBox();
            this.labelAttention1 = new System.Windows.Forms.Label();
            this.buttonHowDo = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCopyBuffer = new System.Windows.Forms.Button();
            this.labelAttention2 = new System.Windows.Forms.Label();
            this.labelWhatLine = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.step1 = new System.Windows.Forms.Label();
            this.step2 = new System.Windows.Forms.Label();
            this.step3 = new System.Windows.Forms.Label();
            this.step4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelIncorrect
            // 
            this.labelIncorrect.AutoSize = true;
            this.labelIncorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIncorrect.ForeColor = System.Drawing.Color.Red;
            this.labelIncorrect.Location = new System.Drawing.Point(199, -1);
            this.labelIncorrect.Name = "labelIncorrect";
            this.labelIncorrect.Size = new System.Drawing.Size(278, 18);
            this.labelIncorrect.TabIndex = 0;
            this.labelIncorrect.Text = "Вы ввели некорректные данные !!!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(28, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "первую и крайнюю страницы";
            // 
            // firstPage
            // 
            this.firstPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstPage.Location = new System.Drawing.Point(36, 42);
            this.firstPage.Name = "firstPage";
            this.firstPage.Size = new System.Drawing.Size(90, 21);
            this.firstPage.TabIndex = 2;
            // 
            // secondPage
            // 
            this.secondPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondPage.Location = new System.Drawing.Point(132, 42);
            this.secondPage.Name = "secondPage";
            this.secondPage.Size = new System.Drawing.Size(90, 21);
            this.secondPage.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(369, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "По сколько листов будете печатать?";
            // 
            // buttonResult
            // 
            this.buttonResult.BackColor = System.Drawing.SystemColors.Control;
            this.buttonResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResult.Location = new System.Drawing.Point(348, 72);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(304, 60);
            this.buttonResult.TabIndex = 5;
            this.buttonResult.Text = "СЧИТАТЬ!";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // textHowMatchPage
            // 
            this.textHowMatchPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textHowMatchPage.Location = new System.Drawing.Point(400, 42);
            this.textHowMatchPage.Name = "textHowMatchPage";
            this.textHowMatchPage.Size = new System.Drawing.Size(81, 21);
            this.textHowMatchPage.TabIndex = 6;
            // 
            // textPagePrintAll
            // 
            this.textPagePrintAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPagePrintAll.Location = new System.Drawing.Point(6, 192);
            this.textPagePrintAll.Multiline = true;
            this.textPagePrintAll.Name = "textPagePrintAll";
            this.textPagePrintAll.ReadOnly = true;
            this.textPagePrintAll.Size = new System.Drawing.Size(512, 73);
            this.textPagePrintAll.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(483, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "\"0\" - всё сразу";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiobuttonHowDo);
            this.groupBox1.Controls.Add(this.radiobuttonResult);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(21, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 60);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Укажите, какой стороной принтер выдает страницы:";
            // 
            // radiobuttonHowDo
            // 
            this.radiobuttonHowDo.AutoSize = true;
            this.radiobuttonHowDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radiobuttonHowDo.Location = new System.Drawing.Point(153, 38);
            this.radiobuttonHowDo.Name = "radiobuttonHowDo";
            this.radiobuttonHowDo.Size = new System.Drawing.Size(123, 20);
            this.radiobuttonHowDo.TabIndex = 1;
            this.radiobuttonHowDo.TabStop = true;
            this.radiobuttonHowDo.Text = "текcтом  ВНИЗ";
            this.radiobuttonHowDo.UseVisualStyleBackColor = true;
            // 
            // radiobuttonResult
            // 
            this.radiobuttonResult.AutoSize = true;
            this.radiobuttonResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radiobuttonResult.Location = new System.Drawing.Point(153, 22);
            this.radiobuttonResult.Name = "radiobuttonResult";
            this.radiobuttonResult.Size = new System.Drawing.Size(128, 20);
            this.radiobuttonResult.TabIndex = 0;
            this.radiobuttonResult.TabStop = true;
            this.radiobuttonResult.Text = "текcтом ВВЕРХ";
            this.radiobuttonResult.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(91, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(492, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "ПЕРЕДНЯЯ сторона                                             ОБОРОТНАЯ сторона";
            // 
            // listBoxSide1
            // 
            this.listBoxSide1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxSide1.FormattingEnabled = true;
            this.listBoxSide1.ItemHeight = 15;
            this.listBoxSide1.Location = new System.Drawing.Point(6, 41);
            this.listBoxSide1.Name = "listBoxSide1";
            this.listBoxSide1.Size = new System.Drawing.Size(305, 94);
            this.listBoxSide1.TabIndex = 12;
            this.listBoxSide1.SelectedIndexChanged += new System.EventHandler(this.listBoxSide1_SelectedIndexChanged);
            // 
            // listBoxSide2
            // 
            this.listBoxSide2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxSide2.FormattingEnabled = true;
            this.listBoxSide2.ItemHeight = 15;
            this.listBoxSide2.Location = new System.Drawing.Point(340, 41);
            this.listBoxSide2.Name = "listBoxSide2";
            this.listBoxSide2.Size = new System.Drawing.Size(305, 94);
            this.listBoxSide2.TabIndex = 13;
            this.listBoxSide2.SelectedIndexChanged += new System.EventHandler(this.listBoxSide2_SelectedIndexChanged);
            // 
            // labelAttention1
            // 
            this.labelAttention1.AutoSize = true;
            this.labelAttention1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAttention1.Location = new System.Drawing.Point(2, 136);
            this.labelAttention1.Name = "labelAttention1";
            this.labelAttention1.Size = new System.Drawing.Size(118, 18);
            this.labelAttention1.TabIndex = 14;
            this.labelAttention1.Text = "labelAttention1";
            this.labelAttention1.Click += new System.EventHandler(this.labelAttention1_Click);
            // 
            // buttonHowDo
            // 
            this.buttonHowDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHowDo.Location = new System.Drawing.Point(248, 466);
            this.buttonHowDo.Name = "buttonHowDo";
            this.buttonHowDo.Size = new System.Drawing.Size(162, 34);
            this.buttonHowDo.TabIndex = 16;
            this.buttonHowDo.Text = "Как это работает?";
            this.buttonHowDo.UseVisualStyleBackColor = true;
            this.buttonHowDo.Click += new System.EventHandler(this.buttonHowDo_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAbout.Location = new System.Drawing.Point(12, 466);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(162, 34);
            this.buttonAbout.TabIndex = 17;
            this.buttonAbout.Text = "О программе";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonCopyBuffer);
            this.groupBox2.Controls.Add(this.labelAttention2);
            this.groupBox2.Controls.Add(this.listBoxSide2);
            this.groupBox2.Controls.Add(this.listBoxSide1);
            this.groupBox2.Controls.Add(this.labelWhatLine);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.labelAttention1);
            this.groupBox2.Controls.Add(this.textPagePrintAll);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(5, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(654, 271);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Номера страниц для печати:  (нажмите на нужную строку)";
            // 
            // buttonCopyBuffer
            // 
            this.buttonCopyBuffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCopyBuffer.Location = new System.Drawing.Point(524, 192);
            this.buttonCopyBuffer.Name = "buttonCopyBuffer";
            this.buttonCopyBuffer.Size = new System.Drawing.Size(122, 73);
            this.buttonCopyBuffer.TabIndex = 21;
            this.buttonCopyBuffer.Text = "Копировать номера страниц в буфер обмена";
            this.buttonCopyBuffer.UseVisualStyleBackColor = true;
            this.buttonCopyBuffer.Click += new System.EventHandler(this.buttonCopyBuffer_Click);
            // 
            // labelAttention2
            // 
            this.labelAttention2.AutoSize = true;
            this.labelAttention2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAttention2.Location = new System.Drawing.Point(2, 153);
            this.labelAttention2.Name = "labelAttention2";
            this.labelAttention2.Size = new System.Drawing.Size(118, 18);
            this.labelAttention2.TabIndex = 16;
            this.labelAttention2.Text = "labelAttention2";
            // 
            // labelWhatLine
            // 
            this.labelWhatLine.AutoSize = true;
            this.labelWhatLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWhatLine.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelWhatLine.Location = new System.Drawing.Point(2, 171);
            this.labelWhatLine.Name = "labelWhatLine";
            this.labelWhatLine.Size = new System.Drawing.Size(100, 18);
            this.labelWhatLine.TabIndex = 15;
            this.labelWhatLine.Text = "labelWhatLine";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(28, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "ВВЕДИТЕ";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.buttonExit.Location = new System.Drawing.Point(489, 466);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(162, 34);
            this.buttonExit.TabIndex = 20;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // step1
            // 
            this.step1.AutoSize = true;
            this.step1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.step1.ForeColor = System.Drawing.Color.Magenta;
            this.step1.Location = new System.Drawing.Point(5, 9);
            this.step1.Name = "step1";
            this.step1.Size = new System.Drawing.Size(27, 29);
            this.step1.TabIndex = 21;
            this.step1.Text = "1";
            // 
            // step2
            // 
            this.step2.AutoSize = true;
            this.step2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.step2.ForeColor = System.Drawing.Color.Magenta;
            this.step2.Location = new System.Drawing.Point(343, 20);
            this.step2.Name = "step2";
            this.step2.Size = new System.Drawing.Size(27, 29);
            this.step2.TabIndex = 22;
            this.step2.Text = "2";
            // 
            // step3
            // 
            this.step3.AutoSize = true;
            this.step3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.step3.ForeColor = System.Drawing.Color.Magenta;
            this.step3.Location = new System.Drawing.Point(4, 80);
            this.step3.Name = "step3";
            this.step3.Size = new System.Drawing.Size(27, 29);
            this.step3.TabIndex = 22;
            this.step3.Text = "3";
            // 
            // step4
            // 
            this.step4.AutoSize = true;
            this.step4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.step4.ForeColor = System.Drawing.Color.Magenta;
            this.step4.Location = new System.Drawing.Point(424, 87);
            this.step4.Name = "step4";
            this.step4.Size = new System.Drawing.Size(27, 29);
            this.step4.TabIndex = 23;
            this.step4.Text = "4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 508);
            this.Controls.Add(this.step4);
            this.Controls.Add(this.step3);
            this.Controls.Add(this.step2);
            this.Controls.Add(this.step1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonHowDo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textHowMatchPage);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.secondPage);
            this.Controls.Add(this.firstPage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelIncorrect);
            this.Name = "Form1";
            this.Text = "HelperPrintBooks from Maksim Hilkovich v.1.0.2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIncorrect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstPage;
        private System.Windows.Forms.TextBox secondPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.TextBox textHowMatchPage;
        private System.Windows.Forms.TextBox textPagePrintAll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radiobuttonHowDo;
        private System.Windows.Forms.RadioButton radiobuttonResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxSide1;
        private System.Windows.Forms.ListBox listBoxSide2;
        private System.Windows.Forms.Label labelAttention1;
        private System.Windows.Forms.Button buttonHowDo;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelAttention2;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonCopyBuffer;
        private System.Windows.Forms.Label labelWhatLine;
        private System.Windows.Forms.Label step1;
        private System.Windows.Forms.Label step2;
        private System.Windows.Forms.Label step3;
        private System.Windows.Forms.Label step4;
    }
}


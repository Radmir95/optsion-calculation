namespace OptionCalculation
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
            this.btn_step0 = new System.Windows.Forms.Button();
            this.tbso = new System.Windows.Forms.TextBox();
            this.tbb0 = new System.Windows.Forms.TextBox();
            this.tbn = new System.Windows.Forms.TextBox();
            this.tbk = new System.Windows.Forms.TextBox();
            this.tbb = new System.Windows.Forms.TextBox();
            this.tba = new System.Windows.Forms.TextBox();
            this.tbr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cn = new System.Windows.Forms.Label();
            this.step = new System.Windows.Forms.Label();
            this.betta = new System.Windows.Forms.Label();
            this.gamma = new System.Windows.Forms.Label();
            this.errortext = new System.Windows.Forms.Label();
            this.endtime = new System.Windows.Forms.Label();
            this.funcPay = new System.Windows.Forms.Label();
            this.bankb = new System.Windows.Forms.Label();
            this.moneyback = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_step0
            // 
            this.btn_step0.Location = new System.Drawing.Point(271, 278);
            this.btn_step0.Name = "btn_step0";
            this.btn_step0.Size = new System.Drawing.Size(75, 23);
            this.btn_step0.TabIndex = 0;
            this.btn_step0.Text = "Расчитать";
            this.btn_step0.UseVisualStyleBackColor = true;
            this.btn_step0.Click += new System.EventHandler(this.CalcValues);
            // 
            // tbso
            // 
            this.tbso.Location = new System.Drawing.Point(79, 33);
            this.tbso.Name = "tbso";
            this.tbso.Size = new System.Drawing.Size(100, 20);
            this.tbso.TabIndex = 1;
            this.tbso.Text = "100";
            // 
            // tbb0
            // 
            this.tbb0.Location = new System.Drawing.Point(79, 59);
            this.tbb0.Name = "tbb0";
            this.tbb0.Size = new System.Drawing.Size(100, 20);
            this.tbb0.TabIndex = 2;
            this.tbb0.Text = "10";
            // 
            // tbn
            // 
            this.tbn.Location = new System.Drawing.Point(79, 85);
            this.tbn.Name = "tbn";
            this.tbn.Size = new System.Drawing.Size(100, 20);
            this.tbn.TabIndex = 3;
            this.tbn.Text = "2";
            // 
            // tbk
            // 
            this.tbk.Location = new System.Drawing.Point(79, 111);
            this.tbk.Name = "tbk";
            this.tbk.Size = new System.Drawing.Size(100, 20);
            this.tbk.TabIndex = 4;
            this.tbk.Text = "110";
            // 
            // tbb
            // 
            this.tbb.Location = new System.Drawing.Point(79, 189);
            this.tbb.Name = "tbb";
            this.tbb.Size = new System.Drawing.Size(100, 20);
            this.tbb.TabIndex = 6;
            this.tbb.Text = "0,4";
            // 
            // tba
            // 
            this.tba.Location = new System.Drawing.Point(79, 163);
            this.tba.Name = "tba";
            this.tba.Size = new System.Drawing.Size(100, 20);
            this.tba.TabIndex = 7;
            this.tba.Text = "-0,3";
            // 
            // tbr
            // 
            this.tbr.Location = new System.Drawing.Point(79, 137);
            this.tbr.Name = "tbr";
            this.tbr.Size = new System.Drawing.Size(100, 20);
            this.tbr.TabIndex = 8;
            this.tbr.Text = "0,1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "S0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "N";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "B0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "a";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "r";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "K";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "b";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(79, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = " очистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_up
            // 
            this.btn_up.Enabled = false;
            this.btn_up.Location = new System.Drawing.Point(6, 29);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(75, 23);
            this.btn_up.TabIndex = 18;
            this.btn_up.Text = " Поднялась";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.CalcValues);
            // 
            // btn_down
            // 
            this.btn_down.Enabled = false;
            this.btn_down.Location = new System.Drawing.Point(101, 29);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(75, 23);
            this.btn_down.TabIndex = 19;
            this.btn_down.Text = "Упала";
            this.btn_down.UseVisualStyleBackColor = true;
            this.btn_down.Click += new System.EventHandler(this.CalcValues);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(228, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_down);
            this.groupBox1.Controls.Add(this.btn_up);
            this.groupBox1.Location = new System.Drawing.Point(220, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 79);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Цена";
            // 
            // cn
            // 
            this.cn.AutoSize = true;
            this.cn.Location = new System.Drawing.Point(228, 36);
            this.cn.Name = "cn";
            this.cn.Size = new System.Drawing.Size(34, 13);
            this.cn.TabIndex = 23;
            this.cn.Text = "CN = ";
            // 
            // step
            // 
            this.step.AutoSize = true;
            this.step.Location = new System.Drawing.Point(228, 66);
            this.step.Name = "step";
            this.step.Size = new System.Drawing.Size(42, 13);
            this.step.TabIndex = 25;
            this.step.Text = "Шаг =  ";
            // 
            // betta
            // 
            this.betta.AutoSize = true;
            this.betta.Location = new System.Drawing.Point(228, 118);
            this.betta.Name = "betta";
            this.betta.Size = new System.Drawing.Size(44, 13);
            this.betta.TabIndex = 26;
            this.betta.Text = "betta* =";
            // 
            // gamma
            // 
            this.gamma.AutoSize = true;
            this.gamma.Location = new System.Drawing.Point(228, 92);
            this.gamma.Name = "gamma";
            this.gamma.Size = new System.Drawing.Size(60, 13);
            this.gamma.TabIndex = 27;
            this.gamma.Text = "gamma* =  ";
            // 
            // errortext
            // 
            this.errortext.AutoSize = true;
            this.errortext.BackColor = System.Drawing.SystemColors.Control;
            this.errortext.ForeColor = System.Drawing.Color.Red;
            this.errortext.Location = new System.Drawing.Point(614, 33);
            this.errortext.Name = "errortext";
            this.errortext.Size = new System.Drawing.Size(155, 13);
            this.errortext.TabIndex = 28;
            this.errortext.Text = "Опцион не будет предъявлен";
            this.errortext.Visible = false;
            // 
            // endtime
            // 
            this.endtime.AutoSize = true;
            this.endtime.BackColor = System.Drawing.SystemColors.Control;
            this.endtime.ForeColor = System.Drawing.Color.Maroon;
            this.endtime.Location = new System.Drawing.Point(251, 9);
            this.endtime.Name = "endtime";
            this.endtime.Size = new System.Drawing.Size(155, 13);
            this.endtime.TabIndex = 29;
            this.endtime.Text = "Момент исполнения опциона";
            this.endtime.Visible = false;
            // 
            // funcPay
            // 
            this.funcPay.AutoSize = true;
            this.funcPay.Location = new System.Drawing.Point(294, 92);
            this.funcPay.Name = "funcPay";
            this.funcPay.Size = new System.Drawing.Size(0, 13);
            this.funcPay.TabIndex = 30;
            this.funcPay.Visible = false;
            // 
            // bankb
            // 
            this.bankb.AutoSize = true;
            this.bankb.BackColor = System.Drawing.SystemColors.Control;
            this.bankb.ForeColor = System.Drawing.Color.Red;
            this.bankb.Location = new System.Drawing.Point(579, 46);
            this.bankb.Name = "bankb";
            this.bankb.Size = new System.Drawing.Size(235, 13);
            this.bankb.TabIndex = 31;
            this.bankb.Text = "Сбрасываем все и расчитываемся с банком";
            this.bankb.Visible = false;
            // 
            // moneyback
            // 
            this.moneyback.AutoSize = true;
            this.moneyback.BackColor = System.Drawing.SystemColors.Control;
            this.moneyback.ForeColor = System.Drawing.Color.Red;
            this.moneyback.Location = new System.Drawing.Point(552, 255);
            this.moneyback.Name = "moneyback";
            this.moneyback.Size = new System.Drawing.Size(0, 13);
            this.moneyback.TabIndex = 32;
            this.moneyback.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 328);
            this.Controls.Add(this.moneyback);
            this.Controls.Add(this.bankb);
            this.Controls.Add(this.funcPay);
            this.Controls.Add(this.endtime);
            this.Controls.Add(this.errortext);
            this.Controls.Add(this.gamma);
            this.Controls.Add(this.betta);
            this.Controls.Add(this.step);
            this.Controls.Add(this.cn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbr);
            this.Controls.Add(this.tba);
            this.Controls.Add(this.tbb);
            this.Controls.Add(this.tbk);
            this.Controls.Add(this.tbn);
            this.Controls.Add(this.tbb0);
            this.Controls.Add(this.tbso);
            this.Controls.Add(this.btn_step0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_step0;
        private System.Windows.Forms.TextBox tbso;
        private System.Windows.Forms.TextBox tbb0;
        private System.Windows.Forms.TextBox tbn;
        private System.Windows.Forms.TextBox tbk;
        private System.Windows.Forms.TextBox tbb;
        private System.Windows.Forms.TextBox tba;
        private System.Windows.Forms.TextBox tbr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label cn;
        private System.Windows.Forms.Label step;
        private System.Windows.Forms.Label betta;
        private System.Windows.Forms.Label gamma;
        private System.Windows.Forms.Label errortext;
        private System.Windows.Forms.Label endtime;
        private System.Windows.Forms.Label funcPay;
        private System.Windows.Forms.Label bankb;
        private System.Windows.Forms.Label moneyback;
    }
}


namespace Figures
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textSPPT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSPPT = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textMX = new System.Windows.Forms.TextBox();
            this.textMY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textMZ = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonRX = new System.Windows.Forms.Button();
            this.textRX = new System.Windows.Forms.TextBox();
            this.buttonRY = new System.Windows.Forms.Button();
            this.textRY = new System.Windows.Forms.TextBox();
            this.buttonRZ = new System.Windows.Forms.Button();
            this.textRZ = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonRet = new System.Windows.Forms.Button();
            this.buttonSC = new System.Windows.Forms.Button();
            this.buttonWR = new System.Windows.Forms.Button();
            this.buttonShift = new System.Windows.Forms.Button();
            this.textSH = new System.Windows.Forms.TextBox();
            this.textSC = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picture = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dif = new System.Windows.Forms.TextBox();
            this.mir = new System.Windows.Forms.TextBox();
            this.deg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 313);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 106);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.deg);
            this.panel5.Controls.Add(this.mir);
            this.panel5.Controls.Add(this.dif);
            this.panel5.Controls.Add(this.checkBox2);
            this.panel5.Controls.Add(this.checkBox1);
            this.panel5.Controls.Add(this.textSPPT);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.buttonSPPT);
            this.panel5.Controls.Add(this.buttonMove);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.textMX);
            this.panel5.Controls.Add(this.textMY);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.textMZ);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(121, 0);
            this.panel5.Name = "panel5";
            this.panel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel5.Size = new System.Drawing.Size(361, 104);
            this.panel5.TabIndex = 20;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(153, 86);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(70, 17);
            this.checkBox2.TabIndex = 21;
            this.checkBox2.Text = "Z - Buffer";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 86);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(130, 17);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "The algorithm Roberts";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textSPPT
            // 
            this.textSPPT.Location = new System.Drawing.Point(163, 35);
            this.textSPPT.Name = "textSPPT";
            this.textSPPT.Size = new System.Drawing.Size(44, 20);
            this.textSPPT.TabIndex = 19;
            this.textSPPT.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(66, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Move on X";
            // 
            // buttonSPPT
            // 
            this.buttonSPPT.Location = new System.Drawing.Point(163, 10);
            this.buttonSPPT.Name = "buttonSPPT";
            this.buttonSPPT.Size = new System.Drawing.Size(44, 20);
            this.buttonSPPT.TabIndex = 18;
            this.buttonSPPT.Text = "SPPT";
            this.buttonSPPT.UseVisualStyleBackColor = true;
            this.buttonSPPT.Click += new System.EventHandler(this.buttonSPPT_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.AutoSize = true;
            this.buttonMove.Location = new System.Drawing.Point(15, 12);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(45, 23);
            this.buttonMove.TabIndex = 7;
            this.buttonMove.Text = "Move";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Move on Z";
            // 
            // textMX
            // 
            this.textMX.Location = new System.Drawing.Point(131, 10);
            this.textMX.Name = "textMX";
            this.textMX.Size = new System.Drawing.Size(26, 20);
            this.textMX.TabIndex = 8;
            this.textMX.Text = "0";
            // 
            // textMY
            // 
            this.textMY.Location = new System.Drawing.Point(131, 39);
            this.textMY.Name = "textMY";
            this.textMY.Size = new System.Drawing.Size(26, 20);
            this.textMY.TabIndex = 9;
            this.textMY.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Move on Y";
            // 
            // textMZ
            // 
            this.textMZ.Location = new System.Drawing.Point(131, 65);
            this.textMZ.Name = "textMZ";
            this.textMZ.Size = new System.Drawing.Size(26, 20);
            this.textMZ.TabIndex = 10;
            this.textMZ.Text = "0";
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.buttonRX);
            this.panel4.Controls.Add(this.textRX);
            this.panel4.Controls.Add(this.buttonRY);
            this.panel4.Controls.Add(this.textRY);
            this.panel4.Controls.Add(this.buttonRZ);
            this.panel4.Controls.Add(this.textRZ);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(121, 104);
            this.panel4.TabIndex = 19;
            // 
            // buttonRX
            // 
            this.buttonRX.Location = new System.Drawing.Point(11, 13);
            this.buttonRX.Name = "buttonRX";
            this.buttonRX.Size = new System.Drawing.Size(75, 20);
            this.buttonRX.TabIndex = 0;
            this.buttonRX.Text = "Rotate OX";
            this.buttonRX.UseVisualStyleBackColor = true;
            this.buttonRX.Click += new System.EventHandler(this.buttonRX_Click);
            // 
            // textRX
            // 
            this.textRX.Location = new System.Drawing.Point(92, 13);
            this.textRX.Name = "textRX";
            this.textRX.Size = new System.Drawing.Size(26, 20);
            this.textRX.TabIndex = 2;
            this.textRX.Text = "0";
            // 
            // buttonRY
            // 
            this.buttonRY.Location = new System.Drawing.Point(11, 42);
            this.buttonRY.Name = "buttonRY";
            this.buttonRY.Size = new System.Drawing.Size(75, 20);
            this.buttonRY.TabIndex = 3;
            this.buttonRY.Text = "Rotate OY";
            this.buttonRY.UseVisualStyleBackColor = true;
            this.buttonRY.Click += new System.EventHandler(this.buttonRY_Click);
            // 
            // textRY
            // 
            this.textRY.Location = new System.Drawing.Point(92, 42);
            this.textRY.Name = "textRY";
            this.textRY.Size = new System.Drawing.Size(26, 20);
            this.textRY.TabIndex = 4;
            this.textRY.Text = "0";
            // 
            // buttonRZ
            // 
            this.buttonRZ.Location = new System.Drawing.Point(11, 71);
            this.buttonRZ.Name = "buttonRZ";
            this.buttonRZ.Size = new System.Drawing.Size(75, 20);
            this.buttonRZ.TabIndex = 5;
            this.buttonRZ.Text = "Rotate OZ";
            this.buttonRZ.UseVisualStyleBackColor = true;
            this.buttonRZ.Click += new System.EventHandler(this.buttonRZ_Click);
            // 
            // textRZ
            // 
            this.textRZ.Location = new System.Drawing.Point(92, 71);
            this.textRZ.Name = "textRZ";
            this.textRZ.Size = new System.Drawing.Size(26, 20);
            this.textRZ.TabIndex = 6;
            this.textRZ.Text = "0";
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.buttonRet);
            this.panel3.Controls.Add(this.buttonSC);
            this.panel3.Controls.Add(this.buttonWR);
            this.panel3.Controls.Add(this.buttonShift);
            this.panel3.Controls.Add(this.textSH);
            this.panel3.Controls.Add(this.textSC);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(482, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(192, 104);
            this.panel3.TabIndex = 18;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // buttonRet
            // 
            this.buttonRet.Location = new System.Drawing.Point(128, 14);
            this.buttonRet.Name = "buttonRet";
            this.buttonRet.Size = new System.Drawing.Size(61, 46);
            this.buttonRet.TabIndex = 19;
            this.buttonRet.Text = "Return";
            this.buttonRet.UseVisualStyleBackColor = true;
            this.buttonRet.Click += new System.EventHandler(this.buttonRet_Click);
            // 
            // buttonSC
            // 
            this.buttonSC.Location = new System.Drawing.Point(6, 13);
            this.buttonSC.Name = "buttonSC";
            this.buttonSC.Size = new System.Drawing.Size(75, 20);
            this.buttonSC.TabIndex = 14;
            this.buttonSC.Text = "Scale";
            this.buttonSC.UseVisualStyleBackColor = true;
            this.buttonSC.Click += new System.EventHandler(this.buttonSC_Click);
            // 
            // buttonWR
            // 
            this.buttonWR.Location = new System.Drawing.Point(6, 72);
            this.buttonWR.Name = "buttonWR";
            this.buttonWR.Size = new System.Drawing.Size(75, 23);
            this.buttonWR.TabIndex = 17;
            this.buttonWR.Text = "Writing";
            this.buttonWR.UseVisualStyleBackColor = true;
            this.buttonWR.Click += new System.EventHandler(this.buttonWR_Click);
            // 
            // buttonShift
            // 
            this.buttonShift.Location = new System.Drawing.Point(6, 42);
            this.buttonShift.Name = "buttonShift";
            this.buttonShift.Size = new System.Drawing.Size(75, 20);
            this.buttonShift.TabIndex = 1;
            this.buttonShift.Text = "Shift";
            this.buttonShift.UseVisualStyleBackColor = true;
            this.buttonShift.Click += new System.EventHandler(this.buttonShift_Click);
            // 
            // textSH
            // 
            this.textSH.Location = new System.Drawing.Point(87, 42);
            this.textSH.Name = "textSH";
            this.textSH.Size = new System.Drawing.Size(35, 20);
            this.textSH.TabIndex = 16;
            this.textSH.Text = "0";
            // 
            // textSC
            // 
            this.textSC.Location = new System.Drawing.Point(87, 14);
            this.textSC.Name = "textSC";
            this.textSC.Size = new System.Drawing.Size(35, 20);
            this.textSC.TabIndex = 15;
            this.textSC.Text = "0";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picture);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 313);
            this.panel2.TabIndex = 2;
            // 
            // picture
            // 
            this.picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture.Location = new System.Drawing.Point(0, 0);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(676, 313);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dif
            // 
            this.dif.Location = new System.Drawing.Point(304, 10);
            this.dif.Name = "dif";
            this.dif.Size = new System.Drawing.Size(51, 20);
            this.dif.TabIndex = 22;
            this.dif.Text = "0";
            // 
            // mir
            // 
            this.mir.Location = new System.Drawing.Point(304, 39);
            this.mir.Name = "mir";
            this.mir.Size = new System.Drawing.Size(51, 20);
            this.mir.TabIndex = 23;
            this.mir.Text = "0";
            // 
            // deg
            // 
            this.deg.Location = new System.Drawing.Point(304, 65);
            this.deg.Name = "deg";
            this.deg.Size = new System.Drawing.Size(51, 20);
            this.deg.TabIndex = 24;
            this.deg.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(248, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "diffuse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(248, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "mirror";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(248, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "degree";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 419);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRX;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button buttonShift;
        private System.Windows.Forms.TextBox textRX;
        private System.Windows.Forms.TextBox textRZ;
        private System.Windows.Forms.Button buttonRZ;
        private System.Windows.Forms.TextBox textRY;
        private System.Windows.Forms.Button buttonRY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textMZ;
        private System.Windows.Forms.TextBox textMY;
        private System.Windows.Forms.TextBox textMX;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.TextBox textSC;
        private System.Windows.Forms.Button buttonSC;
        private System.Windows.Forms.TextBox textSH;
        private System.Windows.Forms.Button buttonWR;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonSPPT;
        private System.Windows.Forms.Button buttonRet;
        private System.Windows.Forms.TextBox textSPPT;
        public System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox deg;
        public System.Windows.Forms.TextBox mir;
        public System.Windows.Forms.TextBox dif;
    }
}


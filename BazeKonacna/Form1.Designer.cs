namespace BazeKonacna
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
            this.dugme2 = new System.Windows.Forms.Button();
            this.dugme3 = new System.Windows.Forms.Button();
            this.dugme1 = new System.Windows.Forms.Button();
            this.dugme4 = new System.Windows.Forms.Button();
            this.DodajOpstuPraksu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dugme2
            // 
            this.dugme2.Location = new System.Drawing.Point(25, 67);
            this.dugme2.Name = "dugme2";
            this.dugme2.Size = new System.Drawing.Size(187, 24);
            this.dugme2.TabIndex = 1;
            this.dugme2.Text = "ManyToOne";
            this.dugme2.UseVisualStyleBackColor = true;
            this.dugme2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dugme3
            // 
            this.dugme3.Location = new System.Drawing.Point(25, 109);
            this.dugme3.Name = "dugme3";
            this.dugme3.Size = new System.Drawing.Size(187, 24);
            this.dugme3.TabIndex = 2;
            this.dugme3.Text = "OneToMany";
            this.dugme3.UseVisualStyleBackColor = true;
            this.dugme3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dugme1
            // 
            this.dugme1.Location = new System.Drawing.Point(25, 22);
            this.dugme1.Name = "dugme1";
            this.dugme1.Size = new System.Drawing.Size(187, 26);
            this.dugme1.TabIndex = 3;
            this.dugme1.Text = "OneToOne";
            this.dugme1.UseVisualStyleBackColor = true;
            this.dugme1.Click += new System.EventHandler(this.button4_Click);
            // 
            // dugme4
            // 
            this.dugme4.Location = new System.Drawing.Point(25, 151);
            this.dugme4.Name = "dugme4";
            this.dugme4.Size = new System.Drawing.Size(187, 27);
            this.dugme4.TabIndex = 4;
            this.dugme4.Text = "ManyToMany";
            this.dugme4.UseVisualStyleBackColor = true;
            this.dugme4.Click += new System.EventHandler(this.button5_Click);
            // 
            // DodajOpstuPraksu
            // 
            this.DodajOpstuPraksu.Location = new System.Drawing.Point(25, 195);
            this.DodajOpstuPraksu.Name = "DodajOpstuPraksu";
            this.DodajOpstuPraksu.Size = new System.Drawing.Size(187, 26);
            this.DodajOpstuPraksu.TabIndex = 5;
            this.DodajOpstuPraksu.Text = "DodajStolicu";
            this.DodajOpstuPraksu.UseVisualStyleBackColor = true;
            this.DodajOpstuPraksu.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "UpdatePacijent";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 27);
            this.button2.TabIndex = 7;
            this.button2.Text = "DodajIntervencijuStomatologu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(25, 329);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 27);
            this.button3.TabIndex = 8;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(246, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(233, 27);
            this.button4.TabIndex = 9;
            this.button4.Text = "Upit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(246, 67);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(233, 24);
            this.button5.TabIndex = 10;
            this.button5.Text = "Upit sa Where";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(246, 109);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(233, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "Parametrizovani upiti";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(246, 152);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(233, 26);
            this.button7.TabIndex = 12;
            this.button7.Text = "Upiti sa imenovanim parametrima";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(246, 198);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(233, 23);
            this.button8.TabIndex = 13;
            this.button8.Text = "Enumerable";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(246, 241);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(233, 28);
            this.button9.TabIndex = 14;
            this.button9.Text = "Upiti koji vracaju samo jednu vrednost";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(246, 287);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(233, 27);
            this.button10.TabIndex = 15;
            this.button10.Text = "query over";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(246, 329);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(233, 29);
            this.button11.TabIndex = 16;
            this.button11.Text = "Native Sql";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(246, 377);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(233, 27);
            this.button12.TabIndex = 17;
            this.button12.Text = "Linq";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(517, 21);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(204, 23);
            this.button13.TabIndex = 18;
            this.button13.Text = "Criteria";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(517, 62);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(204, 29);
            this.button14.TabIndex = 19;
            this.button14.Text = "Stranicenje";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(25, 377);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(187, 23);
            this.button15.TabIndex = 20;
            this.button15.Text = "Transakcija";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(0, 0);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 0;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(517, 109);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(204, 23);
            this.button17.TabIndex = 21;
            this.button17.Text = "Visestruki rezultati";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 503);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DodajOpstuPraksu);
            this.Controls.Add(this.dugme4);
            this.Controls.Add(this.dugme1);
            this.Controls.Add(this.dugme3);
            this.Controls.Add(this.dugme2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button dugme2;
        private System.Windows.Forms.Button dugme3;
        private System.Windows.Forms.Button dugme1;
        private System.Windows.Forms.Button dugme4;
        private System.Windows.Forms.Button DodajOpstuPraksu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
    }
}


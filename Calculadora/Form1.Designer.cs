namespace Calculadora
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnc1 = new System.Windows.Forms.Button();
            this.btndivide = new System.Windows.Forms.Button();
            this.btnmultiply = new System.Windows.Forms.Button();
            this.btnsubstract = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnequals = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btndot = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.txtdisplay = new System.Windows.Forms.TextBox();
            this.btnc = new System.Windows.Forms.Button();
            this.btncuadrado = new System.Windows.Forms.Button();
            this.btnraiz = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.btnraiz);
            this.panel1.Controls.Add(this.btncuadrado);
            this.panel1.Controls.Add(this.btnc);
            this.panel1.Controls.Add(this.btnc1);
            this.panel1.Controls.Add(this.btndivide);
            this.panel1.Controls.Add(this.btnmultiply);
            this.panel1.Controls.Add(this.btnsubstract);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Controls.Add(this.btnequals);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btndot);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.btn0);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(13, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 291);
            this.panel1.TabIndex = 0;
            // 
            // btnc1
            // 
            this.btnc1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnc1.FlatAppearance.BorderSize = 0;
            this.btnc1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnc1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnc1.Location = new System.Drawing.Point(84, 32);
            this.btnc1.Name = "btnc1";
            this.btnc1.Size = new System.Drawing.Size(75, 46);
            this.btnc1.TabIndex = 16;
            this.btnc1.Text = "<-";
            this.btnc1.UseVisualStyleBackColor = false;
            this.btnc1.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btndivide
            // 
            this.btndivide.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndivide.FlatAppearance.BorderSize = 0;
            this.btndivide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndivide.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btndivide.Location = new System.Drawing.Point(246, 32);
            this.btndivide.Name = "btndivide";
            this.btndivide.Size = new System.Drawing.Size(75, 46);
            this.btndivide.TabIndex = 15;
            this.btndivide.Text = "/";
            this.btndivide.UseVisualStyleBackColor = false;
            this.btndivide.Click += new System.EventHandler(this.btndivide_Click);
            // 
            // btnmultiply
            // 
            this.btnmultiply.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmultiply.FlatAppearance.BorderSize = 0;
            this.btnmultiply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmultiply.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnmultiply.Location = new System.Drawing.Point(246, 84);
            this.btnmultiply.Name = "btnmultiply";
            this.btnmultiply.Size = new System.Drawing.Size(75, 46);
            this.btnmultiply.TabIndex = 14;
            this.btnmultiply.Text = "*";
            this.btnmultiply.UseVisualStyleBackColor = false;
            this.btnmultiply.Click += new System.EventHandler(this.btnmultiply_Click);
            // 
            // btnsubstract
            // 
            this.btnsubstract.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsubstract.FlatAppearance.BorderSize = 0;
            this.btnsubstract.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsubstract.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubstract.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsubstract.Location = new System.Drawing.Point(246, 139);
            this.btnsubstract.Name = "btnsubstract";
            this.btnsubstract.Size = new System.Drawing.Size(75, 46);
            this.btnsubstract.TabIndex = 13;
            this.btnsubstract.Text = "-";
            this.btnsubstract.UseVisualStyleBackColor = false;
            this.btnsubstract.Click += new System.EventHandler(this.btnsubstract_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnadd.Location = new System.Drawing.Point(246, 188);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 46);
            this.btnadd.TabIndex = 12;
            this.btnadd.Text = "+";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnequals
            // 
            this.btnequals.BackColor = System.Drawing.Color.Blue;
            this.btnequals.FlatAppearance.BorderSize = 0;
            this.btnequals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnequals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnequals.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnequals.Location = new System.Drawing.Point(246, 240);
            this.btnequals.Name = "btnequals";
            this.btnequals.Size = new System.Drawing.Size(75, 38);
            this.btnequals.TabIndex = 11;
            this.btnequals.Text = "=";
            this.btnequals.UseVisualStyleBackColor = false;
            this.btnequals.Click += new System.EventHandler(this.btnequals_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn9.Location = new System.Drawing.Point(165, 87);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 46);
            this.btn9.TabIndex = 10;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn8.Location = new System.Drawing.Point(84, 87);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 46);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn7.Location = new System.Drawing.Point(3, 87);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 46);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn6.Location = new System.Drawing.Point(165, 139);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 46);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn5.Location = new System.Drawing.Point(84, 139);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 46);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn4.Location = new System.Drawing.Point(3, 139);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 46);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn3.Location = new System.Drawing.Point(165, 188);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 46);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btndot
            // 
            this.btndot.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndot.FlatAppearance.BorderSize = 0;
            this.btndot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btndot.Location = new System.Drawing.Point(165, 240);
            this.btndot.Name = "btndot";
            this.btndot.Size = new System.Drawing.Size(75, 38);
            this.btndot.TabIndex = 3;
            this.btndot.Text = ".";
            this.btndot.UseVisualStyleBackColor = false;
            this.btndot.Click += new System.EventHandler(this.btndot_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn2.Location = new System.Drawing.Point(84, 191);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 46);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn1.Location = new System.Drawing.Point(3, 188);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 46);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn0.Location = new System.Drawing.Point(84, 240);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 38);
            this.btn0.TabIndex = 0;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // txtdisplay
            // 
            this.txtdisplay.BackColor = System.Drawing.Color.DarkGray;
            this.txtdisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdisplay.Location = new System.Drawing.Point(16, 104);
            this.txtdisplay.MaxLength = 21;
            this.txtdisplay.Multiline = true;
            this.txtdisplay.Name = "txtdisplay";
            this.txtdisplay.ReadOnly = true;
            this.txtdisplay.Size = new System.Drawing.Size(328, 45);
            this.txtdisplay.TabIndex = 1;
            this.txtdisplay.Text = "0";
            this.txtdisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnc
            // 
            this.btnc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnc.FlatAppearance.BorderSize = 0;
            this.btnc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnc.Location = new System.Drawing.Point(3, 32);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(75, 46);
            this.btnc.TabIndex = 17;
            this.btnc.Text = "C";
            this.btnc.UseVisualStyleBackColor = false;
            this.btnc.Click += new System.EventHandler(this.btnc_Click);
            // 
            // btncuadrado
            // 
            this.btncuadrado.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncuadrado.FlatAppearance.BorderSize = 0;
            this.btncuadrado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncuadrado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncuadrado.Location = new System.Drawing.Point(165, 32);
            this.btncuadrado.Name = "btncuadrado";
            this.btncuadrado.Size = new System.Drawing.Size(75, 46);
            this.btncuadrado.TabIndex = 18;
            this.btncuadrado.Text = "X²";
            this.btncuadrado.UseVisualStyleBackColor = false;
            this.btncuadrado.Click += new System.EventHandler(this.btncuadrado_Click);
            // 
            // btnraiz
            // 
            this.btnraiz.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnraiz.FlatAppearance.BorderSize = 0;
            this.btnraiz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnraiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnraiz.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnraiz.Location = new System.Drawing.Point(3, 240);
            this.btnraiz.Name = "btnraiz";
            this.btnraiz.Size = new System.Drawing.Size(75, 38);
            this.btnraiz.TabIndex = 19;
            this.btnraiz.Text = "√";
            this.btnraiz.UseVisualStyleBackColor = false;
            this.btnraiz.Click += new System.EventHandler(this.btnraiz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(356, 458);
            this.Controls.Add(this.txtdisplay);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btndot;
        private System.Windows.Forms.Button btndivide;
        private System.Windows.Forms.Button btnmultiply;
        private System.Windows.Forms.Button btnsubstract;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnequals;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnc1;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.TextBox txtdisplay;
        private System.Windows.Forms.Button btnraiz;
        private System.Windows.Forms.Button btncuadrado;
    }
}


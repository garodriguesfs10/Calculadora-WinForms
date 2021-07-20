
namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.lblvalor1 = new System.Windows.Forms.Label();
            this.lbloperacao2 = new System.Windows.Forms.Label();
            this.lblvalor2 = new System.Windows.Forms.Label();
            this.lbligual = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(12, 38);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(263, 20);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResultado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResultado_KeyPress);
            // 
            // lblOperacao
            // 
            this.lblOperacao.BackColor = System.Drawing.Color.Transparent;
            this.lblOperacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOperacao.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblOperacao.Location = new System.Drawing.Point(12, 38);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblOperacao.Size = new System.Drawing.Size(36, 20);
            this.lblOperacao.TabIndex = 1;
            this.lblOperacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(66, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(120, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 43);
            this.button3.TabIndex = 4;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(174, 71);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 43);
            this.button4.TabIndex = 5;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(228, 71);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(48, 43);
            this.button5.TabIndex = 6;
            this.button5.Text = "CE";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(174, 136);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(48, 43);
            this.button7.TabIndex = 10;
            this.button7.Text = "-";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(120, 136);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(48, 43);
            this.button8.TabIndex = 9;
            this.button8.Text = "6";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(66, 136);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(48, 43);
            this.button9.TabIndex = 8;
            this.button9.Text = "5";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(12, 136);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(48, 43);
            this.button10.TabIndex = 7;
            this.button10.Text = "4";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(174, 199);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(48, 43);
            this.button12.TabIndex = 15;
            this.button12.Text = "x";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(120, 199);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(48, 43);
            this.button13.TabIndex = 14;
            this.button13.Text = "3";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(66, 199);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(48, 43);
            this.button14.TabIndex = 13;
            this.button14.Text = "2";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(12, 199);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(48, 43);
            this.button15.TabIndex = 12;
            this.button15.Text = "1";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(228, 199);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(48, 104);
            this.button16.TabIndex = 21;
            this.button16.Text = "=";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(174, 260);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(48, 43);
            this.button17.TabIndex = 20;
            this.button17.Text = "/";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(120, 260);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(48, 43);
            this.button18.TabIndex = 19;
            this.button18.Text = ".";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(12, 260);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(102, 43);
            this.button20.TabIndex = 17;
            this.button20.Text = "0";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // lblvalor1
            // 
            this.lblvalor1.AutoSize = true;
            this.lblvalor1.Location = new System.Drawing.Point(128, 9);
            this.lblvalor1.MinimumSize = new System.Drawing.Size(35, 13);
            this.lblvalor1.Name = "lblvalor1";
            this.lblvalor1.Size = new System.Drawing.Size(35, 13);
            this.lblvalor1.TabIndex = 22;
            this.lblvalor1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblvalor1.Click += new System.EventHandler(this.lblvalor1_Click);
            // 
            // lbloperacao2
            // 
            this.lbloperacao2.AutoSize = true;
            this.lbloperacao2.Location = new System.Drawing.Point(169, 9);
            this.lbloperacao2.MinimumSize = new System.Drawing.Size(35, 13);
            this.lbloperacao2.Name = "lbloperacao2";
            this.lbloperacao2.Size = new System.Drawing.Size(35, 13);
            this.lbloperacao2.TabIndex = 23;
            this.lbloperacao2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblvalor2
            // 
            this.lblvalor2.AutoSize = true;
            this.lblvalor2.Location = new System.Drawing.Point(210, 9);
            this.lblvalor2.MinimumSize = new System.Drawing.Size(35, 13);
            this.lblvalor2.Name = "lblvalor2";
            this.lblvalor2.Size = new System.Drawing.Size(35, 13);
            this.lblvalor2.TabIndex = 24;
            this.lblvalor2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbligual
            // 
            this.lbligual.AutoSize = true;
            this.lbligual.Location = new System.Drawing.Point(262, 9);
            this.lbligual.Name = "lbligual";
            this.lbligual.Size = new System.Drawing.Size(13, 13);
            this.lbligual.TabIndex = 25;
            this.lbligual.Text = "=";
            this.lbligual.Click += new System.EventHandler(this.label4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(228, 136);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(48, 43);
            this.button6.TabIndex = 11;
            this.button6.Text = "C";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 323);
            this.Controls.Add(this.lbligual);
            this.Controls.Add(this.lblvalor2);
            this.Controls.Add(this.lbloperacao2);
            this.Controls.Add(this.lblvalor1);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblOperacao);
            this.Controls.Add(this.txtResultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Label lblvalor1;
        private System.Windows.Forms.Label lbloperacao2;
        private System.Windows.Forms.Label lblvalor2;
        private System.Windows.Forms.Label lbligual;
        private System.Windows.Forms.Button button6;
    }
}


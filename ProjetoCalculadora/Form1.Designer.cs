
namespace ProjetoCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.adicao = new System.Windows.Forms.Button();
            this.subtracao = new System.Windows.Forms.Button();
            this.multiplicacao = new System.Windows.Forms.Button();
            this.divisao = new System.Windows.Forms.Button();
            this.expoente = new System.Windows.Forms.Button();
            this.radicaliza = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adicao
            // 
            this.adicao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.adicao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adicao.BackgroundImage")));
            this.adicao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.adicao.ForeColor = System.Drawing.SystemColors.Info;
            this.adicao.Location = new System.Drawing.Point(27, 59);
            this.adicao.Name = "adicao";
            this.adicao.Size = new System.Drawing.Size(117, 78);
            this.adicao.TabIndex = 0;
            this.adicao.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.adicao.UseVisualStyleBackColor = false;
            this.adicao.Click += new System.EventHandler(this.button1_Click);
            // 
            // subtracao
            // 
            this.subtracao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("subtracao.BackgroundImage")));
            this.subtracao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.subtracao.Location = new System.Drawing.Point(157, 59);
            this.subtracao.Name = "subtracao";
            this.subtracao.Size = new System.Drawing.Size(117, 78);
            this.subtracao.TabIndex = 1;
            this.subtracao.UseVisualStyleBackColor = true;
            this.subtracao.Click += new System.EventHandler(this.subtracao_Click);
            // 
            // multiplicacao
            // 
            this.multiplicacao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("multiplicacao.BackgroundImage")));
            this.multiplicacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.multiplicacao.Location = new System.Drawing.Point(285, 59);
            this.multiplicacao.Name = "multiplicacao";
            this.multiplicacao.Size = new System.Drawing.Size(117, 78);
            this.multiplicacao.TabIndex = 2;
            this.multiplicacao.UseVisualStyleBackColor = true;
            this.multiplicacao.Click += new System.EventHandler(this.multiplicacao_Click);
            // 
            // divisao
            // 
            this.divisao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("divisao.BackgroundImage")));
            this.divisao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.divisao.Location = new System.Drawing.Point(27, 143);
            this.divisao.Name = "divisao";
            this.divisao.Size = new System.Drawing.Size(117, 78);
            this.divisao.TabIndex = 3;
            this.divisao.UseVisualStyleBackColor = true;
            this.divisao.Click += new System.EventHandler(this.divisao_Click);
            // 
            // expoente
            // 
            this.expoente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("expoente.BackgroundImage")));
            this.expoente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.expoente.Location = new System.Drawing.Point(155, 143);
            this.expoente.Name = "expoente";
            this.expoente.Size = new System.Drawing.Size(117, 78);
            this.expoente.TabIndex = 4;
            this.expoente.UseVisualStyleBackColor = true;
            this.expoente.Click += new System.EventHandler(this.expoente_Click);
            // 
            // radicaliza
            // 
            this.radicaliza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radicaliza.BackgroundImage")));
            this.radicaliza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.radicaliza.Cursor = System.Windows.Forms.Cursors.Default;
            this.radicaliza.Location = new System.Drawing.Point(285, 143);
            this.radicaliza.Name = "radicaliza";
            this.radicaliza.Size = new System.Drawing.Size(117, 78);
            this.radicaliza.TabIndex = 5;
            this.radicaliza.UseVisualStyleBackColor = true;
            this.radicaliza.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(224, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(91, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "primerio numero:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "segundo numero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 37);
            this.label3.TabIndex = 10;
            this.label3.Text = "Resultado";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 333);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radicaliza);
            this.Controls.Add(this.expoente);
            this.Controls.Add(this.divisao);
            this.Controls.Add(this.multiplicacao);
            this.Controls.Add(this.subtracao);
            this.Controls.Add(this.adicao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adicao;
        private System.Windows.Forms.Button subtracao;
        private System.Windows.Forms.Button multiplicacao;
        private System.Windows.Forms.Button divisao;
        private System.Windows.Forms.Button expoente;
        private System.Windows.Forms.Button radicaliza;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


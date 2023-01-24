
namespace WindowsFormsApp2
{
    partial class Generationform
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.N = new System.Windows.Forms.TextBox();
            this.Xнулевое = new System.Windows.Forms.TextBox();
            this.Вывод_Дан = new System.Windows.Forms.RichTextBox();
            this.X0 = new System.Windows.Forms.Label();
            this.N0 = new System.Windows.Forms.Label();
            this.выход = new System.Windows.Forms.Button();
            this.ButGen = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(6)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 100);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(659, 60);
            this.label2.TabIndex = 0;
            this.label2.Text = "Алгоритм Блюм-Блюма-Шуба";
            // 
            // N
            // 
            this.N.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.N.Location = new System.Drawing.Point(92, 150);
            this.N.Multiline = true;
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(155, 35);
            this.N.TabIndex = 3;
            this.N.TextChanged += new System.EventHandler(this.N_TextChanged);
            // 
            // Xнулевое
            // 
            this.Xнулевое.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Xнулевое.Location = new System.Drawing.Point(549, 152);
            this.Xнулевое.Multiline = true;
            this.Xнулевое.Name = "Xнулевое";
            this.Xнулевое.Size = new System.Drawing.Size(155, 35);
            this.Xнулевое.TabIndex = 4;
            this.Xнулевое.TextChanged += new System.EventHandler(this.Xнулевое_TextChanged);
            // 
            // Вывод_Дан
            // 
            this.Вывод_Дан.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Вывод_Дан.Location = new System.Drawing.Point(12, 276);
            this.Вывод_Дан.Name = "Вывод_Дан";
            this.Вывод_Дан.Size = new System.Drawing.Size(776, 99);
            this.Вывод_Дан.TabIndex = 5;
            this.Вывод_Дан.Text = "";
            this.Вывод_Дан.TextChanged += new System.EventHandler(this.Вывод_Дан_TextChanged);
            // 
            // X0
            // 
            this.X0.AutoSize = true;
            this.X0.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X0.ForeColor = System.Drawing.Color.White;
            this.X0.Location = new System.Drawing.Point(557, 106);
            this.X0.Name = "X0";
            this.X0.Size = new System.Drawing.Size(147, 33);
            this.X0.TabIndex = 6;
            this.X0.Text = "Введите X0";
            // 
            // N0
            // 
            this.N0.AutoSize = true;
            this.N0.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.N0.ForeColor = System.Drawing.Color.White;
            this.N0.Location = new System.Drawing.Point(96, 106);
            this.N0.Name = "N0";
            this.N0.Size = new System.Drawing.Size(134, 33);
            this.N0.TabIndex = 7;
            this.N0.Text = "Введите N";
            // 
            // выход
            // 
            this.выход.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.выход.Location = new System.Drawing.Point(630, 381);
            this.выход.Name = "выход";
            this.выход.Size = new System.Drawing.Size(158, 57);
            this.выход.TabIndex = 8;
            this.выход.Text = "Выход";
            this.выход.UseVisualStyleBackColor = true;
            this.выход.Click += new System.EventHandler(this.выход_Click);
            // 
            // ButGen
            // 
            this.ButGen.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButGen.Location = new System.Drawing.Point(280, 189);
            this.ButGen.Name = "ButGen";
            this.ButGen.Size = new System.Drawing.Size(243, 54);
            this.ButGen.TabIndex = 9;
            this.ButGen.Text = "Сгенерировать";
            this.ButGen.UseVisualStyleBackColor = true;
            this.ButGen.Click += new System.EventHandler(this.ButGen_Click);
            // 
            // Generationform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(6)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButGen);
            this.Controls.Add(this.выход);
            this.Controls.Add(this.N0);
            this.Controls.Add(this.X0);
            this.Controls.Add(this.Вывод_Дан);
            this.Controls.Add(this.Xнулевое);
            this.Controls.Add(this.N);
            this.Controls.Add(this.panel2);
            this.Name = "Generationform";
            this.Text = "Generationform";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox N;
        private System.Windows.Forms.TextBox Xнулевое;
        private System.Windows.Forms.RichTextBox Вывод_Дан;
        private System.Windows.Forms.Label X0;
        private System.Windows.Forms.Label N0;
        private System.Windows.Forms.Button выход;
        private System.Windows.Forms.Button ButGen;
    }
}
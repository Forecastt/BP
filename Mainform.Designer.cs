
namespace WindowsFormsApp2
{
    partial class Mainform
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
            this.выход = new System.Windows.Forms.Button();
            this.регистрация = new System.Windows.Forms.Button();
            this.авторизация = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(6)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.выход);
            this.panel1.Controls.Add(this.регистрация);
            this.panel1.Controls.Add(this.авторизация);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // выход
            // 
            this.выход.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.выход.Location = new System.Drawing.Point(614, 384);
            this.выход.Name = "выход";
            this.выход.Size = new System.Drawing.Size(174, 54);
            this.выход.TabIndex = 3;
            this.выход.Text = "Выход";
            this.выход.UseVisualStyleBackColor = true;
            this.выход.Click += new System.EventHandler(this.выход_Click);
            // 
            // регистрация
            // 
            this.регистрация.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.регистрация.Location = new System.Drawing.Point(282, 271);
            this.регистрация.Name = "регистрация";
            this.регистрация.Size = new System.Drawing.Size(260, 56);
            this.регистрация.TabIndex = 2;
            this.регистрация.Text = "Регистрация";
            this.регистрация.UseVisualStyleBackColor = true;
            this.регистрация.Click += new System.EventHandler(this.регистрация_Click);
            // 
            // авторизация
            // 
            this.авторизация.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.авторизация.Location = new System.Drawing.Point(282, 196);
            this.авторизация.Name = "авторизация";
            this.авторизация.Size = new System.Drawing.Size(260, 56);
            this.авторизация.TabIndex = 1;
            this.авторизация.Text = "Авторизация";
            this.авторизация.UseVisualStyleBackColor = true;
            this.авторизация.Click += new System.EventHandler(this.авторизация_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(6)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 100);
            this.panel2.TabIndex = 0;
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
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Mainform";
            this.Text = "Mainform";
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button выход;
        private System.Windows.Forms.Button регистрация;
        private System.Windows.Forms.Button авторизация;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}
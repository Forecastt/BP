
namespace WindowsFormsApp2
{
    partial class Regform
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
            this.выход = new System.Windows.Forms.Button();
            this.RegField = new System.Windows.Forms.Button();
            this.PassField = new System.Windows.Forms.TextBox();
            this.LogField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Backtomenu = new System.Windows.Forms.Button();
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
            this.panel2.TabIndex = 1;
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
            // выход
            // 
            this.выход.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.выход.Location = new System.Drawing.Point(630, 381);
            this.выход.Name = "выход";
            this.выход.Size = new System.Drawing.Size(158, 57);
            this.выход.TabIndex = 4;
            this.выход.Text = "Выход";
            this.выход.UseVisualStyleBackColor = true;
            this.выход.Click += new System.EventHandler(this.выход_Click);
            // 
            // RegField
            // 
            this.RegField.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegField.Location = new System.Drawing.Point(235, 286);
            this.RegField.Name = "RegField";
            this.RegField.Size = new System.Drawing.Size(377, 53);
            this.RegField.TabIndex = 11;
            this.RegField.Text = "Зарегестрироваться";
            this.RegField.UseVisualStyleBackColor = true;
            this.RegField.Click += new System.EventHandler(this.RegField_Click);
            // 
            // PassField
            // 
            this.PassField.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassField.Location = new System.Drawing.Point(366, 227);
            this.PassField.Name = "PassField";
            this.PassField.Size = new System.Drawing.Size(246, 53);
            this.PassField.TabIndex = 10;
            this.PassField.UseSystemPasswordChar = true;
            this.PassField.TextChanged += new System.EventHandler(this.PassField_TextChanged);
            // 
            // LogField
            // 
            this.LogField.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogField.Location = new System.Drawing.Point(366, 171);
            this.LogField.Multiline = true;
            this.LogField.Name = "LogField";
            this.LogField.Size = new System.Drawing.Size(246, 46);
            this.LogField.TabIndex = 9;
            this.LogField.TextChanged += new System.EventHandler(this.LogField_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(190, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 46);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(251, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "Login:";
            // 
            // Backtomenu
            // 
            this.Backtomenu.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Backtomenu.Location = new System.Drawing.Point(12, 381);
            this.Backtomenu.Name = "Backtomenu";
            this.Backtomenu.Size = new System.Drawing.Size(207, 57);
            this.Backtomenu.TabIndex = 12;
            this.Backtomenu.Text = "В меню";
            this.Backtomenu.UseVisualStyleBackColor = true;
            this.Backtomenu.Click += new System.EventHandler(this.Backtomenu_Click);
            // 
            // Regform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(6)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Backtomenu);
            this.Controls.Add(this.RegField);
            this.Controls.Add(this.PassField);
            this.Controls.Add(this.LogField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.выход);
            this.Controls.Add(this.panel2);
            this.Name = "Regform";
            this.Text = "Regform";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button выход;
        private System.Windows.Forms.Button RegField;
        private System.Windows.Forms.TextBox PassField;
        private System.Windows.Forms.TextBox LogField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Backtomenu;
    }
}
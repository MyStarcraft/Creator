namespace MyStarcraft_Creator
{
    partial class NewPlayer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAggressive = new System.Windows.Forms.TextBox();
            this.textBoxDefensive = new System.Windows.Forms.TextBox();
            this.textBoxAggro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFight = new System.Windows.Forms.TextBox();
            this.textBoxReconnaissance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "공격력";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "방어력";
            // 
            // textBoxAggressive
            // 
            this.textBoxAggressive.Location = new System.Drawing.Point(236, 37);
            this.textBoxAggressive.Name = "textBoxAggressive";
            this.textBoxAggressive.Size = new System.Drawing.Size(100, 21);
            this.textBoxAggressive.TabIndex = 5;
            // 
            // textBoxDefensive
            // 
            this.textBoxDefensive.Location = new System.Drawing.Point(236, 64);
            this.textBoxDefensive.Name = "textBoxDefensive";
            this.textBoxDefensive.Size = new System.Drawing.Size(100, 21);
            this.textBoxDefensive.TabIndex = 6;
            // 
            // textBoxAggro
            // 
            this.textBoxAggro.Location = new System.Drawing.Point(236, 91);
            this.textBoxAggro.Name = "textBoxAggro";
            this.textBoxAggro.Size = new System.Drawing.Size(100, 21);
            this.textBoxAggro.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "견제";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "승부수 빈도";
            // 
            // textBoxFight
            // 
            this.textBoxFight.Location = new System.Drawing.Point(236, 118);
            this.textBoxFight.Name = "textBoxFight";
            this.textBoxFight.Size = new System.Drawing.Size(100, 21);
            this.textBoxFight.TabIndex = 10;
            // 
            // textBoxReconnaissance
            // 
            this.textBoxReconnaissance.Location = new System.Drawing.Point(236, 145);
            this.textBoxReconnaissance.Name = "textBoxReconnaissance";
            this.textBoxReconnaissance.Size = new System.Drawing.Size(100, 21);
            this.textBoxReconnaissance.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "정찰";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "능력치 분배(0~1000)";
            // 
            // NewPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxReconnaissance);
            this.Controls.Add(this.textBoxFight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAggro);
            this.Controls.Add(this.textBoxDefensive);
            this.Controls.Add(this.textBoxAggressive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "NewPlayer";
            this.Size = new System.Drawing.Size(542, 879);
            this.Load += new System.EventHandler(this.NewPlayer_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.textBoxAggressive, 0);
            this.Controls.SetChildIndex(this.textBoxDefensive, 0);
            this.Controls.SetChildIndex(this.textBoxAggro, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.textBoxFight, 0);
            this.Controls.SetChildIndex(this.textBoxReconnaissance, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAggressive;
        private System.Windows.Forms.TextBox textBoxDefensive;
        private System.Windows.Forms.TextBox textBoxAggro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFight;
        private System.Windows.Forms.TextBox textBoxReconnaissance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

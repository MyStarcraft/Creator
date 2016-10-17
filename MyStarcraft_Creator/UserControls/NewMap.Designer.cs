namespace MyStarcraft_Creator.UserControls
{
    partial class NewMap
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
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.textBoxComplexity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxResources = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "맵 구성 분배(0~100)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "러쉬거리";
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBoxDistance.Location = new System.Drawing.Point(236, 37);
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.Size = new System.Drawing.Size(100, 21);
            this.textBoxDistance.TabIndex = 16;
            // 
            // textBoxComplexity
            // 
            this.textBoxComplexity.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBoxComplexity.Location = new System.Drawing.Point(236, 64);
            this.textBoxComplexity.Name = "textBoxComplexity";
            this.textBoxComplexity.Size = new System.Drawing.Size(100, 21);
            this.textBoxComplexity.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "복잡도";
            // 
            // textBoxResources
            // 
            this.textBoxResources.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBoxResources.Location = new System.Drawing.Point(236, 91);
            this.textBoxResources.Name = "textBoxResources";
            this.textBoxResources.Size = new System.Drawing.Size(100, 21);
            this.textBoxResources.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "자원량";
            // 
            // NewMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxResources);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxComplexity);
            this.Controls.Add(this.textBoxDistance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Name = "NewMap";
            this.Size = new System.Drawing.Size(1502, 879);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.textBoxDistance, 0);
            this.Controls.SetChildIndex(this.textBoxComplexity, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.textBoxResources, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDistance;
        private System.Windows.Forms.TextBox textBoxComplexity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxResources;
        private System.Windows.Forms.Label label4;
    }
}

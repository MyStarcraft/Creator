namespace MyStarcraft_Creator.UserControls
{
    partial class NewUserControl
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
            this.imageProfile = new System.Windows.Forms.PictureBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // imageProfile
            // 
            this.imageProfile.InitialImage = global::MyStarcraft_Creator.Properties.Resources.default_profile;
            this.imageProfile.Location = new System.Drawing.Point(4, 4);
            this.imageProfile.Name = "imageProfile";
            this.imageProfile.Size = new System.Drawing.Size(151, 162);
            this.imageProfile.TabIndex = 0;
            this.imageProfile.TabStop = false;
            this.imageProfile.WaitOnLoad = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(38, 172);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(117, 21);
            this.textBoxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "이름";
            // 
            // NewUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.imageProfile);
            this.Name = "NewUserControl";
            this.Size = new System.Drawing.Size(364, 259);
            ((System.ComponentModel.ISupportInitialize)(this.imageProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imageProfile;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
    }
}

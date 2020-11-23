namespace tech_of_prog1
{
    partial class FormParking
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonPlaneParking = new System.Windows.Forms.Button();
            this.buttonFighterParking = new System.Windows.Forms.Button();
            this.groupBoxTake = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.buttonTake = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxTake.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(863, 482);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonPlaneParking
            // 
            this.buttonPlaneParking.Location = new System.Drawing.Point(876, 12);
            this.buttonPlaneParking.Name = "buttonPlaneParking";
            this.buttonPlaneParking.Size = new System.Drawing.Size(107, 43);
            this.buttonPlaneParking.TabIndex = 1;
            this.buttonPlaneParking.Text = "Припарковать самолет";
            this.buttonPlaneParking.UseVisualStyleBackColor = true;
            this.buttonPlaneParking.Click += new System.EventHandler(this.buttonPlaneParking_Click);
            // 
            // buttonFighterParking
            // 
            this.buttonFighterParking.Location = new System.Drawing.Point(877, 78);
            this.buttonFighterParking.Name = "buttonFighterParking";
            this.buttonFighterParking.Size = new System.Drawing.Size(106, 46);
            this.buttonFighterParking.TabIndex = 2;
            this.buttonFighterParking.Text = "Припарковать истрибитель";
            this.buttonFighterParking.UseVisualStyleBackColor = true;
            this.buttonFighterParking.Click += new System.EventHandler(this.buttonFighterParking_Click);
            // 
            // groupBoxTake
            // 
            this.groupBoxTake.Controls.Add(this.maskedTextBox1);
            this.groupBoxTake.Controls.Add(this.buttonTake);
            this.groupBoxTake.Controls.Add(this.label1);
            this.groupBoxTake.Location = new System.Drawing.Point(868, 145);
            this.groupBoxTake.Name = "groupBoxTake";
            this.groupBoxTake.Size = new System.Drawing.Size(115, 89);
            this.groupBoxTake.TabIndex = 3;
            this.groupBoxTake.TabStop = false;
            this.groupBoxTake.Text = "Забрать самолет";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(49, 19);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(39, 20);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // buttonTake
            // 
            this.buttonTake.Location = new System.Drawing.Point(13, 57);
            this.buttonTake.Name = "buttonTake";
            this.buttonTake.Size = new System.Drawing.Size(74, 26);
            this.buttonTake.TabIndex = 2;
            this.buttonTake.Text = "Забрать";
            this.buttonTake.UseVisualStyleBackColor = true;
            this.buttonTake.Click += new System.EventHandler(this.buttonTake_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 483);
            this.Controls.Add(this.groupBoxTake);
            this.Controls.Add(this.buttonFighterParking);
            this.Controls.Add(this.buttonPlaneParking);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormParking";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxTake.ResumeLayout(false);
            this.groupBoxTake.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonPlaneParking;
        private System.Windows.Forms.Button buttonFighterParking;
        private System.Windows.Forms.GroupBox groupBoxTake;
        private System.Windows.Forms.Button buttonTake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}
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
			this.pictureBoxParking = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.TakePlane = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.listBoxParkings = new System.Windows.Forms.ListBox();
			this.buttonAddParking = new System.Windows.Forms.Button();
			this.buttonDelParking = new System.Windows.Forms.Button();
			this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.AddPlane = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBoxParking
			// 
			this.pictureBoxParking.Location = new System.Drawing.Point(-1, 0);
			this.pictureBoxParking.Name = "pictureBoxParking";
			this.pictureBoxParking.Size = new System.Drawing.Size(862, 489);
			this.pictureBoxParking.TabIndex = 0;
			this.pictureBoxParking.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.maskedTextBox1);
			this.groupBox1.Controls.Add(this.TakePlane);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(868, 382);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(115, 89);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Забрать самолет";
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.Location = new System.Drawing.Point(49, 19);
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(39, 20);
			this.maskedTextBox1.TabIndex = 3;
			// 
			// TakePlane
			// 
			this.TakePlane.Location = new System.Drawing.Point(14, 57);
			this.TakePlane.Name = "TakePlane";
			this.TakePlane.Size = new System.Drawing.Size(74, 26);
			this.TakePlane.TabIndex = 2;
			this.TakePlane.Text = "Забрать";
			this.TakePlane.UseVisualStyleBackColor = true;
			this.TakePlane.Click += new System.EventHandler(this.buttonTakePlane_Click);
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
			// listBoxParkings
			// 
			this.listBoxParkings.FormattingEnabled = true;
			this.listBoxParkings.Location = new System.Drawing.Point(868, 91);
			this.listBoxParkings.Name = "listBoxParkings";
			this.listBoxParkings.Size = new System.Drawing.Size(115, 95);
			this.listBoxParkings.TabIndex = 4;
			this.listBoxParkings.Click += new System.EventHandler(this.listBoxParkings_SelectedIndexChanged);
			// 
			// buttonAddParking
			// 
			this.buttonAddParking.Location = new System.Drawing.Point(868, 59);
			this.buttonAddParking.Name = "buttonAddParking";
			this.buttonAddParking.Size = new System.Drawing.Size(115, 22);
			this.buttonAddParking.TabIndex = 5;
			this.buttonAddParking.Text = "Добавить парковку";
			this.buttonAddParking.UseVisualStyleBackColor = true;
			this.buttonAddParking.Click += new System.EventHandler(this.buttonAddParking_Click);
			// 
			// buttonDelParking
			// 
			this.buttonDelParking.Location = new System.Drawing.Point(867, 196);
			this.buttonDelParking.Name = "buttonDelParking";
			this.buttonDelParking.Size = new System.Drawing.Size(116, 20);
			this.buttonDelParking.TabIndex = 6;
			this.buttonDelParking.Text = "Удалить парковку";
			this.buttonDelParking.UseVisualStyleBackColor = true;
			this.buttonDelParking.Click += new System.EventHandler(this.buttonDelParking_Click);
			// 
			// textBoxNewLevelName
			// 
			this.textBoxNewLevelName.Location = new System.Drawing.Point(868, 33);
			this.textBoxNewLevelName.Name = "textBoxNewLevelName";
			this.textBoxNewLevelName.Size = new System.Drawing.Size(113, 20);
			this.textBoxNewLevelName.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(899, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Парковки";
			// 
			// AddPlane
			// 
			this.AddPlane.Location = new System.Drawing.Point(874, 281);
			this.AddPlane.Name = "AddPlane";
			this.AddPlane.Size = new System.Drawing.Size(106, 39);
			this.AddPlane.TabIndex = 9;
			this.AddPlane.Text = "Добавить самолет";
			this.AddPlane.UseVisualStyleBackColor = true;
			this.AddPlane.Click += new System.EventHandler(this.AddPlane_Click);
			// 
			// FormParking
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(995, 501);
			this.Controls.Add(this.AddPlane);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxNewLevelName);
			this.Controls.Add(this.buttonDelParking);
			this.Controls.Add(this.buttonAddParking);
			this.Controls.Add(this.listBoxParkings);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBoxParking);
			this.Name = "FormParking";
			this.Text = "Парковка";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button TakePlane;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ListBox listBoxParkings;
        private System.Windows.Forms.Button buttonAddParking;
        private System.Windows.Forms.Button buttonDelParking;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button AddPlane;
	}
}
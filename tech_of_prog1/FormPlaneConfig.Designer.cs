namespace tech_of_prog1
{
	partial class FormPlaneConfig
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
            this.groupBoxParam = new System.Windows.Forms.GroupBox();
            this.checkBoxNose = new System.Windows.Forms.CheckBox();
            this.checkBoxGuns = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxPlane = new System.Windows.Forms.PictureBox();
            this.groupBoxPlane = new System.Windows.Forms.GroupBox();
            this.labelFighter = new System.Windows.Forms.Label();
            this.labelPlane = new System.Windows.Forms.Label();
            this.panelPlane = new System.Windows.Forms.Panel();
            this.panelMainColorRed = new System.Windows.Forms.Panel();
            this.panelMainColorYellow = new System.Windows.Forms.Panel();
            this.panelDopColorBlack = new System.Windows.Forms.Panel();
            this.panelDopColorWhite = new System.Windows.Forms.Panel();
            this.panelMainColorGray = new System.Windows.Forms.Panel();
            this.panelMainColorOrange = new System.Windows.Forms.Panel();
            this.panelDopColorGreen = new System.Windows.Forms.Panel();
            this.panelDopColorBlue = new System.Windows.Forms.Panel();
            this.groupColors = new System.Windows.Forms.GroupBox();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).BeginInit();
            this.groupBoxPlane.SuspendLayout();
            this.panelPlane.SuspendLayout();
            this.groupColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxParam
            // 
            this.groupBoxParam.Controls.Add(this.checkBoxNose);
            this.groupBoxParam.Controls.Add(this.checkBoxGuns);
            this.groupBoxParam.Controls.Add(this.numericUpDownWeight);
            this.groupBoxParam.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBoxParam.Controls.Add(this.label2);
            this.groupBoxParam.Controls.Add(this.label1);
            this.groupBoxParam.Location = new System.Drawing.Point(72, 267);
            this.groupBoxParam.Name = "groupBoxParam";
            this.groupBoxParam.Size = new System.Drawing.Size(288, 139);
            this.groupBoxParam.TabIndex = 0;
            this.groupBoxParam.TabStop = false;
            this.groupBoxParam.Text = "Параметры";
            // 
            // checkBoxNose
            // 
            this.checkBoxNose.AutoSize = true;
            this.checkBoxNose.Location = new System.Drawing.Point(181, 92);
            this.checkBoxNose.Name = "checkBoxNose";
            this.checkBoxNose.Size = new System.Drawing.Size(86, 17);
            this.checkBoxNose.TabIndex = 5;
            this.checkBoxNose.Text = "Острый нос";
            this.checkBoxNose.UseVisualStyleBackColor = true;
            // 
            // checkBoxGuns
            // 
            this.checkBoxGuns.AutoSize = true;
            this.checkBoxGuns.Location = new System.Drawing.Point(181, 40);
            this.checkBoxGuns.Name = "checkBoxGuns";
            this.checkBoxGuns.Size = new System.Drawing.Size(59, 17);
            this.checkBoxGuns.TabIndex = 4;
            this.checkBoxGuns.Text = "Пушки";
            this.checkBoxGuns.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(80, 89);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(69, 20);
            this.numericUpDownWeight.TabIndex = 3;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(82, 36);
            this.numericUpDownMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(67, 20);
            this.numericUpDownMaxSpeed.TabIndex = 2;
            this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вес самолета";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Максимальная скорость";
            // 
            // pictureBoxPlane
            // 
            this.pictureBoxPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPlane.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxPlane.Name = "pictureBoxPlane";
            this.pictureBoxPlane.Size = new System.Drawing.Size(292, 167);
            this.pictureBoxPlane.TabIndex = 1;
            this.pictureBoxPlane.TabStop = false;
            // 
            // groupBoxPlane
            // 
            this.groupBoxPlane.Controls.Add(this.labelFighter);
            this.groupBoxPlane.Controls.Add(this.labelPlane);
            this.groupBoxPlane.Location = new System.Drawing.Point(22, 81);
            this.groupBoxPlane.Name = "groupBoxPlane";
            this.groupBoxPlane.Size = new System.Drawing.Size(113, 116);
            this.groupBoxPlane.TabIndex = 2;
            this.groupBoxPlane.TabStop = false;
            this.groupBoxPlane.Text = "Тип кузова";
            // 
            // labelFighter
            // 
            this.labelFighter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFighter.Location = new System.Drawing.Point(11, 73);
            this.labelFighter.Name = "labelFighter";
            this.labelFighter.Size = new System.Drawing.Size(79, 27);
            this.labelFighter.TabIndex = 1;
            this.labelFighter.Text = "Истребитель";
            this.labelFighter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelFighter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelFighter_MouseDown);
            // 
            // labelPlane
            // 
            this.labelPlane.AllowDrop = true;
            this.labelPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPlane.Location = new System.Drawing.Point(11, 18);
            this.labelPlane.Name = "labelPlane";
            this.labelPlane.Size = new System.Drawing.Size(79, 26);
            this.labelPlane.TabIndex = 0;
            this.labelPlane.Text = "Самолет";
            this.labelPlane.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelPlane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelPlane_MouseDown);
            // 
            // panelPlane
            // 
            this.panelPlane.AllowDrop = true;
            this.panelPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPlane.Controls.Add(this.pictureBoxPlane);
            this.panelPlane.Location = new System.Drawing.Point(154, 26);
            this.panelPlane.Name = "panelPlane";
            this.panelPlane.Size = new System.Drawing.Size(300, 181);
            this.panelPlane.TabIndex = 1;
            this.panelPlane.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelPlane_DragDrop);
            this.panelPlane.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelPlane_DragEnter);
            // 
            // panelMainColorRed
            // 
            this.panelMainColorRed.BackColor = System.Drawing.Color.Red;
            this.panelMainColorRed.Location = new System.Drawing.Point(21, 61);
            this.panelMainColorRed.Name = "panelMainColorRed";
            this.panelMainColorRed.Size = new System.Drawing.Size(44, 37);
            this.panelMainColorRed.TabIndex = 4;
            // 
            // panelMainColorYellow
            // 
            this.panelMainColorYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelMainColorYellow.Location = new System.Drawing.Point(89, 61);
            this.panelMainColorYellow.Name = "panelMainColorYellow";
            this.panelMainColorYellow.Size = new System.Drawing.Size(44, 37);
            this.panelMainColorYellow.TabIndex = 5;
            // 
            // panelDopColorBlack
            // 
            this.panelDopColorBlack.BackColor = System.Drawing.Color.Black;
            this.panelDopColorBlack.Location = new System.Drawing.Point(159, 61);
            this.panelDopColorBlack.Name = "panelDopColorBlack";
            this.panelDopColorBlack.Size = new System.Drawing.Size(44, 37);
            this.panelDopColorBlack.TabIndex = 6;
            // 
            // panelDopColorWhite
            // 
            this.panelDopColorWhite.BackColor = System.Drawing.Color.White;
            this.panelDopColorWhite.Location = new System.Drawing.Point(236, 61);
            this.panelDopColorWhite.Name = "panelDopColorWhite";
            this.panelDopColorWhite.Size = new System.Drawing.Size(44, 37);
            this.panelDopColorWhite.TabIndex = 7;
            // 
            // panelMainColorGray
            // 
            this.panelMainColorGray.BackColor = System.Drawing.Color.Gray;
            this.panelMainColorGray.Location = new System.Drawing.Point(21, 119);
            this.panelMainColorGray.Name = "panelMainColorGray";
            this.panelMainColorGray.Size = new System.Drawing.Size(44, 37);
            this.panelMainColorGray.TabIndex = 8;
            // 
            // panelMainColorOrange
            // 
            this.panelMainColorOrange.BackColor = System.Drawing.Color.Orange;
            this.panelMainColorOrange.Location = new System.Drawing.Point(89, 119);
            this.panelMainColorOrange.Name = "panelMainColorOrange";
            this.panelMainColorOrange.Size = new System.Drawing.Size(44, 37);
            this.panelMainColorOrange.TabIndex = 9;
            // 
            // panelDopColorGreen
            // 
            this.panelDopColorGreen.BackColor = System.Drawing.Color.Green;
            this.panelDopColorGreen.Location = new System.Drawing.Point(159, 119);
            this.panelDopColorGreen.Name = "panelDopColorGreen";
            this.panelDopColorGreen.Size = new System.Drawing.Size(44, 37);
            this.panelDopColorGreen.TabIndex = 10;
            // 
            // panelDopColorBlue
            // 
            this.panelDopColorBlue.BackColor = System.Drawing.Color.Blue;
            this.panelDopColorBlue.Location = new System.Drawing.Point(236, 119);
            this.panelDopColorBlue.Name = "panelDopColorBlue";
            this.panelDopColorBlue.Size = new System.Drawing.Size(44, 37);
            this.panelDopColorBlue.TabIndex = 11;
            // 
            // groupColors
            // 
            this.groupColors.Controls.Add(this.labelDopColor);
            this.groupColors.Controls.Add(this.labelMainColor);
            this.groupColors.Controls.Add(this.panelDopColorBlue);
            this.groupColors.Controls.Add(this.panelDopColorGreen);
            this.groupColors.Controls.Add(this.panelMainColorOrange);
            this.groupColors.Controls.Add(this.panelMainColorGray);
            this.groupColors.Controls.Add(this.panelDopColorWhite);
            this.groupColors.Controls.Add(this.panelDopColorBlack);
            this.groupColors.Controls.Add(this.panelMainColorYellow);
            this.groupColors.Controls.Add(this.panelMainColorRed);
            this.groupColors.Location = new System.Drawing.Point(484, 67);
            this.groupColors.Name = "groupColors";
            this.groupColors.Size = new System.Drawing.Size(304, 190);
            this.groupColors.TabIndex = 12;
            this.groupColors.TabStop = false;
            this.groupColors.Text = "Цвета";
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(156, 21);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(123, 37);
            this.labelDopColor.TabIndex = 13;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelColor_DragEnter);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(21, 21);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(111, 37);
            this.labelMainColor.TabIndex = 12;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelColor_DragEnter);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(625, 307);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(82, 24);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(625, 361);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(82, 24);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormPlaneConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupColors);
            this.Controls.Add(this.panelPlane);
            this.Controls.Add(this.groupBoxPlane);
            this.Controls.Add(this.groupBoxParam);
            this.Name = "FormPlaneConfig";
            this.Text = "FormCarConfig";
            this.groupBoxParam.ResumeLayout(false);
            this.groupBoxParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).EndInit();
            this.groupBoxPlane.ResumeLayout(false);
            this.panelPlane.ResumeLayout(false);
            this.groupColors.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxParam;
		private System.Windows.Forms.CheckBox checkBoxNose;
		private System.Windows.Forms.CheckBox checkBoxGuns;
		private System.Windows.Forms.NumericUpDown numericUpDownWeight;
		private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBoxPlane;
		private System.Windows.Forms.GroupBox groupBoxPlane;
		private System.Windows.Forms.Label labelFighter;
		private System.Windows.Forms.Label labelPlane;
		private System.Windows.Forms.Panel panelPlane;
		private System.Windows.Forms.Panel panelMainColorRed;
		private System.Windows.Forms.Panel panelMainColorYellow;
		private System.Windows.Forms.Panel panelDopColorBlack;
		private System.Windows.Forms.Panel panelDopColorWhite;
		private System.Windows.Forms.Panel panelMainColorGray;
		private System.Windows.Forms.Panel panelMainColorOrange;
		private System.Windows.Forms.Panel panelDopColorGreen;
		private System.Windows.Forms.Panel panelDopColorBlue;
		private System.Windows.Forms.GroupBox groupColors;
		private System.Windows.Forms.Label labelDopColor;
		private System.Windows.Forms.Label labelMainColor;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonCancel;
	}
}
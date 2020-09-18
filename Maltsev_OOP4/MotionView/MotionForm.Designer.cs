namespace MotionView
{
    partial class MotionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxInitialCoordinate = new System.Windows.Forms.TextBox();
            this.TextBoxInitialTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GroupBoxMotionType = new System.Windows.Forms.GroupBox();
            this.RadioButtonOscillatoryMotion = new System.Windows.Forms.RadioButton();
            this.RadioButtonUniformAcceleratedMotion = new System.Windows.Forms.RadioButton();
            this.RadioButtonUniformMotion = new System.Windows.Forms.RadioButton();
            this.TexBoxSpeed = new System.Windows.Forms.TextBox();
            this.TextBoxAcceleration = new System.Windows.Forms.TextBox();
            this.TextBoxFrequency = new System.Windows.Forms.TextBox();
            this.TextBoxInitialPhase = new System.Windows.Forms.TextBox();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelAcceleration = new System.Windows.Forms.Label();
            this.labelFrequency = new System.Windows.Forms.Label();
            this.labelInitialPhase = new System.Windows.Forms.Label();
            this.labelPressEnter = new System.Windows.Forms.Label();
            this.TextBoxCalculatedCoordinate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.AddMotionButton = new System.Windows.Forms.Button();
            this.TextBoxMagnitude = new System.Windows.Forms.TextBox();
            this.labelMagnitude = new System.Windows.Forms.Label();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.GroupBoxMotionType.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Начальная координата, м";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Начальное время, с";
            // 
            // TextBoxInitialCoordinate
            // 
            this.TextBoxInitialCoordinate.Location = new System.Drawing.Point(159, 13);
            this.TextBoxInitialCoordinate.Name = "TextBoxInitialCoordinate";
            this.TextBoxInitialCoordinate.Size = new System.Drawing.Size(70, 20);
            this.TextBoxInitialCoordinate.TabIndex = 2;
            this.TextBoxInitialCoordinate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // TextBoxInitialTime
            // 
            this.TextBoxInitialTime.Location = new System.Drawing.Point(159, 44);
            this.TextBoxInitialTime.Name = "TextBoxInitialTime";
            this.TextBoxInitialTime.Size = new System.Drawing.Size(70, 20);
            this.TextBoxInitialTime.TabIndex = 3;
            this.TextBoxInitialTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Нажмите Enter для ввода";
            // 
            // GroupBoxMotionType
            // 
            this.GroupBoxMotionType.Controls.Add(this.RadioButtonOscillatoryMotion);
            this.GroupBoxMotionType.Controls.Add(this.RadioButtonUniformAcceleratedMotion);
            this.GroupBoxMotionType.Controls.Add(this.RadioButtonUniformMotion);
            this.GroupBoxMotionType.Location = new System.Drawing.Point(15, 84);
            this.GroupBoxMotionType.Name = "GroupBoxMotionType";
            this.GroupBoxMotionType.Size = new System.Drawing.Size(278, 68);
            this.GroupBoxMotionType.TabIndex = 5;
            this.GroupBoxMotionType.TabStop = false;
            this.GroupBoxMotionType.Text = "Тип движения";
            // 
            // RadioButtonOscillatoryMotion
            // 
            this.RadioButtonOscillatoryMotion.AutoSize = true;
            this.RadioButtonOscillatoryMotion.Location = new System.Drawing.Point(76, 45);
            this.RadioButtonOscillatoryMotion.Name = "RadioButtonOscillatoryMotion";
            this.RadioButtonOscillatoryMotion.Size = new System.Drawing.Size(103, 17);
            this.RadioButtonOscillatoryMotion.TabIndex = 2;
            this.RadioButtonOscillatoryMotion.TabStop = true;
            this.RadioButtonOscillatoryMotion.Text = "Колебательное";
            this.RadioButtonOscillatoryMotion.UseVisualStyleBackColor = true;
            this.RadioButtonOscillatoryMotion.CheckedChanged += new System.EventHandler(this.RadioButtonOscillatoryMotion_CheckedChanged);
            // 
            // RadioButtonUniformAcceleratedMotion
            // 
            this.RadioButtonUniformAcceleratedMotion.AutoSize = true;
            this.RadioButtonUniformAcceleratedMotion.Location = new System.Drawing.Point(151, 20);
            this.RadioButtonUniformAcceleratedMotion.Name = "RadioButtonUniformAcceleratedMotion";
            this.RadioButtonUniformAcceleratedMotion.Size = new System.Drawing.Size(115, 17);
            this.RadioButtonUniformAcceleratedMotion.TabIndex = 1;
            this.RadioButtonUniformAcceleratedMotion.TabStop = true;
            this.RadioButtonUniformAcceleratedMotion.Text = "Равноускоренное";
            this.RadioButtonUniformAcceleratedMotion.UseVisualStyleBackColor = true;
            this.RadioButtonUniformAcceleratedMotion.CheckedChanged += new System.EventHandler(this.RadioButtonUniformAcceleratedMotion_CheckedChanged);
            // 
            // RadioButtonUniformMotion
            // 
            this.RadioButtonUniformMotion.AutoSize = true;
            this.RadioButtonUniformMotion.Location = new System.Drawing.Point(7, 20);
            this.RadioButtonUniformMotion.Name = "RadioButtonUniformMotion";
            this.RadioButtonUniformMotion.Size = new System.Drawing.Size(94, 17);
            this.RadioButtonUniformMotion.TabIndex = 0;
            this.RadioButtonUniformMotion.TabStop = true;
            this.RadioButtonUniformMotion.Text = "Равномерное";
            this.RadioButtonUniformMotion.UseVisualStyleBackColor = true;
            this.RadioButtonUniformMotion.CheckedChanged += new System.EventHandler(this.RadioButtonUniformMotion_CheckedChanged);
            // 
            // TexBoxSpeed
            // 
            this.TexBoxSpeed.Location = new System.Drawing.Point(16, 177);
            this.TexBoxSpeed.Name = "TexBoxSpeed";
            this.TexBoxSpeed.Size = new System.Drawing.Size(63, 20);
            this.TexBoxSpeed.TabIndex = 6;
            this.TexBoxSpeed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // TextBoxAcceleration
            // 
            this.TextBoxAcceleration.Location = new System.Drawing.Point(145, 177);
            this.TextBoxAcceleration.Name = "TextBoxAcceleration";
            this.TextBoxAcceleration.Size = new System.Drawing.Size(66, 20);
            this.TextBoxAcceleration.TabIndex = 7;
            this.TextBoxAcceleration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // TextBoxFrequency
            // 
            this.TextBoxFrequency.Location = new System.Drawing.Point(16, 224);
            this.TextBoxFrequency.Name = "TextBoxFrequency";
            this.TextBoxFrequency.Size = new System.Drawing.Size(63, 20);
            this.TextBoxFrequency.TabIndex = 8;
            this.TextBoxFrequency.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // TextBoxInitialPhase
            // 
            this.TextBoxInitialPhase.Location = new System.Drawing.Point(122, 224);
            this.TextBoxInitialPhase.Name = "TextBoxInitialPhase";
            this.TextBoxInitialPhase.Size = new System.Drawing.Size(66, 20);
            this.TextBoxInitialPhase.TabIndex = 9;
            this.TextBoxInitialPhase.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(15, 158);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(80, 13);
            this.labelSpeed.TabIndex = 10;
            this.labelSpeed.Text = "Скорость, м/с";
            // 
            // labelAcceleration
            // 
            this.labelAcceleration.AutoSize = true;
            this.labelAcceleration.Location = new System.Drawing.Point(131, 158);
            this.labelAcceleration.Name = "labelAcceleration";
            this.labelAcceleration.Size = new System.Drawing.Size(94, 13);
            this.labelAcceleration.TabIndex = 11;
            this.labelAcceleration.Text = "Ускорение, м/с2";
            // 
            // labelFrequency
            // 
            this.labelFrequency.AutoSize = true;
            this.labelFrequency.Location = new System.Drawing.Point(16, 205);
            this.labelFrequency.Name = "labelFrequency";
            this.labelFrequency.Size = new System.Drawing.Size(67, 13);
            this.labelFrequency.TabIndex = 12;
            this.labelFrequency.Text = "Частота, Гц";
            // 
            // labelInitialPhase
            // 
            this.labelInitialPhase.AutoSize = true;
            this.labelInitialPhase.Location = new System.Drawing.Point(91, 205);
            this.labelInitialPhase.Name = "labelInitialPhase";
            this.labelInitialPhase.Size = new System.Drawing.Size(120, 13);
            this.labelInitialPhase.TabIndex = 13;
            this.labelInitialPhase.Text = "Начальная фаза, град";
            // 
            // labelPressEnter
            // 
            this.labelPressEnter.AutoSize = true;
            this.labelPressEnter.Location = new System.Drawing.Point(58, 256);
            this.labelPressEnter.Name = "labelPressEnter";
            this.labelPressEnter.Size = new System.Drawing.Size(136, 13);
            this.labelPressEnter.TabIndex = 14;
            this.labelPressEnter.Text = "Нажмите Enter для ввода";
            // 
            // TextBoxCalculatedCoordinate
            // 
            this.TextBoxCalculatedCoordinate.Location = new System.Drawing.Point(168, 281);
            this.TextBoxCalculatedCoordinate.Name = "TextBoxCalculatedCoordinate";
            this.TextBoxCalculatedCoordinate.ReadOnly = true;
            this.TextBoxCalculatedCoordinate.Size = new System.Drawing.Size(100, 20);
            this.TextBoxCalculatedCoordinate.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Значение координаты, м:";
            // 
            // AddMotionButton
            // 
            this.AddMotionButton.Location = new System.Drawing.Point(12, 327);
            this.AddMotionButton.Name = "AddMotionButton";
            this.AddMotionButton.Size = new System.Drawing.Size(75, 23);
            this.AddMotionButton.TabIndex = 17;
            this.AddMotionButton.Text = "OK";
            this.AddMotionButton.UseVisualStyleBackColor = true;
            this.AddMotionButton.Click += new System.EventHandler(this.AddMotionButton_Click);
            // 
            // TextBoxMagnitude
            // 
            this.TextBoxMagnitude.Location = new System.Drawing.Point(224, 224);
            this.TextBoxMagnitude.Name = "TextBoxMagnitude";
            this.TextBoxMagnitude.Size = new System.Drawing.Size(69, 20);
            this.TextBoxMagnitude.TabIndex = 20;
            this.TextBoxMagnitude.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // labelMagnitude
            // 
            this.labelMagnitude.AutoSize = true;
            this.labelMagnitude.Location = new System.Drawing.Point(221, 205);
            this.labelMagnitude.Name = "labelMagnitude";
            this.labelMagnitude.Size = new System.Drawing.Size(76, 13);
            this.labelMagnitude.TabIndex = 21;
            this.labelMagnitude.Text = "Амплитуда, м";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(203, 327);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 22;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // MotionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 367);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.labelMagnitude);
            this.Controls.Add(this.TextBoxMagnitude);
            this.Controls.Add(this.AddMotionButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TextBoxCalculatedCoordinate);
            this.Controls.Add(this.labelPressEnter);
            this.Controls.Add(this.labelInitialPhase);
            this.Controls.Add(this.labelFrequency);
            this.Controls.Add(this.labelAcceleration);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.TextBoxInitialPhase);
            this.Controls.Add(this.TextBoxFrequency);
            this.Controls.Add(this.TextBoxAcceleration);
            this.Controls.Add(this.TexBoxSpeed);
            this.Controls.Add(this.GroupBoxMotionType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxInitialTime);
            this.Controls.Add(this.TextBoxInitialCoordinate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MotionForm";
            this.Text = "Расчет координаты";
            this.Load += new System.EventHandler(this.MotionForm_Load);
            this.GroupBoxMotionType.ResumeLayout(false);
            this.GroupBoxMotionType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxInitialCoordinate;
        private System.Windows.Forms.TextBox TextBoxInitialTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GroupBoxMotionType;
        private System.Windows.Forms.RadioButton RadioButtonOscillatoryMotion;
        private System.Windows.Forms.RadioButton RadioButtonUniformAcceleratedMotion;
        private System.Windows.Forms.RadioButton RadioButtonUniformMotion;
        private System.Windows.Forms.TextBox TexBoxSpeed;
        private System.Windows.Forms.TextBox TextBoxAcceleration;
        private System.Windows.Forms.TextBox TextBoxFrequency;
        private System.Windows.Forms.TextBox TextBoxInitialPhase;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelAcceleration;
        private System.Windows.Forms.Label labelFrequency;
        private System.Windows.Forms.Label labelInitialPhase;
        private System.Windows.Forms.Label labelPressEnter;
        private System.Windows.Forms.TextBox TextBoxCalculatedCoordinate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button AddMotionButton;
        private System.Windows.Forms.TextBox TextBoxMagnitude;
        private System.Windows.Forms.Label labelMagnitude;
        private System.Windows.Forms.Button ButtonCancel;
    }
}
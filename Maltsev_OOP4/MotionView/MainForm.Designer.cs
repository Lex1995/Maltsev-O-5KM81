namespace MotionView
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MotionsGroupbox = new System.Windows.Forms.GroupBox();
            this.DataMotionsView = new System.Windows.Forms.DataGridView();
            this.AddMotion = new System.Windows.Forms.Button();
            this.RemoveMotionButton = new System.Windows.Forms.Button();
            this.AddRandomMotionButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SearchCallButton = new System.Windows.Forms.Button();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MotionsGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataMotionsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MotionsGroupbox
            // 
            this.MotionsGroupbox.Controls.Add(this.DataMotionsView);
            this.MotionsGroupbox.Location = new System.Drawing.Point(25, 22);
            this.MotionsGroupbox.Name = "MotionsGroupbox";
            this.MotionsGroupbox.Size = new System.Drawing.Size(481, 266);
            this.MotionsGroupbox.TabIndex = 2;
            this.MotionsGroupbox.TabStop = false;
            this.MotionsGroupbox.Text = "Значения координат и времени";
            // 
            // DataMotionsView
            // 
            this.DataMotionsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataMotionsView.Location = new System.Drawing.Point(0, 19);
            this.DataMotionsView.Name = "DataMotionsView";
            this.DataMotionsView.ReadOnly = true;
            this.DataMotionsView.RowHeadersVisible = false;
            this.DataMotionsView.Size = new System.Drawing.Size(479, 247);
            this.DataMotionsView.TabIndex = 0;
            // 
            // AddMotion
            // 
            this.AddMotion.Location = new System.Drawing.Point(25, 306);
            this.AddMotion.Name = "AddMotion";
            this.AddMotion.Size = new System.Drawing.Size(77, 35);
            this.AddMotion.TabIndex = 1;
            this.AddMotion.Text = "Рассчитать координату";
            this.AddMotion.UseVisualStyleBackColor = true;
            this.AddMotion.Click += new System.EventHandler(this.AddMotion_Click);
            // 
            // RemoveMotionButton
            // 
            this.RemoveMotionButton.Location = new System.Drawing.Point(108, 306);
            this.RemoveMotionButton.Name = "RemoveMotionButton";
            this.RemoveMotionButton.Size = new System.Drawing.Size(74, 35);
            this.RemoveMotionButton.TabIndex = 3;
            this.RemoveMotionButton.Text = "Удалить расчет";
            this.RemoveMotionButton.UseVisualStyleBackColor = true;
            this.RemoveMotionButton.Click += new System.EventHandler(this.RemoveMotionButton_Click);
            // 
            // AddRandomMotionButton
            // 
            this.AddRandomMotionButton.Location = new System.Drawing.Point(188, 306);
            this.AddRandomMotionButton.Name = "AddRandomMotionButton";
            this.AddRandomMotionButton.Size = new System.Drawing.Size(68, 35);
            this.AddRandomMotionButton.TabIndex = 4;
            this.AddRandomMotionButton.Text = "Random";
            this.AddRandomMotionButton.UseVisualStyleBackColor = true;
            this.AddRandomMotionButton.Click += new System.EventHandler(this.AddRandomMotionButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(263, 306);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 35);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(344, 306);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(77, 35);
            this.LoadButton.TabIndex = 6;
            this.LoadButton.Text = "Загрузить";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // SearchCallButton
            // 
            this.SearchCallButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SearchCallButton.Location = new System.Drawing.Point(431, 306);
            this.SearchCallButton.Name = "SearchCallButton";
            this.SearchCallButton.Size = new System.Drawing.Size(75, 35);
            this.SearchCallButton.TabIndex = 7;
            this.SearchCallButton.Text = "Поиск";
            this.SearchCallButton.UseVisualStyleBackColor = true;
            this.SearchCallButton.Click += new System.EventHandler(this.SearchCallButton_Click);
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(MotionView.Program);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 353);
            this.Controls.Add(this.SearchCallButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AddRandomMotionButton);
            this.Controls.Add(this.RemoveMotionButton);
            this.Controls.Add(this.AddMotion);
            this.Controls.Add(this.MotionsGroupbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "Виды движения";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MotionsGroupbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataMotionsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MotionsGroupbox;
        private System.Windows.Forms.DataGridView DataMotionsView;
        private System.Windows.Forms.Button AddMotion;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.Button RemoveMotionButton;
        private System.Windows.Forms.Button AddRandomMotionButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button SearchCallButton;
    }
}


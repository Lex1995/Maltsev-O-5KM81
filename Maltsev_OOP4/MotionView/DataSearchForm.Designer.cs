namespace MotionView
{
    partial class DataSearchForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataSerchMotionVew = new System.Windows.Forms.DataGridView();
            this.RadioButtonInitialCoordinate = new System.Windows.Forms.RadioButton();
            this.RadioButtonTime = new System.Windows.Forms.RadioButton();
            this.TextBoxInsertValue = new System.Windows.Forms.TextBox();
            this.labelOfValueInsert = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSerchMotionVew)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataSerchMotionVew);
            this.groupBox1.Location = new System.Drawing.Point(184, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Найденные элементы";
            // 
            // DataSerchMotionVew
            // 
            this.DataSerchMotionVew.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DataSerchMotionVew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataSerchMotionVew.Location = new System.Drawing.Point(0, 13);
            this.DataSerchMotionVew.Name = "DataSerchMotionVew";
            this.DataSerchMotionVew.ReadOnly = true;
            this.DataSerchMotionVew.Size = new System.Drawing.Size(378, 149);
            this.DataSerchMotionVew.TabIndex = 0;
            // 
            // RadioButtonInitialCoordinate
            // 
            this.RadioButtonInitialCoordinate.AutoSize = true;
            this.RadioButtonInitialCoordinate.Location = new System.Drawing.Point(8, 15);
            this.RadioButtonInitialCoordinate.Name = "RadioButtonInitialCoordinate";
            this.RadioButtonInitialCoordinate.Size = new System.Drawing.Size(142, 17);
            this.RadioButtonInitialCoordinate.TabIndex = 1;
            this.RadioButtonInitialCoordinate.TabStop = true;
            this.RadioButtonInitialCoordinate.Text = "Начальная координата";
            this.RadioButtonInitialCoordinate.UseVisualStyleBackColor = true;
            this.RadioButtonInitialCoordinate.CheckedChanged += new System.EventHandler(this.RadioButtonInitialCoordinate_CheckedChanged);
            // 
            // RadioButtonTime
            // 
            this.RadioButtonTime.AutoSize = true;
            this.RadioButtonTime.Location = new System.Drawing.Point(8, 49);
            this.RadioButtonTime.Name = "RadioButtonTime";
            this.RadioButtonTime.Size = new System.Drawing.Size(58, 17);
            this.RadioButtonTime.TabIndex = 2;
            this.RadioButtonTime.TabStop = true;
            this.RadioButtonTime.Text = "Время";
            this.RadioButtonTime.UseVisualStyleBackColor = true;
            // 
            // TextBoxInsertValue
            // 
            this.TextBoxInsertValue.Location = new System.Drawing.Point(21, 96);
            this.TextBoxInsertValue.Name = "TextBoxInsertValue";
            this.TextBoxInsertValue.Size = new System.Drawing.Size(100, 20);
            this.TextBoxInsertValue.TabIndex = 3;
            this.TextBoxInsertValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxInsertValue_KeyDown);
            // 
            // labelOfValueInsert
            // 
            this.labelOfValueInsert.AutoSize = true;
            this.labelOfValueInsert.Location = new System.Drawing.Point(21, 77);
            this.labelOfValueInsert.Name = "labelOfValueInsert";
            this.labelOfValueInsert.Size = new System.Drawing.Size(98, 13);
            this.labelOfValueInsert.TabIndex = 4;
            this.labelOfValueInsert.Text = "Введите величину";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(33, 126);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(33, 156);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // DataSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 192);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.labelOfValueInsert);
            this.Controls.Add(this.TextBoxInsertValue);
            this.Controls.Add(this.RadioButtonTime);
            this.Controls.Add(this.RadioButtonInitialCoordinate);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataSearchForm";
            this.Text = "Поиск";
            this.Load += new System.EventHandler(this.DataSearchForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataSerchMotionVew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DataSerchMotionVew;
        private System.Windows.Forms.RadioButton RadioButtonInitialCoordinate;
        private System.Windows.Forms.RadioButton RadioButtonTime;
        private System.Windows.Forms.TextBox TextBoxInsertValue;
        private System.Windows.Forms.Label labelOfValueInsert;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button CloseButton;
    }
}

namespace WinAPI_Process_Lab
{
    partial class Form1
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
            this.altoSlidingLabel1 = new AltoControls.AltoSlidingLabel();
            this.VirtualMemorySize_SlidingLabel = new AltoControls.AltoSlidingLabel();
            this.TextToReadingVar_altoTextBox1 = new AltoControls.AltoTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.Read_AltoButton = new AltoControls.AltoButton();
            this.ReadingVar_metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.WritingVar_metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // altoSlidingLabel1
            // 
            this.altoSlidingLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.altoSlidingLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.altoSlidingLabel1.Location = new System.Drawing.Point(23, 63);
            this.altoSlidingLabel1.Name = "altoSlidingLabel1";
            this.altoSlidingLabel1.Size = new System.Drawing.Size(384, 15);
            this.altoSlidingLabel1.Slide = false;
            this.altoSlidingLabel1.TabIndex = 3;
            this.altoSlidingLabel1.Text = "Количество зарезервированной виртуальной памяти:";
            // 
            // VirtualMemorySize_SlidingLabel
            // 
            this.VirtualMemorySize_SlidingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VirtualMemorySize_SlidingLabel.ForeColor = System.Drawing.Color.Azure;
            this.VirtualMemorySize_SlidingLabel.Location = new System.Drawing.Point(403, 63);
            this.VirtualMemorySize_SlidingLabel.Name = "VirtualMemorySize_SlidingLabel";
            this.VirtualMemorySize_SlidingLabel.Size = new System.Drawing.Size(119, 15);
            this.VirtualMemorySize_SlidingLabel.Slide = false;
            this.VirtualMemorySize_SlidingLabel.TabIndex = 4;
            // 
            // TextToReadingVar_altoTextBox1
            // 
            this.TextToReadingVar_altoTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.TextToReadingVar_altoTextBox1.Br = System.Drawing.Color.White;
            this.TextToReadingVar_altoTextBox1.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.TextToReadingVar_altoTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.TextToReadingVar_altoTextBox1.Location = new System.Drawing.Point(3, 3);
            this.TextToReadingVar_altoTextBox1.Name = "TextToReadingVar_altoTextBox1";
            this.TextToReadingVar_altoTextBox1.Size = new System.Drawing.Size(220, 43);
            this.TextToReadingVar_altoTextBox1.TabIndex = 5;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Silver;
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.Read_AltoButton);
            this.metroPanel1.Controls.Add(this.TextToReadingVar_altoTextBox1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(8, 15);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(230, 91);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroPanel1.TabIndex = 7;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // Read_AltoButton
            // 
            this.Read_AltoButton.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.Read_AltoButton.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.Read_AltoButton.BackColor = System.Drawing.Color.Transparent;
            this.Read_AltoButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Read_AltoButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.Read_AltoButton.ForeColor = System.Drawing.Color.Black;
            this.Read_AltoButton.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(188)))), ((int)(((byte)(210)))));
            this.Read_AltoButton.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(167)))), ((int)(((byte)(188)))));
            this.Read_AltoButton.Location = new System.Drawing.Point(160, 52);
            this.Read_AltoButton.Name = "Read_AltoButton";
            this.Read_AltoButton.Radius = 10;
            this.Read_AltoButton.Size = new System.Drawing.Size(65, 30);
            this.Read_AltoButton.Stroke = false;
            this.Read_AltoButton.StrokeColor = System.Drawing.Color.Gray;
            this.Read_AltoButton.TabIndex = 6;
            this.Read_AltoButton.Text = "Read";
            this.Read_AltoButton.Transparency = false;
            this.Read_AltoButton.Click += new System.EventHandler(this.Read_AltoButton_Click);
            // 
            // ReadingVar_metroLabel1
            // 
            this.ReadingVar_metroLabel1.AutoSize = true;
            this.ReadingVar_metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ReadingVar_metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.ReadingVar_metroLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ReadingVar_metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Selectable;
            this.ReadingVar_metroLabel1.Location = new System.Drawing.Point(12, 109);
            this.ReadingVar_metroLabel1.Name = "ReadingVar_metroLabel1";
            this.ReadingVar_metroLabel1.Size = new System.Drawing.Size(110, 25);
            this.ReadingVar_metroLabel1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.ReadingVar_metroLabel1.TabIndex = 8;
            this.ReadingVar_metroLabel1.Text = "ReadingVar";
            this.ReadingVar_metroLabel1.UseCustomBackColor = true;
            this.ReadingVar_metroLabel1.UseCustomForeColor = true;
            this.ReadingVar_metroLabel1.UseStyleColors = true;
            // 
            // WritingVar_metroLabel2
            // 
            this.WritingVar_metroLabel2.AutoSize = true;
            this.WritingVar_metroLabel2.BackColor = System.Drawing.Color.SlateGray;
            this.WritingVar_metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.WritingVar_metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.WritingVar_metroLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.WritingVar_metroLabel2.LabelMode = MetroFramework.Controls.MetroLabelMode.Selectable;
            this.WritingVar_metroLabel2.Location = new System.Drawing.Point(12, 155);
            this.WritingVar_metroLabel2.Name = "WritingVar_metroLabel2";
            this.WritingVar_metroLabel2.Size = new System.Drawing.Size(104, 25);
            this.WritingVar_metroLabel2.Style = MetroFramework.MetroColorStyle.Silver;
            this.WritingVar_metroLabel2.TabIndex = 9;
            this.WritingVar_metroLabel2.Text = "WritingVar";
            this.WritingVar_metroLabel2.UseCustomBackColor = true;
            this.WritingVar_metroLabel2.WrapToLine = true;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.SlateGray;
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.ReadingVar_metroLabel1);
            this.metroPanel2.Controls.Add(this.metroPanel1);
            this.metroPanel2.Controls.Add(this.WritingVar_metroLabel2);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(23, 97);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(384, 275);
            this.metroPanel2.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroPanel2.TabIndex = 10;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.UseStyleColors = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(554, 410);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.VirtualMemorySize_SlidingLabel);
            this.Controls.Add(this.altoSlidingLabel1);
            this.MaximumSize = new System.Drawing.Size(554, 410);
            this.MinimumSize = new System.Drawing.Size(554, 410);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Write and Read";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private AltoControls.AltoSlidingLabel altoSlidingLabel1;
        private AltoControls.AltoSlidingLabel VirtualMemorySize_SlidingLabel;
        private AltoControls.AltoTextBox TextToReadingVar_altoTextBox1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel ReadingVar_metroLabel1;
        private MetroFramework.Controls.MetroLabel WritingVar_metroLabel2;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private AltoControls.AltoButton Read_AltoButton;
    }
}


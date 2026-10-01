namespace week4_class_task
{
    partial class task2
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
            textName = new TextBox();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textName
            // 
            textName.Location = new Point(363, 115);
            textName.Name = "textName";
            textName.Size = new Size(293, 39);
            textName.TabIndex = 0;
            textName.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(141, 194);
            button1.Name = "button1";
            button1.Size = new Size(189, 50);
            button1.TabIndex = 1;
            button1.Text = "Display";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 115);
            label1.Name = "label1";
            label1.Size = new Size(187, 32);
            label1.TabIndex = 2;
            label1.Text = "Enter you Name";
            label1.Click += label1_Click;
            // 
            // task2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 644);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textName);
            Name = "task2";
            Text = "task2";
            Load += task2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textName;
        private Button button1;
        private Label label1;
    }
}
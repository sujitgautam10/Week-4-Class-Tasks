namespace week4_class_task
{
    partial class task6
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
            txtGuess = new TextBox();
            btnGuess = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtGuess
            // 
            txtGuess.Location = new Point(195, 71);
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(313, 39);
            txtGuess.TabIndex = 0;
            // 
            // btnGuess
            // 
            btnGuess.Location = new Point(196, 162);
            btnGuess.Name = "btnGuess";
            btnGuess.Size = new Size(172, 51);
            btnGuess.TabIndex = 1;
            btnGuess.Text = "Guess";
            btnGuess.UseVisualStyleBackColor = true;
            btnGuess.Click += btnGuess_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(196, 260);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 32);
            lblResult.TabIndex = 2;
            // 
            // task6
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnGuess);
            Controls.Add(txtGuess);
            Name = "task6";
            Text = "task6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtGuess;
        private Button btnGuess;
        private Label lblResult;
    }
}
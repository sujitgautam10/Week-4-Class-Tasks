namespace week4_class_task
{
    partial class task3
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
            txtSubject1 = new TextBox();
            txtSubject2 = new TextBox();
            btnCalculate = new Button();
            lbl = new Label();
            txtSubject3 = new TextBox();
            lel1 = new Label();
            label1 = new Label();
            label2 = new Label();
            lblResult = new TextBox();
            SuspendLayout();
            // 
            // txtSubject1
            // 
            txtSubject1.Location = new Point(389, 90);
            txtSubject1.Name = "txtSubject1";
            txtSubject1.Size = new Size(224, 39);
            txtSubject1.TabIndex = 0;
            // 
            // txtSubject2
            // 
            txtSubject2.Location = new Point(389, 170);
            txtSubject2.Name = "txtSubject2";
            txtSubject2.Size = new Size(224, 39);
            txtSubject2.TabIndex = 1;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(389, 462);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(250, 70);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Calculate Result";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(177, 364);
            lbl.Name = "lbl";
            lbl.Size = new Size(190, 32);
            lbl.TabIndex = 4;
            lbl.Text = "Total Percentage";
            lbl.Click += lblResult_Click;
            // 
            // txtSubject3
            // 
            txtSubject3.Location = new Point(389, 265);
            txtSubject3.Name = "txtSubject3";
            txtSubject3.Size = new Size(224, 39);
            txtSubject3.TabIndex = 5;
            // 
            // lel1
            // 
            lel1.AutoSize = true;
            lel1.Location = new Point(151, 96);
            lel1.Name = "lel1";
            lel1.Size = new Size(232, 32);
            lel1.TabIndex = 6;
            lel1.Text = "Enter subject 1 mark";
            lel1.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 177);
            label1.Name = "label1";
            label1.Size = new Size(232, 32);
            label1.TabIndex = 7;
            label1.Text = "Enter subject 2 mark";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 268);
            label2.Name = "label2";
            label2.Size = new Size(232, 32);
            label2.TabIndex = 8;
            label2.Text = "Enter subject 3 mark";
            // 
            // lblResult
            // 
            lblResult.Location = new Point(389, 357);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(674, 39);
            lblResult.TabIndex = 9;
            // 
            // task3
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 802);
            Controls.Add(lblResult);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lel1);
            Controls.Add(txtSubject3);
            Controls.Add(lbl);
            Controls.Add(btnCalculate);
            Controls.Add(txtSubject2);
            Controls.Add(txtSubject1);
            Name = "task3";
            Text = "task3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSubject1;
        private TextBox txtSubject2;
        private Button btnCalculate;
        private Label lbl;
        private TextBox txtSubject3;
        private Label lel1;
        private Label label1;
        private Label label2;
        private TextBox lblResult;
    }
}
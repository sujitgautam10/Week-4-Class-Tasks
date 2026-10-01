namespace week4_class_task
{
    partial class task5
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
            txtUnits = new TextBox();
            btnCalculate = new Button();
            lblBill = new Label();
            SuspendLayout();
            // 
            // txtUnits
            // 
            txtUnits.Location = new Point(259, 42);
            txtUnits.Name = "txtUnits";
            txtUnits.Size = new Size(282, 39);
            txtUnits.TabIndex = 0;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(259, 129);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(210, 44);
            btnCalculate.TabIndex = 1;
            btnCalculate.Text = "Calculate Bill";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblBill
            // 
            lblBill.AutoSize = true;
            lblBill.Location = new Point(268, 235);
            lblBill.Name = "lblBill";
            lblBill.Size = new Size(0, 32);
            lblBill.TabIndex = 2;
            // 
            // task5
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblBill);
            Controls.Add(btnCalculate);
            Controls.Add(txtUnits);
            Name = "task5";
            Text = "task5";
            Load += task5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUnits;
        private Button btnCalculate;
        private Label lblBill;
    }
}
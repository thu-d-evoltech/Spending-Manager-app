namespace Spend_Management
{
    partial class AddItemForm
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
            label1 = new Label();
            btnOK = new Button();
            textBoxCategory = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 37);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "項目名";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnOK
            // 
            btnOK.BackColor = SystemColors.GradientInactiveCaption;
            btnOK.Location = new Point(107, 95);
            btnOK.Margin = new Padding(3, 2, 3, 2);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(55, 26);
            btnOK.TabIndex = 4;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // textBoxCategory
            // 
            textBoxCategory.BorderStyle = BorderStyle.FixedSingle;
            textBoxCategory.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 128);
            textBoxCategory.Location = new Point(94, 30);
            textBoxCategory.Margin = new Padding(3, 2, 3, 2);
            textBoxCategory.Name = "textBoxCategory";
            textBoxCategory.Size = new Size(171, 27);
            textBoxCategory.TabIndex = 5;
            // 
            // AddItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 130);
            Controls.Add(textBoxCategory);
            Controls.Add(btnOK);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddItemForm";
            Text = "AddItemForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnOK;
        private TextBox textBoxCategory;
    }
}
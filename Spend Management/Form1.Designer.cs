namespace Spend_Management
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelMenu = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btnHome = new Button();
            btnToggleMenu = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelMenu.BackColor = Color.FromArgb(0, 125, 197);
            panelMenu.BorderStyle = BorderStyle.FixedSingle;
            panelMenu.Controls.Add(button4);
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(btnHome);
            panelMenu.Controls.Add(btnToggleMenu);
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 450);
            panelMenu.TabIndex = 0;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.LightBlue;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            button4.ForeColor = Color.White;
            button4.Location = new Point(-1, 255);
            button4.Name = "button4";
            button4.Size = new Size(220, 40);
            button4.TabIndex = 5;
            button4.Text = "📝　レポート";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.LightBlue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            button3.ForeColor = Color.White;
            button3.Location = new Point(-1, 207);
            button3.Name = "button3";
            button3.Size = new Size(220, 40);
            button3.TabIndex = 4;
            button3.Text = "🎯　目標";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.LightBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            button2.ForeColor = Color.White;
            button2.Location = new Point(-1, 160);
            button2.Name = "button2";
            button2.Size = new Size(220, 40);
            button2.TabIndex = 3;
            button2.Text = "📊　統計";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.LightBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            button1.ForeColor = Color.White;
            button1.Location = new Point(-1, 113);
            button1.Name = "button1";
            button1.Size = new Size(220, 40);
            button1.TabIndex = 2;
            button1.Text = "💰　収支記録";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            btnHome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnHome.BackColor = Color.Transparent;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.MouseOverBackColor = Color.LightBlue;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(-1, 65);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(220, 40);
            btnHome.TabIndex = 1;
            btnHome.TabStop = false;
            btnHome.Text = "🏠　ホーム";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = false;
            // 
            // btnToggleMenu
            // 
            btnToggleMenu.Location = new Point(4, 6);
            btnToggleMenu.Name = "btnToggleMenu";
            btnToggleMenu.Size = new Size(28, 28);
            btnToggleMenu.TabIndex = 0;
            btnToggleMenu.Text = "☰";
            btnToggleMenu.UseVisualStyleBackColor = true;
            btnToggleMenu.Click += btnToggleMenu_Click;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnHome;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMenu);
            Name = "Form1";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnToggleMenu;
        private System.Windows.Forms.Timer timer1;
        private Button btnHome;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}

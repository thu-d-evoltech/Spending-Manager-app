namespace Spend_Management
{
    partial class MainForm
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
            btnLogout = new Label();
            btnReport = new Button();
            btnTarget = new Button();
            btnSpend = new Button();
            btnHome = new Button();
            btnToggleMenu = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panelMain = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(0, 125, 197);
            panelMenu.BorderStyle = BorderStyle.FixedSingle;
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Controls.Add(btnReport);
            panelMenu.Controls.Add(btnTarget);
            panelMenu.Controls.Add(btnSpend);
            panelMenu.Controls.Add(btnHome);
            panelMenu.Controls.Add(btnToggleMenu);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(210, 531);
            panelMenu.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.AutoSize = true;
            btnLogout.Font = new Font("游ゴシック", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 128);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(102, 483);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(90, 21);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "ログアウト";
            btnLogout.Click += btnLogout_Click;
            // 
            // btnReport
            // 
            btnReport.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnReport.AutoSize = true;
            btnReport.BackColor = Color.Transparent;
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatAppearance.MouseOverBackColor = Color.LightBlue;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            btnReport.ForeColor = Color.White;
            btnReport.Location = new Point(-3, 203);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(206, 40);
            btnReport.TabIndex = 5;
            btnReport.Text = "📝　レポート";
            btnReport.TextAlign = ContentAlignment.MiddleLeft;
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += btnReport_Click;
            // 
            // btnTarget
            // 
            btnTarget.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnTarget.AutoSize = true;
            btnTarget.BackColor = Color.Transparent;
            btnTarget.FlatAppearance.BorderSize = 0;
            btnTarget.FlatAppearance.MouseOverBackColor = Color.LightBlue;
            btnTarget.FlatStyle = FlatStyle.Flat;
            btnTarget.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            btnTarget.ForeColor = Color.White;
            btnTarget.Location = new Point(-1, 111);
            btnTarget.Name = "btnTarget";
            btnTarget.Size = new Size(206, 40);
            btnTarget.TabIndex = 4;
            btnTarget.Text = "🎯　目標";
            btnTarget.TextAlign = ContentAlignment.MiddleLeft;
            btnTarget.UseVisualStyleBackColor = false;
            btnTarget.Click += btnTarget_Click;
            // 
            // btnSpend
            // 
            btnSpend.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSpend.AutoSize = true;
            btnSpend.BackColor = Color.Transparent;
            btnSpend.FlatAppearance.BorderSize = 0;
            btnSpend.FlatAppearance.MouseOverBackColor = Color.LightBlue;
            btnSpend.FlatStyle = FlatStyle.Flat;
            btnSpend.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            btnSpend.ForeColor = Color.White;
            btnSpend.Location = new Point(-1, 157);
            btnSpend.Name = "btnSpend";
            btnSpend.Size = new Size(206, 40);
            btnSpend.TabIndex = 2;
            btnSpend.Text = "💰　支出";
            btnSpend.TextAlign = ContentAlignment.MiddleLeft;
            btnSpend.UseVisualStyleBackColor = false;
            btnSpend.Click += btnSpend_Click;
            // 
            // btnHome
            // 
            btnHome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnHome.AutoSize = true;
            btnHome.BackColor = Color.Transparent;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.MouseOverBackColor = Color.LightBlue;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(-1, 65);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(206, 40);
            btnHome.TabIndex = 1;
            btnHome.TabStop = false;
            btnHome.Text = "🏠　ホーム";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnToggleMenu
            // 
            btnToggleMenu.AutoSize = true;
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
            // panelMain
            // 
            panelMain.AutoSize = true;
            panelMain.BackColor = SystemColors.Window;
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(210, 0);
            panelMain.Margin = new Padding(3, 2, 3, 2);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(694, 531);
            panelMain.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnHome;
            ClientSize = new Size(904, 531);
            Controls.Add(panelMain);
            Controls.Add(panelMenu);
            MaximumSize = new Size(920, 570);
            MinimumSize = new Size(920, 570);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private Button btnToggleMenu;
        private System.Windows.Forms.Timer timer1;
        private Button btnHome;
        private Button btnTarget;
        private Button btnSpend;
        private Button btnReport;
        private Panel panelMain;
        private Label btnLogout;
    }
}

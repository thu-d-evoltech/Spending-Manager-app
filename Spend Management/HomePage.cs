using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spend_Management
{
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnListEdit_Click(object sender, EventArgs e)
        {
            foreach (Control panel in flowLayoutPanel_List.Controls)
            {
                foreach (Control ctrl in panel.Controls)
                {
                    if (ctrl is Button btn && btn.Text == "X") 
                    {
                        btn.Visible = true;
                    }
                }
            }
            btnAddItem.Visible = true;
            btnEditSave.Visible = true;
            btnListEdit.Visible = false;
        }

        private void btnEditSave_Click(object sender, EventArgs e)
        {
            foreach (Control panel in flowLayoutPanel_List.Controls)
            {
                foreach (Control ctrl in panel.Controls)
                {
                    if (ctrl is Button btn && btn.Text == "X") 
                    {
                        btn.Visible = false;
                    }
                }
            }
            btnAddItem.Visible = false;
            btnEditSave.Visible = false;
            btnListEdit.Visible = true;
        }

        private void DeletePanel_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && btn.Parent != null)
            {
                // 
                flowLayoutPanel_List.Controls.Remove(btn.Parent);
                btn.Parent.Dispose(); 
            }
        }

            private void AddNewItem(string categoryName)
        {
            // Panel
            Panel itemPanel = new Panel();
            itemPanel.Size = new Size(267, 38);
            itemPanel.Margin = new Padding(31, 4, 31, 4);
            itemPanel.BackColor = Color.PaleTurquoise;

            // Label
            Label nameLabel = new Label();
            nameLabel.Text = categoryName;
            nameLabel.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            nameLabel.Location = new Point(3, 10);
            nameLabel.Size = new Size(63, 21);
            itemPanel.BackColor = Color.PaleTurquoise;
            nameLabel.AutoSize = false;
            nameLabel.TextAlign = ContentAlignment.MiddleLeft;

            // TextBox
            TextBox txt = new TextBox();
            txt.Size = new Size(162, 27);
            txt.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 128);
            txt.Location = new Point(68, 8);
            txt.Text = "0円";
            txt.ReadOnly = true;
            txt.TextAlign = HorizontalAlignment.Right;

            // Delete
            Button deleteButton = new Button();
            deleteButton.Text = "X";
            deleteButton.BackColor = Color.FromArgb(255, 128, 128);
            deleteButton.Location = new Point(235, 8);
            deleteButton.Size = new Size(29, 26);
            deleteButton.Click += (s, e) =>
            {
                flowLayoutPanel_List.Controls.Remove(itemPanel);
            };

            //
            itemPanel.Controls.Add(nameLabel);
            itemPanel.Controls.Add(txt);
            itemPanel.Controls.Add(deleteButton);

            // 
            flowLayoutPanel_List.Controls.Add(itemPanel);
            flowLayoutPanel_List.Controls.SetChildIndex(itemPanel, 1);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            var addForm = new AddItemForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                AddNewItem(addForm.CategoryName);
            }
        }
    }
}

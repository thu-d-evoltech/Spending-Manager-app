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
    public partial class SpendingPage : UserControl
    {
        private BudgetManager budgetManager;
        private int currentUserId;

        public SpendingPage()
        {
            InitializeComponent();
            budgetManager = new BudgetManager("Data Source=spend_data.db");
            currentUserId = Session.CurrentUserId;
            LoadData();
        }

        public void LoadData()
        {
            // Lấy danh sách chi tiêu từ database
            var expenses = budgetManager.GetAllExpenses(currentUserId);

            // Xóa tất cả control cũ trong FlowLayoutPanel
            flowExpenseName.Controls.Clear();

            // Tạo RadioButton cho từng mục chi tiêu
            foreach (var expense in expenses)
            {
                var radio = new RadioButton();
                radio.Text = expense.Name;       // Hiển thị tên chi tiêu
                radio.Tag = expense;             // Lưu toàn bộ đối tượng nếu cần dùng sau
                radio.AutoSize = true;
                radio.Margin = new Padding(5);   // Tạo khoảng cách cho đẹp

                flowExpenseName.Controls.Add(radio);
            }
        }
    }
}

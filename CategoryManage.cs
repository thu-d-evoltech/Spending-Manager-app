using System;

namespace Spend_Management
{
    public static class CategoryManage
    {
        public static List<string> CategoriesSpend { get; private set; } = new List<string>()
    {
        "食費", "家賃", "交通費", "生活費", "その他"
    }

    public static void UpdateCategories(List<string> NewCategories)
        {
            CategoriesSpend = NewCategories;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MathematicalAlgorithms
{
    /// <summary>
    /// 两数之和 的交互逻辑
    /// </summary>
    public partial class TheSumOfTwoNumbers : Window
    {
        public TheSumOfTwoNumbers()
        {
            InitializeComponent();
        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var nums = Array.ConvertAll(this.input_nums.Text.Split(','), s => Convert.ToInt32(s));
            var resultNums=TwoSum(nums, Convert.ToInt32(this.tagget.Text));
            if (resultNums.Length <= 0)
                this.result.Text = "没有得到数组下标";
            else
                this.result.Text = "下标：" + resultNums[0].ToString() + "和下标：" + resultNums[1].ToString();
        }
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[0];
        }
    }
}

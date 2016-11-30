using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int numberxiabiao_int = 0;//数字集合下标
        int operatorxiabiao_int = 0;//运算符下标
        double[] number_double = new double[10];//数字集合
        string[] operator_string = new string[10];//运算符集合

        public void numclik(int num)
        {//输入数字
                if (textBox1.Text == "0")
                {
                    //输入的是整数第一个数字
                    textBox1.Text = num + "";
                }
                else
                {
                    //输入的不是整数的第一个数字
                    textBox1.Text = textBox1.Text+ num + "";
                }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //按钮 1
            numclik(1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //按钮 2
            numclik(2);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //按钮 3
            numclik(3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //按钮 4
            numclik(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //按钮 5
            numclik(5);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //按钮 6
            numclik(6);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //按钮 7
            numclik(7);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //按钮 8
            numclik(8);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //按钮 9
            numclik(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //按钮 0
            numclik(0);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //按钮 点
            string a = textBox1.Text;
            if (a.Length > 1)//如果长度大于1进行判断，这判断出现的原因是为了不让下边截取字符串部分下标不少于0
            {
                string b = a.Substring(a.Length - 1);
                string c = "+";
                string d = "-";
                string h = "*";
                string f = "/";
                string g = ".";
                if (b != c && b != d && b != h && b != f && b != g)//不能连续输入运算符或者小数点
                {
                    textBox1.Text = textBox1.Text + ".";
                }
            }
            else
            {
                if (textBox1.Text != "")
                {
                    textBox1.Text = textBox1.Text + ".";
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //按钮 +
            string a = textBox1.Text;
            if (a.Length > 1)//如果长度大于1进行判断，这判断出现的原因是为了不让下边截取字符串部分下标不少于0
            {
                string b = a.Substring(a.Length - 1);
                string c = "+";
                string d = "-";
                string h = "*";
                string f = "/";
                string g = ".";
                if (b != c && b != d && b != h && b != f && b != g)//不能连续输入运算符或者小数点
                {
                    textBox1.Text = textBox1.Text + "+";
                }
            }
            else
            {
                if (textBox1.Text != "")
                {
                    textBox1.Text = textBox1.Text + "+";
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //按钮 -
            string a = textBox1.Text;
            if (a.Length > 1)//如果长度大于3进行判断，这判断出现的原因是为了不让下边截取字符串部分下标不少于0
            {
                string b = a.Substring(a.Length - 1);
                string c = "+";
                string d = "-";
                string h = "*";
                string f = "/";
                string g = ".";
                if (b != c && b != d && b != h && b != f && b != g)//不能连续输入乘号或者
                {
                    textBox1.Text = textBox1.Text + "-";
                }
            }
            else
            {
                if (textBox1.Text != "")
                {
                    textBox1.Text = textBox1.Text + "-";
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //按钮 *
            string a = textBox1.Text;
            if (a.Length > 1)//如果长度大于3进行判断，这判断出现的原因是为了不让下边截取字符串部分下标不少于0
            {
                string b = a.Substring(a.Length - 1);
                string c = "+";
                string d = "-";
                string h = "*";
                string f = "/";
                string g = ".";
                if (b != c && b != d && b != h && b != f && b != g)//不能连续输入乘号或者
                {
                    textBox1.Text = textBox1.Text + "*";
                }
            }
            else
            {
                if (textBox1.Text != "")
                {
                    textBox1.Text = textBox1.Text + "*";
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //按钮 /
            string a = textBox1.Text;
            if (a.Length > 1)//如果长度大于3进行判断，这判断出现的原因是为了不让下边截取字符串部分下标不少于0
            {
                string b = a.Substring(a.Length - 1);
                string c = "+";
                string d = "-";
                string h = "*";
                string f = "/";
                string g = ".";
                if (b != c && b != d && b != h && b != f && b != g)//不能连续输入乘号或者
                {
                    textBox1.Text = textBox1.Text + "/";
                }
            }
            else
            {
                if (textBox1.Text != "")
                {
                    textBox1.Text = textBox1.Text + "/";
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //按钮 清除一位
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //按钮 清除所有内容重新开始
            textBox1.Text = "0";//显示为零
            numberxiabiao_int = 0;
            operatorxiabiao_int = 0;//两个记录数组都清空,清空的方式就是把数组的下标重置，而不是重置数组，严格来说也不能
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //按钮 =
            string a = textBox1.Text;
            int i = 0;//定义一个总的字符串下标
            while (a != "" && i < a.Length)//将字符串分为数字还有符号
            {
                string b = "";
                while (!a[i].Equals('+') && !a[i].Equals('-') && !a[i].Equals('*') && !a[i].Equals('/') && i < a.Length)//这个循环的出现是为了过滤多位数字，还有小数
                {   //一直把向后叠加，直到后面一位是运算符，这样才能完全统计这个数字
                    b = b + a[i];
                    i++; 
                    if (i < a.Length)
                    {
                        if (a[i].Equals('+') || a[i].Equals('-') || a[i].Equals('*') || a[i].Equals('/'))//如果下一个字符是运算符，就存储数字
                        {
                            number_double[numberxiabiao_int] = Convert.ToDouble(b);
                            numberxiabiao_int++;
                            break;
                        }
                    }
                    else
                    {
                        number_double[numberxiabiao_int] = Convert.ToDouble(b);
                        numberxiabiao_int++;
                        break;
                    }
                }

                if (i == a.Length)
                {
                    break; 
                }
                else
                {
                    operator_string[operatorxiabiao_int] = a[i] + "";
                    i++;
                    operatorxiabiao_int++;
                }
            }
            if (numberxiabiao_int == 2)//有两个数字的情况
            {
                if (operator_string[operatorxiabiao_int-1] == "+")
                {
                    double result = number_double[0] + number_double[1];
                    numberxiabiao_int = 0;
                    operatorxiabiao_int = 0;
                    textBox1.Text = result + "";
                }
                else if (operator_string[operatorxiabiao_int-1] == "-")
                {
                    double result = number_double[0] - number_double[1];
                    numberxiabiao_int = 0;
                    operatorxiabiao_int = 0;
                    textBox1.Text = result + "";
                }
                else if (operator_string[operatorxiabiao_int-1] == "*")
                {
                    double result = number_double[0] * number_double[1];
                    numberxiabiao_int = 0;
                    operatorxiabiao_int = 0;
                    textBox1.Text = result + "";
                }
                else if (operator_string[operatorxiabiao_int-1] == "/")
                {
                    double result = number_double[0] / number_double[1];
                    numberxiabiao_int = 0;
                    operatorxiabiao_int = 0;
                    textBox1.Text = result + "";
                }
            }
            else if (numberxiabiao_int == 3)//有三个数字的情况
            {
                string operator1 = operator_string[0];
                string operator2 = operator_string[1];
                if (operator1 == "+")
                {
                    if (operator2 == "+")
                    {
                        double result = number_double[0] + number_double[1] + number_double[2];
                        numberxiabiao_int = 0;
                        operatorxiabiao_int = 0;
                        textBox1.Text = result + "";
                    }
                    else if (operator2 == "-")
                    {
                        double result = number_double[0] + number_double[1] - number_double[2];
                        numberxiabiao_int = 0;
                        operatorxiabiao_int = 0;
                        textBox1.Text = result + "";
                    }
                    else if (operator2 == "*")
                    {
                        double result = number_double[0] + number_double[1] * number_double[2];
                        numberxiabiao_int = 0;
                        operatorxiabiao_int = 0;
                        textBox1.Text = result + "";
                    }
                    else if (operator2 == "/")
                    {
                        double result = number_double[0] + number_double[1] / number_double[2];
                        numberxiabiao_int = 0;
                        operatorxiabiao_int = 0;
                        textBox1.Text = result + "";
                    }
                }
                else if (operator1 == "-")
                {
                    if (operator2 == "+")
                    {
                        double result = number_double[0] - number_double[1] + number_double[2];
                        numberxiabiao_int = 0;
                        operatorxiabiao_int = 0;
                        textBox1.Text = result + "";
                    }
                    else if (operator2 == "-")
                    {
                        double result = number_double[0] - number_double[1] - number_double[2];
                        numberxiabiao_int = 0;
                        operatorxiabiao_int = 0;
                        textBox1.Text = result + "";
                    }
                    else if (operator2 == "*")
                    {
                        double result = number_double[0] - number_double[1] * number_double[2];
                        numberxiabiao_int = 0;
                        operatorxiabiao_int = 0;
                        textBox1.Text = result + "";
                    }
                    else if (operator2 == "/")
                    {
                        double result = number_double[0] - number_double[1] / number_double[2];
                        numberxiabiao_int = 0;
                        operatorxiabiao_int = 0;
                        textBox1.Text = result + "";
                    }
                }
                else if (operator1 == "*")
                {
                    if (operator2 == "+")
                    {
                        double result = number_double[0] * number_double[1] + number_double[2];
                        numberxiabiao_int = 0;
                        operatorxiabiao_int = 0;
                        textBox1.Text = result + "";
                    }
                    else if (operator2 == "-")
                    {
                        double result = number_double[0] * number_double[1] - number_double[2];
                        numberxiabiao_int = 0;
                        operatorxiabiao_int = 0;
                        textBox1.Text = result + "";
                    }
                    else if (operator2 == "*")
                    {
                        double result = number_double[0] * number_double[1] * number_double[2];
                        numberxiabiao_int = 0;
                        operatorxiabiao_int = 0;
                        textBox1.Text = result + "";
                    }
                    else if (operator2 == "/")
                    {
                        double result = number_double[0] * number_double[1] / number_double[2];
                        numberxiabiao_int = 0;
                        operatorxiabiao_int = 0;
                        textBox1.Text = result + "";
                    }
                }
                else if (operator1 == "/")
                {
                    if (operator2 == "+")
                    {
                        double result = number_double[0] / number_double[1] + number_double[2];
                        numberxiabiao_int = 0;
                        operatorxiabiao_int = 0;
                        textBox1.Text = result + "";
                    }
                    else if (operator2 == "-")
                    {
                        double result = number_double[0] / number_double[1] - number_double[2];
                        numberxiabiao_int = 0;
                        operatorxiabiao_int = 0;
                        textBox1.Text = result + "";
                    }
                    else if (operator2 == "*")
                    {
                        double result = number_double[0] / number_double[1] * number_double[2];
                        numberxiabiao_int = 0;
                        operatorxiabiao_int = 0;
                        textBox1.Text = result + "";
                    }
                    else if (operator2 == "/")
                    {
                        double result = number_double[0] / number_double[1] / number_double[2];
                        numberxiabiao_int = 0;
                        operatorxiabiao_int = 0;
                        textBox1.Text = result + "";
                    }
                }
            }
            numberxiabiao_int = 0;
            operatorxiabiao_int = 0;//两个记录数组都清空
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //按钮 开根号
            string b = textBox1.Text;//一个简单的承接，把显示的字符串
            string c = "";
            string c2 = "";
            double c1 = 0;
            int n = 0;
            bool flag = true;//用来判断是不是只有一个数字
            for (int j = 0; j < b.Length; j++)
            {
                if (b[j].Equals('+') || b[j].Equals('-') || b[j].Equals('*') || b[j].Equals('/'))
                {
                    flag = false;
                    break;
                }
            }
            if (flag == false)
            {
                if (!b[b.Length - 1].Equals('+') && !b[b.Length - 1].Equals('-') && !b[b.Length - 1].Equals('*') && !b[b.Length - 1].Equals('/'))//只能是最后一个字符为数字是才能执行
                {
                    for (int k = b.Length - 1; k > -1; k--)
                    {
                        if (b[k].Equals('+') || b[k].Equals('-') || b[k].Equals('*') || b[k].Equals('/'))
                        {
                            n = k;
                            break;
                        }
                    }
                }
                for (int g = n; g < b.Length; g++)
                {
                    c += b[g];
                }
                c1 = Convert.ToDouble(c);
                for (int g = 0; g < n + 1; g++)
                {
                    c2 += b[g];
                }
                textBox1.Text = c2 + Math.Sqrt(c1);
            }
            else
            {
                textBox1.Text = Math.Sqrt(Convert.ToDouble(b)) + "";
            }
       
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //按钮 求倒数
            string b = textBox1.Text;//一个简单的承接，把显示的字符串
            string c = "";
            string c2 = "";
            double c1 = 0;
            int n = 0;
            bool flag = true;//用来判断是不是只有一个数字
            for (int j = 0; j < b.Length; j++)
            {
                if (b[j].Equals('+') || b[j].Equals('-') || b[j].Equals('*') || b[j].Equals('/'))
                {
                    flag = false;
                    break;
                }
            }
            if (flag == false)
            {
                if (!b[b.Length - 1].Equals('+') && !b[b.Length - 1].Equals('-') && !b[b.Length - 1].Equals('*') && !b[b.Length - 1].Equals('/'))//只能是最后一个字符为数字是才能执行
                {
                    for (int k = b.Length - 1; k > -1; k--)
                    {
                        if (b[k].Equals('+') || b[k].Equals('-') || b[k].Equals('*') || b[k].Equals('/'))
                        {
                            n = k;
                            break;
                        }
                    }
                }
                for (int g = n; g < b.Length; g++)
                {
                    c += b[g];
                }
                c1 = Convert.ToDouble(c);
                for (int g = 0; g < n + 1; g++)
                {
                    c2 += b[g];
                }
                textBox1.Text = c2 + 1/c1;
            }
            else
            {
                textBox1.Text = 1/Convert.ToDouble(b) + "";
            }

        }

        private void button21_Click(object sender, EventArgs e)
        {
            //按钮 求倒数
            string b = textBox1.Text;//一个简单的承接，把显示的字符串
            string c = "";
            string c2 = "";
            double c1 = 0;
            int n = 0;
            bool flag = true;//用来判断是不是只有一个数字
            for (int j = 0; j < b.Length; j++)
            {
                if (b[j].Equals('+') || b[j].Equals('-') || b[j].Equals('*') || b[j].Equals('/'))
                {
                    flag = false;
                    break;
                }
            }
            if (flag == false)
            {
                if (!b[b.Length - 1].Equals('+') && !b[b.Length - 1].Equals('-') && !b[b.Length - 1].Equals('*') && !b[b.Length - 1].Equals('/'))//只能是最后一个字符为数字是才能执行
                {
                    for (int k = b.Length - 1; k > -1; k--)
                    {
                        if (b[k].Equals('+') || b[k].Equals('-') || b[k].Equals('*') || b[k].Equals('/'))
                        {
                            n = k;
                            break;
                        }
                    }
                }
                for (int g = n; g < b.Length; g++)
                {
                    c += b[g];
                }
                c1 = Convert.ToDouble(c);
                for (int g = 0; g < n + 1; g++)
                {
                    c2 += b[g];
                }
                textBox1.Text = c2 + Math.Sqrt(c1);
            }
            else
            {
                textBox1.Text = Math.Sqrt(Convert.ToDouble(b)) + "";
            }

        }

        private void button22_Click(object sender, EventArgs e)
        {
            //按钮 帮助
            new Form2().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";//让其一开始显示零
            textBox1.TextAlign = HorizontalAlignment.Right;//从右向左输入格式
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

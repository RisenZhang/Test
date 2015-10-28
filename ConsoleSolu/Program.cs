﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSolu
{
    class Program
    {
        static void Main(string[] args)
        {
            mainPic();
        }

        static public void mainPic()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine(" My First Program ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1.Input Name   2.BMI           3.f(x)");
            Console.WriteLine("4.find Max     5.practice1005  6.test1013");
            Console.WriteLine("7.test1020     8.test1027      9.practice1027");

            Console.Write("Option: ");
            string ans = "";
            ans = Console.ReadLine();
            if (ans == "1")
                inputeName();
            else
                if (ans == "2")
                    bmi();
                else
                    if (ans == "3")
                        fx();
                    else if (ans == "4")
                        findMax();
                    else if (ans == "5")
                        practice1005();
                    else if (ans == "6")
                        test1013();
                    else if (ans == "7")
                        test1020();
                    else if (ans == "8")
                        test1027();
                    else if (ans == "9")
                        practice1027();

        }
        static void findMax()
        {
            Console.Clear();
            Console.WriteLine("Program is running . . . ");
            //-----------------
            int max7 = 0;
            int s = 1;
            while (s <= int.MaxValue)
            {
                if ((s % 7) == 0)
                    max7 = s;
                try
                {
                    checked { s++; }
                }
                catch (OverflowException oex)
                {
                    Console.WriteLine(oex.Message);
                    break;

                }
                //if (s < 0)
                //    break;
            }
            Console.WriteLine("Max Multiple of 7 in Integer :" + max7);
            Console.WriteLine("Max of Integer :" + int.MaxValue.ToString());
            Console.WriteLine("Min of Integer :" + int.MinValue.ToString());

            Console.ReadKey();
            mainPic();
        }

        static public void bmi()
        {
            Console.Clear();
            double myH = 0;
            double myW = 0;
            double myBMI = 0;
            Console.Write("Please Input Your Height: ");
            myH = double.Parse(Console.ReadLine());
            Console.Write("Please Input Your Weight: ");
            myW = double.Parse(Console.ReadLine());
            Console.WriteLine("Your Height:" + myH.ToString());

            Console.WriteLine("Your Weight:" + myW.ToString());
            myBMI = myW / ((myH / 100) * (myH / 100));
            Console.WriteLine("Your BMI:" + myBMI.ToString());
        }

        static public void inputeName()
        {
            Console.Clear();
            //Practice String variable
            string myName = "";
            Console.Write("Please Input Your Name: ");
            myName = Console.ReadLine();
            Console.WriteLine("Hi, " + myName);
            Console.WriteLine("--------------------------------");
            Console.ReadKey();
        }

        static public void fx()
        {
            Console.Clear();
            //Compute f(x) = x^3 + x^2 + 2x + 1
            double x = 0;
            double y = 0;
            Console.Write(" Input X= ");
            x = double.Parse(Console.ReadLine());
            y = Math.Pow(x, 3) + Math.Pow(x, 2) + 2 * x + 1;
            Console.WriteLine("f(x) = " + y.ToString());
            Console.ReadKey();

        }

        static void practice1005()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine(" My First Program ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1.找質數(雙層for迴圈)   2.找N數內為3,7,9倍數  3.計算稅率");
            Console.WriteLine("4.找質數(while與for迴圈)");
            Console.Write("Option: ");
            string opt = "";
            opt = Console.ReadLine();

            switch (opt)
            {
                case "1":
                    int i, j, k;
                    int y = 0;
                    for (i = 2; i <= 50000; i++)
                    {
                        k = 1; //判斷是否為質數 預設1為是質數
                        for (j = 2; j < i; j++)
                        {
                            if (i % j == 0) //有其它數j可以整除i 代表此數字不是質數
                            {
                                k = 0;
                                break; //跳出迴圈換下一個J計算
                            }
                        }//end of for
                        if (k == 1)
                        {
                            Console.Write(" {0:D5}", i); // {0:"D"5} D代表十進位,5代表幾個
                            Console.WriteLine();
                            y++;
                        }

                    }
                    Console.Write("所有質數的數量:" + y);
                    Console.ReadKey();
                    mainPic();
                    break;
                case "2":
                    int n;
                    Console.Write("Please input integer N:");
                    n = int.Parse(Console.ReadLine());

                    string n3 = "";
                    string n7 = "";
                    string n9 = "";
                    int count = 1;

                    while (count <= n)
                    {
                        if (count % 3 == 0)
                            n3 += count.ToString() + ",";
                        if (count % 7 == 0)
                            n7 += count.ToString() + ",";
                        if (count % 9 == 0)
                            n9 += count.ToString() + ",";

                        count++;
                    }
                    Console.WriteLine("Multiples of 3:" + n3);
                    Console.WriteLine("Multiples of 7:" + n7);
                    Console.WriteLine("Multiples of 9:" + n9);
                    Console.ReadKey();
                    mainPic();

                    break;
                case "3":
                    int income;
                    double tax=0.0;
                    Console.Write("Please input your income:");
                    income = int.Parse(Console.ReadLine());

                    if (income <= 520000)
                    {
                        tax = income * 0.05;
                    }
                    else if (income > 520000 & income <= 1170000)
                    {
                        tax = (income * 0.12) - 36400;
                    }

                    else if (income > 1170000 & income <= 2350000)
                    {
                        tax = (income * 0.2) - 130000;
                    }

                    else if (income > 2350000 & income <= 4400000)
                    {
                        tax = (income * 0.3) - 365000;
                    }

                    else if (income >= 4400001)
                    {
                        tax = (income * 0.4) - 805000;
                    }
                    Console.WriteLine("Your Payable Tax :" + tax.ToString());
                    Console.ReadKey();
                    mainPic();
                    break;
                case "4":

                    int num = 0;//宣告質數
                    int aunum =0; //驗證是否為質數
                    int sum = 0;

                    while (num < 50000)
                    {
                        for ( aunum= 2; aunum <= num; aunum++)
                        {
                            if (num % aunum == 0)
                            {
                                break;
                            }
                        }
                        if (num == aunum) //驗證到最後都沒break就是質數
                        {
                            Console.Write(" {0:D5}", num); // {0:"D"5} D代表十進位,5代表幾個
                            Console.WriteLine();
                            sum++;
                        }
                        num++;
                    }
                    Console.Write("所有質數的數量:" + sum);
                    Console.ReadKey();
                    mainPic();

                    break;
            }
        }

        static void test1013()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine(" My First Program ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1.計算總和   2.統計性別  3.輸入三數判斷最大最小");
            Console.WriteLine("4.輸入三數判斷最大最小if判斷法");
            Console.Write("Option: ");
            string opt = "";
            opt = Console.ReadLine();

            switch (opt)
            {
                case "1":
                    int total = 0;
                    Console.Clear();

                    string ans = "";
                    while (ans != "N")
                    {
                        Console.Write("Please input a integer:"); ans = Console.ReadLine();
                        if (ans.ToUpper() == "N")
                            break;
                        else
                            try
                            {
                                total += int.Parse(ans);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("錯誤訊息:" + ex.Message);
                            }
                            finally
                            {
                                Console.WriteLine("No error" );
                            }


                    }
                    Console.WriteLine("Total:" + total.ToString());
                    Console.ReadKey();
                    mainPic();
                    break;

                case "2":
                    int Female = 0;
                    int Male = 0;
                    int Undefine = 0;
                    string input_vam = "";

                    while (true)
                    {
                        Console.Write("Please input a Female/Male/Undefine: ");
                        input_vam = Console.ReadLine().ToUpper();

                        if (input_vam == "F")
                        {
                            Female++;
                        }
                        if (input_vam == "M")
                        {
                            Male++;
                        }
                        if (input_vam == "U")
                        {
                            Undefine++;
                        }
                        if (input_vam == "N")
                        {
                            break;
                        }
                    }
                    Console.WriteLine("There are Female :" + Female);
                    Console.WriteLine("There are Male :" + Male);
                    Console.WriteLine("There are Undefine :" + Undefine);
                    Console.ReadKey();
                    mainPic();
                    break;
                case "3":
                    int max = int.MinValue;
                    int min = int.MaxValue;
                    int temp = 0;
                    int count = 0;

                    while (count < 3)
                    {
                        Console.Write("Please input a integer:");
                        temp = int.Parse(Console.ReadLine());

                        if (temp > max)
                            max = temp;
                        if (temp < min )
                            min = temp;

                        count++;
                    }

                    Console.WriteLine("Max Num:" + max +"\t"+"Min Num:" +min);

                    Console.ReadKey();
                    mainPic();
                    break;
                case "4":

                    int a, b, c, min1, max1;
                    Console.Write("Please input a integer:");
                    a = int.Parse(Console.ReadLine());

                    Console.Write("Please input a integer:");
                    b = int.Parse(Console.ReadLine());

                    Console.Write("Please input a integer:");
                    c = int.Parse(Console.ReadLine());

                    //找最大
                    if (a >= b)
                    {
                        if (a >= c)
                            max1 = a;
                        else
                            max1 = c;
                    }
                    else
                    {
                        if (b >= c)
                            max1 = b;
                        else
                            max1 = c;
                    }
                    //找最小
                    if (a <= b)
                    {
                        if (a <= c)
                            min1 = a;
                        else
                            min1 = c;
                    }
                    else
                    {
                        if (b <= c)
                            min1= b;
                        else
                            min1 = c;
                    }

                    Console.WriteLine("Max Num:" + max1 +"\t"+"Min Num:" +min1);
                    Console.ReadKey();
                    mainPic();

                    break;
                default:
                    Console.WriteLine("無此選項 返回主程式");
                    Console.ReadKey();
                    mainPic();
                    break;
            }

        }

        static void test1020()
        {
            Console.Clear();
            Console.Write("Please input N:");
            int N = 0;

            string inputN = "";
            try
            {
                inputN = Console.ReadLine();
                N = int.Parse(inputN);
            }

            //Long --> int
            catch (OverflowException ex)
            {
                Console.WriteLine("你輸入長整數, 溢位了(" + ex.Message + ")");
                Console.ReadKey();
                mainPic();
            }

            // real & string -->int
            catch (FormatException fex)
            {
                double inputReal = 0.0;
                try
                {
                    inputReal = double.Parse(inputN);
                }

                catch (Exception ex)
                {
                    Console.WriteLine("你輸入字串(" + ex.Message);
                    Console.ReadKey();
                    mainPic();
                }

                Console.WriteLine("你輸入實數(" + fex.Message);
                Console.ReadKey();
                mainPic();
            }

            //找 5的倍數
            int max5Mul = 0;
            for (int i = N; i >= 5; i--)
            {
                if ((i % 5) == 0)
                {
                    max5Mul = i;
                    break;
                }
            }

            Console.WriteLine("最大的5的倍數" + max5Mul.ToString());
            Console.ReadKey();
            mainPic();
        }

        static void test1027()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine(" 2015-10-27 測驗03 ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1.計算圓面積   2.M的N冪次方運算");
            Console.Write("Option: ");
            string opt = "";
            opt = Console.ReadLine();

            switch (opt)
            {
                case "1":
                    double r = 0;
                    double area = 0.0;
                    string inputN = "";
                    Console.Write("請輸入圓的半徑:");
                    inputN = Console.ReadLine();

                    while (inputN != "N" & inputN != "n") //使用者輸入的值不是N且也不是n才進入迴圈
                    {

                        try
                        {
                            r = double.Parse(inputN);
                        }

                        catch (OverflowException ex)
                        {
                            Console.WriteLine("你輸入長整數, 溢位了(" + ex.Message + ")");
                            Console.ReadKey();
                            mainPic();
                        }

                        // 提防輸入非數字
                        catch (FormatException fex)
                        {
                            Console.WriteLine("你輸入字串(" + fex.Message + ")");
                            Console.ReadKey();
                            mainPic();
                        }

                        if (r > 0)
                        {
                            area = getArea(r);
                            Console.WriteLine("圓的面積:" + area.ToString());
                        }
                        else
                        {
                            Console.WriteLine("半徑請輸入正數");
                        }
                        
                        Console.Write("請輸入圓的半徑:");
                        inputN = Console.ReadLine();

                    }
                    Console.Write("你輸入N或n跳出計算");
                    Console.ReadKey();
                    mainPic();
                    break;

                case "2":
                    double m = 0.0;
                    int n = 0;

                    //無窮迴圈 只能強制關閉
                    while (true)
                    {
                        Console.Write("請輸入M:");
                        m = double.Parse(Console.ReadLine());
                        Console.Write("請輸入N:");
                        n = int.Parse(Console.ReadLine());
                        Console.WriteLine("M的N次方:" + myPower(m, n).ToString());
                    }
                    break;

                default:
                    Console.WriteLine("無此選項 返回主程式");
                    Console.ReadKey();
                    mainPic();
                    break;
            }

        }

        static double getArea(double r)
        {
            double ans =0.0;

            ans = r * r * Math.PI;

            return ans; 
        }

        static double myPower(double m,int n)
        {
            double ans =m;

            for (int i = 0; i < n-1; i++)
            {
                ans = ans * m;
            }
            return ans; 
        }

        static void practice1027()
        {
            string opt = "";
            string input1 = "";
            string input2 = "";
            double absolute = 0.0;
            double t_hight,t_weight,area = 0.0;
            double p_hight, p_weight,bmi = 0.0;
            myMath mathfuct = new myMath(); //宣告mathfuct代表myMath這個Class
            Console.Clear();
            Console.WriteLine("1.絕對值    2.三角形面積    3.BMI");
            Console.Write("選擇:");
            opt = Console.ReadLine();

            switch (opt)
            {
                case "1":
                    Console.Write("請輸入數字:");
                    input1 = Console.ReadLine();
                    
                    absolute = judgenum(input1);                //判斷輸入的是否為數字
                    absolute = mathfuct.getAbs(absolute);       //呼叫myMath裡面的getAbs子程式
                    Console.WriteLine("絕對值:"+absolute.ToString());
                    Console.ReadKey();
                    mainPic();

                    break;

                case "2":
                    Console.Write("請輸入三角形高:");
                    input1 = Console.ReadLine();

                    Console.Write("請輸入三角形底:");
                    input2 = Console.ReadLine();

                    t_hight = judgenum(input1);
                    t_weight = judgenum(input2);

                    area = mathfuct.getTriangle(t_hight, t_weight); //呼叫myMath裡面的getTriangle子程式

                    Console.WriteLine("三角形面積:" + area.ToString());
                    Console.ReadKey();
                    mainPic();

                    break;

                case "3":
                    Console.Write("請輸入身高(公尺):");
                    input1 = Console.ReadLine();

                    Console.Write("請輸入體重(公斤):");
                    input2 = Console.ReadLine();

                    p_hight = judgenum(input1);
                    p_weight = judgenum(input2);

                    bmi = mathfuct.getBMI(p_hight, p_weight);

                    Console.WriteLine("BMI值:" + bmi.ToString());
                    Console.ReadKey();
                    mainPic();

                    break;

                default:
                    Console.WriteLine("無此選項 返回主程式");
                    Console.ReadKey();
                    mainPic();
                    break;
            }
            
        }
        static double judgenum(string input)
        {
            double num = 0.0;

            try
            {
                num = double.Parse(input);
            }
            catch (FormatException fex)
            {
                Console.WriteLine("你輸入字串(" + fex.Message + ")");
                Console.ReadKey();
                mainPic();
            }

            return num;
        }

        


    }
}

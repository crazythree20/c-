using System;
using System.Text;
using System.Text.RegularExpressions;

//string str1 = "23432n";
//string str2 = "234234";

//Console.WriteLine(Regex.IsMatch(str1, @"\d"));



//string str = "www.baidu.com";

//Console.WriteLine(Regex.Replace(str,@"[a-z]","1"));

string re = @"^\d{5,12}$";
Console.WriteLine(Regex.IsMatch("14554b45", re));
Console.WriteLine(Regex.IsMatch("145", re));
double a = 80;
int i = 0;
while (a>10)
{
   
    i += 1;
    a = a - a * 0.02;

    Console.WriteLine(i+ " "+a);

}

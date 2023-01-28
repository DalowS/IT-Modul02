using Hello_SoftUni;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

public class Program00
{

    public static void Main()


    {
        //zad1
        /* double naem = double.Parse(Console.ReadLine());

         double ketaring = 2 * naem;
         double napitki = ketaring- ketaring * 0.15 ;
         double gifts = (napitki + ketaring) / 7;

         double sum = naem +ketaring + napitki + gifts;
         Console.WriteLine(sum);*/
        /*
                double banichkaCena = double.Parse(Console.ReadLine());
                int banichkaBroj = int.Parse(Console.ReadLine());
                int mekica1 = int.Parse(Console.ReadLine());
                int kifla1 = int.Parse(Console.ReadLine());
                int gevreci1 = int.Parse(Console.ReadLine());
                double budget = double.Parse(Console.ReadLine());

                double banica = banichkaBroj * banichkaCena;

                Console.WriteLine(banica);
                double mekica = mekica1 *(banica * 0.20);
                Console.WriteLine(mekica);
                double kifla = kifla1*(mekica - mekica * 0.40);

                Console.WriteLine(kifla);
                double gevrek = gevreci1*(kifla + 1.20);

                Console.WriteLine(gevrek);
                double sum = banica + mekica + kifla + gevrek;

                if (sum<budget )
                {
                    Console.WriteLine("Yes! {0} leva left",budget-sum);
                }
                else if(sum>budget)
                {
                    Console.WriteLine("No! {0} leva left", budget - sum);
                }*/

        /*
               int n = int.Parse(Console.ReadLine());

                int counter = 0;
                for (int d1 = 0; d1 <=9; d1++)
                {
                    for (int d2 = 0; d2 <= 9; d2++)
                    {
                        int sum = d1 + d2;
                        if (sum == n) {
                            for (int d3 = 0; d3 <= 9; d3++)
                            {
                                if (d3%2==0)
                                {
                                    for (int d4 = 0; d4 <= 9; d4++)
                                    {
                                        if (d4 == 0 || d4 == 9)
                                        {
                                            for (int d5 = 0; d5 <= 9; d5++)
                                            {
                                                if (d5 == 3 || d5 == 6)
                                                {
                                                    Console.WriteLine("{0}{1}{2}{3}{4}", d1, d2, d3, d4, d5);
                                                    counter++;

                                                }
                                            }
                                        }
                                    }                   
                                 }
                             }
                         }           
                    }  
                }
                Console.WriteLine("Count of winner numbers: "+counter);*/

        int monopoly = 0;
        int puzzle = 0;
        int robot = 0;
        int lego = 0;

        int children = int.Parse(Console.ReadLine());
        for (int i = 1; i <= children; i++) 
        {
            string a = Console.ReadLine();
            if (a == "lego") lego++;
            else if (a == "monopoly") monopoly++;
            else if (a == "puzzle") puzzle++;
            else if (a == "robot") robot++;
        }
        

        Console.WriteLine("Lego:  {0}", lego);
        Console.WriteLine("Monopoly:  {0}", monopoly);
        Console.WriteLine("Puzzle:  {0}", puzzle);
        Console.WriteLine("Robot:  {0}", robot);
    }
}









/*program.Print();*/
/*  //Зад8
  var b1 = double.Parse(Console.ReadLine());
  var b2 = double.Parse(Console.ReadLine());
  var h = double.Parse(Console.ReadLine());
  var area2 = (b1 + b2) * h / 2.0;
  Console.WriteLine("Trapezoid area = "+area2);

  //Зад9 
  Console.Write("Enter circle radius. r = ");
  var r = double.Parse(Console.ReadLine());
  var area = Math.Round(Math.PI * r * r, 2);
  var perimeter = Math.Round(2 * Math.PI * r, 2);
  Console.WriteLine("Area = " + area);
  Console.WriteLine("Perimeter = " + perimeter);
  //Зад10
  var x1 = double.Parse(Console.ReadLine());
  var y1 = double.Parse(Console.ReadLine());
  var x2 = double.Parse(Console.ReadLine());
  var y2 = double.Parse(Console.ReadLine());
  var area1 = (x1 - x2) * (y2 - y1);
  Console.WriteLine(Math.Round(area1,4));
  var p = 2* (x1 - x2) + (y2 - y1);
  Console.WriteLine(Math.Round(p, 4));
  //Зад11
 var a = double.Parse(Console.ReadLine());
      var h = double.Parse(Console.ReadLine());
      var s = Math.Round(a * h / 2,2);
      Console.WriteLine("Triangle area = {0}", s);
*/


/*var s = double.Parse(Console.ReadLine());
var a = Console.ReadLine();
var b = Console.ReadLine();

if (a == "BGN" && b == "USD") Console.WriteLine("{0:f2} USD", s / 1.79549);
if (a == "BGN" && b == "EUR") Console.WriteLine("{0:f2} EUR", s / 1.95583);
if (a == "BGN" && b == "GBP") Console.WriteLine("{0:f2} GBP", s / 2.53405);
if (a == "USD" && b == "BGN") Console.WriteLine("{0:f2} BGN", s * 1.79549);
if (a == "EUR" && b == "BGN") Console.WriteLine("{0:f2} BGN", s * 1.95583);
if (a == "GBP" && b == "BGN") Console.WriteLine("{0:f2} BGN", s * 2.53405);
if (a == "USD" && b == "EUR") Console.WriteLine("{0:f2} EUR", (s * 1.79549) / 1.95583);
if (a == "USD" && b == "GBP") Console.WriteLine("{0:f2} GBP", (s * 1.79549) / 2.53405);
if (a == "EUR" && b == "USD") Console.WriteLine("{0:f2} EUR", (s * 1.95583) / 1.79549);
if (a == "EUR" && b == "GBP") Console.WriteLine("{0:f2} GBP", (s * 1.95583) / 2.53405);
if (a == "GBP" && b == "USD") Console.WriteLine("{0:f2} EUR", (s * 2.53405) / 1.79549);
if (a == "GBP" && b == "EUR") Console.WriteLine("{0:f2} GBP", (s * 2.53405) / 1.95583);*/


/* string date = Console.ReadLine();
     DateTime time = DateTime.ParseExact(date,"dd-MM-yyyy",System.Globalization.CultureInfo.InvariantCulture);
     time = time.AddDays(999);
     Console.WriteLine(time.ToString("dd-MM-yyyy"));*/

/*int input =int.Parse(Console.ReadLine());
if (input%2==0)
{
    Console.WriteLine("even");
}
else
{
    Console.WriteLine("odd");
}
*/

//4zad

/*int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if (a>b)
{
    Console.WriteLine(a);
}
else if (b > a)
{
    Console.WriteLine(b);
}*/

//5zad
/*string  input = (Console.ReadLine());

 if (input== "s3cr3t!P@ssw0rd")
 {
     Console.WriteLine("Welcome");
 }
 else
 {
     Console.WriteLine("Wrong password!");
 }*/

//zad6
/* string a = (Console.ReadLine()).ToLower();
 string b = (Console.ReadLine()).ToLower();
 if (a==b)
 {
     Console.WriteLine("yes");
 }
 else
 {
     Console.WriteLine("no");
 }*/
//zad7

/*  int hours = int.Parse(Console.ReadLine());
  int minutes = int.Parse(Console.ReadLine());
  minutes = minutes + 15;

  if (minutes > 59)
  {
      minutes = minutes - 60;
      hours = hours + 1;
  }

  if (hours == 24)
  {
      hours = 0;
  }

  Console.WriteLine($"{hours}:{minutes:00}");*/

//zad 8
/*  int a = int.Parse(Console.ReadLine());
  int b = int.Parse(Console.ReadLine());
  int c = int.Parse(Console.ReadLine());

  if (a==b&&b==c)
  {
      Console.WriteLine("yes");
  }
  else
  {
      Console.WriteLine("no");
  }*/

//zad9

/*int number = int.Parse(Console.ReadLine());
switch (number)
{

    case 1:
        Console.WriteLine("one");
        break;
    case 2:
        Console.WriteLine("two");
        break;
    case 3:
        Console.WriteLine("tree");
        break;
    case 4:
        Console.WriteLine("four");
        break;
    case 5:
        Console.WriteLine("five");
        break;
    case 6:
        Console.WriteLine("six");
        break;
    case 7:
        Console.WriteLine("seven");
        break;
    case 8:
        Console.WriteLine("eight");
        break;
    case 9:
        Console.WriteLine("nine");
        break;

        default:
        Console.WriteLine("number too big");
         break ;

}*/

//zad10
/*   int number = int.Parse(Console.ReadLine());
   double bonus;
   if (number <=100)
   {
       bonus = 5;
   }
   else if (number< 1000)
   {
       bonus = number * 0.20;
   }
   else
   {
       bonus = number*0.10;
   }
   if (number%2==0)
   {
       bonus++;
   }
   if (number%10==5)
   {
       bonus += 2;
   }

   Console.WriteLine(bonus);

   Console.WriteLine(number+bonus);*/

//zad11

/*  int a = int.Parse(Console.ReadLine());
   int b = int.Parse(Console.ReadLine());
   int c = int.Parse(Console.ReadLine());
   // Общо време
   int sumOfSeconds = a + b + c;

   if (sumOfSeconds < 60)
   {
       Console.Write("0:");
   }
   else if(sumOfSeconds < 120)
   {
       Console.WriteLine("1:");
       sumOfSeconds -= 60;
   }
   else
   {
       Console.WriteLine("2:");
       sumOfSeconds -= 120;
   }
   if (sumOfSeconds<10)
   {
       Console.WriteLine("0"+sumOfSeconds);
   }
   else
   {
       Console.WriteLine(sumOfSeconds);
   }*/

/*int number = int.Parse(Console.ReadLine());
string e1 = Console.ReadLine();
string e2 = Console.ReadLine();

if (e1=="m"&& e2== "mm")
{
    Console.WriteLine("{0} mm",number*1000);
}
if (e1 == "m" && e2 == "cm")
{
    Console.WriteLine("{0} cm", number * 100);
}
if (e1 == "m" && e2 == "mi")
{
    Console.WriteLine("{0} mi", number * 0.000621371192);
}
if (e1 == "m" && e2 == "in")
{
    Console.WriteLine("{0} in", number * 39.3700787);
}
if (e1 == "m" && e2 == "km")
{
    Console.WriteLine("{0} in", number * 0.001);
}
if (e1 == "m" && e2 == "ft")
{
    Console.WriteLine("{0} ft", number * 3.2808399);
}
if (e1 == "m" && e2 == "yd")
{
    Console.WriteLine("{0} yd", number * 1.0936133);
}*/
/*double number = double.Parse(Console.ReadLine());

if (number<=10)
{
    Console.WriteLine("slow");
}
else if (number >10&&number<=50)
{
    Console.WriteLine("average");
}
else if (number > 50 && number < 150)
{
    Console.WriteLine("fast");
}
else if (number > 150 && number <= 1000)
{
    Console.WriteLine("ultra fast");
}
else
{
    Console.WriteLine("extremely fast");
}*/
/*
        int n = int.Parse(Console.ReadLine());
        string[] a = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
        string[] b = new string[] { "", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        string[] c = new string[] { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety", };
        string[] d = new string[] { "hundred" };

        int check1 = (n / 10) % 10;
        int check2 = n % 10;
        if (n >= 0 && n < 100)
        {
            if (n >= 0 && n < 10)
            {
                if (n == 0)
                {
                    Console.WriteLine("zero");
                }
                else
                {
                    string one = a[n - 1];
                    Console.WriteLine(one);
                }
            }

            else if (n >= 0 && n < 20)
            {
                if (n == 10)
                {
                    string tens = a[n - 1];
                    Console.WriteLine(tens);
                }
                else
                {
                    int digit = n % 10;
                    string two = b[digit];
                    Console.WriteLine(two);
                }
            }
            else if (check1 != 0 && check2 == 0)
            {
                int digit1 = n / 10;
                string three = c[digit1];
                Console.WriteLine(three);
            }
            else if (n > 20 && n % 10 != 0)
            {
                int dig1 = n % 10;
                int dig2 = n /= 10;
                string four = c[dig2];
                string five = a[dig1 - 1];
                Console.WriteLine("{0} {1}", four, five);
                }
            else if (n == 100)
                {
                int dig1 = n % 10;
                int dig2 = n /= 100;
                string four = a[dig1];
                string five = d[dig2 - 1];
                Console.WriteLine("{0} {1}", four, five);
            }

        }
            else {Console.WriteLine("invalid number");}*/

/* double age = double.Parse(Console.ReadLine());

 string gender = Console.ReadLine();

 if (age < 16)
 {
     if (gender == "m")
     {
         Console.WriteLine("Master");
     }
     else if (gender == "f") { Console.WriteLine("Miss"); }
 }
 else
 {
     if (gender == "m")
     {
         Console.WriteLine("Mr.");
     }
     else if (gender == "f")
     {
         Console.WriteLine("Ms.");
     }
 }*/

/* string product = Console.ReadLine().ToLower();

 string town = Console.ReadLine().ToLower();
 double quantity = double.Parse(Console.ReadLine());

 if (town == "sofia")
 {
     if (product== "coffee")
     {
         Console.WriteLine(0.50*quantity);
     }
 }
 if (town == "plovdiv")
 {
     if (product == "coffee")
     {
         Console.WriteLine(0.40 * quantity);
     }
 }
 if (town == "varna")
 {
     if (product == "coffee")
     {
         Console.WriteLine(0.45 * quantity);
     }
 }

 if (town == "sofia")
 {
     if (product == "water")
     {
         Console.WriteLine(0.80 * quantity);
     }
 }
 if (town == "plovdiv")
 {
     if (product == "water")
     {
         Console.WriteLine(0.70 * quantity);
     }
 }
 if (town == "varna")
 {
     if (product == "water")
     {
         Console.WriteLine(0.70 * quantity);
     }
 }
 if (town == "sofia")
 {
     if (product == "beer")
     {
         Console.WriteLine(1.20 * quantity);
     }
 }
 if (town == "plovdiv")
 {
     if (product == "beer")
     {
         Console.WriteLine(1.15 * quantity);
     }
 }
 if (town == "varna")
 {
     if (product == "beer")
     {
         Console.WriteLine(1.10 * quantity);
     }
 }
 if (town == "sofia")
 {
     if (product == "sweets")
     {
         Console.WriteLine(1.45 * quantity);
     }
 }
 if (town == "plovdiv")
 {
     if (product == "sweets")
     {
         Console.WriteLine(1.30 * quantity);
     }
 }
 if (town == "varna")
 {
     if (product == "sweets")
     {
         Console.WriteLine(1.35 * quantity);
     }
 }
 if (town == "sofia")
 {
     if (product == "peanuts")
     {
         Console.WriteLine(1.60 * quantity);
     }
 }
 if (town == "plovdiv")
 {
     if (product == "peanuts")
     {
         Console.WriteLine(1.50 * quantity);
     }
 }
 if (town == "varna")
 {
     if (product == "peanuts")
     {
         Console.WriteLine(1.55 * quantity);
     }
 }*/

/*  var x1 = double.Parse(Console.ReadLine());
  var y1 = double.Parse(Console.ReadLine());
  var x2 = double.Parse(Console.ReadLine());
  var y2 = double.Parse(Console.ReadLine());
  var x = double.Parse(Console.ReadLine());
  var y = double.Parse(Console.ReadLine());

  if ((x>=x1&& x<=x2)&&(y>=y1&& y<=y2))
  {
      Console.WriteLine("Inside");
  }
  else
  {
      Console.WriteLine("Outside");
  }
*/


/*  string name = Console.ReadLine().ToLower();
  switch (name)
  {
      case "banana":
      case "apple":
      case "kiwi":
      case "cherry":
      case "lemon":
      case "grapes":
          {
              Console.WriteLine("fruit");
              break;
          }
      case "tomato":
      case "cucumber":
      case "pepper":
      case "carot":

          {
              Console.WriteLine("vegetable");
              break;
          }
      default: { Console.WriteLine("unknown"); break; }
  };*/

/*   long a = long.Parse(Console.ReadLine());
   if ((a>=100 && a<=200 || a==0))
   {

   }
   else
   {
       Console.WriteLine("Invalid");
   }
*/
/* var x1 = double.Parse(Console.ReadLine());
 var y1 = double.Parse(Console.ReadLine());
 var x2 = double.Parse(Console.ReadLine());
 var y2 = double.Parse(Console.ReadLine());
 var x = double.Parse(Console.ReadLine());
 var y = double.Parse(Console.ReadLine());

 var onLeftSide = (x==x1)&& (y>=y1)&& (y<=y2);
 var onRightSide = (x == x2) && (y >= y1) && (y <= y2);
 var onUpSide = (y == y1) && (x >= x1) && (x <= x2);
 var onDownSide = (y == y2) && (x >= x1) && (x <= x2);

 if (onLeftSide||onRightSide||onUpSide||onDownSide)
 {
     Console.WriteLine("Border");
 }
 else
 {
     Console.WriteLine("Inside/Outside");
 }*/

/*  int day = int.Parse(Console.ReadLine());
  switch (day)
  {
      case 1:
          Console.WriteLine("Monday");
          break;
      case 2:
          Console.WriteLine("Tuesday");
          break;
      case 3:
          Console.WriteLine("Wednesday");
          break;
      case 4:
          Console.WriteLine("Thursday");
          break;
      case 5:
          Console.WriteLine("Friday");
          break;
      case 6:
          Console.WriteLine("Saturday");
          break;
      case 7:
          Console.WriteLine("Sunday");
          break;

      default:
          Console.WriteLine("Error");
          break;
  }
*/
/*  string name = Console.ReadLine().ToLower();
  switch (name)
  {
      case "dog":

          {
              Console.WriteLine("mammal");
              break;
          }
      case "crocodile":
      case "tortoise":
      case "snake":


          {
              Console.WriteLine("reptile");
              break;
          }
      default: { Console.WriteLine("unknown"); break; }
  }; */

/* string name = Console.ReadLine().ToLower();
 int rows = int.Parse(Console.ReadLine());
 int cols = int.Parse(Console.ReadLine());
 double sum = rows * cols;
 if (name== "premiere")
 {
     sum *= 12.00;          
 }
 if (name == "normal")
 {
     sum *= 7.50;
 }
 if (name == "discount")
 {
     sum *= 5.00;
 }
 Console.WriteLine("{0:f2} leva", sum);*/

//zad4 26.11
/*  Console.WriteLine("n= ");
 int n = int.Parse(Console.ReadLine());
  Console.WriteLine("Enter the numbers:");

  int sum = 0;
  for (int i = 0; i < n; i++)
  {
      int number = int.Parse(Console.ReadLine());
      sum = sum+number;
  }
  Console.WriteLine("sum = "+sum);*/
//zad6
/* Console.WriteLine("n= ");
int n = int.Parse(Console.ReadLine());
int  min= 100000000;
 for (int i = 0; i < n; i++)
 {
     int number = int.Parse(Console.ReadLine());
     if (number<min)
     {
         min=number;
     }
 }
 Console.WriteLine("min = "+min);*/

//zad7
/*int n = int.Parse(Console.ReadLine());
int leftSum=0;
int rightSum=0;
for (int i = 0; i < n; i++)
{
    leftSum += int.Parse(Console.ReadLine());

}
for (int i = 0; i < n; i++)
{
    rightSum += int.Parse(Console.ReadLine());

}
if (rightSum==leftSum)
{
    Console.WriteLine("Yes, sum = " + leftSum);
}
else
{
    Console.WriteLine("No, diff = " + Math.Abs(rightSum - leftSum));
}*/
//zad 8
/*int n = int.Parse(Console.ReadLine());
int oddSum = 0;
int evenSum = 0;

for (int i = 0; i < n; i++)
{
    int element = int.Parse(Console.ReadLine());
    if (i % 2 == 0)
    {
        oddSum += element;
    }
    else
    {
        evenSum+=element;
    }
}
if (oddSum==evenSum)
{
    Console.WriteLine("Yes \nSum={0}",oddSum);
}
else
{
    Console.WriteLine("No \nDiff={0}", Math.Abs(oddSum-evenSum));
}*/

//zad 9

/* int n = int.Parse(Console.ReadLine());
 int currentSum=0;
 int previousSum = 0;
 int difference = 0;
 for (int i = 1; i <= n; i++)
 {
     if (i==1)
     {
         int firstNum = int.Parse(Console.ReadLine());
         int secondNum= int.Parse(Console.ReadLine());
         previousSum = firstNum + secondNum;
     }
     else
     {
         int firstNum1 = int.Parse(Console.ReadLine());
         int secondNum2 = int.Parse(Console.ReadLine());
         currentSum = firstNum1 + secondNum2;
         if (Math.Abs(currentSum-previousSum)>difference)
         {
             difference = Math.Abs(currentSum - previousSum);
         }
         previousSum=currentSum;
     }
 }
 if (difference>0)
 {
     Console.WriteLine("No, maxdiff="+difference);
 }
 else
 {
     Console.WriteLine("Yes, value=" + previousSum);
 }*/

//zad10

/* int n = int.Parse(Console.ReadLine());
 int sum = 0, max = -10000000;
 for (int i = 0; i < n; i++)
 {
     int k = int.Parse(Console.ReadLine());
     if (k>max)
     {
         max = k;
     }
     sum += k;
 }
 sum = sum - max;
 if ( sum==max)
 {
     Console.WriteLine("Yes \nSum = {0}",sum);
 }
 else
 {
     Console.WriteLine("No \nDiff = {0}", sum-max);
 }*/
//zad 13
/*int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("$");
    }
    Console.WriteLine();
}*/
/*
        int n = int.Parse(Console.ReadLine());
        int l = int.Parse(Console.ReadLine());

        for (int d1 = 1; d1 <= n; d1++)
        {
            for (int d2 = 1; d2 <= n; d2++)
            {
                for (char l1 = 'a'; l1 < 'z'+l; l1++)
                {
                    for (char l2 = 'a'; l2 < 'z' + l; l2++)
                    {
                        for (int d3 = Math.Max(d1,d2)+1; d3 <= n; d3++)
                        {
                            Console.WriteLine("{0} {1} {2} {3} {4}",d1,d2,l1,l2,d3);
                        }
                        Console.WriteLine();
                    }
                }
            }
        }*/
/* int n = int.Parse(Console.ReadLine());
 Console.Write("+ ");
 for (int i = 0; i < n-2; i++)
 {
     Console.Write("-");
 }
 Console.Write(" +");
 Console.WriteLine();
 Console.Write("| ");
 for (int i = 0; i < n - 2; i++)
 {
     Console.Write("-");
 }      
 Console.Write(" |");
 Console.WriteLine();
 Console.Write("+ ");
 for (int i = 0; i < n - 2; i++)
 {
     Console.Write("-");
 }
 Console.Write(" +");*/
/*
        int n = int.Parse(Console.ReadLine());
        for (int row= 1; row <= n; row++)
        {
            for (int col = 1; col <= n-row; col++)
                Console.Write(" ");
                Console.Write("*");             
            for (int col = 1; col < row; col++)

                Console.Write(" *");
                Console.WriteLine();  
        }
        for (int r = n-1; r > 0; r--)
        {
            for (int c = 1; c <=n-r; c++)
                Console.Write(" ");
            Console.Write("*");
            for (int c = 1; c < r; c++)
                Console.Write(" *");
            Console.WriteLine();
        }*/
/* int n1 = int.Parse(Console.ReadLine());
 for (int i = 1; i <= n1; i+=3)
 {
     Console.WriteLine(i);
 }*/
/* int n = int.Parse(Console.ReadLine());
 for (int i = n; i >=1; i--)
 {
     Console.WriteLine(i);
 }*/

/*   int n =0;  
   do
   {
       Console.WriteLine("Enter a number in the range [1...100]:");
       n = int.Parse(Console.ReadLine());
       if (n >= 1 && n <= 100)
       {
           Console.WriteLine("The number is: " + n);
       }
       else
       {
           Console.WriteLine("Invalid number! ");
       }

   } while (n<1||n>100);*/




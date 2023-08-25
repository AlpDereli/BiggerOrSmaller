// See https://aka.ms/new-console-template for more information
List<int> ilist = new List<int>();
Console.WriteLine("Please enter integer numbers and seperate them with a space andenter even number of numbers(12 33 3 5...): ");
string s  = Console.ReadLine();
string[] arr = s.Split();
foreach (string str in arr)
{
    int s1 = int.Parse(str);
    ilist.Add(s1);
}
int sum = 0;
int sum1 = 0;
foreach (int i in ilist)
{
    if (i<=67)
    {
        sum += 67-i;
    }
    else
    {
        int i2 = i - 67;
        sum1 += i2 * i2;
    }
}
Console.WriteLine(sum + " " + sum1);
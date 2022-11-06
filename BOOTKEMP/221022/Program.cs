int fibon (int n)
{
if (n ==0 || n==1) return 1;
else return n * fibon(n - 1);
}
fibon(4);
int res = fibon(4);
System.Console.WriteLine(res);
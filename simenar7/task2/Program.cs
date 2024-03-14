int akkerman(int n, int m)
{
    if (n==0)
        return m+1;
    
    else
        if((n!=0)&&(m == 0))
         return akkerman(n-1,1);
    else
        return akkerman(n-1,akkerman(n,m-1));
}
Console.Write(akkerman(1,2)); //4
Console.Write(akkerman(0,0)); //1
Console.Write(akkerman(4,5)); // Srack Overflow

Console.ReadLine();

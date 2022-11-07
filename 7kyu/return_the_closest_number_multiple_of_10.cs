//Given a number return the closest number to it that is divisible by 10.

//Example input:

//22
//25
//37

//Expected output:

//20
//30
//40

using System;

public class Kata
{
    public int ClosestMultiple10(int num)
    {
       return ((int) Math.Round(num / 10.0)) * 10;    
    }
}

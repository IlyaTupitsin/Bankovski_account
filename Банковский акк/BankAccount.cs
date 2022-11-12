using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Bankccount
{
    public long balance;

    public Bankccount()
    {
        balance = 0;
    }

    void SayBalance(long money , short penny)
    {
        Console.WriteLine("На балансе: " + money + " руб. " + penny + "коп." );
    }
}

        

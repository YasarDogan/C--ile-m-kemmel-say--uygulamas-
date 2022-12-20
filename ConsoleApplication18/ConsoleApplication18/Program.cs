using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Mukemmel { 
    private int mSayi=0;
    public int sayi {
        get {
            return mSayi;
        }
        set {
            mSayi = value;
        }
    }

    public Mukemmel(int sayi) {
        this.sayi = sayi;
    }
    public bool mukemmelmi() {
        int say = 0;
        for (int i = 1; i < this.sayi; i++)
        {
            if (this.sayi % i == 0)
                say += i;
        }
        if (this.sayi == say)
            return true;
        return false;
    }

    public void dokum() {
        bool cevap = this.mukemmelmi();
        if (cevap)
            Console.WriteLine("Mükemmel bir sayı");
        else
            Console.WriteLine("Mükemmel olmayan bir sayı");
    }
    }



    class Program
    {
        static bool Mukemmelmi(int a) {
            int say = 0;
            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                    say += i;
            }
            if (a == say)
                return true;
            return false;
        }

        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Mukemmel m = new Mukemmel(a);
            m.dokum();

            Console.ReadKey();
        }
    }
}

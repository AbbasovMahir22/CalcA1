/*Bir Figure abstrakt class-ı olur və onun Figure-dan miras alan zaman mütləq override edilməsi lazım olan bir CalcArea methodu olur.

Bir Square class-ı olur side deyə bir property-i olur və side mənfi ola bilməz.
Side dəyəri təyin olunmamış Square obyekti yaradıla bilməz.
Square class-ı Figure class-ından miras alacaq və CalcArea methodunu özünə uyğun override edəcək.

Bir Rectangular class-ı olur width və length deyə property-ləri olacaq, width və length mənfi ola bilməz.
Width və length dəyərləri təyin olunmamış Rectangular obyekti yaradıla bilməz.
Rectangular class-ı Figure class-ından miras alacaq və CalcArea methodunu özünə uyğun override edəcək.

Program class-ında bir menu olacaq
1. Square
2. Rectangular
0. Quit

İstifadəçi 1 yazıb enter-ə click-ləsə Square-in CalcArea methodu işə düşməlidir.
İstifadəçi 2 yazıb enter-ə click-ləsə Rectangular-in CalcArea methodu işə düşməlidir.
İstifadəçi 0 yazıb enter-ə click-ləsə proqram sonlanmalıdı.*/


using CalcArea;
using CalcMethod;


Console.WriteLine("1.Square, 2.Rectangular,0.Quit ");
double Num = Convert.ToDouble(Console.ReadLine());
if (Num == 1)
{
    Console.Write("Side daxil edin :" + " ");
    double S = Convert.ToDouble(Console.ReadLine());
    Square square = new Square(S);
    Console.WriteLine(square.CalcArea());

}
else if (Num == 2)
{
    Console.Write("Widt daxil edin" + " ");
    double W = Convert.ToDouble(Console.ReadLine());
    Console.Write("Lentgh  daxil edin" + " ");
    double L = Convert.ToDouble(Console.ReadLine());
    Rectangular square = new Rectangular(W, L);
    Console.WriteLine(square.CalcArea());
}
else if (Num == 0)
{
    Console.WriteLine("Cixis edildi ");
}
else
{
    Console.WriteLine("Yanlis reqem daxil edildi proqrama yeniden giris edin");

}



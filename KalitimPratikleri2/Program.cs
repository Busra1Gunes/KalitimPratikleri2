// See https://aka.ms/new-console-template for more information
using System.Runtime.ConstrainedExecution;

A a = new A("");
B b = new B(true);
C c = new C();
Kazanan kaza= new Aday1();
Console.WriteLine(kaza.Kazanan() + "\n");

Console.WriteLine(a.Metod() + "\n" + b.Metod() + "\n" + c.Metod());
//Polimorfizim , interfacelerin veya base classların implemente edildikleri veya inherid edildikleri sınıfı
//referansını tutma özelliğinden dolayı o interface üzerinden farklı implementasyonlara geçebiliyoruz nuda bizim için poliformik ççok biçimli bir ortam sunuyor
//base claasın referansı derived classların nesnelerini  refere edebilirler
// örnek A yeni=new C(); 
public interface Kazanan
{
    string  Kazanan();

}

public class Aday1 : Kazanan
{

    string Kazanan.Kazanan()
    {
        return "Kazanan Aday1";
    }
}
public class Aday2 : Kazanan
{
   

    string Kazanan.Kazanan()
    {
        return "Kazanan Aday2";
    }
}
public class A
{
    public A(string a)
    {
        Console.WriteLine("A'dan başla");

    }
    //Eğer base class içerisindeki bir metod yani işlev derived(kalıtım alan) classlarda başka bir şekilde
    //kullanılacaksa ,o metod base class içerisinde virtual olarak tanımlanabilir
    //Böylece bu classtan türeyen classlar kendi içlerinde base classtan virtual
    //olarak belirtilen metodları yeniden tanımlayabilecektir
    public virtual string Metod()
    {
        return "A classı içindeki metod";
    }
}
public class B : A
{
    public B(bool a) : base("")//burada base B'nin kalıtım aldığı base clasını temsil eder
                               //eger Bnin contructoru içinde böyle bir değişiklik yapmasaydık B A'nın constructorundan dolayı hata vericekti
    {
        //eger b sınıfıda contructorunda parametre alırsa C klassında hata vericektir C claasdı içindede
        //contructor düzenlemesi yapmamız gerekir 
    }
    //Override ise virtual olarak base classtan tanımlanan herhangi bir elemanı derived classta yeniden şekillendirebilmemizi 
    //sağlayan komuttur
    public override string Metod()
    {
        return "Ben b classıyım A'daki metodu alıp değiştirdim";
    }
}
public class C : B
{
    //düzenleme bu şekilde yapılır
    public C() : base(true)
    {

    }
    public override string Metod()
    {
        return "Ben c classıyım A'daki metodu önce B değiştirdi şimdi de ben değiştirdim";
    }

}
//Polimorfizm, bir interface veya base class üzerinden farklı sınıfların farklı davranışlarını sergileme yeteneğidir.
//Örneğin, hayvanları temsil eden bir Animal interface'i veya base class'ı düşünelim.Bu interface veya base class,
//her hayvan türünün ortak özelliklerini ve bir makeSound() metodunu tanımlasın.

// Animal interface'i veya base class'ı
interface Animal
{
    void makeSound();
}

// Dog sınıfı
class Dog : Animal
{

    public  void makeSound()
    {
        string a = ("Hav hav!");
    }
}

// Cat sınıfı
class Cat : Animal
{

    public  void makeSound()
    {
        string a = ("Miyav!");
    }
}

// Kullanımı gösteren örnek
public class Main
{
    public static void main(String[] args)
    { 
        Animal animal1 = new Dog();
        Animal animal2 = new Cat();

        animal1.makeSound(); // Hav hav!
        animal2.makeSound(); // Miyav!
    }
}

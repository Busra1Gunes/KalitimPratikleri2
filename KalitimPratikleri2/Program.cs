// See https://aka.ms/new-console-template for more information
A a = new A("");
B b = new B(true);
C c = new C();

Console.WriteLine(a.Metod() + "\n" + b.Metod() + "\n" + c.Metod());



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

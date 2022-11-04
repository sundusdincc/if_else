internal class Program
{
    private static void Main(string[] args)
    {
        int time = DateTime.Now.Hour;
        if (time >= 6 && time <= 11)
        {
            Console.WriteLine("Günaydın!");
        }
        else if (time <= 18)
        {
            Console.WriteLine("İyi Günler!");
        }
        else
        {
            Console.WriteLine("İyi Geceler!");
        }


        //String sonuc=time<=18 ? "İyi Günler!" : "İyi Geceler!";
        String sonuc = time >= 6 && time <= 11 ? "Günaydın!" : time <= 18 ? "İyi Günler!" : "İyi Geceler";
        Console.WriteLine(sonuc);


        int a = 78;
        String grade = a < 50 ? "Student is failed" : a >= 50 && a <= 60 ? "Student gets D grade" : a >= 70 && a <= 80 ? "Student gets B grade" : "Student gets A+ grade";
        Console.WriteLine(grade);
        Console.ReadKey();
    }
}
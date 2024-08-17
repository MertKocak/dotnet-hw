namespace dotnet;
class Program
{
    static void Main(string[] args)
    {
        byte b = 5;
        sbyte sb = 5;
        short s = 5;
        ushort us = 5;

        Int16 i16 = 2;
        int i = 2;
        Int32 i32 = 2;
        Int64 i64 = 2;

        uint u = 2;
        long l = 4;
        ulong ul = 4;

        float f = 5;
        double d = 5;
        decimal de = 5;

        char ch = '2';
        string str = "Mert";

        bool b1 = true;
        bool b2 = false;

        DateTime dt = DateTime.Now;
        Console.WriteLine(dt);
        object o1 = "x";
        object o2 = 'y';
        object o3 = 4;
        object o4 = 4.3;

        // string ifadeler
        string str1 = string.Empty;
        str1 = "Zikriye Ürkmez";
        string ad = "Zikriye";
        string soyad = "Ürkmez"; string tamIsim = ad + " " + soyad;
        //integer tanımlama şekilleri
        int integer1 = 5;
        int integer2 = 3;
        int integer3 = integer1 * integer2;

        // boolean
        bool bool1 = 10 > 2;
        
        // Değişken Dönüşümleri
        string str20 = "20";
        int int20 = 20;
        string yeniDeger = str20 + int20.ToString(); Console.WriteLine(yeniDeger); // Çıktısı 2020
        int int21 = int20 + Convert.ToInt32(str20); Console.WriteLine(int21); // Çıktısı 40
        int int22 = int20 + int.Parse(str20); // Çıktısı 40
        
        // datetime
        string datetime = DateTime.Now.ToString("dd.MM.yyyy");
        Console.WriteLine(datetime);
        string datetime2 = DateTime.Now.ToString("dd/MM/yyyy"); Console.WriteLine(datetime2);
        
        //saat
        string hour = DateTime.Now.ToString("HH:mm");
        Console.WriteLine(hour);

    }
}

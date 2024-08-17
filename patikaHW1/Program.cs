namespace patikaHW1;
class Program
{
    static void Main(string[] args)
    {

        //ÖDEVİN BİRİNCİ SORUSU-----------------------------------------
        /*
        Console.WriteLine("Pozitif bir sayı giriniz:");

        int n = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[n];

        Console.WriteLine("{0} adet sayı giriniz:" , n);

        for(int i=0; i<n; i++){

            int x = Convert.ToInt32(Console.ReadLine());
            numbers[i] = x;
        }

        for(int j = 0; j<numbers.Length; j++){
            if(numbers[j]%2 == 0){
                Console.Write("Çift: {0}, " ,numbers[j]);
            }
        }
        -----------------------------------------------------------------*/



        //ÖDEVİN İKİNCİ SORUSU-----------------------------------------
        /*
        Console.WriteLine("Pozitif bir sayı giriniz:");
         int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Bölmek için bir sayı giriniz:");
         int m = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[n];

        Console.WriteLine("{0} adet sayı giriniz:" , n);

        for(int i=0; i<n; i++){
            int x = Convert.ToInt32(Console.ReadLine());
            numbers[i] = x;
        }

        Console.Write("{0}'e tam bölünen sayılar: " ,m);
        for(int j = 0; j<numbers.Length; j++){
            if(numbers[j]%m == 0){
                Console.Write("{0}, " ,numbers[j]);
            }
        }
        -----------------------------------------------------------------*/



        //ÖDEVİN ÜÇÜNCÜ SORUSU------------------------------------------
        /*
        Console.WriteLine("Pozitif bir sayı giriniz:");

        int n = Convert.ToInt32(Console.ReadLine());

        String[] numbers = new String[n];

        Console.WriteLine("{0} adet kelime giriniz:" , n);

        for(int i=0; i<n; i++){
            string x = Console.ReadLine()!;
            numbers[i] = x;
        }

        Array.Reverse(numbers);
        Console.WriteLine(String.Join(',', numbers));
        --------------------------------------------------------------------*/



        //ÖDEVİN DÖRDÜNCÜ SORUSU------------------------------------------
        Console.WriteLine("Bir cümle giriniz:");
        string n = Console.ReadLine()!;

        int wordCount = 1;
        int charCount = 0;
        int l = 0;
        int k = 0;

        while (l <= n.Length - 1){
            if (n[l] == ' ' || n[l] == '\n' || n[l] == '\t'){
                wordCount++;
            }
            l++;
        }

        while (k <= n.Length - 1){
            if (n[k] != ' '){
                charCount++;
            }
            k++;
        }

        Console.WriteLine("Toplam kelime sayısı : {0}\n", wordCount);
        Console.WriteLine("Toplam harf sayısı : {0}\n", charCount);
    }
}

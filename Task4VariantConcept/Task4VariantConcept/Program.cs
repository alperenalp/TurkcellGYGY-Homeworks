using Task4VariantConcept;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Kovaryant, veri türlerinin birbirine uygunluğu hakkında bir kavramdır. Bu, bir veri türünün, daha geniş bir veri türünün yerine kullanılabileceği anlamına gelir. 
         * 
         * Kovaryantlık, alt sınıfların, üst sınıfların yerine kullanılabileceği anlamına gelir. 
         * Yani, alt sınıflar, üst sınıfların yerine geçebilir ve üst sınıfın davranışını aynen taklit edebilirler. 
         * Bu, bir programın daha esnek olmasını sağlar ve kodun yeniden kullanılabilirliğini artırır.
         * 
         * */

        Animal animal = new Animal();
        Animal dog = new Dog();
        Animal cat = new Cat();

        animal.Feed();
        dog.Feed();
        cat.Feed();

        /*
         * 
         * "Animal" sınıfının bir özelliği, "Feed" metodudur. "Cat" ve "Dog" sınıfları da bu metodu kalıtım yoluyla almış olabilirler. 
         * Bu durumda, bir "Cat" veya "Dog" nesnesi, "Animal" tipi olarak kullanılabilir ve "Feed" metodunu kullanabilir.
         * 
         * */


        /*
         * Kontravaryantlık ise, tam tersi bir durumdur. Bir fonksiyonun parametrelerindeki tiplerin, alt tiplerin yerine geçebileceği anlamına gelir. 
         * 
         * */

        HayvanBarinagi hayvanBarinagi = new HayvanBarinagi();
        KediBarinagi kediBarinagi = new KediBarinagi();

        hayvanBarinagi.EvcilHayvanEkle(new Animal());
        //kediBarinagi.EvcilHayvanEkle(new Animal());
        kediBarinagi.EvcilHayvanEkle(new Cat());

        /*
         * "HayvanBarinagi" sınıfı, "EvcilHayvanEkle" metodunu tanımlar ve "hayvanlar" listesine yeni hayvan nesneleri ekler. 
         * "KediBarinagi" sınıfı ise "EvcilHayvanEkle" metodunu ezer ve sadece "Kedi" tipindeki nesnelerin eklenmesine izin verir.
         * Bu durumda, "EvcilHayvanEkle" metodunun parametrelerinin alt tiplerinin kullanılabilmesi nedeniyle 
         * "HayvanBarınağı" sınıfı, "EvcilHayvanEkle" metodunun kontravaryant olmasını sağlar.
         * */



        /*
         * In-Out generic interface'ler, generic tür parametrelerinin kovaryant ve kontravaryant olabilmesine olanak tanıdığı için, türler arasında dönüşüm yapmaya olanak sağlar.
         * Bu durum, kodun daha esnek olmasına ve daha az tekrar edilmesine yardımcı olur.
         * 
         * Bir interface'deki "in" parametresinin kontravaryant olması, alt sınıf beklenen yere üst sınıf geçilebilir demektir.
         * */

        IAnimal<Animal> animalSound = new AnimalSound<Animal>();
        IAnimal<Dog> dogSound = animalSound; // Kontravaryant kullanım

        dogSound.MakeSound(new Dog()); // "The animal made a sound." çıktısını verir

    }

}

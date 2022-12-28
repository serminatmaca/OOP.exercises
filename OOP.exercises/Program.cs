using OOP.exercises;


internal class Program
{
    // insan isimli bir sınıf içinde isim, soyisim, boy, kilo, yaş alanlarını tanımlayıp, bir kurucu metot içinde bu alanlar için varsayılan değer atamalarını yapacağız. son olarak da " Tanis" isimli metotla girilen bilgileri kullanıcıya belli, güzel, açıklayıcı bir şekilde görüntüleyen bir program yazınız..

    // örnek: Ben Şermin ATMACA.. boyum: 1,69.. kilom: 67 kg.. yaşım:29'dur

    private static void Main(string[] args)

    {
        clsPeople people = new clsPeople("sermin", "ATMACA", 169, 67, 29);

        people.Tanis();



        
    }

}

class UM_Alani
{
    public string Alan_Adi { get; set; }
    public List<string> İl_Adları { get; set; }
    public int İlan_Yılı { get; set; }

    public UM_Alani(string alan_Adı, List<string> il_Adları, int ilan_Yılı)
    {
        Alan_Adi = alan_Adı;
        İl_Adları = il_Adları;
        İlan_Yılı = ilan_Yılı;
    }
}
class Program
{

    public static void AlanlariListele(Dictionary<string, List<UM_Alani>> AlanGrup)
    {
        foreach (var bölge in AlanGrup)
        {
            Console.WriteLine($"--- {bölge.Key} Bölgesi ---");
            Console.WriteLine($"\nToplam {bölge.Value.Count} UNESCO alanı bulunuyor:\n");

            foreach (var alan in bölge.Value)
            {
                Console.WriteLine($"Alan Adı: {alan.Alan_Adi}");
                Console.WriteLine($"İl Adları: {string.Join(", ", alan.İl_Adları)}");
                Console.WriteLine($"İlan Yılı: {alan.İlan_Yılı}");
                Console.WriteLine();
            }

        }
    }
    //UM alanlarını kuyruk yapısına göre listeleme
    static void KuyrukListele(Queue<UM_Alani> Queue)
    {
        Console.WriteLine("Kuyruk İle Listelenen Um_Alanı Bilgileri:");
        while (!Queue.Bosmu())
        {
            UM_Alani alan = Queue.Sil();
            Console.WriteLine($"Alan Adı: {alan.Alan_Adi}");
            Console.WriteLine($"İl Adları: {string.Join(", ", alan.İl_Adları)}");
            Console.WriteLine($"İlan Yılı: {alan.İlan_Yılı}");
            Console.WriteLine();
        }
    }
    //Um alanlarını öncelikli kuyruk yapısına göre listeleme
    static void OncelikliKuyrukListele(PriorityQueue<UM_Alani> Queue)
    {
        Console.WriteLine("Öncelikli Kuyruk İle Listelenen Um_Alanı Bilgileri:");
        while (!Queue.Bosmu())
        {
            UM_Alani alan = Queue.Sil();
            Console.WriteLine($"Alan Adı: {alan.Alan_Adi}");
            Console.WriteLine($"İl Adları: {string.Join(", ", alan.İl_Adları)}");
            Console.WriteLine($"İlan Yılı: {alan.İlan_Yılı}");
            Console.WriteLine();
        }
    }

    static void HesaplaVeYazdir()
    {
        TamSayiKuyrugu tamSayiKuyruk = new TamSayiKuyrugu();
        tamSayiKuyruk.Ekle(10);
        tamSayiKuyruk.Ekle(4);
        tamSayiKuyruk.Ekle(8);
        tamSayiKuyruk.Ekle(6);
        tamSayiKuyruk.Ekle(7);
        tamSayiKuyruk.Ekle(1);
        tamSayiKuyruk.Ekle(15);
        tamSayiKuyruk.Ekle(9);
        tamSayiKuyruk.Ekle(3);
        tamSayiKuyruk.Ekle(2);

        double toplamSure = 0;
        int kuyrukBoyutu = tamSayiKuyruk.Count();

        while (!tamSayiKuyruk.Bosmu())
        {
            int urunSayisi = tamSayiKuyruk.Sil();
            double islemSuresi = urunSayisi * 2.5;
            toplamSure = islemSuresi + toplamSure;
            Console.WriteLine($"{urunSayisi} ürünü olan müşterinin işlemi {islemSuresi} saniye kadar sürdü.");
        }

        double ortalamaSure = toplamSure / kuyrukBoyutu;
        Console.WriteLine($"Ortalama işlem tamamlanma süresi: {ortalamaSure} saniye");

        PriorityQueueForNumbers PriorityQueue = new PriorityQueueForNumbers();

        PriorityQueue.Ekle(10);
        PriorityQueue.Ekle(4);
        PriorityQueue.Ekle(8);
        PriorityQueue.Ekle(6);
        PriorityQueue.Ekle(7);
        PriorityQueue.Ekle(1);
        PriorityQueue.Ekle(15);
        PriorityQueue.Ekle(9);
        PriorityQueue.Ekle(3);
        PriorityQueue.Ekle(2);

        HesaplaVeYazdir(PriorityQueue);
    }

    static void HesaplaVeYazdir(PriorityQueueForNumbers Queue)
    {
        int KuyrukBoyut = Queue.Count();
        double toplamSure = 0;


        while (!Queue.Bosmu())
        {
            int urunSayisi = Queue.Sil();
            double islemSuresi = urunSayisi * 2.5;
            toplamSure += islemSuresi;
            Console.WriteLine($"{urunSayisi} ürün olan müşterinin işlemi {islemSuresi} saniye sürdü.");
        }

        double ortalamaSure = toplamSure / KuyrukBoyut;
        Console.WriteLine($"Öncelikli Kuyruk ile ortalama işlem tamamlanma süresi: {ortalamaSure} saniye");
    }

    static void Main(string[] args)
    {
        List<UM_Alani> unescoAlanlari = new List<UM_Alani>();

        unescoAlanlari.Add(new UM_Alani("Göreme Millî Parkı ve Kapadokya", new List<string> { "Nevşehir" }, 1985));
        unescoAlanlari.Add(new UM_Alani("Hattuşa: Hitit Başkenti", new List<string> { "Çorum" }, 1986));
        unescoAlanlari.Add(new UM_Alani("Nemrut Dağı", new List<string> { "Adıyaman" }, 1987));
        unescoAlanlari.Add(new UM_Alani("Hieropolis-Pamukkale", new List<string> { "Denizli" }, 1988));
        unescoAlanlari.Add(new UM_Alani("Xanthos-Letoon", new List<string> { "Antalya", "Muğla" }, 1988));
        unescoAlanlari.Add(new UM_Alani("Safranbolu Şehri", new List<string> { "Karabük" }, 1994));
        unescoAlanlari.Add(new UM_Alani("Truva Arkeolojik Alanı", new List<string> { "Çanakkale" }, 1998));
        unescoAlanlari.Add(new UM_Alani("Edirne Selimiye Camii ve Külliyesi", new List<string> { "Edirne" }, 2011));
        unescoAlanlari.Add(new UM_Alani("Çatalhöyük Neolitik Alanı", new List<string> { "Konya" }, 2012));
        unescoAlanlari.Add(new UM_Alani("Bursa ve Cumalıkızık: Osmanlı İmparatorluğunun Doğuşu", new List<string> { "Bursa" }, 2014));
        unescoAlanlari.Add(new UM_Alani("Bergama Çok Katmanlı Kültürel Peyzaj Alanı", new List<string> { "İzmir" }, 2014));
        unescoAlanlari.Add(new UM_Alani("Diyarbakır Kalesi ve Hevsel Bahçeleri Kültürel Peyzajı", new List<string> { "Diyarbakır" }, 2015));
        unescoAlanlari.Add(new UM_Alani("Efes", new List<string> { "İzmir" }, 2015));
        unescoAlanlari.Add(new UM_Alani("Ani Arkeolojik Alanı", new List<string> { "Kars" }, 2016));
        unescoAlanlari.Add(new UM_Alani("Aphrodisias", new List<string> { "Aydın" }, 2017));
        unescoAlanlari.Add(new UM_Alani("Göbekli Tepe", new List<string> { "Şanlıurfa" }, 2018));
        unescoAlanlari.Add(new UM_Alani("Arslantepe Höyüğü", new List<string> { "Malatya" }, 2021));
        unescoAlanlari.Add(new UM_Alani("Gordion", new List<string> { "Ankara" }, 2023));
        unescoAlanlari.Add(new UM_Alani("Anadolu’nun Ortaçağ Dönemi Ahşap Hipostil Camiileri", new List<string> { "Konya", "Kastamonu", "Eskişehir", "Afyon", "Ankara" }, 2023));

        Dictionary<string, List<string>> bölgeler = new Dictionary<string, List<string>>
        {
            { "İç Anadolu", new List<string> { "Eskişehir", "Konya", "Ankara", "Çankırı", "Aksaray", "Kırıkkale", "Kırşehir", "Yozgat", "Niğde", "Nevşehir", "Kayseri", "Karaman", "Sivas" } },
            { "Karadeniz", new List<string> { "Bolu", "Düzce", "Zonguldak", "Karabük", "Bartın", "Kastamonu", "Çorum", "Sinop", "Samsun", "Amasya", "Tokat", "Ordu", "Giresun", "Gümüşhane", "Trabzon", "Bayburt", "Rize", "Artvin" } },
            { "Marmara", new List<string> { "Çanakkale", "Balıkesir", "Edirne", "Tekirdağ", "Kırklareli", "İstanbul", "Bursa", "Yalova", "Kocaeli", "Bilecik", "Sakarya" } },
            { "Akdeniz", new List<string> { "Antalya", "Burdur", "Isparta", "Mersin", "Adana", "Hatay", "Osmaniye", "Kahramanmaraş" } },
            { "Doğu Anadolu", new List<string> { "Malatya", "Erzincan", "Elazığ", "Tunceli", "Bingöl", "Erzurum", "Muş", "Bitlis", "Şırnak", "Kars", "Ağrı", "Ardahan", "Van", "Iğdır", "Hakkari" } },
            { "Ege", new List<string> { "İzmir", "Aydın", "Muğla", "Manisa", "Denizli", "Uşak", "Kütahya", "Afyon" } },
            { "Güneydoğu Anadolu", new List<string> { "Gaziantep", "Kilis", "Adıyaman", "Şanlıurfa", "Diyarbakır", "Mardin", "Batman", "Siirt" } },

        };

        foreach (var alan in unescoAlanlari)
        {
            foreach (var bölge in bölgeler)
            {
                if (alan.İl_Adları.Any(bölge.Value.Contains))
                {
                    if (!bölge.Value.Contains(alan.İl_Adları[0]))
                    {
                        bölge.Value.Add(alan.İl_Adları[0]);
                    }
                }
            }
        }

        Dictionary<string, List<UM_Alani>> AlanGrup = new Dictionary<string, List<UM_Alani>>();

        foreach (var bölge in bölgeler)
        {
            string bölgeAdı = bölge.Key;
            List<UM_Alani> alanlarBölgeyeAit = new List<UM_Alani>();

            foreach (var alan in unescoAlanlari)
            {
                foreach (var il in alan.İl_Adları)
                {
                    if (bölge.Value.Contains(il))
                    {
                        alanlarBölgeyeAit.Add(alan);
                        break;
                    }
                }
            }

            AlanGrup.Add(bölgeAdı, alanlarBölgeyeAit);
        }

        AlanlariListele(AlanGrup);

        Queue<UM_Alani> umAlanlariKuyruk = new Queue<UM_Alani>();

        // unescoAlanlari listesinden UM_Alanı nesnelerini kuyruğa ekleme
        foreach (var alan in unescoAlanlari)
        {
            umAlanlariKuyruk.Ekle(alan);
        }

        KuyrukListele(umAlanlariKuyruk);

        PriorityQueue<UM_Alani> oncelikliKuyruk = new PriorityQueue<UM_Alani>();

        // UM_Alanı nesnelerini öncelikli kuyruğa ekleme
        foreach (var alan in unescoAlanlari)
        {
            oncelikliKuyruk.Ekle(alan);
        }
        OncelikliKuyrukListele(oncelikliKuyruk);
        HesaplaVeYazdir();
    }
}
//Queue yapısı oluşturma
class Queue<T>
{
    private List<T> elements = new List<T>();

    public bool Bosmu()
    {
        return elements.Count == 0;
    }
    public void Ekle(T item)
    {
        elements.Add(item);
    }

    public T Sil()
    {
        if (Bosmu())
        {
            throw new InvalidOperationException("Kuyruk boş.");
        }

        T item = elements[0];
        elements.RemoveAt(0);
        return item;
    }

    public T Peek()
    {
        if (Bosmu())
        {
            throw new InvalidOperationException("Kuyruk boş.");
        }

        return elements[0];
    }

    public int Count()
    {
        return elements.Count;
    }

    public void Clear()
    {
        elements.Clear();
    }
}
//Priority Queue yapısı oluşturma
class PriorityQueue<Int>
{
    private List<Int> elements = new List<Int>();

    public void Ekle(Int item)
    {
        elements.Add(item);
    }

    public Int Sil()
    {
        if (Bosmu())
        {
            throw new InvalidOperationException("Kuyruk boş.");
        }

        Int enÖncelikliEleman = FindPriority();
        elements.Remove(enÖncelikliEleman);
        return enÖncelikliEleman;
    }

    private Int FindPriority()
    {
        Int Priority = default(Int);

        foreach (Int item in elements)
        {
            if (Priority == null || Karşılaştır(item, Priority) < 0)
            {
                Priority = item;
            }
        }

        return Priority;
    }

    private int Karşılaştır(Int x, Int y)
    {
        UM_Alani alanX = x as UM_Alani;
        UM_Alani alanY = y as UM_Alani;

        if (alanX != null && alanY != null)
        {
            return string.Compare(alanX.Alan_Adi, alanY.Alan_Adi);
        }

        throw new InvalidOperationException("UM_Alanı dışında elemanları karşılaştıramazsınız.");
    }

    public bool Bosmu()
    {
        return elements.Count == 0;
    }

    public int Count()
    {
        return elements.Count;
    }
    public void Clear()
    {
        elements.Clear();
    }
}
class PriorityQueueForNumbers
{
    private List<int> elements = new List<int>();

    public void Ekle(int item)
    {
        elements.Add(item);
    }

    public int Sil()
    {
        if (Bosmu())
        {
            throw new InvalidOperationException("Kuyruk boş.");
        }

        int enÖncelikliEleman = FindPriority();
        elements.Remove(enÖncelikliEleman);
        return enÖncelikliEleman;
    }

    private int FindPriority()
    {
        int enOncelikli = elements[0];

        foreach (int item in elements)
        {
            if (item < enOncelikli)
            {
                enOncelikli = item;
            }
        }

        return enOncelikli;
    }


    public bool Bosmu()
    {
        return elements.Count == 0;
    }

    public int Count()
    {
        return elements.Count;
    }
    public void Clear()
    {
        elements.Clear();
    }

}

class TamSayiKuyrugu
{
    private List<int> elements = new List<int>();

    public bool Bosmu()
    {
        return elements.Count == 0;
    }
    public void Ekle(int item)
    {
        elements.Add(item);
    }

    public int Sil()
    {
        if (Bosmu())
        {
            throw new InvalidOperationException("Kuyruk boş.");
        }

        int item = elements[0];
        elements.RemoveAt(0);
        return item;
    }

    public int Count()
    {
        return elements.Count;
    }
    public int Peek()
    {
        if (Bosmu())
        {
            throw new InvalidOperationException("Kuyruk boş.");
        }

        return elements[0];
    }

    public void Clear()
    {
        elements.Clear();
    }
}
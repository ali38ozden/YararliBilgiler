using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class burak : MonoBehaviour
{
    public Sprite[] burakResimler;
   


    public Text baslik, konu;
    public Image urunResmi;
    

    string urunisim;


    ortakScript _ortakScript;

    private void Awake()
    {
        _ortakScript = Object.FindObjectOfType<ortakScript>();
    }

    public void Urunler(string urun)
       
    {
        urunisim = _ortakScript.urunisim;
        _ortakScript.urunisim = urun;

        PlayerPrefs.SetString("urunisim", urunisim);
        #region uzumden-karasinek
        if (urun == "Üzüm")
        {
            urunResmi.sprite = burakResimler[0];
            baslik.text = "Üzümün Faydaları";

            konu.text = "\n- Üzümün en önemli özelliği, çok güçlü bir anti-oksidan olmasıdır. E vitamininden 50, C vitamininden ise 30 kat daha fazla anti-oksidan özellik göstermektedir. Bilinen tüm meyveler içinde en güçlü anti-oksidandır. Bu yönüyle de kansere karşı koruyucudur.\n\n" +
                "- Üzüm kalp damar sağlığı açısından da oldukça faydalıdır. Yüksek kolesterol problemi yaşayan kişilere kolesterol düşürücü olarak önerilmektedir. Kolesterol üzerine etkisi, iyi kolesterolü yükseltip kötü kolesterolü düşürmesi şeklinde gerçekleşir.\n\n" +
                "- Üzümün içindeki proantosiyanidinler beyin ve karaciğer hasarı üzerine beta karoten, C vitamini ve E vitaminlerinden daha güçlü bir koruyucu etki göstermektedirler. Ayrıca bu maddeler, kanın sulanması ve kan akımının hızlanmasında da görev almaktadırlar. Böylece özellikle gözdeki kılcal damarları güçlendirerek gözün saydam tabakasını korumakta, ilerleyen yaşlarda ortaya çıkan görme bozukluklarının azalmasına da yardımcı olmaktadırlar.\n\n" +
                "- Üzümde bulunan flavanoidler ciltteki kollajen ve elastin dokularını koruyarak erken yaşlanmayı önlerler, cildin sıkı ve elastik olmasını sağlarlar. Hücre yenileyici etkisi ile cildin güzelleşmesine yardımcı olurlar.\n\n" +
                "- Flavanoidler, saç hücreleri üzerine de etkilidirler. Saçın büyümesini uyarırken saç hücrelerinde de artışa neden olurlar.\n\n" +
                "- Üzüm anti-oksidan ve demir içeriği yüksek bir meyve olması nedeniyle yorgunluğun giderilmesinde etkilidir ve unutkanlığa karşı da koruyucudur.\n";
        }   //önemli olan burdaki "üzüm " isimin yukardaki "üzüm" isimiyle ayni olması tanimla(üzüm,"üzüm") ;tanimla(uzum,"üzüm") de olsa sorun vermez yani
        if (urun == "Muz")
        {
            urunResmi.sprite = burakResimler[2];
            baslik.text = "Muzun Faydaları";

            konu.text = "\n- İçerdiği kalsiyum, magnezyum ve fosfor gibi mineralleri ile de kemik sağlığında önemli bir yere sahiptir.\n\n" +
            "- Enerji verir. İçerisinde bulunan potasyumdan dolayı, güçlü bir enerji kaynağıdır.\n\n" +
            "- Enerji verir. İçerisinde bulunan potasyumdan dolayı, güçlü bir enerji kaynağıdır.\n\n" +
            "- Kan basıncını düzenler.\n\n" +
            "- Muz, iltihap önleme, tahriş olan bölgeleri iyileştirme ve cilt lekelerini geçirme gibi çeşitli faydalara sahiptir. Ayrıca muz kabuğu diş beyazlatmada doğal ürünler arasında en etkili besindir.\n\n";
        }
        if (urun == "Ceviz")
        {
            urunResmi.sprite = burakResimler[3];
            baslik.text = "Cevizin Faydaları";

            konu.text = "- Ceviz sağlıklı yağlar, lifler, vitaminler ve mineraller içerir.\n\n" +
                "- İç cevizin etrafını saran zarda, E vitamini, melatonin ve polifenol adı verilen bileşikler antioksidan özelliği sağlar.\n\n" +
                "- Beyin ve kalp sağlığını destekler.\n\n"
                ;
        }
        if (urun == "İncir")
        {
            urunResmi.sprite = burakResimler[4];
            baslik.text = "İncirin Faydaları";

            konu.text = "\n- Kokusu ile kendine hayran bırakan incir, sağlığa olan etkisi ile de dikkat çeker.\n\n" +
                "- İncir meyvesinin içinde yüksek potasyum bulunması ve yağ oranın az olması ve kalsiyum oranının fazla olması sebebi ile kalp ve damar sağlığını korur ve damar sertleşmesinin önüne geçer.\n\n"+
                "- Kalbin arına iyi gelir ve kalp yağlanmasını engeller.\n\n" + 
                "- Posalı yapısı ile sindirim sağlığı için önemlidir.\n\n" +
                "- Kemik ve diş sağlığını korumak isteyenlerin inciri bolca tüketmesi önerilir.\n\n"+      
                "- İncir içinde bulunan lifler sebebi ile meme kanserini önlediği söylenmektedir.\n\n" +
                "- İçinde bulunan magnezyum oranı ile saç köklerini besler ve saç derisini korur.\n\n"+
                "- İncir içerisinde bulunan potasyum ve B3 vitamini ile tansiyonu düzenlemede etkilidir.\n\n";
        }
        if (urun == "Mango")
        {
            urunResmi.sprite = burakResimler[5];
            baslik.text = "Mangonun Faydaları";

            konu.text = "\n- Mango iyi bir folat kaynağıdır, birkaç B vitamini ve A, C, K ve E vitaminleri barındırır. Bu vitaminlerin hepsi de bağışıklığı artırmaya yardımcı olur.\n\n" +
                "- Mango, tümü sağlıklı kalp fonksiyonunu destekleyen magnezyum, potasyum ve antioksidan mangiferini içerir.\n\n" +
                "- Potasyum ve magnezyum zengini mango tansiyonu düzenler.";
        }
        if (urun == "Ananas")
        {
            urunResmi.sprite = burakResimler[6];
            baslik.text = "Ananasın Faydaları";

            konu.text = "- Ananas, vücutta biriken fazla suyu atmanızda size yardım eden bir meyvedir.\n\n" +
                "- Kilo vermek istediğinizde, sizi rahatsız eden yağları yakmak için tüketebilirsiniz.\n\n" +
                "- Ayrıca antioksidan etkisi ile kalpten saça kadar sizi zararlı maddelerden korur.\n\n" +
                "! Ananasta bulunan şeker oranı bir miktar yüksek olduğu için porsiyon kontrolüne dikkat etmeniz önerilir.";
        } 
        if (urun == "Şeftali")
        {
            urunResmi.sprite = burakResimler[7];
            baslik.text = "Şeftalinin  Faydaları";

            konu.text = "\n- Şeftali, sindirim sistemi için tercih edilecek en sağlıklı meyvelerden biridir. Midenin rahatlamasını sağlar.\n\n" +
                "- Posalı bir meyvedir bu yönü ile idrar söktürücü olarak tüketilir.\n\n" +
                "- C vitamini, potasyum ve posa minerallerini alabileceğiniz şeftali, karaciğer ve safra kesesinin sağlığını da korumakla görevlidir.\n\n";
        }
        if (urun == "Sirke")
        {
            urunResmi.sprite = burakResimler[8];
            baslik.text = "Sirke İçmenin Faydaları";

            konu.text = "\n- Sirke metabolizmayı hızlandırarak yağ yakımına yardım ediyor.\n\n" +
                "- Antioksidan etkisi ile bilinen sirke, vücutta detoks etkisi yaratıyor.\n\n" +
                "- Bağırsak hareketleri düzenli sirkeli su içiminde düzene giriyor.\n\n";
        } 
        if (urun == "Kakao")
        {
            urunResmi.sprite = burakResimler[9];
            baslik.text = "Kakaonun Faydaları";

            konu.text = "- Kakao, hipoglisemik etkisiyle kötü kolesterolün düşmesine yardımcı olur. Mutluluk hormonunu arttırır. Bu sayede stres ve depresyon riskini düşürür. Ayrıca doğal bir antidepresan niteliğindedir.\n";
        } 
        if (urun == "L-Karnitin")
        {
            urunResmi.sprite = burakResimler[10];
            baslik.text = "L-Karnitin";

            konu.text = "\n L-Karnitin Nedir?\n\n" +
                "- Amino asit olarak gösterilen L-karnitin, tamamen bir amino asit değildir. B vitaminleriyle oldukça ilgili olan L-karnitin, aslında bir vitamin türü olarak da ifade edilebilir.\n\n" +
                "- Karaciğer ve böbreklerde üretilen Karnitin vitamini, vücudun belirli bölgelerinde saklanır. Spor ve enerji harcanması gereken eylemlerde vücut tarafından kullanılır.\n\n" +
                "- Birçok besin incelendiğinde yapısında Karnitin vitaminin bulunduğu gözlemlenir. Bu besinlerden en yaygını kırmızı et ve avokado olmaktadır.\n\n" +
                "- L-karnitin içeren besinler mutfağınıza girmeli. Kırmızı et, beyaz peynir, haşlanmış tavuk göğsü, süt ve süt ürünlerinde L-karnitin yer alır.\n\n\n" +
                " L-Karnitin Ne İşe Yarar, Nasıl Kullanılır?\n\n" +
                "- L-karnitin kullanımı oldukça basittir. Minik serumlar şeklinde üretilen L-karnitin, saniyeler içinde tüketilebilir formda satılmaktadır.\n\n" +
                "- L-karnitini karbonhidratlarla birlikte tüketmeniz önerilir.\n\n" +
                "- L-karnitin doğru zamanda kullanılmalıdır. Bu doğru zaman ise; insülinin tepe noktasıdır. Kas hücrelerine glikozu taşıma görevi olan bu vitamin desteği, genellikle spor öncesinde tercih edilir.\n\n\n" +
                " L Karnitin Faydaları\n\n" +
                "- Yağların vücut tarafından enerji olarak kullanılmasını sağlarlar. Böylece yağ yakımına destek olurlar.\n\n" +
                "- Egzersiz sırasında yüksek ATP üretimine katkı sağlayacağı için daha az yorgunluk hissi oluşur.\n\n" +
                "- Kan şekerini dengeler. Karbonhidratla beraber tüketilen L karnitin, kandaki glikozu dengeler ve kan şekerinin yükselmesine engel olur.\n\n" +
                "- Kasların sağlığını korur. Kas hücrelerinin daha hızlı üretilmesine yardım eder.\n";
        }
        if (urun == "Omega 3")
        {
            urunResmi.sprite = burakResimler[11];
            baslik.text = "Omega-3'ün Faydaları ";

            konu.text = "- Kalp ve damar sağlığını korur, trigliserit düzeylerinin azaltır, iyi kolesterol olarak bilinen HDL'yi artırır, kalp krizi ve felç gibi riskini azalmasına yardımcı olur, yüksek tansiyonu önler.\n\n" +
                "- Omega-3 yağ asitlerinin antiinflamatuar etkisi bulunur. İltihaplı bağırsak hastalıklarına (ülseratif kolit ve Crohn hastalığı) ve otoimmün temelli romatolojik hastalıkları karşı etkilidir.\n\n" +
                "- Omega-3 yağ asitlerinin bağışıklık tepkisinin düzenlenmesi ayrıca hücre çoğalmasının kontrolü ve tümörlere karşı mücadelede potansiyel etkileri vardır.\n\n" +
                "- Bazı nörolojik ve psikiyatrik hastalıkların semptomlarının azalması ve yaşa bağlı görme kaybının önlenmesini sağlamaktadır.\n\n" +
                "- Omega-3 anne karnındaki bebeklerin beyin gelişimi, merkezi sinir sistemi ve bedensel gelişimi için de çok önemlidir.\n\n\n" +
                " Omega-3 Ne İçin Kullanılır\n\n" +
                "- Kalp hastalığı riskini azaltmak.\n\n" +
                "- Vücuttaki iltihabı azaltmak.\n\n" +
                "- Göz sağlığını desteklemek.\n\n" +
                "- Beyin sağlığını desteklemek.\n\n" +
                "- Çocuklarda dikkat eksikliği ve hiperaktivite bozukluğu belirtilerini azaltmak.\n\n" +
                "- Yüksek tansiyonu önlemek.\n";
        }
        if (urun == "Güneş Işığı")
        {
            urunResmi.sprite = burakResimler[12];
            baslik.text = " Güneş Işığı ";

            konu.text = "- Güneş ışığının; D vitamini sentezlenmesi sağlamak, kemik sağlığını geliştirmek, bağışıklık sistemini güçlendirmek, beyin sağlığını korumak, vücuttaki fazla yağın atılmasını sağlamak ve dişleri güçlendirmek gibi önemli faydaları vardır.\n";
        }
        if (urun == "Safran")
        {
            urunResmi.sprite = burakResimler[13];
            baslik.text = "Safranın Faydaları ";

            konu.text = "- Antioksidan özelliği nedeniyle solunum rahatsızlıklarına iyi gelir.\n\n" +
                " - Depresyon, kaygı, hafıza kaybı ve nörolojik hastalıklara karşı koruma sağlar. \n\n" +
                "- C vitamini, magnezyum, demir, potasyum yönünden zengin olan safran aynı zamanda kan şekeri seviyesini düzenler\n";
        }
        if (urun == "Chia")
        {
            urunResmi.sprite = burakResimler[14];
            baslik.text = "Chia Faydaları ";

            konu.text = "- Chia tohumu, bitki bazlı Omega-3 yağ asitleri içermektedir.\n\n" +
                "- Araştırmalar Omega 3 yağ asitlerinin, kolesterolü düşürdüğü, kalp ritmini düzenlediği ve kalp damar sağlığına yardımcı olduğunu göstermiştir. \n\n" +
                "- İçerdiği kalsiyum, magnezyum ve fosfor gibi mineralleri ile de kemik sağlığında önemli bir yere sahiptir\n";
        } 
        if (urun == "Kabak")
        {
            urunResmi.sprite = burakResimler[15];
            baslik.text = "Kabak Faydaları ";

            konu.text = "- Zengin bir antioksidan kaynağı olan kabak, içeriğindeki antioksidanlar sayesinde cilt ve göz sağlığı için birebirdir.\n\n" +
                " - İçeriğinde yüksek oranda su bulunması, sindirim sisteminin daha verimli çalışması için kolaylık sağlar. \n\n" +
                "- Kabaktaki düşük sodyum ve yüksek potasyum, kan basıncını dengeler ve yüksek tansiyonu düşürmeye yardımcı olur.\n\n";
        }
        if (urun == "Kabızlık")
        {
            urunResmi.sprite = burakResimler[16];
            baslik.text = " Kabızlık ";

            konu.text = "\n- Bol bol su ve sıvı gıdalar tüketmelidir.\n\n" +
                " - Lif ağırlıklı sebze, meyve, bakliyat ve tahıllardan oluşan beslenme programı hazırlanmalıdır. \n\n" +
                "- Lokmalar iyice çiğnendikten sonra yutulmalıdır.\n\n"+
                "- Tuvalet düzeni oluşturulması ve tuvalet ihtiyacı ertelenmemelidir.\n\n";
        }
        if (urun == "Kafur")
        {
            urunResmi.sprite = burakResimler[17];
            baslik.text = " Kafur ";

            konu.text = "- Genellikle mevsim geçişlerinde ve kış mevsiminde ortaya çıkan grip ve nezle gibi üst solunum yolu hastalıklarına karşı bağışıklık sistemini korumaya yardımcı olur.\n\n" +
                " - Bunun yanında mide ekşimesi, şişkinlik ve hazımsızlık gibi şikayetlerin azalmasına yardımcı olur. \n\n" +
                "- Günde bir fincan kafur çayı içmek, böbrek sağlığını da korumaya yardımcı olur.\n\n" +
                "- Yanık yaralarını iyileştirmek için kafur yağı ya da kafur içeren balsamlar ve kremler kullanılabilir.\n\n"+
                "- Kafur yağı, dekonjestan ve öksürük kesici özelliktedir. Yapılan çalışmalar kafur yağının buhar olarak teneffüs edilmesinde solunum yolları rahatsızlıklarına iyi geldiğini göstermiştir.\n\n"+
                "- Kafur ürünleri ayrıca kas ağrılarında da kullanılabilir. Kas kramplarını , spazmları ve sertliği gidermeye yardımcı olabilir.\n\n";
        } 
        if (urun == "Kalp Çarpıntısı")
        {
            urunResmi.sprite = burakResimler[18];
            baslik.text = " Kalp Çarpıntısı ";

            konu.text = "- Taşikardi ya da kalp çarpıntısı kişi istirahat halindeyken kalbin, normalden daha hızlı attığı yaygın bir kalp ritmi bozukluğu türüdür. Kalp atış hızının egzersiz, stres, travma veya hastalığa karşı fizyolojik bir cevap olarak artması ise normaldir ve sinüs taşikardisi olarak adlandırılır. Bu, kalbin doğal kalp uyarısını sağlayan ve sağ kulakçıkta bulunan sinüs düğümünün normalden daha hızlı elektrik sinyalleri göndermesi nedeniyle olur. Kalp atım hızı artmıştır, fakat ritim bozukluğu yoktur. Patolojik taşikardilerde ise kalp, dinlenme sırasında üst veya alt odacıklarda veya her ikisinde birden normalden daha hızlı atar. Kalbin daha hızlı atması nedeniyle, kalp kaslarının (miyokard) oksijen ihtiyacı artar. Bu durum uzun süre devam ederse, oksijen yetersizliğine bağlı miyokard hücreleri ölebilir ve bu da kalp krizine yol açabilir.";
                
        }
        if (urun == "Kan")
        {
            urunResmi.sprite = burakResimler[19];
            baslik.text = "Kan Nedir";

            konu.text = "- Kan damarlarımızda sürekli dolaşan yaşam için temel oluşturan canlı bir sıvıdır. Dolaşımda ki toplam kan hacminin normal değeri vücut ağırlığının % 8’idir.Bu değer 70 kg’lık bir insanda 5600 ml.’dir. Bunun yaklaşık %50-60'ı plazma adınıalan sıvıdan ve %40-50'si ise hücrelerden oluşur. Plazmanın büyük kısmı sudur. Bu su içinde besin maddeleri, proteinler ve diğer yaşamsal önemde kimyasal maddeler bulunur. lyuvar (eritrosit), Akyuvar (lökosit) ve kan pulcukları (trombositler) ise kan hücrelerini oluştururlar.\n\n";
        }
        if (urun == "Kan Vermek")
        {
            urunResmi.sprite = burakResimler[20];
            baslik.text = " Kan Vermek ";

            konu.text = "- Kan verdiğinizde vücudunuzdaki kan hücreleri yenileniyor bu da daha sağlıklı ve daha güçlü olmanızı sağlıyor.\n\n" +
                "-  Kan bağışı kalp krizi ihtimalini %90 oranında azaltıyor. \n\n" +
                "- Baş ağrısına iyi geliyor.\n\n"+
                "- Yüksek tansiyona iyi gelir.\n\n" +
                "- Kanda bulunan yüksek yağ oranını düşürür.\n\n";
        }
        if (urun == "Kanamayı Durdurmak")
        {
            urunResmi.sprite = burakResimler[21];
            baslik.text = " Kanamayı Durdurmak ";

            konu.text = "- Direk Baskı: Yaranın üzerine gazlı bez kapatıp elinizle bastırabilirsiniz, gazlı bez de yoksa sadece elinizle direk yaranın üstünü kapatıp bastırmalısınız. Baskıyı uzun süre devam ettirebilmek için basılı sargı uygulanır. Yaranın üzerine kapatılan gazlı bezin üzerine elastik olmayan bandajla baskı uygulayacak şekilde aşağıdan yukarı doğru sargı yapılır. Kanama devam ediyorsa, eskisini sökmeden baskılı sargı tekrar edilir. \n\n" +
                " -  Kaldırma: Yaralı veya kanayan kısmın kalp seviyesi üzerine kaldırılması ile kanama oldukça azalır hatta durabilir.\n\n" +
                "- Baskı Noktaları: Yaralı bölgeyi besleyen ana damarı sıkıştıracak bir kuvvetle bastırılır. Şakak bölgesi için, kulak önüne; yüz bölgesi için, alt çene kemiğinin hemen altına, kol bölgesinde, köprücük kemiğinin üçte bir iç kısmının arka ve alt tarafına doğru; bacak bölgesi için; kasık kıvrımından geçen atar damarı sıkıştıracak bir kuvvetle bastırılır. \n\n" +
                "- Turnike: Kanama hala durmadıysa veya kanama alanı baskı uygulanamayacak kadar büyükse kol ve bacaklardaki büyük kanamalarda atardamarı deri ile kemik arasında durdurma yöntemidir.Tek kemikler üzerine uygulanır. Yaranın üzerinden turnike bağlanır, kanama durana kadar sıkılır. Her 20 dakikada bir 5-10 saniye turnike gevşetilir, kanama durduysa hemen sökülmelidir. Uygulanan turnike 1 saatten fazla kalmamalıdır, daha uzun kalacaksa hastanede açılmalıdır.\n\n";
                
        }
        if (urun == "Kan Tükürmek")
        {
            urunResmi.sprite = burakResimler[22];
            baslik.text = " Kan Tükürmek ";

            konu.text = "- En sık görülen hemoptizi nedenleri, akut bronşitler, kronik bronşitler, pnömoni(zatüre), tüberkülozdan oluşan enfeksiyonlar, akciğer kanserleri, bronşiektazilerdir. Enfeksiyonlar, hemoptizilerin yaklaşık yüzde 50 – 70 arasında değişen oranlarda sebebini oluşturmaktadır. Sıklıkla bakteriyel enfeksiyonlar hemoptizi nedeni olurken, influenza (grip) ve HIV(AIDS) gibi virüsler de hemoptizi nedenleri arasında yer alabilmektedir. Kronik bronşitler de, yıl içerisinde birkaç kez tekrarlayan hemoptizilere neden olabilir. Akciğer kanserleri ise, hemoptizilerin yaklaşık yüzde 20’sinden sorumludur. Endometriozis olarak adlandırılan bir kadın hastalığı da hemoptizinin nadir nedenleri arasında yer alır ve tipik olarak kanamalar adet dönemlerinde meydana gelebilir. Bu kanamalar katemenial hemoptizi olarak adlandırılır. Arsenik, asbest, nikel, eter gibi bir takım çevresel etkenlere maruziyet de hemoptiziye neden olabilmektedir. Bazı parazitik enfeksiyonlar da akciğerleri tuttuğunda hemoptiziye sebep olabilmektedir. Akciğere pıhtı atması, arteriovenöz malformasyonlar, arteriel anevrizmalar gibi damarsal hastalıklar da hemoptizi hastalığının yaşanmasına sebebiyet verebilir. Her türlü tetkike rağmen yaklaşık yüzde 10 hastada, hemoptizinin sebebi bulunamaz ve bu durum idiopatik (sebepsiz) hemoptizi olarak adlandırılır. \n\n";
               
        }
        if (urun == "Kangren")
        {
            urunResmi.sprite = burakResimler[23];
            baslik.text = " Kangren ";

            konu.text = "- Kangren yunanca kökenli bir kelime olup yetersiz kanlanma ya da mekanik veya termal hasarın neden olduğu dokuda yumuşama, büzülme, kuruma ve kararma ile karakterize kayıptır. Bu kayıp hemen hemen tüm organlarda görülebilir. En sık görüldüğü doku ve organlar bacak, kol, apandis ve ince bağırsaktır. Halk arasında sıklıkla yanlış olarak gangren şeklinde isimlendirilir.\n\n" +
            "- Kangren kısaca kanlanma bozukluğu sonucu ortaya çıkan doku ölümü şeklinde tanımlanabilir. Cilt baskın olarak etkilendiği için dışardan çıplak gözle rahatlıkla görülebilir. Kuru ya da yaş kangren şeklinde iki farklı formda ortaya çıkabilmektedir. Yaş kangren olarak adlandırılan türü, akıntılı bir bacak ülseri şeklinde de kendini gösterebilir.\n\n";

        }
        if (urun == "Kanser")
        {
            urunResmi.sprite = burakResimler[24];
            baslik.text = " Kanser ";

            konu.text = "- Kelime anlamı olarak kanser, bir organ veya dokudaki hücrelerin düzensiz olarak bölünüp çoğalmasıyla beliren kötü urlara denir. Genel anlamda ise kanser vücudumuzun çeşitli bölgelerindeki hücrelerin kontrolsüz çoğalması ile oluşan 100'den fazla hastalık grubudur. Çok çeşitli kanser tipleri olmasına rağmen, hepsi anormal hücrelerin kontrol dışı çoğalması ile başlar. Tedavi edilmez ise ciddi rahatsızlıklara, hatta ölüme dahi neden olabilir.\n\n" +
            "- Kanser (cancer) terimi, tıbbın babası olarak bilinen Yunan fizikçi Hippocrates (MÖ 460-370) tarafından oluşturulmuştur. Hippocrates carcinos ve carcinoma terimlerini ülser oluşturan ve ülser oluşturmayan tümörler için kullanmıştır.\n\n";

        }
        if (urun == "Kansızlık")
        {
            urunResmi.sprite = burakResimler[25];
            baslik.text = " Kansızlık ";

            konu.text = "- Pirinç, buğday, çavdar, mısır ve yulaf kansızlığa iyi gelir.\n\n" +
                " -  Kırmızı et türleri, ıspanak, pazı, pekmez, balık, elma, tavuk ve yeşil yapraklı sebzeler, demir içeren besinlerin başında gelir.\n\n" +
                "- Hamsi, sardalya, uskumru, istiridye, karides, midye, ton balığı, balık yağı ve somon. \n\n" +
                "- Nohut, mercimek, iç bakla, kuru fasulye ve barbunya.\n\n"+
                "- Genellikle yeşil yapraklı sebzeler, kuşkonmaz, brokoli, bezelye, yeşil biber.\n\n"+
                "- Karadut, böğürtlen, çilek, portakal, yaban mersini, muz ve frenk üzümü.\n\n"+
                "- Fındık, ceviz, badem, kuru üzüm, kuru incir ve kuru erik kansızlığa iyi gelen besinler arasındadır.\n\n"+
                "- İçeriğinde bol miktarda demir barındıran pancar, kansızlığa iyi gelen besinlerin başında gelir. Pancar suyu malzemeleri: 1 adet pancar, 1 bardak su ve 1 adet havuçtur. İlk olarak pancar ve havucu mikserden geçirin. Üzerine suyu ilave edin ve köpüklenene kadar karıştırın. Hiç bekletmeden karışımı için.\n\n";

        }
        if (urun == "Karabiber")
        {
            urunResmi.sprite = burakResimler[26];
            baslik.text = " Karabiber ";

            konu.text = "- Karabiberin içeriğinde C ve A vitaminleri bulunur. Bunun yanı sıra potasyum, demir , magnezyum ve mineral de yer alır. Bu yüzden karabiber tüketimi kış aylarında virüslere karşı dayanıksız olan direnci yükseltir. Soğuk algınlığı, nezle, grip gibi kış hastalıklarının daha hafif geçirilmesinde yardımcı olur.\n\n" +
                " - Göz sağlığı için en faydalı vitaminlerden biri A vitaminidir. Karabiberin içeriğinde de bolca A vitamini bulunduğu için göz sağlığına ve göz alerjilerine iyi gelir. \n\n" +
                "- C vitamini yüklü olan karabiber antibiyotik etkisine sahiptir. Hastalıklara karşı kalkan görevi görür. \n\n" +
                "- Vitamin ve mineral açısından zengin olan karabiber enerji verir, sindirim sistemini korur ve daha düzenli çalışmasına yardımcı olur. Aynı zamanda bağırsak ve mide rahatsızlıklarına da iyi gelir.\n\n" +
                "- Karabiberin farklı tüketim şekilleri ile sağlığa farklı katkılar sunulabilir. Eğer zerdeçal ile karabiber karıştırılıp tüketilirse bu karışım sigarayı bırakma sürecinizde destek olur.\n\n" +
                "- Kansere karşı koruma sağlar.\n\n" +
                "- Cildin sağlıklı bir görünüme kavuşmasına yardımcı olur.\n\n";
        }
        if (urun == "Karaciğer Sağlığı")
        {
            urunResmi.sprite = burakResimler[27];
            baslik.text = " Karaciğer sağlığı ";

            konu.text = "- Karaciğer sağlığının korunması için yaşam boyu dikkat edilmesi gereken bazı hususlar söz konusudur. Alkol ve sigara kullanımı ile gereksiz ilaç kullanımından kaçınmak, düzenli egzersiz yapmak, stresten uzak durmak, sağlık kontrollerini düzenli olarak yaptırmak ve sağlıklı beslenmek bunların başında gelir. Özellikle sağlıksız bir beslenme planının uygulanması, karaciğerin yorulmasına ve yağlanmasına neden olarak organa hasar verir. \n\n" +
            "- Bu nedenle protein, yağ ve karbonhidrat oranı dengeli, taze meyve ve sebzeleri yeterli miktarda içeren bir diyetin uygulanması karaciğer sağlığının korunması açısından elzemdir. Bunun yanı sıra bazı doğal besin türleri, karaciğer sağlığının korunmasına yardımcı olur ve karaciğer hastalıklarını önlemeye katkı sağlar. Bu besinlerin düzenli olarak tüketimi de sağlıklı bir karaciğere sahip olmak isteyen kişiler için önerilebilir. Enginar, Kahve, Yeşil çay örnek verilebilir. \n\n"; 

        }
        if(urun == "Karaçiçek")
        {
            urunResmi.sprite = burakResimler[28];
            baslik.text = " Karaçiçek ";

            konu.text = "- İnsan vücudunun her yerinde çıkabilen mercimek büyüklüğündeki(çiçek hastalığı cinsinden) sivilcelerdir. Başları siyah olduğundan dolayı Karaçiçek denilmiştir. Taun cinsinden bulaşıcı ve tehlikeli bir hastalıktır.  \n\n";
          

        }
        if (urun == "Karanfil")
        {
            urunResmi.sprite = burakResimler[29];
            baslik.text = " Karanfil ";

            konu.text = "- Antiseptik ve antibakteriyeldir.\n\n"+
            "- Mantar üremesini azaltır. Spazm çözer.\n\n"+
            "- Ağrı azaltıcı etkisi vardır.\n\n"+
            "- Ağırlık uzaklaştırmada faydalıdır, zihinsel ve fiziksel yorgunluğa iyi gelir,\n\n"+
            "- 10-20 dakikada toparlanmanızı sağlar. İshal ve ülseratif kolit gibi bağırsak enfeksiyonlarına iyi gelir.\n\n"+
            "- Diş eti ve diş ağrılarına hafifletici etkisi vardır.\n\n"+
            "- Stresi azaltır ve akne tedavisini destekler.\n\n"+
            "- Fazlası toksik etki yaratabilir. Yutulmaması gerekir. Hafifçe çiğnenip aroması alınabilir.\n\n";


        }
        if (urun == "Karasinek")
        {
            urunResmi.sprite = burakResimler[30];
            baslik.text = " Karasinek ";

           konu.text = "- Günde yaşama zarar verecek milyonlarca canlıyı yok ederler.\n\n"+
            "- Özellikle öldükten sonra bulaşıcı olarak zarar verici canlıları ortadan kaldırırlar.\n\n"+
            "- Yaşamda oluşabilecek birçok farklı hastalığın önüne geçme konusunda yardımcı olurlar.\n\n"+
            "- Doğada oluşmuş birçok zararlı leşin ortadan kalkmasına destek verirler.\n\n"+
            "- Besin zincirinde dengenin bozulmaması için çok önemli bir yer tutarlar.\n\n";
        
        }
        #endregion
        if (urun == "Karın Ağrısı")
        {
            urunResmi.sprite = burakResimler[31];
            baslik.text = " Karın Ağrısı Nasıl Geçer ";

            konu.text = 
             "\n- Bağırsak hareketlerini engellememek ve tuvalete çıkmak\n\n" +
             "- Karın ve ayaklara sıcak su torbası yerleştirmek.\n\n" +
             "- Sıcak bir duş ve banyo yapmak.\n\n" +
             "- Karına dairesel hareketler ile masaj yapmak.\n\n" +
             "- Uyuyarak dinlenmek.\n\n"+
             "- Kolay sindirilebilir yiyecekler yemek.\n\n"+
             "- Asitli içeceklerden uzak durmak.\n\n"+
             "- Esneme hareketleri yapmak iyi gelir.\n\n";

        }
        if (urun == "Karpuz")
        {
            urunResmi.sprite = burakResimler[32];
            baslik.text = " Karpuz ";

            konu.text = "\n- İçeriğinde lif olmasından ötürü, bağırsakları çalıştırır. \n\n" +
             "- Gün içerisindeki meyve gereksinimini karşılar.\n\n" +
             "- Su içermesinden ötürü, gün içerisinde tüketilmesi gereken sıvının belli bir bölümünü karşılar.\n\n" +
             "- C vitamini ve folik asit açısından zengindir. C vitamini, hastalıklara karşı koruma sağlayan en önemli antioksidan vitaminleri içerisinde bulunur. \n\n" +
             "- Kırmızı renkli meyvelerin içerisinde likopen ve antosiyanin yüksektir. Bu bileşenler; kalp krizi, kalp hastalıkları ve bazı kanser çeşitlerine karşı koruma sağlar.\n\n" +
            "- Karpuzun bilinmeyen bir başka faydası ise; kansere karşı koruyucu olduğudur. Karpuz, içerdiği vitamin ve mineraller sayesinde vücudu kansere karşı korumaktadır.\n\n" +
            "- Karpuz; böbreklerin işlevlerini doğru bir şekilde getirmesine yardımcı olur. \n\n";
            

        }
        if (urun == "Kaşıntı")
        {
            urunResmi.sprite = burakResimler[33];
            baslik.text = " Kaşıntı ";

            konu.text = "- Öncelikle kaşıntının ortaya çıkış sebebi bulunmalıdır. Altta yatan nedene göre tedavi planlamak önemlidir. Böcek ısırığında kremler ile yatıştırma yapılır.  Bulunulan ortam böcekten arındırılır. \n\n" +
             "- Strese bağlı kaşıntı olduğunda ikili hekim tedavisi uygulanabilir. Nörodermatit yani sinirsel egzama bugünlerde çok karşılaşılan bir hastalıktır. Bu rahatsızlıkta hem dermatolog hem psikiyatri uzmanının tedavi etmesi gerekir. Psikiyatrik temele dayanan kaşıntıların da birçok formu vardır. Günlük strese bağlı kaşıntılar gelişebildiği gibi kronik psikiyatrik hastalıklara bağlı kaşıntılarla da karşılaşılabilir. Bu durumlarda iki bölümde uzman görüşüyle tedavi planlanması önemlidir.\n\n" +
             "- Karaciğer hastalıklarında, çok alkol tüketen hastalarda, siroz hastalarında kaşıntı görülür. Karaciğer vücutta böbrekle birlikte toksin atan organdır. Safra kesesi hastalıklarında; safra keseden doğru düzgün akamazsa geri gelirse, safra artarsa halk arasında sarılık denilen hastalık oluşur bu da kaşıntıyı etkileyen faktördür. Safra kesesini tıkayan taşlar, pankreas hastalıkları, böbrek hastalıkları ve böbrek yetmezliğine bağlı kaşıntılar oluştuysa burada da o hastalığa yönelik tedavi planlanması gerekmektedir.\n\n" +
             "- Kaşıntının yatıştırılması için cilde sürülen kremler kullanılır. Kaşıntı kremleri genelde kortizon içerir ama kortizonlar farklı kategoride ve nemlendirici ile birlikte verilir. Bu ikili tedavide hem etkisi daha fazla olmakta hem de kortizonun yan etkileri azaltılmaktadır. Kortizon hücrelerin geri çekilmesinde kaşıntının azalmasında en önemli faktördür.  \n\n" +
             "- Her kaşıntıda aynı ilaç kullanılmamaktadır. Uzmana sormadan kaşıntı için daha önce kullanılan ilaçlar kullanılmamalı, kaşıntının nedeni öğrenilmelidir. Mantar da kaşıntı yapar ama kortizonlu kremi mantara sürülürse kaşıntıyı alsa da mantarın artmasına sebep olur.\n\n" +
            "- Kaşınan bölgeye soğuk uygulanması histamin etkisini azaltacağı için kaşıntının azaltılmasında yararlı olabilir.\n\n";
           
        }
        if (urun == "Katarakt")
        {
            urunResmi.sprite = burakResimler[34];
            baslik.text = " Katarakt ";

            konu.text = "- Katarakt sıkça yaşa göre sınıflandırılan bir hastalıktır. Doğuştan gelen katarakta konjenital katarakt, Yaş ile birlikte ortaya çıkan tipe ise senil katarakt denir. Gözün içinde yer alan, sinir ve damar içermeyen mercek üzerinde bulanık kısımların oluşması, saydamlığını kaybetmesi, kahverengi ve sarı renklenmelerin oluşmasıyla ortaya çıkan, görme duyusunun azalması ile sonuçlanan hastalıktır. Katarakt gözlerin her ikisinde ya da sadece birinde görünebilse de çoğunlukla bir göz diğerine göre daha fazla etkilenir. Normal koşullarda saydam olan mercek, ışığı gözün arkasına ileterek net bir şekilde görme duyusunun çalışmasını sağlar. Ancak merceğin bir kısmının bulanıklaşması durumunda ışık yeteri kadar içeri giremez ve görüş etkilenir. Tedavi edilmeyen durumlarda bulanık alanlar genişler ve sayı olarak artar. Bulanıklık arttıkça görüş daha fazla etkilenir ve kişiyi günlük işlerini yapamaz hâle getirir.\n\n";
             


        }
        if (urun == "Katran")
        {
            urunResmi.sprite = burakResimler[35];
            baslik.text = " Katran ";

            konu.text = "- Bazı maddeler karbon bakımından zengindir. Özel koşullarda damıtılma işlemleriyle elde edilen bir maddedir. Katran herkesin merak ettiği bir maddedir. Ne işe yaradığı konusunda herkes birçok araştırma yapıyor. Zift, katran üretimi sonucu ortaya çıkan bir artık maddesidir. Katran birçok alanda kullanılan bir üründür. Özellikle egzama hastalığına oldukça fayda sağlar. Düzenli kullanılmasıyla birlikte pek çok hastalığa şifa olur. Cilt ve saç sorunları yaşayan kişilere genellikle katran kullanılması önerilir.\n\n" +
             "- Katranın bu hastalıklar için sabunu bulunuyor. Özel katran sabunuyla tüm bu hastalıklar ortadan kaldırılabiliyor. Çok faydalı olan bu ürün, doktorlar tarafından bazı hastalıkların tedavisinde önerilebiliyor. Katran sabunu adını renginden almıştır. İçerisinde kimyasal bulunmayan doğal bir temizleyicidir. Özellikle cilt ve saç sağlığında uzun yıllardır kullanılan bir sabundur. Çok uygun fiyatta olan bu sabun, doktorlar tarafından tavsiye ediliyor. Katran sabunu duş alırken vücuda yavaş yavaş masaj yaparak uygulanmalıdır.\n\n";

        }
        if (urun == "Kayısı")
        {
            urunResmi.sprite = burakResimler[36];
            baslik.text = " Kayısı ";

            konu.text = "- Kayısı yüksek potasyum içeriği sayesinde kalp koruyucu etkiye sahiptir. Kalp atış hızının düzenlenmesine yardımcı olur. İçeriğindeki potasyum kalp kaslarını besler.\n\n" +
            "- Tansiyonu dengeler ve kan basıncının normal düzeylerde seyretmesini sağlar.\n\n" +
            "- İçerdiği kalsiyum, fosfor gibi mineraller kemik sağlığı açısından önemlidir.\n\n" +
            "- Ağız ve diş sağlığı için yararlı bir meyvedir. Bağışıklık sistemini güçlendirir, diş eti sorunlarının oluşmasını engeller ve ağız içi yaraların iyileşmesine yardımcı olur.\n\n" +
            "- Bol miktarda demir içeren kayısı, kansızlığa karşı koruyucu etkiye sahiptir.\n\n" +
            "- Hamileler, büyüme ve gelişme çağındaki çocuklar için yararlı bir meyve olan kayısının taze olanında C vitamini bulunmaktadır.\n\n" +
            "- Antioksidan özellikteki beta-karotenin yaşlanmayı geciktirme etkisi vardır. Kayısı cildi nemlendirir, korur ve pürüzsüzleştirir. A vitamininin deride yağ bezlerinin aktivitesini baskıladığı kanıtlanmıştır. İçerdiği A vitamini akne gibi cilt bozuklukları oluşumunu önler.\n\n";


        }
        if (urun == "Kaymak")
        {
            urunResmi.sprite = burakResimler[37];
            baslik.text = " Kaymak ";

            konu.text = "\n- Vücudunuzda şişen bir yer varsa krem gibi sürdüğünde şişkinliği önler.\n\n" +
            "- Kaymak vücudu güçlendirir bu etkiyi yükseltmek için bal ile tüketebilirsin.\n\n" +
            "- Diş çıkaran çocukların dişine sürüldüğünde diş çıkarmasına yardımcı olur.\n\n" +
            "- Kaymak da yoğurt gibi bakterilere karşı savaşır.\n\n" +
            "- Süt kaymağına biraz çam balı veya kekik ekleyip tüketirsen balgam söktürücü etkisi vardır.\n\n" +
            "- Mide ve sindirim sistemini düzenler.\n\n" +
            "- Bal ve kaymağı beraber tüketirsen birçok hastalıktan korunmuş olursun.\n\n" +
            "- Yine bal kaymak karışımı basit yaralara sürüp iyileşmesini hızlandırabilirsin.\n\n";
        }
        if (urun == "Keçiboynuzu")
        {
            urunResmi.sprite = burakResimler[38];
            baslik.text = " Keçiboynuzu ";

            konu.text = "\n- Keçiboynuzu potasyum, kalsiyum, sodyum, magnezyum ve demir mineralleriyle zengin bir besin kaynağıdır. Antioksidan özelliğiyle doğal bir antibiyotik özelliği de vardır. Kalp ve damar sağlığına faydalıdır. Kanı temizleme ve damar tıkanıklıklarını giderme özelliği vardır.\n\n" +
            "- Kış aylarında artan astım atakları ve bronşit hastalıklarına iyi gelen keçiboynuzu şiddetli öksürüklere karşı dahi çok etkilidir. Balgam söktürücüdür, bu sayede öksürüğü azaltır.\n\n" +
            "- Bağırsak ve sindirim sistemine de olumlu etkiler sağlar, kabızlığı önler. Bağırsak kurdu, bağırsak paraziti gibi rahatsızlıkların tedavisinde etkili olur.\n\n" +
            "- İçerdiği lifler dolayısı ile genel anlamda sindirim sistemini koruyucu özelliği vardır ve zengin lif içeriği ile kilo vermeye yardımcı olduğu bilinmektedir.\n\n" +
            "- Cinsel yaşama enerji katar. Keçiboynuzu tam bir enerji kaynağı niteliğindedir. Cinsel gücü arttırarak erkeklerde sperm miktarını çoğalttığı gözlemlenmiştir.\n\n" +
            "- İç organları temizler, vücuttan ağır metallerin ve radyasyonun atılmasını sağlar. Karaciğer, akciğer ve bağırsakları temizler.\n\n" +
            "- Sigaranın zararlarını azaltır, akciğeri temizleyerek akciğer kanserine yakalanma riskini azaltır.\n\n" +
            "- Keçiboynuzu, diyabetle savaşır. Kan şekerini düzenleyerek kötü kolesterolü azaltmaktadır ve bu bakımdan da şeker hastalığına karşı önemli bir antioksidan görevi görmektedir. Bunun yanı sıra keçiboynuzu, şeker hastalığının sebep olduğu halsizlik ve sürekli uyku halinin de önüne geçmek için faydalıdır.\n\n";
        }
        if (urun == "Kekemelik")
        {
            urunResmi.sprite = burakResimler[39];
            baslik.text = " Kekemelik ";

            konu.text = "\n- Kekemelik; kelimeler, sesler ya da hecelerin tekrarlanması, konuşma sırasında duraklama veya dengesiz konuşma hızı ile karakterize bir konuşma bozukluğudur. \n\n" +
             "-  En sık olarak 2 ila 6 yaş arasında meydana gelen kekemelik tüm çocukların yaklaşık %5 ila 10'unu etkiler.\n\n" +
             "- Kekemelik görülen çocukların %25’inden fazlasında bu durum yetişkinliğe kadar devam etmez.\n\n" +
             "- Genellikle, çocuğun gelişimi ilerledikçe tamamen kaybolur. Kalıcı olabilecek durumlarda erken müdahale ile yetişkinlikte problemin devam etmesi önlenebilir.\n\n\n" +
             " Belirtiler şöyle sıralanabilir; \n\n" +
            "- Bir kelime, kelime öbeği veya cümleyi başlatmada zorluk\n\n" +
            "- Bir sözcüğü veya sözcük içindeki sesleri uzatma\n\n" +
            "- Ses, hece veya kelimeyi tekrar etme\n\n" +
            "- Bir sonraki kelimeye geçmede zorluk yaşanması\n\n" +
            "- Bazı kelimeleri söylerken yüzün veya üst gövdenin aşırı derecede gerilmesi vb. \n\n";

        }
        if (urun == "Kekik")
        {
            urunResmi.sprite = burakResimler[40];
            baslik.text = " Kekik ";

            konu.text = "- Kalp sağlığını korur.\n\n" +
             "- Kansere karşı koruyucudur.\n\n" +
             "- Bağışıklık sistemini güçlendirir.\n\n" +
             "- Sindirim sistemi sorunlarını giderir.\n\n" +
             "- Göz sağlığına iyi gelir.\n\n" +
            "- Solunum yolu rahatsızlıklarını tedavi eder.\n\n" +
            "- Ciltte ağrıyan bölgeye uygulanan kekik yağı, ağrı ve acıyı hafifletir.\n\n" +
            "- Daha sağlıklı bir uyku çekmenize olanak tanır.\n\n" +
            "- Alzhemeir ve Parkinson gibi rahatsızlıklara karşı beyni korur.\n\n" +
            "- Omega 3 yağ asidi seviyesini yükselterek, beyin sağlığına katkı yapar\n\n";
            
        }
        if(urun == "Kellik")
        {
            urunResmi.sprite = burakResimler[41];
            baslik.text = " Kellik ";

            konu.text = "- Saç dökülmesinin birden fazla sebebi olabilir \n\n" +
             "- Demir eksikliği ve anemi saç dökülmelerinin en büyük sebeplerinden biri. Demir içeren besinlerin daha sık tüketilmesiyle bu sorunun önüne geçilebiliyor.\n\n" +
             "- Stres diğer bir sebep. Uzun süre stres altında kaldıysanız, bir travma geçirdiyseniz 3-6 ay gibi bir süre sonra saçlarınızın hızla döküldüğünü fark edebilirsiniz.\n\n" +
             "- Genetik faktörler de etkili. İster erkek ister kadın olun ailenizde saç dökülmesine bir yatkınlık varsa sizde de görülme olasılığı oldukça yüksek.\n\n" +
             "- Protein eksikliği sebebiyle de saçlarınız dökülüyor olabilir. Yeteri kadar protein almadığınızda vücut bu eksikliği gidermek için saçın büyümesini durdurabilir.\n\n" +
            "- Tiroid bezi yeterince çalışmıyor ve yeterince hormon pompalamıyorsa bu da saç dökülmesi gibi sorunlara yol açabilir.\n\n" +
            "- B vitamini eksikliği ya da aşırı A vitamini alımı da saç dökülmesini tetikleyebilir.\n\n\n" +
            " Gelin, saç dökülmesine iyi gelen besinleri yakından tanıyalım\n\n" +
            "- Ispanak, pazı, roka gibi yeşil yapraklı sebzeler\n\n" +
            "- Portakal, greyfurt, karpuz, çilek gibi C vitamini içeren meyveler\n\n" +
            "- Ceviz, fındık gibi kuru yemişler\n\n" +
            "- Balık başta olmak üzere deniz ürünleri\n\n" +
            "- Tavuk, hindi gibi protein kaynakları\n\n" +
            "- Fasulye, havuç, sarımsak, soğan vb\n\n";    
        }
        if (urun == "Kemik")
        {
            urunResmi.sprite = burakResimler[42];
            baslik.text = " Kemik ";

            konu.text = "- Kemikler için yararlı vitamin ve mineraller dengeli bir şekilde alınmalı!\n\n" +
             "- Kalsiyum: Kemikler için lokomotiftir. Kalsiyum içeren besinler; süt ve süt ürünleri, soya fasulyesi, fıstık, ceviz, badem, lahana, brokoli, koyu yeşil yapraklı sebzeler, balık, kurutulmuş meyveler, kuru baklagillerdir.\n\n" +
             "- A vitamini: Kemik gelişimine ve büyümesine katkısı oldukça fazladır. A vitamini yönünden zengin besinler; turuncu renkli besinler, süt, yumurta, balık, karaciğer, brokoli, kivi, erik ve incirdir.\n\n" +
             "- Magnezyum: Kemik gelişimine katkı sağlar. Kuru baklagiller, yağlı tohumlar, rafine edilmemiş tahıl taneleri ve koyu yeşil yapraklı sebzeler önemli magnezyum kaynağıdır.\n\n" +
             "- Çinko: Sağlıklı kemik gelişimi için gereklidir. Çinko içeren besinler deniz ürünleri, kırmızı et, mantar, ceviz, badem, fındık, fasulye, bulgur ve bezelye olarak sıralanabilir.\n\n" +
            "- Potasyum: Kemikler için gereklidir. Günlük tüketilmesi gereken potasyum miktarı 3,5 gramdır. Potasyumdan zengin besinler; koyu yeşil yapraklı sebzeler, kabuklu patates, kuru kayısı, sakız ve somon balığı, yoğurt, avakado.\n\n" +
            "- D vitamini: Kemik sağlığı için önemlidir; balık yağı, süt ve süt ürünleri, morina balığı yağı, sardalya, uskumru, somon, ton balığı, yumurta sarısı, tereyağı, yulaf ezmesi gibi besinlerde D vitamini bakımından zengindir.\n\n" +
            "- K vitamini: Kemik dostudur; yeşil yapraklı sebzeler, ıspanak, bürüksel lahanası, maydanoz, şalgam, pancar yaprağı, bamya, marul, brokoli, kuşkonmaz, tahıllar, tereyağı, peynir, yumurta, karaciğer, soya fasulyesi, yeşilçay, kivi, yaban mersini, kuru erik, havuç K vitamini içeren besinler arasındadır.\n\n";

        }
        if (urun == "Kepek")
        {
            urunResmi.sprite = burakResimler[43];
            baslik.text = " Kepek ";

            konu.text = "\n- Kepek, basit bir saç problemi gibi görünse de kişinin öz güvenini etkileyen bir sorundur. Temizlikle ilgili olmasa bile, kişinin saçlarının kirli ya da bakımsız görünmesine sebep olur. Ayrıca kaşıntılı kepekler de, kişilere rahatsızlık verir. Bir çalışmada, kepeğin tıbbi bir soruna neden olmasa da, psikolojik sorunlara yol açabileceği söylenmektedir.\n\n" +
             "- Kepek için temel tedavi kepek önleyici şampuanlardır. Süpermarketlerden veya  eczanelerin dermokozmetik bölümlerinden satın alınabilen, çeşitli maddeler içeren kepek şampuanları vardır.\n\n\n" +
             " Aşağıdaki malzemelerden birini içeren şampuanlar genellikle kepeğe iyi gelmektedir.\n\n" +
             "- Çinko pirit\n\n" +
             "- Salisilik asit\n\n" +
            "- Selenyum sülfit\n\n" +
            "- Ketokonazol\n\n\n" +
            "- Kepek şampuanlarını kullanmadan önce, kullanma talimatları dikkatlice okunmalıdır ve ne sıklıkla uygulanacağı öğrenilmelidir. Şampuanı durulamadan önce en az beş dakika saçta bırakmak, maddelerin etkisini daha yoğun göstermesi açısından yararlı olacaktır. Şampuanlarda tedavide kepeğin iyileşip iyileşmediğini görmek için bir ay boyunca denemek gerekir. Bazı durumlarda semptomlar düzeldiğinde şampuan daha az sıklıkla kullanılabilir ama tamamen kullanım kesildiğinde kepek geri dönebilir.\n\n";

        }
        if (urun == "Kereviz")
        {
            urunResmi.sprite = burakResimler[44];
            baslik.text = " Kereviz ";

            konu.text = "\n- Kereviz, maydanozgiller familyasına ait, vitamin ve mineral açısından oldukça zengin bir sebzedir. Eski Mısır, antik Yunan ve geleneksel Çin tıbbında da hastalıklara karşı kullanılmış faydalı bir besindir. Kereviz, A,C,D,E,K, folat (folik asit), piridoksin (B6), potasyum ve pantotenik asit (B5) gibi B grubu vitaminlerini içermektedir.  Kereviz ayrıca potasyum, sodyum, kalsiyum, fosfor ve magnezyum gibi mineraller bakımından da zengin bir besindir.  Kerevizin tohumları baharat olarak da kullanılmaktadır\n\n" +
             "- Kerevizin su oranı yüksektir ve neredeyse hiç yağ içermez. Az karbonhidrat ve nispeten yüksek miktarda lif bulundurmaktadır. Alkali bir sebze olan kereviz vücudun pH oranını korumasına da yardımcı olmaktadır.\n\n" +
             "- Kerevizin aktif bileşenleri arasında karakteristik kokusunu belirleyen uçucu yağlar, flavonoidler ve alkaloidler gibi antioksidanlar da bulunur. İçerdiği antioksidanların etkinliği 5 ile 7 gün sonra azaldığından, kereviz her zaman taze olarak tüketilmelidir.\n\n" +
             "- Kereviz kalp ve damar sağlığına katkı sağlamaktadır. Kereviz antioksidan ve antiinflamatuar özellikleriyle damarlar üzerinde koruyucu etkiye sahiptir.\n\n" +
             "- Kereviz bağışıklık sistemini güçlendirir ve iltihabı önler. Kereviz zengin bir antioksidan kaynağıdır. Antioksidan vitaminlere (örneğin C vitamini ve beta-karoten) ek olarak kereviz, önemli miktarda polifenol de içermektedir.\n\n" +
             "- Gut hastalığı ve romatizmaya iyi gelir. Özellikle dikkat çekici olan, kerevizin en önemli tıbbi etkilerinden biri olan idrar söktürücü etkisinden sorumlu olan yüksek potasyum içeriğidir.\n\n";
             

        }
        //05.04.2022
        if (urun == "Saç Kıran")
        {
            urunResmi.sprite = burakResimler[45];
            baslik.text = " Saç Kıran ";

            konu.text = "- Saçkıran hastalığının nedeni kesin olarak bilinmemektedir. Fakat otoimmün nedenlerden kaynaklandığı düşünülmektedir. Otoimmün hastalıklar, vücudun kendi hücre ve dokularını yabancı olarak tanıması ile ortaya çıkar. Sonuç olarak da bağışıklık sistemi kişinin kendi hücrelerine saldırır. Saçkıranda da bağışıklık hücreleri saç köklerine saldırarak saçın uzamasını durdurur ve saç dökülmesine yol açar.\n\n" +
             "- Yapılan araştırmalara göre saçkıranın genetik faktörlerle de ilişkili olduğu görülmektedir. Saçkıran olan bir ebeveynin çocuğunda bu rahatsızlığın görülme riski normal popülasyondan yaklaşık 3 ila 6 kat daha fazladır. Yine bazı hastalıklar saçkıran ile birlikte görülebilmektedir ve bu da genetik faktörlerin etkisini desteklemektedir.\n\n Bu hastalıklardan bazıları şunlardır:\n\n" +
             "- Egzama\n\n" +
             "- Addison hastalığı\n\n" +
             "- Sedef hastalığı\n\n" +
            "- Saman nezlesi\n\n" +
            "- Atopik alerjik astım\n\n" +
            "- Vitiligo\n\n" +
            "- Lupus\n\n";

        }
        if (urun == "Kına")
        {
            urunResmi.sprite = burakResimler[46];
            baslik.text = " Kına ";

            konu.text = "\n- Asrı Saadet zamanında kadınların saç, erkeklerinde saç-sakal boyası olarak kullandıkları maddenin çoğu zaman kına olduğu öne sürülmektedir. 'Ketem' olarak geçen bitkinin kökü kına ile harmanlanır kızıl ya da sarımsı renkli boya ortaya çıkar. Turuncumsu bir renk elde edilmesi için çivit otundan yapılan oluşan toz ile karışır.\n\n" +
             "- Eski zamanlarda süs amacıyla yaptırılan kına kurutucu ve yapışkanlık sağladığı için Peygamber Efendimiz (SAV) zamanında tıbbî olarak uygulanmış ve önerilmiştir. Efendimiz (SAV) başı ağrıdığı zaman mübarek başını kınaya boyatırmış ve kınanın baş ağrısı için olumlu etkisinin olduğunu şu hadis-i şerifinde buyurmaktadır: \n\n" +
             "- “Kına, Allah’ın izni ile baş ağrısına faydalıdır.” [İbni Mace, Tıb, No: 3502] Tirmizi’nin naklettiği bir hadiste: “Her ne zaman Peygamberimiz (Sallallâhu Aleyhi ve Sellem) yaralanır veya vücuduna diken batsa, yaranın üzerine veya dikenin battığı yere, mutlaka kına koyarlardı.” [Tirmizi, Tıb, No: 2054] Sahih hadis kaynaklarında geçen rivayetlere göre baş ağrısı çekenler için aynı zamanda hacamatın, ayak hastalıkları için de kına yakmanın iyi geldiği bilinmektedir.\n\n";
             

        }
        if (urun == "Kına Çiçeği")
        {
            urunResmi.sprite = burakResimler[47];
            baslik.text = " Kına Çiçeği ";

            konu.text = "\n- Kına çiçeği süs olarak kullanılan bitkilerden biridir. Susuzluğa dayanıklı bir bitki olması sebebiyle yorucu bakıma ihtiyaç duymaz. Farklı renklerde bulunabilen kına çiçeği, sağlam bir gövdeye sahiptir. Uzunluğu bir metreye kadar uzayabilmektedir.\n\n" +
             "- Kına çiçeği halk arasında cam güzeli çiçeği olarak da adlandırılabilmektedir. Bir dalında bulunan çiçek sayısı fazla olduğu için bulunduğu ortamlara renk katar. Çiçeklerinin boyu 5-6 santimetre aralığında değişiklik gösterir.\n\n" +
             "- Kına çiçeğinin birbirinden önemli faydaları bulunur. Kurutulmuş, kaynatılmış ve yağı çıkarılmış şekilde kullanılabilmektedir. Uzun zamanlardan beridir hastalık tedavilerinde kullanıldığı için tıpta yeri bulunur. Kurumuş kına çiçekleri kas kasılmalarının geçmesi amacıyla kullanılabilir.\n\n" +
             "- Kına çiçeğinden yapılan yağlar sara hastalığına iyi gelir. Vücutta oluşan deri sarkmalarının toparlanmasına yardımcı olur. Ancak aşırı kullanılması durumunda kabızlık gibi boşaltım problemleri oluşabilir. Ayrıca giyeceklerde oluşabilecek güvelerin önlenmesi amacıyla kullanılabilir.\n\n";
            
        }
        if (urun == "Kırık")
        {
            urunResmi.sprite = burakResimler[48];
            baslik.text = " Kırık ";

            konu.text = "- Kırık, kemik bütünlüğünün bozulmasıdır. Kırıklar darbe sonucu ya da kendiliğinden oluşabilir. Yaşlılık ile birlikte kendiliğinden kırık oluşma riski de artar.\n\n" +
             "- Kapalı kırık: Kemik bütünlüğü bozulmuştur. Ancak deri sağlamdır.\n\n" +
             "- Açık kırık: Deri bütünlüğü bozulmuştur. Kırık uçları dışarı çıkabilir. Beraberinde kanama ve enfeksiyon tehlikesi taşırlar.\n\n\n" +
             " Kırık belirtileri neler olabilir?\n\n" +
             "- Hareket ile artan ağrı\n\n" +
             "- Şekil bozukluğu\n\n" +
             "- Hareket kaybı\n\n" +
             "- Ödem ve kanama nedeniyle morarma\n\n\n" +
             " Kırıklarda ilkyardım nasıl olmalıdır?\n\n" +
             "- Hayatı tehdit eden yaralanmalara öncelik verilir,\n\n" +
             "- Hasta/yaralı hareket ettirilmez, sıcak tutulur,\n\n" +
             "- Kol etkilenmişse yüzük ve saat gibi eşyalar çıkarılır,\n\n" +
             "- Kırık şüphesi olan bölge, ani hareketlerden kaçınılarak bir alt ve bir üst eklemleri de içine alacak şekilde tespit edilir, \n\n" +
             "- Tıbbi yardım istenir. \n\n";

        }
        if (urun == "Kısırlık")
        {
            urunResmi.sprite = burakResimler[49];
            baslik.text = " Kısırlık ";

            konu.text = "\n- Dünya Sağlık Örgütü tarafından Cinsel yönden aktif olan ve herhangi bir doğum kontrol yöntemi uygulamayan bir çiftin, bir yıl süre içerisinde gebelik elde edememesi durumu olarak adlandırılan kısırlık, dünya genelinde çiftlerin yaklaşık olarak %25'ini etkileyen klinik bir sağlık problemidir.\n\n" +
             "- Yapılan araştırmalar kısırlık probleminden 1/3 oranda erkeklerin, 1/3 oranda kadınların  ve 1/3 oranda her iki partnerin sorumlu olduğunu ortaya koyar.\n\n" +
             "- Gebe kalamama şikayeti ile başvuran çiftlerde, infertilite probleminin ortaya çıkış nedenleri fazlasıyla değişiklik gösterir. Başvuru sonrasında her iki partnere yapılacak olan detaylı muayene ile problemin asıl kaynağı saptanabilir. Yapılan muayene kısırlık probleminin hangi partnerden kaynaklandığını, uygulanacak tedavi yöntemlerini ve tedavinin başarılı olma yüzdesini belirleme açısından son derece önemlidir.\n\n" +
             "- Kısırlık şüphesi bulunan bir erkeğe yapılacak olan ilk tetkik genellikle spermiogram olarak adlandırılan sperm sayım testidir. Bu tetkik, 3 gün boyunca ilişki ve mastürbasyon gibi herhangi bir cinsel faaliyette bulunmamış erkekten alınan meni örneğinin incelenmesi ile gerçekleştirilir. Alınan örnekteki sperm sayısı, hareketliliği ve şekli detaylı şekilde değerlendirilerek Dünya Sağlık Örgütü tarafından belirlenen kriterler ile karşılaştırılır.\n\n" +
             "- Alınan meni örneğinde veya kanda spermlere karşı antikor varlığını tespit etmek için Antisperm Antikor Testi yapılır.\n\n" +
             "- Kadınlarda görülen kısırlık probleminin en yaygın nedeni yumurtlama bozuklukları olduğundan dolayı ilk olarak normal yumurtlama işleminin gerçekleşip gerçekleşmediği kontrol edilir. Yumurtalıkların yokluğu, yumurtlama için gereken ve beyinden salgılanan hormonların düzensizliği veya çeşitli yumurtalık hastalıkları, kadınlardaki kısırlık nedenlerinin yaklaşık %25'ini oluşturur.\n\n" +
             "- Kadınlarda regl döngüsünün ilk günü yapılan hormon düzeyi kontrolü, regl başlamadan birkaç gün önce rahmin iç yüzeyinden alınan endometriyal biyopsi örneği ve ultrasonografi ile yumurtalık gelişimi incelenerek sağlıklı yumurtlama işlemi hakkında bilgi sahibi olunur.\n\n" +
             "- Kısırlık nedenleri içerisinde bir diğer yaygın görülen neden ise tüplerdeki tıkanıklık problemidir. Tüplerin kısmi ya da tamamen tıkanması durumu, yumurtanın rahime ulaşmasını engelleyerek kısırlığa yol açar. Kısırlık şüphesi olan kadınlarda bu durumu saptayabilmek için rahim içerisinden tüplere özel ilaçlar gönderilir ve sonrasında çekilen röntgen sayesinde tüplerde herhangi bir tıkanıklık problemi olup olmadığı değerlendirilir. Bu yönteme ek olarak laparoskopi adı verilen karın içerisini kamera ile görüntülemeyi sağlayan kapalı cerrahi işlemle de fallop tüpleri detaylı şekilde görüntülenebilir.\n\n" +
             "- Kadınlardaki kısırlık probleminin yaklaşık %5'i rahimde meydana gelen yapısal bozukluklardan, yapışıklıklardan, miyomlardan veya poliplerden kaynaklanır. Embriyonun rahimde tutunmasını engelleyerek düşüğe ya da kısırlığa yol açan miyomlar, jinekolojik muayene ve ultrasonogrofi yöntemleri ile kolayca tanımlanabilir.\n\n" +
             "- Rahimde henüz anne karnındayken meydana gelen rahim perdesi, çift rahim varlığı gibi yapısal problemlerin de kısırlığa yol açtığı bilinir ve Histerosalpingografi adlı bir görüntüleme yöntemi ile teşhis edilebilir. Histerospkop adı verilen fiber optik ışıklı görüntüleme cihazı, rahim içerisine girerek yapısal bozukluklarla birlikte polipleri ve miyomları da kolayca teşhis etme imkanı verir.\n";



        }
        if (urun == "Kızamık")
        {
            urunResmi.sprite = burakResimler[50];
            baslik.text = " Kızamık ";

            konu.text = "\n- Kızamık özellikle çocukluk çağında çok sık görülen bulaşıcı bir enfeksiyon hastalığıdır. Vücut direncini düşürdüğü için çocuk zatürre, orta kulak iltihabı, menenjite kadar ilerleyebilir.\n\n" +
             "- Bu nedenle tüm dünyada yaygın olan ve ciddi riskleri olan bu hastalığa karşı, aşılama yapılması hayati önemdedir. Aşının yaygın olarak kullanılmasından sonra, hastalığın görülme sıklığında %95'lik bir azalma olmuştur.\n\n" +
             "- Suçiçeği, kızamık, kızamıkçık, 6. ve 5. hastalık gibi hastalıklar döküntülü hastalıklar grubundadır. Bunların hepsi viral enfeksiyonlar yani virüsler yoluyla bulaşır, yüksek ateş ve öksürük gibi belirtiler gösterir.\n\n" +
             "- Vücut direncini zorlayan bu hastalıklar çocuğunuzu güçsüz düşürebilir. Kızamığa yönelik bir tedavi bulunmazken, uygun bir bakımla hastalık bir süre sonra kendiliğinden geçer.\n\n" +
             "- Bulaşıcı olan bu hastalıklarda döküntüler olduğu sürece bulaşma riski vardır. Bu nedenle bebeklik ve çocukluk döneminde aşıların aksatılmaması, bulaşma ihtimaline ve enfeksiyonlara karşı hijyene dikkat edilmesi büyük önem taşır.\n\n" +
             "- Bulaşıcı salgın bir hastalık olan kızamık, direkt temasla ya da solunum yoluyla hızla bulaşabilir. Bu virüsler oda havasında bir saatten fazla kalabilir ve bu havanın solunmasıyla da bulaşabilir.\n\n" +
             "- Hastalar döküntü başlamadan önceki 4 gün ve başladıktan sonraki 4 gün hastalığı çevredekilere bulaştırabilir. Bulaştırıcılığın en yoğun olduğu süreç ateş, öksürük gibi ilk belirtilerin ortaya çıktığı dönemdir.\n\n\n" +
             "- Kızamık, önce nezle veya grip gibi başlar. Ardından çocukta şu belirtiler görülür:\n\n" +
             "- Ateş\n\n- Kesik kesik ve ısrarcı öksürük\n\n- Burun akıntısı\n\n- Gözlerde kızarıklık\n\n- Işığa bakamama\n\n- Akıntılı olmayan konjonktivit\n\n\n" +
             "- Döküntü oluşmadan 2 gün önce yanak içinde, alt azı dişler hizasında etrafı pembe-kırmızı bir halka ile çevrili, mavi-beyaz renkli 1 mm’lik lekeler oluşur. Bu lekeler bazen ağzın başka yerlerine de yayılabilir.\n\n" +
             "- Kızamığın belirtilerinden 2-3 gün sonra yüz ve saç çizgisinde döküntüler oluşur. 3 gün içinde kol-bacaklara ve gövdeye yayılır. Yüz ve boyundaki döküntüler birleşebilir.\n\n" +
             "- Kızamık olan kişiyle temastan 8-12 gün sonra kızamık belirtileri görülür. Döküntüler ise 14 gün sonra ortaya çıkar.  Kızamığı bir kez geçirmek hastalığa yaşam boyu bağışıklık sağlar.\n\n";

        }
        if (urun == "Kimyon")
        {
            urunResmi.sprite = burakResimler[51];
            baslik.text = " Kimyon ";

            konu.text = "- Kimyon, maydanozgiller familyasına ait bir şifalı bitkidir. Başta Meksika, Hint, Afrika ve Asya olmak üzere dünyanın pek çok yerinde karabiberden sonra en yaygın kullanılan baharattır. Kurutulmuş tohumlar veya öğütülmüş toz şeklinde satılır. Köri tozu gibi birçok baharat karışımında da kullanılır. Ayrıca yemeklere lezzet katmasının yanı sıra, yıllardır dünyanın birçok yerinde şifa amaçlı da kullanılmaktadır. Bazı Güneydoğu Asya ülkelerinde sindirim, öksürük, ağrı ve karaciğer hastalıklarında kullanılır.\n\n" +
             "- Kimyonda yer alan magnezyum, sodyum ve uçucu yağlar; sindirimi hızlandırır. Bir miktar sıcak suya eklenerek, tüketildiğinde mide ağrılarına iyi gelir. Kimyon, şişkinlik başta olmak üzere çoğu gastrointestinal bozuklukları tedavi edicidir. İrritabl bağırsak sendromu semptomlarını hafifletir. Etkili bir gaz giderici olarak, gaz problemlerinizi hafifletir.\n\n" +
             "- Kimyon kabızlığa iyi gelir. Kabızlık sorunu olanlar düzenli kimyon tüketerek sorunlarını hafifletebilirler. Kimyondaki timol isimli madde, bağırsaklardaki besinlerin sindirimden sorumlu emzimleri salgılayan salgı bezlerini uyarır. Kimyonun aroması, ağızdaki tükürük bezlerini harekete geçirir, gıdaların sindirimini kolaylaştırır.\n\n" +
             "- Demir deposu olarak bilinen kimyon, çocuklarda büyümeyi destekler. Genç kadınların adet döneminde kaybettikleri kanın yenilenmesini sağlar. Çocuklar tarafından tüketildiğinde çocukların sağlıklı kas ve kemik gelişimine katkıda bulunur. Demir eksikliği ile karşılaşmamak için yemeklerinize bir miktar kimyon baharatı ilave edebilirsiniz.\n\n" +
             "- Kandaki yüksek şeker miktarını azaltan kimyon, diyabet tedavisinde etkilidir. Kanda üretilen şeker, normal işlevini kaybettiğinde proteine bağlanırken AGE’ler oluşur. AGE’ler, böbrek, sinir ve küçük kan damarlarına zarar verirler. Kimyonda AGE’leri azaltan önemli bileşenler bulunur. Kimyon takviyeleri ile kan şekeri kontrol altında tutulabilir.\n\n" +
             "- Anti-kanserojen ve antioksidan olarak, kolon ve meme kanseri başta olmak üzere çoğu kanser türüne karşı koruyucu özelliği vardır. Tümör oluşumunu durdurarak, tümörün daha geniş alanlara yayılımını engeller. Kimyonda bulunan fenoller, flavonoidler, alkaloidler ve antioksidanlar, vücudumuza zarar veren serbest radikallerle savaşır. Serbest radikallerin inflamasyona yol açmasının ve DNA’ya zarar vermesinin önüne geçer.\n\n" +
             "- Kötü LDL kolesterol seviyelerini düşüren kimyon, sağlıksız kan trigliseritlerini azaltır. Yapılan bilimsel bir çalışmada kimyon takviyeleri kullanan hastaların kan kolesterolünde düzelmeler elde edilmiştir. Ancak, diyette baharat olarak kullanılan kimyonun aynı etkiye sahip olup olmadığı henüz bilinmemektedir.\n\n" +
             "- Tıpkı bir balgam söktürücü gibi davranan kimyon, balgamın hapşırma, öksürme ve tükürme yollarıyla dışarı atılmasını sağlar. Astım ve bronşit gibi solunum yolu enfeksiyonlarının doğal tedavisinde kimyon çayından yararlanılabilir.\n\n" +
             "- Kötü kolesterolle savaşır ve kalp ve damar sağlığına da iyi gelir. Damar tıkanıklığı, kalp krizi ve inme riskini önemli ölçüde azaltır. \n\n" +
             "- Detoks etkisi göstererek, cildimizi toksinlerden arındırır. Sivilcelere, cilt kızarıklıklarına ve lekelere, cilt tahrişlerine ve güneş yanıklarına iyi gelir. Cildi canlandırır.\n\n" +
             "- İçeriğinde yer alan E vitamini sayesinde cildi besler ve nemlendirir. Cilde uygulanan kimyon macunu, egzama ve sedef gibi deri rahatsızlıklarını iyileştirir. Cildi mantar ve mikrobik enfeksiyonlara karşı korur.\n\n";

        }
        if (urun == "Kolera")
        {
            urunResmi.sprite = burakResimler[52];
            baslik.text = " Kolera ";

            konu.text = "- Kolera, Vibrio cholerae adlı bir bakterinin yiyecek ve içeceklere bulaşması sonucu yayılan bir hastalıktır.  Kolera, şiddetli ishale neden olan, vücutta dehidrasyona yol açan ve tedavi edilmediği takdirde ölümcül olabilen tehlikeli hastalıkların başında yer almaktadır. Kolera genellikle bakterinin bulaşmış olduğu deniz ürünleri, yiyecekler ve içme suyu ile vücuda bulaşır. \n\n" +
             "- Kolera, ülkemizde pek görülmese de diğer ülkeler için hala daha ciddi bir sorun olarak görülmektedir. 1800’lü yıllarda oldukça yaygın olan ve birçok insanın ölümüne neden olan bu hastalık, su kanallarına yapılan arıtma sistemleri sayesinde daha az görülmektedir. \n\n" +
             "- Dünya Sağlık Örgütü, her yıl 1, 3 milyon ila 4 milyon vaka olduğunu bildiriyor. Kolera hastalığının en sık görüldüğü yer savaş, kıtlık, kalabalık ve temizliğin kötü olduğu yerlerdir. Genel olarak Afrika, Güney Asya ve Latin Amerika'nın bazı eyaletlerinde görülmektedir. Eğer bu bölgelere seyahat etmek istiyorsanız mutlaka ilgili önlemleri almalısınız.\n\n" +
             "- Kolera hastalığına “Vibrio cholerae” adı verilen bakteriler neden olur. Hastalığın ölümcül olmasının nedenleri ise, bu bakteriler tarafından üretilen ve Choleragen  (CTX) olarak bilinen güçlü bir toksinin ince bağırsağa yapışmasıdır.\n\n" +
             "- Choleragen yani CTX, bağırsak duvarlarına bağlandığında sodyum ve klorüre müdahale eder. Bakteriler ince bağırsağın duvarlarına bağlandığında, vücut çok fazla miktarda su salgılamaya başlar ve bu durum da ishalle birlikte hızlı sıvı ve tuz kaybına neden olur.\n\n" +
             "- Özellikle kirli su kaynakları, kolera enfeksiyonunun en önemli nedenlerinden biridir. Bunun yanı sıra iyi yıkanmamış meyveler, pişmemiş sebzeler ve diğer yiyecekler de koleraya neden olan bakterileri içerebilir. \n\n" +
             "- Kolera insandan insana direk temas yoluyla geçmemektedir, fakat kolera enfeksiyonuna yakalanmış bir kişinin dışkısının yiyecek ya da suya teması ile insandan insana geçebilmektedir.\n\n";
             
        }
        if (urun == "Köselik")
        {
            urunResmi.sprite = burakResimler[53];
            baslik.text = " Köselik ";

            konu.text = "\n- Bir sıfat olan köselik kelime anlamı olarak sakalı bıyığı çıkmayan ya da pek seyrek olan kişi anlamına gelmektedir. Genellikle erkeksi görünüşün tam olmaması ya da ileri yaşa rağmen olduğu yaştan daha genç gözlenme sorunudur. Başta köselik problemi küçük kılsız alanların oluşmasıyla erkek bireylerde gözlemlenir. Bu kılsız alanlar ya da dökülmeler saç, göğüs, yüz (sakal) ve bacak gibi farklı bölgelerde kendini gösterebilir.\n\n" +
             "- Köselik genellikle ergenlik döneminde yüzde sakal dediğimiz kılların çıkmaması ya da seyrek şekilde olmasıyla anlaşılabilir. Bu durum erkek eşey (biyolojik cinsiyet) hormonu olan testosteronun dengesiz yayılımı ya da yetersizliği gibi hormonsal nedenlerle olabileceği gibi genetik faktörlerin de köselikte etkili bir sebep olabileceği bilinmektedir. Köselik, saç kıran gibi hastalıklardan tamamıyla farklı olduğu için bir hastalık kabul edilmez.\n\n" +
             "- Ancak köselik psikolojik açıdan erkeği rahatsız edebileceği için sosyal yaşantısını etkileyebilir. İleri yaşa rağmen olduğundan küçük görünme, erkeksi görünüşün olmaması ya da belli alanlarda kılın yokluğu veya seyrekliği gibi estetik açısından da oluşabilecek problemler erkeği rahatsız eder ve özgüven problemlerine de sebebiyet verebilir. Hekimler tarafından gerekli görülmesi durumunda genetik ya da hormonal olmak üzere köselik testi yaparak tanı konabilir.\n\n" +
             "- Köselik çoğunlukla bir hastalık olarak kabul edilmese de bazı tedavi yöntemleri mevcuttur. Erkeklerde köseliğin görülmesinin başlıca iki sebebi erkek eşey (biyolojik cinsiyet) hormonu olan testosteronun dengesiz yayılımı ya da yetersizliği gibi hormonsal nedenlerle ve ailesel sebeplerden olan genetik kaynaklı açıklanabilmektedir. Bunun dışında stres, çevresel faktörler ve farklı sağlık sorunları da köseliğe neden olabileceğinden uzman hekim öncelikle köseliğin ana sebebini belirleyerek tedaviye başlar.\n\n" +
             "- Eğer köselik hormonal sebeplerden kaynaklıysa ergenlik dönemindeki hekim hormon tedavisi takviyesiyle eğer kıl kökleri mevcutsa sakal oluşumunu sağlayabilmektedir. Ancak kişinin birinci derece yakın akrabalarında da köselik sorunu gözlemleniyorsa sorun genetiktir ve hormonlar kesilince bu sakal dediğimiz kılların yeniden dökülmesi ve seyrekleşmesi gözlenir. Yani hormonal tedavi köselik sorununu sadece öteleyecektir.\n\n" +
             "- Ayrıca verilen bu hormonların vücutta başka bölümlerde başka sorunların oluşmasına neden olması kuvvetle muhtemeldir. Bu sebeple ailesel köselik görülen kişilerde hormon takviyesi çok tercih edilmez.\n\n\n Bunun dışında diğer tedavi yöntemleri;\n\n\n" +
             " Sakal Ektirme\n\n- Erkeklerde köselik görünmesi durumunda kesin çözümlerden biri sakal ektirme yöntemidir. Yüzün belli bölgelerinde düzensiz şekilde görülen kılların estetik açıdan rahatsızlığa sebep olması ya da hiç kıl bulunmaması sonucu erkeksi görünümün sağlanamaması gibi durumlar sakal ektirme yöntemiyle kesin çözüme kavuşabilmektedir.\n\n Sakal ektirme yönteminde uygulanan işlemler sırasıyla;\n\n" +
             "- Önce ensedeki kafayı sağa sola çevirebildiğimiz dönel bölgeden saç kökleri alınmaktadır.\n\n" +
             "- Enseden alınan bu kıl kökleri yüzde kılların olmadığı bölgelere yerleştirilerek erkekte seyrekliğin giderilmesi ve böylece doğal sakal görünümü sağlanabilmektedir.\n\n" +
             "- Yapılan uygulama uzman bir hekim tarafından yapıldığında kıl köklerinin alındığı bölgede herhangi iz ya da belirti gözlenmemektedir. Ayrıca bu işlemde kılların yüzde düzensiz yerleşimi ya da belli bölgelerde sakal kaybı gibi problemlerde çözüme kavuşturulur çünkü işlem sırasında sakal sıklığının dengeli olmasına dikkat edilmektedir.\n\n\n" +
             " Sakal Serumu\n\n- Köselik için sakal serumu kullanmak herkes için kesin sonuç alınan bir tedavi yöntemi değildir. Çünkü genetik olarak sakal çıkmayan bölgelerde ya da seyrekliğin göründüğü boşluklarda sakal oluşumunu sağlayacak kıl kökü olmadığından sakal serumunun hiçbir etkisi olmayacaktır. Bu seyrek kıl bulunan ya da hiç kıl olmayan alanlarda kıl kökü varlığı mevcut erkeklerde sakal serumu yardımıyla sakalların kıl kalitesinin artması ve bakımlı hızlı uzayan sakalların görülmesi mümkündür.\n\n\n" +
             " Sakal Mezoterapisi\n\n- Yüze uygulanan ve kıl köklerini güçlendiren bir yöntem olan sakal mezoterapisi ile de köselik sorunu çözülebilir. Sakal mezoterapisi yöntemiyle cilt yenilenir, daha taze bir görünüm alır ve kıl kökleri güçlenir.\n\n";

        }
        if (urun == "Kuduz")
        {
            urunResmi.sprite = burakResimler[54];
            baslik.text = " Kuduz ";

            konu.text = "\n- Kuduz, enfekte hayvanların tükürüğünden, yani salyasından insanlara yayılan ölümcül bir virüstür. Kuduz virüsü genellikle ısırma yoluyla diğer canlılara bulaşır.\n\n" +
             "- Ülkemizde kuduza yakalanma ve bulaştırma olasılığı en yüksek türler arasında at, eşek, inek, keçi, kedi, ve köpek gibi evcil hayvanlar ile ayı, çakal, domuz, kirpi, kokarca, köstebek, kurt, tilki, sansar, yarasa gibi yabani hayvanlar bulunur. \n\n" +
             "- Kuduz hastalığı erken müdahale edilmesi zorunlu bir hastalıktır. Kuduz belirtileri ve semptomlarının görülmeye başlandığı hemen her vakada hastalık bireyin ölümüne neden olur. Bu nedenle, kuduza yakalanma riski ile karşı karşıya kalan her bireyin korunmak için kuduz aşısı yaptırması zorunludur.\n\n" +
             "- Bireyler, kuduz hastalığı riskini azaltmak için öncelikle kuduz hayvanlarla temasa giren evcil hayvanlarını aşılatmalıdır. Kedi, veya köpek gibi evcil hayvanlar kuduza karşı aşılanabilir. Veterinerler hayvanların ne sıklıkla aşılanması gerektiği konusunda yeterli bilgiyi sağlayacaktır. \n\n" +
             "- Evcil hayvanlar mümkün olduğu oranda içeride tutulmalı, ve dışarıda bulundukları süreç boyunca denetlenmelidir. Evcil hayvanlar ile vahşi hayvanlar arasında temas kurulması önlenmelidir. \n\n" +
             "- Seyahat eden bireyler kuduz aşısı olmayı düşünmelidir. Özellikle kuduz vakalarının yaygın olarak görüldüğü bir ülkeye seyahat eden bireyler, orada uzun bir süre kalacaklarsa doktorlarına kuduz aşısı yaptırmanın gerekliliğini sormalıdır. Yine tıbbi bakıma ulaşmanın zor olduğu bölgelere seyahat edecek bireyler de aynı önlemleri düşünmelidir.\n\n";
           
        }
        if (urun == "Kulak Çınlaması")
        {
            urunResmi.sprite = burakResimler[55];
            baslik.text = " Kulak Çınlaması ";

            konu.text = "\n- Kulak çınlaması (tinnitus), akustik bir uyaran olmaksızın hastanın bir ses algılaması olarak da tanımlanabilir.\n\n" +
             "- Bu ses değişik ton, özellik ve karakterde olabilir. Çoğu zaman çınlama gibi duyulan ses, bazen uğultu, çan, rüzgâr veya ıslık sesi, makine gürültüsü, hışırtı, nabız sesleri gibi tarif edilir.\n\n" +
             "- Tinnitus bir hastalıktan ziyade semptom yani belirti olarak değerlendirilir ve o şekilde ele alınır. İşitme sisteminin en sık karşılaşılan belirtisidir.\n\n" +
             "- Bu yakınmalar ruhsal sorunlara yol açacak veya hayat kalitesini ileri düzeyde bozacak kadar şiddetli olabilir bazı kişilerde ise tinnitus birkaç dakika içerisinde gelip geçici özellik gösterebilir.\n\n" +
             "- Kulak çınlamasında kişinin duyduğu sese neden olabilecek hiçbir dış ses kaynağı yoktur. Sadece kişinin kafasının içinde olan ve dışarıdan algılanamayan bir ses olması nedeniyle tinnitus bazen “hayalet ses” olarak da ifade edilir.\n\n" +
             "- Muayene ve tetkikler sonucu çınlamanın sebebi ortaya konulur ve sonrasında kişiye özel uygun bir tedavi planlaması yapılır.\n\n" +
             "- Kulak çınlamasının azaltılmasına yönelik yüksek sesli müziğe maruz kalmaktan korunma, kan basıncının kontrolü, tuzlu yiyeceklerden uzak durma, kahve, kola ve sigara tüketiminden kaçınma, egzersiz yapma gibi tavsiyeler kulak çınlamasına ne iyi gelir sorusuna verilebilecek en iyi cevaplar arasında yer alır.\n\n";

        }
        if (urun == "Kulunç Ağrısı")
        {
            urunResmi.sprite = burakResimler[56];
            baslik.text = " Kulunç Ağrısı ";

            konu.text = "\n- Özellikle boyun omuz ve sırt bölgesinde görülür. Adele gruplarının tekrarlayıcı hareketlerin sonucunda kasın tekrardan gevşeyememesi sonucu oluşur.\n\n" +
             "- Yel (rüzgara) maruz kalmak da kulunç oluşuma neden olur.\n\n" +
             "- Sporcularda görülen kaslara aşırı yüklenme sonucunda oluşabilir.\n\n" +
             "- Yanlış duruşa sahipseniz kulunç ağrısı oluşabilir. Yanlış duruş ile beraber omurgaya binen yükü arttırırız bu da adele spazmına neden olur. Doğru duruş ile kulunç ağrısının önüne geçebiliriz.\n\n" +
             "- Stresli bi yaşamımız varsa kasları gerer ve kulunca neden olur.\n\n\n" +
             " Kulunç Ağrısına Ne İyi Gelir?\n\n" +
             "- Kulunç ağrısında en basit ve etkili yöntemlerden biri sıcak su torbasıyla 15-20 dakika boyunca ağrılı bölgeye koymanızdır. Sıcak uygulama ile kan dolaşımı artar ve kasların gevşemesi sağlanmış olur.\n\n" +
             "- Esneme hareketleri de yaparak kasların gevşemesini sağlayabilirsiniz.\n\n" +
             "- Stres ve gerginlikten uzak durmak da ağrıların oluşmasını önleyebilir. \n\n" +
             "- Bir diğer etkili yöntem ise aromatik yağ masajı yapabilirsiniz. Bu zeytinyağı olabilir. Ağrılı bölgeye 10-15 dakika boyunca dairesel hareketlerle yağın cilde emilimini sağlayabilirsiniz.\n\n" +
             "- Kulunç ağrısının olduğu bölgeye kekik yağı veya nane yağı ile masaj yapmak da ağrının rahatlamasına yardımcı olacaktır. Ancak masaj yaparken çok fazla bastırmamaya özen gösterin.\n\n";

        }
        if (urun == "Kum Banyosu") 
        {
            urunResmi.sprite = burakResimler[57];
            baslik.text = " Kum Banyosu ";

            konu.text = "- Tedavi gayesiyle vücudun sıcak kum içine sokulmasına kum banyosu denir. Karnı ağrıyanlar, vücudunda ağrı-sızı bulunanlar sıcak kuma yatınca ağrılaı hafifler ve fayda görürler\n\n" ;
           
        }
        if (urun == "Kurdeşen")
        {
            urunResmi.sprite = burakResimler[58];
            baslik.text = " Kurdeşen ";

            konu.text = "\n- Kurdeşen ya da tıbbi adıyla ürtiker ciltte aniden ortaya çıkan ve ortası soluk kırmızı döküntülere sebep olan bir rahatsızlıktır. Halk arasında kurdeşen dökmek olarak tabir edilen hastalık vücutta genellikle belirli bir bölgede ortaya çıkar. Fakat bazen tüm vücudu kaplayan döküntüler de bulunabilir.\n\n" +
             "- Kurdeşen, vücut içinden ya da dışarıdan gelebilecek çeşitli uyaranlarla tetiklenmektedir. Bu uyaranların bir kısmı alerjik mekanizmalar yoluyla, bazıları iltihabi enfeksiyonlar sırasında veya sonrasında, diğerleri ise soğuk, sıcak, basınç ve efor gibi fiziksel etkiler yoluyla kurdeşeni tetikler.\n\n" +
             "- Bununla birlikte, çoğu durumda tetikleyici faktör bulunamamaktadır. Fakat tetikleyicilerden bağımsız olarak vücutta kurdeşene yol açan mekanizmalar her hastada büyük ölçüde aynıdır.\n\n" +
             "- Kurdeşen hastalığı için tetikleyici çok sayıda olası ajan vardır. Bu da sıklıkla hastadaki tetikleyici faktörün bulunmasını oldukça zahmetli hale getirmektedir.\n\n\n Ürtikere neden olabilecek tetikleyicilerden bazıları;\n\n" +
             "- Alerjenler: Özellikle fındık ve kabuklu deniz ürünleri\n\n" +
             "- Enfeksiyonlar: Virüs, bakteri ya da parazitlerin neden olduğu enfeksiyonlar.\n\n" +
             "- Çeşitli Hastalıklar: Tiroid hastalıkları, romatizmal hastalıklar\n\n" +
             "- Böcek Zehiri: Arı sokması ve bazen sivrisinek ısırması\n\n" +
             "- Fiziksel Etkenler: Soğuk, sıcak, güneş ışığı, ter, basınç gibi fiziksel faktörler\n\n" +
             "- Bazı İlaçlar: Bazı antibiyotikler, tansiyon ilaçları ya da ağrı kesici ilaçlar şekilde sıralanabilir.\n\n" +
             "- Çeşitli Hastalıklar: Tiroid hastalıkları, romatizmal hastalıklar\n\n\n" +
             "- Kurdeşen tedavisi öncelikle olası tetikleyicileri bulmak ve mümkün olduğunca bunlardan kaçınmak şeklinde ele alınır. Hastanın yediği bir besin ürtikere neden oluyorsa, bu besinin hasta tarafından tüketilmesi yasaklanır. Eğer ürtiker bir ilaç nedeniyle ortaya çıkmışsa, ilgili ilaç doktor tarafından kesilir ve uygun farklı preparatlarla değiştirilir. Arı, yaban arısı, eşek arısı gibi böcek sokması sonucu ürtiker ortaya çıkmışsa ilgili zehre yönelik spesifik immünoterapi tedavisi gerekebilir.\n\n";

        }
        if (urun == "Kuru Üzüm")
        {
            urunResmi.sprite = burakResimler[59];
            baslik.text = " Kuru Üzüm ";

            konu.text = "- Bağışıklık sistemini güçlendirir.\n\n" +
             "- Sindirim sistemini çalıştırmaya yardımcı olur.\n\n" +
             "- Kolesterol seviyesini düzenler.\n\n" +
             "- Romatizmal hastalıkları engeller.\n\n" +
             "- Yorgunluk ve depresyonun önüne geçer, enerji verir.\n\n" +
             "- Uzun süre tokluk hissi sağlar.\n\n" +
             "- Kuru üzüm kemiklerin güçlenmesini sağlar.\n\n" +
             "- Mide rahatsızlıklarına iyi gelir.\n\n" +
             "- Anemi tedavilerinde takviye olarak tavsiye edilir.\n\n" +
             "- İçeriğindeki boron minerali sayesinde kalsiyum emilimini kolaylaştırır ve kemik sağlığını güçlendirir.\n\n" +
             "- Kuru üzüm kabızlığı önler.\n\n";

        }
        if (urun == "Kuşkonmaz")
        {
            urunResmi.sprite = burakResimler[60];
            baslik.text = " Kuşkonmaz ";

            konu.text = "- Asparagus officinalis olarak da bilinen kuşkonmaz çiçekli bir bitki türüdür. Ayrıca halk arasında serçe otu olarak da bilinir.\n\n" +
             "- Çalılık ve dikenlerin arasında yetişen ve toplaması zahmetli olan kuşkonmaz, birçok derde deva olarak biliniyor.\n\n" +
             "- Tohum olarak da ekildiği gibi doğal olarak da kendiliğinden yetişen kuşkonmaz, ortalama 10-15 cm kadar uzayabilen, nisan ve mayıs aylarında toplanıp yenen bir bitki.\n\n" +
             "- Kuşkonmaz içerisinde barındırdığı zengin vitamin ve mineraller sayesinde 'bitkisel bir antibiyotik' olarak biliniyor. Bitkide A, C, K ve B vitamini, potasyum, demir, folik asit ve lif bulunuyor. Antioksidan ve lif içeriği sayesinde kolon kanserinde koruyucu etki gösteriyor.\n\n" +
             "- Kuşkonmaz, özellikle A ve C vitaminiyle selenyum ayrıca beta karoten bakımından zengin olduğu için de antioksidan özelliğe sahiptir.\n\n" +
             "- Antioksidanlar da kansere karşı koruyucudur. Kuşkonmazdaki saponinin de bir antioksidandır. Bu sayede hücrelerimizi oksidatif strese ve inflamasyona karşı korur.\n\n" +
             "- Saponinin antikarsinojen ve antiinflamatuar etki gösterir. Kuşkonmaz aynı zamanda iyi bir folik asit kaynağı olduğu için yeni hücrelerin gelişimini destekleyip kanser hücrelerinin gelişimini önleyebiliyor.\n\n" +
             "- İyi bir lif kaynağı olduğu için de bağırsakları koruyup, kolon kanserine karşı da etkili bir rol oynuyor.\n\n";

        }
        if (urun == "Kuyruk Yağı")
        {
            urunResmi.sprite = burakResimler[61];
            baslik.text = " Kuyruk Yağı ";

            konu.text = "\n- Özellikle kalp-damar hastalıklarına karşı iyi gelir.\n\n" +
             "- İçeriğinde Omega yağ asitleri bulunur ve vücut sağlığı için oldukça etkilidir.\n\n" +
             "- Kolesterolü dengeler ve daha sağlıklı hale getirir.\n\n" +
             "- Antioksidan etkisi yaratarak bağışıklık sistemini önemli oranda güçlendirir.\n\n" +
             "- Gelişim çağında olan çocuklarda kas ve kemik gelişiminin sağlıklı olmasını sağlar.\n\n" +
             "- Kan basıncının dengelenmesine yardımcı olur. Tansiyonun dengede kalmasını sağlar.\n\n" +
             "- Damar tıkanıklıklarına karşı koruma sağlar. Kalp ve damar hastalıkları riskini düşürür.\n\n" +
             "- Sinir sistemi üzerinde olumlu ve yumuşatıcı etkiler oluşturur. Böylelikle romatizma ve felç riskini minimalize eder. Ayrıca vücuttaki titreme ve yanı sıra siyatik hastalıklarından da korur.\n\n" +
             "- Bağışıklık sisteminin virüs, enfeksiyon ve serbest radikallere karşı her zaman dirençli kalmasını sağlar.\n\n" +
             "- Kuyruk yağı cilt hücrelerinin yenilenmesine ve onarılmasına yardımcı olur.\n\n";
           

        }
        if (urun == "Safra")
        {
            urunResmi.sprite = burakResimler[62];
            baslik.text = " Safra ";

            konu.text = "- Safra, yeşilimsi kahverengi bir alkali sıvıdır ve atık ürünler, kolesterol ve safra tuzlarından oluşur. Safra, bir sindirim enzimi değildir, ancak safra tuzu, büyük yağ damlacıklarını emülsifiye ettiği için benzer şekilde işlev görür. Safranın sindirim sistemindeki birincil işlevi, yağları parçalamaktır. Safra kesesinden (depolandığı yer) salgılanır ve daha sonra kolesistokinin adı verilen bir hormona (yiyecek mideden ince bağırsağa girdiğinde salınır) yanıt olarak ince bağırsağa girer. Safra onikiparmak bağırsağına (ince bağırsağın ilk bölümü) girdiğinde, sindirilen yağın sindirilen çözünürlüğünü iyileştirerek sindirilen yağın yanı sıra yağda çözünen vitaminleri de parçalayarak emilimini kolaylaştırır.\n\n";
           
        }
        if (urun == "Sakız")
        {
            urunResmi.sprite = burakResimler[63];
            baslik.text = " Sakız ";

            konu.text = "- Sakız çiğnemek belleği ciddi oranda güçlendirmektedir.\n\n" +
             "- Gün içerisinde önemli bir motivasyon desteği sağlar.\n\n" +
             "- Özellikle çene hareketi sağladığı için hafızayı güçlendirir.\n\n" +
             "- Beyne giden kan hızı dengeye ulaşır ve daha fazla oksijen gider.\n\n" +
             "- Motivasyon ile beraber uyanıklığı arttırıcı bir etkisi bulunur.\n\n" +
             "- Sinir ve stres ile beraber gerginliğin atılmasını sağlar.\n\n" +
             "- Kas hareketleri sağladığı için dengeli şekilde kilo vermeye yardımcı olur.\n\n" +
             "- Sakız çiğnemek bağırsak hareketlerine yardımcı olur.\n\n" +
             "- Ağız kuruluğuna karşı tükürük üretir.\n\n" +
             "- Mideden ağza doğru gelecek olan reflüyü engeller.\n\n" +
             "- Ağız ve diş temizliği için oldukça önemlidir.\n\n";

        }
        if (urun == "Safra Kesesi Taşı")
        {
            urunResmi.sprite = burakResimler[65];
            baslik.text = " Safra Kesesi Taşı ";

            konu.text = "- Safra kesesi taşı kadınlarda erkeklere oranla daha fazla sıklıkta görülen ve oldukça ağrılı seyredebilen bir hastalıktır. Karaciğerden günde yaklaşık olarak 1 litre kadar safra salgılanır ve bağırsaklardan yağların sindirimi ile bazı vitaminlerin emilimini sağlamak gibi çeşitli fonksiyonları yerine getirir.\n\n" +
             "- Safra, karaciğerden midenin devamı olan oniki parmak bağırsağına doğru akarken, yolu üzerindeki safra kesesine uğrayarak burada birikir. Suyu emilerek yoğunluğu daha da artar. Özellikle yağlı yiyecekler başta olmak üzere bazı gıdaların tüketilmesinin ardından safra kesesi kasılarak içerisindeki yoğunlaşmış safrayı onikiparmak bağırsağına doğru sevk eder. Olağan koşullarda bileşiminde bulunan çeşitli maddelerin belirli miktarlardaki karışımı sayesinde safra akışkanlığını korur. Ancak safranın içinde yer alan bu bileşenlerdeki herhangi bir artış ya da azalma, safranın akışkanlığında bozulmaya ve tortu bırakıcı bir hal almasına yol açabilir.\n\n" +
             "- Hem bu tortular hem de uzun süre sadece damar yoluyla beslenen ya da uzun süreli açlık hallerinde safra çamuru denen safra çökeltileri de safra taşı oluşumunda rol oynayabilir.\n\n" +
             "- Safra Taşı Oluşumu Olası Nedenleri;\n\n" +
             "- SAFRADA AŞIRI KOLESTEROL VARLIĞI,\n\n" +
             "- SAFRADA AŞIRI BİLİRUBİN VARLIĞI,\n\n" +
             "- SAFRA KESESİNİN TAM OLARAK BOŞALAMAMASI.\n\n" +
             "- Safra kesesi taşı belirtileri nelerdir?\n\n" +
             "- Ani ve hızlı ağırlaşan karnın sağ üst bölgesinde ağrı hissi,\n\n" +
             "- Sırt ağrısı,\n\n" +
             "- Sağ omuzda ağrı,\n\n" +
             "- Bulantı, kusma,\n\n" +
             "- İdrar renginde koyulaşma\n\n" +
             "- Açık renkli dışkı\n\n" +
             "- Aşırı gaz ve diğer sindirim problemleri\n\n" +
             "- İshal\n\n" +
             "- Safra kesesi ameliyatı ve taş tedavisi nasıldır?\n\n" +
             "- Hastalığın ve komplikasyonlarının tedavilerinde çeşitli yöntemler kullanılır. En sık kullanılan yöntem laparoskopik ameliyatlardır. Safra kesesi ameliyatlarının %5'ten daha azı açık ameliyat ile gerçekleşir. Açık ameliyat yapılmasının en önemli sebebi karın içerisinde önceden geçirilmiş ataklar ya da ameliyatlara bağlı oluşmuş yapışıklıklardır. ERCP ve PTK gerekli olan durumlarda kullanılan diğer tedavi yöntemleridir.\n\n" +
             "- Safra kesesi taşı gelişiminden ve taşa bağlı olumsuz etkilerden korunmak adına hekimlerin bilgisi ve önerisi dahilinde yapılabilecek bir takım beslenme değişiklikleri mevcuttur:\n\n" +
             "- Kızartmalar gibi yağ içeriği yüksek gıdalardan kaçınmak ve düşük yağlı besinlerle beslenmek.\n\n" +
             "- Beslenme programına bağırsak hareketlerini kolaylaştırıcı etki gösteren lif içeriği yüksek gıdalar eklemek\n\n" +
             "- Kahve safra kesesi taşı ve diğer hastalıklarına karşı koruyucu etki gösterebilir ancak yüksek düzeyde kafein içeren içeceklerden, yüksek yağlı süt ürünlerinden ve şeker içeriği yüksek tatlı gıdalardan diyare (ishal) yapıcı etkileri nedeniyle uzak durulması önerilir.\n\n" +
             "- Sindirimi kolaylaştırmak adına öğünleri küçülterek beslenmek ve günlük en az 6-8 bardak su tüketmek yapılabilecek diğer beslenme uygulamaları arasında yer alır.\n\n" +
             "- Safra kesesi taşı veya gelişme riski bulunan kişiler kilo verirken yavaş kilo verme yöntemlerini seçmesi önerilir. Hızlı şekilde kilo vermek hem safra kesesi taşı gelişimine hem de diğer sağlık problemlerine neden olabileceği için dikkatli olunmalıdır.\n\n" +
             "- Safra kesesi taşı belirtileri ve diğer şikayetler zaman içerisinde ortaya çıkıp sonrasında kaybolabilir. Özellikle 5 saati geçen karın ağrısı şikayetinde, sarılık belirtilerinin eşlik etmesi halinde, dışkının beyaz renkte olması halinde ve bu belirtilere terleme, üşüme, titreme ve ateş gibi diğer şikayetlerin eşlik etmesi durumunda sağlık kuruluşlarına başvurmanız önerilir.\n\n";

        }
        if (urun == "Salgın")
        {
            urunResmi.sprite = burakResimler[66];
            baslik.text = " Salgın ";

            konu.text = "- Epidemiyolojide, salgın (Yunanca epi- üzerinde + demos halk) belli bir insan popülasyonunda, belli bir periyotta, yeni vakalar gibi görülen ancak önceki tecrübelere göre beklenenden fazla etki gösteren hastalıktır, (epizootik ise aynı şeydir ancak hayvanlarda geçerlidir). Belli bir bölgede yayılan salgınlara epidemi, dünya çapında yayılan salgınlara pandemi denir.\n\n" +
             "- Beklenenin ne olduğuna bağlı olarak salgının tanımlanması subjektif olabilir. Bir salgın lokal (bir hastalık patlaması), daha genel (epidemik) ve hatta dünya çapında (pandemik) olabilir.\n\n" +
             "- Sabit seviyede oluşan ve popülasyonda görece olarak yüksek derecede seyreden alışılagelmiş hastalıklar ise endemik olarak adalandırılır. Endemik hastalığa bir örnek sıtmadır. Afrikanın bazı bölgelerinde (örneğin, Liberya) halkın büyük çoğunluğunun hayatlarının bazı dönemlerinde sıtmaya yakalanmaları beklenir.\n\n" +
             "- Meşhur salgınlara örnek olarak Orta Çağ Avrupasında yaşanan ve kara veba olarak da bilinen hıyarcıklı veba, I. Dünya Savaşı sonunda ortaya çıkan İspanyol gribi verilebilir.\n\n";

        }
        if (urun == "Sandal Ağacı")
        {
            urunResmi.sprite = burakResimler[67];
            baslik.text = " Sandal Ağacı ";

            konu.text = "- Sandal ağacı yağı cilt bakımında sıkça kullanılır. Özellikle de yaşlılık ve güneş ışınlarından dolayı ciltte oluşan koyu renkte halkalar, sivilce, siyah noktalar ve cilt kuruluğu için sandal ağacı yağı sık olarak önerilir.\n\n" +
             "- Sandal ağacı yağı kuru ciltleri besler ve nemlendirir.\n\n" +
             "- Kurumuş, çatlamış ve yıpranmış ciltleri onarır.\n\n" +
             "- Ciltte biriken her türlü virüs ve bakterilerin arınmasına yardımcı olur.\n\n" +
             "- Ciltteki ölü derilerin ve kirin temizlenmesine yardımcı olur.\n\n" +
             "- Sandal ağacı yağı vücuda faydaları \n\n" +
             "- Kaliteli ve doğal bir balgam söktürücüdür.\n\n" +
             "- Öksürüğü doğal yoldan iyileştirir ve solunumu dengeler.\n\n" +
             "- Antiseptik, rahatlatıcı ve yatıştırıcı özellikleri vardır.\n\n" +
             "- Alerjik ciltlere zarar vermeden, doğal bir antiseptik olarak cildin temizlenmesinde rahatlıkla kullanılır.\n\n" +
             "- Dizanteri hastalığının tedavisine yardımcı olur.\n\n" +
             "- Bel soğukluğunu giderir.\n\n" +
             "- Ciltte oluşan akne türü sorunları sakinleştirir ve tedavi eder.\n\n" +
             "- Uykusuzluk, stres, gerginlik, depresyon gibi sorunların çözümünde rahatlatıcı olarak etkilidir.\n\n" +
             "- Afrodizyak etkisi vardır.\n\n" +
             "- Etkili ve doğal bir antibiyotiktir.\n\n" +
             "- Ülser sorununda mideyi tedavi etme aşamasında yardımcı etkendir.\n\n" +
             "- Ciltte oluşan çürükler ve yanıkların tedavisinde kullanılır.\n\n" +
             "- Ciltte oluşan şişlik ve kaşıntı oluşturan böcek ısırığı gibi hassas şikayetlere de iyi gelir.\n\n" +
             "- Cilt yanıklarının rahatlatılmasını ve azalmasını sağlar ve cildin renk tonunu doğal olarak açar.\n\n" +
             "- Terleme sorununu doğal yoldan çözer.\n\n" +
             "- Vücudun doğal işleyişini hızlandırır; sindirim, solunum ve sinir sistemini güçlendirir.\n\n" +
             "- Sandal ağacı yağı ruh halinizi düzeltmek için de yararlıdır. Sandal ağacının topraklama dengeleyici aroması, duyguların dengelenmesine yardımcı olacaktır.\n\n" +
             "- Sandal ağacı yağı harici olarak, cilt üzerine masaj ve friksiyon yapmak kaydıyla kullanılması önerilir. Hamileyseniz, bebek emziriyorsanız veya bir doktor bakımı altında tedavi görüyorsanız, kesinlikle doktorunuza danışın. Gözler, iç kulaklar ve hassas bölgelerle temas etmesinden kaçının.\n\n";
            
        }
        if (urun == "Sarhoşluk")
        {
            urunResmi.sprite = burakResimler[68];
            baslik.text = " Sarhoşluk ";

            konu.text = "- Alkol aldıktan sonra ayılma süresi kişiye bağlıdır. Bununla birlikte, vücudun alkolü dışarı atma hızı genellikle saatte yüzde 0.15'tir. Tüketilen alkol miktarı, ayılmanın ne kadar süreceğini etkiler. Ne kadar çok içerseniz, alkol vücutta o kadar uzun süre kalır. \n\n" +
             "- İşte bu içeriğimizde sarhoş insanı ayıltma yöntemlerini sizler için listeledik. Fakat söylemekte fayda var, bu yöntemler kan dolaşımındaki alkolü temizlemez. Sadece kişinin daha uyanık hissetmesini sağlar.\n\n\n" +
             " Buz Gibi Soğuk Bir Duş\n\n- Soğuk bir duş, uyanıklığı artırabileceği ve sarhoş kişinin daha dinç görünmesine yardımcı olabileceğinden faydalı olabilir. Fakat dikkatli olunmalı çünkü bazı durumlarda soğuk duş, yarattığı şok etkisiyle beraber küçük bir hafıza kaybı etkisi de yaratabilir.\n\n\n" +
             " Türk Kahvesi İçmek\n\n- Kafein daha uyanık hissetmeye yardımcı olur fakat ayıltmaz. Yine de Türk kahvesi uyanık hissetme konusunda daha etkili olacaktır. Aynı zamanda hem kafein hem de alkolün dehidrasyon etkisi olduğunu hatırlamakta fayda var bu nedenle sarhoşken kahve içmek bazen iyi bir fikir olmayabilir.\n\n\n" +
             " Limonlu Soda\n\n- Diğer bir yöntem ise limonlu sodadır. Sarhoş kişiye limonlu soda içirmek kısa bir süre sonra daha uyanık hissetmesine yardımcı olacaktır.\n\n\n" +
             " Bol Bol Su İçmek\n\n- Bol su içmek, alkol tükettikten sonra hidrasyona ve toksinlerin vücuttan atılmasını sağlar. Ayrıca susuz kalmak, baş dönmesi, sersemlik ve yorgun hissetme gibi semptomları ağırlaştırabilir. Bu yüzden sarhoşken bol su tüketmek kan dolaşımındaki alkolü seyreltmeye yardımcı olur.\n\n\n" +
             " Bol Şekerli Çay\n\n- Bol şekerli çay, bilenen yöntemlerden biridir. Sarhoşken vücuda şeker yüklemek ayılmaya yardımcı olur.\n\n\n" +
             " Egzersiz Yapmak\n\n- Egzersiz sarhoşken yapmak istenecek son şey olabilir. Fakat metabolizmayı hızlandırarak terlemeye neden olur ve böylece ayılmada etkisi olacaktır.\n";

        }
        if(urun == "Sarılık")
        {
            urunResmi.sprite = burakResimler[69];
            baslik.text = " Sarılık ";

            konu.text = "\n- Sarılık bir çeşit hastalık değil de bir çeşit belirti olmaktadır. Bu durumda her sarılık bulaşıcı olmamaktadır. Kan içerisinde bulunan bilirubin adlı maddenin ciltte, cilt altında, mukozalarda ve göz akları üzerinde birikerek, bu bölgelerde sarı bir renk görülmesi sebebiyle buna sarılık denilmektedir. Bu bölgelerde göz ile görülecek şekilde bir birikim olması için ücutta bilirubin maddesinin üretiminin çok artması veya bu bilirubin maddesinin vücuttan atılımının yavaşlaması gerekmektedir.\n\n\n" +
             " Sarılığa İyi Gelen Yiyecekler Nelerdir?\n\n\n" +
             " Bal\n\n- Bal oldukça lezzetli bir besin olmasının yanı sıra insan sağlığı için çok da faydalı bir gıdadır. Bu sebeple düzenli olarak tüketilmesi gerekir. Ancak bal tüketiminden önce dikkat edilmesi gereken bir husus da vardır. Piyasada çok fazla sahte bal ya da tam anlamıyla doğal olmayan bal bulunmaktadır. Bu balların tüketiminin insan sağlığı için hiçbir faydası bulunmamaktadır. Bu neden bal tüketimi için bal tercihi yaparken kesinlikle ne kadar doğal olduklarına bakılmalı ve doğallıklarından emin olunduktan sonra tüketilmelidir. Balın aynı zamanda sarılığa da etki ettiği ve iyi geldiği söylenmektedir. Bu nedenle sarılık problemi yaşayan kişilerin tüketebileceği bir gıdadır. Yine de bal tüketiminde aşırıya kaçmamak çok önemlidir. Çünkü aşırı miktarda ve vücudun ihtiyacından çok daha fazla tüketilen her gıda vücutta başka birtakım rahatsızlıklara sebep olabilmektedir. Bu sebeple sarılığa da iyi geldiği belirtilen balı dahi kafi gelecek miktarda tüketmek büyük bir önem taşımaktadır. \n\n\n" +
             " Maydanoz\n\n- Maydanoz oldukça yararlı, besin değeri yüksek ve lezzetli bir besindir. Türk ve dünya mutfağından pek çok yemekte kendine yer bularak bu yemekleri hem daha lezzetli hem de daha sağlıklı kılan bir gıdadır. Maydanozun da sarılığa iyi gelen yiyeceklerden bir tanesi olduğu söylenmektedir. Bu sebeple sarılığın vücudunuza bıraktığı olumsuz etkileri azaltmak için düzenli olarak tüketebilirsiniz. Maydanozu salatalarınıza ilave edebilir, maydanozdan yapılmış bitki çayı içebilir ve maydanozun suyunu içebilirsiniz. Ancak maydanoz tüketiminde de aşırıya kaçmamanız gerekmektedir. Sarılığın da en iyi ve en önemli tedavi yönteminin doktorun önereceği tedavi olduğu unutulmamalıdır. \n\n\n" +
             " Zerdeçal\n\n- Zerdeçal da sıklıkla tüketilmese de çok sağlıklı bir gıdadır. Zerdeçalın da sarılığa oldukça iyi geldiği uzmanlar tarafından belirtilmektedir. Bu sebeple sarılık rahatsızlığınız var ise düzenli olarak ancak kesinlikle yeterli miktarda zerdeçal tüketebilirsiniz. Zerdeçalın pek çok farklı tüketim şekli bulunmaktadır. İster zerdaçalı yemeklerinizin içerisine toz olarak ilave edebilir, isterseniz de çayını yaparak tüketebilirsiniz.\n\n\n" +
             " Lahana\n\n- Lahana zaten faydaları herkes tarafından bilinen bir yiyecektir. Lahana sarılıkta da çok etkili bir gıdadır. Bu yüzden de sarılık problemi çeken kişilerin düzenli olarak tüketmesinden oldukça büyük fayda vardır.\n\n\n" +
             " Turp\n\n- Turp hali hazırda insan sağlığına pek çok faydası olan bir gıdadır. Bu sebeple turpun sarılık rahatsızlığı çeken kişiler tarafından düzenli olarak tüketilmesinde önemli bir faydası bulunmaktadır. Sarılıkta oldukça etkili olan turpu da vücuda aşırı miktarda almamak gerekir. Çünkü her gıdanın aşırı tüketiminde ne kadar sağlıklı olursa olsun birtakım başka rahatsızlıklar vücutta oluşabilmektedir. Bu konuda dikkatli olmak gerekir.\n";

        }
        if (urun == "Sarımsak")
        {
            urunResmi.sprite = burakResimler[70];
            baslik.text = " Sarımsak ";

            konu.text = "\n- Latince ismi Allium Sativum olan sarımsağın ana vatanı Hindistan, Çin ve Orta Asya’dır. Çin’de çok eski tarihlerden beri doğal ilaç yapımında kullanılmıştır. Mısır’da bulunan eski mezarlarda da onun izlerine rastlanır. Yüzyıllardan beri ilaç olarak kullanılan sarımsak ülkemizde özellikle savaş yıllarında tifo, dizanteri ve veba gibi hastalıkların tedavisinde kullanılmış bir bitkidir.\n\n" +
             "- Yutularak tüketilen sarımsak vücuda enerji verir. Bedenin dinç ve sağlıklı kalmasına yardım eder. Bu nedenle halsizlik ve kronik yorgunluğa karşı çok iyi gelir.\n\n" +
             "- Afrodizyak etkisi vardır. Sarımsağın yutularak tüketilmesi cinsel performansı artırır.\n\n" +
             "- Sarımsak yutmak saçlarda oluşan dökülmeyi azaltır. Sağlıklı ve parlak görünümlü saçlar için etkilidir.\n\n" +
             "- Zehirlenmelere karşı sarımsak yutmanın yararlı olduğu hakkında görüşler vardır.\n\n" +
             "- Kireçlenmeye karşı iyi gelir.\n\n" +
             "- Sarımsak yutma, vücutta oluşan iltihaplı hastalıklara karşı antibiyotik etkisi yapar.\n\n" +
             "- Kolesterolü düşürür ve idrar söktürücü özelliği ile yüksek tansiyona iyi gelir.\n\n" +
             "- Hazmı kolaylaştırır. Bağırsakların düzenli çalışmasını sağlar ve bağırsak kurtlarının düşmesine yardım eder.\n\n" +
             "- Sarımsağın yutularak tüketilmesi kanın kolayca sulanmasını sağlar.\n\n" +
             "- Gece yatmadan önce bir diş sarımsak yutulursa kabızlığa iyi gelir. Kabız olmaktan da korur.\n\n" +
             "- Kansere karşı koruyucu etkisi vardır. Oluşan kanser hücrelerinin yayılmasını engellediği yönünde görüşler bulunur.\n\n" +
             "- Doğal bir antibiyotiktir. Enfeksiyonları iyileştirir. Düzenli olarak yutulması halinde bağışıklık sistemini güçlendirerek soğuk algınlığına karşı direnç geliştirir.\n\n" +
             "- Sarımsağın çiğ olarak tüketilmesi daha çok tavsiye edilir. Keskin tadı ve yoğun kokusu olduğu için herkes çiğ sarımsak yemeyi tercih etmeyebilir. Pişirilen sarımsağın bu özellikleri, büyük ölçüde azalır.\n\n" +
             "- Pişmiş sarımsak daha kolay sindirilir. Çok pişirilmesi besin değerini azaltır. Bu yüzden kabuklu olarak pişirmeyi tercih edebilirsiniz. Sarımsağı az pişmiş olarak tüketirseniz şu faydalarından yararlanabilirsiniz:\n\n" +
             "- Kalp ve damar hastalıklarına karşı faydalıdır. Damarları temizler ve kalp hastalıklarına karşı dirençli olmayı sağlar.\n\n" +
             "- Kan basıncını düşürür. Tansiyonu ve kolesterol seviyesini düzenler.\n\n" +
             "- Pişmiş sarımsak, bağışıklık sistemini güçlendirerek hastalıklara karşı korur.\n\n" +
             "- Vücutta biriken ağır metallerin atılmasına katkı sağlar.\n\n" +
             "- Kemikleri güçlendirir. Kemik ve kas sağlığına iyi gelerek atletik bir yapı kazandırır.\n\n" +
             "- Besin değeri yüksek bir gıda olduğu için yorgunluğun giderilmesine yardımcı eder. Vücudu zinde tutar.\n\n" +
             "- İştah açıcı özelliği vardır. Sarımsağın göze faydaları olduğu hakkında bilgiler bulunur.\n\n" +
             "- Sarımsağın faydaları söz konusu olduğunda en yararlı tüketim şekli, taze sarımsak ya da çiğ sarımsak yemektir. Filizlenen sarımsağın faydaları tıpkı baş haline gelen sarımsak gibidir. Belki daha lezzetli olduğu için kolayca tüketilebilir.\n\n" +
             "- Taze sarımsağın faydaları şöyle sıralanabilir:\n\n" +
             "- Çıbanları ve cilt yaralarını iyileştirici özelliği bulunur.\n\n" +
             "- Kaslarda meydana gelen kramplar için faydalıdır.\n\n" +
             "- Damarları genişletir ve kalp sağlığına iyi gelir.\n\n" +
             "- Sarımsak bal ile birlikte tüketilirse bağırsak parazitleri ile kurtlarını düşürür. Ayrıca bağırsak gazların atılmasında etkilidir.\n\n" +
             "- Öksürük, boğaz ağrısı gibi şikayetlere iyi gelir ve balgam söktürücü etkisi vardır. İnatçı öksürükleri keser. Diş sağlığını korumaya faydalıdır. Diş ağrısına iyi gelir.\n\n" +
             "- Sindirim sisteminin düzenli çalışmasına yardımcı olur. Bağırsakları hareketlendirir.\n\n" +
             "- Sarımsak mantar tedavisinde kullanılan bir bitkidir.\n\n" +
             "- Meme ve prostat kanserine karşı faydalı olduğu hakkında bilgiler bulunur. Tümörlerle savaşabilen bir yapısı olduğu söylenir. Yeni tümör oluşumlarını engeller.\n\n" +
             "- Bağışıklık sistemini güçlendirir. Astım bronşite karşı faydalı olabilir.\n\n" +
             "- Saç dökülmesine ve saçkırana karşı faydalıdır. Küsen kaşlara da iyi geldiği bilinir.\n\n" +
             "- Kemik sağlığını koruduğu için menopoz döneminde yaşanabilecek osteoporoz gibi kemik hastalıklarına yakalanmayı önler.\n\n" +
             "- Sarımsağın faydaları Ahmet Maranki tarafından önemle vurgulanır. Maranki, Alzheimer ve demans rahatsızlığına karşı sarımsak yenmesini tavsiye eder.\n\n";

        }
        if(urun == "Sedef Hastalığı")
        {
            urunResmi.sprite = burakResimler[71];
            baslik.text = " Sedef Hastalığı ";

            konu.text = "\n- Sedef hastalığı, cilt hücrelerinin normalden bir kaç kat daha hızlı çoğalmasına neden olan bir cilt bozukluğudur. Bir diğer adı da psoriasis olan sedef hastalığı sırasında ciltte beyaz pullarla kaplı engebeli kırmızı lekeler görülmeye başlanır.\n\n" +
             "- Bu pullu lekeler cildin herhangi bir yerinde büyüyebilirler, ancak çoğunlukla kafa derisinde, dirseklerde, dizlerde ve sırtta görülürler. Sedef hastalığı bulaşıcı değildir, yani kişiden kişiye geçemez. Ancak bazı vakalarda aynı ailenin üyelerinde görülmektedir.\n\n" +
             "- Sedef hastalığı genellikle erken yetişkinlikte görülür. Çoğu vakada cildin sadece birkaç bölgesi etkilenir. Ancak daha ağır vakalarda, sedef hastalığı vücudun büyük bir bölümünü kaplayabilir. Kırmızı lekeler zaman içerisinde iyileşebilir ve bireyin hayatı boyunca tekrar geri gelebilir.\n\n\n" +
             " Sedef Hastalığı Neden Olur?\n\n- Sedef hastalığının kesin nedeni henüz bilinmese de uzmanlar bu hastalığın birden fazla faktörün kombinasyonu nedeniyle ortaya çıktığına inanmaktadır.\n\n" +
             "- Bağışıklık sistemindeki bir hata ciltte gereksiz yere iltihaplanmaya, bu da yeni cilt hücrelerinin hızlı bir şekilde çoğalmasına neden olmaktadır.\n\n" +
             "- Normalde cilt hücreleri her 10 ila 30 günde bir değiştirilir. Sedef hastalığında ise yeni hücreler her 3-4 günde bir büyür. Bu kadar sık bir şekilde yenileri ile değiştirilen eski hücreler birikerek, ciltte görülen gümüş pulları ortaya çıkarır.\n\n" +
             "- Sedef hastalığı aynı aile içindeki bireylerde görülebilir, ancak bazen kuşak atlayabilir. Örneğin, bir dede ile torunu etkilenebilir, ancak çocuğun annesi hastalıktan etkilenmeyebilir. Sedef hastalığı bunun haricinde bireyden bireye geçmez, bulaşıcı değildir.\n\n" +
             "- Sedef hastalığının hemen her türünün bir takım ortak tetikleyicileri mevcuttur. Sedef hastalığının canlanmasını tetikleyebilecek bu koşullar arasında ciltte meydana gelen kesikler, sıyrıklar veya cerrahi müdahaleler, duygusal stres, strep enfeksiyonları, bipolar bozukluk için kullanılan lityum, sıtma ilaçları, beta-bloker gibi tansiyon ilaçları, hidroksiklorokin veya antimalaryal ilaçları, özellikle genç erkeklerde aşırı alkol kullanımı ve sigara içilmesi olabilir.\n\n" +
             "- Hastalık özellikle kış dönemlerinde ve soğuk günlerde daha sık görülmektedir. Sıcak, güneşli ve nemli ortamlarda bulunmak hastalığın ortaya çıkması ihtimalini azaltabilir.\n\n" +
             "- Sedef hastalığı olan bazı bireylerde, en küçük bir çizik veya bir sivrisinek ısırığı bile yeni bir tetiklenmeye neden olabilir. Bu tepki travma sonrası hastalığa ait lezyonların ortaya çıkması olayıdır, adına Koebner fenomeni denilmektedir. Sedef hastalığı olan dört kişiden birinde görülmektedir.\n\n\n" +
             " Sedef Hastalığı Nasıl Geçer?\n\n" +
             "- Sedef hastalığı kronik bir hastalıktır, bu nedenle bütünüyle tedavisi yoktur. Ancak halihazırda kullanılan tedavi yöntemleri en ciddi vakalarda bile semptomları büyük ölçüde azaltır. Gerçekleştirilen son araştırmalar sonucunda, sedef hastalığının iltihaplanması iyi bir şekilde kontrol edildiğinde, bu iltihaplanma ile ilişkili kalp hastalığı, inme, metabolik sendrom ve diğer hastalıkların riskinin azaldığı görülmektedir.\n\n\n" +
             " Sedef Hastalığı Nasıl Tedavi Edilir?\n\n" +
             "- Sedef hastalığının tedavisi için kullanılan birçok yöntem mevcuttur. Bu yöntemlerden bazıları yeni cilt hücrelerinin büyümesini yavaşlatırken, diğerleri kaşıntıyı giderir ve kuru cildi rahatlatır. Doktor vakada görülen döküntünün büyüklüğüne, vücutta bulunduğu yere, bireyin yaşına, genel sağlığına, hastalığın türüne ve diğer faktörlere göre birey için doğru olan bir tedavi planı belirleyecektir.\n\n" +
             "- Sedef hastalığının yaygın tedavileri arasında steroid kremler, kuru cilt için nemlendiriciler, losyonlarda, kremlerde, köpüklerde, şampuanlarda ve banyo çözeltilerinde bulunan ve özellikle kafa derisinde görülen sedef hastalığı için yaygın bir tedavi yöntemi olan kömür katranı, D vitamini içeren ve reçete ile verilen krem veya merhemler, ile retinoid kremler bulunmaktadır.\n\n" +
             "- Daha ağır ve şiddetli sedef hastalığı vakaları için daha farklı tedavi yöntemleri de kullanılmaktadır. Bunlar arasında cilt hücrelerinin büyümesini yavaşlatmak için cilde ultraviyole ışık verilir. Fototerapi adı verilen bu ışık tedavisinde psoralen adı verilen bir ilaç ile ultraviyole ışık birlikte kullanılır.\n\n" +
             "- Kemik iliği ve karaciğer ile akciğer sorunlarına yol açabildiği için sadece ağır vakalarda kullanılan metotreksat ilacı da bir başka yöntemdir. Bu ilaç kullanımında birey doktor tarafından yakından izlenir ve laboratuvar testleri, göğüs röntgeni ile karaciğer biyopsisi yapılması gerekebilir.\n\n" +
             "- Retinoid içeren haplar, kremler, köpükler, losyonlar ve jeller, A vitamini ile alakalı ilaç sınıfıdır. Retinoidler, doğum kusurları da dahil olmak üzere ciddi yan etkilere neden olabilir, bu nedenle hamile veya çocuk sahibi olmayı planlayan kadınlar için önerilmez.\n\n" +
             "- Bunların yanı sıra sedef hastalığı nedeniyle iltihaplanmayı daha iyi kontrol etmek için vücudun bağışıklık sistemini (sedef hastalığında aşırı aktif olan) bloke ederek çalışan çeşitli biyolojik tedaviler de mevcuttur. \n\n" +
             "- Enzim inhibitörleri de sedef hastalığı ile psoriatik artrit gibi uzun süreli inflamatuar hastalıklar için kullanılan yeni bir ilaç türüdür.";
         
        }
        if (urun == "Sedir Ağacı")
        {
            urunResmi.sprite = burakResimler[72];
            baslik.text = " Sedir Ağacı ";

            konu.text = "\n- Sedir, çamgiller familyasından gelmektedir. İğne yapraklı ağaç türlerindendir. İğne yaprakları üç köşeli olup dökülmez ve her zaman yeşil kalabilir. Çam ağacıyla benzer özellikler gösteren sedir ağacının kozalakları vardır. Çam ağacıyla yaprak uzunlukları bakımından birbirinden ayrılırlar. Aynı şekilde iki ağacın da kozalakları farklıdır. Sedir ağacı yarı ışık ağacıdır. Soğuk havalara dayanıklı değildir ve sıcağı sever. Akdeniz iklimi sedirin yetişmesi için gerekli tüm koşulları oluşturur. Ülkemizin genellikle güney kesimlerinde görülse de elverişli ortamı bulduğunda yetişir. Örneğin ona İstanbul’da da sık sık rastlanabilir." +
                " Türkiye’de sedir ormanlarının bulunduğu alanlar Antalya ve çevresinde yer alır. Bu sedirler genelde Toros sediri adıyla da anılır. Diğer ağaç türlerinden farklı olarak 25 - 30 yıl sonrasında ergenliğine ulaşan bu ağaçların olgunluk çağına ulaşması daha uzun yıllar alır. Tohumla üreyebilen bu ağaç tekrar ekilebilir. Kokusuyla insanı büyüleyen ve rahatlatan bu bitkiden aynı zamanda mobilya ve enstrüman üretiminde de faydalanılır.Ancak faydaları bununla sınırlı değildir. Sedirden elde edilen yağ birçok rahatsızlığa iyi gelmektedir. En çok cilt hastalıkları tedavisinde iyileştirici rolü oynar. Gelin birlikte sedir yağının faydalarına bir göz atalım.\n\n" +
             "- Sağlık ve kozmetik sektöründe doğanın iyileştirici gücüne oldukça sık başvurulur. Cilt ürünlerinde bitkilerin ve ağaçların esansları kullanılır. Bileşenlerinin özellikleri bilinen bu yağ ve esanslar tüketicilerin doğal bir ürün kullandıklarını bildikleri için kendilerini güvende hissetmelerini sağlar. Sedir cilt hastalıkları tedavisinde,  sindirim ve bağışıklık sistemi problemlerinde ve solunum rahatsızlıklarında faydası tespit edilmiş bir ağaç türüdür. Yaprakları, kozalakları, reçinesi ve odunu birçok sektörde kullanılmaktadır. Her kısmının insanlığa ayrı bir faydası dokunan sedir çok kıymetli bir ağaç türüdür. Sedir yağı sedir ağacından elde edilir. " +
             "Saf haliyle kullanılabildiği gibi ilave edilmiş diğer kozmetik ürünlerin de kullanılabileceği bilinmektedir. Yine de sedir yağının has ve katkısız hali en faydalı olanıdır. Alışveriş yaparken dikkatli olmanız ve saf bir yağ aldığınızdan emin olmanız etkisi bakımından önemlidir. Sedir yağının antiseptik, anti - enflamatuar, antispazmodik ve diüretik gibi başlıca özellikleri bulunur.Bunlar neden bu kadar faydalı olduğunu da bir kez daha gözler önüne sermektedir.Ciddi bir yan etkisi olmadığı bilinse de, kullanmadan önce doktorunuza başvurmanız tavsiye edilir.\n\n\n" +
             " Bilinen Faydaları ve Yapım Yöntemleri\n\n" +
             "- Ciltteki gözenekleri açarak cildi canlandırır. Siyah nokta ve akne problemlerine iyi gelir. Ciltteki kızarıklık ve tahrişleri sakinleştirir, aza indirir. Sedir yağı kullanılan ürüne eklenebileceği gibi saf halde yüze uygulanabilir. Masaj yapılarak uygulanması önerilir. Düzenli kullanımda ciltte sıkılaşma ve yenilenme görülür.\n\n" +
             "- Strese ve sinire iyi geldiği bilinir. Sedir yağını koklamak korkuların azalmasına yardımcı olur. Aynı zamanda kişinin dikkatini daha kolay toplamasını ve kolayca dağılmamasını sağlar. Kasları gevşeterek kişinin rahatlamasına yardımcı olur. Sedir yağını bir su bardağına damlatabilir ve oda kokusu olarak kullanabilirsiniz. Sedir bitkisinden yapılmış bu bu yağı çalışma ortamında veya günlük hayatınızda belli aralıklarla sürmeniz sizi rahatlatacaktır.\n\n" +
             "- Sindirim sistemi rahatsızlıklarının giderilmesinde yardımcıdır. Gastrit ve ülser gibi mide problemlerinin azalmasına yardımcı olur. Tekrar hatırlatmakta fayda vardır ki, kronik rahatsızlıklarda mutlaka doktora gidilmelidir. Daha günlük ve kısa süreli problemlerde sedirden faydalanılması önerilir. Sedir çayının mide rahatsızlıklarına iyi gelmesinin yanı sıra ağızdaki iltihapları da iyileştirdiği bilinir. Çay aynı zamanda stresi azalttığı için mide sorunlarınıza iyi gelecek olmanın yanında size bir dinginlik de verecektir.\n\n" +
             "- Sedirin ne kadar etkili ve faydalı bir ağaç türü olduğunu artık biliyoruz. Bir diğer faydası ise akciğer rahatsızlıklarına iyi gelmesidir. Öksürük ve bronşiti azaltır. Diüretik özelliğiyle de bilinen sağlıklı bir idrar söktürücüdür. İdrar yolu enfeksiyonlarının tedavisinde de kullanılır.\n\n" +
             "- Faydalarını saymakla bitiremeyeceğimiz sedir yağı kolayca temin edilebilmektedir. Ancak daha önce de söylediğimiz gibi değerli olan bu yağın has olmasına ve katkı maddesi içermemesine dikkat etmelisiniz.";

        }
        if (urun == "Semizotu")
        {
            urunResmi.sprite = burakResimler[73];
            baslik.text = " Semizotu ";

            konu.text = "- Besin değeri yüksek olan semizotunun birçok hastalığa koruyucu etkisi var. Başta C ve A vitamini olmak üzere pek çok vitamin içeren semizotu, Omega 3 ihtiyacının bir bölümünü de karşılıyor.\n\n\n" +
             " Kalbi Koruyor\n\n- Doymamış yağ asitlerinden; özellikle omega-3 yağ asitleri, a-linolenik asit, EPA, DHA, glutatyon, glutamik asit ve aspartik asit bakımından zengin olan semizotu, kalp damar sağlığını koruyor.\n\n\n" +
             " Kolesterolü Düşürüyor\n\n- İçeriğindeki zengin bileşenler sayesinde hem kolesterolün düşürülmesine yardımcı oluyor hem de kan basıncının dengelenmesinde önemli rol oynuyor.\n\n\n" +
             " Hastalıklardan Koruyor\n\n- Bakteri ve mantar üremesine karşı koruyucu etkiye sahip olduğundan vücudu hastalık yapıcı mikroorganizmalara karşı koruyor.\n\n\n" +
             " Kanser Hastalarına Öneriliyor\n\n- Antioksidan etkisinden ötürü bağışıklık sistemini güçlendiriyor ve kanser gibi çeşitli hastalıkların tedavisinde de kullanılıyor.\n\n\n" +
             " Böbrekte Kum ve Taşı Döküyor\n\n- İdrar söktürücü ve toksin temizleyici özelliğe sahip olan semizotunun, böbrekteki kumu ve taşı döktüğü biliniyor.\n\n\n" +
             " Kabızlığı Önlüyor\n\n- Baharın şifalı besini, içerdiği yüksek oranlı lifiyle kabızlığı önlüyor, kabızlık çekenlere bağırsakları çalıştırarak fayda sağlıyor.\n\n\n" +
             " Yorgunluk, Halsizlik ve Depresyona İyi Geliyor\n\n- İçeriğindeki vitamin ve mineraller sayesinde, yorgunluk, halsizlik ve depresyona da iyi geliyor.\n\n\n" +
             " Formda Kalmaya Yardımcı Oluyor\n\n- Düşük kalori ve düşük glisemik indeksi ile kan şekerinin dengelenmesini sağlayan semizotu, formda kalmaya da yardımcı oluyor.\n\n\n" +
             " Cildi ve Gözü Koruyor\n\n- Ciltte kuruluk gibi sorunlara fayda sağlayan semizotu, içeriğindeki A vitamini sayesinde göz problemlerine karşı da koruyucu etkiye sahip.\n\n\n" +
             " Bağışıklık Sistemini Güçlendiriyor\n\n- Semizotu; A, B1, B2,B6, C, E, niasin, nikotinik asit, beta karoten, riboflavin, folat gibi vitaminlerden ve özellikle K, Ca, Fe, Mg, Na, P, Cu, Zn ve Mn minerallerinden zengin olması sayesinde bağışıklık sistemini güçlendiriyor.\n\n";
             
        }
        if (urun == "Serum")
        {
            urunResmi.sprite = burakResimler[74];
            baslik.text = " Serum ";

            konu.text = "\n- Serum içeriğinde tuz bulunan ve gerekli durumlarda damarlardaki kan içerisinde bulunan sıvı-elektrolit dengesine katkı sağlamak için kullanılan bir çeşit tuzlu çözelti olma özelliği taşımaktadır. Günümüzde hastanelerde yaygın olarak kullanılmaktadır. Serum sanılanın aksine hastalık durumlarında kişilerin iyileşmesine etki eden özel ilaçlı bir karışım değildir.\n\n\n" +
             " Serum Ne İşe Yarar?\n\n- Serum esasında bir tür tuzlu su karışımıdır. Pek çok kişinin sandığı gibi hastalık durumlarında sihirli bir iyileştirici etkiye sahip değildir. Serum kullanımın en önemli ve tek amacı ise; damarlardaki kan içerisinde bulunan sıvı-elektrolit dengesine katkı sağlamak olmaktadır. Bu kapsamda 1 litre serumun içeriğinde %0.9 tuz bulunmaktadır. Bunun anlamı litre başına 154 milimol sodyum (Na) ve 154 milimol klor (Cl)) bulunduğudur. Kısaca serum; %99.1' su olan bir tür tuzlu sudur.\n\n\n" +
             " Serumun İçinde Ne Vardır?\n\n- Serum içeriğinde %0.9 tuz bulunan yani litre başına 154 milimol sodyum (Na) ve 154 milimol klor (Cl)) bulundurmakta olup %99.1'i ise su olan bir tür tuzlu sudur. Serum'un hastanelerde en yaygın olarak kullanımı söz konusu olan tipi ise %0.9 oranında ve serumun litresi başına 9 gram tuz içeren bir nevi tuzlu su olmaktadır. Bir tür tuzlu su olan bu karışıma izotonik salin yahut fizyolojik salin gibi isimler verilmektedir.\n\n\n" +
             " Hangi Durumlarda Takılır?\n\n- İnsan vücudu, hücre adı verilen milyonlarca birimin bir araya gelmesinden oluşmaktadır. Her bir hücrenin içerisinde genel olarak su ve elektrolit adı verilen minerallerden meydana gelen hücre içi sıvısı vardır. Hücrelerin dışında da yine su ve bazı elektrolitlerden meydana gelmiş durumda olan ekstrasellüler sıvı (hücre dışı sıvısı) ismi verilen bir sıvı mevcuttur.\n\n" +
             "- Ekstrasellüler sıvı, hücrelerin arasında bulunmakta olan ara sıvı ve damarlarda bulunan kanın sıvı kısmını oluşturan plazma olmak üzere ikiye ayrılmaktadır. Bir bireyin sağlıklı olabilmesi için bu sıvıları oluşturan su ve elektrolitlerin belirli bir dengede olması gereklidir. Sıvı-elektrolit kayıplarının söz konusu olduğu durumlarda tedaviyi hızlandırıcı olarak yahut GİS (gastro-intestinal sistem) ya da ağız yoluyla ile ilaç ya da besin alınamayan hallerde hastalara serum takılır.\n\n\n" +
             " Serum Nasıl Hazırlanır?\n\n- Hastanelerde yaygın olarak kullanımı söz konusu olan parenteral solüsyonlar şeklindeki serumlar, şişe yahut bir torba içinde ambalajlanmış haldedir. Doktorun kararı doğrultusunda serum hastaya tek başına yahut içine ilaç karıştırılarak verilebilmektedir. Her iki şekilde de aseptik tekniğe uygun olarak hazırlanmasının gerekliliği söz konusudur.\n\n\n" +
             "- Sterilizasyonu korumak amacıyla serum şişesi yahut torbasının ağzında bulunmakta olan, set takılacak olan bölüme kesinlikle el ile dokunulmaz. Serumun içine ilaç karıştırılmasının gerekli olduğu hallerde enjektörün iğnesi ile özel kısımdan serum içerisine ilaç verilir ve sıvı hafifçe alt üst edilerek verilmiş olan ilacın sıvı ile iyice karışması sağlanır.\n\n\n" +
             " Ameliyattan Önce Neden Serum Takılır?\n\n- Ameliyat öncesinde damara yerleştirilen plastik bir kanül vasıtasıyla hastaya serum takılır. Anestezik ilaçlar bu damar yolu vasıtasıyla hastaya verilir. Böylece ameliyattan önce ve ameliyat esnasında hastanın sıvı ve elektrolit ihtiyacının karşılanması sağlanır.\n\n" +
             "- Yine ameliyat esnasında ortaya çıkan yaşamsal bulgularda oluşabilecek farklılıkların tedavisinde kullanılacak olan ilaçlar, vücuda seruma karıştırılarak verilir. Ameliyat sonrasında ise serum vasıtasıyla ağrı kesiciler, kusma ve bulantıyı önleyici etki gösterecek ilaçlar, hasta ağızdan gıda alabilecek hale gelene kadar serum içerisinde damar yoluyla verilir.\n\n";
             
        }
        if (urun == "Ses Kısıklığı")
        {
            urunResmi.sprite = burakResimler[75];
            baslik.text = " Ses Kısıklığı ";

            konu.text = "\n Ses Kısıklığı Nedir?\n\n- Normalde çok net olan sesinizde değişimler, boğuklaşmalar gündemdeyse buna neden olan sorunları araştırmakta fayda vardır. Çünkü ses kısıklığı, bir hastalık değil de bir hastalığın belirtisi olarak karşınıza çıkabilir. \n\n" +
             "- Ses düzeyinizde meydana gelen dalgalanmaları, ses kalitenizdeki düşüşü ifade eden ses kısıklığı birçok sorundan karşımıza çıkabilmektedir. Sesiniz cılız, titrek ve kısık olabilir. Bu şikayetin ana kaynağı gırtlak bölgesinde meydana gelen enfeksiyonlar ve ses tellerindeki problemlerdir. \n\n" +
             "- Kısa süreli ses kısıklıkları, soğuk algınlığı gibi basit nedenlerle bağdaştırıldığından çok önemsenmez ve kısa sürede yok olur. Fakat uzun süreli ses kısıklıklarının, ciddi tıbbi durumların ayak sesleri olabileceği ihtimalini göz ardı etmemek gerekir. \n\n\n" +
             " Ses Kısıklığı Nedenleri\n\n- Ses telleri, akciğerler ve sesin şekillendirilmesinden sorumlu dil, dudak, çene kasları, sesin oluşması için görevli 3 ana yapıdır. \n\n" +
             "- Ses, gırtlakta bulunan ses tellerinin birleşerek aradaki boşlukların kapanmasıyla oluşur. Eğer bu boşluklar tam olarak kapanmazsa ses kısıklığından söz edebiliriz. Ortaya çıkan ses kısıklığının sebebi, ses tellerinde meydana gelen hasarlarla ya da ses tellerinin tahriş olmasıyla açıklanabilir. \n\n" +
             "- Ses kısıklığına; grip, nezle, soğuk algınlığı gibi üst solunum yolu rahatsızlıkları, midedeki asitli içeriğin boğazı tahrişine neden olan reflü gibi hastalıklar, sigara kullanımı ya da pasif içicilik, kafein içeren içecekler veya alkollü içeceklerin tüketilmesi, çığlık, uzun süreli yüksek desibelli şarkılar söylemek ve bağırmak gibi faktörlere bağlı olarak ses zedelenmesi, nörolojik bozukluklar, alerjiler, ses tellerinde oluşan deformasyonlar, zehirli maddelerin solunması, kuvvetli öksürme atakları, gırtlaktaki ses kutusuna gelecek darbeler, ses tellerinde oluşan anormal yapılar, boğaz, tiroid, akciğer kanserleri, erkeklerde ergenliğe geçiş dönemi, tiroid bezinde meydana gelen işlev bozuklukları, ses oluşturmaya yardımcı kasların zayıflaması ve zarar görmesi gibi faktörler sebep olur.\n\n" +
             "- Ses kısıklığının meydana gelmesine, nörolojik sıkıntılar, psikolojik rahatsızlıklar, kalıtsal durumlar, hamilelik, kullanılan ilaç ve hormonlar, kötü huylu tümörler sebep olabilir. Ses kısıklığının en yaygın sebebi, akut larenjittir.\n\n\n" +
             " Ses Kısıklığı En Çok Kimlerde Görülür?\n\n- Sesini kullanarak işini idame ettiren; çağrı merkezi çalışanları, seyyar satıcılar, öğretmenler, spikerler, politikacılar, şarkıcılar gibi meslek grupları ses kısıklığıyla daha fazla karşılaşmaktadırlar. Ayrıca ses kısıklığına daha çok 30 ila 60 yaş aralığında denk gelinmektedir. Ses kısıklığı birkaç saat sürebildiği gibi hayat boyu da sürebilmektedir.\n\n\n" +
             "- Ses Kısıklığına Ne İyi Gelir?\n Boğazınız ağrıyorsa ılık tuzlu suyla boğazınız rahatlayana kadar gargara yapabilirsiniz. \n\n" +
             "- Evinizde, iş yerinizde kuru hava solumak boğazının tahriş olmasına sebep olabilir. Bu yüzden bulunduğunuz ortamlardaki havanın nemlendirilmesi önem arz etmektedir. Bunu bir buhar makinesiyle yapabileceğiniz gibi kalorifere ıslak havlu asmak gibi basit bir yöntemle de sağlayabilirsiniz. Ilık bir duş almak da boğazınızın nemlenmesine vesile olacaktır.\n\n" +
             "- Boğaz ağrılarınızı dindirmek amacıyla pastil kullanımını tercih edebilirsiniz.\n\n" +
             "- Ses kısıklığını gidermek için küçük bir bardak suya 2 çorba kaşığı sirke ve bir çay kaşığı bal ekleyip tüketebilirsiniz.\n\n" +
             "- Papatya, zencefil gibi rahatlatıcı çaylar boğaz ağrınızın dinmesine vesile olup, sizi rahatlatacaktır.\n\n" +
             "- 1 tatlı kaşığı bala 4-5 damla limon damlatıp gargara yapıp tüketmek boğazınızı yatıştırır.\n\n" +
             "- Doğal antibiyotik lakaplı sarımsağı tüketmeniz, ses kısıklığının tedavisine yardımcı olacaktır.\n\n";
           

        }
        if (urun == "Sıtma")
        {
            urunResmi.sprite = burakResimler[76];
            baslik.text = " Sıtma ";

            konu.text = " Sıtma Nedir?\n\n- Sıtma; insanlara parazit taşıyan sivrisineğin sokmasıyla bulaşan, zamanında tedavi edilmezse öldürücü olabilen, nöbetler halinde ateş ve titremeye neden olan bir hastalıktır.\n\n\n" +
             " Hastalık İnsanlara Nasıl Bulaşır?\n\n- Sıtma insanlara çoğunlukla parazit taşıyan sivrisineğin sokması ile bulaşır. Nadir olmakla beraber; sıtma paraziti taşıyan kanın sağlam kişiye verilmesi, parazitli kan bulaşmış iğnelerin batması veya kullanılması, organ nakli ve gebe kadınlarda plasenta yoluyla çocuğa geçiş ile de bulaşabilir.\n\n\n" +
             " Hastalığın Belirtileri Nelerdir?\n\n- Sıtma hastalığının belirtileri; nöbetler şeklinde gelen ateş, üşüme, titreme, baş ağrısı, kas ağrısı ve yorgunluktur. Bulantı, kusma ve ishal olabilir. Sıtma nöbetleri parazit türüne göre değişen aralıklarla, şiddetli titremeyle yükselen ateşle başlar, terlemeyle sona erer. \n\n" +
             "- Tanı ve tedavisinin geciktiği durumlarda kansızlık ve sarılık gelişebilir. Sıtma hastalığına sebep olan bazı parazit türlerinde tedaviye 24 saat içinde başlanmazsa ilerleyerek ölüme yol açabilir.\n\n\n" +
             " Hastalığın Tedavisi Var mıdır?\n\n Sıtma hastalığı ilaçlarla tedavi edilebilen bir hastalıktır. Hastalığın erken teşhis ve uygun tedavi edilmesi halinde hastalarda tam iyileşme olur. \n\n" +
             "- Tedavi ilaçlarının doğru dozda ve önerilen sürede kullanılması hastalığın tekrarını önleyeceğinden şikayetler geçse dahi tedavinin tamamlanması çok önemlidir. \n\n";
             
        }
        if (urun == "Siğil")
        {
            urunResmi.sprite = burakResimler[77];
            baslik.text = " Siğil ";

            konu.text = "\n Siğil İçin Evde Uygulanabilecek Alternatif Tedaviler;\n\n\n" +
             " Çay Ağacı Yağı\n\n- Çay ağacı yağının cilt hücrelerini hızla yenileme ve mikropları temizleme görevi vardır.\n\n" +
             "- Eğer vücudunuzda siğili bitkisel yollarla temizlemek isterseniz, siğil olan bölgeye düzenli olarak çay ağacı yağı sürün ve gazlı bezle bir süre kapatın.\n\n" +
             "- Düzenli kullanım sonucunda siğilin ufalarak iyileştiğini görebilirsiniz.\n\n\n" +
             " Aspirin\n\n- Siğil kaşıntısına ne iyi gelir dediğinizde ufak bir aspirini ezip birkaç damla suyla karıştırmanız yeterli olacaktır. Aspirinli suyu siğil olan dokuya sürün ve gazlı bezle bölgeyi sarın. Her akşam aksatmadan bu yöntemi denerseniz, siğilin oluşturduğu kaşıntı ve kabarıklığı ortadan kaldırabilirsiniz.\n\n\n" +
             " Hint Yağı\n\n- 1 hafta ile 3 hafta boyunca Hint yağı ile siğilli dokuya masaj yaparak bu sorunu çözebilirsiniz.\n\n\n" +
             " Diş Macunu\n\n- Her gece uykudan önce kullandığınız diş macununu, siğil olan yüzeye sürün ve yara bandı ile bu bölgeyi kapatın. Diş macunu, siğilin olduğu hücreleri iyileştirecek ve sizi bu cilt rahatsızlığından kurtaracaktır.\n";
            

        }
        if (urun == "Sinameki")
        {
            urunResmi.sprite = burakResimler[78];
            baslik.text = " Sinameki ";

            konu.text = "\n Sinameki Otunun Faydaları Nelerdir?\n\n" +
             "- Sinameki otunda bulunan bazı bileşenler vücutta oluşan parazitlerle savaşmaktadır. Bağırsak kurtları ile savaşır ve bağırsak sağlığınızı korur. Böylece mideniz daha iyi hisseder.\n\n" +
             "- Sinameki otu diüretik ve antioksidan bir bitkidir. Bu etkisi sayesinde vücudunuzda biriken zararlı maddeleri kolayca atmanızı sağlar. Sinameki otu kabızlık ve ödem durumlarında sizi iyi hissettiren bir bitki olacaktır. Kabızlık tedavisinde bitkisel çay olarak önerilmektedir.\n\n" +
             "- Vücudunuzda oluşacak iltihapları önler. Eğer var olan bir iltihap varsa kısa zamanda yok edip sizi eski sağlığınıza kavuşturur.\n\n" +
             "- Sinameki otu baş ağrısı, kemik ağrısı ve mide ağrısı gibi durumlarda ağrı kesici olarak etkisini gösterebilir.\n\n" +
             "- Sinameki otu bağırsaklarınız için etkili olduğu gibi cildiniz için de faydalı olacaktır. Sinameki otunu cildinizin daha canlı görünmesi ve parlaklık kazanması için kullanabilirsiniz.\n\n\n" +
             " Sinameki Otu Nasıl Kullanılır?\n\n\n" +
             " Sinameki Çayı\n\n- Sinameki otunu bitki çayı olarak tüketebilirsiniz. Yapmanız gereken tek şey iki çay kaşığı sinameki otunu bir bardak sıcak su ile 10 dakika demleyip içmek. Tadını biraz daha lezzetlendirmek isterseniz bir miktar bal ilave edebilirsiniz. Çayı gün içinde tüketebilirsiniz. Demlenen çayı en çok 20 dakika içinde tüketmelisiniz. Aksi takdirde etkisini kaybedecektir. Ağrı, stres, ödem ve hazımsızlık gibi durumlarda kurtarıcınız olacaktır. Kronik mide ve kalp hastalığı yaşayanlar tüketmeden önce mutlaka doktorundan onay almalıdır.\n\n\n" +
             " Saç Bakımı\n\n- Saçlarınızın daha sağlıklı uzamasını istediğinizde sinameki otu ile bir kür hazırlayabilirsiniz. Bir miktar sinameki otunu kaynatın ve soğumasını bekleyin. Soğuyan sinameki otu suyuna 3 tatlı kaşığı badem yağı ekleyin. Bu karışımın içine yarım aspirin ezin ve iyice karıştırın. Bakım yapacağınız zaman saçınızda en az 2 saat bu karışımı bekletin ve daha sonra duşa girin. Haftada 2 defa kullanımı tavsiye edilmektedir. Saçları seyrek olduğundan şikayetçi olanlara sinameki otu tavsiye edilecektir. Düzenli kullanımda saçlardaki boşluk gidecek ve saçlar daha da gürleşecektir.\n\n\n" +
             " Cilt Bakımı\n\n- Cilt bakımı konusunda da sinameki otu kullanımı yaygındır. Sinameki otunu kaynatıp bir pamuk yardımı ile yüzünüzü temizlediğinizde cildinizin mikroplardan arındığını fark edebilirsiniz. Bir miktar sinameki otunu kaynatın ve soğumaya bırakın. Bir pamuk yardımı ile yüzünüze dairesel hareketlerle masaj yapın. Her gün kullanabilirsiniz. Düzenli kullanımda cildinizdeki sivilce ve siyah nokta gibi problemler yok olacaktır.\n";
             

        }
        if (urun == "Sindirim Bozukluğu")
        {
            urunResmi.sprite = burakResimler[79];
            baslik.text = " Sindirim Bozukluğu ";

            konu.text = "- Sindirim denince aklımıza direkt mide ve bağırsaklar geliyor olsa da aslında tüm sistem içerisinde farklı vücut bölümleri de vardır. Ağızdan anüse kadar olan vücut bölümünde, gıdaların vücut için yararlı hale dönüştürüldükten sonra uygun bölümlerin dışa atılmasına kadar olan tüm süreçler sindirim sistemi görevleri arasında yer alır. Ağız, yutak, yemek borusu, mide, ince ve kalın bağırsak, karaciğer, pankreas ile anüs sindirim sisteminde yer almaktadır.\n\n" +
             "- Bu organlardan herhangi birine dair şikayetiniz varsa gastroenteroloji uzmanına görünebilirsiniz. Sindirim sistemi hastalıkları ve korunma yolları arasında en önemli başlık sağlıklı beslenme ve spor yapmaktan geçtiğini de unutmamalısınız.\n\n" +
             "- Sindirim sistemi hastalıkları tedavisi rahatsızlığın ciddiyetine, şiddetine, türüne ve rahatsızlığı yaşayan kişinin vücut özelliklerine, kilosuna ve boyuna göre değişmektedir. Çok ciddi durumlarda ameliyata kadar uzanan zorlu süreçler varken hafif ve orta düzeydeki rahatsızlıklar için genelde uygun beslenme şekli ve gerekliyse hafif ilaçlarla tedavi mümkün olabilmektedir.\n\n\n" +
             " Sindirim Sistemi Hastalıklarında 4 Beslenme Tedavisi;\n\n- Sindirim sistemi hastalıklarında beslenme çok önemlidir. Uygun öğün listeleri ile başlangıç seviyesindeki rahatsızlıklar tedavi edilebilmekte ya da kontrol altına alınabilmektedir. Sindirim sistemi sağlığı için en önemli nokta dengeli ve doğal beslenmektir.\n\n\n" +
             " 1) Asitli Gıdalardan Uzak Durun\n\n" +
             "- Asitli, gazlı gıdalardan ve içeceklerden, yağlı ve aşırı baharatlı yemeklerden uzak durun.\n\n" +
             "- Kahve ve çay gibi kafeinli içecekleri olabildiğince azaltın.\n\n\n" +
             " 2) İşlenmiş Et, Kızartma ve Kafein Tüketmeyin\n\n" +
             "- Kafeinli içecekler, asitli gıdalar ve içecekler, zeytin, hardal, çemen, işlenmiş etler, kızarmış tüm yemekler, yağlı ve aşırı baharatlı yiyecekler, alkol, turşu, soğangiller ve domatesi doktor kontrolünde kontrollü tüketin ya da hiç tüketmeyin.\n\n\n" +
             " 3) Mide Sorunu ve İshal Durumunda Muz, Patates Tercih Edin.\n\n" +
             "- Yağsız, hafif, nişasta içeriği yüksek besinler tüketin.\n\n" +
             "- Muz, patates, pirinç lapası iyi seçeneklerdir.\n\n" +
             "- Su kaybından kaynaklı sorunların önüne geçmek için bol bol su için.\n\n\n" +
             " 4) Mide Sorunu ve Kabızlık Durumunda Posalı Besinler Yeyin\n\n" +
             "- Lifli ve posalı besinler tüketin.\n\n" +
             "- Yeşil sebzeler yiyebilirsiniz.\n\n" +
             "- Özellikle sabah aç karnına kuru kayısı, kuru incir yemeniz faydalı olacaktır.\n\n" +
             "- Sindirim sistemini rahatlatmak için anason gibi bitki çaylarından destek alabilirsiniz.\n";

        }
        if (urun == "Siroz")
        {
            urunResmi.sprite = burakResimler[80];
            baslik.text = " Siroz ";

            konu.text = " Siroz Nedir?\n\n- Kronik karaciğer hastalığı olarak da adlandırılan siroz, karaciğerde ileri derecede hasar oluşumuna verilen isimdir. Çeşitli hastalıklar nedeniyle, bazense bilinmeyen sebeplerden dolayı karaciğerde farklı düzeylerde hasar meydana gelebilir. Bunun sonucunda karaciğerin yapısal fonksiyonlarında çeşitli bozulmalar oluşur ve normal işlevlerini yerine getirememeye başlar. Bu durum, siroz sürecinin başlangıcıdır. Süreç ilerledikçe işlevine devam eden karaciğer hücrelerinin azalması sonucunda karaciğer giderek sertleşmeye ve küçülmeye başlar. Sertleşen dokulara kanın akışı zorlaşır ve kanın dokuya ulaşamaması sebebiyle yeni damar yolları oluşur. Tüm bu olaylar karaciğeri daha da olumsuz etkileyerek siroz tablosunu ağırlaştırır. Sonuç olarak karaciğer fonksiyonunu yerine getirememeye başlar ve karaciğer yetmezliği ortaya çıkar.\n\n\n" +
             " Siroz Belirtileri Nelerdir?\n\n- Siroz hastalığı, erken dönemde genellikle belirti vermez. Fakat hastalığın derecesi ilerledikçe ve karaciğerde oluşan harabiyet düzeyi arttıkça görülen belirtilerde ve bu belirtilerin şiddetinde artış gözlenir. En sık görülen siroz belirtileri aşağıdaki gibi sıralanabilir:\n\n" +
             "- İştah ve kilo kaybı\n\n" +
             "- Bulantı ve kusma\n\n" +
             "- Sürekli halsizlik hissi\n\n" +
             "- Bacaklarda şişme ve ödem oluşumu\n\n" +
             "- Karında asit birikimi nedeniyle şişme\n\n" +
             "- Kas kaybı\n\n" +
             "- Kansızlık\n\n" +
             "- Kanın pıhtılaşmaması\n\n" +
             "- Kadınlarda adet düzensizliği\n\n" +
             "- Ciltte morarma ve kanamalar\n\n" +
             "- Sinirlilik hali\n\n" +
             "- Kabızlık ve gaz sorunu\n\n" +
             "- Midede ağırlık hissi\n\n\n" +
             " Siroz Nedenleri Nelerdir?\n\n" +
             "- Sirozun bilinen en yaygın sebebi kronik alkol kullanımıdır. Aşırı alkol kullanımının haricinde en önemli siroz nedenlerinden bir tanesi de Hepatit B ve Hepatit C gibi kronik viral hepatitlerdir. Siroz hastalarının yaklaşık %10-15'lik bir kısmında ise yapılan tüm araştırmalara rağmen herhangi bir nedene rastlanılamamakta ve bu duruma nedeni belli olmayan siroz hastalığı (kriptojenik siroz) denmektedir. Bunların haricinde aşağıdaki nedenlerden dolayı da kişilerde nadir de olsa siroz hastalığı gelişebilir:\n\n" +
             "- Alkol kaynaklı olmayan karaciğer yağlanmaları\n\n" +
             "- Safra yollarının tıkanması ve iltihaplanması\n\n" +
             "- Vücudun kendi dokularına karşı antikor üretmesi sonucunda oluşan otoimmün hepatitler\n\n" +
             "- Ağır ilaçların uzun süreli kullanımı\n\n" +
             "- Demir ve bakır minerallerinin aşırı alımı\n\n" +
             "- Karaciğer sirozu; hastalığın ilerleme seviyesine göre A, B ve C olarak 3 seviyeye ayrılır. Karaciğerin daha az hasar almış olduğu A ve B seviyesindeki hastalarda düzenli hekim kontrolü ve tedavi sonucunda hastalığın ilerleyişi minimuma indirilerek uzun yıllar boyunca kaliteli bir yaşam sağlamak mümkün olabilmektedir. Uzman hekimler tarafından uygulanan tedavilerde öncelikle amaç karaciğerdeki sertleşmiş skar dokusunun ilerleyişinin önüne geçmek ve hastalığın yol açmış olduğu komlikasyonları önlemektir. Karaciğere yük oluşturabilecek her türlü besinden, gereksiz ilaç kullanımından ve alkol tüketiminden kaçınmak siroz hastalarında en önemli tedavi ilkesini oluşturur. Siroz otoimmün kaynaklı ise bağışıkık sistemini baskılayan ilaçlar ile tedavi, viral hepatitlerden kaynaklanıyorsa antiviral ilaç tedavisi uygulanır. İleri düzey karaciğer harabiyeti olan C seviyesindeki siroz hastalarında ise hekim önerisi ile karaciğer nakli gerekebilmektedir. Eğer siz de siroz hastalığına sahip iseniz düzenli olarak kontrollerinizi yaptırarak ve hekim tarafından önerilen tedavi ilkelerini uygulayarak hastalığın ilerleyişini önleyebilir, yaşam kalitenizi artırabilirsiniz.\n\n";

        }
        if(urun == "Sivilce")
        {
            urunResmi.sprite = burakResimler[81];
            baslik.text = " Sivilce ";

            konu.text = " Yüzde Çıkan Sivilceler Nasıl Geçer?\n\n" +
             "- Dermatoloji bölümü öğretim görevlisi Joshua Zeichner, yağ bezlerinin her saniye aktif olduğunu ve bu yağ bezlerinin toz, makyaj ve çevresel faktörlerin yol açtığı kirlilik ile birleşince çok daha zararlı hale geldiğini belirtiyor, bu sebeple yüzdeki sivilcelerin geçmesi için önce bu durumu önlemek gerektiğini ifade ediyor. Spor yapan insanlar için durum daha ciddi oluyor. Zeichner, yağ bezlerinden salınan sebumun kir ve ter ile birleşip kıl follikülleri içinde birikip kalabileceğini söylüyor. Bu durumda duş alınamasa bile en azından temiz bir havluyla bölgeyi kurulamanın önemli olduğunun altını çiziyor." +
             " Yüzdeki sivilcelerden kurtulmak için önce bu ilk basamak temizlik önlemlerini almak gerektiğini belirtiyor.Tüm dermatologların uyardığı bir diğer konu ise yüzdeki sivilcelerin geçmesi için sivilcelere asla el sürülmemesi ve sivilcelerin patlatılmaması gerektiğidir. Çünkü eğer sivilce patlatılırsa, iyileşme süresi çok daha uzun olacaktır ve patlatılan sivilcenin yaraya dönüşme olasılığı da artacaktır.\n\n\n" +
             " Yanakta Çıkan Sivilceler Nasıl Geçer?\n\n" +
             "- Yanakta çıkan sivilcelerle uğraşırken önemli önlemlerden biri yatılan yerde kullanılan çarşafları haftada en az bir defa değiştirmektir. Cildi temiz tutmanın en kolay yöntemlerinden biri de budur. Sivilce oluşumuna daha müsait olan ciltler için ise kullanılan yastığın üstüne temiz bir el havlusu yayıp kullanılması doktorlar tarafından öneriliyor. Bu havluyu her gün değiştirmek ve yastık kılıfını da sıklıkla yenilemek sivilce oluşumunu engellemeye yardımcı olacaktır. Uzun saç kullananların ise gece uyurken saçlarını bağlaması tavsiye ediliyor. Böylelikle saçlar yanaklara temas etmeyecek ve bu bölgelerin hava alması kolaylaşacaktır.\n\n" +
             "- Kullanılması gereken yüz temizlik ürünlerine gelince; cildi tahriş etmeyen, kurutmayan ve yağlandırmayan bir yüz temizleme ürünü gereklidir. Bu ürünün öncelikli amacı da yanaklardaki kiri ve yağı uzaklaştırarak yüzü temizlemektir. Cilt bakım ürünleri söz konusu olduğunda, komedojenik olmayan  yani gözenekleri tıkamayan  ve cildi tahriş etmeyen temizleyici ve nemlendirici ürünler kullanmak gerekmektedir.\n\n" +
             "- Erkekler için yüzü tıraş etmek her zaman dikkatlice yapılması gereken bir şeydir. Çünkü erkeklerin sakalları gün be gün uzadığı için gözenekler daha kolay iltihaplanır ve sivilcelerin geçmesi zorlaşabilir.\n\n" +
             " Batık kılları ve sivilceleri geçirmek için şu adımlar dikkatle izlenmelidir:\n\n" +
             "- Gözenekleri açmak için yüz ılık su ile yıkanmalıdır,\n\n" +
             "- Cilt tipine uygun bir tıraş kremi araştırılarak bulunmalı ve kullanılmalıdır,\n\n" +
             "- Çoğu cilt tipi için tek bıçaklı tıraş bıçağı gözeneklerin ölü deriler ile tıkanmasını önler, bu yüzden tercih edilmelidir,\n\n" +
             "- Tıraş yapılırken her zaman kılın uzama yönüne doğru yapılmalıdır. Tıraşın ters yöne yapılması tahrişe sebep olabilir ve batık kıl oluşumunu artırabilir.\n\n" +
             "- Yağlanma ve sivilce problemi yoğunsa sivilce önleyici temizleme jeli tıraş köpüğü olarak kullanılabilir.\n\n" +
             "- Tahrişi azaltmak için jilet yerine elektrikli tıraş makinesi veya trimmer kullanımı tercih edilebilir.\n\n\n" +
             " Burunda Çıkan Sivilceler Nasıl Geçer?\n\n" +
             "- Düzenli bir cilt bakım rutini sürdürmek, cildi temiz tutmanın ve T bölgesindeki fazla yağlardan arınmanın anahtarıdır. Bunların yanında burunda çıkan sivilceleri (akneleri) geçirmek ve önlemek için yapılacak ekstra adımlar da vardır:\n\n" +
             "- Günde iki defa kaliteli bir yüz temizleme jeli ile yüz temizlenmelidir,\n\n" +
             "- Fazla yağı ve kiri arındırmak için tonik kullanılmalıdır. İlaçlı tonikler normallerine ek olarak sivilceleri (akneleri) tedavi etmeye de yarar, bu yüzden tercih edilmelidir,\n\n" +
             "- Cilt tipi için uygun olan nemlendirici kullanımı ile yağ bezelerinin oluşumu yavaşlar ve böylece sivilce (akne) oluşumu da azalır. Ancak burun en yağlı deri bölgesidir, kurutucu ürünler veya tedavilerle birlikte burunda kuruma kolay kolay oluşmaz. Bu nedenle sivilceli (akneli) ﻿ciltte bu bölgenin nemlendiriciye ihtiyacı çok azdır." +
             " Haftada bir ya da iki kez kil maskesi yapılmalıdır.Böylece burundaki tıkanmış gözenekler kaybolur ve gözeneklerin daha küçük görünmesi sağlanır,\n\n\n" +
             " Sırtta Çıkan Sivilceler Nasıl Geçer?\n\n" +
             "- Sırttaki sivilceleri geçirmek için spor alışkanlıklarına, saç modellerine ve güneşin zararlı ışınlarına dikkat edilmelidir. Eğer gerekli şekilde davranılırsa, sırtta çıkan sivilceler kolaylıkla ortadan kalkabilir. Spordan hemen sonra duş almak, sırtta oluşabilecek sivilceleri önlemenin veya oluşmuş olanlar varsa bunları geçirmenin en iyi yoludur. Sporda kullanılan kıyafetler de her egzersizden sonra yıkanmalı ve öyle kullanılmalıdır.\n\n" +
             "- Duş süngeri ile cildi temizlemek bir başka etkili yöntemdir. Duş süngeri ile cildi nazikçe temizlemek ölü deriyi yok eder ve cilde hava aldırır.\n\n" +
             "- Sırttaki sivilceleri (akneleri) geçirmek için bol kıyafetler giymek de bu süreç için iyi bir yöntemdir. Çünkü dar giysiler kirin ve terin vücuda yapışıp kalmasına sebep olabilir. Bu yüzden gözenekler tıkanmış olur böylece sırtta daha fazla sivilce (akne) oluşur. Üste giysi giymeden spor aletleriyle egzersiz yapmak da bir o kadar zararlıdır. Bu yüzden spor süresince cilde nefes aldıran ve terlemeyi azaltan bol kıyafetler giyilmelidir.";

        }
        if (urun == "Sivrisinek")
        {
            urunResmi.sprite = burakResimler[82];
            baslik.text = " Sivrisinek ";

            konu.text = "- Doğada hiçbir şey gereksiz olarak yaratılmamıştır. Her yaratılanın bir hikmeti vardır. Yaz aylarımızı kabusa çeviren sivrisineklerin bile yaratılmasında sayısız hikmet vardır. Hep beraber bunlara göz atalım;\n\n" +
             " Besin Kaynağı Olarak Sivrisinekler\n\n" +
             "- Sivrisinekler pekçok hayvanın ana besin maddelerinden biridir ki, bu doğada ekosistemi sağlar. Her ne kadar faydası yok gibi görünseler de sivrisinekler de doğanın bir parçasıdır ve ekosistemde onlar da başka bir canlı tarafından yenmekte ve bu sayede doğal döngü devam etmektedir. Sivrisinekler onu yiyen hayvanlar için iyi bir protein kaynağıdır. Bu hayvanlara örnek olarak kuşlar, balık, haşarat, yarasalar, amfibiler ve sürüngenler verilebilir.\n\n" +
             "- Doğal dögünün parçası olan sivrisineklerin neslinin tükenmesi özellikle de bazı bölgelerde göç yolu olan kuşların %50’sinin çok önemli ve hayati bir besin kaynağının sonu olacaktır. Sivrisineklerin çoğalması çok hızlı gerçekleşir ve dünyanın her yerinde yaşama potansiyelleri vardır. Bu yüzden yer yüzünde yer alan birçok yarasa, örümcek ve kuş çeşidi için ana besin kaynağı bol protein içeren sivrisineklerdir. Sivrisineklerin bu doğal döngüden çıkarılmaları ekosistemin bozulmasına sebep olur. Bu yüzden bilinmelidir ki dengeli bir doğa yaşamı için sivrisineklerin varlığı önemlidir.\n\n\n" +
             " Teknolojik Faydası\n\n- Doğada yaradan tarafından yaratılan birçok canlı ve bitki insanlara ilham olmaktadır. Sivrisinekler de bacak ve kanat hareketleri açısından incelenen ve günümüz teknoloji mühendisleri önemli cihazları tasarlarken sivrisineklerin kanat hızının uyumu gibi birçok yeteneğinden ilham almaktadır. Buna en iyi ve en modern örnek drone yani insansız hava araçlarıdır.\n\n" +
             "- Sivrisinek ısırığı çoğunlukla hissedilmez. Bunun sebebi ise sivrisineğin ısıracağı bölgeyi ısırmadan önce uyuşturmasıdır. Sivrisinek tükürüğünde bulunan anestezik özellikler incelenmiş ve daha sonra bu salgı tıpta tedavi için uyuşturmak için başvurulan lokal ve topikal anesteziklere sentetik şekilde karıştırılmıştır. Ek olarak diyabet hastalığının tedavisindeki sivrisineğin ağzındaki dokunaçlara benzer bir cihaz kullanılır ve bu cihaz kan şekeri ölçümünün daha acısız yapılmasına olanak sağlar.\n\n\n" +
             " Sivrisinekler Atıkları Giderir\n\n" +
             "- Sivrisinek larvaları suda yaşayan bir tür böcektir ve bu böcekler suda yaşayan balık gibi birçok hayvan için faydalı bir besin kaynağıdır. Sivrisinel larvaları sivrisinek yumurtalarının gelişmiş halidir ve larvalar ise 7-10 gün içinde yetişkin sivrisinekler olmaktadır. Sivrisinekler larvalarının faydası ise doğadaki parazit, alg, mantar ve farklı mikroorganizmaları yemesidir ve bu sayede doğadaki canlı dengesini sağladığı bilinmektedir.\n\n\n" +
             " Bitkileri Tozlaştırır\n\n" +
             "- Sivrisineklerin bitkileri tozlaştırmaya etkisi de vardır. Sivrisinekler ömürlerinin neredeyse tamamında çevrelerinde bulunan su bitkilerinin tozlaşmasına katkı sağlamaktadır. Diğer bir deyişle, sivrisineğin yardımcı olduğu bu tozlaşma bitkilerin yaşamlarının devamına yardımcı olur ve bitki çeşitliliği sağlar.  Ekosistemdeki hayvan ve bitki çeşitliliği çok önemlidir ve fonksiyoneldir.\n\n";
             
        }
        if (urun == "Siyatik")
        {
            urunResmi.sprite = burakResimler[83];
            baslik.text = " Siyatik ";

            konu.text = "\n- Siyatik ağrısı, insan vücudunun en kalın siniri olan siyatik sinirinin sıkışması ile ortaya çıkıyor. Toplumda “Siyatik” olarak bilinen bu rahatsızlığın en önemli belirtilerini ise bacakta ağrı, uyuşma ve karıncalanma oluşturuyor.  Ağrı sebebiyle yaşam konforunun önemli ölçüde düşmesine neden olan siyatik rahatsızlığının tedavi edilmemesi ise bacakta ve ayakta kalıcı sorunlar ile felç gibi durumlara neden olabiliyor.\n\n\n" +
             " SİYATİK NEDİR?\n\n- Siyatik insan vücudundaki en kalın sinirin adıdır ve latince adı nervus ischiadicu tur. Bu sinir kalça arkasından bacağın arka yüzü boyunca seyrederek diz üstü seviyede iki ana kola ayrılır ve ayağa kadar ulaşır. Fakat bir hastalığı ifade etmek için toplumda yaygın olarak kullanılan siyatik kelimesi ile bu sinirin vücutta çeşitli yerlerde sıkışmasıyla ortaya çıkabilen ve özellikle bacakta ağrı, kuvvet kaybı, kasılma, uyuşma, karıncalanma gibi şikayetlerle kendini gösteren bir rahatsızlık kastedilmektedir.\n\n\n" +
             " SİYATİK BELİRTİLERİ NELERDİR?\n\n- Özellikle kalça arkasından uyluk, baldır hatta topuk ve ayak tabanına kadar yayılabilen şiddetli, bıçak saplanır tarzda keskin veya künt vasıflı ya da kramp benzeri ağrı en sık görülen belirtidir. Bu ağrı yürümekle, öne eğilmekle artabilir. Bunun yanında bacakta ve ayakta uyuşma, karıncalanma gibi his kusurları görülebilir. Siyatik sinirdeki sıkışmanın derecesine bağlı olarak sinirin uyardığı kaslarda kuvvet kaybına bağlı yürüme güçlükleri de görülebilir.\n\n\n" +
             " SİYATİK NEDEN OLUR?\n\n- En sık neden siyatik sinirin omurilikten çıkan sinir köklerinin omurga seviyesinde çeşitli nedenlerle sıkışmasıdır. Bu nedenler arasında bel fıtığı, omurga kanal darlığı, omurgada kireçlenme, omurga şekil bozuklukları, omurga kırıkları, omurga tümörleri sayılabilir. Siyatik sinir omurga haricinde kalça arkasındaki “piriformis” kası veya tendonu tarafından da sıkıştırılarak benzeri şikayetlere sebep olabilir. Bunların dışında siyatik sinirin seyri boyunca bacakta herhangi bir seviyede herhangi bir sebeple sıkışması da bu belirtilere yol açabilmektedir.\n\n\n" +
             " SİYATİK NASIL TEŞHİS EDİLİR?\n\n- Siyatik hastalığının tanısında en önemli iki şeyden birincisi hekimin hastalığın başlangıcı, seyri, şikayetlerin sıklığı ve bu şikayetleri nelerin ortaya çıkardığı ile alakalı hastanın anlatacağı hastalık öyküsünü detaylıca kaydetmesi ve bu öykü doğrultusunda yapılacak olan tıbbi muayenedir. İkinci aşama da öykü ve muayene bulguları ışığında gerekli tetkiklerin yapılmasıdır. Bu tetkikler arasında EMG denilen sinir iletim hızı testleri, MR veya diğer radyolojik görüntüleme yöntemleri ve gerek görüldüğü durumlarda çeşitli laboratuvar tahlilleri sayılabilir.\n\n\n" +
             " SİYATİK TEDAVİSİ NASIL UYGULANIR?\n\n- Tedavi siyatik sinirin sıkıştığı seviyeye, sıkışmanın nedenine ve hastanın genel tıbbi durumuna göre değişkenlik gösterir. Omurgadaki sıkışmalarda (sıklıkla bel fıtığı veya kanal darlığı nedeniyle) sıkışma bölgesine yapılacak enjeksiyon tedavileri veya direkt olarak siniri sıkıştıran yapıları ortadan kaldırmak üzere yapılacak cerrahi tedaviler seçenekler arasındadır. Bu tedavilere ek olarak fizik tedavi, siyatik egzersizleri ve ilaç tedavilerinden de faydalanılmaktadır. Omurga dışındaki siyatik sinir sıkışmalarında da benzeri şekilde enjeksiyon tedavileri, cerrahi tedavi, fizik tedavi yöntemleri ve ilaç tedavilerine başvurulur. Özellikle ileri dereceli sıkışmalarda bacakta kuvvet kaybı da eşlik ediyorsa kalıcı siyatik sinir hasarı riskini olabildiğince azaltmak için acil cerrahi müdahale gerekebilmektedir.\n\n\n" +
             " Siyatik ağrısı ne kadar sürer?\n\n- Siyatik ağrısının süresi oldukça değişkendir. Sadece birkaç gün sürüp kendiliğinden geçebildiği gibi aylarca sürebilen ağrılar şeklinde de görülebilir.\n\n\n" +
             " Siyatik ağrısı nerelere vurur?\n\n- Tipik olarak kalça arkasından başlayan bir ağrı şeklinde tarif edilir. Kalçadan sadece diz arkasına yayılabildiği gibi topuğa hatta ayak ucuna kadar tüm bacak boyunca yayıldığını tarif eden hastalar da olabilmektedir. Ayrıca bacağa yayılan ağrı ile birlikte kalçadan bele doğru vuran ağrı da olabilir.\n\n\n" +
             " Siyatik tedavi edilmezse ne olur?\n\n- Özellikle ciddi siyatik sinir sıkışmalarında bir müddet sonra sinir, fonksiyonunu yitirmeye başlayabilir. Bunun sonucunda da bacakta, ayakta kalıcı his kusurları ve kalıcı kuvvet kaybı, yürüme kusurları, düşük ayak, felç gibi durumlar oluşabilir. Bu gibi gecikmiş olguların tedavisi daha kompleks cerrahi tedaviler gerektirebilir ve sonuçları erken dönemde yapılan tedavilere göre hasta açısından daha az tatmin edici olabilmektedir.\n\n\n" +
             " Siyatik ağrısı için hangi doktora gidilir?\n\n- Siyatik sinir sıkışması omurga seviyesinde ise omurga cerrahisi uzmanı (ortopedi ve travmatoloji, nöroşirurji) tedavi sürecini yönetecektir. Kalça veya bacak seviyesindeki sinir sıkışmalarında da gene ortopedi ve travmatoloji uzmanına başvurmak gerekmektedir. Fizik tedavi ve rehabilitasyon uzman doktorunun düzenleyeceği bir fizik tedavi süreci de bütüncül yaklaşım içerisinde yerini alabilmektedir. Bunların dışında siyatik sinirde cerrahi veya girişimsel müdahale gerektirecek bir mekanik sıkışmanın olmadığı fakat sinirde fonksiyonel bir kusur bulunması durumunda nöroloji uzman doktoru da tedavi sürecine dahil olabilmektedir.\n";

        }
        if (urun == "Soğan")
        {
            urunResmi.sprite = burakResimler[84];
            baslik.text = " Soğan ";

            konu.text = "- Soğan, frenk soğanı, sarımsak ve pırasa da içeren Allium bitki ailesine aittir. Bu sebzelerin karakteristik keskin aromaları ve bazı tıbbi özellikleri vardır.\n\n" +
             "- Soğanlar boyut, şekil, renk ve lezzet bakımından farklılık gösterir. En yaygın türleri kırmızı, sarı ve beyaz soğandır. Bu sebzelerin tadı, genellikle yetiştirildiği ve tüketildiği mevsime bağlı olarak değişebilir.\n\n" +
             "- Soğan doğramanın gözlerin sulanmasına neden olduğu yaygın bir bilgidir. Bununla birlikte, soğan sağlığa çok faydalıdır. Soğan, çeşitli kanser türlerinin riskini azaltma, ruh halini iyileştirme ve cilt ve saç sağlığını koruma gibi kişilerin sağlığında büyük rol oynar.\n\n\n" +
             " Soğan Hangi Vitaminleri Neleri İçerir?\n\n- Soğan  özellikle A vitamini, C ve B vitaminleri açısından önemli bir kaynaktır. Ayrıca kükürt, iyot, kalsiyum, demir, folat, magnezyum, fosfor, potasyum ve antioksidanlar açısından da zengindir.\n\n" +
             "- A vitamini hem enfeksiyonlara karşı bağışıklığı hem de göz sağlığını destekler B vitaminleri ise suda eriyen vitaminlerdir. B vitamini bağışıklık ve sinir sisteminin düzgün çalışmasına yardımcı olur. C vitamini ise özellikle kış mevsiminde hastalıklardan korunmaya destek olmaktadır.\n\n\n" +
             " Soğan Nasıl Tüketilir?\n\n- Yemeklerde pişmiş olarak arpacık, beyaz ve kuru soğan tercih edilirken taze yeşil, kırmızı ve mor soğan ise salata veya yemeklerin üstünde çiğ olarak kullanılır.\n\n" +
             "- Özellikle kış mevsiminde havaların değişmesiyle bağışıklık sistemi zayıf düşmektedir. Virüslere ve bakterilere karşı doğal antibiyotik görevi gören soğan zayıflayan bağışıklık sisteminin kuvvetlenmesini destekler. Soğan içerdiği sülfür (kükürtlü maddeler) sayesinde antibakteriyel etki oluşturmaktadır. Yetişkin ve çocuklar çok rahat bir şekilde soğan tüketebilir.\n\n\n" +
             " Soğan Hangi Hastalıklara Faydalıdır? Soğanın Faydaları Nelerdir?\n\n" +
             "- Yapılan çalışmalar soğanın içerdiği kuarsetin adlı antioksidan sayesinde yumurtalık, kolorektal gibi kanser türlerine yakalanma riskini azaltmaya yardımcı olduğunu göstermektedir. Özelikle kırmızı soğan, vücuttaki sağlıklı hücrelere zarar veren serbest radikalleri ortadan kaldıran antioksidan maddeleri, kuru ve beyaz soğana göre daha fazla bulundurmaktadır.\n\n" +
             "- Ayrıca soğanın içindeki kuarsetin, alerjik reaksiyonlara yol açan histaminin bağışıklık hücrelerinde salınımını engellemesine yardımcı olur. Böylelikle soğanın astım veya alerjik problemleri olan kişilerde bağışıklığı desteklemeye yardımcı olduğu bilinmektedir. Soğanının içeriğindeki kükürt kan inceltici etkisi göstererek kalp kriziyle inme riskini artıran plateletlerin birikimini önler. Soğandan alınan kükürtün hipertansiyon başlangıcını geciktirme ve azaltmaya yardımcı olduğu diğer çalışmalarla tespit edilmiştir.\n\n\n" +
             " Soğanın Kansere Olan Faydaları Nelerdir?\n\n- Yapılan çalışmalarda allium sebzeleri özellikle mide ve kolorektal kanserlerle ilgili olarak kapsamlı bir şekilde incelenmiştir. Asya Pasifik Klinik Onkoloji Dergisi'nde 2019 yılında yapılan bir araştırma, kolorektal kanserli 833 kişiyi, hastalığı olmayan 833 kişiyle karşılaştırmıştır. Araştırmacılar, soğan gibi allium sebzelerini düzenli olarak tüketenlerde kolorektal kanser riskinin %79 daha düşük olduğunu bulmuşlardır.\n\n" +
             "- Bir fincan doğranmış soğan ayrıca bir yetişkinin tavsiye ettiği günlük C vitamini alımının en az %13,11'ini sağlamaktadır. Bir antioksidan olarak bu vitamin, kanserle bağlantısı olan serbest radikal bileşiklerinin oluşumuna karşı koymaya yardımcı olur.\n\n" +
             "- Yine de soğandaki hangi bileşiklerin kansere karşı koruyucu etkileri olduğunu doğrulamak için daha fazla araştırma yapılması gerekmektedir.\n\n\n" +
             " Soğan Nasıl Saklanmalıdır?\n\n- Toplum olarak kuru soğanı saklarken en sık yapılan hatalardan biri patates ile aynı ortamda muhafaza etmek veya depolamaktır. Çünkü patatesin yaydığı nem soğanın filizlenmesine ve çürümesine yol açar. Kuru soğanı serin ve kuru bir ortamda saklamak uzun süre taze şekilde tüketilmesini sağlar. Yarım kalan kuru soğanlar ise cam saklama kabına koyarak buzdolabında muhafaza edilebilir.\n\n" +
             "- Taze soğanı ıslak olarak buzdolabına koymak yapılan diğer hatalardan biridir. Öncelikle tazeliğini kaybetmiş yapraklar varsa temizlenmeli daha sonra kağıt havluya sarılarak buzdolabında saklanmalıdır. Böylelikle taze soğanın daha uzun taze kalması sağlanabilir.\n\n\n" +
             " Soğanı Yağda Kavurmak Zararlı Mı?\n\n- Tüketirken soğanı yağda kavurmak yapılan en büyük hatalardan biridir. Yağda kavurma esnasında yağ yanar. Yağ yandığı için kanserojen maddeler daha çok ortaya çıkar. Kızartmada olduğu gibi soğanı da yağda kavurmak sağlıklı değildir. Soğanlı yemek yapılırken tüm sebzeler tencere birlikte çiğden konularak yapılmalıdır. Sebzelerin pişme esnasında saldıkları su ile de zaten soğan pişmektedir. Etli bir yemek yapılırken de eti sotelerken yine etin bıraktığı su ile soğan kendi halinde pişmektedir.\n\n\n" +
             " Soğan Tüketmek Mide ve Bağırsak Rahatsızlıklarını Tetikler Mi?\n\n" +
             "- Soğan, mide ve bağırsak hassasiyeti olan bireylerde rahatsızlık verebilir. Soğan mide ve bağırsaklarında herhangi bir şikayeti olmayan kişilerde yanma gibi rahatsızlıklara yol açmaz. Eğer bir kişinin reflü, gastrit veya bağırsak intoleransı gibi rahatsızlıkları varsa soğan tükettiği zaman bu hassasiyetleri artabilir. Soğan çok lifli ve sülfürden zengindir dolayısıyla gaz gibi gastrointestinal şikayetleri artırabilir. Soğan zarı da şikayetlerin oluşmasında rol oynayabilir. Mide ve bağırsak hassasiyeti olanların çiğ soğan yerine pişmiş soğan tüketmeleri önerilir.\n\n";

        }
        if (urun == "Su")
        {
            urunResmi.sprite = burakResimler[85];
            baslik.text = " Su ";

            konu.text = "\n- Su, oksijenden sonra insan yaşamında en önemli yere sahip olan maddedir. Dünya üzerindeki bütün canlıların yaşamını sürdürebilmesi için gerekli iki temel unsur bulunmaktadır; oksijen ve su. Bu bakımdan su, biyolojik yaşamın sürdürülmesini sağlayan temel bir unsur olarak tanımlanabilmektedir.\n\n" +
             "- Yetişkin bir insanın vücut ağırlığının yaklaşık olarak %50-70’ini su oluşturmaktadır. Bu oran, yaşa, kiloya, boy uzunluğuna ve kişinin fiziksel etkinliğinin derecesine bağlı olarak değişim gösterebilmektedir. Ortalama olarak, erkeklerde vücut ağırlığının %60’ını, kadınlarda vücut ağırlığının %50’sini ve çocuklarda vücut ağırlığının %65-75’ini su oluşturmaktadır. Yaşın ilerlemesiyle birlikte vücuttaki su oranında azalma meydana gelmekte ve aynı doğrultuda yağ oranı artış göstermektedir. Bu bakımdan vücutta meydana gelen yaşlanma etkilerinde de suyun önemi oldukça fazladır.\n\n\n" +
             " İnsan Vücudu ve Su\n\n- İnsan vücudunda bulunan kas dokuları, yağ dokularından daha fazla oranda su içermektedir.\n\n" +
             "- Vücudumuzda bulunan suyun, 2/3’ü hücrelerin içinde yer almakta, geri kalanı ise damarlarda, dokular arasında, sindirim sisteminde ve vücut boşluklarında bulunmaktadır.\n\n" +
             "- Hayati nitelikte pek çok fonksiyona sahip olan vücut sıvılarının (kan, mide salgısı, tükürük, gebelikte oluşan amniyotik sıvı, idrar) büyük kısmını su oluşturmaktadır.\n\n" +
             "- Su, besinler ve içecekler yoluyla vücuda alınmakta, alınan su sindirim sisteminde emildikten sonra kana karışmaktadır. Kan dolaşımı ile vücuda dağılan su, kılcal damarlardan çıkarak doku sıvısını oluşturmaktadır. Hücre içerisinde bazı kimyasal tepkimelere katılan su, tekrar hücre dışına çıkarak doku sıvısına dönüşmekte ve dokular yoluyla kan dolaşımına katılmaktadır. Kan dolaşımı aracılığıyla böbreklere gelen suyun büyük bir kısmı idrar olarak vücut dışına atılmaktadır. Bir kısmı ise, deri, solunum ve sindirim sistemi tarafından kullanılarak vücuttan atılmaktadır.\n\n" +
             "- Vücutta su tutulumu, vazopressin adı verilen hormon yoluyla sağlanmaktadır. Beyin, hipotalamusta sentezlenen vazopress hormonu ile, vücuttaki su tutulumunu düzenlemektedir. Vücutta suyun azaldığını ve susama hissini oluşturan algılayıcı ve uyarıcı hücreler de vücutta beyin kısmında bulunmaktadır.\n\n\n" +
             " Suyun Vücuttaki Önemi ve Görevleri\n\n" +
             "- Su, beyin, omurilik ve diğer organların dış etkenlerden korunmasını sağlamaktadır.\n\n" +
             "- Ağız, burun ve göz dokularını nemlendirmektedir.\n\n" +
             "- Akciğerdeki hava, vücuttaki su yardımıyla nemlendirilmekte, bu durum solunuma yardımcı olmaktadır.\n\n" +
             "- Su, vücut ısısının dengede tutulmasını sağlamaktadır.\n\n"+ 
             "- Günlük yeterli su tüketimi, metabolizmayı hızlandırmaktadır.\n\n" +
             "- Besinlerin sindirilmesinde ve enerjiye dönüştürülmesinde su önemli bir yere sahiptir.\n\n" +
             "- Su, atık ve toksik maddelerin vücuttan atılmasına yardımcı olmaktadır.\n\n" +
             "- Kan hacmi ve basıncı, su ile dengelenmektedir. Kanın vücuttaki akışkanlığını su sağlamaktadır.\n\n" +
             "- Su, oksijen ve besin öğelerini hücrelere taşıyarak, hücrelerin fonksiyonlarını sağlıklı şekilde gerçekleştirebilmeleri için gerekli olan katı maddelerin çözünmesini sağlamaktadır.\n\n" +
             "- Kasların dengesi ve eklemlerin kayganlığı su ile sağlanmaktadır.\n\n" +
             "- Vücutta oluşan ödemlerin atılmasında su önemli bir rol oynamaktadır.\n\n\n" +
             " Günlük Su Tüketimi ve Vücut Dengesi\n\n" +
             "- Yetişkin bir insanın günlük su ihtiyacı yaklaşık olarak 2500 ml kadardır. Ancak bu miktar, sadece su olarak tüketilmesi gereken ihtiyacı oluşturmaktadır. Çay, kahve, meyve suyu gibi sıvı içeceklerin bazıları vücuttan su atılmasını arttırabileceği için, sadece su tüketiminin gerçekleştirilmesine dikkat edilmesi gerekmektedir.\n\n" +
             "- Vücutta, suyun vücuda alımı ve vücuttan atılması belli bir denge içinde gerçekleştirilmektedir. Temel olarak vücutta bulunan normal sıvı hacmi söz konusudur ve günlük olarak tüketilen suyun, vücuttaki sıvı hacmini koruması gerekmektedir.\n\n" +
             "- Vücutta bulunan sıvı hacminin korunması için, günlük sıvı alımının günlük sıvı kaybına eşit şekilde gerçekleşmesi gerekmektedir. Vücutta bulunan bu temel sıvı dengesinin bozulması durumunda ise, birtakım rahatsızlıklar ortaya çıkmaktadır.\n\n" +
             "- Vücut için yeterli miktarda ve nitelikte su tüketilmesi durumunda, vücudun ihtiyacı olan iz elementlerinin çoğu karşılanabilmektedir. Bu durum cildin güzelleşmesi ve bağışıklık sisteminin güçlenmesi olarak vücuda yansımaktadır. Yeterli ve nitelikli su tüketimi yoluyla; soğuk algınlığı, idrar yolu enfeksiyonları, böbrek taşları ve mesane kanseri oluşma riski düşmektedir.\n\n";
            

        }
        if (urun == "Su Çiçeği")
        {
            urunResmi.sprite = burakResimler[86];
            baslik.text = " Su Çiçeği ";

            konu.text = "\n- Su çiçeğinin tıbbi adı variselladır. Ergenlik çağından önceki çocuklarda yaygın olarak görülür. Hastalığın etkeni bir virüsdür. Bu hastalıkta komplikasyon nadirdir, genellikle kendiliğinden iyileşir. Su çiçeği bir kez geçirildikten sonra hayat boyu bağışıklık sağlar ancak nadir de olsa tekrarlayabilir. Su çiçeği aşısı uygulanmaya başladığından beri vaka sayısı oldukça azalmıştır. Aşılı bireyler su çiçeği geçirseler bile çok hafif atlatmaktadırlar. \n\n" +
             "- Su çiçeği en sık 5-10 yaşlarında, kış sonu ve ilkbahar aylarında görülür. Hastalık çok bulaşıcıdır. Bulaşma yolu insandan insana, damlacık ve havayolu iledir. Virüs tükürük bezlerinde bulunur ve kuluçka süresi 13-22 gündür. Su çiçeği geçiren bir kişi hastalık belirtileri başlamadan iki gün önce hastalığı bulaştırmaya başlar, bulaşıcılık yaralar kabuklanıncaya kadar devam eder.\n\n\n" +
             " Su Çiçeğinin Belirtileri Nelerdir?\n\n- Hastalığın tipik bulgusu içi su dolu döküntülerdir. Döküntüler başlangıçta berrak, daha sonra bulanık bir hâl alır. Döküntüler kaşıntılıdır ve gövdeden başlayarak yüz ve saçlı deriye ulaşır. Ağız içinde de döküntü görülebilir.\n\n\n" +
             " Su Çiçeği Kimler İçin Risklidir?\n\n" +
             "- Yaşamın ilk bir ayındaki bebekler.\n\n" +
             "- 28 haftadan önce doğan bebekler.\n\n" +
             "- 2 hafta yada daha uzun kortizon tedavisi alanlar.\n\n" +
             "- Kanser  hastaları: hastalık çok yaygın ve ağır seyreder.\n\n" +
             "- Bağışıklık sistemi baskılanmış olanlar.\n\n" +
             "- Gebelik: Hem su çiçeği ağır seyreder hem de zatürre yapabilir.\n\n\n" +
             " Su Çiçeğinde İstenmeyen Durumlar Nelerdir?\n\n" +
             "- Su çiçeği genellikle hafif geçirilen bir hastalık olmakla birlikte nadiren komplikasyon görülebilir. En sık görülen komplikasyon bakteriyel enfeksiyonlardır. Kaşınma ile birlikte derideki lezyonlar mikrop kapabilir. Apseye kadar ilerleyen cilt lezyonları olabilir. Çok nadiren kanda trombosit sayısı (kanın pıhtılaşmasını sağlayan kan pulcukları) düşebilir ve kanamalı bir hastalık ortaya çıkabilir. Yetişkinlerde ve bağışıklık sistemi baskılanmış olanlarda zatürre gelişebilir. Çok nadir görülen bir diğer komplikasyon da ensefalit denilen beyin iltihabıdır; ölümcül olabilir. Su çiçeği sinir sistemi ile ilgili değişik rahatsızlıklara yol açabilir. Çok nadiren su çiçeğinden sonra kalp zarlarında iltihaplanma, erkeklerde testis tutulumu, midede gastrit, böbrek iltihabı ve eklem iltihabı olabilir. Bağışıklık sistemi zayıf olanlarda organlara yayılım olur.\n\n\n" +
             " Su Çiçeği Tanısı Nasıl Konur?\n\n" +
             "- Su çiçeği deride çıkan döküntülerin şekline ve yayılımına göre tanınır. ELİSA ile bakılan antikor testi vardır.\n\n\n" +
             " Su Çiçeğinin Tedavisi Nasıl Yapılır?\n\n" +
             "- Hastalara bulgulara göre tedavi verilir. Ateş varsa ateş düşürücüler kullanılır ancak aspirin sakıncalıdır. Kaşıntılar için ağızdan ve sürülerek kullanılan kaşıntı gidericiler kullanılır. Bağışıklık sistemi baskılanmış kişilere antiviral tedavi başlanır. \n\n" +
             "- Su çiçeği ile temas etmiş duyarlı kişiler 72 saat içinde aşı yaptırırlarsa koruyucu olur. Rutin su çiçeği aşısı 12 aylıktan büyük bebeklere yapılır.\n\n\n" +
             " HASTALARA ÖNERİLER\n\n- Derideki kaşıntıyı azaltmak ve mikrop kapmasını önlemek için günlük banyo önerilir. Kese yapılmaz. Tırnaklar kısa kesilmelidir. Aspirin kullanılmamalıdır. Su çiçeği geçiren çocuğu hamile kadınlardan, yeni doğmuş bebeklerden, bağışıklık sistemi yetersiz insanlardan ve kortizon kullananlardan uzak tutmak gerekir. Su çiçeği geçiren çocukları döküntüler kabuklanana kadar okula veya kreşe göndermemek gerekir. \n\n";
            

        }
        if (urun == "Susam")
        {
            urunResmi.sprite = burakResimler[87];
            baslik.text = " Susam ";

            konu.text = "- Susam yüksek kaliteli protein içerir, bu protein kasların korunmasına ve gelişmesine yardımcı olur. \n\n" +
             "- Magnezyum mineralini içerdiğinden kan basıncını düşürmeye yardımcıdır.\n\n" +
             "- Yapılan çalışmalarda susam yağının diyabeti önleyebildiği ve diyabet hastalarında görülen plazma glikozunu düzenlemeye yardımcı olduğu bilinmektedir.\n\n" +
             "- Magnezyum mineralini içerdiğinden kan basıncını düşürmeye yardımcıdır.\n\n" +
             "- Yapılan çalışmalarda susam yağının diyabeti önleyebildiği ve diyabet hastalarında görülen plazma glikozunu düzenlemeye yardımcı olduğu bilinmektedir.\n\n" +
             "- Kolesterol üretimini engelleyen fitosteroller içerir. \n\n" +
             "- Yüksek lif içeriği bağırsak fonksiyonlarının düzenlenmesine yardımcıdır.\n\n" +
             "- Susam yüksek oranda çinko içerir. Bu özelliği ile kolajen üretimine destek olur. Cilde elastikiyet kazandıran susam, hasar gören hücreleri ve vücut dokularını da onarır.\n\n" +
             "- Susam yağı düzenli kullanıldığında cilt kanseri riskini azaltabilir.\n\n" +
             "- Sesamol adı verilen antioksidan ve iltihap karşıtı  bileşik sayesinde aterosklerotik lezyonları önleyerek kalp sağlığına fayda sağlar. \n\n" +
             "- Susam stres giderici mineraller olarak bilinen kalsiyum ve magnezyum içerir. Ayrıca sakinleştirici vitaminler de içermektedir. Bu sayede ruh halini iyileştirir, ağrıları azaltır ve derin bir uyku çekmenize yardımcı olur.\n\n" +
             "- Siyah susam demir bakımından çok zengindir. Halsizliği ve kansızlığı olan kişilere siyah susam önerilir.\n\n" +
             "- Eklem, kemik ve kan damarlarının güçlenmesine destek olur.\n\n" +
             "- Sağlıklı karaciğer fonksiyonunun devamlılığını sağlar, alkolün olumsuz etkisini azaltır. \n\n" +
             "- Bir avuç susam bir bardak sütten daha fazla kalsiyum içerir beraberinde yüksek çinko içeriği ile kemik mineral yoğunluğunu arttırır. Düzenli olarak susam tüketimi yaşlı bireylerde kemik erimesini (osteoporoz) önlemeye yardımcı olabilir. Yapılan bir çalışmada diyetle düşük çinko alımı ile kalça ve omurgada kemik erimesi arasında bir bağlantı olduğu gösterilmiştir.\n\n" +
             "- Cilt parlaklığı ve saç uzaması için gerekli kompleks B vitaminlerini içerir.\n\n\n" +
             " Susam Nasıl Kullanılır?\n\n" +
             "- En yaygın kullanım alanı sevilen yemeklerin üzerine serpiştirmektir. Ekmek ve kek yapımında veya salatalarda değerlendirilebilir. Herhangi bir alerjiniz yoksa günde 1 silme yemek kaşığı susam kullanımı uygundur. Çiğ tohumları çiğnemek en fazla fayda sağlar fakat sindirim bozukluğu yaşayanlar kolay sindirim için susamı geceden ıslatarak veya suda 4-5 saat bekleterek tercih edebilir. Hafifçe kavurmak veya dövmek de iyidir.\n\n\n" +
             " Susamın Yan Etkileri Nelerdir?\n\n" +
             "- Ağız yoluyla belirtilen miktarlarda (1 tatlı kaşığı – 1 yemek kaşığı gibi) alındığında genel olarak güvenlidir. Fazla miktarda kullanımı tansiyon veya kan şekeri düşüklüğüne sebebiyet verebilir. Susam yüksek oranda lif içerir, iyi huylu anastomoz darlığı olan kişilerde bağırsak tıkanması riskini artırabilir. Hamileyken veya emzirirken susam kullanımın güvenli olup olmadığını bilmek için yeterli güvenilir bilgi yoktur. Bu bağlamda güvenli tarafta kalın ve sadece yenebilen, yemekte olan miktarlar kadar tüketin.\n\n";

        }
        if (urun == "Su Teresi")
        {
            urunResmi.sprite = burakResimler[88];
            baslik.text = " Su Teresi ";

            konu.text = "- Turpgiller ailesinden olan su teresi, keskin kokusu, hafif mayhoş ve acımtırak tadı ile bilinir. Yemeklerin yanında veya sadece salata olarak tüketilebilen su teresi, aynı zamanda özütü çıkarılarak şifa kaynağı olarak da kullanılabilmektedir. Su teresi öyle bir bitkidir ki açık yaralardan tutun da cinsel rahatsızlıklara kadar her türlü soruna iyi gelmektedir. Özellikle her formda tüketilebilir olması, su teresini son derece değerli kılmaktadır.\n\n" +
             "- Genellikle bataklık gibi bol suyun olduğu bölgelerde yetişen bu bitki nemin yüksek olduğu yerlerde çok daha fazla büyüyebilir. İçinde barındırdığı kükürt, demir, potasyum, fosfor ve iyot gibi mineraller sayesinde çiğ veya pişmiş olarak tüketilmesi halinde, vücutta eksik olan çoğu maddeyi yeterli hale getirecektir. Sadece mineral değil, vitamin açısından da oldukça zengin olan bu bitkinin, dış yüzeyinin de şifalı bir yönü bulunmaktadır.\n\n" +
             "- Bitki yaprakları hiçbir işleme tabi tutulmadan harç formuna sokularak açık yaralara sürüldüğünde, sihirli bir merhem etkisi yaratarak iyileşme sağlamaktadır. Ayrıca cinsel gücü artırıcı etkisi bulunduğundan dolayı, sorunlu bireyler açısından da harika bir bitkidir. Su teresi adına yaraşır şekilde, su gibi bir bitkidir. Özellikle taze olarak tüketilen su teresi sofralarda insanın iştahını kabartacak kadar güzeldir.\n\n\n" +
             " Su Teresinin Faydaları Nelerdir?\n\n" +
             "- Su teresinin; urları (tümör) tedavi edici, zayıflatıcı, karaciğer düzenleyici, kanamaları önleyici, cinsel gücü artırıcı, regl döngüsü düzenleyici ve kardiyovasküler vakaları önleyici etkisi bulunmaktadır. Tüm bunların yanı sıra uzmanların yaptığı son çalışmalar kanserin önlenmesi üzerinde de olumlu etkisi olduğunu ortaya koymaktadır. Su teresi kaynatılarak cilde sürüldüğünde veya su teresi özü damlalar halinde cilde yedirildiğinde büyük şifa sağlamaktadır.\n\n" +
             "- Özellikle nasırlı gibi sert yüzeyleri güzelleştiren bu şifalı bitki, vücuttaki izlerin geçmesinde de etkilidir. Kış aylarındaki bir diğer faydası ise sürekli tıkanık olan burunları açmasıdır. Su teresi nefes yollarını temizleyerek tıkanıklıkların önüne geçer ve sinüzit gibi rahatsızlıkları önler.\n\n" +
             "- C vitamini açısından zengin ve çok güçlü bir antioksidan olan su teresi kanser oluşumunu önler, kanser hücrelerinin yok olmasına yardımcı olur. Kanserin en önemli nedeni olan serbest radikallerle savaşır.\n\n" +
             "- Yine C vitamini ve folik asit içeriği ile bağışıklık sisteminin kuvvetlenmesini sağlar. Yıl içerisinde, mevsiminde taze olarak tükettiğiniz su teresi sayesinde, özellikle grip benzeri hastalıklara daha az yakalandığınızı görebilirsiniz.\n\n" +
             "- Beyin fonksiyonlarını geliştirerek alzheimer benzeri hastalıkların oluşumunu önler. Bu bitkinin beyindeki nöron aktivitesini artırdığı tespit edilmiştir.\n\n" +
             "- Kalsiyum içeriği nedeniyle dişlerin daha sağlıklı olmasını sağlar. Aynı zamanda kemik gelişimine yardımcı olur.\n\n" +
             "- Kötü kolesterolü düşürür, kalp ve damar hastalıklarını önler. Yine dolaşım sistemi hücrelerine zarar veren serbest radikallerle savaşmak da su teresinin faydaları arasında yer almaktadır.\n\n" +
             "- Bildiğiniz gibi hamileliğin daha ilk aylarında, doktorlar anneye folik asit vermektedir. İşte su teresi doğal bir folik asit kaynağı olduğu için bu süreçte oldukça faydalıdır. Fakat her ihtimale karşı doktorunuza danışmadan tüketmemenizi öneririz.\n\n" +
             "- Katarakt gibi göz hastalıklarının oluşumunu önler, aynı zamanda gözlerin daha sağlıklı ve iyi görmesini sağlar.\n\n" +
             "- Zihni açarak, kavrama kabiliyetinin gelişmesine yardımcı olur.\n\n" +
             "- Su teresini kaynatarak elde ettiğiniz su hem cilde hem de saçlara iyi gelmektedir.\n\n" +
             "- Esasen hiçbir zararı olmayan su teresi, her şeyde olduğu gibi aşırı kullanıldığı takdirde bir takım yan etkiler doğurabilmektedir. Bağırsakları çalıştırdığından çok fazla su teresi yenirse ishal olunabilir. Adet düzenleyici etkisi olduğundan gebe kadınların yememesi önerilir. Gebelik esnasında menstruasyon döngüsünü başlatacağı için, düşüğe yol açabilir.\n";

        }
        if (urun == "Sürme")
        {
            urunResmi.sprite = burakResimler[89];
            baslik.text = " Sürme ";

            konu.text = "\n- Göz vücudun önemli organlarından biridir. Eskiden beri göz sağlığını korumak için her türlü doğal yola başvurulmuştur. Peygamber Efendimiz zamanında gece sürülmesi tavsiye edilen doğal sürme de bu yöntemlerden biridir. Doğal sürmenin bir çok çeşidi bulunur fakat Efendimiz göz sağlığı için en faydalısının “İsmid taşı” olduğunu buyurmuştur. Bu taş içerdiği; antimuan, sülfür ve çinko maddeleri sayesinde son yıllarda bilim insanlarının da dikkatini çekmiştir.\n\n" +
             "- Peygamber Efendimiz, İsmid taşından yapılan doğal sürmeyi gece yatmadan önce kullanılmasını tavsiye etmesinin nedeni ise uyurken vücut hücrelerini daha sağlıklı yeniler.\n\n\n" +
             " Doğal Sürmenin Göze Faydaları\n\n" +
             "- Gözde oluşma ihtimali olan iltihabı önler.\n\n" +
             "- İçerdiği antimon maddesi kirpikleri uzatır ve sıklaştırır.\n\n" +
             "- Aynı zamanda içerisinde bulunan çinko maddesi de görme yetisini artırır.\n\n" +
             "- Gün boyu gözde biriken tozu ve kiri temizler.\n\n" +
             "- Güneş ışınlarına maruz kalmış ve deforme olmuş göz hücrelerini yeniler.\n\n";
             

        }
        if (urun == "Süt")
        {
            urunResmi.sprite = burakResimler[90];
            baslik.text = " Sütün Faydaları ";

            konu.text = 
             "\n Daha Güçlü Kemik Yapısı Oluşmasını Destekler\n\n" + 
             "- Güçlü bir iskelet oluşturmak ve bebeklikten yetişkinliğe (ve menopoza) kadar sağlıklı kemiklerin korunması hayati önem taşır. Süt osteoporozu, kemik kaybını ve oluşabilecek çeşitli kemik zayıflıklarını önler. Ergenlik çağının başlarındaki en yüksek büyüme seviyesi sırasında, vücuda günde 400 mg kadar kalsiyum gerekir. Gerekli olan bu kalsiyum miktarı, en kolay şekilde sütten alınabilir.\n\n" +
             "- Ayrıca kemik sağlığını artırmak için D vitamini ve magnezyum da ihtiyacınız olduğunu unutmayın. Bu özellikle menopoz dönemindeki kadınlar için çok önemlidir. Menopoz döneminde oluşan östrojen dalgalanmaları kemik yoğunluğunda azalma gibi olumsuz etkiler meydana getirebilir.\n\n\n" +
             "- Mide Rahatsızlıklarını ve Hazımsızlığı Tedavi Eder\n\n" + 
             "- Sütünün yaklaşık %3’ü proteindir. Bu proteinin %80’i kazeinden oluşur. Kazeinin birincil rolü alınan mineralleri hedef bölgelere taşımaktır. Kazein, kalsiyum ve fosfora bağlanır ve onları sindirim sistemine iletir. Sütün faydaları arasında midedeki sindirim sularının salınmasını uyarma, sindirimi hızlandırma ve mideyi rahatlatma vardır.\n\n\n" +
             " Diyabet Riskini Azaltır\n\n" +
             "- Süt kalsiyum, magnezyum ve peptitler açısından zengin bir besindir. Bu bileşenler vücuttaki glikoz toleransını ve insülin duyarlılığını dengelemeye yarar.\n\n\n" +
             " Bağışıklığı Güçlendirir\n\n" +
             "- Süt, çinko ve D vitamini gibi bazı besin maddeleri nedeniyle bağışıklık sistemini destekler. Ayrıca kalp için de faydalıdır. Bir bardak süt kandaki iyi kolesterol (HDL) seviyesini artırabilir. Süt, vücudun genel metabolizmasının sağlığını artırmada önemli olan iyi yağlar bakımından zengindir.\n\n";
            
        }
        if (urun == "Spor")
        {
            urunResmi.sprite = burakResimler[91];
            baslik.text = " Spor ";

            konu.text = "\n- Öncelikle halk dilinde “spor yapmak” olarak bahsedilen konuya ışık tutalım:\n Spor, içinde mücadele veya rekabet içeren çoğunlukla fiziksel aktiviteleri kapsayan bir olgudur. Halk arasında “spor yapmak” olarak dile getirilen olgu ise çoğunlukla fiziksel bir etkinliğe ya da egzersiz yapmaya karşılık geliyor. Örnek vermek gerekirse karşılıklı bir mücadele ve rekabet içeren “satranç” da bir spordur. Ancak evde yaptığınız bir fitness egzersizi, spor değildir.\n\n" +
             "- Egzersiz yapmanın ve onu günlük hayatın bir parçası haline getirerek bir rutin oluşturmanın zihinsel ve fiziksel olarak kanıtlanmış sayısız faydası bulunuyor. Farklı uzmanlık alanlarından birçok bilim insanı, hala bugün bile ulaştıkları araştırma ve test sonuçları ile egzersiz yapmanın insan vücuduna olan pozitif etkilerini kanıtlamaya devam ediyor.\n\n\n" +
             " Bireysel Olarak Yapılabilir\n\n- Egzersiz yapmak için fitness salonuna gitmek veya ekipmanlar edinerek ağır antrenmanlar gerçekleştirmek zorunda değilsiniz. Egzersiz yapmanın en güzel taraflarından biri de budur. Evde, kişisel alanınızda yapmaya başlayacağınız düzenli egzersiz, kısa süre içerisinde metabolizma hızında artış, vücut yağında azalma, fiziksel görünüşte iyileşme ve daha zinde hissetme gibi birçok faydasının olacağını görebilirsiniz. Üstelik, internet üzerinde mevcut olan birçok günlük egzersiz videosu, motivasyonu artırarak kendi programınızı düzenlemenize yardımcı olacaktır. Özellikle pandemi sürecinde boş zamanlarınızı spor yaparak en iyi şekilde değerlendirebilirsiniz.\n\n\n" +
             " Kilo Vermeye Yardımcıdır\n\n- Uzmanlar her fırsatta, kilo verme sürecinin sağlıklı beslenme alışkanlıkları ile birlikte düzenli egzersiz yaparak sağlıklı beslenmeyi destekleyen sporla kolaylaştığını ve uzun vadeli sonuçlar almak için iyi bir adım olduğunu dile getiriyor. Sizin için doğru beslenme ile doğru egzersizi birleştirerek hem fazla kilolarınızdan kurtulup hem de daha güçlü ve dirençli bir bünyeye sahip olabilirsiniz. Bu konuda bir beslenme uzmanı ve fitness eğitmeni ile çalışmanızı öneriyoruz.\n\n" +
             " Genç Kalmanıza Yardımcı Olur\n\n- Belli bir yaşa ulaştıktan sonra birçok bireyde metabolizmanın yavaşlaması ve sabahları baş gösteren halsizlik gibi bazı memnuniyetsizlikler gözlenmeye başlanır. Uzmanlara göre, düzenli olarak haftanın minimum 5 günü yarım saatlik yürüyüş yapan bireyler daha güçlü kaslara ve kalp-solunum sistemine sahip olur.\n\n\n" +
             " Her Yaşa Uygun Bir Egzersiz Mutlaka Var\n\n- Birçok konuda da olduğu gibi, egzersize küçük yaşlarda başlamak bu alanda ileri seviyelere ulaşmak için bir anahtar görevi görür. Ancak egzersize başlamak için hiçbir zaman geç kalmış sayılmazsınız. Teşhisi konmuş bir sağlık durumunuz varsa, başlamak istediğiniz aktivite veya spor branşını aile hekiminize ya da sağlık durumunuzu takip eden uzman doktorunuza danışmayı unutmayın.\n\n\n" +
             " Birçok Hastalığa Karşı Zamanında Önlem Almanıza Yardımcı Olur\n\n- Yaşlanma ile birlikte kan basıncında artış, kan yağlarında artış ve kalp damar hastalıkları ortaya çıkabilir. Bireyin yaptığı egzersiz ise birçok farklı rahatsızlığın önüne geçerek önlem almasına yardımcı olur. Düzenli olarak yapılan egzersiz, tansiyonu kontrol altına almanıza ve kan dolaşımınızın gelişimine katkı sağlar.Bu da çabuk yorulmanıza engel olur. Her şeyden önemlisi, düzenli egzersiz yaparak vücudunuzu dinlemeyi öğrenirsiniz. Ve böylece vücudunuzda gerçekleşen en ufak bir değişimi bile fark edebilirsiniz. Bu da birçok hastalık için erken tanı olanağı sağlar.\n\n\n" +
             " Düzenli Bir Hayata Olanak Sağlar\n\n- Egzersiz tadını alan herkes er ya da geç fark eder ki hayatlarında bir düzene ihtiyaç duyarlar. Çünkü hareketi hayatının merkezine almadan ve bir rutin oluşturmadan herhangi bir egzersiz branşını sürdürmek neredeyse imkansızdır. Egzersiz merkezli bir hayat planı da erken kalkmak, bireyin kendisine zaman ayırabilmesi gibi pek çok pozitif yönüyle birlikte gelir. Örneğin henüz öğlen olmadan birçok işin çoktan bitirilmiş olması, kişinin motivasyonuna büyük ölçüde katkı sağlar.\n";

        }
        if (urun == "Şalgam")
        {
            urunResmi.sprite = burakResimler[92];
            baslik.text = " Şalgam ";

            konu.text = "\n- Şalgam suyu, kalsiyum, C vitamini, A vitamini, E vitamini, manganez ve beta-karoten gibi antioksidanlar bakımından zengindir. Sindirim sistemi, kemik gelişimi, akciğer sağlığına faydaları vardır.\n\n" +
             "- Şalgamın faydaları saymakla bitmez. Güçlü bir antioksidan deposu olan şalgam kanser hastalığını önlemede de yardımcı olur. Bunun yanı sıra şalgam sindirim sisteminin de doğru çalışmasını sağlamaktadır.\n\n\n" +
             " Şalgamın Faydaları Nelerdir?\n\n - Adana'ya özgü bir lezzet olan şalgam vücuttan toksinleri atar.\n\n" +
             "- Lezzeti ile de öne çıkan şalgam bağırsak rahatsızlıklarını önlemeye yardımcı olur. \n\n" +
             "- Yüksek oranda C vitamini barındıran şalgam günlük C vitamini ihtiyacını da karşılamaktadır.\n\n" +
             "- İştah açıcı özelliği sayesinde kilo alamayan kişilerin düzenli olarak şalgam tüketmesi önerilir. Şalgam hızla kilo aldırır.\n\n" +
             "- Yüksek oranda potasyum, demir ve kalsiyum içeren şalgam kemik gelişimine de katkı sağlamaktadır.\n\n" +
             "- Şalgam sigaranın verdiği zararları en aza indirir. Bu sayede akciğerde meydana gelen hasarlar kısa sürede temizlenir.\n\n" +
             "- Şalgam organların da çok düzenli bir şekilde çalışmasına yardımcı olmaktadır.\n\n" +
             "- Şalgam sindirim sisteminin düzenli çalışmasını sağlayarak hazmı da kolaylaştırmaktadır.\n\n" +
             "- Şalgam genel olarak böbrek taşlarının düşürülmesine de yardımcı olur. \n\n" +
             "- Şalgam düzenli tüketildiği takdirde kötü kolesterolü düşürmektedir. \n\n" +
             "- Şalgam vücutta meydana gelen iltihapların da doğal yollar ile dışarı atılmasını sağlar. Aynı zamanda idrar söktürücüdür.\n\n" +
             "- Şalgamın doğru tüketildiği takdirde stresi azalttığı da görülür. \n\n"+
             "- Şalgam, vücutta terden dolayı oluşan kötü kokuların giderilmesine de yardımcı olmaktadır.\n\n";

        }
        if (urun == "Şam Fıstığı")
        {
            urunResmi.sprite = burakResimler[93];
            baslik.text = " Şam Fıstığının Faydaları ";

            konu.text = "\n B6 Vitamini Bakımından Zengin\n\n- Potasyum, fosfor, bakır ve B1 vitamini bakımından zengin olan Antep fıstığı, aynı zamanda B6 vitamini açısından da en zengin gıdalardan biri. B6 vitamini kan şekeri dengesizliğini düzenlerken, kan hücrelerine oksijen taşıyan hemoglobinin yapımında da görev alır.\n\n\n" +
             " Antioksidan Deposu\n\n- Çoğu kuruyemiş ve tohumdan daha fazla antioksidan içerir. Özellikle göz sağlığı için oldukça önemli iki antioksidan olan lutein ve zeaksantini en çok içeren kuruyemiştir. Bunların dışında Antep fıstığı, kansere ve kalp hastalıklarına karşı koruyucu etki sağlayan antioksidanlardan polifenol ve tokoferolü de içerir.\n\n\n" +
             " Damarlarınızı Korur\n\n- L-arjinin aminoasidi açısından oldukça zengindir. Bu sayede damar sağlığının geliştirilmesinde önemli bir rol oynar. L-arjinin aminoasidi vücutta nitrik oksite dönüştürülerek kan damarlarınızı genişletmeye, dolayısıyla kan basıncınızı düzenlemeye yardımcı olur.\n\n\n" +
             " Kalp Dostu\n\n- 1 porsiyonunda 12 gram yağ bulundurmasına rağmen hiç kolesterol içermediği için kalp dostudur. Bunun yanı sıra kan kolesterol seviyesini düşürerek koroner kalp hastalıkları riskini azaltır. Kalp sağlığını korumaya yardımcı olur.\n\n\n" +
             " Cildi Güzelleştirir\n\n- Antep fıstığı belirgin miktarda çoklu ve tekli doymamış yağ asitlerini içerdiği için cildi doğal yoldan nemlendirmeye yardımcı olur, yaşlanma karşıtı etki gösterir. Antep fıstığı kuruluğu ortadan kaldırmak için masaj terapisi ve aromaterapi gibi çeşitli terapilerde kullanılır. Ayrıca Antep fıstığında bulunan E vitamini antioksidan görevi görür ve cildi çeşitli cilt hastalıklarına yol açan UV ışınlarından korur. Dolayısıyla tüm bu faydalarını göz önünde bulundurarak Antep fıstığına mutfağınızda yer ayırın.\n\n";

        }
        if (urun == "Şap Hastalığı")
        {
            urunResmi.sprite = burakResimler[94];
            baslik.text = " Şap Hastalığı ";

            konu.text = "\n- Şap hastalığı çift tırnaklı hayvanların akut seyirli, çok bulaşıcı ve zoonotik karaktere sahip viral bir enfeksiyonudur. Hastalığın bulaşma oranı yüksek olup, hassas hayvan topluluklarında (popülasyonlarında) % 100'e kadar ulaşabilmektedir. Bu nedenle hastalık ekonomik, siyasi ve ticari yönlerden büyük önem taşımaktadır.  \n\n" +
             "- Hastalığın etkeni Picornaviridae familyasının Aphtovirus alt grubunda yer alan şap virusudur. Virusun O , A, C , SAT-1, SAT-2, SAT-3 ve ASİA 1 olmak üzere antijenik olarak farklı yedi ayrı serotipi bulunmaktadır. (O) serotipinin II, A serotipinin 32, C serotipinin 5, SAT I serotipinin I, SAT 2 serotipinin 3, SAT 3 serotipinin 4 , ASIA I serotipinin ise I alt tipi vardır. Serotipler arasında çapraz bağışıklık görülmemesi hastalıkla mücadeleyi güçleştirmektedir.  \n\n" +
             "- Virus fiziksel etkenlere karşı değişik duyarlılık göstermektedir. Isıya dayanıksız olup 37°C'de 12 saatte, 60-65°C de 1/2 saatte, 85°C de ise birkaç dakika da yıkımlanarak etkisiz hale gelmektedir. Ancak düşük ısı derecelerine ve ani donma ve çözülmelere karşı oldukça dayanıklıdır. Enfekte karkaslarda +4°C de 24-48 saatte laktik asit oluşumuna bağlı olarak hızla inaktive (etkisiz) olurken, kan, kemik iliği, lenf bezleri ve iç organlarda uzun süre dayanabilir ve ani dondurmalarda iskelet kaslarında da uzun süre aktif halde kalabilir.  \n\n" +
             " Virus çevre şartlarına da oldukça dayanıklı olup;  \n\n" +
             "- Yapağıda 24 gün\n\n" +
             "- Sığır derisinde 4 hafta\n\n" +
             "- Samanda 15 hafta\n\n" +
             "- Kepekte 20 hafta\n\n" +
             "- Toprakta 4 hafta\n\n" +
             "- Kuru ot ve danede 5 ay süreyle enfeksiyözitesini (bulaşma yeteneğini) koruyabilmektedir. \n\n" +
             "- Kimyasal etkenlere karşı dayanıksız olan şap virusu pH 7.0- 7.7 de etkilenmemekte (stabil olmakla) birlikte asit ve alkali şartlarda kısa sürede inaktive olmaktadır Hastalık direkt ve indirekt olarak yayılmaktadır. Hastalığın en belirgin yayılma yolu havada bulunan virusun solunum sistemi ile alınmasıyla olmaktadır. Enfekte veya kuluçka dönemindeki hayvanlar solunum, deri, sekret ve ekstretleri, süt ve sperma ile virusu saçmaktadır. Hastalık bulaşık (kontamine) hayvan ürünleri, bulaşık (kontamine) araç ve aletler, insan, yabani hayvanlar, kuşlar, rüzgar ve nakil araçları ile de bulaşabilmektedir. İnsanlar da ise enfekte hayvanlar ile temas veya enfekte et ve süt ürünleri ile enfeksiyonu nadiren aldıkları bildirilmektedir.Bu konuda Enstitümüze herhangi bir başvuru olmamıştır.  \n\n" +
             "- Sığırlarda ateş, iştahsızlık, depresyon ve süt veriminde azalma ilk klinik bulgulardır. 24 saat içerisinde salya akışı başlar ve dil-dişetinde veziküller şekillenir. Keseciklere (veziküllere) interdigital bölgede, koroner bölgede, meme derisinde, ağız ve burun mukozasında rastlanabilir. Veziküllerin yırtılması ile geniş ülseratif yaralar şekillenebilir. Dildeki yaraların (lezyonların) genellikle birkaç günde iyileşmesine karşın ayaklardaki ve nazal bölgedeki lezyonlar çoğunlukla ikinci (sekunder) bakteriyel enfeksiyonlara maruz kalırlar. Sekunder bakteriyel enfeksiyonlar sonucu pneumoni ve mastitis görülebilir, tırnak düşebilir.  \n\n" +
             "- Koyun ve keçilerde hastalık daha hafif seyirlidir. Hastalık koyunlarda genellikle topallık ile karakterizedir ve topallık süreklilik gösterir. Ağızdaki lezyonlar sığırlardaki lezyonlardan daha küçük ve daha kısa sürelidir. Genellikle hastalığın yol açtığı ekonomik kayıplar sığırlarınkinden daha düşüktür ve klinik bulgular ancak dikkatli bir gözlemle belirlenir.  \n\n" +
             "- Şap hastalığının ölüm (mortalite) oranı düşük olmakla birlikte genç hayvanlarda virusun kalpte yerleşmesi (lokalize) sonucu ölümle sonuçlanan myokarditis olguları görülebilir. Hastalığın bulaşma (morbidite) oranı ise yüksek olup, et ve süt verimlerindeki hızlı düşüşe bağlı ekonomik kayıplar önem taşımaktadır.  \n\n" +
             "- Klinik bulgular hastalıktan şüphe ettirmekle birlikte kesin tanı virolojik veya serolojik yöntemler kullanılarak konulmaktadır. Ayırıcı tanıda; topallık, mukozal erozyonlar, salya, nazal akıntı ve meme lezyonlarına yol açan enfeksiyonlar göz önünde bulundurulmalıdır.  \n\n" +
             "- Şap hastalığının kontrolü için uygulanan 4 ana strateji vardır. Bunlar: Kesim, Karantina ve Aşılamadır.\n\n\n" +
             " KESİM\n\n- Şap hastalığına yakalanmış hayvanların ve bunlar ile temas etmiş hayvanların kesime tabi tutulmasıdır. Amaç esas virus kaynağının tüketilmesi (eliminasyonu) ve virusun hayat seyrinin (siklusunun) kırılmasıdır. Bu yöntemin dezavantajı , büyük ölçüde hayvan kaybına neden olmasıdır. Şap hastalığının sporadik olarak seyrettiği aşılama programını bırakmış ülkelerde bu yöntem uygulanmaktadır. Ancak hastalığın yayılmasının (insidensinin) düşük olduğu ülkelerde ekonomik olan bu yöntem, hastalığın yaygın olduğu ülkelerde hem ekonomik değildir, hem de toplumsal kabulü oldukça güçtür.\n\n\n" +
             " KARANTİNA\n\n- Şap virusunun epidemiyolojik durumu ve edinilen deneyimler gözönünde bulundurulduğunda, sadece bu yöntem ile sonuç alınamayacağı açıktır. Ancak diğer yöntemler ile birlikte uygulandığında anlam taşımaktadır.\n\n\n" +
             " AŞILAMA\n\n- Amaç hastalığın yaygın olduğu ülkelerdeki hayvan topluluğunda (popülasyonunda) yüksek antikor düzeyinin sağlanmasıdır. Bu amaçla düzenli ve yoğun aşılama programları ile popülasyonda virusa karşı direnç sağlanması hedeflenmektedir. Ancak başarı sağlanabilmesi için karantina ve önleyici (profilaktik) önlemlere gereksinim vardır. Aşılama stratejisinin belirlenmesinde hastalığın epidemiyolojisi, çevresel faktörler, çiftçilerin kültür seviyesi gibi faktörler de önem taşımaktadır.\n";
            

        }
        if (urun == "Şaşılık")
        {
            urunResmi.sprite = burakResimler[95];
            baslik.text = " Şaşılık ";

            konu.text = "\n- Şaşılık, gözlerin aynı hizada olmaması ve farklı yönlere bakmasıdır. Senkronik göz hareketlerinde paralelliğin bozulması durumudur.\n\n" +
             "- Doğumdan itibaren çocuklar dış dünyadan gelen görsel uyarıları yaşlarına göre tecrübe etmeye başlarlar. Hayatın ilk aylarında itibaren her iki gözden gelen görüntüleri beyinde görme merkezinde birleştirerek derinlik hissi olarak da adlandırabileceğimiz 3 boyutlu görmeyi geliştirmeye başlarlar.\n\n" +
             "- Bu tecrübe döneminin ilk başlarında yani bebekliğin ilk 3 ayında ara ara ortaya çıkan şaşılıklar normaldir. Dördüncü aydan sonra devam etmesi ise göz sağlığı açısından dikkate alınmalıdır.\n\n\n" +
             " Nedenleri\n\n- Toplumun %2-4'ünde şaşılık görülmektedir. Bu durumun gelişiminde pek çok nedenin rol oynadığı düşünülmektedir:\n\n" +
             "- Genetik geçiş söz konusudur. Ailede şaşılık olanlarda risk daha fazladır.\n\n" +
             "- Annenin hamilelik döneminde geçirdiği hastalık, zor ve uzamış doğum, erken doğum, doğum sonrası travma, yüksek ateşli hastalık ve havale öyküsü olanlarda görülme ihtimali artmaktadır.\n\n" +
             "- Göz numarası yüksek olan bir çocukta, net görmeye çalıştıkça gözlerinde kayma ortaya çıkabilir.\n\n" +
             "- Ani başlayan göz kaymaları çok önemlidir. Göz içi veya kafa içi kitlelerin ilk habercisi olabilir.\n\n" +
             "- Görme ekseninde normalde saydam olması gereken kornea veya lensteki opaklaşmaların (çocukluk dönemi kataraktı) ilk bulgusu şaşılık olabilir. Böyle bir durumda gecikmeden bir göz muayenesi yapılmalıdır.\n\n" +
             "- Şaşılık ileri yaşlarda da ortaya çıkabilir. Daha önce şaşılığı olmayan bir kişide aniden ortaya çıktığında kişide çift görme ve dengesizliğe neden olur. Böyle bir duruma kontrol altında olmayan diyabet veya sistemik hipertansiyon gibi bazı sistemik hastalıklar neden olabileceği gibi, kafaiçi kitleler ve nörolojik hastalıklar da sebep olabilir.\n\n\n" +
             " Belirtileri\n\n- Aşağıdaki belirtileri fark eden bir aile, çocuğunu mutlaka göz muayenesine getirmelidir:\n\n" +
             "- Gözlerin senkronik normal hareketlerinin kaybolması\n\n" +
             "- Bir gözü özellikle ışıklı ortamlarda kısma\n\n" +
             "- Fotoğraflarda gözlerden yansıyan kırmızı reflenin sarıya dönmesi\n\n" +
             "- Başın ve/veya yüzün bir yöne çevrilmesi\n\n" +
             "- Yürümede sonradan gelişen dengesizlik\n\n" +
             "- Belirgin kaymalar dışarıdan bakıldığında rahatlıkla fark edilir. Düşük miktarlardaki kaymalar ise ailenin gözünden kaçabilir. Ambliyopi (göz tembelliği) ile sonuçlanabilecek bu durum bu yüzden geç tanı alabilir.\n\n\n" +
             " Tedavi Yöntemleri\n\n- Tedavi yönteminin seçimi şaşılığın tipi, hastanın yaşı, görme keskinliği gibi pek çok değişkene göre, hastaya özel olarak planlanır.\n\n\n" +
             " Çocukluk Döneminde Şaşılık Tedavisi\n\n- Şaşılık asla kendi kendine ve zamanla düzelmez. Bazı şaşılık tiplerinde gözlük kullanımı ile tamamen tedavi sağlanabilmektedir. Bu yüzden tedavinin ilk basamağı çocukta gözlük ihtiyacının doğru bir şekilde tespiti ve düzeltilmesidir.\n\n" +
             "- Görme tembelliğinin eşlik ettiği durumlarda gözlükle beraber göz kapama tedavisi iyi sonuçlar veren tedavilerdir.\n\n\n" +
             " Göz Kapama Tedavisi Nasıl Uygulanır?\n\n- Şaşılıkta hastanın yaşına ve görme tembelliğinin derinliğine göre, belirlenen süreler için sağlıklı göze kapama tedavisi planlanır.\n\n" +
             "- Yapışkanlı göz kapatma pedleri ile iyi gören göz, günün belli sürelerinde kapatılır ve hastanın tembellik olan gözü kullanması sağlanır. Kapama tedavisi sırasında hasta gözlüklerini de kullanmalıdır.\n\n" +
             "- Hekim tarafından önerilen sürenin sonunda görme keskinliğinde artış miktarı saptanır. Kapama tedavisinin gün içindeki süresi ve devam edilmesi gereken süre tekrar belirlenir.\n\n" +
             "- Gözlüğe rağmen kayma devam ediyorsa göz kaslarına düzeltme ameliyatı yapmak gerekebilir. Ameliyat öncesi ve sonrası gözlük kullanımına devam edilebilir. Görme tembelliği olan hastada ameliyat öncesi ve sonrası göz kapama tedavileri yapılmalıdır.\n\n\n" +
             " Yetişkin Dönemde Şaşılık Tedavisi\n\n- Yetişkin dönemde tedavide şaşılığın başlangıç dönemi dikkate alınır. Yetişkin dönemde yeni başlayan şaşılık her zaman çok önemlidir. Öncelikle şaşılığa neden olabilecek hastalıkların varlığı araştırılmalı ve bu hastalıklar tedavi edilmelidir.\n\n" +
             "- Bu dönemde, yeni başlayan şaşılık nedenli ortaya çıkan diplopi (çift görme) hastanın hayat kalitesini olumsuz etkiler.\n\n" +
             "- Yetişkinlerde şaşılık durumunda kayma miktarına göre tedavi planı yapılır. Prizmatik camlar, göze hareket veren kaslara Botulinium Toksin (botoks) enjeksiyonu veya şaşılık cerrahisi ile hastanın hem kayması hem de çift görmesi ortadan kaldırılabilir.\n\n" +
             "- Yetişkin yaşlarda şaşılık cerrahisi sonrası beynin adaptasyon merkezinin gözlerin yeni pozisyonuna uyum kabiliyeti azalır. Bu nedenle ameliyat sonrası bile çift görme gelişebilir. Yetişkinlerde bu açıdan ameliyat öncesi cerrahiye uygunluk açısından değerlendirme ve bilgilendirme çok önemlidir.\n\n";
            

        }
        if (urun == "Şeker")
        {
            urunResmi.sprite = burakResimler[96];
            baslik.text = " Şeker ";

            konu.text = "- Şeker genellikle zararları ile bilinen bir besindir. Ancak aşırıya kaçılmadığı müddetçe şekerin de birçok faydası bulunmaktadır. Besleyici birçok mineral içeren şekerin faydaları şöyle sıralanır:\n\n" +
             "- Enerji verir.\n\n- Düşük tansiyon problemini çözer.\n\n- Doğal besin maddeleri ve mineraller içerir, bunlar da sağlık için çok yararlıdır.\n\n- Beyin fonksiyonlarının çalışmasında yardım eder.\n\n- Şeker depresyonu tedavi eder.\n\n" +
             "- Şekerin faydaları ile zararları kıyaslandığında faydaları bir hiç olarak düşünülebilir. Şekerin çok fazla zararı vardır. Onlardan bazıları ise şunlardır:\n\n" +
             "- Cildin elastikliğini ve sıkılığını koruyan yapılara zarar vererek cildi kırıştırıyor.\n\n" +
             "- Yapılan araştırmalar sonucunda anlaşılıyor ki şeker tüketimi hafızayı zayıflatıyor. Aynı zamanda fazla şeker tüketimi dikkat bozukluğu ve öğrenme güçlüğüne de yol açıyor.\n\n" +
             "- Dişlerin çürümesine yol açıyor.\n\n" +
             "- Şeker tüketen bir kişi şeker tüketmeyen bir insana göre çok daha fazla kansere yakalanıyor.\n\n" +
             "- Şekerin en çok bilinen zararlarından birisi de kilo aldırmasıdır. Şeker tüketimi obeziteye yol açıyor.\n\n";
             

        }
        if (urun == "Şeker Hastalığı")
        {
            urunResmi.sprite = burakResimler[97];
            baslik.text = " Şeker Hastalığı (Diyabet) ";

            konu.text = "\n- Çağın hastalıkları arasında en ön sıralarda yer alan diyabet (şeker hastalığı), ölümcül birçok hastalığın oluşumunda birinci sırada rol oynayan ve dünyanın her yerinde çok yaygın olarak görülen bir hastalık türüdür. Hastalığın tam adı olan Diabetes Mellitus, Yunancada şekerli idrar anlamına gelir. Sağlıklı bireylerde açlık kan glukoz düzeyi 70-100 mg/dL aralığındadır. Kandaki şeker seviyesinin bu aralığın üzerine çıkması, genellikle diyabet hastalığına işaret eder.\n\n" +
             "- Hastalığın nedeni insülin hormonu üretiminin herhangi bir nedenle yetersiz olması veya hiç olmaması, ya da vücut dokularının insüline karşı duyarsız hale gelmesidir. Birçok farklı çeşidi bulunan diyabet hastalığının en yaygın görülen ve genellikle 35-40 yaş üzeri bireylerde ortaya çıkan türü Tip 2 diyabettir. Bir diğer adı insülin direnci olan Tip 2 diyabette pankreasta insülin üretimi yeterli olduğu halde hücrelerde insülin hormonunu algılayıcı reseptörlerin çalışmaması nedeniyle bu hormona karşı duyarsızlık gelişir. Bu durumda kan şekeri insülin tarafından dokulara taşınamaz ve kan glukoz düzeyi normalin üzerine çıkar. Bu durum ağız kuruması, kilo kaybı, çok su içme ve çok yemek yeme şeklinde belirtiler ile kendini gösterir.\n\n" +
             "- Birçok farklı önemli hastalığın oluşumunda birincil neden olarak karşımıza çıkan Tip 2 diyabette tedavi ilkelerine tam olarak uyulması büyük önem taşır. Uzun süre yüksek seyreden kan şekeri; kardiyovasküler sistem, böbrekler ve gözler başta olmak üzere tüm vücutta kalıcı hasarlara yol açtığından diyabet teşhisi konulan bireyler derhal diyabet eğitimi almalı, diyetisyen tarafından uygun görülen beslenme programına tam olarak uymalıdır.\n\n\n" +
             " Şeker Hastalığı (Diyabet) Nedir?\n\n- Halk arasında genel olarak  şeker hastalığı olarak tabir edilen Diabetes Mellitus, genel olarak kanda glukoz (şeker) seviyesinin normalin üzerine çıkması, buna bağlı olarak normalde şeker içermemesi gereken idrarda şekere rastlanmasıdır. Farklı türevleri bulunan diyabet hastalığı, ülkemizde ve dünyada en sık rastlanan hastalıklar arasında yer alır. Uluslararası Diyabet Federasyonu'nun sağlamış olduğu istatistiki verilere göre her 11 yetişkinden biri diyabet hastalığına sahip olmakla birlikte her 6 saniyede 1 birey diyabet kaynaklı sorunlar nedeniyle hayatını kaybetmektedir.\n\n\n" +
             " Şeker Hastalığı Belirtileri Nelerdir?\n\n- Diyabet hastalığı, bireylerde kendini üç temel belirti ile gösterir. Bunlar normalden fazla yemek yeme ve doymama hissi, sık idrara çıkma, ağızda kuruluk ve tatlılık hissi ve buna bağlı olarak aşırı su içme isteği olarak sıralanabilir. Bunun haricinde kişilerde görülebilecek diğer diyabet belirtileri şu şekilde sıralanabilir:\n\n" +
             "- Halsizlik ve yorgunluk hissi\n\n- Hızlı ve istemsiz kilo kaybı\n\n- Bulanık görme\n\n- Ayaklarda uyuşma ve karıncalanma şeklinde rahatsızlık hissi\n\n- Yaraların normalden daha geç iyileşmesi\n\n- Ciltte kuruluk ve kaşıntı\n\n- Ağızda aseton benzeri koku oluşumu\n\n\n" +
             " Şeker Hastalığı Nedenleri Nelerdir?\n\n- Şeker hastalığı nedenleri konusunda yapılan birçok araştırmanın neticesinde, diyabet hastalığında genetik ve çevresel nedenlerin birlikte rol aldığı sonucuna varılmıştır. Temelde Tip 1 Diyabet ve Tip 2 Diyabet olarak iki türü bulunan şeker hastalığında hastalığa neden olan etmenler bu türlere göre farklılık göstermektedir. Tip 1 Diyabet nedenleri arasında yüksek oranda genetik faktörler rol oynamakla birlikte kan şekerinin düzenlenmesinde görev alan insülin hormonunu üretimi yapan pankreas organına zarar veren virüsler ve vücut savunma sisteminin çalışmasındaki aksaklıklar da hastalığa sebep olan etmenler arasındadır. Bunun yanı sıra şeker hastalığının daha yaygın görülen türü olan Tip 2 diyabetin nedenleri arasında şu şekilde belirtilebilir:\n\n" +
             "- Obezite (aşırı kilo)\n\n- Ebeveynlerde diyabet öyküsünün bulunması\n\n- İleri yaş\n\n- Hareketsiz yaşam tarzı\n\n- Stres\n\n- Gebelik sırasında gestasyonel diyabet oluşumu ve normalden yüksek doğum ağırlıklı bebek dünyaya getirme\n\n\n" +
             " Şeker Hastalığı Çeşitleri Nelerdir?\n\n\n" +
             " Tip 1 Diyabet (İnsüline bağımlı diyabet)\n\n- Genellikle çocukluk döneminde ortaya çıkan, pankreasta insülin üretiminin yetersiz olması veya hiç olmaması kaynaklı ve dışarıdan insülin alımının zorunlu olduğu diyabet hastalığı türü.\n\n\n" +
             " Tip 2 Diyabet\n\n- Hücrelerin kan şekerini düzenleyen insülin hormonuna karşı duyarsızlaşması sonucunda görülen diyabet hastalığı türü.\n\n\n" +
             " Latent Autoimmune Diabetes in Adults (LADA)\n\n- İleri yaşlarda görülen, otoimmün (bağışıklık sistemindeki çalışma bozukluğu sebebiyle vücudun kendi kendine zarar vermesi) kaynaklı Tip 1 diyabet benzeri insüline bağımlı diyabet hastalığı türü.\n\n\n" +
             " Maturity Onset Diabetes (MODY)\n\n- Erken yaşta görülen Tip 2 diyabet benzeri diyabet hastalığı türü.\n\n\n" +
             " Gestasyonel Diyabet\n\n- Gebelik sırasında gelişen diyabet hastalığı türü.\n\n" +
             "- Yukarıda belirtilen diyabet türleri haricinde halk arasında gizli şeker hastalığı olarak adlandırılan pre-diyabet dönemi, Tip 2 diyabet oluşumunun öncesinde kan şekerinin diyabet tanısı koymak için yeterli yükseklikte seyretmeden hafif bir yükseklik eğiliminde olduğu, doğru tedavi ve diyet ile birlikte diyabet oluşumunun önüne geçilebildiği veya yavaşlatılabildiği döneme verilen addır. Şeker hastalığının en çok görülen iki çeşidi Tip 1 Diyabet ve Tip 2 Diyabettir.\n\n\n" +
             " Şeker Hastalığı Tanısı Nasıl Konulur?\n\n" +
             "- Diyabet tanısında kullanılan en temel iki test açlık kan şekeri ölçümü ve şeker yükleme testi olarak da bilinen Oral Glukoz Tolerans Testi (OGTT)'dir. Sağlıklı bireylerde açlık kan şekeri düzeyi ortalama 70-100 mg/Dl arasında değişkenlik gösterir. Açlık kan şekerinin 126 mg/Dl'nin üzerinde olması, diyabet tanısının koyulabilmesi için yeterlidir. Bu değerin 100-126 mg/Dl arasında olması durumunda bireye OGTT uygulanarak tokluk kan şekeri araştırılır. Öğün başlangıcından 2 saat sonra kan şekerinin ölçülmesi sonucunda kan glukoz seviyesinin 200 mg/Dl'nin üzerinde olması diyabet hastalığının, 140-199 mg/Dl aralığında olması gizli şeker adı verilen pre-diyabet döneminin göstergesidir. Bunların yanı sıra yaklaşık son 3 aylık kan şekerini yansıtan HbA1C testinin %7'den yüksek olması diyabet tanısını işaret eder.\n\n\n" +
             " Şeker Hastalığı Tedavisi Yöntemleri Nelerdir?\n\n" +
             "- Diyabet tedavi yöntemleri, hastalığın türüne göre farklılık gösterir. Tip 1 diyabette insülin tedavisi ile birlikte tıbbi beslenme tedavisi titizlikle uygulanmalıdır. Hastanın diyeti doktor tarafından önerilen insülin dozu ve planına göre diyetisyen tarafından planlanır. Besinlerin içerdiği karbonhidrat miktarına göre insülin dozunun ayarlanabildiği karbonhidrat sayımı uygulaması ile birlikte Tip 1 diyabetli bireylerin hayatı oldukça kolaylaştırılabilmektedir. Tip 2 diyabetli bireylerde ise tedavi beslenme düzeninin sağlanmasının yanı sıra genellikle hücrelerin insülin hormonuna duyarlılığını artırmaya veya doğrudan insülin hormonu salınımını artırmaya yönelik oral antidiyabetik ilaçların kullanılmasını içerir.\n\n" +
             "- Diyabet hastalığında dikkat edilmesi gerekenler ve önerilen tedavi ilkelerine uyulmadığı durumlarda kan şekerinin yüksek seviyelerde seyretmesi, başta nöropati (sinir harabiyeti), nefropati (böbreklerde hasar oluşumu) ve retinopati (göz retinasında hasar oluşumu) olmak üzere birçok sağlık sorununa yol açar. Bu nedenle eğer siz de diyabet hastalığına sahip bir bireyseniz, düzenli olarak kontrollerinizi yaptırmayı ihmal etmeyiniz.\n\n";
        }
        if (urun == "Şeker Kamışı")
        {
            urunResmi.sprite = burakResimler[98];
            baslik.text = " Şeker Kamışı ";

            konu.text = "\n Şeker Kamışı Nedir? Faydaları Nelerdir?\n\n- Şeker kamışı, buğdaygiller familyasından olan şeker elde edilen bir bitkidir. Genellikle sıcak ve tropikal iklimlerde yetişirler. Dünyada şeker üretiminde en çok kullanılan bitki şeker pancarıdır. Boyu yaklaşık 2-6 metre arasında olan lifli özellikte bir bitkidir.\n\n\n" +
             " Şeker Kamışı Nerede Kullanılır?\n\n- Belirli bir işlemden geçtikten sonra içerisindeki su çıkarılır ve kalan posa kısmı kağıt, ambalaj, karton gibi çevre dostu eşya yapımında kullanılır.\n\n" +
             "- Şeker kamışından elde edilen öz su ise şeker yapımında kullanılır. Suyu buharlaştırılığçeşitli işlemlerden geçtikten sonra şeker elde edilmiş olur.\n\n\n" +
             " Şeker Kamışının Faydaları\n\n- Şeker kamışı antioksidan açısından zengindir. Bu yüzden enfeksiyonlara karşı savaşır ve bağışıklığı artırır. Demir, magnezyum, kalsiyum ve diğer elektrolitler açısından zengindir. Soğuk algınlığı ve diğer enfeksiyonları iyileştirmeye yardımcı olur ve aynı zamanda  ateşle savaşır. Bunların yanı sıra, şeker kamışının suyu hakkında öğrenmeniz birkaç büyük yararı vardır:\n\n" +
             "- Şeker kamışının suyu, idrar yolu enfeksiyonlarını, böbrek taşlarını tedavi etmeye ve böbreklerin düzgün çalışmasını sağlamaya yardımcı olan bir diüretiktir. Ancak çok fazla miktarda tüketildiği takdirde böbreklere zarar verebilir.\n\n" +
             "- Şeker kamışının suyu karaciğerinizi güçlendirmeye yardımcı olur ve bu nedenle sarılık için önerilmektedir. Sarılık, vücut sıvılarında bilirubin olarak bilinen maddenin yükselmiş seviyeleri nedeniyle cildin sarı renkte olduğu bir hastalıktır ve kötü işleyen karaciğerin tetiklediği bir durumdur. Şeker kamışının suyu, vücudun hızlı bir şekilde iyileşmesi için gereken besinlerle doldurur.\n\n" +
             "- Şeker kamışının suyu, enerji içeceklerini ideal enerji değerine taşıyan karbonhidrat, demir, potasyum ve diğer temel besin maddeleri açısından zengindir. Özellikle yaz aylarında, bir bardak soğuk şeker kamışı suyu ve gerçekten hem sağlığınız hem de tükenmekte olan enerji düzeyleriniz için önemlidir. Plazma ve vücut sıvılarını oluşturur ve yorgunluğa yardımcı olur.\n\n" +
             "- Şeker kamışı suyunun, bağırsak hareketini iyileştirerek ve kabızlığı hafifleten,müshil özelliklere sahip olduğunu öne sürülmektedir; suyu da asitlik ve mide yanıkları tedavisinde iyi olduğu söylenen alkali özelliklere sahiptir .\n\n" +
             "- Şeker kamışının suyu, diş çürümesini ve kötü nefesi önlemeye yardımcı olan mineraller açısından son derece zengindir.\n\n";
             
        }
        if (urun == "Tansiyon")
        {
            urunResmi.sprite = burakResimler[99];
            baslik.text = " Tansiyon ";

            konu.text = "\n Tansiyon Nedir?\n\n" +
                "- Atardamarların içindeki kan basıncına tansiyon denir. Kapl kası kasıldığında atardamarlara kan pompalanır. Bu esnada ölçülen basınç sistolik basınçtır. Kalp kası gevşediğinde ise kan damarda durulur; bu esnada ölçülen basınç diastolik basınçtır. Tansiyon ölçümünde sistolik (büyük) ve diyastolik (küçük) kan basınçlarına bakılır. Tansiyon yüksekliğine hipertansiyon denir.\n\n\n" +
                " Hipertansiyon (Yüksek Tansiyon) Nedir?\n\n" +
                "- Tansiyon değerlerinin 140/90 mmHg nin üzerinde olması hipertansiyon olarak adlandırılır. Yüksek tansiyon bebeklik döneminden itibaren her yaşta görülebilir.\n\n\n" +
                " Hipertansiyon Nedenleri Nelerdir?\n\n" +
                "- Aşırı tuz tüketimi\n\n- Stres\n\n- Obezite\n\n- Kalp damar hastalıkları\n\n- Böbrek hastalıkları\n\n- Genetik faktörler\n\n- Tiroid hastalıkları\n\n- Böbrek üstü bezinin hastalıkları\n\n- Şeker hastalığı\n\n\n" +
                " Hipertansiyonun Belirtileri Nelerdir?\n\n" +
                "- Hipertansiyon yıllarca kendini göstermeyebilir. Aşikar hale geldiğinde ise baş ağrısı, burun kanaması, kulaklarda çınlama, halsizlik, sık idrara çıkma ve  bacaklarda şişlik şeklinde belirtiler verebilir. Bu belirtilerle birlikte tansiyon yüksekliği görüldüğünde mutlaka hekime başvurulmalıdır.\n\n\n" +
                " Hipertansiyon Tedavisi Nasıl Yapılır?\n\n" +
                "- Hipertansiyon hastalarında ilaç tedavisi yanı sıra yaşam tarzında değişiklik önerilir. Bu hastaların ideal kiloda olmaları, az tuz tüketmeleri, düzenli egzersiz yapmaları gerekir. Altta yatan hastalığın tedavisini yapmak esastır. Çok çeşitli tansiyon ilaçları piyasada vardır. Bunlardan hangisinin kullanılacağına hekim karar verecektir.\n\n" +
                "- Bazı hipertansiyon vakaları ilaç tedavisine kolay cevap vermez. Bu vakalara dirençli hipertansiyon denir. Dirençli hipertansiyon hastalarına şah damarı pili takılabilir.\n";



        }





    }
    
    
}

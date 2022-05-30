using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ali : MonoBehaviour
{
    #region Girisler
    public Sprite[] AliResimler;
    public Sprite[] AliResimler1;
    public Sprite[] AliResimler2;

    
    public Image urunResmi;

    public Text baslik, konu;
   

    string urunisim;


    #endregion

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


      
        #region    29.03
            if (urun == "Elma")
            {
                urunResmi.sprite = AliResimler[0];
                baslik.text = "Elma";
                konu.text = "\n- Zengin su içeriğinin yanı sıra birçok vitamin ve mineral içermektedir. Elmanın sağlığa faydaları; lifli yapısı (pektin) ve antioksidanlar (polifenoller, C vitamini) ile bağlantılıdır.\n\n" +
                "- Başta C, A, K, E ve B vitaminleri açısından zengin olan elma içerdiği mineraller ve eser elementlerle hem enerji verir hem de hücre koruyucudur. Zengin su içeriği ile vücudun düzgün çalışması için gerekli olan hidrasyonu sağlar.\n\n" +
                "- Elmayı ısırarak yemek ağız ve diş sağlığı için faydalıdır. Çiğneme periodontal hastalıklara karşı koruma sağlar.\n\n" +
                "- Elmanın zengin lif ve antioksidan bileşenleri kolesterol düşürücü etkileriyle kalp ve damar hastalıklarına karşı koruma sağlamakta, diyabet ve obezite oluşumunun önlenmesinde yardımcı olmaktadır.\n\n" +
                "- Elma çözünen ve çözünmeyen lif bakımında zengin bir içeriğine sahip olduğu için tok tutar, iştahı keser, bağırsakları çalıştırır, bağırsak sağlığını destekler ve kabızlığı önler. \n\n" +
                "- Antioksidanlar serbest radikallerin zararlı etkileriyle mücadele etme özelliğine sahiptir. Serbest radikaller hücrelerin erken yaşlanmasına neden olurlar.  \n\n";
            }
            if (urun == "Yulaf")
            {
                urunResmi.sprite = AliResimler[1];
                baslik.text = "Yulafın Faydaları";
                konu.text = "- Yulafın içerisinde yer alan mineral ve vitaminler kalp rahatsızlıklarını önler. Kötü kolesterolün düşürülmesinde yardımcı olur.\n\n" +
                               "- Enerji verir, tokluk hissi sağlayarak zayıflamayı sağlar.\n\n" +
                               "- Kolon kanserindeki risklerin azalmasını sağlar.\n\n" +
                               "- Zararlı hücrelerin büyümesini engeller.\n\n" +
                               "- Kabızlık ve kan şekerine iyi gelir.\n\n" +
                               "- Cilt sağlığı için fayda sağlar.\n\n";
            }
            if (urun == "Ayak Mantarı")
            {
                urunResmi.sprite = AliResimler[2];
                baslik.text = "Ayak Mantarı Nedir";
                konu.text = "- Ayaklarda kaşıntı ve parlak kırmızı döküntülere neden olan bir mantar enfeksiyonudur. Soyulma, kızarıklık, kaşınma, yanma, su toplama ve yaralara neden olur. Ayak mantar enfeksiyonu sık görülen ve aynı zamanda bulaşıcı olan bir deri hastalığıdır.\n \n" +
                             "- Lavanta Yağı: Ayak mantarının oluşturmuş olduğu koku ve kaşıntının önüne geçen lavanta yağı, sürekli kullanıldığı takdirde bu sorunu çözecektir.\n\n" +
                             "- Zeytinyağı ve Limon: Zeytinyağı ve limon suyu, ayak mantarına iyi gelecek bir çözüm yolu olarak belirtilebilir.\n\n" +
                             "- Beyaz sirke, vicks çay ağacı yağı: Beyaz sirke ve çay ağacı yaşı ile hazırlanan karışım.\n\n\n" +
                             " Ayak Mantarı Oluşumu Önlemek İçin\n\n" +
                             "- Ayaklar sık sık yıkanmalıdır.\n\n" +
                             "- Ortak kullanım sağlanan yerlerin zeminine çıplak ayaklar ile basılmamalıdır.\n\n" +
                             "- Teri emen ve pamuklu çorap giymeye dikkat edilmelidir.\n\n" +
                             "- Ortak havlu, ortak terlik gibi bireysel eşyalar ortak kullanılmamalıdır.\n\n" +
                             "- Törpü, tırnak makası gibi özel eşyalar tek kişilik kullanılmalıdır.\n\n";
            }
            if (urun == "Kepek")
            {
                urunResmi.sprite = AliResimler[3];
                baslik.text = "Kepeğe Çözümler";
                konu.text = "- Doğal İçerikli Şampuan: Tekrar eden kepek sorunlarını engellemek için saç derisindeki sebumu yani fazla yağı dengeleyen, peeling etkili şampuanlar tercih edilmelidir.\n\n" +
                               "- Eğer kepek sorunu, saç derisinin aşırı kuru olmasından kaynaklanıyorsa selenyum ve paraben içermeyen şampuanların kullanılması gerekir.\n\n" +
                               "- Çiçek Yağları: Yine saç derisini nemlendirmek için çiçek yağları ile masaj yapmak da faydalı olur.\n\n" +
                               "- Yoğun kepeklenme dönemlerinde fön, maşa ve düzleştirici gibi saç derisini iyice kurutacak olan işlemlerden kaçınmak gerekir.\n\n" +
                               "- Elma Sirkesi: Kepek nasıl gider doğal yöntemler sayesinde diye düşünüyorsanız, elma sirkesi derdinize deva olacaktır. Bir kasenin içine su doldurulur ve bir miktar sirke ile karıştırılır.\n\n" +
                               "- Banyodan çıkmadan hemen önce son durulama, bu su ile yapılır.\n\n" +
                               "- Doğal Yağlar: Saçtaki kepek nasıl giderilir sorusunun bir başka cevabı da şampuanınızın içine doğal yağlar katmaktır.\n\n" +
                               "- Her zaman kullandığınız şampuanın içerisine 20 damla nane yağı damlatılır.\n\n" +
                               "- Şampuanınızı bu şekilde kullanmaya başladıktan bir müddet sonra kepeğin kendiliğinden yok olduğuna şahit olursunuz.\n\n";
            }
            if (urun == "Zeytinyağı")
            {
                urunResmi.sprite = AliResimler[4];
                baslik.text = " Zeytinyağının Faydaları ";
                konu.text = 
                               "\n Karaciğeri Temizler\n\n- Karaciğer tüm vücudumuzu temizlemekte görevlidir. Zeytinyağı da karaciğeri. Vücudumuza giren toksinleri karaciğer salgılarıyla temizler. Zeytinyağı da karaciğerin fonksiyonunun artmasına yardımcı olur.\n\n\n" +
                               " Sindirimi Düzenler\n\n- Zeytinyağı yüksek oranda antioksidan içerir. Bu da sindirim sisteminizi düzenler ve bağırsakların düzenli çalışmasını sağlar. Günde bir yemek kaşığı oranında zeytinyağı tüketmeniz durumunda sindirim sisteminiz düzenlenecektir. Kabızlık yaşıyorsanız bu soruna çözüm olacaktır.\n\n\n" +
                               " Metabolizmayı Hızlandırır\n\n- Zeytinyağı tüketmeniz metabolizmanızı hızlandırır ve kilo vermenizi sağlar. Her gün zeytinyağlı salata tüketmeniz ve bunu öğün haline getirmeniz durumunda formunuzu korumanıza yardımcı olacaktır.\n\n\n" +
                               " Kemikleri Güçlendirir\n\n- Zeytin, yüksek oranda kalsiyum içerir. Kalsiyum kemiklerin yapı taşıdır. Bitkisel yağ olan zeytinyağı kemikleri güçlendirir ve korur. Zeytinyağı mineral bakımından da zengindir onun bu etkisi kemiklerin güçlenmesine katkı sağlar.\n\n\n" +
                               " Cildi Korur\n\n- Cildi korur ve yaşlanmayı geciktirir. Güzelleştirir ve pürüzsüz bir cilde sahip olmanızı sağlar. Makyaj malzemelerine karşın cildi kimyasallara karşı korur.\n\n\n" +
                               " Saç Bakımına Etkisi\n\n- Zeytinyağı saç bakımına da faydalıdır. Birçok saç bakım ürünlerinin içeriğinde zeytinyağı mevcuttur. Ancak evde çözüm olarak, zeytinyağını saçınıza duştan önce 15-20 dakika bekletirseniz saç dökülmesini azaltır ve canlı gözükmesini sağlar.\n\n\n" +
                               " Diyabete Etkisi\n\n- Zeytinyağı, kan şekeri seviyesini düşürür. Diyabet hastaları için insülin görevi görür ve sorunlara pozitif etki sağlar.\n\n\n" +
                               " Kan Basıncını Düzenler\n\n- Kan basıncını düzenler ve bu da tansiyonunuzun normal seviyede olmasını sağlar.\n\n\n" +
                               " Stresi Azaltır\n\n- Günde bir miktar zeytinyağı tüketmek, yorucu ve stresli hissettiğiniz zamanlarda size destek sağlayacaktır. Zeytinyağı aynı zamanda vücudunuzun enerjisini korur ve size canlılık katar. Sabah kahvaltınızda zeytin tabağına bir miktarda zeytinyağı döküp baharatlarla damak zevkinize göre tatlandırarak tüketebilirsiniz.\n\n";
            }
            if (urun == "Ayva")
            {
                urunResmi.sprite = AliResimler[5];
                baslik.text = "Ayvanın Faydaları";
                konu.text = "- Kilo vermeye katkı sağlıyor.\n\n" +
                               "- Bağışıklık sistemini güçlendiriyor.\n\n" +
                               "- Saçların uzamasına yardımcı oluyor.\n\n" +
                               "- Cildin genç kalmasına yardım ediyor.\n\n" +
                               "- Kanser riskini azaltıyor.\n\n" +
                               "- Kalp-damar sağlığını koruyor.\n\n" +
                               "- Bağırsak hastalıkları riskini azaltıyor.\n\n" +
                               "- Sindirime yardımcı oluyor.\n\n";
            }
            if (urun == "Böbrek Hastalıklarının Belirtileri")
            {
                urunResmi.sprite = AliResimler[6];
                baslik.text = "Böbrek Hastalıklarının Belirtileri";
                konu.text = "\n- Çabuk yorulma, bulantı, kusma.\n\n" +
                               "- İdrarda meydana gelen değişiklik (Kanlı, çay rengi, köpüksü olması).\n\n" +
                               "- İdrar yapma alışkanlığında değişimler (Miktarda artma ya da azalma, idrara sıkışma, idrar yaparken yanma hissi, gece idrara çıkma).\n\n" +
                               "- Ayak bilekleri, el ve yüzde şişme.\n\n" +
                               "- Yüksek kan basıncı.\n\n" +
                               "- Nefes darlığı, nefes almada zorluk.\n\n" +
                               "- Tat almada bozukluk, kötü kokulu nefes.\n\n" +
                               "- Bunlardan biri varsa acilen hastaneye gitmeniz tavsie olunur.\n\n";
            }
            if (urun == "Kırmızı Soğan")
            {
                urunResmi.sprite = AliResimler[7];
                baslik.text = "Kırmızı Soğanın Faydaları";
                konu.text = "- Kan basıncını düzenler, kan temizleyicidir ve kan pıhtılaşmasını önler. Kalp sağlığına faydaları kanıtlanmıştır.\n\n" +
                               "- Zengin bir kuersetin kaynağıdır ve enfeksiyonlara karşı koruyucu özelliği vardır.\n\n" +
                               "- Zengin selenyum içeriğine sahiptir. Bağışıklık sistemini güçlendirir, akciğeri temizler, güneşin zararlarından ve kırışıklıklardan cildi korur.\n\n" +
                               "- Cildin, saçın ve tırnağın önemli bileşeni olan kükürtün de kaynağıdır. Kükürt aynı zamanda tümörlerin büyümesini ve yayılımını engelleyerek kanser riskini azaltabilir.\n\n" +
                               "- Kırmızı soğan kötü kolesterolü düşürmede etkili olan harika bir besindir.\n\n" +
                               "- İçerisindeki fitokimyasallar vücudumuzda C vitamininin daha iyi kullanılmasını sağlar.\n\n" +
                               "- Kırmızı soğanda bulunan folat, depresyonun engellenmesinde etkilidir.\n\n" +
                               "- Kırmızı soğan krom içerir, bu da kan şekerinin dengelenmesini sağlar.\n\n" +
                               "- Kırmızı soğanın demir minerali içeriği de zengindir. Bu nedenle kansızlık yaşayan kişilerin beslenmelerine kırmızı soğanı eklemeleri önemlidir.\n\n";
            }
            if (urun == "Nar")
            {
                urunResmi.sprite = AliResimler[8];
                baslik.text = "Narın Faydaları";
                konu.text = "\n- Narın sağlığa en faydalı özelliklerinden biri güçlü bir doğal antioksidan olmasıdır. Antioksidanlar vücudu hastalıklara karşı daha dirençli hale getirir, hücreleri serbest radikal hasarından korur, kanser gibi hastalıkları önler, iltihaplanma ve yaşlanmanın etkilerini azaltır.\n\n" +
                               "- A, C ve E vitaminleri açısından zengin olan bu meyve, aynı zamanda antiviral ve anti-tümör özelliklere de sahiptir. Nar, çinko, fosfor, magnezyum ve demir bileşikleri açısından zengin ve tıbbi özelliklere sahip bir meyvedir. Ancak şeker içeriğine dikkat edilmelidir.\n\n" +
                               "- Narın içerdiği polifenoller antioksidanlar olarak işlev görmektedir. Bu antioksidanların prostat, mide kanseri, kolon, akciğer ve meme kanseri üzerinde olumlu etkileri olduğu çeşitli çalışmalar ile gösterilmiştir.\n\n" +
                               "- Nar, kan damarlarını korur, gençleştirir ve böylece kan dolaşımını iyileştirerek kalp ve damar sağlığını koruyabilmektedir. Narın kolesterol düşürücü etkisi de bulunmaktadır. Kolesterol ve yağ birikmesi, kalp hastalığının yaygın nedenlerinden biridir. Nar damarları tıkayan 'kötü' kolesterolü düşürmeye yardımcı olabilir. Aynı şekilde 'iyi' kolesterolü yükseltebilir ve bu da felç ve kalp krizi riskini azaltır.\n\n" +
                               "- Nar sindirim rahatsızlıklarına karşı da oldukça etkilidir. Güçlü antibakteriyel ve antiviral etkisi, bağırsakların düzgün çalışmasına müdahale edebilecek tüm zararlı mikroorganizmaları ve diğer bakterileri ortadan kaldırır. Nar ayrıca şişkinlik ve kabızlık problemlerini önleyerek sindirim sisteminin sağlıklı kalmasına yardımcı olmaktadır. Ağız florası için de birçok faydası bulunmaktadır. Diş etlerinde oluşan enfeksiyonlara karşı etkilidir.\n\n" +
                               "- Narda bulunan bitkisel hormonlar, özellikle kadınlarda hormonal sistem üzerinde dengeleyici bir etkiye sahiptir. Bu nedenle nar menopoz dönemi için kullanılabilir.\n\n" +
                               "- Narın çekirdekleri de içerdikleri vitamin, mineraller ve antioksidanlarla cildin genç kalmasını ve güzelleşmesini sağlamaktadır.\n\n";

            }
            if (urun == "Çilek")
            {
                urunResmi.sprite = AliResimler[9];
                baslik.text = "Çileğin Faydaları";
                konu.text = "- Kanı temizler.\n\n" +
                               "- Sakinleştirici etkiye sahiptir, stresi azaltır.\n\n" +
                               "- Diş etlerini güçlendirir, ağız kokusunu giderir.\n\n" +
                               "- Romatizma ve karaciğer rahatsızlıklarına iyi gelir.\n\n" +
                               "- Etkili bir antioksidan olması sebebiyle bağışıklık sistemini güçlendirir.\n\n" +
                               "- Sindirim sisteminin düzenli çalışmasını sağlar.\n\n" +
                               "- Bağırsak kurtlarının dökülmesini yardımcıdır.\n\n" +
                               "- Cildi nemlendirip taze bir görünüm kazandırır.\n\n" +
                               "- İdrar söktürücü özelliği vardır.\n\n";
            }
            if (urun == "Kiraz")
            {
                urunResmi.sprite = AliResimler[10];
                baslik.text = "Kirazın Faydaları";
                konu.text = "\n- Vücudumuzu toksinlerden arındırır.\n\n" +
                               "- İçerdiği antioksidanlar kansere karşı koruyucudur.\n\n" +
                               "- Kolesterol ve kan şekerini düşürmeye yardımcıdır.\n\n" +
                               "- A, B, C vitamini, magnezyum ve kalsiyum açısından zengindir.\n\n" +
                               "- İçerdiği A vitamini ile cildimizi güzelleştirir, çocuklarda büyümeye yardımcıdır.\n\n" +
                               "- Yüksek pektin ve çözülebilir lif sayesinde, kolesterolü düşürücü etki gösterir.\n\n" +
                               "- Fosfor zengini kiraz sinir sistemini güçlendirir, sakinleştirme özelliği vardır.\n\n" +
                               "- Gut ve romatoid artrit gibi eklem rahatsızlığı olanların kiraz tüketimi, ağrılarını azaltabilir.\n\n" +
                               "- Kabızlığı önlemede etkilidir.\n\n" +
                               "- Bağışıklık sistemi fonksiyonunda önemli bir yeri olan melatonin içerir.\n\n" +
                               "- Kirazın sapları idrar söktürücüdür.\n\n";
            }
            if (urun == "Portakal")
            {
                urunResmi.sprite = AliResimler[11];
                baslik.text = "Portakalın Faydaları";
                konu.text = "- Şeker hastalığı tedavisinde kullanılır.\n\n" +
                               "- Cilt yaşlanmasını engeller.\n\n" +
                               "- Böbrek taşı oluşumunu engeller.\n\n" +
                               "- Kansızlık tedavisinde kullanılır.\n\n" +
                               "- Bağışıklık sistemini güçlendirir.\n\n" +
                               "- Kan basıncını dengeler.\n\n" +
                               "- Kötü kolesterolü düşürür.\n\n";
            }
            if (urun == "Limon")
            {
                urunResmi.sprite = AliResimler[12];
                baslik.text = "Limonun Faydaları";
                konu.text = "\n- Böbrek taşlarının oluşumunu engellemede oldukça etkilidir.\n\n" +
                               "- C vitamini kaynağı olmasıyla antioksidan etkisi yaratır.\n\n" +
                               "- Kanı temizler ve kan basıncını dengeler.\n\n" +
                               "- Kanın pıhtılaşmasını sağlayan maddeler içerir ve salgılar.\n\n" +
                               "- Bağışıklık sistemini güçlendirir ve serbest radikallerin oluşumunu engeller.\n\n" +
                               "- Yüksek demir içeriğine sahip olduğu için kansızlık problemlerini çözmede yardımcı olur.\n\n" +
                               "- Bağışıklık sistemini güçlendirerek kronik rahatsızlıkların önüne geçer.\n\n" +
                               "- Lif bakımından zengindir ve böylece bağırsakların çalışmasını sağlar.\n\n" +
                               "- Kötü kolesterolü düşürmede yardımcı olur.\n\n" +
                               "- Damar sertleşmesini önler ve kalp ile damar sağlığını koruyucu bir etki oluşturur.\n\n\n" +
                               " Limon Kabuğu Neye İyi Gelir?\n\n" +
                               "- Diş ve diş etlerini korurken aynı zamanda güçlendirir.\n\n" +
                               "- Karaciğerde yağlanmayı önemli oranda azaltır.\n\n" +
                               "- Yüksek oranda lif barındırır ve bağırsakları rahatlatır.\n\n" +
                               "- Hücre hasarını önemli oranda korur.\n\n" +
                               "- Kanser riskini ciddi anlamda düşürür.\n\n" +
                               "- Damar sağlığını korur ve damar tıkanıklığına karşı destek verir.\n";
            }
            if (urun == "Kaju")
            {
                urunResmi.sprite = AliResimler[13];
                baslik.text = "Kajunun Faydaları";
                konu.text = "- Bağışıklık sisteminin korunmasında etken olan selenyum mineralini içerir.\n\n" +
                               "- Kansere karşı vücut direncini artırır.\n\n" +
                               "- Kalsiyum ve magnezyum gibi mineraller içermesi kemik sağlığı açısından önemlidir.\n\n" +
                               "- Triptofan içeriği ile mutluluk verir.\n\n" +
                               "- Kalp kasının çalışmasında, kan basıncının düzenlenmesinde ve kasların gevşemesinde etkilidir.\n\n" +
                               "- İçeriğindeki çinko, çocukların gelişimini destekler.\n\n" +
                               "- Vitaminler açısından zengindir ve enerji verir.\n\n" +
                               "- Kansızlığı gidermeye yardımcıdır.\n\n" +
                               "- Sindirim sistemi için faydalı olan asitler içerir.\n\n";
            }
            if (urun == "Hurma")
            {
                urunResmi.sprite = AliResimler[14];
                baslik.text = "Hurmanın Faydaları";
                konu.text = "- Bol miktarda kalsiyum ve fosfat içeren hurma genel anlamda kemik sağlığının korunmasına yardımcı olur. Bunun yanında kemiklerin güçlenmesine yardımcı olur, vitamin eksikliğinden dolayı oluşabilecek kemik hastalıklarına karşı koruyucu özelliği vardır. \n\n" +
                               "- Hafızaya iyi geliyor.\n\n" +
                               "- Kanseri önleyici.\n\n" +
                               "- Antioksidan kaynağı\n\n" +
                               "- Kalp ilacı.\n\n" +
                               "- Kolesterole ve damar sertliğine faydalı\n\n" +
                               "- Hamilelikte doğumu kolaylaştırıcı.\n\n" +
                               "- İktidarsızlığa iyi geliyor.\n\n" +
                               "- Kan yapıcıdır, Anemi hastalığını kaldırır\n\n";
            }
            if (urun == "Siyah Zeytin")
            {
                urunResmi.sprite = AliResimler[15];
                baslik.text = "Siyah Zeytin Faydaları";
                konu.text = "- Sindirimi Kolaylaştırır.\n\n" +
                               "- Saç, Cilt ve Tırnak İçin Besleyici.\n\n" +
                               "- Kanseri Önler.\n\n" +
                               "- Uzun Süre Tok Tutar.\n\n" +
                               "- Kalp Sağlığını Korur.\n\n" +
                               "- Vücut Gelişimine Destek Olur.\n\n" +
                               "- Kan Yapar.\n\n";
            }
            if (urun == "Badem")
            {
                urunResmi.sprite = AliResimler[16];
                baslik.text = "Badem Faydaları";
                konu.text = "- Sinirleri güçlendirir.\n\n" +
                               "- Göğüs hastalıklarını önler.\n\n" +
                               "- Beden ve zihin yorgunluğunu giderir.\n\n" +
                               "- Hamilelerin sütünü arttırır ve bebeklerin gelişimine yardımcı olur .\n\n" +
                               "- Böbrek, idrar yolları ve cinsel organlardaki iltihapları iyileştirir.\n\n" +
                               "- Badem yağı ayrıca müsil olarak da kullanılır.\n\n" +
                               "- Kolestrolü düşürür.\n\n";
            }
            if (urun == "Karpuzz")
            {
                urunResmi.sprite = AliResimler[17];
                baslik.text = "Karpuz Faydaları";
                konu.text = "- İçeriğinde lif olmasından ötürü, bağırsakları çalıştırır.\n\n" +
                               "- Gün içerisindeki meyve gereksinimini karşılar.\n\n" +
                               "- Su içermesinden ötürü, gün içerisinde tüketilmesi gereken sıvının belli bir bölümünü karşılar.\n\n" +
                               "- C vitamini ve folik asit açısından zengindir. C vitamini, hastalıklara karşı koruma sağlayan en önemli antioksidan vitaminleri içerisinde bulunur.\n\n" +
                               "- Kırmızı renkli meyvelerin içerisinde likopen ve antosiyanin yüksektir. Bu bileşenler; kalp krizi, kalp hastalıkları ve bazı kanser çeşitlerine karşı koruma sağlar.\n\n" +
                               "- Kırmızı meyveler, inflamasyonu azaltarak, antioksidan özellikleri bulunan bazı flavonoidler içermektedir. Bu yüzden karpuzun, hastalıklara karşı koruyucu etkisi bulunur.\n\n" +
                               "- Karpuz; böbreklerin işlevlerini doğru bir şekilde getirmesine yardımcı olur. \n\n";
            }
            if (urun == "Kavun")
            {
                urunResmi.sprite = AliResimler[18];
                baslik.text = "Kavunun Faydaları";
                konu.text = "- Bağışıklık sistemini güçlendirir.\n\n" +
                               "- Damar tıkanıklığını önlemede etkilidir.\n\n" +
                               "- Böbrek taşları ve kumlarını düşmesine yardımcı olur.\n\n" +
                               "- İdrar söktürücü özelliği vardır.\n\n" +
                               "- Cildi nemlendirir, romatizma ağrılarını hafifletir\n\n";
            }
            if (urun == "Salatalık")
            {
                urunResmi.sprite = AliResimler[19];
                baslik.text = "Salatalığın Faydaları";
                konu.text = "- Besleyicidir. Salatalığın önemli bir kısmı sudan oluşur.\n\n" +
                               "- Kansere karşı koruma sağlar. Salatalık güçlü antioksidanlardandır.\n\n" +
                               "- Su ihtiyacını karşılar.\n\n" +
                               "- Vücudu arındırır.\n\n" +
                               "- Kemikleri güçlendirir.\n\n" +
                               "- Cilt bakımında etkilidir.\n\n" +
                               "- Baş ağrısını dindirir.\n\n" +
                               "- Kilo vermeye yardımcı olur.\n\n";
            }
            if (urun == "Sarımsakk")
            {
                urunResmi.sprite = AliResimler[20];
                baslik.text = "Sarımsağın Faydaları";
                konu.text = "- Sarımsakta A, B1 ve C vitaminleri bulunuyor.\n\n" +
                               "- Allicin serbest radikallere karşı korur.\n\n" +
                               "- Sarımsağın tansiyonu düşürme etkisi vardir.\n\n" +
                               "- Sarımsak doğal bir antibiyotik.\n\n" +
                               "- Sarımsak mesane enfeksiyonlarına karşı etkilidir.\n\n" +
                               "- Sarımsak kanser tedavisinde kullanılıyor.\n\n" +
                               "- Sarımsak kanser riskini azaltıyor.\n\n" +
                               "- Sarımsak karaciğeri koruyor.\n\n";
            }
            if (urun == "Domates")
            {
                urunResmi.sprite = AliResimler[21];
                baslik.text = "Domates Faydaları";
                konu.text = "- Kanser ve kalp hastalıklarına karşı koruyan domates aynı zamanda felç riskini de en az indirger.\n\n" +
                               "- C vitamini yönünden zengin olan domates bağışıklık sistemini kuvvetlendirir ve grip benzeri virütik hastalıklara karşı korur.\n\n" +
                               "- Safra ve böbrek taşlarının düşürülmesine destek olur.\n\n" +
                               "- Domatesin % 85’inde bulunan likopen kolesterolü düşürür, akciğer, rahim, prostat, serviks, göğüs kanserlerine karşı koruyucu özelliği vardır.\n\n" +
                               "- Damar sertliğine iyi gelir.\n\n" +
                               "- Mide ve bağırsakların düzenli çalışmasını sağlar ve kabızlığı giderir.\n\n" +
                               "- Kalorisi oldukça düşük olduğundan diyet yapanların vazgeçilmezidir. Kalori kontrolü yaparken vücudunuzun mineral ve vitamin eksikliğini giderir.\n\n" +
                               "- Cilde tazelik kazandırır.\n\n" +
                               "- Domates, yağ yakımını % 30 arttıran aminoasitlerin salgılanmasını tetikler.\n\n" +
                               "- Kolesterolü düşürür, yağ asitlerini dengeler.\n\n";
            }
            if (urun == "Patlıcan")
            {
                urunResmi.sprite = AliResimler[22];
                baslik.text = "Patlıcan Faydaları";
                konu.text = "- Bol miktarda lif içermesiyle birlikte hazımsızlık gibi sorunları giderir.\n\n" +
                               "- Kalp çarpıntısı gibi stres yaratan hastalıklarda insanı sakinleştirir.\n\n" +
                               "- Vücutta doku sıvılarında biriken ödemi atmada ve aynı zamanda idrarı söktürme de önemli bir besin kaynağıdır.\n\n" +
                               "- Bol miktarda demir içerdiği için kansızlık çekenler için kan üretimini arttırmaya yardım eder.\n\n" +
                               "- İstemsiz bir şekilde kas kasılması olaylarını engeller.\n\n" +
                               "- Közlenmiş patlıcanın faydaları ise normal patlıcana göre biraz daha az olabilir. Bunun nedeni ise közlendiği için içerisindeki bazı yararlı bakterilerin ölmesi ve bazı vitaminlerin yok olmasıdır. Bunların haricinde yine normal patlıcan gibi birçok yararı bulunmaktadır.\n\n";
            }
            #endregion
        #region    30.03
            if (urun == "Arı Sokması")
            {
                urunResmi.sprite = AliResimler[23];
                baslik.text = "Arı Sokması";
                konu.text = "- Kendilerini savunmak maksadıyla, vücutlarında bulunan iğneyi batırmalarina arı sokması denir.\n\n" +
                               "- Arı sokması neticesinde ortaya çıkan reaksiyonlar kişiden kişiye farklılık göstermektedir.\n\n" +
                               "- Bal arıları bir kişiyi soktuktan sonra ölürken, eşek arıları ve yaban arıları gibi türler birden fazla kez sokup, yaşamına devam edebilir.\n\n" +
                               "- Çok sayıda arı aynı anda sokarsa, o zaman toksik reaksiyon görülebilir. Bu durum alerji belirtilerine benzerse de testlerde alerjik duyarlanma saptanamaz.\n\n" +
                               "- Arının soktuğu yer soğuk su ve sabunla yıkanmalıdır. Soğuk su rahatlatırken, sabun da kalan kiri ya da zehri bölgeden temizlemeye yardım eder.\n\n" +
                               "- Alerji ilacı ya da krem de kullanılabilir.\n\n" +
                               "- Sokulan bölge kolunuz ya da bacağınız ise, yükseğe koymanız ağrı ve şişliğin azalması noktasında size destek olacaktır.\n\n" +
                               "- Şişlik ve kaşıntının olduğu yer kaşınmamalıdır. \n\n";
            }
            if (urun == "Arpa")
            {
                urunResmi.sprite = AliResimler[24];
                baslik.text = "Arpanın Faydaları";
                konu.text = "- Kemik sağlığını korur. İçeriğinde bulunan bakır ve fosfor mineralleri sayesinde kemikler için oldukça faydalıdır.\n\n" +
                               "- Çocuklarda astımı engellemeye yardımcı olur. \n\n" +
                               "- Kalp ve damar sağlığını korur.\n\n" +
                               "- Şeker hastalığını dengeler.\n\n" +
                               "- Bağırsak sağlığını korur.\n\n" +
                               "- Emziren anneler için sütü arttırıcı özelliği vardır.\n\n" +
                               "- Vücuttan toksinlerin atılmasına yardımcı olur.\n\n" +
                               "- Alkol ve gıda zehirlenmelerinde kullanılır.\n\n";
            }
            if (urun == "Apse")
            {
                urunResmi.sprite = AliResimler[25];
                baslik.text = "Apse Nedir";
                konu.text = "- İrinli yangı bölgesinde doku erimesi vardır, oluşan boşluğu irin doldurur. Genellikle piyojen bakterilerin neden olduğu fokal bir yangı türüdür.\n\n" +
                               "- Oldukça küçük bir absede etken kısa zamanda ortadan kaldırılırsa irinli boşluğu granülasyon dokusu doldurur ve yerinde nedbe (sikatris) bırakarak iyileşir.\n\n" +
                               "- Daha büyük bir absede etken ortadan kaldırıldıktan sonra irinli boşluk fibröz kapsülle çevrilir. Abse içindeki maddelerin büyük bir kısmı rezorbe olur. Geriye içi sarımtırak renkte steril sıvı ile dolu kistik bir boşluk kalır.\n\n" +
                               "- Piyemi ve sepsis: Absedeki etkenler kan ve lenf yolu ile yayılabilir (piyemik abse, septik şok).\n\n" +
                               "- Basınç: Bazı lokalizasyonlarda absenin kendisinin ve perifokal ödemin yaptığı hacim art­ışı çok tehlikelidir. Özellikle beyin absesinde kafaiçi (intrakraniyal) basıncın artması ölümcül olabilir.\n\n" +
                               "- Fistül: Etkenin/absenin ortadan kaldırılamadığı durumlarda lezyon büyür ve fistülleşebilir. Abse olgusunda önemli bir fenomendir.\n\n";

            }
            if (urun == "Ağlamanın Zararları")
            {
                urunResmi.sprite = AliResimler[26];
                baslik.text = "Ağlamanın Zararları";
                konu.text = "- Ağlamak bir anlamda rahatlama sağlar. Bu rahatlama sadece fiziksel değil ruhsal olarak da ortaya çıkar. \n\n" +
                               "- Ağlamak genel olarak faydalıdır fakat fazla ağlamanın zararları vardır. Ama bu zararlar ciddi zararlar değildir.\n\n" +
                               "- Ağlayan kişilerinin yüzleri kızarır. Bu ağlamanın basit bir etkisidir.\n\n" +
                               "- Çok ağlayan kişilerin göz çevreleri daha çabuk kırışır, yıpranır. Gözyaşı tuzlu olduğu için ağlayınca göz çevresi yanar.\n\n" +
                               "- Göz kapaklarında şişme olur. Ağlamak baş ağrısı yaptığı gibi ağlamanın gerçekleşmemesi için kişinin kendini tutması da baş ağrısına sebep olur.\n\n" +
                               "- Baş ağrısı ile birlikte mide bulantısı ve baş dönmesi de ortaya çıkabilir. Hatta aşırı ağlamanın sonucu olarak kişi bayılabilir. Gözlerde yanma oluşabilir.\n\n" +
                               "- Çok ağlamakla ilgili merak edilen bir konu da çok ağlamanın gözleri bozup bozmadığıdır. Ağlamakla gözler bozulmaz.\n\n" 
                               ;

            }
            if (urun == "Akciğer")
            {
                urunResmi.sprite = AliResimler[27];
                baslik.text = "Akciğer";
                konu.text = "- Hava soluyan omurgalılardaki temel solunum organıdır.\n\n" +
                               "- Soluk alındığında burun ve ağızdan giren hava nefes borusu ve sonrasında bronşlardan geçerek akciğerlere ulaşır.\n\n" +
                               "- Toplardamarlarla gelen karbondioksitce fazla olan (kirli) kan burada yenilenir.\n\n" +
                               "- Sesin oluşumunda da görevlidir.\n\n" +
                               "- Yeni doğanda akciğer, ilk başta parlak pembe renktedir. Zamanla grileşmeye ve yaş geçtikçe koyulaşarak en sonunda neredeyse siyah rengine bürünür.\n\n" +
                               "- Bu koyulaşmaya solunumla alınan havadaki toz ve öteki maddeler neden olmaktadır.\n\n" +
                               "- Ayrıca sigara içenlerin akciğerleri içmeyenlere göre daha siyahtır.\n\n";
            }
            if (urun == "Akraba Evliliği")
            {
                urunResmi.sprite = AliResimler[28];
                baslik.text = "Akraba Evliliği";
                konu.text = "- Genetik hastalıkların epidemolojisini etkileyen önemli etmenlerden biridir ve dünya toplumunun en az %20'si tarafından yeğlenmektedir. Doğan çocukların en azından %8,4'ü akraba evliliklerinden doğmaktadır.\n\n" +
                               "- Genel toplumda doğan her 100 çocuktan 2'sinde herhangi bir nedene bağlı olarak doğuştan bir anomali saptanırken, akraba evlilikleri yapan çiftlerde bu risk yaklaşık iki kat oranında artmaktadır ki; bu oran genetik hastalıklar için oldukça artmış bir risktir.\n\n" +
                               "- Akraba evliliği, zararlı baskın gen ve çekinik gen üst üste gelerek çakışması olasılığını artırdığından genetik hastalıkların görülmesine yol açabilir.\n\n" +
                               "- Akraba evlilikleri aralarında kan bağı olan kişiler arasındaki evliliklerdir. Yakınlık derecesine göre en sakıncalısı, 1. derece kuzen evliliği dediğimiz, teyze, dayı, amca ve hala çocukları arasında yapılan evliliklerdir. Kardeş torunları arasındaki evlilikler ise 2. derece kuzen evlilikleri olup kalıtsal hastalık açısından daha az risklidirler.\n\n" +
                               "- Akraba evliliği sonucu ortaya çıkan kalıtsal hastalıklar genelde metabolizma hastalıklarıdır ve sayıları oldukça fazladır.\n\n" +
                               "- Akraba evliliklerinin en sık yapıldığı ülkelerden biri olan Türkiye’de yapılan araştırmalarda, %25'lik bir kısmın kendi akrabasıyla, kan bağı olan kişilerle evlendiği görülmektedir.\n\n" +
                               "- Akdeniz anemisi olarak bilinen talasemi, akraba evliliği sonucu oluşan en sık hastalıklardan birisidir.\n\n";
            }
            if (urun == "Ağız Yarası")
            {
                urunResmi.sprite = AliResimler[29];
                baslik.text = "Ağız Yarası";
                konu.text = "- Çıkma sebebi sosyoekonomik düzeyi yüksek kişilerde ve erkeklere oranla kadınlarda daha sık görülür.\n\n" +
                               "- Genetik yatkınlığın yanı sıra travma, stres ve kaygı bozuklukları, sigara kullanımı, tütün çiğneme, premenstrüel dönem, ilaç kullanımı, folik asit, B12, demir ve çinko gibi vitamin eksiklikleri, bağışıklık sisteminin zayıf olduğu hastalık dönemleri, hormonal değişiklikler, sirke, turşu, tuzlu ve baharatlı yiyeceklerin tüketilmesi, diş macunu içeriğindeki sodyum lauryl sülfat adlı köpük artırıcı madde, sistemik hastalıklar ve alerji gibi pek çok faktör aft oluşumuna sebep olabilir.\n\n" +
                               "- Eğer çıktıysa zamana bırakarak geçmesini bekleyeceksin, yaraya zarar vermemen gerekiyor sıcak, asitli ve yakıcı nitelikte olan tahriş edici gıda ve sıvılardan uzak durmalısın. 'Tuzlu su ya da karbonatlı su ile ağzını çalkalayabilirsin' diyorlar ama bence yapma tuz yarayı yakar acının üstüne acı eklersin, sen sadece sıcak ve asitli şeyler yeme-içme yeter. Ancak uzun dönemde aft oluşumunu engellemek için sigarayı bırakmak, düzenli ve dengeli beslenmek faydalı olabilir.\n\n";
            }
            if (urun == "Alkolizm")
            {
                urunResmi.sprite = AliResimler[30];
                baslik.text = "Alkolizm";
                konu.text = "- Alkollü içkilere kişinin fiziki ve psikolojik sağlığına zarar verecek şekilde olan aşırı tutkunluk.\n\n" +
                               "- Alkolizm sorunu olan kişiye ise alkolik denir.\n\n" +
                               "- Her gün aynı şekilde içki içilir.\n\n" +
                               "- Sınır konur ama bu sınır aşılır.\n\n" +
                               "- İçkinin içilmediği faaliyetler bırakılır.\n\n" +
                               "- Uyku sorunları yaşanır.\n\n" +
                               "- Sabahları sinirli, hasta, terlemiş veya titreyerek uyanır.\n\n" +
                               "- Uyandıktan sonra üç saat içinde içki içilir.\n\n" +
                               "- Genellikle alkole karşı düşkünlüğün başlaması, sinir gerginliğini yok etmek için içme ihtiyacının duyulmasıyla olur.\n\n" +
                               "- İlaç tedavisi: İlaç, alkollü içkiyi kullanma halinde son derece kuvvetli etkiler meydana getirir. Bu şekilde alkolün kendisine yaramadığına inanan kişi alkolden soğur. İlacın tesirli olması için düzenli olarak her gün alınması gereklidir. İlaç tedavisinin mutlaka uygun bir klinikte ve yetkili doktor kontrolünde yapılması (en azından başlatılması) hayati ehemmiyeti haiz bir husus olduğu unutulmamalıdır.\n\n" +
                               "- Alkolün pençesinden kurtulanların pek çok ülkede kurduğu alkoliklere yardım “Adsız Alkolikler” (Alcoholics Anonymous) teşkilatı hem alkolden kurtulmada hem de alkole dönmeme savaşında kişilere yardım etmektedir.\n\n" +
                               "- Psikoterapi (ruhsal tedavi)nin de tedavi edici nitelikte olduğu son zamanlarda kanıtlanmıştır.\n\n";
            }
            if (urun == "Akrep Sokması")
            {
                urunResmi.sprite = AliResimler[31];
                baslik.text = "Akrep Sokması";
                konu.text = "- Akrebin soktuğu bölgede, şiddetli ağrı, uyuşma ve karıncalanma, hafif şişlik ve sıcaklık gözlemlenebilir.\n\n" +
                               "- Bunun yanı sıra genellikle çocuklarda görülen semptomlara bakıldığında, nefes almada zorluk, istemsiz baş, boyun ve göz hareketleri, terleme, mide bulantısı ve kusma, kalp atışının hızlanması (taşikardi), tansiyonun yükselmesi ve huzursuzluk hali gibi durumlar görülebilir. \n\n" +
                               "- Ayrıca akrepler tarafından bir kere sokulan insanların, daha sonraki sokmalarda alerjik reaksiyon yaşamaları mümkün hale gelebilir.\n\n" +
                               "- Bu sokmalar, ağır alerjik reaksiyonların neden olduğu anafilaksi adı verilen ve hayatı tehdit eden bir duruma neden olacak kadar şiddetli olabilir. \n\n" +
                               "- Bu vakalardaki belirti ve semptomlar; kurdeşen, nefes darlığı, bulantı ve kusmayı içerebilir.\n\n" +
                               "- Akrep sokması ilk müdahale olarak, yaranın yumuşak bir sabun ve su ile temizlenmesi gerekir. Akrebin soktuğu bölgeye buz yardımıyla kompres uygulanarak o bölgenin serin tutulması sağlanmalıdır. Bu işlem, şişliğin hafifletilmesinin yanı sıra ağrıların azaltılmasına da yardımcı olabilir.\n\n" +
                               "- Çoğunlukla akrep ısırması tıbbi tedaviyi gerektirmez. Ancak semptomlar şiddetli ise, bir hastaneye gitmek gerekebilir. \n\n" +
                               "- Akrepler genellikle yakacak odun, elbise, çarşaf, ayakkabı ve çöp kovalarında saklanır, bu nedenle bu şeyleri tutarken dikkatli olunmalıdır. Daha sıcak mevsimlerde, yürüyüş yaparken veya kamp yaparken görülme olasılığı daha yüksektir.\n\n" +
                               "- Akrep zehri hem lokal hem de sistemik reaksiyonlar üretir. Lokal reaksiyonlar kaşıntı, ödem ve yanma ağrısı olan ekimozlardan oluşur. Zehir, kardiyovasküler bulgular, art arda sersemlik hali, vücut ısısının düşmesi, huzursuzluk ve taşikardi gibi semptomlara neden olur. Sıklıkla olmasa da bir akrep sokması ölüme neden olabilir.\n\n";
            }
            if (urun == "Ağız Kokusu")
            {
                urunResmi.sprite = AliResimler[32];
                baslik.text = "Ağız Kokusu";
                konu.text = "- Ağız kokusu diş sağlığı alışkanlıklarından kaynaklanabilir ve diğer sağlık sorunlarına da işaret edebilir. Ağız kokusu, yediğiniz yiyecek türlerine ve diğer sağlıksız yaşam tarzı alışkanlıklarına göre daha da kötüleştirilebilir.\n\n" +
                               "- Günlük olarak dişlerin fırçalanması, diş ipi ve gargara kullanılması ağız bakımı açısından son derece önemlidir. Fırçalanmayan, diş ipi ve gargara kullanılmayan dişlerde gıda parçacıkları ağızda kalabilir.\n\n" +
                               "- Dişlerin arasında kalan yemek artıkları, diş etlerinin çevresinde ve dilde bakteri üremesine neden olur ve bu durumda nefesin kötü kokmasına yol açar. Antibakteriyel ağız gargaraları kokuyu azaltmaya yardımcı olabilir. Ayrıca takma dişler de kokuya neden olan bakteri ve yiyecek parçacıklarının uygun şekilde temizlenmemesi durumunda kötü kokuya neden olabilir.\n\n" +
                               "- Kalıcı ağız kokusu veya ağızda kötü bir tat, diş eti (periodontal) hastalığının bir işareti de olabilir. Dişlerdeki plak birikimi ve diş etlerini tahriş eden toksinler diş eti hastalıklarına sebep olabilir. Eğer ağız kokusu diş eti hastalığından kaynaklanıyorsa en kısa sürede tedavi edilmelidir. Tedavi edilmeyen diş etline bağlı rahatsızlıklar diş ve çene kemiğine zarar verebilir.\n\n\n" +
                               " Ağız Kokusuna Sebep Olabilecek Diğer Nedenler:\n\n"+ 
                               "- Ağıziçi mantar enfeksiyonları\n\n"+ 
                               "- Diş çürükleri (oyuklar)\n\n"+ 
                               "- Sinüzit\n\n"+
                               "- Bademcik iltihabı\n\n"+ 
                               "- Mide ve bağırsak sistemleri hastalıkları\n\n"+ 
                               "-Uzun süreli açlık\n\n";

            }
            #endregion
        #region    31.03
            if (urun == "Astım")
            {
                urunResmi.sprite = AliResimler[33];
                baslik.text = "Astım";
                konu.text = "- Astım, solunum yollarını tıkayan ve nefes almayı zorlaştıran kronik bir hastalıktır. Astımda, hava yolu etrafındaki düz kaslar, alerjenler, duman, soğuk hava veya egzersiz gibi tetikleyicilere yanıt olarak kasılır ve mukus adı verilen yapışkan salgının üretimi artar; bu durum hava yolunun daralmasına neden olur. Çeşitli tetikleyicilere yanıt olarak gelişen astım atakları hırıltıya, nefes darlığına ve öksürüğe neden olabilir.\n\n" +
                               "- Hava kalitesi düşük olan şehirlerde yaşayanlar\n\n" +
                               "- Sigara içenler veya bulundukları ortamlarda sigara dumanına maruz kalanlar (pasif içiciler).\n\n" +
                               "- Alerjisi olan kişiler.\n\n" +
                               "- Ailesinde astım hastası veya alerjik bireyler olan kişiler astım için risk altındadır.\n\n\n" +
                               " BELİRTİLER:\n\n" +
                               "- Nefes alırken hırıltı veya ıslık sesi.\n\n" +
                               "- Öksürük.\n\n" +
                               "- Göğüste ağrı veya sıkışma.\n\n" +
                               "- Nefes darlığı.\n\n\n" +
                               " TEDAVİ YÖNTEMLERİ:\n\n" +
                               "- Sigarayı bırakmak.\n\n" +
                               "- Evcil hayvanlara karşı alerjiniz varsa kontrol altına almak.\n\n" +
                               "- Kimyasal duman ve kokuları önlemek.\n\n" +
                               "- Tozlu ve küflü ortamlardan uzak durmak.\n\n" +
                               "- Aşırı soğuktan korunmak.\n\n" +
                               "- Uygun egzersizler yapmak.\n\n";

            }
            if (urun == "Bağırsak")
            {
                urunResmi.sprite = AliResimler[34];
                baslik.text = "Bağırsak";
                konu.text = "- İnce bağırsak ve kalın bağırsak olacak şekilde iki ana kısımdan oluşur. Vücudun gıdadan besinlerin çıkarımı ve emiliminden sorumlu kısmı bağırsaktır.\n\n" +
                               "- Yetişkin bir insanın ince bağırsağı, ortalama olarak yedi metre uzunluğundadır.\n\n" +
                               "- Kalın bağırsak ince bağırsağa oranla daha kısadır ve su reabsorpsiyonu ile kuru dışkıyı üretir.\n\n\n" +
                               " BAĞIRSAK HASTALIKLARI: \n\n" +
                               "- Diğer sindirim sistemi hastalıklarıyla birlikte bağırsak hastalıklarına da bakan tıp dalı gastroenterolojidir.\n\n" +
                               "- Gastroenterit, bağırsakların enflamasyonudur ve en yaygın bağırsak hastalığıdır.\n\n" +
                               "- Ileüs, bağırsak tıkanıklığıdır.\n\n" +
                               "- Apandisit, apandis enflamasyonu. Bu tedavi edilmediği zaman potansiyel olarak ölümcül bir hastalıktır; çoğu durumda apandisit cerrahi müdahaleye gerek duyar.\n\n" +
                               "- Çölyak hastalığı kötü emilimin yaygın bir şeklidir. Crohn hastalığı ve ülseratif kolit bağırsakları etkileyen otoimmün hastalıklardandır. Crohn hastalığı tüm gastrointestinal kanalı etkileyebileceği gibi, kolit sadece kalın bağırsağı etkiler.\n\n" +
                               "- Ayrıca bakınız:Kabızlık,İshal.\n\n";

            }
            if (urun == "Bal")
            {
                urunResmi.sprite = AliResimler[35];
                baslik.text = "Bal";
                konu.text =
                               "- Kahvaltıların en sevileni, binlerce yıldır tatlandırıcı olarak kullanılan şifa deposu balın faydaları saymakla bitmiyor. B1, B2, B3, B5, B6 vitaminleri açısından oldukça zengin bir besin kaynağıdır.\n\n" +
                               "- Uykusuzluğa, astım ve bronşit hastalıklarına iyi geldiği bilinmektedir.\n\n" +
                               "- Bal mineral, vitamin ve amino asitler içerdiği için kilonuzu korumanıza yardımcı olur ve obezite riskini azaltır.\n\n" +
                               "- Bal, prebiyotiktir. Vücuttaki yararlı hücreleri arttırır.\n\n" +
                               "- Cildi iyileştirir, kepeğe ve kaşınmaya iyi gelir.\n\n" +
                               "- Alerjik semptomları azaltır.\n\n" +
                               "- İçerisinde bazı kanser risklerini azaltacak flavonoidler barındırır.\n\n" +
                               "- Boğazı yumuşatır, öksürüğe iyi gelir.\n\n" +
                               "- Antibakteriyeldir.\n\n" +
                               "- Enerji verir.\n\n";

            }
            if (urun == "Balık")
            {
                urunResmi.sprite = AliResimler[36];
                baslik.text = "Balık";
                konu.text =
                               "- Mükemmel bir protein kaynağı olan balığın besin değerleri, türüne göre değişmektedir. Balıkta ortalama 100 gram başına yaklaşık 19,5 gram protein bulunmaktadır. İnsan vücudunun ne kadar proteine ​​​​ihtiyacı olduğu kişiden kişiye değişmektedir. \n\n\n" +
                               " FAYDALARI:\n\n" +
                               "- Bağışıklık sistemini koruyor.\n\n" +
                               "- Omega3 deposu.\n\n" +
                               "- Zeka gelişimine fayda sağlıyor.\n\n" +
                               "- Kalp sağlığını koruyor.\n\n" +
                               "- Kemikleri güçlendiriyor.\n\n" +
                               "- Hücreleri onarıyor.\n\n" +
                               "- Diyabet riskini azaltıyor.\n\n" +
                               "- Eklem ağrılarına faydalıdır.\n\n" +
                               "- Yağ oranı az.\n\n" +
                               "- Çocukların algılama ve dikkat yetisini artırır.\n\n" +
                               "- Alzheimer riskini düşürüyor.\n\n";

            }
            if (urun == "Baş Ağrısı")
            {
                urunResmi.sprite = AliResimler[37];
                baslik.text = "Baş Ağrısına Ne İyi Gelir";
                konu.text =
                               "\n- Bu ağrı çeşidine göre değişkenlik göstericektir.\n\n" +
                               "- Eğer migren atağı geçiriyorsanız,   alnınıza soğuk presler koyabilirsiniz. Bir havlu veya bir torba dondurulmuş pedleri alnınıza koyabilirsiniz. Yine kafanıza buz kompresi yaparak migren ağrınızın hafiflemesine yardımcı olabilirsiniz. Buz kompresini 15 dakika boyunca kafanızda tutup,   15 dakika ara vererek bu işlemi devam ettirebilirsiniz.\n\n" +
                               "- Eğer küme tipi baş ağrınız varsa yine soğuk pres veya karanlık bir ortamda oturmayı deneyebilirsiniz. Küme tipi baş ağrısının tedavisinde en etkili yöntem hekim tarafından önerilen ilaçların kullanılması ve hastanelerin acil bölümlerinde saf oksijen verilmesiyle hafifletilebilmektedir.\n\n" +
                               "- Eğer gerilim tipi bir baş ağrısı varsa, ısıtma pedini ya da sıcak bir havluyu kafa arkasına yerleştirebilirsiniz. Sinüslere bağlı baş ağrınız varsa, ağrıyan bölgeye sıcak bir bez koyabilirsiniz ya da sıcak bir duş da işe yarayabilir.\n\n" +
                               "- Çay ve kahve gibi içinde kafein bulunan içeceklerin tüketilmesi de baş ağrısına iyi gelebilir.\n\n" +
                               "- Karanlık Ortam(gürültülü ve sesli ortamlarda çok fazla kalınca en iyisi ısız bir odaya çekilmek).\n\n" +
                               "- Germe hareketleri, yoga, meditasyon veya kas gevşetme hareketlerinin de baş ağrısına ve diğer ağrı türlerine iyi gelmektedir. \n\n" +
                               "- Boynunuza birkaç dakika masaj yapmak, stresten kaynaklanabilecek bir gerilim baş ağrısını hafifletmeye yardımcı olabilir.\n\n" +
                               "- Hekim tarafından önerilen ilaçların düzenli kullanımı da son derece önemlidir. Bunun dışında baş ağrıları için eczanelerden alabileceğiniz reçetesiz ağrı kesici ilaçları da kullanabilirsiniz.\n\n";

            }
            if (urun == "Baş Dönmesi")
            {
                urunResmi.sprite = AliResimler[38];
                baslik.text = "Baş Dönmesi Nedenleri";
                konu.text =
                               "- Periferik vertigo ( Beyin dışı nedenlerden kaynaklanan vertigo): İç kulağın denge problemlerinden kaynaklanan baş dönmeleri sık görülmektedir. \n\n" +
                               "- Damarsal nedenler: Beyinde ateroskleroz yani damar sertliği görülmesi de baş dönmesine neden olabilir. Kolesterol plakları beyin damarlarında bozulmaya neden olur ve baş dönmesi ile dengesizlik ortaya çıkabilir. \n\n" +
                               "- Beyin tümörleri: Beyinde iyi ya da kötü huylu tümörler baş dönmesine yol açabilmektedir. Özellikle beyincik bölgesindeki oluşumlar bunu daha çok tetiklemektedir. Beyin tümörleri her yaşta ortaya çıkabilmektedir.\n\n" +
                               "- MS ve Myelin hastalıkları: Multipl skelroz. MS, beyin ve omurilikteki sinirlerin myelinli kılıflarını etkileyen tekrarlayıcı özelliği olan bir hastalıktır. Genç yaşta ve kadınlarda sık görülür. MS’te aniden baş dönmesi ortaya çıkabilir. \n\n" +
                               "- Enfeksiyonlar- Basit bir gribal enfeksiyondan tüberküloz gibi kronik enfeksiyonlara kadar pek çok enfeksiyon baş dönmesi olarak kendini gösterebilir. Mutlaka uzman yardımı alınmalı, vücutta enfeksiyon düzeyi ve niteliği belirlenmeli tedavi buna göre yürütülmelidir.\n\n" +
                               "- Travmalar: Kişinin kaza geçirmesi, başını bir yere çarpmış olması gibi durumlar baş dönmesine enden olabilir. Bu travmaların yakın zamanda olması şart değildir.\n\n" +
                               "- Diyabet: Diyabet yani şeker hastalığında beyin hücrelerinin şeker kullanımı bozulur ve enerji alamamaktadır. Bu durumda baş dönmesi ve denge problemleri ortaya çıkabilmektedir.\n\n" +
                               "- Hipertansiyon: Beyin damarları kan basıncı yükselince kendini kanamaya karşı korumak için birden spazma geçerek çaplarını daraltmaktadır.\n\n" +
                               "- Psikolojik etkenler ve stres: Kişide duygu durum bozuklukları, baş dönmesi korkusu, stres gibi faktörler de baş dönmesi ve denge problemlerine neden olabilmektedir.\n\n" +
                               "- Metabolik hastalıklar: Karaciğer hastalıkları, kronik karaciğer hastalıkları, tiroit problemleri ve bazı ilaçların kullanılması durumunda baş dönmesi görülebilmektedir. Sıvı elektrolit dengesi, kan şekeri düzeyi ve kan basıncındaki dengesizlikler baş dönmesine neden olur. \n\n";

            }
            if (urun == "Bel Ağrısı")
            {
                urunResmi.sprite = AliResimler[39];
                baslik.text = " Bel Ağrısı ";
                konu.text =
                               "\n- Bel ağrısı, ağrıma, acıma, yanma veya batma şeklinde, keskin veya künt hissediliyor olabilir. Yeri bazı durumlarda noktasal olarak belirlenebilirken, bazı durumlarda dağınık ve yeri tam tespit edilemez şekildedir. Hafif veya ağır olabilir, iniş çıkışlar sergileyebilir.\n\n\n" +
                               " Bel Ağrısı Sebepleri\n\n\n" +
                               " Yaralanmalar\n\n- Omurga kırıkları en sık olarak omurganın en hareketli bölgesi olan 12.sırt omuru ve 1.bel omurunun birleşim bölgesinde oluşur.\n\n\n" +
                               " Bel Fıtığı\n\n- Ağır kaldırma, uzun süre eğilerek çalışma veya aynı pozisyonda kalma, fazla kilo, uzun süren stres, çok doğum vb sebepler ile bel bölgesinde oluşan ani veya süreğen şiddetli zorlamalar sonucu omurlar arasındaki diskin koruyucu dış kısmının yırtılarak diskin yer değiştirmesi ve sinirleri sıkıştırması ile oluşur. \n\n\n" +
                               " Stres Kırığı ve Bel Kayması\n\n- Alt bel bölgesinde artmış hareketlilik sonucu tekrarlayan mikrotravmalar ile spondilolizis adı verilen stres kırıkları gelişebilir.Uzun süre iyileşmeyen bu kırıklar gençlikte genellikle ağrılı iken, erişkin hayatta sorun yaratmayabilir. \n\n\n" +

                               "- Bakınız: Lomber Dar kanal,Enfeksiyonlar,Tümörler\n\n";

            }
            if (urun == "Beyin")
            {
                urunResmi.sprite = AliResimler[40];
                baslik.text = "Beyin";
                konu.text =
                               "- Beyin, sinir sisteminin merkezi olarak hizmet eden bir organdır. Bütün omurgalı hayvanlar ve çoğu omurgasız hayvan -bazı süngerler, knidliler, tulumlular ve derisi dikenliler gibi omurgasızlar hariç- beyne sahiptir.\n\n\n" +
                               " Beyine İyi Gelen Besinler\n\n" +
                               "- Somon. Beyin sağlığında somonun çok önemli.\n\n" +
                               "- Yaban mersini. Beyin sağlığı ve performansını en fazla yükseltebilen yiyeceklerden.\n\n" +
                               "- Brokoli.\n\n" +
                               "- Bitter çikolata.\n\n" +
                               "- Ceviz, badem, yer fıstığı.\n\n" +
                               "- Ananas, tarçın, havuç, yeşil ve siyah çay: Polifenollerden zengin.\n\n" +
                               "- Zerdeçal.\n\n" +
                               "- Kemik suyu.\n\n" +
                               "- Yumurta.\n\n" +
                               "- Kahve.\n\n" +
                               "- D vitamini: Beynin genç kalmasını sağlayan vitaminlerden. Bu vitamin için en etkili kaynak ise güneş ışığı.\n\n" +
                               "- E vitamini: Beyin sağlığı açısından en temel antioksidanlardan birini oluşturuyor. Bu vitamin özellikle tahıllarda bolca yer alıyor. Bu nedenle bulgur, esmer pirinç, karabuğday, çavdar, kinoa, yulaf gibi besinlere günlük diyetinizde mutlaka yer verin.\n\n";



            }
            if (urun == "Az Yemek")
            {
                urunResmi.sprite = AliResimler[41];
                baslik.text = "Az Yemek";
                konu.text =
                               "\n Az Yemek Yemenin Faydaları\n\n" +
                               "- Az yemek kalbin atış ritmini ve kan pompalama faaliyetlerini belirli bir düzene sokmaktadır. Çünkü kalp yoğun besin maddelerinin kana karışma esnasında görevini doğru bir şekilde yerine getiremeyecektir.\n\n" +
                               "- Az yemenin önemli unsurlarından bir tanesi vücudun işleyişidir. Çok yemek yiyen bir insanın vücudu ağırlaşır. Bu ağırlaşma vücut içerisinde çalışan organların, canlılığını yitirmesine neden olur. Vücut böylece çok fazla yediği için sadece mide kısmına yönelecek ve diğer çalışma organlarının görevini aksatacaktır.\n\n" +
                               "- Dinç bir zihnin en büyük hazinelerinden biri az ve öz yemek yemektedir. Böylece beyine giden kan miktarı daha fazla olmakta ve vücut gereksiz besin maddelerini öğütmek için fazla çaba sarf etmeyecektir. Bu yüzden az yemek yemek dinç ve zinde bir zihnin oluşmasına katkı sağlamaktadır.\n\n" +
                               "- Az yiyen hiçbir insan bugün kilo problemiyle uğraşmaz. Çünkü vücut yağ biriktirmek ya da gereksiz mineralleri depolamak zorunda kalmamaktadır. Az yiyen bir insan kilo verebilir.\n\n\n" +
                               " Gereğinden Az Yemenin Zararları\n\n" +
                               "- Az yemenin bazı ölçüleri vardır. Bu ölçüler eğer gereğinden fazla günde tek bir öğünle atlatılmasını sağlıyorsa o zaman vücudun bağışıklık sistemi iyi bir verim sağlayamaz. Vitamin eksikliği görülür. Vücut ağırlaşır ve hastalıklara açık olur.\n\n" +
                               "- Kişinin vücudunu doğru bir şekilde tanıması ve az yeme kavramını kendi bünyesinin direncine göre belirlemesi gerekmektedir. Eğer az yemek yenilirse, vücut çeşitli baş dönmeleri yaşayacak ve kan şekeri düşerek bir takım bayılma durumları gerçekleşecektir.\n";

            }
            #endregion
        #region    01.04
            if (urun == "Bit")
            {
                urunResmi.sprite = AliResimler[42];
                baslik.text = "Bit";
                konu.text =
                               "- Bitlenme; yüzyıllardır var olan, günümüzde de tam çözümlenememiş, üstelik yalnız az gelişmiş ülkelerin değil, tüm gelişmiş ülkelerin de ortak bir sorunudur.\n\n" +
                               "- Bitlenmek utanılacak bir şey olarak düşünülür. Fakat bu saklanacak, üzüntü duyulacak bir durum değildir. \n\n" +
                               "- Bitlenmemek için temiz olmak yeterli değildir, çünkü bit temiz saça da gelir.\n\n" +
                               "- Bitin bulaşması için tek koşul bit bulaşmış bir kişiyle temas etmektir.\n\n" +
                               "- Zıplayan ya da uçabilen bir canlı olmadığı için ortak kullanılan eşyalar, yakın temas bitin bulaşmasına sebep olur.\n\n" +
                               "- Okula giden çocuklarda temas ve ortak eşya kullanımı çok, temizlik bilinci ve dikkat daha az olduğu için koşullar bitin bulaşmasına müsaittir.\n\n" +
                               "- Bit temizliğinde kullanılan tarak, toka ya atılmalı ya da bit şampuanı ile iyice temizlenmelidir.\n\n" +
                               "- Kullanılan giysi, çarşaf vb. sirkeli suda bekletilmeli ardından yüksek ısıda yıkanmalıdır. Yıkanması mümkün olmayan eşyalar ise bir torbaya koyulup ağzı sıkıca bağlanmalıdır ve 3-4 hafta kapalı şekilde bekletilmelidir. Bu yöntemle bitler ölür.\n\n" +
                               "- Eczanelerden uygun bir bit ilacı temin etmelisiniz.\n\n" +
                               "- Bit ilacını prospektüsüne uygun şekilde kullanmadığınız takdirde bitlerin yeniden oluşmasını engelleyemezsiniz.\n\n" +
                               "- Bit ilacını kullanmadan önce saçı mutlaka yağdan ve kirden temizleyin ve yağlanmaya sebep olabilecek krem gibi ürünler kullanmayın. Saç tamamen kurutulduktan sonra bit ilacını uygulayın.\n\n";

            }
            if (urun == "Boğaz Ağrısı")
            {
                urunResmi.sprite = AliResimler[43];
                baslik.text = "Boğaz Ağrısı";
                konu.text =
                               " Boğaz ağrısına neden olan viral hastalıklar arasında:\n\n" +
                               "- Soğuk algınlığı veya nezle,\n\n" +
                               "- Grip yani influenza,\n\n" +
                               "- Bitin bulaşması için tek koşul bit bulaşmış bir kişiyle temas etmektir.\n\n" +
                               "- Mono, yani enfeksiyöz mononükleoz veya halk arasındaki adıyla öpücük hastalığı,\n\n" +
                               "- Kızamık,\n\n" +
                               "- Suçiçeği,\n\n" +
                               "- Krup hastalığı, yani sert, yüksek sesli öksürük ile tanısı konulan yaygın bir çocukluk çağı hastalığı bulunur.\n\n\n" +
                               " İyi Gelen Bazı Şeyler\n\n" +
                               "- Bal. Bal ya da çaya karıştırılan bal, boğaz ağrısının giderilmesinde etkilidir.\n\n" +
                               "- Tuzlu Su.\n\n" +
                               "- Nane Çayı.\n\n" +
                               "- Ada Çayı.\n\n" +
                               "- Kabartma Tozu.\n\n" +
                               "- Çemen Otu.\n\n" +
                               "- Hatmi Kökü.\n\n" +
                               "- Papatya Çayı.\n\n";

            }
            if (urun == "Boğaz Tıkanması")
            {
                urunResmi.sprite = AliResimler[44];
                baslik.text = "Boğaz Tıkanmasında Yapılacaklar";
                konu.text =
                               "\n İlk Müdahale\n\n" +
                               "- Hastanın öne doğru eğilmesini sağlayın.\n\n" +
                               "- Hastaya hava yolunu tıkayan cismi çıkartmak için öksürmesini söyleyin.\n\n" +
                               "- Avucunuzun içi ile 5 kez kürek kemikleri arasından sırtına vurun.\n\n" +
                               "- Ağız içini kontrol edin. Gözünüze çarpan herhangi bir tıkayıcı nesneyi tutup çıkartın.\n\n\n" +
                               " Bu ilk manevra ile yabancı cisim çıkmadı ise ikinci manevraya geçin\n\n" +
                               "- Eğer sırtı tokatlamak sonuç vermedi ise, hastanın arkasına geçin.\n\n" +
                               "- Elinizi yumruk yapıp göğüs kemiğinin alt kısmına yerleştirin.\n\n" +
                               "- Diğer elinizle yumruğunuzu kavrayarak arkasından hastaya sarılın ve her üç saniyede bir göğüs kemiğini toplam beş defa içeri doğru bastırın.\n\n" +
                               "- Ağzının içini kontrol edin.\n\n\n" +
                               " Bu manevra ile de yabancı cisim çıkmadı ise üçüncü manevraya geçin\n\n" +
                               "- Elinizi yumruk yapıp hastanın karnının orta bölümüne yerleştirin.\n\n" +
                               "- Elinizi birbirine kenetleyip hastanın karnını arka arkaya beş defa kuvvetli bir şekilde içeri ve yukarı doğru çekin.\n\n" +
                               "- Ağız içini kontrol edin. \n\n\n" +
                               "!!! Bütün bu manevralara rağmen yabancı cisim hala çıkmadı ise,  AMBULANS İÇİN HIZIR ACİLİ (112) ARAYIN. Ambulans gelinceye kadar bu manevralara devam edin.\n\n";

            }
            if (urun == "Buhur")
            {
                urunResmi.sprite = AliResimler[45];
                baslik.text = "Buhur Nedir Ve Faydaları";
                konu.text =
                               "- Diğer İsimleri : Buhur, Boswellia, styrax, Frankincense, Encens\n\n" +
                               "- Tropik bölgelerde yetişen sığala ağacından elde edilen yağdır. Bu yağ ağacın salgı hücrelerinde meydana gelir.\n\n\n" +
                               " FAYDALARI \n\n" +
                               "- Nefes darlığını giderir.\n\n" +
                               "- Vücuda rahatlık verir.\n\n" +
                               "- İyi bir antiseptiktir. Yaraların temizlenmesinde ve iyileştirilmesinde dıştan uygulanır. Ciltte ve saçlı deride antiseptik ve temizleyici olarak dıştan uygulanır.\n\n" +
                               "- Ayrıca günlük yağı balgam söktürücü, nefes darlığını giderici ve bedeni rahatlatıcı etkiler taşır. Bunun için bir önceki maddedeki gibi tatlandırılıp sulandırılarak içilir.\n\n" +
                               "- Tütsü olarak kullanılır.\n\n";

            }
            if (urun == "Bulantı")
            {
                urunResmi.sprite = AliResimler[46];
                baslik.text = "Bulantı Nedir Ve Ne İyi Gelir";
                konu.text =
                               "- Mide bulantısı veya kısaca bulantı, midede kusma isteği ile birlikte oluşan rahatsızlık veren bir durum. Bulantı bir hastalık değildir ve genellikle mide veya mide ile ilgisi olmayan bazı rahatsızlıkların semptomlarından birisidir.\n\n\n" +
                               " Mide Bulantısına Ne İyi Gelir?\n\n" +
                               "- Zencefil. Zencefil, sindirim sistemi bozuklukları için son derece faydalı bir bitkidir, zira bulantıyı geçirmede çok etkili bileşenler içerir.\n\n" +
                               "- Papatya ve Rezene Çayı.\n\n" +
                               "- Nane - Limon Çayı.\n\n" +
                               "- Derin nefes alıp vererek rahatlamak.\n\n" +
                               "- Elma sirkesi.\n\n" +
                               "- Yoğurt.\n\n" +
                               "- Patates.\n\n";

            }
            if (urun == "Bunamak")
            {
                urunResmi.sprite = AliResimler[47];
                baslik.text = "Bunamak Nedir Ve Nasıl Önlenir";
                konu.text =
                               "- Demans (bunama), günlük hayatı sekteye uğratacak şiddette hafıza, düşünme ve sosyal becerileri etkileyen semptomların genel adıdır.\n\n\n" +
                               " Bunamaya Karşı Önemli Besinler\n\n" +
                               "- Haftada en az bir kez balık yemek büyük yararlar sağlıyor.\n\n" +
                               "- Çilek ve yaban mersini gibi antioksidan bakımdan zengin meyvelerin bilişsel dejenerasyonu geciktirdiği kanıtlanmış durumda.\n\n" +
                               "- Günde 30 gram kadar kabuklu yemiş ile yulaf, mısır, kabuklu pirinç, çavdar ve akdarı gibi tam tahıl ürünlerinin protein ve mineral bakımından zengin olduğu kadar bunamaya karşı da yararlı olduğuna inanılıyor.\n\n" +
                               "- Ispanak ve diğer yeşil sebzelerin zihinsel gerilemeyi yavaşlattığı biliniyor.\n\n" +
                               "- Hafif bilişsel sorunları olan kişilere B vitaminleri verildiğinde önemli ilerlemeler kaydettikleri görüldü.\n\n" +
                               "- Kakaonun sinir hücrelerini koruyucu etkisi olduğuna inanılıyor. Çikolatayı seviyorsanız şeker oranı az, kakao oranı yüksek olanlarını tercih etmelisiniz.\n\n" +
                               "- Avokadonun içerdiği sağlıklı yağların beyin sağlığına iyi geldiği biliniyor.\n\n";

            }
            if (urun == "Burun Tıkanıklığı")
            {
                urunResmi.sprite = AliResimler[48];
                baslik.text = "Burun Tıkanıklığına Ne İyi Gelir";
                konu.text =
                               "- Burun tıkanıklığını tetikleyen en önemli faktör sigara kullanımıdır. Burun tıkanıklığını önlemek için sigara kullanılıyorsa bırakılmalı ve sigara içilen ortamlardan uzak durulmalıdır.\n\n" +
                               "- Burun tıkanıklığı yaşanılan süreçte daha az miktarda süt tüketmek de burun tıkanıklığına iyi gelir.\n\n" +
                               "- Limon, zencefil, nane, tarçın, zerdeçal gibi bitki çaylarını tüketmek burun tıkanıklığına iyi gelebilir.\n\n" +
                               "- Tuzlu su burun tıkanıklığına iyi gelir. Tıkanıklığın olduğu dönemlerde buruna tuzlu çekilebilir veya denize girilebilir.  \n\n" +
                               "- Özellikle klimalı ya da kaloriferli ortamlarda bulunanlar burun tıkanıklığını engellemek için ortamı nemlendirmelidir. Buhar makinesi ya da odada kaynayan su bulundurmak burun tıkanıklığına iyi gelir.\n\n" +
                               "- C vitamini içeren sebze ve meyve tüketmek burun tıkanıklığına iyi gelir.\n\n";

            }
            if (urun == "Burun Kanaması")
            {
                urunResmi.sprite = AliResimler[50];
                baslik.text = "Burun Kanamasına Nedir Ne iyi Gelir";
                konu.text =
                               "- Epistaksis olarak da adlandırılan burun kanaması, genellikle burnunuzun iç kısmında bulunan kılcal damarların zarar görmesi nedeniyle oluşan kanamaya denir. \n\n" +
                               "- Buz kompresi. Burun kanamasını durdurmak için sık sık uygulanan yöntemlerin başında buz kompresi geliyor.\n\n" +
                               "- Merhemler. Kanama darbe sonucu gerçekleşmişse ağrı kesici özellikli merhemler ve kremler kullanılabilir.\n\n" +
                               "- Koterizasyon.\n\n" +
                               "- Burun içi serum.\n\n";

            }
            if (urun == "Böbrek Taşı")
            {
                urunResmi.sprite = AliResimler[51];
                baslik.text = "Böbrek Taşı Nedir Ne Yapılmalı";
                konu.text =
                               "- Böbrek kanalları içerisinde genellikle bilinmeyen nedenlere bağlı olarak bazı minerallerin birleşerek oluşturduğu sert yapılara böbrek taşı adı verilir.\n\n\n" +
                               " Ne İyi Gelir:\n\n" +
                               "- Bol lifli besinleri tüketmek.\n\n" +
                               "- Ürik asit taşları için; pürin içeren protein değeri yüksek sardalya, sakatat, kuru bakliyat, mantar, ıspanak, karnıbahar, et tüketimi, bira ve benzeri alkollü içecekleri kısıtlamak.\n\n" +
                               "- Tuz kullanımını azaltmak.\n\n" +
                               "- Bol bol hareket edip egzersiz yapmak, kilodan kaçınmak.\n\n";

            }
            if (urun == "Büyü")
            {
                urunResmi.sprite = AliResimler[52];
                baslik.text = "Büyü Nedir";
                konu.text =
                               "- Büyü veya sihir, insanların doğaüstü, paranormal veya mistik yöntemlerle doğal dünyayı (olayları, nesneleri, insanları) etkileyebildiğini öne süren uygulamalar ve bunların çevresinde oluşturulan kültürel sistem.\n\n" +
                               "- Popüler kültürde sık rastlanılan büyü yapma yöntemleri arasında; çeşitli malzemelerden karışımlar hazırlama, büyülü sözcükler söyleme veya hareketler yapma, büyülü yazılar veya semboller çizme, sihirli değnek gibi araçlar kullanma, belirli bir kişiyi sembolize eden kuklalar kullanma, kan veya hayvan yağı kullanma sayılabilir.\n\n" +
                               "- Büyüler zengin, sağlıklı veya başarılı olmak, birine yardım etmek gibi iyi amaçlarla veya birini cezalandırmak gibi kötü amaçlarla da icra edilebilir.\n\n" +
                               "- Büyü ile uğraşan kişiler büyücü ya da sihirbaz olarak tanımlanır. Günümüzde 'sihirbazlık' sözcüğü sıklıkla bir sahne sanatı olan 'hokkabazlıkla' eşanlamlı kullanılır.\n\n" +
                               "- İslam'da büyü yapmak, tıpkı fal bakmak gibi açıkça haram kabul edilir.\n\n";

            }
            #endregion
        #region    02.04
            if (urun == "Çarpık")
            {
                urunResmi.sprite = AliResimler1[0];
                baslik.text = "Çarpık ayak hastalığı";
                konu.text =
                               "- Ayaklardan birinin veya her ikisinin birden doğal pozisyonunda hafifçe içe ve aşağı doğru olmasıyla seyreden ve bebeklik döneminde ortaya çıkan bir hastalıktır.\n\n" +
                               "- Hastaların yarısında sadece tek ayak etkilenirken, diğer yarısında iki ayak birden etkilenmektedir.\n\n";

            }
            if (urun == "Çakal Kavunu")
            {
                urunResmi.sprite = AliResimler1[1];
                baslik.text = "Çakal Kavunu Faydaları";
                konu.text =
                               "- Ağrı kesicidir.\n\n" +
                               "- Damarları açar.\n\n" +
                               "- Saç sağlığına iyi gelir.\n\n" +
                               "- Kanamayı durdurur.\n\n" +
                               "- Hemoroide iyi gelir.\n\n" +
                               "- Kulak çınlamasını geçirir.\n\n" +
                               "- Damak kanamasını durdurur.\n\n" +
                               "- Diş çekimini kolaylaştırır.\n\n";

            }
            if (urun == "Çamurla Tedavi")
            {
                urunResmi.sprite = AliResimler1[2];
                baslik.text = "Çamurla Tedavi Ne İçin Kullanılır";
                konu.text =
                               "- Kas ve iskelet sistemi hastalıkları.\n\n" +
                               "- kronik ağrı durumları.\n\n" +
                               "- Romatizmal hastalıklar.\n\n" +
                               "- Ankilozan spondilit.\n\n" +
                               "- Romatoid artrit.\n\n" +
                               "- Psöriatik artrit.\n\n" +
                               "- Dejeneratif eklem hastalıkları (artrozlar).\n\n" +
                               "- Omurganın dejeneratif hastalıkları.\n\n" +
                               "- Bel fıtığı tedavisi.\n\n" +
                               "- Boyun fıtığı tedavisi.\n\n" +
                               "- Osteoporoz, fibromiyalji sendromu, spor yaralanmaları, kaza sonrası operasyonlar.\n\n";

            }
            if (urun == "Çam Fıstığı")
            {
                urunResmi.sprite = AliResimler1[3];
                baslik.text = "Çam Fıstığı Faydaları";
                konu.text =
                               "- Yağ asidi içeriği sayesinde iştahı bastırır ve kilo vermeye yardımcı olur.\n\n" +
                               "- Çam fıstığındaki besin maddelerinin mükemmel kombinasyonu enerjiyi artırırken, magnezyum ve protein gibi diğer önemli mineraller kalp krizlerini ve şeker hastalığını önlemeye yardımcı olur.\n\n" +
                               "- Karmaşık bir moleküle sahip olan bu besinin vücutta parçalanması daha uzun sürer. Bu sayede tükenmişliğe neden olmadan sürekli ve uzun süreli enerji sağlar.\n\n" +
                               "- Vücuttaki romatizmal ağrılara iyi gelir.\n\n" +
                               "- Hamile anneler için çok faydalıdır. Bebeğin gelişimini destekler.\n\n" +
                               "- Yüksek miktardaki C vitamini sayesinde bağışıklık sistemini güçlendirir.\n\n" +
                               "- Cinsel isteksizliği giderir, sperm sayısının artışında önemli bir rol oynar.\n\n" +
                               "- Çam fıstığı içindeki pinolenik asit sağlıklı kolesterolü destekler ve hatta kötü kolesterol seviyesini düşürmeye yardımcı olur.\n\n" +
                               "- Araştırmalara göre, her gün çam fıstığı yemek tip 2 diyabetin kontrolüne yardımcı olabilir.\n\n" +
                               "- Çam fıstığı, demir bakımından zengindir. Demir ise beyin sağlığı için çok önemlidir.\n\n" +
                               "- İçeriğindeki magnezyum ile kansere karşı savaşır, kanser riskinin azalmasını sağlar.\n\n";

            }
            if (urun == "Çatlak")
            {
                urunResmi.sprite = AliResimler1[4];
                baslik.text = "Çatlağa Ne İyi Gelir";
            konu.text =
                           "\n Şeker Peelingi\n\n" +
                           "- Zamanla kalınlaşan cildi ölü derilerden arındırmak için en uygun yöntemlerden birisi olan şeker, aslında tek başına etkili bir peeling görevi görmektedir.\n\n" +
                           "- Karın, kol ve bacak bölgesini arındırmada oldukça etkili olan şeker sayesinde zamanla derinleşmiş çatlakları hızlı bir şekilde en aza indirgeyebilirsiniz.\n\n" +
                           "- Aynı zamanda kullanacağınız şekeri içerisine tercihe göre ilave edeceğiniz doğal yağlar sayesinde aşırı kuru ve gergin olan çatlakları ekstra nemlendirerek ortadan kaldırabilirsiniz.\n\n\n" +
                           " Aloe Vera\n\n" +
                           "- Çok uzun yıllardır pek çok cilt problemini iyileştirmede etkili olan aloe vera, güçlü bileşenleri sayesinde çatlaklar için de etkili bir çözümdür.\n\n" +
                           "- İster aloe vera yaprağı, ister jel aloe vera jeli kullanarak çatlakları çok kısa bir zamanda gözle görülür oranda iyileştirebilirsiniz.\n\n\n" +
                           " Zeytinyağı\n\n" +
                           "- Pek çok kozmetik ya da kimyasal ürünün cildinize vereceği tahrişten endişe ediyorsanız çatlaklar için zeytinyağı ile doğal ve yumuşacık bir alternatif oluşturabilirsiniz.\n\n" +
                           "- Çatlaklara iyi gelen yağların başında gelen zeytinyağı cildiniz için mükemmel bir nemlendirici etkisi sağlamaktadır. Bu sayede aşırı gerilen ve çatlayan deriyi hızla onarabilirsiniz.\n\n\n" +
                           " Yumurta Akı\n\n" +
                           "- Ciltteki kusurları onarmada ve iyileştirmede oldukça etkili olan yumurta akı, içeriğindeki aminoasit ve protein sayesinde deri hücrelerini yoğun bir şekilde onarır.\n\n" +
                           "- Şikayetçi olduğunuz bölgeye haftada 2 ya da 3 defa masaj yaparak yumurta akı uygulayabilir, çatlaklardan hızlı ve etkili şekilde kurtulabilirsiniz.\n\n\n" +
                           " Limon Suyu\n\n" +
                           "- İçeriğindeki asit sayesinde cildi yenileme işlevi gören limon suyu aynı zamanda derinin toparlanmasında da ekstra etkili olmaktadır.\n\n" +
                           "- Gün içerisinde hızlı ve pratik şekilde uygulayabileceğiniz bu yöntem sayesinde çatlaklarınızı en aza indirgeyebilir ve sorunlu bölgeyi hızla onarabilirsiniz.\n\n\n" +
                           " Patates Suyu\n\n" +
                           "- Pürüzsüz ve ışıl ışıl bir cildin temel formülleri arasında yer alan patates suyu, tek başına bile parlak ve canlı bir cilde kavuşmak için yeterlidir. İçeriğindeki mineraller ve vitaminler sayesinde cildin büyümesine, yenilenmesine ve onarılmasına katkı sağlayan patates suyu çatlakları ve çatlak izlerini kısa bir süre içinde ortadan kaldırır.\n\n\n" 
                           ;
                           

            }
            if (urun == "Cenin")
            {
                urunResmi.sprite = AliResimler1[5];
                baslik.text = "Cenin Nedir";
                konu.text =
                               "- Üç aylıktan itibaren doğuma kadar geçen zamana 'cenin dönemi' adı veriliyor   \n\n" +
                               "- Fetus bir diğer adıyla Cenin, üçüncü gebelik ayı başından doğuma kadarki devre içinde ana rahmindeki canlıya verilen addır.\n\n";

            }
            if (urun == "Çemen Otu")
            {
                urunResmi.sprite = AliResimler1[6];
                baslik.text = "Çemen Otu Faydaları";
                konu.text =
                               "- Sindirim sisteminin düzenli çalışmasını sağlar.\n\n" +
                               "- Gaz ve şişkinliğin giderilmesinde etkilidir.\n\n" +
                               "- Kan şekerini düzenler.\n\n" +
                               "- Vücudun toksinlerden arınmasına yardımcı olur.\n\n" +
                               "- Kronik öksürüğün sonlandırılmasını sağlar.\n\n" +
                               "- Kadınların menopoz dönemlerini rahat geçirmelerine yardımcı olur.\n\n" +
                               "- Kalp krizi riskini azaltır.\n\n" +
                               "- Bağışıklık sistemini güçlendirir. Yara ve iltihapların kısa sürede iyileşmesini sağlar.\n\n" +
                               "- Kandaki yağı, karaciğerdeki toksinleri temizleyerek, cilt hastalığına yakalanma riskini azaltır.\n\n" +
                               "- İçinde barındırdığı demir sayesinde kansızlığa iyi gelir. \n\n";

            }
            if (urun == "Cerrah")
            {
                urunResmi.sprite = AliResimler1[7];
                baslik.text = "Cerrah Nedir";
                konu.text =
                               "- Cerrahlar, hastalarına koruyucu sağlık hizmetleri konusunda danışmanlık yapar ve önleyici ve elektif ameliyatlar gerçekleştirir.\n\n" +
                               "- Nörolojik cerrahi, ortopedik cerrahi ve plastik veya rekonstrüktif cerrahi dahil olmak üzere birçok uzmanlık alanı bulunmaktadır.\n\n" +
                               "- Nasıl cerrah olunacağına odaklanırken, adaylar eğitim, ikamet ve lisans bileşenlerini göz önünde bulundurmalıdır.\n\n";

            }
            if (urun == "Çıkık")
            {
                urunResmi.sprite = AliResimler1[8];
                baslik.text = "Çıkık Nedir Belirtileri Ve İlk Yardımı";

            konu.text = "\n- Çıkık, eklemlerin yaralanmasıdır. Çıkıklar genellikle bir eklem beklenmeyen veya dengesiz bir etki yaşarsa ortaya çıkar. Bu ağrılı yaralanma, ekleminizi geçici olarak deforme eder ve hareketsizleştirir. Çıkık omuzlarda ve parmaklarda en yaygın olanıdır. Diğer yerler dirsek, diz ve kalçadır. Bir eklem yerinden çıktıktan sonra, gelecekte tekrar yerinden çıkması daha olasıdır.\n\n\n" +
                       " Çıkık Belirtileri Nelerdir?\n\n" +
                       "- Hareket ederken şiddet derecesi değişkenlik gösteren ağrı ya da sızı.\n\n" +
                       "- Şişlik ve kızarıklık.\n\n" +
                       "- Bir müddet hareket kısıtlılığı yaşama.\n\n" +
                       "- Eklem bozukluğu.\n\n" +
                       "- Bölgede anormal gözüken şekil bozukluğu\n\n" +
                       "- Çıkığın bulunduğu bölge ya da yakınında uyuşukluk hissi." +
                       "- Çıkığın olduğu bölgede karıncalanma hissi.\n\n\n" +
                       " Çıkıkta İlk Yardım Nasıl Olmalıdır?\n\n" +
                       "- Eklem aynen bulunduğu şekilde tespit edilir.\n\n" +
                       "- Çıkık yerine oturtulmaya çalışılmaz.\n\n" +
                       "- Hasta / yaralıya ağızdan hiçbir şey verilmez.\n\n" +
                       "- Bölgede nabız, deri rengi ve ısısı kontrol edilir.\n\n" +
                       "- Tıbbi yardım istenir (112).\n\n";



        }
            if (urun == "Çiçek Hastalığı")
            {
                urunResmi.sprite = AliResimler1[9];
                baslik.text = "Çiçek Hastalığı";
                konu.text =
                               "- Her yaşta ve her cinste kişilerde görülen, irinli kabarcıklar dökerek yüzde izler bırakan, ateşli, ağır ve bulaşıcı bir hastalıktır. Variola da denir.\n\n" +

                               "- Hastalığın aşısını İngiliz cerrah Edward Jenner'ın bulduğu kabul edilir.\n\n" +
                               "- Basit Tip: Sivilceler birbirinden ayrıdır ve hastalığın gidişatı iyidir.\n\n" +
                               "- Konflüan Tip: Sivilceler bir araya gelerek yüzeysel abseler oluştururlar. Hastalığın gidişatı kötüdür.\n\n" +
                               "- Hemorajik Tip: Sivilcelerde, mukozalarda ve göz konjonktivasında kanamaların görüldüğü çiçek hastalığının en ağır ve öldürücü tipidir.\n\n";

            }
            if (urun == "Cilt")
            {
                urunResmi.sprite = AliResimler1[10];
                baslik.text = "Cilte İyi Gelen Şeyler";
                konu.text =
                               "- Yumuşacık Pürüzsüz Ciltler: Bal ve Zeytinyağı Variola da denir.\n\n" +

                               "- Doğadan Gelen Nem Mucizesi Aloe Vera.\n\n" +
                               "- Avokado\n\n" +
                               "- Arındırıcı ve Dengeleyici Elma Sirkesi.\n\n" +
                               "- Üçü Bir Arada: Muz, Yulaf ve Bal ile Ekstra Canlılık.\n\n";

            }
            if (urun == "Cilt Hastalığı")
            {
                urunResmi.sprite = AliResimler1[11];
                baslik.text = "Cilt Hastalıkları Nelerdir";
                konu.text =
                               "\n Akne\n\n" +
                               "- Aknenin toplumda bilinen yaygın adı sivilcedir. Aknenin oluşmasını tetikleyen birkaç etken vardır. Genel olarak deri altında yağ üretimi ile görevli bezlerin ve kıl köklerinin çeşitli nedenlerden dolayı tıkanmasından dolayı insanlarda akne oluşumu gözlenir.\n\n" +
                               "- İnsan vücudunun cildi nemli tutmayı sağlayan sebum üretimini artırması, gereksiz olan sebum hücrelerinin ölmesine neden olur. Bunun sonucunda ölü sebum hücrelerinin gözeneklere sıkışması sonucunda beyaz ya da siyah nokta oluşumu gözlenir. Bu durumda insan vücudunda yaşayan bakteriler, gözenekler içinde hapsolur ve akneler ortaya çıkar.\n\n\n" +
                               " Egzama\n\n" +
                               "- Egzama, cildin kızarmasına ve kaşınmasına neden olan bir tür cilt hastalığıdır. Bilimsel olarak atopik dermatit olarak adlandırılan egzama, bazı hastalarda kronik olabilir, bazı hastalarda ise dönem dönem ortaya çıkar. Kronik egzama hastalarının ömür boyu bu hastalıkla yaşamaya alışması gerekir.\n\n" +
                               "- Henüz egzamanın kesin bir tedavisi bulunabilmiş değildir. Ancak uygulanan tedaviler ve kişisel bakımlar egzamanın ortaya çıkardığı kaşıntıyı önleyebilir ve yeni salgınların ortaya çıkmasının önüne geçebilir.\n\n\n" +
                               " Kurdeşen (Ürtiker)\n\n" +
                               "- Kurdeşen ciltte ortaya çıkan ve kısa sürede kaybolan, böcek veya sinek ısırığına benzeyen, kırmızı veya ten rengi şeklindeki küçük yumrulardır. Deri döküntülerinin kurdeşen olma ihtimali vardır ve bu döküntülere kaşıntı eşlik eder. Çizilme, alkollü içecekler, egzersiz veya duygusal değişimler kurdeşenin ve kaşıntının şiddetini artırabilir.\n\n\n" +
                               " Sedef Hastalığı\n\n" +
                               "- Sedef hastalığının oluşmasında artan cilt hücresi üretimi etkilidir. Sedef ciltte pullarla kaplı, kırmızı, kabuklu lekelerin oluşmasına neden olur. Bazı hastalarda kaşıntı ve ağrı gözlenir. Hastalığın tedavisi için D vitamini analogları veya topikal kortikosteroidler kullanılır. Bu uygulamalar, kremler ve merhemler ile sağlanır.\n\n\n" +
                               " Cilt Kanseri\n\n" +
                               "- Cilt kanseri, cilt hücrelerinin anormal olarak büyümesi ile genel olarak yoğun şekilde güneşe maruz kalan insanlarda görülür. Ancak yalnızca cildin güneş gören bölgelerinde ortaya çıkmaz. Vücudun her noktasında cilt kanseri görülme olasılığı vardır. Bazal hücreli karsinom, yassı hücreli karsinom ve melanom olarak üç farklı şekilde görülür. Ultraviyole ışınlara maruz kalma süresi azaltılarak cilt kanserinden kaçınılabilir.\n\n" +
                               "- Güneşin yoğun olduğu zamanlarda vücut kremi kullanmadan güneşe çıkmak riski artırır.\n";

            }
            if (urun == "Cücelik")
            {
                urunResmi.sprite = AliResimler1[12];
                baslik.text = " Cücelik ";
                konu.text =
                               "\n- Boyu normalden çok daha kısa olanların yaşadığı durum. Cücelik hayvanlarda, insanlarda ve bitkilerde meydana gelebilir.\n\n" +

                               "- İnsanlarda cücelik sebepleri; doğuştan cücelik ve bazı hastalıklar sebebi ile sonradan meydana gelen cücelik olarak iki grupta incelenebilir.\n\n" +
                               "- Yetişkin bir insanın, cüce sayılma boyu umumiyetle bir ile bir buçuk metre arasında değişmektedir.\n\n" +
                               "- Orantısız cücelikte kısa ekstremiteler veya kısa bir gövde mevcuttur.\n\n" +
                               "- Orantılı cücelikte ise hem ekstremite hem de gövde olağan dışı derecede küçüktür.\n\n" +
                               "- Cüceler, normal zeka ve ömüre sahiptirler.\n\n";

            }
            if (urun == "Cüzzam")
            {
                urunResmi.sprite = AliResimler1[13];
                baslik.text = "Cüzzam Nedir";
                konu.text =
                               "- Enfeksiyona bağlı olarak oluşan bir hastalıktır\n\n" +

                               "- Kendi kendine sınırlanan veya ilerleyici olabilen bölgesel ya da geniş yayılımlı bir hastalık tablosu vardır.\n\n" +
                               "- Cüzzam esas olarak sinirleri, deriyi, üst solunum yolunu, gözü, kemikleri ve testisleri tutar.\n\n\n" +
                               " Belirtileri Nelerdir?\n\n" +
                               "- Vücudun herhangi bir yerinde deriden açık renkte, oval veya yuvarlak, kabarık olmayan, hiçbir şikâyet yaratmayan kepeksiz, bazen hafif duyu kusuru gösteren leke.\n\n" +
                               "- Çocuklarda ve gençlerde burunda sürekli tıkanma ve sık sık tekrarlayan burun kanamaları.\n\n" +
                               "- Deri üzerinde bir veya daha fazla kabarık plak şeklinde, kılsız, terlemeyen, kepekli, mutlaka duyu kusuru olan lezyonlar.\n\n" +
                               "- Belirli yerlerde özellikle ön kol iç yüzde duyu eksilmesi.\n\n" +
                               "- Yüzde ödem, alın derisi ve kulakların morumsu kabarık sert nodüllerle dolması.\n\n" +
                               "- Alt göz kapaklarının kapanmaması.\n\n";

            }
            #endregion                        
        #region                             04.04
        if (urun == "Civit Otu")
        {
            urunResmi.sprite = AliResimler1[14];
            baslik.text = "Civit Otu Faydaları";
            konu.text = "- Grip sorununa karşı bağışıklığı güçlendirir.\n\n" +
            "- Boğazdaki tahriş ve kaşıntıları içeriğindeki maddeler sayesinde önleyebiliyor.\n\n" +
            "- Ayrıca gripten meydana gelebilecek nefes darlığı, bronş sorunlarına karşı koruma görevi görebiliyor.\n\n" ;
        }
        if (urun == "Çok Yemek")
        {
            urunResmi.sprite = AliResimler1[15];
            baslik.text = "Çok Yemenin Zararları";
            konu.text = 
                "- Aşırı yemek yendiğinde, sindirimin, dolaşımın ve boşaltımın yapılabilmesi için Kalp 4 ile 6 kat daha fazla yorulur.\n\n" +
                "- Sadece kalp değil, tüm sindirim, depolama ve boşaltım sisteminde ki tüm organlar bu işten hayliyle etkilenir.\n\n" +
                "- Mide de çok fazla enzim üretmesine ihtiyaç vardır.\n\n" +
                "- Fazla enzim üretmek için fazla enerji gerekmektedir.\n\n";
        }
        if (urun == "Çörek Otu")
        {
            urunResmi.sprite = AliResimler1[16];
            baslik.text = "Çörek Otu Faydaları";
            konu.text =
                "- Öksürüğe iyi gelir.\n\n" +
                "- Hazmı kolaylaştırır.\n\n" +
                "- İdrar söktürücüdür.\n\n" +
                "- Grip tedavisinde kullanılabilir.\n\n" +
                "- Baş ağrısını hafifletir.\n\n" +
                "- Romatizmal hastalıklara iyi gelir.\n\n" +
                "- Adet rahatsızlıklarını hafifletici etkisi vardır.\n\n" +
                "- Yaraların çabuk iyileşmesini ve hücrelerin yenilenmesini hızlandırır.\n\n" +
                "- Çörek otu ekstresi opioid bağımlılığı ile ilgili semptomları azaltır.\n\n" +
                "- Çörek otu özü, boğaz ağrısı ve şişmiş bademciklere iyi gelir.\n\n";
        }
        if (urun == "Çöven Otu")
        {
            urunResmi.sprite = AliResimler1[17];
            baslik.text = "Çöven Otu Faydaları";
            konu.text =
                "- Çöven otu çayı balgam söktürücü özelliği vardır.\n\n" +
                "- Romatizma ağrılarını azaltır.\n\n" +
                "- Çöven otu sabunu cilt kaşıntılarının azalmasında oldukça etkilidir.\n\n" +
                "- Akne tedavisinde çöven otu sabunu çok faydalıdır.\n\n" +
                "- Az miktarda ve düzenli kullanımda çöven otu çayı bağırsakları temizler.\n\n" +
                "- Regl ağrılarında çöven otu çayı ağrı kesici olarak kullanılır.\n\n" +
                "- Kabızlık problemlerini giderilmesinde çöven otu çayının faydaları büyüktür.\n\n" +
                "- Bronşit şikayetlerinde destekleyici tedavi olarak çöven otu çayı kullanılır.\n\n";
        }
        if (urun == "Dalak")
        {
            urunResmi.sprite = AliResimler1[18];
            baslik.text = "Dalak Nedir Ne İyi Gelir";
            konu.text =
                "- Yaklaşık olarak yumruk büyüklüğünde, sol kaburganın hemen altında, mideyle komşu bir organdır. Kırmızı kan hücrelerini filtrelemesi ve vücudu enfeksiyonlara karşı koruması nedeniyle bağışıklık sisteminde oldukça önemli bir role sahiptir.\n\n" +
                "- Dalak sorunları için en önemlisi gün içerisinde yeterli miktarda su içmektir.\n\n" +
                "- Çiğ meyve ve sebze tüketimi de dalağın fonksiyonlarının etkin çalışmasına yardımcı olmaktadır.\n\n" +
                "- Zencefil dalak sorunlarına iyi gelen gıdaların içerisinde yer almaktadır.\n\n" +
                "- Dalak sağlığı için en önemli gıdalardan birisi de balıktır. \n\n" +
                "- Dalağı iyileştirmede özellikle Maitake mantarı büyük bir öneme sahiptir.\n\n" +
                "- Semiz otu ise dalağın çalışmasını olumlu bir şekilde etkilemektedir.\n\n" +
                "- Dalak sağlık sorununuz veya dalak büyümesi gibi sorunlarınız varsa, lahana sizlere iyi gelecektir.\n\n";
        }
        if (urun == "Damar")
        {
            urunResmi.sprite = AliResimler1[19];
            baslik.text = "Damar Nedir Ne İyi Gelir";
            konu.text =
                "- Damar ile farklı şeyler kastediliyor olabilir: Kan damarı, vücutta kanı taşıyan kanallar. Lenf damarı, ince duvarlı, vücutta lenfi taşıyan kanallar\n\n" +
                "- Damar tıkanıklığının giderilmesi için damar açıcı bitki ve gıdalar tüketilmelidir.\n\n" +
                "- Özellikle kepekli tahıl, yulaf ezmesi ve fasulye tüketimi de arttırılmalıdır.\n\n" +
                "- Yüksek lif oranına sahip olan besinler kötü kolesterolü düşürür\n\n" +
                "- Kötü kolesterolün düşmesi ile birlikte damar tıkanıklığı gibi sorunlar da ortadan kalkar.\n\n" ;
        }
        if (urun == "Damar Sertliği")
        {
            urunResmi.sprite = AliResimler1[20];
            baslik.text = "Damar Sertliği Nedir ve Nedenleri";
            konu.text =
                "- Ateroskleroz hastalığına sahip olan bireylerde damar duvarlarında kolesterol birikmesi ve bağ dokusu oluşumunun artması sebebiyle sertleşme ve esneklik kaybı ortaya çıkar.\n\n" +
                "- Damarların sertleşen bu kısımlarından iç kısımlara doğru oluşan aterom plakları, zamanla damarın tıkanmasına ve kan akışının engellenmesine neden olarak ölümle sonuçlanabilen ciddi sorunlara zemin hazırlar. \n\n" +
                "- Özellikle beyin kanaması, kalp krizi gibi en çok ölüme sebebiyet veren hastalıkların birçoğunda temel neden damar sertliğidir.\n\n\n" +
                " Nedenleri:\n\n" +
                "- Erkek cinsiyet.\n\n" +
                "- Kadınlarda menopoz sonrası dönemde östrojen hormonunun koruyucu etkisinin azalması.\n\n" +
                "- Sigara tüketimi.\n\n" +
                "- Yüksek tansiyon.\n\n" +
                "- Şeker hastalığı ve obezite.\n\n" +
                "- Yetersiz fiziksel aktivite.\n\n" +
                "- Sağlıksız beslenme.\n\n" +
                "- Stresli yaşam.\n\n";
        }
        if (urun == "Deniz Suyu")
        {
            urunResmi.sprite = AliResimler1[21];
            baslik.text = "Deniz Suyunun Faydaları";
            konu.text =
                "- Bağışıklık sistemini güçlendirmek en başta gelir.\n\n" +
                "- Dolaşımı arttırır, vücudunuzdaki kan dolaşımını kolaylaştırır. \n\n" +
                "- Cilt sağlığını destekler. \n\n" +
                "- Stres ve depresyonla mücadele eder.\n\n" +
                "- Uykusuzluğu tedavi eder. \n\n" +
                "- Üst solunum yolu sorunlarına iyi gelir.\n\n" +
                "- Karaciğer ve böbrek sorunlarıyla mücadele eder.\n\n" ;
        }
        if (urun == "Depresyon")
        {
            urunResmi.sprite = AliResimler1[22];
            baslik.text = "Depresyon";
            konu.text =
                "\n- Depresyon (majör depresif bozukluk) nasıl hissettiğinizi, nasıl düşündüğünüzü ve nasıl davrandığınızı olumsuz etkileyen yaygın ve ciddi ancak tedavi edilebilen tıbbi bir hastalıktır.\n\n" +
                "- Depresyon sürekli üzüntü halinde olmaya ve zevk veren durumlardan keyif almamaya yol açar \n\n\n" +
                " Depresyon Türleri: \n\n" +
                "- Anksiyete Sıkıntısı: Olağandışı huzursuzluk ya da olası olaylar veya kontrol kaybı hakkında endişe ile depresyon\n\n" +
                "- Atipik Özellikler: Bazı olaylardan geçici olarak mutlu olabilme, iştah artışı, aşırı uyku ihtiyacı, reddedilmeye karşı aşırı duyarlılık ve uzuvlarda ağırlık hissi ile görülen depresyon.\n\n" +
                "- Karışık Özellikler: Yüksek benlik saygısı, ve çok fazla konuşma içeren depresyon ile eş zamanlı enerjik mani\n\n" +
                "- Katatoni: Kontrol edilemeyen motor aktivitesi ile amaçsız hareketler içeren veya sabit ve katı duruşlarla görülen depresyon.\n\n" +
                "- Melankolik Özellikler: Bir zaman keyif getiren bir şeye karşı tepkilerde soğuma ile görülen depresyon, sabah erken uyanma sürecinde kötüleşen ruh hali, halsizlik veya ajitasyon ile beraber görülebilir depresyon.\n\n" +
                "- Mevsimsel Özellikler: Mevsim değişiklikleri ve güneş ışığına daha az maruz kalma ile tetiklenen depresyon.\n\n" +
                "- Peripartum Başlangıc: Hamilelik sırasında veya doğumdan sonraki hafta veya aylarda, yani postpartum dönemde ortaya çıkan depresyon.\n\n" +
                "- Psikotik Özellikler: Kişisel yetersizlik veya diğer olumsuz içeren hezeyanlar ya da halüsinasyonlar tarafından eşlik edilen depresyon.\n\n";
        }
        if (urun == "Deve Hastalığı")
        {
            urunResmi.sprite = AliResimler1[23];
            baslik.text = "Deve Hastalığı";
            konu.text =
                "- Dev hastalığı, hipofiz bezinden büyüme hormonunun fazla salınması neticesinde ortaya çıkar.\n\n" +
                "- Bilimsel olarak jigantizm denir. Ergenlikten önce ortaya çıkan bu hastalıkta kemikler kapanmadığından dolayı boy uzaması ve eklemlerde büyüme görülebilir.\n\n" +
                "- Akromegali ve jigantizmin tedavisindeki birinci unsur, cerrahi olarak bunu salgılayan kitlenin çıkarılmasıdır.\n\n" +
                "- Daha sonra gama knife dediğimiz yöntemle ışın tedavisi uygulanabilir.\n\n" +
                "- Bu kişilerde genellikle ömür boyu ilaç tedavisi uygulanır.\n\n"  ;
        }
        if (urun == "Dil")
        {
            urunResmi.sprite = AliResimler1[24];
            baslik.text = " Dil ";
            konu.text =
                "\n- Dil, ağız içinde bulunan ve tat alma duyusunu gerçekleştiren, kaslardan yapılmış bir organdır. Ayrıca yiyecekleri çiğneme ve yutma işlemlerine yardım eder, insanlarda konuşmayı da sağlar.\n\n\n" +
                " Dil Yarasına İyi Gelenler:\n\n" +
                "- Bal. Bal hem antibakteriyel özellikler gösterdiği iltihaplı bölgelerin hızla iyileşmesine yardımcı oluyor hem de yatıştırıcı özelliği sayesinde kısa sürede ağrı ve acıları dindirebiliyor.\n\n" +
                "- Lavanta yağı-su. \n\n" +
                "- Şalgam suyu. \n\n" +
                "- Kabartma tozu-su.  \n\n" +
                "- Karbonat-su  \n\n" +
                "- Tuz-su.\n\n";
        }
        #endregion
        #region 05.04
        if (urun == "Dilcik")
        {
            urunResmi.sprite = AliResimler1[25];
            baslik.text = "Dilcik Diye Neye Denir";
            konu.text =
                "\n- Küçük dil.\n\n" +
                "- Buğdaygillerde, yaprak ayası ile yaprak kınının birbirinden ayrıldığı yerde bulunan sivri uçlu, küçük, saydam çıkıntı.\n\n" +
                "- Böceklerin ağzında küçük dilin önünde bulunan bölüm\n\n" +
                "- Üflemeli çalgılarda veya org borularında kamış, tahta veya metalden yassı parça.\n\n" +
                "- Anadolu ağzında kadın cinsel organı.\n\n" ;
        }
        if (urun == "Diş")
        {
            urunResmi.sprite = AliResimler1[26];
            baslik.text = "Diş";
            konu.text =
                "\n- Diş; mine, dentin, sement ve pulpadan (diş özü) oluşur.\n Mine: vücuttaki en sert maddedir.\n\n\n" +
                " Diş Ağrısına Ne İyi Gelir\n\n" +
                "- Diş ağrısı şişkinlikle ilişkiliyse, yanağınızın dışına (20 dakika aralıklarla 20 dakika boyunca) soğuk bir kompres tutmak biraz rahatlama sağlayabilir.\n\n" +
                "- Karanfil yağı, diş ağrısı ile ilişkili ağrı ve şişliği geçici olarak azaltmak için kullanılabilir. Bu ev yapımı diş ağrısı ilacı için bir pamuk topuna birkaç damla karanfil yağını emdirin. Pamuk topunu nazikçe dişinizin ve diş etinizin ağrılı bölgesine sürtün.\n\n" +
                "- Bir bardak ılık suya birkaç çay kaşığı tuz ekleyin. Karışımı ağzınızın etrafında gezdirin ve sonra suyu tükürün.(bu etkiler sadece geçici çözümlerdir.)\n\n" ;
        }
        if (urun == "Diş Törpüleme")
        {
            urunResmi.sprite = AliResimler1[27];
            baslik.text = "Diş Törpüleme Ne İşe Yarar";
            konu.text =
                "- Ağız içerisinde bulunan dişlerin, belli başlı çıkan sorunlar karşısında aşındırma yönteminin uygulanmasına denir.\n\n" +
                "- Diş törpüleme işlemi dişte bir kırık meydana geldiğinde, diş üzerinde meydana gelen sararma veya lekelenme gibi sorunlar karşısında da yapılabilir.\n\n" +
                "- Diş törpüleme işlemi genellikle yetişkinlerde yapılabilen bir eylemdir. \n\n\n" +
                " Diş törpüleme işlemi genellikle şu nedenlerden dolayı gerek görülmektedir:\n\n" +
                "- Dişlerde meydana gelen yamukluklar.\n\n" +
                "- Dişlerin ağız yapısına büyük gelmesi.\n\n" +
                "- Dişlerde bulunan, rahatsız eden pütürlükler.\n\n" +
                "- Dişlerin bazılarının kırılmış olması ve ağız içerisinde kesiklikler meydana getirmesi.\n\n" +
                "- Diş boylarında bulunan orantısızlıklar.\n\n" +
                "- Dişlere porselen kaplama yapılması.\n\n" ;
        }
        if (urun == "Doğum")
        {
            urunResmi.sprite = AliResimler1[28];
            baslik.text = "Doğum";
            konu.text =
                "\n- Doğum, türe özgü normal gebelik süresi sonunda yavrunun dünyaya geliş sürecidir. İnsanlarda doğum zamanı, fetusun anne karnından çıktığı an olarak tanımlanır.\n\n\n" +
                " Gebelikte En Yararlı Besinler:\n\n" +
                "- Süt, Yoğurt, Peynir: Kalsiyum, protein.\n\n" +
                "- Yeşil Yapraklı Sebzeler: C vitamini, lif, folik asit, yağsız kırmızı et: protein, demir.\n\n" +
                "- Sardalye: Kalsiyum, demir, protein.\n\n" +
                "- Portakal: C vitamini, lif.\n\n" +
                "- Balık: Protein.\n\n" +
                "- Kepekli Ekmek: Protein, lif, folik asit.\n\n" ;
        }
        if (urun == "Dolama")
        {
            urunResmi.sprite = AliResimler1[29];
            baslik.text = "Dolama nedir";
            konu.text =
                "- Tıp dilinde paronişi olarak tanımlanan dolama, el ya da ayak parmaklarında bulunan tırnak dokusunun etrafında yer alan epidermisin enfekte olmasıdır.\n\n" +
                "- Tırnak çevresi ve lateral tırnak yatağının enfekte olması ile ortaya çıkan bu durum, bazen üst tırnak yatağına ya da eponychium olarak tanımlanan tırnak diplerine de yayılabilir. \n\n" +
                "- Çoğunlukla tırnak çekilmesi, tırnakların yenmesi ya da manikür gibi küçük travmalar sonrasında görülür. \n\n" +
                "- Dolama, kızarıklık ve ağrılı bir sertlik ile başlar.\n\n" +
                "- Enfeksiyon sonucunda oluşan ve parmak iltihabı olarak da bilinen parmakta dolama, kişiye çok ciddi ağrı ve acı hissettirebilir.\n\n" +
                "- Ciltte renk, tırnakta renk ve şekil değişimi, tırnağın kalkması gibi belirtilerle karakterize olan paronişi, çoğunlukla ilaçla ve gerektiğinde cerrahi yöntemlerle tedavi edilir.\n\n"  ;
        }
        if (urun == "Dolunay")
        {
            urunResmi.sprite = AliResimler1[30];
            baslik.text = "Dolunay";
            konu.text =
                "\n- Sinodik aya göre Ay'ın aynı evreleri arasındaki zaman ortalama 29.53 gündür. Bu sebeple yeniay ile başlayan Ay takvimine göre dolunay 14 veya 15. günde gerçekleşir.\n\n\n" +
                " Dolunayın Vücut ve Ruh Sağlığımız Üzerinde Beklenmeyen Etkileri:\n\n" +
                "- Doğumlarda ani ve hızlı bir artışa sebep olabilir.\n\n" +
                "- Uyku düzeniniz bozulabilir.\n\n" +
                "- Ameliyat sonuçlarını etkileyebilir.\n\n" +
                "- Libidonuzda artış olabilir.\n\n" +
                "- Migren ve ağlama krizleri sıklaşabilir, huzursuz olabilirsiniz.\n\n" +
                "- Suç oranları, cinayetler ve intiharlarda artış görülebilir.\n\n" +
                "- Acı eşiğiniz düşebilir.\n\n" +
                "- Trafik kazası yapma ihtimaliniz yükselebilir.\n\n" +
                "- Kalp atışlarınız hızlanabilir, tansiyonunuz yükselebilir.\n\n" +
                "- Ciltte renk, tırnakta renk ve şekil değişimi, tırnağın kalkması gibi belirtilerle karakterize olan paronişi, çoğunlukla ilaçla ve gerektiğinde cerrahi yöntemlerle tedavi edilir.\n\n"  ;
        }
        if (urun == "Dudak")
        {
            urunResmi.sprite = AliResimler1[31];
            baslik.text = "Dudak";
            konu.text =
                "- Ağzın, dişleri örten ve dışarıya doğru az ya da çok kıvrılan üst ve alt kenarlarından her biri.\n\n\n" +
                " Dudak Çatlamasına Ne İyi Gelir?\n\n" +
                "- Toz şeker. Toz şeker, dudaklarınızdaki ölü dokulardan kurtulmanızı sağlayacak ve ölü hücre oluşumunun da önüne geçecektir.\n\n" +
                "- Bal. Antibakteriyal özelliğe sahip balı tek başına da kullanabilirsiniz.\n\n" +
                "- Salatalık. \n\n" +
                "- Aloe vera.\n\n" +
                "- Hindistan cevizi yağı.\n\n" +
                "- Süt ve gül yaprakları.\n\n" +
                "- Su.\n\n" ;
        }
        if (urun == "Dut")
        {
            urunResmi.sprite = AliResimler1[32];
            baslik.text = "Dut Faydaları";
            konu.text =
                "- Kansızlığa iyi gelir.\n\n" +
                "- Hazmı kolaylaştırır.\n\n" +
                "- Vücuda kuvvet verir.\n\n" +
                "- Karaciğeri kuvvetlendirir.\n\n" +
                "- Bağırsak kurtlarını düşürmeye yardımcıdır.\n\n" +
                "- Dut kişinin kilo almasını sağlar ve iştah açar.\n\n" +
                "- Mide ve bağırsakların düzenli çalışmasına yardım eder.\n\n" +
                "- Barındırdığı vitamin ve minerallerin yanında mikrop öldürücü özelliğine sahiptir.\n\n" +
                "- Ağız, bademcik ve boğaz iltihabı, diş eti hastalıkları ve öksürüğe karşı faydalıdır.\n\n" +
                "- Dutun yapraklarında kendine özgü doğal antibiyotik ve antiseptik özelliği olan etkin maddeler bulunmaktadır.\n\n" ;
        }
        if (urun == "Düz Taban")
        {
            urunResmi.sprite = AliResimler1[33];
            baslik.text = "Düz Taban";
            konu.text =
                "\n- Düztabanlık (pes planus) halk arasında taban düşüklüğü olarak da bilinmektedir. İnsan ayak ve ayak bileğinde 26 farklı kemik ve bu kemikleri bir arada tutan birçok eklem bulunmaktadır. Ayrıca onlarca kas, tendon ve bağ ayak yapısını desteklemektedir.\n\n\n" +
                " DÜZTABANLIK BELİRTİLERİ NELERDİR?\n\n" +
                "- Ağrı(Ayak bileği içlerinde,Ayak kemerlerinde,Baldırlarda,Diz eklemlerinde,Kalça eklemlerinde,Belde hissedilebilir.)\n\n" +
                "- Ayakkabıların çabuk deforme olması\n\n" +
                "- Bacakların çabuk yorulması\n\n" +
                "- Ayaklarda sertlik veya uyuşma hissi\n\n" +
                "- Ayaklarda şişlik\n\n" +
                "- Ayaklarda basış bozukluğuna ikincil gelişen nasırlaşmalar\n\n" +
                "- Yürüme veya denge ile ilgili sorunlarla da karşılaşılabilir.\n\n" ;
        }
        if (urun == "Ebu Cehil Karpuzu")
        {
            urunResmi.sprite = AliResimler1[34];
            baslik.text = "Ebu Cehil Karpuzu Faydaları";
            konu.text =
                "- Sinüzite karşı oldukça etkilidir.\n\n" +

                "- Basura karşı mükemmel bir ilaçtır.\n\n" +
                "- İçindeki elateryum adı verilen içeriği idrar artırıcı ve ishal yapıcı özelliğe sahiptir.\n\n" +
                "- Uyuz ve kaşıntıyı geçirir.\n\n" ;
        }
        if (urun == "Ebe Gümeci")
        {
            urunResmi.sprite = AliResimler1[35];
            baslik.text = "Ebe Gümeci Faydaları";
            konu.text =
                "- Akciğerlerde balgam toplanmasında, öksürük ve bronşitte, ses kısıklıklarında, anfizemde faydalıdır.\n\n" +

                "- Ayak şişkinlerinde, kırık ve çıkıklardan ileri gelen şişkinliklerde banyoları çok yararlıdır.\n\n" +
                "- Göz kuruluğu çekenlerde çayı ile pansuman iyi gelir.\n\n" +
                "- Mide ve bağırsakların iyi çalışmasını sağlar.\n\n" +
                "- Ateşi düşürüp, vücuda rahatlık verir.\n\n" +
                "- Ateşi düşürüp, vücuda rahatlık verir.\n\n" +
                "- Alerji, ciltte alerjiler sonucu görülen kaşıntılarda bitkinin çayı çok büyük fayda sağlar.\n\n" +
                "- Taze yapraklarından hazırlanan lapası çıban ve yaraların ağrısını dindirmede kullanılır.\n\n" +
                "- Burun kanamasını durdurur.\n\n";
        }

        #endregion
        #region 06.04
        if (urun == "Ekmek")
        {
            urunResmi.sprite = AliResimler1[36];
            baslik.text = "Ekmek Faydaları Ve Zararları";
            konu.text =
                "\n Faydaları:\n\n" +
                "- İçerdiği karbonhidrat yanında protein, lif, kalsiyum, fosfor ve B1, B6 vitaminlerİ yönünden de zengin bir gıdadır.\n\n" +
                "- Bu açıdan doğal ekmek, zihinsel ve fiziksel sağlığın korunmasını sağlar.\n\n" +
                "- Lif alımıyla mide ve bağırsak sağlığının korunması, kabızlığın önlenmesi için ciddi bir destek sağlar.\n\n" +
                "- Bunun yanı sıra şeker hastalarının kan şekerinin daha yavaş yükselmesine ve kan şekeri ve kolesterol kontrolüne de yardımcı olur.\n\n\n" +
                " Zararları:\n\n" +
                "- Hazır beyaz ekmek gibi yüksek miktarda basit karbonhidrat tüketimi kilo alımına neden olabilir.\n\n" +
                "- Diyabet, kalp hastalığı ve birçok kronik rahatsızlıkların riskini artırabilir.\n\n" +
                "- Bununla birlikte ekmeğin besin profili türüne bağlıdır. \n\n" +
                "- Tam buğday ekmeği gibi lifli bir ekmek daha yüksek besin değerine sahiptir. \n\n" ;
        }
        if (urun == "Eklem Ağrısı")
        {
            urunResmi.sprite = AliResimler1[37];
            baslik.text = "Eklem Ağrısı";
            konu.text =
                "\n- Eklem ağrıları bazı hastalıkların belirtisi olabilir. Ayrıca direkt olarak kemik ve eklem hastalığını da işaret edebilmektedir.\n\n\n" +
                " Eklem Ağrılarına Ne İyi Gelir?\n\n" +
                "- Kas ve eklem ağrılarınızın yatışması için mutlaka soğuk ve sıcak kompres uygulamalısınız.\n\n" +              
                "- Esneme egzersizleri de eklem ağrılarına birebir çözüm olabilir.\n\n" +
                "- Özellikle son zamanlarda çok fazla hareketsiz kaldıysanız, hamladığınızı düşünüyorsanız aşırıya kaçmadan yavaş yavaş esneme hareketleri yapabilirsiniz.\n\n" +
                "- Bu hareketler kanın pompalanmasını sağlar ve ağrıların geçmesine yardımcı olur.\n\n"+
                "- Ağrı olan bölgeye kas gevşetici kremler sürebilirsiniz.\n\n" +
                "- Gut hastalığınız varsa protein bazlı yiyeceklerden kaçınmalısınız.\n\n" +
                "- Uykusuz kalmamalı ve en az günde 8 saat kadar uyumalısınız.\n\n" +
                "- Beslenmenize dikkat etmeli ve kilo almaktan kaçınmalısınız.\n\n";
        }
        if (urun == "Egzama")
        {
            urunResmi.sprite = AliResimler1[38];
            baslik.text = "Egzama";
            konu.text =
                " Nedir\n\n" +
                "- Cilt yüzeyinde kuruluk ve kaşıntı veren kabarcıklar oluşumu ile karakterizedir.\n\n" +
                "- Kuruyup pullanan bu kabarcıklar, zamanla çatlayarak mikroorganizmaların girişine açık hale gelebilir. \n\n" +
                "- Bu nedenle egzama hastası bireylerde enfeksiyon da sıklıkla görülür.\n\n\n" +
                " Egzama Belirtileri:\n\n" +
                "- Ciltte kuruluk.\n\n" +
                "- Kaşıntı.\n\n" +
                "- Kabarcık oluşumu.\n\n" +
                "- Deride pullanma, kabuklanma ve döküntü.\n\n" +
                "- Kızarıklık.\n\n" +
                "- İltihap.\n\n" +
                "- Saç derisinde kepeklenme.\n\n" +
                "- Deride çatlama.\n\n\n" +
                " Tedavi Nasıl Olur\n\n" +
                "- Egzama hastalığı kronik bir rahatsızlık olup bilinen kesin bir tedavisi yoktur.\n\n" +
                "- Hastalara uygulanan tedaviler, genel olarak egzamanın bireyde yol açtığı semptomların önüne geçmeye veya şiddetini azaltmaya yöneliktir.\n\n" +
                "- Herhangi bir uyarana karşılık olarak oluşan egzama türlerinde tedavinin temel ilkesi uyaranla temasın önüne geçmek veya temas sıklığını azaltmaktır.\n\n" +
                "- Hastalığın tedavisinde hekimin önerileri doğrultusunda genellikle alerji önleyici ilaçlar, kortikosteroid içerikli ilaçlar, ve nemlendiricilerden yararlanılır.\n\n" +
                "- Kaşıntının önlenmesi için krem ve jeller kullanılabilir. \n\n" +
                "- Ciltteki kuruluğun önüne geçmek için bol miktarda su tüketilmeli, cilt sürekli nemlendirilmelidir.\n\n";
        }
        if (urun == "Epilepsi")
        {
            urunResmi.sprite = AliResimler1[39];
            baslik.text = "Epilepsi";
            konu.text =
                " Nedir:\n\n" +
                "- Halk arasında “sara hastalığı” olarak da epilepsi, beynin bir bölgesindeki hücrelerin anormal elektrik sinyali yollamasıyla ortaya çıkar. Ülkemiz nüfusunun yaklaşık %1’inin epilepsi hastası olduğu biliniyor.\n\n" +
                "- Sara (Epilepsi), kronik bir hastalıktır. Doğum sırasında ya da daha sonra herhangi bir nedenle beyin hasarı yaşayan kişilerde gelişir.\n\n" +
                "- En bilinen şekliyle epilepsi nöbetleri ile kendini belli eder. \n\n" +
                "- Epilepsi nöbetleri, ani şekilde ortaya çıkar ve beynin tümüne ya da belirli bir bölümüne yayılır. \n\n" +
                "- Nöbet tipleri beynin hangi bölgesinde başladığına göre değişir.\n\n" +
                "- Bazı epilepsi nöbetinde bilinç kaybı, kontrolsüz vücut harekeleri olabileceği gibi, bazı nöbetlerde belirtiler silik hissedilir.\n\n\n" +
                " Nedenleri:\n\n" +
                "- Anne karnında geçirilen enfeksiyonlar\n\n" +
                "- Doğum sırasında bebeğin oksijensiz kalması\n\n" +
                "- Kafa travması\n\n" +
                "- Genetik ve metabolik hastalıklar\n\n" +
                "- Tümörler\n\n" +
                "- Gelişimsel beyin malformasyonları\n\n" +
                "- Menenjit gibi beyin enfeksiyonları epilepsiye yol açabilir.\n\n\n" +
                " Belirtiler:\n\n" +
                "- Vücutta ani kasılmalar\n\n" +
                "- Kollarda ve bacaklarda kontrol edilemeyen sallantılar\n\n" +
                "- Şuur kaybı\n\n" +
                "- Seri şekilde baş sallama hareketi\n\n" +
                "- Kısa bir süre seslere veya konuşmalara yanıt verememe\n\n" +
                "- Sabit bir noktaya bakmak\n\n" +
                "- Hızlı göz kırpmak\n\n" +
                "- Korku, anksiyete ya da deja vu (o anı önce yaşamış gibi hissetme) gibi psikolojik semptomlar\n\n\n" +
                " Tedavi Yöntemleri:\n\n" +
                "- İlaçlarınızı doğru şekilde alın.\n\n" +
                "- Yeterli uyku almak da önemlidir. Uyku eksikliği nöbeti tetikleyebilir.\n\n" +
                "- Egzersiz yapmak, fiziksel olarak sağlıklı kalmanıza ve depresyonun azalmasına yardımcı olabilir.\n\n" +
                "- Aşırı alkol tüketiminden kaçının\n\n" +
                "- Nikotin kullanımından kaçının\n\n";
        }
        if (urun == "Erik")
        {
            urunResmi.sprite = AliResimler1[40];
            baslik.text = "Eriğin Faydaları";
            konu.text =

                "- Erik adet düzensizliklerini giderir.\n\n" +
                "- Ateş düşürücü özelliği vardır.\n\n" +
                "- Karaciğer hastalıklarına iyi gelir.\n\n" +
                "- Kolesterolü dengeler.\n\n" +
                "- Kabızlığı giderir.\n\n" +
                "- Demir eksikliğini önlemedeki tedavi sürecinde kullanılır.\n\n" +
                "- Astım, akciğer kanseri, soğuk algınlığı, öksürük ve kronik akciğer rahatsızlıklarından korur.\n\n" ;
        }
        if (urun == "Esnemek")
        {
            urunResmi.sprite = AliResimler1[41];
            baslik.text = "Esnemek";
            konu.text =

                "- Ağzın genişçe açılıp akciğerlere yüksek miktarda hava çekildiği, daha sonra havanın yavaşça verildiği istemsiz bir reflekstir.\n\n" +
                "- Esneme çoğunlukla yetişkinlerde uykudan hemen önce ve sonra, sıkıcı aktiviteler sırasında ortaya çıkar.\n\n" +
                "- Bulaşıcı bir özelliğe sahiptir.\n\n" +
                "- Genellikle yorgunluk, stres, uykululuk, can sıkıntısı ve hatta açlıkla ilişkilidir.\n\n" +
                "- Esneme beyni soğutmaya yardımcı olur. Soğuk havanın içeri alınmasını sağlar ve böylece beyin sağlıklı sıcaklığına geri döner.\n\n" +
                "- Esnemek kulak zarını, yüz kaslarını ve göğüs kaslarını (toraks) germeye ve esnetmeye yardımcı olur. Böylece, rahatlarsınız ve vücuda alınan oksijen artar.\n\n" +
                "- Esnemek beyne ve kan dolaşımına daha fazla oksijen girmesini sağlar. Ayrıca akciğerlerdeki birikmiş karbondioksiti dışarı verir.\n\n" +
                "- Uzun bir esneme sırasında gözleriniz yaşarır. Bu durum esneme ile birlikte gözlerdeki gözyaşı bezlerinin sıkılmış gibi olduğundan meydana gelir. Gözyaşı hem gözü yağlar hem de görüşü netleştirir.\n\n" +
                "- Esneme, beynin konsantrasyonunu ve odaklanmasını geliştirir.\n\n";
        }
        if (urun == "Estetik Ameliyatı")
        {
            urunResmi.sprite = AliResimler1[42];
            baslik.text = "Estetik Ameliyatı";
            konu.text =
                "\n Estetik Ameliyat Yaptırmanın Başlıca Riskleri:\n\n" +
                "- Bireyin genel psikolojisinin olumsuz yönde etkilenmesi.\n\n" +
                "- Keyfi amaçlı olarak yaptırıldığında bireyin beklentilerine doğrudan cevaplar sunamaması.\n\n" +
                "- Bireylerin keyfi amaçlı veya güzelleşme amaçlı olarak yaptırdığında çoğu zaman hayal kırıklığı yaşaması.\n\n" +
                "- Keyfi veya güzelleşme amaçlı yapıldığında eski görünümden daha kötü bir görünümün elde edilebilmesi.\n\n" ;
        }
        if (urun == "Et")
        {
            urunResmi.sprite = AliResimler1[43];
            baslik.text = "Et Faydaları";
            konu.text =

                "- Kırmızı et yüksek kalitede esansiyel amino grup asit içeren protein, demir ve çinko yönünden zengindir.\n\n" +
                "- Gıdalardan alınan demirin sindirilmesine yardımcıdır. \n\n" +
                "- B grubu vitaminler için zengin bir kaynaktır.\n\n" +
                "- Anemiyi önler.\n\n" +
                "- Hamileliği destekler.\n\n" +
                "- Kardiyovasküler sağlığı korur.\n\n" +
                "- Psikolojik sağlık için.\n\n" +
                "- Katarakt oluşumunu geciktirir.\n\n" +
                "- Kolesterol seviyesini dengeliyor.\n\n" +
                "- Raşitizmden korur.\n\n" +
                "- Kaslarınızı güçlendirir.\n\n" +
                "- Enerji verir\n\n";
        }
        if (urun == "Kurutulmuş Et")
        {
            urunResmi.sprite = AliResimler1[44];
            baslik.text = "Kurutulmuş Etin Faydaları";
            konu.text =

                "- Vitamin ve mineral bakımından zengin bir yapıya sahip olan kuru et, kansızlığa iyi gelmektedir. Kırmızı ette bulunan demir sayesinde, kansızlığı gidermektedir.\n\n" +
                "- Vücudumuzun ihtiyaç duyduğu proteinin önemli bir bölümünü karşılayabilen kuru et, buna bağlı olarak kas yapısını da güçlendirmeye destek olur.\n\n" +
                "- Zeka gelişimini arttırdığı bilinen kırmızı et, daha pratik ve hızlı düşünmeye yardımcı olmaktadır.\n\n" +
                "- Bağışıklık sistemi üzerinde etkili olan kuru et, hastalıklara karşı vücut direncini arttırmaktadır.\n\n" +
                "- Hayvansal besinlerde yüksek oranda bulunan kreatin nedeniyle kuru et, beyin sağlığı içinde oldukça yararlıdır.\n\n" +
                "- Vücudumuzun temel yapı taşını oluşturan kemiklerimiz için kuru et, son derece yararlı bir besindir.\n\n" +
                "- Güçlü bir hafızaya sahip olmak isteyenlerin düzenli tüketmesi gereken kuru et, içerisinde bulundurduğu B6 ve B12 vitaminleri nedeniyle zihin üzerinde olumlu etkilere sahiptir.\n\n" +
                "- Sağlıklı koşullarda hazırlanan ve çiğ kalmamasına dikkat edilen kuru et, özellikle gebeler üzerinde yararlı olduğundan ve bebeklerinin sağlığı bakımından tüketmeleri gereken besinler arasında yer almaktadır.\n\n" +
                "- İdeal kilosunun üzerinde olan ve kilo vermek isteyenlerin, diyet listelerinde mutlaka yer alması gereken, vitamin ve mineral bakımından oldukça zengin bir besindir.\n\n" +
                "- Selenyum içeren kuru et,  tüketildiğinden kısa bir süre sonra bedeninize enerji verecektir. Enerjisi ile vücudunuzu canlandıran kuru et, kolon kanserinden de koruduğu için düzenli tüketilmesi gerekebilir.\n\n" +
                "- Dokuların yenilenmesinde ve kas yapılanmasında etkili olan kuru et, içerisinde bulundurduğu yüksek protein sayesinde, sağlığımız bakımından oldukça yararlıdır.\n\n" +
                "- Bağışıklığı güçlendiren ve metabolik süreçlerde de etkili olan kuru et, vücudumuz tarafından üretilen enzim ve hormonlar bakımından da faydalıdır. Bazı hormonların salgılanmasını arttırmaktadır.\n\n" +
                "- Vücudun tüm doku ve organlarına oksijen taşıyan kırmızı kan hücreleri için ihtiyaç duyulan demir desteğini sağlamaktadır.\n\n" ;
        }
        if (urun == "Etli Çorba")
        {
            urunResmi.sprite = AliResimler1[45];
            baslik.text = "Etli Çorbanın Faydaları";
            konu.text =

                "- Yemeğe başlamadan önce çorba içmek, doygunluk hissi verir ve daha küçük porsiyonlar tüketilmesini sağlar.\n\n" +
                "- Çorbalar midenin gerilmesini sağladığı için yemeğin daha az yenilmesini sağlar.\n\n" +
                "- Özellikle kilo kontrolünde olanların mutlaka çorba tüketmesi gerekir. Kış aylarında çorba içmek, vücudun ısısını arttırır ve üşümeyi azaltır.\n\n" +
                "- Isınmanın yanı sıra vücudun serotonin seviyesini arttırır ve mutluluk verir.\n\n" +
                "- Yemek öncesinde içilen bir porsiyon çorba, vücudun ihtiyaç duyduğu sıvı miktarını dengeler.\n\n" +
                "- Yemek öncesinde çorba içmek, ana öğünlerin daha kolay bir şekilde sindirilmesini sağlar.\n\n" +
                "- Özellikle sebze ve et ile hazırlanan çorbalar vücudun hastalık direncini arttırarak, grip ve soğuk algınlığı gibi hastalıklara yakalanma riskini düşürür.\n\n"  ;
        }
        if (urun == "Evham")
        {
            urunResmi.sprite = AliResimler1[46];
            baslik.text = "Evham Nedir";
            konu.text =

                "- Evham, belirli bir konuya yoğunlaşarak ortaya çıkmaz. Her kişinin evhamı farklı konular üzerinde olabilir. Önemli evham çeşitlerine örnek olarak;\n\n" +
                "- Tek fobi : Sadece tek bir şeye duyulan evham çeşididir.\n\n" +
                "- Agorafobi : Boşluktan, yükseklikten, yabancı insanların bulunduğu kalabalık ortamlardan dolayı bunalan kişi, agora fobi evham çeşidi sınıfına dahildir. \n\n" +
                "- Sosyal Fobi : Günlük yaşam içerisinde, arkadaş ortamında sanki kendini aşağı görme gibi bir durum kaygısına kapılıp, psikolojik olarak rahatsızlığa kapılan kişilerde görülen evham çeşididir.\n\n\n" +
                " Evham Tedavisi İçin Ne Yapmalı?\n\n" +
                "- Evham basit dereceler de ise kendimiz bu durumu düşünmeyerek yenebiliriz.\n\n" +
                "- Ancak psikolojik bir tedavisi uygulaması kalıcı bir sonuç elde etmemizi sağlayacaktır.\n\n" +
                "- İlerlemiş durumlarda ise bir psikiyatr desteği alıp, ilaçlı tedavi görmemiz şart.\n\n" +
                "- Kısacası evham önemsiz bir durum gibi düşünülse de, ilerlemiş durumlarda kişinin hayatını alt üst edebilen ciddi bir rahatsızlıktır. \n\n" +
                "- Evhamlı olduğunuz konular var ise bu durumu düzeltmek için kısa sürede önlemler almanızı öneririz.\n\n";
        }

        #endregion
        #region 07.04
        if (urun == "FareKulağı")
        {
            urunResmi.sprite = AliResimler1[47];
            baslik.text = "FareKulağı Nedir";
            konu.text =

                "\n- Diğer Adları: Gaz otu, kaz otu, yabani mercan köşkü, yabancı kanarya otu, bağırsak otu, sülük otu, cücü bağırsağı. \n\n" +
                "- Kurutma Usulü: Gerilen  iplere asılarak gölgede kurutulmalıdır. \n\n" +
                "- Kullanma Usulü: 1 çay kaşığı kuru bitki tozu 1lt su ile haşlanıp günde 3 bardak içilir. Toz halinde buruna çekilir. Halk arasında yemeği de yapılır. \n\n" +
                "- Şifası: Karaciğer hastalıkları, böbrek ve safra taşlarına idrar söktürücü, kabız, kalp sıkıntısı, eklem şişlikleri, nefes darlığı, sara, tüberküloz, göz iltihaplarında kullanılır.\n\n" +
                "- Yetişme Ortamı: Otlaklarda, işlenmeyen bahçe topraklarında yaygın olarak görülür. \n\n" ;
        }
        if (urun == "Taze Fasülye")
        {
            urunResmi.sprite = AliResimler1[48];
            baslik.text = "Taze Fasülye Faydaları";
            konu.text =

                "\n- Taze fasulye A ve C vitaminleri açısından zengin bir besin kaynağıdır \n\n" +
                "- Ayrıca fasulye folik asit, potasyum içermektedir.\n\n" +
                "- Kötü kolesterolün (LDL) düşmesinde yardımcıdır. Taze fasulye antioksidan özelliğe sahiptir.\n\n" +
                "- Ayrıca B vitamini komplekslerinden özellikle de B1 vitamini ve B2 vitamini açısından zengindir.\n\n" +
                "- Vücut gelişimini destekleyen ve kemikleri güçlendiren fasulye, romatizma ve siyatik ağrılara iyi gelmektedir. \n\n" +
                "- Böbrekleri güçlendirerek böbrek kumu ve taşlarını dökmeye yardım ettiği konusunda araştırmalar yapılmıştır.\n\n" +
                "- Enerji veren yapısıyla vücudu güçlendiren taze fasulye, beden ve zihin yorgunluğuna iyi gelmektedir. \n\n";
        }
        if (urun == "Felç")
        {
            urunResmi.sprite = AliResimler1[49];
            baslik.text = "Felç (İnme) Nedir";
            konu.text =

                "\n- İnmenin 2 çeşidi mevcuttur: Tıkalı bir arter (iskemik inme) veya bir kan damarı sızıntısı veya patlaması (hemorajik inme).\n\n" +
                "- İskemik İnme: En yaygın yaşanan inme türüdür. Beynin kan damarlarında daralma ya da tıkanma meydana gelir ve ciddi şekilde azalmış kan akışına (iskemi) neden olur. \n\n" +
                "- Hemorajik İnme: Beyindeki bir kan damarı sızdırdığında ya da yırtıldığında meydana gelir. Beyin kanamaları, kan damarlarınızı etkileyen birçok durumdan kaynaklanabilir.\n\n\n" +
                " Hemorajik İnme Faktörleri\n\n" +
                "- Kontrolsüz yüksek tansiyon.\n\n" +
                "- Kan sulandırıcı ilaçlarla aşırı tedaviye maruz kalmak.\n\n" +
                "- Kan damarı duvarlarında meydana gelen şişkinlik.\n\n" +
                "- Travma.\n\n" +
                "- Damar duvarında zayıflığa neden olan protein birikimleri.\n\n" +
                "- Kanamaya neden olan iskemik inme.\n\n" +
                "- Arteriyovenöz malformasyon.\n\n\n" +
                " İnme Risk Faktörleri\n\n" +
                "- Erkeklerde inme riski de kadınlara oranla daha yüksek seyretmesine rağmen kadınlarda inmeden dolayı ölüm oranları erkeklerden fazladır. \n\n" +
                "- Yaşam tarzı risk faktörleri. \n\n" +
                "- Fazla kilolu ya da obez olmak.\n\n" +
                "- Fiziksel hareketsizlik.\n\n" +
                "- Uyuşturucu kullanımı.\n\n\n" +
                " Tıbbi Risk Faktörleri:\n\n" +
                "- Yüksek tansiyon.\n\n" +
                "- Sigara içimi ya da pasif içicilik.\n\n" +
                "- Yüksek kolestrol.\n\n" +
                "- Diyabet.\n\n" +
                "- Obstrüktif uyku apnesi.\n\n" +
                "- Kalp yetmezliği, kalp kusurları, kalp enfeksiyonu veya atriyal fibrilasyon gibi kardiyovasküler hastalık.\n\n" +
                "- Kişisel veya ailevi inme, kalp kriziveya geçici iskemik atak öyküsü.\n\n" +
                "- Kovid-19 enfeksiyonu.\n\n";
        }
        if (urun == "Fındık")
        {
            urunResmi.sprite = AliResimler1[50];
            baslik.text = "Fındık Fayadaları";

            konu.text =

                "\n- Bağışıklık Sistemini Güçlendirir. Fındık yağı E vitamini açısından zengin bir kaynaktır.\n\n" +
                "- Tokluk Hissi Verir.\n\n" +
                "- Sinirleri Sağlamlaştırır.\n\n" +

                "- Beyin Sağlığını Korur.\n\n" +
                "- Diyabet Riskini Azaltır.\n\n" +
                "- Kolestrolü Düşürür.\n\n" +
                "- Kansere Karşı Korur.\n\n" +
                "- Kabızlığı Önler.\n\n" +
                "- Kasları Güçlendirir\n\n" +
                "- Yaşlanmayı Engeller\n\n" ;
        }
        if (urun == "Fıstık")
        {
            urunResmi.sprite = AliResimler1[51];
            baslik.text = "Fıstık Fayadaları";

            konu.text =

                "\n- Fıstık Kolon Kanserinden Koruyor.\n\n" +
                "- Mide Kanseri Riskini Azaltıyor.\n\n" +
                "- Sinir Hastalıklarına Karşı Fıstık.\n\n" +

                "- Safra Taşı Tehlikesine Karşı Fıstık.\n\n" +
                "- Kilo Vermek için Fıstık Yiyin.\n\n" +
                "- Fıstık İnme Riskini Azaltır.\n\n" +
                "- Kolesterole Faydalıdır.\n\n" +
                "- Kan Şekerini Dengeler.\n\n" +
                "- Depresyondan Korur.\n\n" ;
        }
        if (urun == "Fil Hastalığı")
        {
            urunResmi.sprite = AliResimler1[52];
            baslik.text = "Fil Hastalığı";

            konu.text =

                "- Tıbbi adı lenfödem olan ve halk arasında fil hastalığı olarak bilinen durum.\n\n" +
                "- Genellikle kol veya bacaklardan birinde, bazen de her ikisinde birden görülebilen şişkinlik ile kendisini belli eden bir durumdur denebilir.\n\n" +
                "- Estetik görüntüyü bozması ve günlük yaşamı olumsuz etkilemesi nedeniyle fil hastalığı hastaları sosyal, fizyolojik ve psikolojik anlamda etkileyen bir hastalıktır. \n\n" +

                "- Bu nedenle teşhis edildiği andan itibaren tedavi süreci başlatılarak hastalığın yol açtığı şişliklerin ortadan kaldırılması hedeflenir. \n\n" +
                "- Tedavinin geciktirilmesi hastalarda daha ciddi komplikasyonların gelişimine zemin hazırlayabilir.\n\n\n" +
                " Belirtileri:\n\n" +
                "- Parmaklar ve parmak araları da dahil olmak üzere kol ve bacakların bir kısmının veya tamamının şişmesi.\n\n" +
                "- Ağrı ve rahatsızlık hissi.\n\n" +
                "- Vücutta ağırlık ve sıkılık hissi.\n\n" +
                "- Hareket kabiliyetinin kısıtlanması.\n\n" +
                "- Derinin sertleşerek kalınlaşması (fibrozis).\n\n" +
                "- Lenfödem hastalığının bugüne dek belirlenmiş net bir tedavisi yoktur.Fakat hücreler arasında sıvı birikimini en aza indirmek, lenfatik sistem içerisindeki sıvının akışını kolaylaştırmak ve teşvik etmek gibi amaçlarla tedavi uygulayarak hastalığın yol açabileceği ciddi sorunları önlemek mümkündür. \n\n";
        }
        if (urun == "Fizik Tedavi")
        {
            urunResmi.sprite = AliResimler1[53];
            baslik.text = "Fizik Tedavi Nedir";

            konu.text =

                "- Fizik tedavi, fiziksel yöntem ve tekniklerin hastalıkların tedavisinde kullanılması anlamına gelir. Uygulanan fizik tedavi yöntem ve teknikleri vücudumuzda herhangi bir lezyon veya yara oluşturmaz. Fizik tedavi uygulamasının amacı hastanın ağrılarının azaltılması veya yok edilmesi, fonksiyonel kapasitenin arttırılması,  günlük yaşam aktivitelerinin tekrar kazanılması, organların işlevlerinin sağlıklı hale gelmesi, bağımsız bir birey olarak toplumdaki yerini almasıdır.\n\n\n" +
                " Hangi Alanlarda Kullanılır?\n\n" +
                "- Ortopedik Hastalıklar ve yaralanmalar.\n\n" +
                "- Nörolojik ve sinir-kas hastalıkları ve yaralanmaları.\n\n" +
                "- Akut ve kronik ağrı tedavisi.\n\n" +
                "- Romatizmal hastalıklar.\n\n" +
                "- Doğumsal veya edinsel eklem ve kemik bozuklukları.\n\n" +
                "- Spor yaralanmaları.\n\n" ;
        }
        if (urun == "Gargara")
        {
            urunResmi.sprite = AliResimler1[54];
            baslik.text = "Gargara";

            konu.text =

                "- Gargaralar ağız hijyeninin sağlanmasına, yiyeceklerin bıraktığı kokuların giderilmesine yardım eder.\n\n" +
                "- Sigara, alkol, sarımsak gibi maddelerin tüketimi sonrasında ağızda kalan kötü tadı ortadan kaldırmaya destek verir.\n\n" +
                "- Uzmanlar tarafından reçete edilen kimi gargaralar, burun, ağız ve boğazdaki enfeksiyonun hafifletilmesi için etki gösterebilir.\n\n" +
                "- Ağızdaki bakterileri azaltan ağız suları, temizlik hissi kazandırır.\n\n" +
                "- Diş eti iltihabı gibi sorunların nedenlerinden biri de plaktır. Gargaralar plak oluşumunu engellemeye yardımcı olur.\n\n" +
                "- Florür içeren gargara, diş minesini güçlendirerek asitlerden korunmasını sağlar. Böylece çürümenin önüne geçilebilir.\n\n" +
                "- Kimi gargaraların ağrı kesici etkisi bulunur. Hafif anestezikler içeren ürünler, genellikle diş operasyonları sonrasında kullanılır.\n\n" +
                "- Kimi gargaraları dişleri beyazlatmak için hidrojen peroksit bileşenleri taşır. Uzun süreli kullanımda diş renklerinde değişim görülebilir.\n\n" +
                "- Bazı gargaralar ağız kuruluğunu hafifletici bileşenler içerebilir.\n\n" ;
        }
        if (urun == "Gasil")
        {
            urunResmi.sprite = AliResimler1[55];
            baslik.text = "Gasil Nedir";

            konu.text =

                "\n- Yıkama, yıkanma. \n\n" +
                "- Ölüyü cenâze namazı kılınmadan önce dînî usûllere göre yıkama.\n\n" ;
        }
        if (urun == "Gebre Otu")
        {
            urunResmi.sprite = AliResimler1[56];
            baslik.text = "Gebre Otu Faydaları";

            konu.text =

                "- Bağışıklık sistemini güçlendirme.\n\n" +
                "- Serbest radikaller denen zararlılarla savaşır ve özellikle kanser gibi hastalıklar için koruma kalkanı oluşturur.\n\n" +
                "- Demir eksikliğinden dolayı kansızlık yaşayanlar için içinde demir bulunduran gebre otu iyileşmeyi kolaylaştırır.\n\n" +
                "- B12 eksikliğinden dolayı da olabilen kansızlık, halsizlik gibi birçok rahatsızlığa da bu bitki iyi gelmektedir.\n\n" +
                "- Vücudumuzun yapıtaşları olan hücrelerde oluşabilen hasarlarla mücadele eden gebre otu aynı zamanda antioksidandır.\n\n" +
                "- Sivilce, kuruluk, kızarıklık gibi cilt sorunlarınız varsa gebre otu size yardımcı olabilir.\n\n" +
                "- Bağırsakları da temizleyen bitki, idrar söktürerek parazitlerden arınmayı hızlandırabilmektedir.\n\n" +
                "- Cinsel soğukluk için vücut hormonlarına etki durumu olabilen gebre otunun cinsel gücü artırdığını söyleyenler de bulunmaktadır.\n\n";
        }
        if (urun == "Gece Körlüğü")
        {
            urunResmi.sprite = AliResimler1[57];
            baslik.text = "Gece Körlüğü Nedir";

            konu.text =

                "\n- Gece körlüğü ya da daha az bilinen adıyla niktalopi, gözün gece karanlığı gibi düşük ışık koşullarına uyum sağlayamaması ile karakterize bir durumdur. \n\n\n" +
                " Nedenleri:\n\n" +
                "- Yaş: Kişi yaşlandıkça göz bebekleri genişleyip daralma özelliğini bir miktar kaybedebilir.\n\n" +
                "- Presbiyopi: Presbiyopi yaşla birlikte ortaya çıkan bir göz kusurdur. \n\n" +
                "- Miyop: Uzağı görme kusuru olan miyopta gece görüşü de bozulabilir.\n\n" +
                "- Göz tansiyonu (Glokom): Göz tansiyonu ya da glokom, göz içi basıncının artmasıdır.\n\n" +
                "- Göz tansiyonunda kullanılan bazı ilaçlar: Göz bebeklerini daraltan göz tansiyonu ilaçları, göze giren ışık miktarında azalmaya yol açarak gece görüşünde bozulmaya neden olabilir.\n\n" +
                "- Katarakt: Katarakt, göz içindeki göz merceğinin saydamlığında azalma nedeniyle görüşün bulanıklaşması durumudur. \n\n" +
                "- Diyabetik retinopati: Şeker hastalığının gözün arkasındaki retina tabakasına verdiği zarar sonucu oluşan durum olan diyabetik retinopati, ciddi görme kayıplarına neden olabilir. \n\n" +
                "- Retinitis Pigmentosa: Retinada koyu pigmentin toplandığı nadir görülen bir genetik hastalık. \n\n" +
                "- A vitamini ya da çinko eksikliği: A vitamini ve çinko eksikliği gece körlüğünü tetikleyebilir.\n\n" +
                "- Keratokonus: Gözün en dışta bulanan tabakası korneanın incelip sivrileşmesine keratokonus denir.\n\n" +
                "- Güneşe maruz kalmak: Uygun göz koruması olmadan güneşe maruz kalmak, gece görüşünü geçici olarak bozabilir. \n\n" +
                "- Lasik göz ameliyatını takiben komplikasyonlar: Lasik göz ameliyatı uzak veya yakını görme kusurlarının lazer kullanılarak düzeltilmesi yöntemidir.\n\n";
        }
        if (urun == "Kuru Fasülye")
        {
            urunResmi.sprite = AliResimler1[58];
            baslik.text = "Kuru Fasülyenin Faydaları";
            konu.text =

                "\n- Kuru fasulye çok yüksek protein değerlerine sahiptir. Kırmızı etin vücuda sağladığı besin değerlerinin birçoğunu karşılayabilir.\n\n" +
                "- Kuru fasulyenin metabolizmayı hızlandırıcı etkisi bulunur. Bu sayede kabızlık sorunlarının giderilmesinde yardımcı olur.\n\n" +
                "- Kuru fasulye, vücudun yapısının korunması için onlarca faydaya sahiptir. Bunun yanında, kimyasal kozmetik ürünlerinin cilde sağlayamadığı bakımı sağlayabiliyor.\n\n" +
                "- Kuru fasulye, vücudun daha enerjik olmasını sağlar. Tüketildiğinde, enerji düzeyini yukarı çıkarır. Zihinsel yorgunluk durumlarında, kuru fasulye tüketilmesi önerilir.\n\n" +
                "- Kuru fasulye; niasin içeriği sayesinde migren sorunlarına, baş ağrılarına karşı iyi gelmektedir.\n\n" +
                "- İçerdiği bol miktarda lif sayesinde uzun süren bir tokluk hissi sağlar. Böylece kişinin sık bir şekilde acıkmasını önleyerek daha kolay bir şekilde kilo vermesine yardımcı olur.\n\n" +
                "- Kuru fasulye, şeker hastaları için önemli olan glisemik kontrol üzerinde antioksidan etkilere sahiptir. Böylece kan şekerinin düzenlenmesini sağlar.\n\n" +
                "- İçerdiği bol miktarda demir vitamini ve folik asit sayesinde özellikle hamileler için oldukça önemlidir. Hamilelik döneminde bolca kuru fasulye tüketilmesi, doktorların önerisi arasında yer alır.\n\n" +
                "- Kuru fasulye tüketerek idrar yolu enfeksiyonlarından kurtulmanız mümkündür. Kuru fasulye, böbreklerdeki taş ve kumun dökülmesine yardımcı olur.\n\n"
                ;
        }
        #endregion
        #region 08.04

        if (urun == "Geğirmek")
        {
            urunResmi.sprite = AliResimler2[0];
            baslik.text = "Geğirmek Nedir";

            konu.text =

                "\n- Sindirim sisteminin üst bölümünde biriken gazın ağız yoluyla dışarı atılmasıdır. Belirli bir sağlık sorununun yan etkisi olarak görülebilmektedir. Sığır ve koyun gibi memeli türlerinde meydana gelen geğirmenin metan salınımını artırdığı bilinmektedir. \n\n\n" +
                " Nedenleri:\n\n" +
                "- Geğirme genellikle yemek yerken veya içerken ve ardından gazın dışarı atılması sırasında hava yutma nedeniyle oluşur, bu durumda dışarı atılan gaz esas olarak azot ve oksijen karışımıdır.\n\n" +
                "- Geğirmelere, bira ve meşrubat gibi karbon dioksit içeren içeceklerin içilmesi neden olabilir, bu durumda atılan gaz esas olarak karbondioksittir. \n\n" +
                "- Diyabet ilaçları, örneğin metformin ve exenatide, özellikle daha yüksek dozlarda geğirmeye neden olabilir. Bu genellikle birkaç hafta içinde çözülür.\n\n" +
                "- Dispepsi, bulantı ve mide ekşimesi gibi diğer semptomlarla birlikte geğirme ülser veya hiatal herni belirtisi olabilir ve bir doktor tarafından gözden geçirilmelidir.\n\n" +
                "- Diğer geğirme nedenleri arasında gıda alerjisi, safra kesesi hastalıkları, özofageal reflü, H. pylori, asit reflü hastalığı and gastritis vardır.\n\n" ;
        }
        if (urun == "Göbek")
        {
            urunResmi.sprite = AliResimler2[1];
            baslik.text = "Göbek Nedir";

            konu.text =

                "\n- Göbek bağının düşmesinden sonra bebeğin karnının ortasında oluşan çukurluk.\n\n" +
                "- Göbek sözcüğü ile özellikle karın bölgesi kilolu olan kimselerde göbek çukurunun (deliğinin) etrafındaki bölge de kastedilir.\n\n" +
                "- Göbek bağı, anne ve cenin arasında bulunan; besin, oksijen, karbon monoksit ve dışkı transferini sağlayan organdır.\n\n" ;
        }
        if (urun == "Göğüs")
        {
            urunResmi.sprite = AliResimler2[2];
            baslik.text = "Göğüs Nedir ve Hastalıkları";

            konu.text =

                "\n- Vücudun, boyun ile karın arasında yer alan ve akciğer, yürek gibi organları içinde bulunduran bölümü.\n\n\n" +
                " Sık Görülen Göğüs Hastalıkları ve Tedavileri\n\n\n" +
                " Kronik Obstrüktif Akciğer Hastalığı (KOAH)\n\n- Amfizem ve kronik bronşiti kapsayan bir rahatsızlıktır. Bireyin hayat kalitesini azaltan ve günlük aktiviteleri esnasında bile solunum güçlüğü yaşamasına neden olan bu hastalık aynı zamanda öksürük ve balgamlı seyreden ilerleyici kronik bir hastalıktır.\n\n\n" +
                " Akciğer Kanseri\n\n- Akciğer hücrelerinin kontrolsüz ve hızla çoğalması sonucu oluşur. Kanlı balgam, nefes darlığı ve göğüs ağrısı şikayetlerine neden olan hastalığın tedavisinde kemoterapi, ışın tedavisi, immunoterapi ile ameliyat yöntemleri kullanılır.\n\n\n" +
                " Astım ve Alerjik Akciğer Hastalıkları\n\n- Bağışıklık sisteminin tehdit olarak gördüğü herhangi bir alerjenin vücuda girmesi sonucu solunum yollarında daralma, mukus yapımında artış, öksürük ve hırıltı karşımıza çıkar.\n\n\n" +
                " Kronik Öksürükler\n\n- 3 haftadan daha uzun süren, uyku kalitesini düşüren, halsizliğe yol açan ve kişinin hayat kalitesini azaltan öksürüklerdir. Sıklıkla daha ciddi bir hastalığın belirtisi olabilen kronik öksürüklerin sebebi belirlenmeli ve tedavisi bekletmeden yapılmalıdır.\n\n\n" +
                " Zatürre (Pnömoni)\n\n- Akciğerlerde bakteri, virüs ya da mantar nedeniyle enfeksiyon gelişmesi zatürre (pnömoni) olarak bilinir. Oluşan enfeksiyon, alveol adı verilen hava dolu keselere dolar ve nefes almada güçlük başlar. Ateş, öksürük, terleme, göğüs ağrısı, titreme ve hatta nefes darlığı ile kendini gösteren zatürrenin zaman kaybetmeden tedavi edilmesi gerekir.\n\n\n" +
                " Akciğer Sönmesi (Pnömotoraks)\n\n- Başka bir hastalığın sonucu olarak ya da tıbbî müdahale esnasında ortaya çıkabilir. Bazı durumlarda sebepsiz yere oluştuğu da gözlenmektedir. Göğüs ağrısı, öksürük ve nefes darlığı belirtileri veren hastalığın acilen tedavi edilmesi gerekir.\n\n\n" +
                " Akciğer embolisi (Pulmoner emboli)\n\n- Vücudun farklı alanlarında oluşan ve kan yolu ile akciğere kadar ulaşabilen kan pıhtısı, başta akciğer atar damarı olmak üzere diğer damarları da tıkayabilir. Göğüs ağrısı, terleme, çarpıntı, kanlı balgam ve nefes darlığı belirtileri gösterir.\n\n\n" +
                " Sarkoidoz\n\n- Bağışıklık sisteminin anormal çalışmasından kaynaklanan, kalp, karaciğer, dalak, beyin, göz, lenf düğümleri ile özellikle akciğeri etkileyen sistemik bir hastalıktır. Bulaşıcı olmayan bu hastalığın tam olarak nedeni belli değildir. Hastalığın teşhisi için kan ve idrar tahlillerinin yapılması ,akciğer röntgeni ve akciğer tomografisi gerekir.\n\n\n" +
                " Plörezi\n\n- Akciğer zarları arasındaki boşluğun çeşitli nedenler ile olması gerekenden fazla sıvı ile dolmasıdır. Plörezi, başlı başına bir hastalık olmasından çok, farklı bir hastalık belirtisi olarak kabul edilmelidir. Verem, akciğer kanseri, akciğer zarı kanseri, akciğer apsesi ile zatürre gibi hastalıklar sıvı birikimine sebep olabilir.\n\n\n" +
                " Uyku Apnesi\n\n- Uyku esnasında solunumun durması anlamına gelir. Gündüz artan uykululuk hali ve horlama gibi belirtiler uyku bozukluklarının sık görülen belirtisidir. Kesin tanı için hasta, uyku laboratuarında bir gece değerlendirilir. Bu esnada solunum eforu, uyku evreleri, hava akımı, elektrokardiyografi, elektroensefalografi, elektromiyografi, arousal ve oksijen satürasyonu ögeleri kayıt altına alınır. Böylece apne olup olmadığı, varsa sıklığı, ne kadar sürdüğü ve apnenin genel vücut fonksiyonlarına olan etkisi değerlendirilmiş olmaktadır.\n\n" ;
        }
        if (urun == "Göz Değmesi")
        {
            urunResmi.sprite = AliResimler2[3];
            baslik.text = "Göz Değmesi Nedir";

            konu.text =

                "- Halk arasında genellikle, mavi gözlü ve keskin bakışlı bazı kimselerin başka bir insana, çocuğa, güzel bir eşya ve nesneye bakması ile oluşan olağan dışı olumsuz etki, zarar, hastalık ve sıkıntıların, nazar sonucu ortaya çıktığına inanılır.\n\n";
        }
        if (urun == "Göz Yaşı")
        {
            urunResmi.sprite = AliResimler2[4];
            baslik.text = "Göz Yaşı Nedir";

            konu.text =

                "- Gözyaşı, omurgalıların göz boşluğundaki bezlerin salgıladığı, gözlerin temizlenmesi ve nemlenmesini sağlayan berrak, tuzlu sıvıdır.\n\n" +
                "- Keder, sevinç ve korku gibi güçlü duygular; gülme, göz kaşıma veya esneme, gözyaşı salgılanmasının artmasına ve neticesinde ağlamaya sebep olabilir.\n\n" +
                "- Göz çukurunda kayganlığı sağlayan, bazı bakteri türlerini parçalayıcı Beta-lizin gibi enzimler içeren gözyaşı, toz, bakteri vb. yabancı cisimcikleri ya yanağa ya da gözyaşı kanalından buruna sürükler.\n\n" +
                "- Kimyasal ve mekanik tahriş, ağrı, yoğun duygusal değişiklikler, gözyaşı salgılamasını arttırır.\n\n" +
                "- Bakınız Ağlamak.\n\n";
        }
        if (urun == "Gül")
        {
            urunResmi.sprite = AliResimler2[5];
            baslik.text = "Gülün Faydaları";

            konu.text =

                "- Kilo kaybına yardımcı olur: Gül yaprakları, vücuttaki toksinleri temizlemeye ve ek olarak da; metabolizmayı hızlandıran ve böylece kilo kaybına yardımcı olan bileşikler içerir.\n\n" +
                "- Doğal nemlendirici: Güllerde bulunan doğal yağlar, cildin nemini koruyarak cildin pürüzsüz olmasını sağlar.\n\n" +
                "- Rahatlatıcı etki: Aromatik olarak kullanıldığında, gül insanı sakinleştirir ve rahatlatır.\n\n" +
                "- Güneş ışınlarına karşı koruma: Gül, güçlü bir antioksidan olan yüksek miktarda C vitamini içerir.\n\n" +
                "- Sivilceli ciltlere çözüm: Gül yağı doğal antibakteriyel özelliklere sahiptir, sivilce ve sivilceye eğilimli cildi tedavi etmeye yardımcı olur.\n\n" +
                "- Kabızlığı giderir: Gül yaprakları kabızlığı tedavi etmek için doğal bir yardımcı görevi görür.\n\n" ;
        }
        if (urun == "Gülmek")
        {
            urunResmi.sprite = AliResimler2[6];
            baslik.text = "Gülmek Faydaları";

            konu.text =

                "- Gülen insanların kan akışı daha düzenlenir.\n\n" +
                "- Gülen insanların kan akışı daha düzenli oluyor.\n\n" +
                "- Bağışıklık seviyesi yükseliyor.\n\n" +
                "- Kan şekeri düşüyor ve uykusuzluk problemi yaşamıyor.\n\n" +
                "- Uzmanların tavsiyesi, 'Daha sağlıklı hissetmek için güne gülümseyerek başlayın ve hep daha çok gülmeyi deneyin!'\n\n" ;
        }       
        if (urun == "Gümüş")
        {
            urunResmi.sprite = AliResimler2[7];
            baslik.text = "Gümüş Nedir";

            konu.text =

                " Tarihi:\n\n" +
                "- Gümüş çok eski zamanlardan beri bilinmekle birlikte yine de altın ve bakırdan sonra keşfedilmiştir. Altın az olmasına rağmen, dünyanın her yanına yayılması sebebiyle daha önce kullanılmaya başlanmıştır.\n\n\n" +
                " Gümüş Takıların İnsan Sağlığa Faydaları:\n\n" +
                "- Radyasyona karşı koruyucudur.\n\n" +
                "- Enfeksiyonların engellemesinde ve gerilemesinde etkilidir.\n\n" +
                "- Alerjik reaksiyonlar yapmazlar.\n\n" +
                "- Ruhsal sağlığınızı olumlu etkiler.\n\n" +
                "- Antibakteriyel özelliğe sahiptir.\n\n" +
                "- Gümüş iyonları kemik gelişimi ve sağlığı için faydalıdır.\n\n";
        }
        if (urun == "Güneş")
        {
            urunResmi.sprite = AliResimler2[8];
            baslik.text = "Güneş Işığı Faydaları ve Zararları";

            konu.text =
                " Faydaları:\n\n"+
                "- D Vitamini Sağlar.\n\n" +
                "- Cilt Sağlığını Destekler. \n\n" +
                "- Kanseri Önler.\n\n" +
                "- Kemik Erimesini Önler.\n\n" +
                "- Sivilceleri Kurutur.\n\n\n" +

                " Zararları:\n\n" +
                "- Kırışıklıkları Arttırıyor\n\n" +
                "- Göz Sağlığını Kötü Etkiliyor\n\n" +
                "- Cilt Lekelerine Sebep Oluyor\n\n" +
                "- Ciltte Yanık Oluşumu\n\n" +
                "- Solar Keratoz: Küçük, kızarık veya kahverengi pullu veya kabuklanmış deri lezyonlarıdır.\n\n" +
                "- Çiftçi Dudağı: Dudaklarda “solar keratoz” benzeri lezyonlar oluşabilmektedir.\n\n" ;
        }
        if (urun == "Hafıza")
        {
            urunResmi.sprite = AliResimler2[9];
            baslik.text = "Hafıza Nedir Ne İyi Gelir";

            konu.text =

                "\n- Günlük hayatta öğrenilen konuları, yaşananları ve pek çok durumu bilinçli olarak zihinde saklama gücüne hafıza denir. Özellikle bilinçaltı içerisinde geçmişle ilişkisi üzerinden tüm yaşananlar etkin bir şekilde saklanır. \n\n\n" +
                " Hafızayı Güçlendiren Gıdalar:\n\n" +
                "- Balık: Omega-3 yağ asidi yönünden zengin.\n\n" +
                "- Ceviz, badem, yer fıstığı: Özellikle şekli de beyine benzeyen ceviz hem omega-3 yağ asidince hem de E vitamini bakımından zengin.\n\n" +
                "- Kırmızı et, tavuk, yoğurt, yumurta: B12 vitamini yönünden zengin.\n\n" +
                "- Bitter çikolata: Polifenollerden zengin\n\n" +
                "- D vitamini: Beynin genç kalmasını sağlayan vitaminlerden. Bu vitamin için en etkili kaynak ise güneş ışığı. Her gün 15 dakika güneşlenin.\n\n" +
                "- E vitamini: Beyin sağlığı açısından en temel antioksidanlardan birini oluşturuyor. Bu vitamin özellikle tahıllarda bolca yer alıyor. Bu nedenle bulgur, esmer pirinç, karabuğday, çavdar, kinoa, yulaf gibi besinlere günlük diyetinizde mutlaka yer verin.\n\n" ;
        }
        if (urun == "Hacamat")
        {
            urunResmi.sprite = AliResimler2[10];
            baslik.text = "Hacamat Nedir";

            konu.text =

                "- Hacamat uygulaması, vücudun belli başlı bölgelerine kupalar yerleştirilerek, bazı uygulamalarda küçük kesiler yapılarak gerçekleştirilmektedir. \n\n" +
                "- Genellikle sırt, omuz ve kafa bölgesine uygulanan, deride bir kesi oluşturularak gerçekleştirilen negatif basınç uygulaması düzeneğiyle kanın emilmesi amaçlanmaktadır. \n\n\n" +
                " Faydaları:\n\n" +
                "- Kaslarımızı gevşetir.\n\n" +
                "- Manevi hayatımıza renk katar.\n\n" +
                "- Vücudumuzun herhangi bir yerindeki hatta damarlardaki sertlikleri geçirir.\n\n" +
                "- Tüm ağrıları kökünden keser (migren, bel boyun fıtığı gibi).\n\n" +
                "- Uykusuzluk gecelerimize son verir birde sinirimizi yatıştırır.\n\n";
        }
        if (urun == "Hamam")
        {
            urunResmi.sprite = AliResimler2[11];
            baslik.text = "Hamam Nedir";

            konu.text =

                "- Para karşılığında yıkanma işinin yapıldığı genel yer.\n\n" +
                "- Hamam mutluluk hormonunu tetikler.\n\n" +
                "- Ölü derilerden kurtulun.\n\n" +
                "- Hamam bağışıklık sistemini güçlendirir.\n\n" +
                "- Hamam sıcağı eklemlere ve adalelere iyi geliyor. \n\n" +
                "- Sinüs tıkanıklığına karşı hamam en iyi çözümlerden biri.\n\n" +
                "- Vücudun nefes almaması stresi tetikler.\n\n" +
                "- Hamam yağ yakımını hızlandırır ve kilo vermeye yardımcı olur.\n\n";
        }
        if (urun == "Hamam Otu")
        {
            urunResmi.sprite = AliResimler2[12];
            baslik.text = "Hamam Otu Faydaları";

            konu.text =

                "- Hamam otunun tek bir faydası bulunuyor.\n\n" +
                "- O da vücutta istenmeyen tüylerin dökülmesini ve tekrar çıkmamasını sağlamaktır.\n\n" +
                "- Hamam otu ve yağı bir nevi ağda ve epilasyon aleti görevini görüyor.\n\n" +
                "- Bu aletlerin verdiği acıyı, bu ot sayesinde yaşamıyorsunuz.\n\n" ;
        }
        if (urun == "Hapşırmak")
        {
            urunResmi.sprite = AliResimler2[13];
            baslik.text = "Hapşırmak";

            konu.text =

                "\n- Vücut sağlığı bakımından çok önemlidir. \n\n\n" +
                " Hapşırmanın Faydaları:\n\n" +
                "- Üst solunum yolunda yer alan süzgeçler mikropları dışarı atmamıza yardımcı olur.\n\n" +
                "- Hapşırma sırasında kalp ve beyne kan pompalanır. Bu sayede beyin ve kalpte bir rahatlama sağlanır.\n\n" +
                "- Akciğere yerleşen zararlı maddeler hapşırma sayesinde vücuttan atılır.\n\n" +
                "- Kan damarlarını hapşırma işlemi ile beraber genişletir.\n\n" +
                "- Akciğerde hapşırma ile beraber hava boşaltımı sağlanır ve ciğerlere taze hava girer.\n\n" +
                "- Hapşırma durdurulmaya çalışılırsa beyin kanamasına yol açabilir.\n\n" +
                "- Hapşırma esnasında yüksek basınç oluşur. Bu basınç sebebiyle kalp durabilir ya da göz damarları çatlayabilir.\n\n\n" +

                " Hapşırmak Karşı Önlemler:\n\n" +
                "- Hapşırmanın gerçekleşeceği esnada derin nefes alarak ona kadar saymak ve burun köprüsü sıkılarak alınan nefesin parça parça yavaş bir halde verilmesi bir çözüm olabilir.\n\n" ;
        }
        #endregion


    }
   
}

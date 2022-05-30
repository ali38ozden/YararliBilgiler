using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class kerem : MonoBehaviour
{
    
    public Sprite[] KeremResimler;
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
        
        if (urun == "Armut")
        {
            urunResmi.sprite = KeremResimler[0];
            baslik.text = " Armutun Faydalarý ";

            konu.text = "- Kilo kaybý saðlar, zayýflatýr. Zengin bir lif kaynað olan armut, içerdikleri ile uzun süre tok kalmanýzý; böylelikle kalori açýðý oluþturarak zayýflamanýza olanak tanýr.\n\n"+
                "- Kanseri önler. Anti kanserojen özellikleri ile olasý kanser hücrelerinin oluþumunu engeller.\n\n"+
                "- Baðýþýklýðý güçlendirir. Yapýsýnda bulunan antioksidanlar sayesinde soðuk algýnlýðý, grip ve nezle benzeri hastalýklara karþý baðýþýklýðý güçlü tutar.\n\n" +
                "- Sindirim sistemini düzenler.\n\n" +
                "- Kalp saðlýðýna iyi gelir, kan akýþýný arttýrýr. Potasyum açýsýndan zengin olmasýndan dolayý kalp saðlýðýna iyi gelir. Öte yandan, vücut genelinde kan akýþýný da arttýrýr.\n\n"+
                "- Yüksek tansiyonu engeller.\n\n";


        }

        // L ile baþlayanlar
        #region L ile baslayanlar
        if (urun == "Lahana")
        {
            urunResmi.sprite = KeremResimler[1];
            baslik.text = " Lahananýn Faydalarý ";

            konu.text = "- Lahana izotiyosiyanatlar denen fitokimyasallar deposudur. Bu bileþikler antioksidandýr. Lahanada bulunan çözünür lif ile birlikte kandaki kötü kolesterol seviyesinin azaltýr.\n\n" +
                "- Lahanada bulunan potasyum önemli bir mineral ve elektrolittir. Kalp hýzýný ve kan basýncýný kontrol altýnda tutmaya yardýmcý olur. Potasyum, sodyumun vücuttaki negatif etkilerine karþý kan damarý duvarlarýný rahatlatýr ve idrar yoluyla sodyumun salgýlanmasýna yardýmcý olur. Lahanada bulunan manganez de kýrmýzý kan hücresi oluþumu için gereklidir.\n\n" +
                "- Lahana bir tür karbonhidrat olan baðýrsak dostu çözünmez lifle doludur. Çözünmez lif, baðýrsak hareketlerini teþvik ederek sindirim sistemini saðlýklý tutmaya yardýmcý olur, kabýzlýðý önler ve baðýrsaktaki yararlý bakterilerin artmasýna sebep olur.\n Bu bakteriler baðýþýklýk sistemini korumak ve bazý vitaminleri (K2, B12 vitamini gibi) üretmek gibi önemli iþlevleri yerine getirirler. Yeterli lif tüketimi, safra ve dýþký yoluyla toksinlerin atýlmasýný kolaylaþtýrýr. Ýdrar söktürücü özelliði sayesinde de vücuttan toksinlerin atýlmasýný saðlar. Lahana piþtiðinde ortaya çýkan kötü kokunun sebebi sindirim sisteminin düzgün çalýþmasýný saðlayan kükürtlü bileþiklerdir.\n\n" +
                "- Lahana göz hastalýklarýný engelleyen antioksidanlar içerir. Ýçeriðindeki beta-karoten, A vitaminine dönüþerek göz saðlýðýna fayda saðlar. A Vitamini gözleri güçlendirerek gece görme fonksiyonlarýný artýrýr ve gözlerin yaþlanmasýný engeller.\n\n";

        }

        if (urun == "Lavman")
        {

            baslik.text = " Lavman ";
            urunResmi.sprite = KeremResimler[2];

            konu.text = "- Aþýrý kabýzlýk, karýn aðrýsý vs. gibi bir sebepten dolayý makattan kalýn baðýrsaða veya idrar yapamayan kimse için kamýþtan idrar torbasýna doðru ilaç gönderme iþine lavman denilmektedir.\n\n\n"+
                "Lavman Sýrasýnda Kullanýlan Bazý Ýlaçlar:\n\n"+
                "- Gülhatmi tohumu tozunun yumuþatýcý lavmanlara konulmasý gayet faydalýdýr.\n\n"+
                "- Hünnap; piþirilerek, suda ýsýtýlarak, kaynatýlarak ve lavman þeklinde de kullanýlýr.\n\n"+
                "- Ebe gömeci tohumunun tozu, lavman yapmak vs.de kullanýlýr.\n\n";
        }

        #endregion  

        // M ile baþlayanlar
        #region M ile baslayanlar

        if (urun == "Mandalina")
        {
            baslik.text = " Mandalina ";
            urunResmi.sprite = KeremResimler[3];

            konu.text = "- Soðuk algýnlýðýna iyi gelir. Turunçgiller arasýnda yer alan mandalina soðuk algýnlýðý riskini azaltarak kiþilerin hastalanmasýný engeller. Mandalinanýn bunun yanýnda oldukça fazla özelliði bulunmaktadýr. Ýçeriðinde bulunan C vitamini sayesinde soðuk algýnlýðýna karþý koruyucu özellik barýndýrýr.\n\n" +
                "- Baðýþýklýðý güçlendirir. Baðýþýklýk sistemi zayýflamasýna sebep olan birçok etken bulunmaktadýr. Özellikle stres ve yetersiz beslenme gibi etmenler baðýþýklýk sisteminin zayýflamasýna ve kiþilerin hastalanmasýna sebep olur. Mandalina C vitamini açýsýndan oldukça zengin bir meyve olarak kiþilerin hastalýk riskini düþürür.\n\n" +
                "- Kolestrolü düþürür. Antioksidan açýsýndan zengin olan mandalina tüketilerek kolesterolü düþürdüðü bilinmektedir.\n\n" +
                "- Tansiyonu düzenler. Mandalinanýn içerisinde bulunan yüksek potasyum ve düþük sodyum içeriði tansiyonun dengelenmesini saðlar.\n\n";

        }

        if (urun == "Mantar")
        {
            baslik.text = " Mantarýn Faydalarý ";
            urunResmi.sprite = KeremResimler[4];

            konu.text = "- Genel olarak, mantarlar kolesterol içermezler, fakat ayný zamanda iyi bir kitin ve beta-glukan kaynaðýdýrlar, bu da kolesterolü düþüren liflerdir.\n\n" +
                "- Mantarlar, kalsiyumun emilimini saðlayarak kemiklere yardýmcý olan D vitamini kaynaðýdýr.\n\n"+
                "- Antioksidan bakýmýndan zengin olan mantar vücudun direncini artýrdýðýndan hastalýlara yakalanma oranýný azaltýr. Karaciðer, akciðer ve baðýrsaklardaki toksinleri temizleyerek vücuttan atar.\n\n";
        }
        if (urun == "Marul")
        {
            baslik.text = " Marulun Faydalarý ";
            urunResmi.sprite = KeremResimler[5];

            konu.text = "- Marul, sýklýkla kardiyovasküler hastalýklara ve diðer tehlikeli durumlara yol açan yüksek kolesterol seviyelerini düþürmede faydalý olabilir. Yüksek LDL kolesterol seviyeleri zararlýdýr, kalp krizine ve felce neden olabilir.\n\n" +
                "- E ve C vitamini bakýmýndan zengin olan marul, cilt hücrelerini yeniler.\n\n"+
                "- Marul, görme saðlýðýný artýran süper bir antioksidan olan zeaksantin içerir ve bunun yaþa baðlý maküler dejenerasyonu önlediði bulunmuþtur.\n\n"+
                "- Maruldaki lif sindirimi artýrýr, kabýzlýk ve þiþkinlik gibi diðer sindirim hastalýklarýný engeller. Ayrýca mide aðrýsýný hafifletebilir. Ayný zamanda baðýrsak saðlýðýný da iyileþtirir.\n\n";
        }

        if(urun=="Meyan Kökü")
        {
            baslik.text = " Meyan Kökünün Faydalarý ";
            urunResmi.sprite = KeremResimler[6];

            konu.text = "- Meyan kökü, B vitamini kompleksi, flavonoidler, fitoöstrojen, kolin, protein, potasyum, fosfor gibi pek çok vitamin ve mineralle dolu zengin bir bitkidir.\n\n" +
                "- Meyan kökü, içerdiði kumarin bileþeni ile vücuttaki iltihaplý hücreleri temizlemeye yardýmcý oluyor. Özellikle kýþ aylarýnda kuru öksürük, balgam gibi sorunlara iyi geliyor.\n\n" +
                "- Meyan kökünün çok çeþitli kullaným alaný bulunuyor. Bunlardan biri de çay þeklinde tüketilmesidir. Meyan kökü çay olarak tüketildiðinde solunum ve sindirim sorunlarýnýn çözümüne destek oluyor.\n\n" +
                "- Kabýzlýða iyi gelen meyan kökü, ayný zamanda kemik ve eklem aðrýlarýný da dindiriyor.\n\n" +
                "- Meyan kökü, aðýz içindeki yaralara da iyi geliyor. Bazý uzmanlar aðýz yaralarý için meyan kökünün kaynatýlmasýný ve kaynatýlan bu su ile gargara yapýlmasýný öneriyor.\n\n" +
                "- Meyan kökü tüm bunlarýn yaný sýra güzellik için de kullanýlan bir bitki. Saç ve cilt saðlýðýna katkýda bulunuyor.\n\n" +
                "- Meyan kökü nemlendirici özelliði ile saç derisini nemli tutuyor. Kuru saç derisi sorunu olanlarýn sýklýkla karþýlaþtýðý kepek sorununa ve saç derisinin pul pul dökülmesine karþý da ektilidir.\n\n" +
                "- Meyan kökünden elde edilen çayý birkaç damla Hindistan cevizi ile karýþtýrýp saç derisine uygularsanýz ve 1 saat bekletip yýkarsanýz faydasýný görebilirsiniz. Meyan kökünün saçlara bir faydasý da saçýn uzamasýný saðlamasýdýr.\n\n";

        }

        

        if (urun == "Masaj")
        {
            baslik.text = " Masajýn Vücuda Faydalarý ";
            urunResmi.sprite = KeremResimler[8];

            konu.text = "\n- Masaj demek yenilenmektir. Masaj, vücuttaki dokularý yeniler. Günümüzde birçok yerde bilinçsiz þekilde masaj yapýlýyor. Masajý uzman masöz veya masör fizyoterapistler uygulamalý.\n\n" +
                "- Masaj, kan dolaþýmýný hýzlandýrýr ve depresyonu yatýþtýrýr. Ayrýca masajýn baðýþýklýk sistemini güçlendirdiðine ve aðrýlarýn azalmasýna yardýmcý olur. Düzenli masaj terapisi alan kiþiler stresten, depresyondan kurtulur.\n\n" +
                "- Yanlýþ yapýlan masaj vücudunuza zarar verebilir. Ancak masaj; doðru ellerde, hijyenik ortamda, uzman masöz veya masör fizyoterapistler tarafýndan yapýlýrsa zarar vermez.\n\n";

        }

        if (urun == "Menekþe")
        {
            baslik.text = " Menekþenin Faydalarý ";
            urunResmi.sprite = KeremResimler[9];

            konu.text = "- Ýdrar yollarý enfeksiyonlarýnda iyileþtirici etkisi vardýr.\n\n" +
                "- Egzama, akne ve öteki cilt sorunlarýnda iyileþtirici etkisi görülür.\n\n" +
                "- Baþ aðrýsý, sinirlilik hali ve uykusuzluða karþý olumlu etkileri vardýr.\n\n" +
                "- Göðsü yumuþatýr, balgamý söktürür.\n\n" +
                "- Soðuk algýnlýðý, anjin, boðmaca, öksürük ve bronþit durumlarýnda iyileþtirici ve rahatlatýcýdýr.\n\n\n" +
                "Kullaným Þekli : 1 tatlý kaþýðý yaprak, sap ve çiçek karýþýmýnýn üzerine 1 bardak kaynar su dökülüp 10-15 dakika süreyle demlendirilir.";

        }

        if(urun=="Yeþil Mercimek")
        {
            baslik.text = " Yeþil Mercimeðin Faydalarý ";
            urunResmi.sprite = KeremResimler[10];

            konu.text = "-Yeþil mercimek, özellikle vücudun kas yapýsýnýn düzgün çalýþmasý için ihtiyaç duyduðu tüm temel amino grup asitlerin takviyesini vücuda yapabilmektedir.\n\n" +
                "- Yeþil mercimek, yüksek düzeyde çözünür lif içermesi nedeniyle kandaki kötü kolesterolü azaltmaya yardýmcý olabilmektedir. Kolesterolü seviyelerinin saðlýklý boyutlarda düþürülmesi sayesinde arterleri temiz tutarak kalp hastalýðý ve felç riskini de azaltabilmektedir.\n\n" +
                "- Yeþil mercimek tüketimi bazý kanser türleriyle mücadele edebilmek için yardýmcý olabilmektedir. Mercimek, kanser savaþçýlarý olarak bilinen lektin bileþikleri açýsýndan zengindir. Lektinler, vücuttaki kanserli hücrelerinin büyümesini kontrol altýna alabilmektedir.\n\n" +
                "- Yeþil mercimek sahip olduðu lif ve kompleks karbonhidratlar nedeniyle enerjiyi sürekli artýrabilmektedir. Mercimek vücuda oksijen taþýma, enerji üretimi ve metabolizmayý hýzlandýrma gibi fonksiyonlar için gerekli olan demir açýsýndan oldukça iyi bir kaynaktýr.\n\n" +
                "- Folat, doðum kusurlarýnýn önlenmesi için gebelik öncesi en az bir yýl süreyle tüketilmesi durumunda yüzde 50 veya daha fazla erken doðum þansýný azaltabilmektedir. Hastalýk Kontrol Merkezi doðurganlýk zamanýndan en az yýl önceden günlük olarak 400 mikrogram folik asit tüketmesini önermektedir. Bir bardak yeþil mercimekte ise gün boyunca ihtiyaç duyulan folat miktarýnýn yüzde 90'ý bulunmaktadýr.\n\n" +
                "- Mercimek sindirim ve sinir sistemlerini kuvvetlendirmeye katkýda bulunan B3 vitamini de dâhil olmak üzere pek çok vitamini içermektedir. B3 vitamini, ayný zamanda kolesterol kontrolü, Alzheimer hastalýðý, kataraktlar, osteoartrit ve diyabet gibi hastalýklarýn oluþma riskini azaltmada önemli bir rol oynamaktadýr.";
        }

        if(urun=="Kýrmýzý Mercimek")
        {
            baslik.text = " Kýrmýzý Mercimeðin Faydalarý ";
            urunResmi.sprite = KeremResimler[11];

            konu.text = "- Cilde iyi gelir. Ýçerisindeki antioksidan bileþenler sayesinde yaþlanmayý engeller, ciltteki yara ve aknelere iyi gelir.\n\n " +
                "- Zengin lif içeriði sayesinde tok tutar, kilo kaybýna yardýmcý olur.\n\n" +
                "- Diyabet hastalarý için doðru bir besindir. Lif içeriði sayesinde sindirimi kolaylaþtýrýr, kan þekerini düzenler.\n\n" +
                "- Protein ve mineral bakýmýndan zengindir.\n\n" +
                "- Kemik ve diþ saðlýðýna iyi gelir. Osteoporoz riskini azaltýr.\n\n\n" +
                " Kýrmýzý Mercimeðin Yan Etkileri \n\n"+ 
                "- Kýrmýzý mercimeðin fazla tüketilmesi midedeki gaz oranýnýn artmasýna neden olur. Fazla tüketim sonucu böbrek rahatsýzlýklarý, potasyum zehirlenmesi gibi problemler oluþabilir. Kýrmýzý mercimeði düzenli tüketmeye karar verdiyseniz mutlaka öncelikle doktorunuza danýþýnýz.\n\n";
        }

        if(urun=="Mersin Yapraðý")
        {
            baslik.text = " Mersin Yapraðýnýn Faydalarý ";
            urunResmi.sprite = KeremResimler[12];

            konu.text = "\n- Oldukça hoþ bir kokusu olan mersin yapraðýnýn içerisinde A vitamini, þeker ve tanen bulundurur.\n\n" +
                "- Ýdrar yollarý enfeksiyonlarýný gidermeye yardýmcý olur.\n\n" +
                "- Bronþit hastalýðýna oldukça faydalýdýr.\n\n" +
                "- Akciðer iltihaplarýnýn tedavi için kullanýlýr.\n\n" +
                "- Egzama gibi cilt hastalýklarýný giderir.\n\n" +
                "- Ýshali kesici özelliði vardýr.\n\n" +
                "- Ýþtahsýzlýk problemi yaþayanlarda iþtahýn açýlmasýna yardýmcý olur.\n\n" +
                "- A vitamini içermesi nedeniyle görme yeteneðini artýrýr.\n\n" +
                "- Baðýþýklýk sistemini güçlendirerek nezle grip gibi soðuk algýnlýðý hastalýklarýna iyi gelir.\n\n";

        }

        if(urun=="Mesane Hastalýklarý")
        {
            baslik.text = " Mesane Hastalýklarý ";
            urunResmi.sprite = KeremResimler[13];

            konu.text = 
                "\n SÝSTÝK (MESANE ÝLTÝHABI)\n\n" +
                "- Mesanenin iltihabýna sistit denilir. Genellikle çeþitli bakterilerin neden olduðu bir enfeksiyon þeklidir. Sistit idrar yollarýnýn en sýk rastlanan rahatsýzlýðýdýr. Bu hastalýk büyüklerde olduðu gibi çocuklarda da meydana gelebilir. Anatomik yatkýnlýk nedeniyle her kadýn hayatýnda en az bir kez idrar yollarý iltihabý geçirir.\n\n\n" +
                " MESANE KANSERÝ - MESANE TÜMÖRÜ\n\n" +
                "- Mesaneyi oluþturan hücrelerin kontrolsüz olarak çoðalmasýna mesane kanseri denir. Mesane kanseri idrar kesesinin içini döþeyen hücre tabakasýndan kaynak alýr. Eðer bu hücre çoðalmasý yalnýzca mesanenin yüzeyel katmaný ile sýnýrlýysa buna yüzeyel mesane kanseri denir. Eðer hücre çoðalmasý derinleþip kas ve yað tabakasýna da geçerse buna derin (invaziv) mesane kanseri denir.\n\n\n" +
                " ÝDRARINI TUTAMAMAK\n\n" +
                "- Mesanedeki idrarýn irade dýþý olarak boþalmasý.\n\n"+
                " Faydalý Bazý Maddeler\n\n- Ödaðacý tozu, idrarýný tutamayan kimseler için faydalýdýr.\n\n" +
                "- Acur, mesane aðrýlarýna karþý faydalýdýr. Tohumu ise idrarý söktürür.\n\n\n" +
                " ÝDRAR YAPMA ZORLUÐU\n\n Sebepleri\n\n" +
                "- Mesanenin zayýf olmasý ve kuvvetli basýnç yapamamasý.\n\n Tedavi:\n\n- Aðýz yoluyla idrar söktürücü ilaçlarýn alýnmasý.\n\n\n" +
                " ÝDRARINI YAPAMAMAK\n\n Sebepleri\n\n" +
                "- Ýdrar yollarýnda taþ meydana gelmesi, et bitmesi veya kan pýhtýsý meydana gelmesi gibi þeylerdir.\n\n" +
                " Faydalý Bazý Maddeler\n\n" +
                "- Bal, böbrek ve mesane týkanýklýklarýný açar.\n\n" +
                "- Þeker kamýþý,idrarý çoðaltýr. Mesaneyi ve nefes borusunu temizler.\n\n" +
                "- Kavun ve karpuz, böbrek ve mesane taþlarýný eritip söktürür.\n\n"
                ;
        }

        if (urun == "Mevsimler")
        {
            baslik.text = " Mevsimler ";
            urunResmi.sprite = KeremResimler[14];

            konu.text = "\n- Saðlýk için en faydalý mevsim bahar mevsimidir. Zira bu mevsimde hastalýk ve ölüm azalýr.\n\n" +
                "- Sonbaharda ise hastalýklar ve ölümler çoðalýr.\n\n" +
                "- Bahar mevsimini kan aldýrmak ve sebze yiyerek geçirmelidir.\n\n" +
                "- Yaz mevsimini sýcaðýn hararetini giderici soðuk yiyecek ve içeceklerle, kan aldýrmaktan sakýnarak ve ýlýk su ile çokça duþ yaparak geçirmelidir.\n\n" +
                "- Kýþýn bol bol et tüketilmeli, kan aldýrmaktan sakýnmalý ve çokça hareket edilmelidir.\n\n";
        }

        if(urun=="Meyve Suyu")
        {
            baslik.text = " Meyve Suyunun Faydalarý ";
            urunResmi.sprite = KeremResimler[15];

            konu.text = "\n- Hastalýklardan korunmanýn ve saðlýklý bir yaþam için güçlü bir baðýþýklýk sistemi gerektiðini belirten uzmanlar, güçlü bir baðýþýklýk sistemi için de bol bol vitamin içeren, antioksidan ve mineral açýsýndan güçlü meyve sularýnýn tüketilmesini öneriyor.\n\n\n" +
                " PORTAKAL SUYU\n\n - Yüksek miktarda C vitamini içeren portakal suyu, baðýþýklýk sisteminizi destekleyerek enfeksiyonlara karþý koruyucu etkide bulunur. Bitkisel kaynaklý besinlerdeki demirin vücudunuzda emilmesine ve vücudunuzdaki yaralanma ve kesilmelerin iyileþmesine yardým eder.\n\n\n" +
                " ELMA SUYU\n\n - Güçlü bir antioksidan kaynaðý. Yapýlan çalýþmalar elma tüketiminin hücresel hasarý önleyici bir etkisi olduðu; bazý kanser türleri, kardiyovasküler hastalýklar, astým, tip 2 diyabet, obezite gibi hastalýk riskini azaltýcý potansiyel etkide bulunduðunu gösterir.\n\n\n" +
                " VÝÞNE SUYU\n\n - Stresin zararlý etkilerini azaltýr. Yüksek oranda polifenolik bileþen içerdiðinden kanser ve kalp hastalýklarý gibi hastalýk risklerinin azaltýlmasýnda potansiyel bir etkiye sahip.\n\n\n" +
                " KAYISI SUYU\n\n - Bir bardak kayýsý suyu,günlük A vitamini gereksiniminin 4-8 yaþ grubu için %48’ini, 9-13 yaþ grubu için %32’sini, 14 yaþ ve sonrasý erkekler için %21’ini, 14 yaþ ve sonrasý kadýnlar için ise %27’sini karþýlar.\n\n\n" +
                " ÜZÜM SUYU\n\n - Potasyum, vitamin C, folat, fenolik ve flavonoid bileþenlerden zengin. Hücrelere zarar veren bileþenlerin düzeyini azaltýr. Kalp saðlýðýný ve bazý kanser türlerine karþý koruyucu ve riski azaltýcý potansiyel bir etkisi olduðu belirtilir.\n\n\n" +
                " NAR SUYU\n\n - Kalsiyum, potasyum ve içerdiði diðer bileþenlere baðlý olarak çok güçlü bir antioksidan. Buna baðlý olarak kötü kolesterol düzeyini düþürebilir, iyi kolesterol düzeyini yükseltebilir ve koroner kalp hastalýklarý riskini azaltýr. Kan basýncýnýn düþürülmesinde etkili. Karaciðere koruyucu etkisi vardýr.\n\n" ;
        }

        if(urun== "Mide Rahatsýzlýðý")
        {
            baslik.text = " Mide Rahatsýzlýðýna Ýyi Gelecek Þeyler ";
            urunResmi.sprite = KeremResimler[16];

            konu.text = "\n NANE\n - Nane mide rahatsýzlýklarý için en çok kullanýlan doðal çözümlerden biri olsa gerek. Ayný zamanda hazýmsýzlýða ve bulantýya da iyi gelen nanenin spazm giderici özellikleri sizi ve sindirim sisteminizi sakinleþtiriyor.\n Bir bardak nane çayý en iyi çözümlerden biri ama isterseniz naneli þeker ve hatta nane özü yaðýný koklamak bile mide rahatsýzlýðýnýza iyi gelebilir.\n\n " +
                " BEYAZ PÝRÝNÇ\n - Midenizin rahatsýzlýðý artýk dayanýlmaz bir dereceye geldiyse, hiçbir baharat ve yað katýlmamýþ ve sadece haþlanmýþ beyaz pirinç sindirim sisteminizde dolaþan o ekstra sývýyý çekip, sisteminizi þoka sokmadan ekstra lif de saðlayacaktýr.\n\n" +
                " ELMA SÝRKESÝ\n - Mide kramplarýna ve mide ekþimesine iyi gelen elma sirkesini aç karna almamaya ve biraz su ile karýþtýrýp kullanmaya özen gösterin.\n\n" +
                " REZENE\n - Çin’de hala mide rahatsýzlýklarýna karþý ilaçlar yerine verilen rezeneyi, bir çay kaþýðý kadar tohumunu ezip yiyebilir, ya da rezene çayý ile beraber tüketebilirsiniz.\n\n" +
                " MUZ\n - Özellikle yeþili daha gitmemiþ muzlar, oldukça rahat sindirebildiðinden ve içerdiði pektin adlý doðal maddeden dolayý özellikle bulantý durumlarýnda sindirim siteminizi yoluna sokmakta bire birdir.\n\n" +
                " ZENCEFÝL\n - Mide rahatsýzlýklarýna karþý çoðu ilaçtan daha etkili olan zencefili, zencefil çayý ya da þekersiz zencefilli þekerlerden birini tüketerek kullanabilirsiniz.\n\n" +
                " PAPATYA\n - Mide krampý ya da hazýmsýzlýk gibi bir sorununuz varsa, papatya çayýnýn iltihaplanmaya karþý etkisi mide zarýnýzý rahatlatýp, sindirim sisteminizin etrafýndaki kaslarý gevþetecektir.\n\n" +
                " ÇEMEN\n - Çemen, mide ekþimesine ve kabýzlýða birebir. Bol lif kaynaðý olduðundan sindirim sisteminize yardýmcý olan çemeni, tohumlarýný hafif bir yemeðe ekleyerek ya da bulmasý biraz zor olsa da çayýný içerek kullanabilirsiniz.\n\n";
        }

        if (urun == "Misk Otu")
        {
            baslik.text = " Misk Otunun Faydalarý ";
            urunResmi.sprite = KeremResimler[17];

            konu.text = "- Ýþtah artýrýcý etkisinin yaný sýra hazmý kolaylaþtýrýr.\n\n" +
                "- Ýçerdiði vitaminler sayesinde baðýþýklýk sisteminin desteklenmesine yardýmcý olur.\n\n" +
                "- Ýdrar sorunlarý yaþayanlar için idrar söktürücü özelliði ile vazgeçilmezdir.\n\n" +
                "- Kadýnlarda adet sancýlarýný hafifleterek düzene sokar.\n\n" +
                "- Misk otu çayýnýn balgam söktürücü etkisi vardýr.\n\n" +
                "- Misk otu çayý cilt üzerine uygulandýðýnda egzama gibi cilt sorunlarýna iyi gelir.\n\n" +
                "- Sedatif etkisi sayesinde doðal sakinleþtirici, yatýþtýrýcýdýr.\n\n" +
                "- Sindirim kanalýndaki sývýlarý ve safra salgýsýný arttýrmada yardýmcý olur.\n\n" +
                "- Sinirsel zayýflýk, nevroz, depresyon, gerginlik, uykusuzluk, kaygý hali gibi psikolojik rahatsýzlýklarýn giderilmesinde yardýmcý olur.\n\n";
        }

        if (urun == "Misvak")
        {
            baslik.text = " Misvakýn Faydalarý ";
            urunResmi.sprite = KeremResimler[18];

            konu.text = "\n- Diþ etlerini korur. Diþ eti kanamalarýný önler. Ýçerdiði minerallerle ayný zamanda antioksidan(kanser önleyici) özelliðinden , diþ eti ve diþlerin birleþiminde mikrop barýnmasýný engeller.\n\n" +
                "- Diþ macunlarýnda köpürmeyi saðlayan teksapon maddesi içermez. Teksapon, kan hücrelerinde toksik etkiye, diþ etlerinin þiþmesine, diþ eti hastalýklarýna, diþlerin asitlere karþý direncini düþürerek çürümeye ve alerjik tepkimelere yol açar.\n\n" +
                "- Diþ saðlýðýný temin eder. Sert kýllarý sayesinde diþ arasýna girerek, diþ minelerine zarar vermeden plak ve tartar oluþumunu engeller. Ayrýca düzenli kullanýmda sararmayý ortadan kaldýrýr.\n\n" +
                "- Aðýz kokusunu yok eder. Yatmadan önce diþler fýrçalansa dahi mideden gelen gazlar kötü kokuya neden olabilir. Misvaktaki doðal aroma, bu kötü kokularý giderir. Mide gazýný gidermeye destek sunar.\n\n" +
                "- Baþ aðrýsýna iyi gelir. Yapýlan araþtýrmalarda , misvakýn içerdiði maddeler ve doðal aromasýnýn düzenli kullanýmda baþ aðrýlarýna da iyi geldiði saptanmýþtýr.\n\n"; 
                
        }

        if (urun == "Müshil")
        {
            baslik.text = " Müshil Etkisi Yapan Bitkiler ve Besinler ";
            urunResmi.sprite = KeremResimler[19];

            konu.text = "\n ELMA ÇAYI\n - Kabýzlýk çekilen günlerde müshil ilacý olarak elma çayý tüketilmesi önerilir. Elma çayý baðýrsaklarý kýsa sürede uyarýr.\n\n\n" +
                " REZENE\n - Midede oluþan gazý ve þiþliði gideren rezene çayý, müshil görevini taþýyan çaylardan biridir. Kýsa zamanda baðýrsaklarýn temizlenmesine yardým eder. Rezeneyi ölçülü ve düzenli tüketilmesi önerilir.\n\n\n" +
                " YEÞÝL ÇAY\n - Metabolizma dostu olan yeþil çay, müshil görevini taþýmaktadýr. Gün içinde 3 fincan tüketerek baðýrsaklarýn aktif kalmasýna yardým edebilirsiniz.\n\n\n" +
                " ZENCEFÝL ÇAYI\n - Zencefil çayý, baðýrsak durgunluðunu önleyen ve sindirim sistemine destek olan bir çaydýr. Zencefil çayýna 1 dilim limon ekleyerek müshil özelliðini ikiye katlayabilirsiniz.\n\n\n" +
                " MELÝSA\n - Melisa çayý vitamin deðeri yüksek olan bitki çaylarýndan biridir. Müshil etkili doðal çay arayanlara tavsiye edilir.\n\n\n " +
                " EKÝNEZYA\n - Ekinezya çayýný gün içinde tüketerek baðýrsaklarýn rahatlamasýna yardým edebilirsiniz. Kabýzlýk ve ödem gibi sorunlar için önerilmektedir.\n\n\n" +
                "---------------------------------------------\n\n\n" +
                " KARADUT\n - Antioksidan etkili karadut, müshil görevi üstlenen meyvelerden biridir.\n\n\n" +
                " CHÝA TOHUMU\n - Diyet döneminde chia tohumu tüketerek baðýrsaklarýn aktifleþmesine yardým edersiniz. Chia tohumu, lifli yapýsý sayesinde müshil etkisi oluþturacaktýr.\n\n\n" +
                " ÇÝLEK\n - Çileðin %90’ý su içermektedir. Bu meyveyi tüketerek müshil etkisi oluþturabilirsiniz.\n\n\n" +
                " BEZELYE\n - Diyet liflerini içeren bezelye, metabolizmayý hýzlandýrmaktadýr. Müshil almanýz gereken durumlarda bezelye salatasý ya da bezelye yemeði tüketerek doðal müshil alabilirsiniz.\n\n\n" +
                " KAYISI\n - Doðal müshil denildiðinde akýllara hemen kayýsý gelir. Gün kurusu kayýsý tüketerek kabýzlýk ve þiþlik gibi durumlarýn önüne geçebilirsiniz. Kayýsý diyet liflerini yapýsýnda barýndýran, metabolizmayý hýzlandýran bir meyvedir. Kuru ve yaþ halinde tercih edebilirsiniz.\n\n\n" +
                " KÝVÝ\n - Kivi, doðal müshil özelliði olan bir meyvedir. Tükettiðiniz anda baðýrsaklarý uyarýr.\n\n\n" +
                " ZEYTÝNYAÐI\n - Gün içinde tüketilen besinlere zeytinyaðý eklemeniz önerilir. Zeytinyaðý sayesinde kabýzlýk gibi sorunlarý önleyebilirsiniz.\n\n\n " +
                " ISPANAK\n - Ispanak tüketerek baðýrsak sorunlarýný tarihe gömebilirsiniz. Çünkü ýspanak baðýrsaklarýn daha saðlýklý þekilde çalýþmasýna yardým eden sebzelerden biridir. Ispanaklý kür, ýspanak salatasý ve yemeði baðýrsaklarýn aktifleþmesine destek olacaktýr.\n\n\n";
        }

        #endregion

        // N ile baþlayanlar
        #region N ile baslayanlar

        if (urun == "Nane")
        {
            baslik.text = " Taze Nanenin Faydalarý ";
            urunResmi.sprite = KeremResimler[7];

            konu.text = "- Antiseptik, antiviral (virüs karþýtý) ve antibakteriyel (bakteri karþýtý) özelliklere sahiptir.\n\n" +
                "- Aðýzda zararlý bakteri üremesini önleyerek, dil ve diþleri temizleyerek, aðýz saðlýðýný iyileþtirir.\n\n" +
                "- Hýzlý ve etkili bir bulantý kesicidir.\n\n" +
                "- Akne semptomlarýný rahatlatýr.\n\n" +
                "- Burun, boðaz ve akciðer týkanýklýklarýný temizler.\n\n" +
                "- Doðal bir uyarýcýdýr zihinsel saðlýðý destekler, yorgunluk, anksiyete ve depresyonu rahatlatýr.\n\n" +
                "- Sinir ve kas aðrýlarýný azaltmaya yardýmcýdýr.\n\n" +
                "- Baþ aðrýsý ve migreni azaltabilir.\n\n" +
                "- Sindirim sistemini (mide ekþimesi, ishal, hazýmsýzlýk, aþýrý gaz) düzenler.\n\n";

        }

        if (urun == "Nasýr")
        {
            baslik.text = " Nasýr Tedavisi ";
            urunResmi.sprite = KeremResimler[20];

            konu.text = " \n\n PONZA TAÞI KULLANIMI\n - En basit ve en etkili yöntemlerden biri olan ponza taþý sert girintili çýkýntýlý yapýya sahip oluklu dikdörtgen bir taþtýr. Özellikle banyoda ya da banyo sonrasýnda kullanýlmasý tavsiye edilir. Banyodan yumuþayan sert nasýr kolayca ponza taþý ile törpülenebilir. Nasýrýn verdiði rahatsýzlýk hissi ve acý ölü derinin atýlmasý ile ortadan kalkar. Düzenli ponza kullanýmý ile nasýrlar büyük ölçüde tedavi edilir.\n\n\n" +
                " NASIR BANTLARI\n - Eczaneden satýn alabileceðiniz nasýr bantlarý, nasýr tedavisinde etkin yöntemlerden biridir. Salisilik asit veya trikloroasetik asit içeren bu ürünler ölü deri üzerinde kimyasala bir parçalanma saðlayarak, nasýrýn yok olmasýna yardýmcý olur. Uygulama sýrasýnda veya sonrasýnda yanlýþ kullanýma baðlý meydana gelebilecek alerji, kýzarýklýk gibi bir belirti ile karþýlaþtýðýnýzda ürünü kullanmayý býrakmalý ve hemen uzman bir hekimden yardým almanýz gerektiðini unutmayýnýz.\n\n\n" +
                " BEYAZ SÝRKE ve LÝMON\n - Nasýr kalemleri veya nasýr bantlarýnda olduðu gibi beyaz sirke ve limon bol miktarda asit içerir. Doðal besinlerden elde edilebilen bu asitler nasýrýn kimyasal reaksiyonla parçalanmasýný saðlar. Limon veya beyaz sirke ile nasýrlý bölge iyice ovulur. Nasýrlý bölge bandajlý olarak ertesi sabaha kadar bekletilir. Bandajýn çok sýký olmamasýna ve ayaðýn hava almasýna özen gösterilmesi gerekir. Bandaj açýldýktan sonra ölü derilerin pul pul döküldüðünü gözlemleyebilirsiniz. Nasýr tamamen yok olana kadar beyaz sirke ve limon uygulayabilirsiniz. Her uygulama sonrasýnda cildi beslemek ve nemlendirmek için zeytinyaðý, hindistan cevizi yaðý veya badem yaðý ile masaj yapýlmasý gerektiðini unutmayýnýz.\n\n\n";
        }

        if(urun=="Nefes Darlýðý")
        {
            baslik.text = " Nefes Darlýðýna Ne iyi Gelir ";
            urunResmi.sprite = KeremResimler[21];

            konu.text = "\n- Kendinizi rahat bir þekilde konumlandýrmayý, sakin kalmayý ve büzülmüþ dudaktan nefes alma tekniðini kullanmayý öðrenmek, nefesinizin kontrolünü yeniden kazanmanýza ve akut nefes darlýðý ataðý sýrasýnda endiþenizi azaltmanýza yardýmcý olabilir. Þu adýmlarý takip edin:\n\n" +
                "- Durun ve rahat bir pozisyon alýn.\n\n" +
                "- Mümkün olduðunca sakin olun; omuzlarýnýzý gevþetin.\n\n" +
                "- Nefes alýn. Nefes almak için dudaklarýnýzý sýkýþtýrýn.\n\n" +
                "- Nefes almaktan daha fazla zaman ayýrarak nefesinizi yavaþlatýn. Ciðerlerinizi boþalmaya zorlamayýn.\n\n" +
                "- Dudaklarýnýzý büzerken yavaþça nefes vermeye devam edin. Henüz yapmadýysanýz burnunuzdan nefes almaya baþlayýn.\n\n" +
                "- Dudak büzme tekniðine en az 5 dakika veya sakin nefes almaya dönene kadar devam edin.\n\n";

        }

        if(urun=="Nergis Çiçeði")
        {
            baslik.text = " Nergis Çiçeðinin Faydalarý ";
            urunResmi.sprite = KeremResimler[22];

            konu.text = "\n - Nergis çiçeðinin güzel kokusu, geniz týkanýklýðýnýn açýlmasýna yardýmcý olmaktadýr.\n\n" +
                "- Nergis çiçeðinin temizleyici özelliði bulunur.\n\n" +
                "-  Nergis çiçeðinin kaynatýlmasý ile içilmesi ya da haþlanmasý ile tüketilmesi, kusmayý önler ve midede bulunan nemi çeker.\n\n" +
                "- Abraþ ve cüzzam rahatsýzlýklarýna iyi gelir.\n\n" +
                "- Nergis çiçeðinin öðütülen kökü, sinirlere ulaþan yaralarýn iyileþtirilmesinde önemli fayda saðlar.\n\n" +
                "- Safra ve rutubet kaynaklý olan baþ aðrýlarýný ortadan kaldýrýr.\n\n" +
                "- Soðuk kaynaklý oluþan nezleye karþý yararlýdýr.\n\n";
        }

        if (urun == "Nezle")
        {
            baslik.text = " Nezleye Ne Ýyi Gelir ";
            urunResmi.sprite = KeremResimler[23];

            konu.text = "\n\n MÜRVER\n - Baðýþýklýk sistemini güçlendirir. Gribe, öksürüðe ve nezleye faydalýdýr. Soðuk algýnlýðýný giderip, göðsü yumuþatýr. Nane ile birlikte demlenerek tüketilmesi önerilir.\n\n\n " +
                " ZENCEFÝL-LÝMON\n - Limon ile birlikte tüketildiðinde soðuk algýnlýðýna, yaðlý bir yemek sonrasý ise sindirime yardýmcý olur. Boðazýnýzda veya vücudunuzda kýrýklýk, halsizlik, aðrý hissettiðinizde taze zencefil rendesi, limon suyu ve bal ile hazýrlayacaðýnýz karýþým iyi gelecektir.\n\n\n" +
                " KUÞBURNU\n - C vitamini zengini kuþburnu vücuda direnç verir. Tam kurutulmuþ meyveleri parçalayýp 10 dakika kaynatarak hazýrlanacak çay hemen tüketildiðinde içeriðindeki C vitamininden yüksek dozda faydalanýlýr.\n\n\n" +
                " IHLAMUR\n - Ihlamur çiçeklerinin iltihap giderici ve aðrý giderici özelliði bulunmaktadýr. Soðuk algýnlýðý þikayetlerinin ve boðazdaki tahriþin azalmasýna, tedavinin hýzlanmasýna yardýmcý olur.\n\n\n" +
                " EKÝNEZYA\n - Nezle ve soðuk algýnlýðýndan korunma ve tedaviye yardýmcýdýr.\n\n\n" +
                " KAKULE\n - Soðuk algýnlýðý, bronþit, öksürük, ateþ gibi þikayetlerin hafifletilmesinde, aðýz ve boðaz iltihaplarýnýn giderilmesinde etkilidir. Demleme usulü, çeþitli baharatlarla karýþtýrýlarak içilmesi önerilir.\n\n\n" +
                " KARABÝBER MEYVESÝ\n - Yemeklere lezzet vermesinin dýþýnda, aðrý kesici ve ateþ düþürücü etkisi bulunmaktadýr. Toz haline getirilmiþ karabiber meyvesi ile hazýrlanan çay gargara þeklinde uygulandýðýnda boðaz enfeksiyonlarýna ve aðrýnýn azalmasýna yardýmcý olacaktýr.\n\n\n";
        }

        if(urun=="Nilüfer Çiçeði")
        {
            baslik.text = " Nilüfer Çiçeðinin Faydalarý ";
            urunResmi.sprite = KeremResimler[24];

            konu.text = "\n - Nilüfer çiçeði sýkýlarak elde edilen yaðý kozmetik fabrikalarýnda krem yapýmýnda kullanýlýr. Bu yað vücudun esnekleþmiþ yapýlarýný sertleþtirerek kýrýþmasýný önler. Ayýrca hücreleri yenileyerek daha parlak ve diri olmasýný saðlar.\n\n" +
                "- Nilüfer çayý düzenli tüketildiðinde baðýrsak florasýný dengeler. Sindirim hastalýklarýnýn önüne geçer. Güçlü bir iltihap söktürücü olan nilüfer çiçeði, kan damarlarýný temizleyerek týkanýklýðý engeller. Böylece kalp hastalýklarýnýn yaþanmamasýný saðlar. Bunun yaný sýra toksinlerden arýndýrdýðý için baðýþýklýk sistemini yeniler. Hücrelerin mutasyonunun önün geçer. Hastalýklarda yükselen ateþlenmeyi engeller.\n\n" +
                "- B vitamini kompleksi bakýmýndan zengin olan nilüfer çiçeði, güçlü bir idrar söktürücü özelliðine sahiptir. Kas ve kemiklerde birikmeye meyilli olan asidi bu yolla atar. Böylece vücut fonksiyonlarýný ve hareketlerini güçlendirir.\n\n" +
                "- Nilüfer çayý en çok ruhsal problemlere fayda saðlar. Stres ve uykusuzluða baðlý geliþen, sinirsel yorgunluðun yaþanmasýnýn önüne geçer. Çünkü sinir hücrelerini yatýþtýrýr. Düzensiz olan kan akýþýný da düzenleyerek panik atak ve kalp ritim bozukluklarýna da iyi gelir.\n\n";
        }

        if (urun == "Nohut")
        {
            baslik.text = " Nohutun Faydalarý ";
            urunResmi.sprite = KeremResimler[25];

            konu.text = "- Nohutta sindirimi optimize ederek kan þekeri seviyelerini düzenlemeye yardýmcý olan yüksek miktarda çözünür lif vardýr. Normal seviyelerde insülin ve kan þekeri saðlayarak diyabet geliþimini önleyebilir ve insanlarýn durumu yönetmesine yardýmcý olabilir.\n\n" +
                "- Nohutun, demir, fosfor, magnezyum, bakýr ve çinko yönünden zengin olmasý kemik saðlýðý için son derece önemlidir. Bu minerallerin çoðu kemik mineral yoðunluðunu iyileþtirmek ve osteoporoz gibi yaþa baðlý koþullarý önlemek için gereklidir.\n\n" +
                "- Mineral selenyum meyve ve sebzelerin çoðunda bulunmamakla birlikte, nohutlarda bulunur. Karaciðer enzimlerinin düzgün çalýþmasýna ve vücutta kansere neden olan bazý bileþiklerin detoksifikasyonuna yardýmcý olur. Ek olarak, selenyum iltihabý önler ve tümör büyüme oranlarýný azaltýr. Nohut ayrýca DNA sentezi ve onarýmýnda rol oynayan folat içerir, böylece DNA’da kanser hücrelerinin oluþumunun önlenmesine yardýmcý olur. Nohutta bulunan fitokimyasallar olan saponinler, kanser hücrelerinin vücutta çoðalarak yayýlmasýný önler. Nohut ve diðer baklagillerden, tam tahýllardan, meyvelerden ve sebzelerden yüksek lif alýmý, kolorektal kanser riskini azaltýr.\n\n" +
                "- Folat, özellikle kadýnlar için birçok farklý sebepten dolayý önemli bir B vitaminidir. Düþük folat seviyeleri, nöral tüp defektleri ve çocuklarýn doðumundaki diðer komplikasyonlarla yakýndan iliþkilidir. Hamilelikte beslenmeye folat bakýmýndan zengin nohutun eklenmesi, bebeðin saðlýklý doðumunu saðlamak için lezzetli bir yoldur.\n\n" +
                "- Yüksek protein ve demir içeriði nedeniyle nohut saç dökülmesi yaþayanlar için harika bir doðal takviye görevi görebilir. Nohut ayrýca A, B ve E vitaminleri kaynaðý olup, hepsi kafa derisi saðlýðýný iyileþtiren ve kan dolaþýmýný artýran omega 6 yað asitleri açýsýndan oldukça zengindir.\n\n" +
                "- Nohuttaki yüksek lif, potasyum, C vitamini ve B-6 vitamini içeriði kalp saðlýðýný destekler. Nohut, kandaki toplam kolesterol miktarýný düþürmeye yardýmcý olan önemli miktarlarda lif içerir ve böylece kalp hastalýðý riskini azaltýr.\n\n" +
                "- Nohut, daha iyi bir görüþe yardýmcý olan A, C ve E vitaminleri gibi iyi bir çinko ve vitamin kaynaðýdýr. Düzenli olarak nohut alýmý görme yeteneðinizi artýrabilir.\n\n" +
                "- Nohuttaki manganezin varlýðý cilt saðlýðýný arttýrýr, kýrýþýklýklarýn ve ince çizgilerin oluþumunu önler. Temel olarak, manganez, serbest radikallerin zararlý etkilerini tersine çevirerek kýrýþýklýklarý önler.\n\n";
        }

        if (urun == "Nektarin")
        {
            baslik.text = " Nektarinin Faydalarý ";
            urunResmi.sprite = KeremResimler[26];

            konu.text = "- Nektarin, içerisinde bol miktarda polifenol ve C vitamini içermektedir. Bu yüzden antioksidan özelliðe sahip olup, vücuttaki zararlý atýklarý uzaklaþtýrýr. Ayrýca hastalýklara karþý da vücudumuzu korur.\n\n" +
                "- Obezite gibi hastalýklarýn tedavisinde nektarin kullanýlmaktadýr. Hem kalorisi az olduðu için hem de kardiyak bozukluklarý engellemesiyle, bu tarz hastalýklarda yardýmcý gýda olarak kullanýlabilir.\n\n" +
                "- Nektarin bol vitaminin yanýnda lutein maddesini içerdiði için göz saðlýný da büyük ölçüde korumaktadýr. Ayrýca bu madde katarakt riskini de en aza indirmektedir.\n\n" +
                "- Bol miktarda potasyum minerali içerdiði için potasyum eksikliði çeken hastalarda ek gýda olarak kullanýlabilir.\n\n" +
                "- Nektarin çeþitli asit çeþitlerini de barýndýrdýðý için vücutta oluþan tümör gibi maddelerin büyümesini engeller.\n\n" +
                "- Son yapýlan araþtýrmalarda nektarinin kanseri önlediði keþfedilmiþtir. Genel olarak kolon kanserinin tedavisinde tüketilebilir.\n\n"
                ;
        }
        #endregion

        // O ile baþlayanlar
        #region O ile baslayanlar
        if (urun=="Organ Baðýþý")
        {
            baslik.text = " Organ Baðýþýnýn Önemi ";
            urunResmi.sprite = KeremResimler[27];

            konu.text = "\n- Toplum üzerinde organ baðýþý hakkýndaki en büyük korkulardan biri, kiþinin organ baðýþçýsý olduðunun öðrenilerek kötü niyetli kiþiler tarafýndan bu bilginin kullanýlmasýdýr. Bu tür gerçek olmayan söylentiler yüzünden pek çok kiþi organ baðýþýndan vazgeçmektedir. Kiþinin organ baðýþçýsý olup olmadýðýný yalnýzca Saðlýk Bakanlýðý yetkilileri bilir. Dolayýsýyla herhangi bir kiþinin, organ baðýþçýsý olup olmadýðýnýn üçüncü þahýslar tarafýndan öðrenilmesi mümkün deðildir.\n\n" +
                "- Organ nakli canlýdan canlýya ya da kadavradan yapýlabilir. Canlýdan canlýya organ nakli genellikle böbrek, karaciðer ve akciðer gibi organlar için uygulanýr. Çoðunlukla aile içindeki kiþiler arasýnda yapýlan bu nakil tipi, hastanýn hayati tehlikesinin olduðu ve ilgili organýn nakil yolu ile yenilenmesi sayesinde iyileþme olasýlýðýnýn belirlenmesinden sonra yapýlýr. Bu durumda hastaya gönüllü olarak organ baðýþlayacak olan kiþi, saðlýk taramalarýndan geçirilir. Kan ve doku uyumu kontrol edilir. Baðýþçý, tek böbrek ile hayatýný devam ettirebileceðinden böbreðinin biri hastaya nakledilir. Karaciðer ve akciðer gibi organlar ise baðýþçýdan tamamen alýnmaz. Bunun yerine ilgili organýn bir bölümü alýnarak hastaya nakledilir.\n\n" +
                "- Organ baðýþýnýn önemi bu noktada ortaya çýkar. Canlýdan canlýya yapýlan nakillerde, az da olsa baðýþçý için risk bulunur. Bu durum organ baðýþýnýn ne denli önemli olduðunun da bir kanýtýdýr. Toplum bazýnda yeterince organ baðýþý olmasý durumunda canlýdan canlýya doku ve organ nakli oraný oldukça alt seviyelere iner. Donörün hayattayken baðýþçý olmasý durumunda ilgili doku ve organlar, organ nakli bekleyen hastalar için büyük bir umut olur. Özellikle kalp ve pankreas gibi hayati organlarýn nakli canlýdan canlýya nakli mümkün deðildir. Bu organlara ihtiyacý olan kiþilerin hayata tutunmasýnýn tek yolu baðýþçýlardýr. Kiþinin beyin ölümünün gerçekleþmemesi durumunda organlarýnýn alýnmasý ise mümkün deðildir.";
        }

        if(urun=="Oruç Tutmak")
        {
            baslik.text = " Oruç Tutmanýn Faydalarý ";
            urunResmi.sprite = KeremResimler[28];

            konu.text = "\n HÜCRELERÝ ONARIR\n\n - Oruç tuttuðunuzda, vücuttaki hücreler otofaji adý verilen hücresel bir iþlemi baþlatýr. Bu iþlem, hücrelerin parçalanmasý ve zaman içerisinde hücrelerde oluþan ölü ya da iþlevsiz proteinlerin atýlmasýný saðlar. Otofaji oranýnýn artmasý kanser ve alzheimer gibi hastalýklara yakalanma riskini azaltýr.\n\n\n" +
                " KALP SAÐLIÐINI KORUR\n\n - Saðlýksýz beslenme, hareket azlýðý gibi çeþitli faktörler kalp hastalýðý riskinin artmasýný saðlar. Oruç, kalp saðlýðýný destekleyen faktörlerden iyi kolesterol olarak bilinen HDL kolesterolü arttýrýrken, kötü kolesterol olan LDL ve trigliserid oranlarýnda düþüþe yardýmcý olmaktadýr.\n\n\n" +
                " KANSERÝ ÖNLEMEYE YARDIMCI OLUR\n\n - Oruçlu kiþide organizma kendini kontrol etmeye vakit bulur ve böylelikle kanser hücrelerinin oluþumunu baþýndan engellemiþ olur. Ayný zamanda kanser tedavisi için uygulanan kemoterapi sýrasýnda ortaya çýkan çeþitli yan etkileri azaltmasý da orucun faydalarý arasýnda yer alýr.\n\n\n" +
                " ZÝHÝNSEL FONKSÝYONLARI ARTTIRIR\n\n - Ramazan ayýnda oruç tutarken uzaklaþtýðýmýz fiziksel istekler, beynimizin yapýlan iþlere yoðunlaþmasýný saðlar. Gereksiz metabolik aktivitelerle uðraþmayan vücut, algýlama ve öðrenmeye odaklanarak hafýzamýzýn daha iyi çalýþmasýna katkýda bulunur. Açlýk, beyin saðlýðý için önemli olduðu saptanan çeþitli metabolik özellikleri iyileþtirir.\n\n\n" +
                " OKSÝDATÝF STRES ve ÝNFLAMASYONU (ÝLTÝHAP) AZALTIR\n\n - Oksidatif stres, yaþlanmanýn yanýnda daha pek çok kronik hastalýða (diyabet, obezite, kanser vb.) neden olan durumlardan biridir. Yapýlan araþtýrmalar oruç tutmanýn vücudun oksidatif strese karþý direncini arttýrdýðýný ortaya çýkarmýþtýr. Ayrýca, uzun süreli açlýðýn inflamatuvar belirteçleri azaltarak birçok yaygýn hastalýðýn ana nedeni olan iltihaplara karþý korunmayý saðladýðýný göstermiþtir.\n\n\n";
        }

        if(urun=="Oðul Otu")
        {
            baslik.text = " Oðul Otunun Faydalarý ";
            urunResmi.sprite = KeremResimler[29];

            konu.text = "- Kendisi sahip olduðu bileþenler sayesinde stresle baþ etmede çok yardýmcý oluyor. Vücudu stresin zararlý etkilerinden koruyor.\n\n" +
                "- Baþ aðrýsý baþta olmak üzere vücudun çeþitli bölgelerinde oluþan aðrýlarýn azalmasýna destek oluyor. Özellikle oðul otuyla demlenen çayýn banyo suyuna karýþtýrýlmasýyla bu etkisinden faydalanýlýyor.\n\n" +
                "- Oðul otu aðýz yoluyla tüketildiðinde kan dolaþýmýný hýzlandýrýcý bir etki yaratýyor. Bu özelliði sayesinde de kanýn damarlarda saðlýklý bir þekilde akmasýný saðladýðýndan kalp ve damar rahatsýzlýklarýndan vücudu koruyor.\n\n" +
                "- Düzenli olarak kullanýldýðýnda yaðlý ciltlerin yaðdan arýnmasýný saðlýyor.\n\n" +
                "- Mide bulantýsý yaþayanlarýn bu sorundan kurtulmasýný saðlýyor.\n\n" +
                "- Baðýrsaklardaki hareketliliði artýrarak özellikle kabýzlýk sorunu yaþayanlara çare oluyor.\n\n" +
                "- Metabolizmayý hýzlandýrdýðýndan hazýmsýzlýk sorununa da çare oluyor. Sindirim sisteminin saðlýklý bir þekilde çalýþmasýna destek oluyor.\n\n";
        }
        #endregion

        // Ö ile baþlayanlar
        #region Ö ile baþlayanlar
        if (urun=="Öd Aðacý")
        {
            baslik.text = " Öd Aðacý Faydalarý ";
            urunResmi.sprite = KeremResimler[30];

            konu.text = "\n ÞERBET HALÝNDE TÜKETÝLDÝÐÝNDE\n\n - Zehirlenmeye karþý panzehir niteliðindedir.\n\n - Adet döngüsünü düzenler.\n\n - Ýdrar söktürücüdür.\n\n" +
                "- Kalýn baðýrsak hastalýklarýnda etkili rol oynar ve doðal bir müshil ilacýdýr.\n\n - Aðrý kesici niteliðindedir.\n\n - Baðýþýklýk sistemini güçlendirir.\n\n\n" +
                " TÜTSÜ OLARAK KULLANILDIÐINDA\n\n - Depresyona, strese ve yorgunluða iyi gelir. Meditasyon esnasýnda ferahlatýcý bir etki yaratýr.\n\n - Konsantrasyonu arttýrýr ve huzur verir.\n\n" +
                "- Balgam emicidir ve kokusu üst solunum yollarý hastalýklarýna iyi gelir.\n\n - Kokusu vücudu bakteri ve toksinlerden arýndýrýr.\n\n\n";
               
        }

       if(urun=="Öksürük Otu")
        {
            baslik.text = " Öksürük Otunun Faydalarý ";
            urunResmi.sprite = KeremResimler[31];

            konu.text = "- Öksürük otu neye faydalý sorusuna verilecek ilk cevap bitkinin adýndan da anlaþýldýðý gibi öksürüðü kesmesidir.\n\n" + 
                "- Nezle, grip, soðuk algýnlýðý gibi solunum yolu hastalýklarýna iyi gelir.\n\n - Astým ve bronþit gibi nefes ile ilgili sorunlarýn minimuma indirilmesinde destek saðlar.\n\n" +
                "- Ýdrar sökücü özelliði vardýr ve bu yüzden ödemleri azaltabilmektedir.\n\n - Kan dolaþýmý ile ilgili problemleri olanlar için kan sulandýrýcý etkisi bulunmaktadýr.\n\n " +
                "- Sinir sistemini koruyucu özelliði sayesinde daha rahat hissetmeyi kolaylaþtýrýr.\n\n - Yaralar, çýbanlar, böcek sokmalarý gibi durumlarda bazý yörelerde merhem olarak kullanýlmaktadýr.\n\n" +
                "- Þiþmiþ ayaklar ve eklem aðrýlarý için öksürük otu içeren suda ayak banyosu rahatlatýcý olabilmektedir.\n\n - Tazeyken sýkýlan öksürük otundan elde edilen suyun kulak aðrýsýný dindirdiði söylenmektedir.\n\n";
                
        }

       if(urun=="Ökse Otu")
        {
            baslik.text = " Ökse Otunun Faydalarý ";
            urunResmi.sprite = KeremResimler[32];

            konu.text = "\n KANSERLE MÜCADELE EDER\n\n - Ökse otu kanser karþýtý aktiviteye sahiptir. Kemoterapi sonrasýnda hastalarýnýn durumunu hafifletmek için yardýmcý olur. Ayrýca, ökse otu kanser hücrelerinin ölümüne de neden olur.\n\n\n" +
                " TANSÝYONU DENGELER\n\n - Ökse otu, insanlarý etkileyen hipertansiyon üzerinde ölçülebilir bir etkisi vardýr. Hipertansiyonu azaltarak felç, kalp krizi ve koroner kalp hastalýðýný önlemeye yardýmcý olur. Tansiyonun yükselmesini de düþmesini de engeller.\n\n\n" +
                " DÝYABETE ÝYÝ GELÝR\n\n - Günde 2-3 bardak içilen ökse otu çayý kandaki þeker seviyelerini düþürür. Ayrýca, insülin üretimini yönetir.\n\n\n" +
                " ÝLTÝHAPLANMALARLA MÜCADELE EDER\n\n - Ökse otunun doðal bir anti inflamatuardýr. Artrit ve diðer eklem aðrýlarýna neden olan enflamasyonu hem iç hem de dýþtan tedavi eder. Anti inflamatuar yeteneði sayesinde ökse otu, sindirim ve mide aðrýlarýnýn da hafifletilmesine yardýmcý olur.\n\n\n" +
                " ÜST SOLUNUM YOLLARINA ÝYÝ GELÝR\n\n - Solunum sistemindeki tahriþi azaltýr. Öksürük, boðaz aðrýsý, bronþit ve göðüs sýkýþmasýný tedavi etmek için de kullanýlýr.\n\n\n" +
                " STRESE ÝYÝ GELÝR\n\n - Ökse otu, uykusuzluk, anksiyete, stres ve depresyon gibi hastalýklara sahip olanlarýn sinir sistemini rahatlatýr, stres hormonlarýný azaltýr.\n\n\n" +
                " REGL AÐRILARINA ÝYÝ GELÝR\n\n - Aðrýlý ve kramplý regl dönemi geçiriyorsanýz, ökse otu çayý regli döneminde yaþadýðýnýz gerginliði ve kramplarý rahatlatacaktýr.\n\n\n" +
                " KANAMALARI DURDURUR\n\n - Burun, akciðer ya da baðýrsak kanamanýz varsa, ökse otu çayý hemostatik etkisi sayesinde kanamayý durduracaktýr.";
                
        }

        if (urun == "Öfke")
        {
            baslik.text = " Öfkenin Zararlarý ";
            urunResmi.sprite = KeremResimler[33];

            konu.text = "\n- Kontrol edilemeyen öfke fiziksel olarak baþ aðrýlarýna, mide rahatsýzlýklarýna, solunum problemlerine, cilt problemlerine, böbrek fonksiyonlarýnda problemlere, sinir sistemi rahatsýzlýklarýna, dolaþým sorunlarýna, var olan fiziksel rahatsýzlýklarýn kötüleþmesine ve duygusal rahatsýzlýklara; " +
                "biliþsel olarak konsantrasyon bozukluðuna, düþük performansa, unutkanlýða, uykusuzluða ve dikkatsizliðe; davranýþsal olarak alkolizme, sigara tiryakiliðine, huzursuzluða, aceleciliðe, ilaç kullanýmýna ve aþýrý yemek yemeye; sosyal olarak da aile hayatýnda, iþ/okul hayatýnda ve toplumsal hayatta sorunlara yol açmaktadýr.";
        }
        #endregion

        // P ile baþlayanlar
        #region P ile baslayanlar
        if (urun=="Pamukçuk Hastalýðý")
        {
            baslik.text = " Pamukçuk Nasýl Geçer ";
            urunResmi.sprite = KeremResimler[34];

            konu.text = "\n KARBONAT\n\n - Pamukçuk tedavisinde en çok bilinen ve yaygýn bir þekilde uygulanan bitkisel tedavi yöntemi karbonattýr.\n\n" +
                "- Ýçme suyunu kaynatýn, içine az bir miktar karbonat ekleyin. Daha sonra temiz bir bezi parmaðýnýza geçirin ve bu karýþýma batýrýn. Ardýndan bu bezle aðýz içini temizleyin. Pamukçuk karbonat ile kýsa sürede yok olacaktýr.\n\n" +
                "- Emziriyorsanýz ve bebeðinizde pamukçuk çýktýysa göðüs ucunuzu da her emzirme öncesi bu karýþýmla temizlemeniz gerekir.\n\n\n" +
                " SÝRKE\n\n - Organik sirkeyi su ile seyrelterek gargara yapmak aðýz içindeki bakterilerin ve mantarlarýn yok olmasýna yardýmcý olur. Bu uygulamayý pamukçuk oluþmadan, aðýz içi hijyenini korumak amacýyla düzenli olarak her diþ fýrçalama eylemi sonrasýnda yapabilirsiniz.\n\n" +
                "- Bebeklerde ise yine steril bir bezi parmaðýnýza geçirip bu karýþýma batýrdýktan sonra bebeðinizin aðýz içini temizleyebilirsiniz. Ancak bu yöntemi bebeðinizde uygulamadan önce mutlaka çocuk doktorunuza danýþmanýzý öneririz.\n\n\n" +
                " BAL\n\n - Pamukçuðun üzerine bir miktar bal sürerek iyileþme sürecini kýsaltabilirsiniz.\n\n !! Ancak bu noktada, 1 yaþ altý bebeklere bal verilmemesi konusunda uyarýda bulunmalýyýz.\n\n\n" +
                " ADAÇAYI\n\n - 1 tutam adaçayýný 1 su bardaðý içme suyuyla 5 dakika kadar kaynatýn. Bu çayý soðuduktan sonra gargara þeklinde kullanabilirsiniz.\n\n\n" +
                " ZENCEFÝL ve ZERDEÇAL\n\n - Antibakteriyel besinler listesinin ilk sýralarýnda yer alan zencefil ve zerdeçal baharatlarýný bir miktar içme suyuyla karýþtýrýp kendinize bitkisel bir gargara yapabilirsiniz.\n\n\n" +
                " KARADUT\n\n - Doðal karadut reçelinden gün içinde 3 defa tüketerek dil üzerindeki pamukçuklarýn giderilmesine yardým edebilirsiniz. Özellikle de 6 aydan daha büyük bebekler için çok az miktarda karadut reçeli önerilir.\n\n" +
                "- Çocuklarda zaman zaman pamukçuk yaþanabilir. Bu durumu kýsa sürede iyileþtirmek için karadut özleri ya da þuruplarý kullanýlabilir. Yeni fark edilen pamukçuklar için karadut suyu da etkili olacaktýr. Dilerseniz karadut suyuyla dil üzerindeki pamukçuklarý silebilirsiniz.\n\n" +
                "- Daha etkili þekilde yok etmek için her sabah 1 fincan karadut suyu tüketmeniz önerilir.\n\n";
        }

        if(urun=="Papatya Çayý")
        {
            baslik.text = " Papatya Çayýnýn Faydalarý ";
            urunResmi.sprite = KeremResimler[35];

            konu.text = "- Papatya çayýnýn en bilinen özelliði sinirleri gevþetmesi ve uykusuzluða iyi gelmesidir.\n\n" +
                "- Sindirimi kolaylaþtýrýr, mide kramplarýna ve aðrýlarý geçirir.\n\n" +
                "- Diþ aðrýlarýný hafifletir. Diþ sorunu yaþýyorsanýz, papatya çayý ile gargara yapabilirsiniz.\n\n" +
                "- Cildi güzelleþtirir ve canlý bir görünüm saðlar. Papatya çayýný bir cilt toniði gibi kullanabilir, yüzünüzü silebilirsiniz.\n\n" +
                "- Göz kapaklarýnda meydana gelen iltihaplanmalarý tedavi eder.\n\n" +
                "- Solunum yolu hastalýklarýnýn tedavisinde kullanýlýr. Sinüzit, nezle gibi bir hastalýk yaþýyorsanýz, papatya çayýnýn buharýný solumak iyileþmenize yardým edecektir.\n\n" +
                "- Regl aðrýlarýna, sýrt ve bel aðrýlarýna iyi gelir.\n\n" +
                "- Kan þekerini dengeler.\n\n";

        }

        if(urun=="Parmak Emme")
        {
            baslik.text = " Parmak Emme ";
            urunResmi.sprite = KeremResimler[36];

            konu.text = "\n- Emme fonksiyonu yeni doðmuþ çocuklarda çok kuvvetlidir. Ancak parmak emme ve dil emme alýþkanlýklarý ilk 1.5 sene normal olmakla birlikte 2 yaþýn sonunda kaybolur." +
                " Ancak parmak emme, emzik emme alýþkanlýðý devam edecek olursa henüz geliþmekte olan kas ve kemik yapýlarý üzerine basýnç uygulayarak diþlerin yer deðiþtirmesine yol açar." +
                " Bu durumda üst ön diþler öne alt ön diþler ise geriye doðru eðilir ve alt ve üst ön diþler arasýnda açýklýk meydana gelir.Alýþkanlýk býrakýlýrsa bu açýklýk kapanýr ancak 3.5 yaþýndan sonra kalýcýlýk artar." +
                "Parmak emme alýþkanlýðý gece uyurken de devam ederse daha etkili olur ve bunun sonucunda üst çenede darlýk (V þeklinde bir çene kavisi) meydana gelir.\n\n\n" +
                " ANNE ve BABALAR NE YAPMALI?\n\n - Kardeþi doðduðu için anne ve babasýnýn ilgisini kaybettiðine inanan bir çocuk ilgiyi geri kazanmak için parmak emiyor olabilir. Böyle bir durumda, çocuðun kardeþi doðsa da kendisinin ayrý bir yeri olduðuna ve ebeveynlerinin onu sevmeye devam edeceðine inandýrýlmasý doðru bir yol olacaktýr.\n\n" +
                "- Çocuðun kaygýlý olduðu zamanlarda parmaðýný emdiði fark edildiyse kaygý yaratan durum üzerinde durulmalý ve çocuk kaygý yaratan etkenlerden mümkün olduðunca uzak tutulmaya çalýþýlmalýdýr.\n\n" +
                "- Çocuðun parmak emme davranýþý üzerinde baskýcý bir þekilde durulmamalýdýr. Anne ve babalarýn verdiði tepkiler çocuðun ilgisini bu konuya odaklayarak parmak emme davranýþýnýn artmasýna neden olabilir." +
                " Örneðin, parmak emen bir çocuðun azarlanmasý, sýk sýk uyarýlmasý, baþka çocuklarla kýyaslanmasý gibi durumlar parmak emme davranýþýný pekiþtirebilir ve çocuðun kendini suçlu ya da cezalandýrýlmýþ hissetmesine yol açabilir.\n\n";
        }

        if (urun == "Patlýcan")
        {
            baslik.text = " Patlýcanýn Faydalarý ";
            urunResmi.sprite = KeremResimler[37];

            konu.text = "\n- Bol miktarda lif içermesiyle birlikte hazýmsýzlýk gibi sorunlarý giderir.\n\n" +
                "- Kalp çarpýntýsý gibi stres yaratan hastalýklarda insaný sakinleþtirir.\n\n" +
                "- Vücutta doku sývýlarýnda biriken ödemi atmada ve ayný zamanda idrarý söktürmede önemli bir besin kaynaðýdýr.\n\n" +
                "- Bol miktarda demir içerdiði için kansýzlýk çekenler için kan üretimini arttýrmaya yardým eder.\n\n" +
                "- Ýstemsiz bir þekilde kas kasýlmasý olaylarýný engeller.\n\n" +
                "- Közlenmiþ patlýcanýn faydalarý ise normal patlýcana göre biraz daha az olabilir. Bunun nedeni ise közlendiði için içerisindeki bazý yararlý bakterilerin ölmesi ve bazý vitaminlerin yok olmasýdýr. Bunlarýn haricinde yine normal patlýcan gibi birçok yararý bulunmaktadýr.\n\n" +
                "- Patlýcan sapýnýn faydalarý da saymakla bitmemektedir. Patlýcanýn gövdesinin olduðu kadar sapý da yararlýdýr. Þöyle ki patlýcan tutunduðu topraktan mineral ve bazý yararlý maddeleri sapýnda birikmektedir. Bu yüzden sapý kaynatýlýp tüketildiðinde birçok hastalýk önlenmiþ olur.\n\n" +
                "- Çið patlýcanýn faydalarý genel olarak sindirim sistemine etki etmektedir. Baðýrsaklarý yumuþatma özelliðine sahiptir ve taþ oluþumunu engeller. Kötü kolesterol gibi zararlý hastalýklarý engeller.\n\n";
        }

        if (urun == "Pekmez")
        {
            baslik.text = " Pekmezin Faydalarý ";
            urunResmi.sprite = KeremResimler[38];

            konu.text = "\n ANTÝOKSÝDAN ÖZELLÝKLERÝ\n\n - Diðer þekerler ve tatlandýrýcýlarla karþýlaþtýrýldýðýnda pekmez, yüksek oranda antioksidanlar içerir. Antioksidanlar, vücudu çeþitli bozukluklar ve dejeneratif hastalýklarla iliþkili oksidatif hasara karþý korur. Bu da pekmezi, çoðu insan için rafine þekere daha iyi bir alternatif yapar.\n\n\n" +
                " VÜCUT AÐIRLIÐINI AZALTMADA YARDIMCIDIR\n\n - Pekmezde bulunan polifenollerin obeziteyi azaltmada ve kilo vermede etkili olabilecek antioksidan etkilere sahip olduðunu göstermektedir.\n\n\n" +
                " ADET KRAMPLARINI HAFÝFLETÝR\n\n - Pekmez, iyi bir demir kaynaðýdýr ve kan kaybý nedeniyle demir eksikliði riski olan kadýnlarýn adetlerini kontrol etmede çok etkili olabilir.\n\n\n" +
                " KEMÝKLERÝ SAÐLIKLI TUTAR\n\n - Pekmez iyi bir kalsiyum kaynaðýdýr. Kalsiyum, kemik saðlýðýný, enzimlerin iþleyiþini ve hücre zarý iþlevini korumada önemli bir rol oynar. Kalsiyum, saðlýklý diþlerin korunmasýnýn yaný sýra vücudun menopoz sýrasýnda sýk görülen kemik hastalýklarýna karþý korunmasýnda da büyük rol oynar.\n\n\n" +
                " CÝNSEL SAÐLIÐI GELÝÞTÝRÝR\n\n - Karadut pekmezi, cinsel hormonlarýn saðlýklý üretilmesine yardýmcý olduðu düþünülen eser mineral manganez bakýmýndan zengindir. Manganez, sinir sisteminin iþleyiþinde, kan pýhtýlarýnýn önlenmesinde ve karbonhidratlardan enerji üretiminde hayati bir rol oynar. Manganez eksikliði kýsýrlýða, genel yorgunluða ve kemiklerin zayýflamasýna neden olabilir.\n\n\n" +
                " ANTÝ-ÝNFLAMATUAR ÖZELLÝKLER\n\n - Pekmezin antienflamatuar ve antioksidan özellikleri, bu tür rahatsýzlýklarý hafifletmek için güvenilir bir bileþendir. Romatizma ve nevralji gibi iltihaplý hastalýk durumlarýný tedavi etmek için bazý ilaç preparatlarýnda etkili bir þekilde kullanýlmýþtýr.\n\n\n\n" +
                " PEKMEZÝN TÜRLERÝNE GÖRE FAYDALARI \n\n\n" +
                " DUT PEKMEZÝ\n\n - Kan eksikliði bulunan hastalarda çok büyük faydalar saðlar.\n - Ülsere iyi gelir.\n - Astým ve bronþit hastalarýnda rahatlama saðlar.\n - Soðuk havalarda vücut direncini artýrýr.\n - Sporcular için bir enerji deposudur.\n - Bebeklerin büyümesine ve geliþmesine yardýmcý olur.\n - Çocuklarýn zeka geliþiminde önemli rol oynar.\n - Aðýz ve boðaz hastalýklarýnda etkilidir.\n\n\n" +
                " ÜZÜM PEKMEZÝ\n\n - Vücuttaki kaný arttýrýr.\n - Enerji verir.\n - Ýþtahý açar.\n - Hamilelikte bebeðin geliþimi açýsýndan çok faydalýdýr.\n - Mideyi, baðýrsaklarý, böbrekleri kuvvetlendirir.\n - Damar sertliðine iyi gelir.\n - Kan dolaþýmýný rahatlatýr.\n\n\n" +
                " KUÞBURNU PEKMEZÝ\n\n - Solunum yolu enfeksiyonlarýna iyi gelir.\n - Vucuda zindelik katar.\n - Kaný temizler.\n - Mide kramplarýna ve sindirim sistemi problemlerine iyi gelir.\n\n\n" +
                " KEÇÝBOYNUZU PEKMEZÝ\n\n - Kolestrolü düþürür ve tansiyonu dengeler.\n - Kalbi destekler.\n - Cinsel gücü ve sperm sayýsýný artýrýr.\n - Vücudu güçlendirir.\n - Kansýzlýða karþý çok etkilidir.\n - Diþleri besler, kemikleri güçlendirir.\n - Baðýrsaklarý çalýþtýrýr.\n - Çocuklar ve hamileler için faydalýdýr.\n\n\n" +
                " ANDIZ PEKMEZÝ\n\n - Bronþit, öksürük, sarýlýk, kaþýntý, egzama, mide bulantýsýna iyi gelir.\n - Akciðer ve karaciðere destek saðlar.\n - Kan yapar ve enerji verir.\n\n\n" +
                " KARADUT PEKMEZÝ\n\n - Yüksek miktarda demir içerdiðinden kansýzlýkta destekleyici gýda olarak kullanýlmaktadýr.\n - Anne sütünü artýrýr.\n - Halsizliði, aþýrý yorgunluðu giderir.\n - Aðýz ve boðaz enfeksiyonlarýnda kullanýlýr.\n -  Kaný temizler anemi hastalarý için tavsiye edilir.\n - Kan basýncýný düþürür.\n - Sindirim sistemi kronik hastalýðýna faydalýdýr.\n - Mide salgýlarýný arttýrýr.\n - Sindirim sistemini düzenler.\n - Saçlarýn ve diþlerin güçlenmesini saðlar.\n - Kronik gastrit ve hepatit tedavisinde kullanýlabilir.\n\n\n"
                ;
        }

        if (urun == "Perhiz")
        {
            baslik.text = " Perhiz ";
            urunResmi.sprite = KeremResimler[39];

            konu.text = "\n PERHÝZ NEDÝR?\n\n - Perhiz, saðlýk durumundan dolayý ya da bedene çeki düzen vermek için yapýlan kýsýtlý beslenme programýdýr.\n\n - Yaþam kalitesini daha iyi konuma getiren perhiz, aslýnda Yahudilerin ve Hristiyanlarýn kültüründe uygulanan, yýlýn belirli günlerinde et, hamur, yaðlý gýdalarý yememe düzenidir.\n\n - Dini inançlarýndan kaynaklanan bu besin kýsýtlamasý, zaman içinde diðer kültürlerde diyet programý þeklini almýþtýr.\n\n\n" +
                " PERHÝZ PROGRAMI NASIL UYGULANIR?\n\n - Perhiz, kiþinin yaþ ve saðlýk durumuna göre ayarlanan beslenme programýna göre uygulanýr. Bir örnek ile netleþtirmek gerekirse; eðer gut hastalýðý için diyet uygulanacaksa, guta neden olan besinlerin bir süre tüketilmemesi gerekir.\n\n\n" +
                " PERHÝZ YAPMANIN FAYDALARI NELERDÝR?\n\n - Kiþilere özel olarak uygulanan perhiz, her þeyden önce az ve öz yemeyi hedefler. Bu ise beslenme düzenini saðlamaktadýr.\n\n - Vücut için zararlý olan maddelerin kýsýtlanmasý, kiþiyi daha saðlýklý kýlacaktýr.\n\n - Perhiz dönemi boyunca, bedenden zararlý maddelerin atýlmasý daha kolay bir hal alýr. Bu ise kiþinin hem ruhen hem de bedenen rahatlamasýný saðlar.\n\n\n" +
                " NELERE DÝKKAT EDÝLMELÝ?\n\n - Perhiz diyeti yaparken atacaðýnýz ilk adým bilinçli olmalýdýr. Bu nedenle bir uzman yardýmý ile bedeninizi tanýyýp ona göre beslenme düzeni oluþturmalýsýnýz.\n\n - Saðlýk sorununuz varsa eðer öðünlerinize ekleyeceðiniz besinler, size iyi gelen yiyeceklerden seçilmelidir.\n\n - Alerji veya hastalýðýnýzý tetikleyen besinlerin diyet listenizde olmamasý gerekli. Bu nedenle daha önce alerji testi yaptýrmadýysanýz, test yaptýrdýktan sonra perhiz yapabilirsiniz.\n\n" +
                " - Hamilelik döneminde de perhiz yapýlabilir. Anne için gerekli olan besinler listeye eklenirken, saðlýðýný tehdit eden besinler öðünlerden çýkarýlýr. Bitki çaylarý, yoðun kafein, alkol gibi ürünler listede yer almazken protein, vitamin ve saðlýklý yiyecekler perhiz yemekleri listesinde en üst sýrada yazýlmaktadýr.\n\n"
                ;
        }

        if (urun == "Peynir")
        {
            baslik.text = " Peynirin Faydalarý ";
            urunResmi.sprite = KeremResimler[40];

            konu.text = "\n - Sinir sistemi için faydalýdýr.\n\n" +
                "- Hafýzayý güçlendirir.\n\n" +
                "- Diþleri güçlendirir. Diþ minesine yararlýdýr.\n\n" +
                "- Çürük diþ oluþumunu engeller.\n\n" +
                "- Vücudun kalsiyum ihtiyacýný karþýlar.\n\n " +
                "- Kemik erimesi oluþumunu engeller.\n\n" +
                "- Diyabete karþý korur.\n\n" +
                "- Kilo vermeye kolaylýk saðlar.\n\n" +
                "- Kalp hastalýklarý riskini aza indirir.\n\n" +
                "- Yüksek tansiyonu düþürür.\n\n" +
                "- Tümör oluþumunu engeller.\n\n" +
                "- Migren aðrýsýna iyi gelir.\n\n" +
                "- Baðýrsak bakterilerini korur.\n\n";
                
        }

        if (urun == "Pýrasa")
        {
            baslik.text = " Pýrasanýn Faydalarý ";
            urunResmi.sprite = KeremResimler[41];

            konu.text = "\n - Pýrasa, içerisinde bulunan flavonoid olan kaempherol içerir. Kan damarlarýnýn astarlarýný serbest radikallere karþý korular kaempherol içeren pýrasa bu nedenle kalp saðlýðý için çok faydalýdýr.\n\n" +
                "- Pýrasada iyi bir potasyum kaynaðýdýr. Potasyum kan basýncýnýn ayarlanmasýnda sodyum kadar etkilidir. Bu nedenle pýrasa tüketmek hipertansiyon riskini azaltýr.\n\n" +
                "- Pýrasa içeriðinde hem kalsiyum hem de K vitamini bulunmaktadýr. Kemiklerin güçlenmesinde görevi olan kalsiyum ve K vitamini ihtiyacýný gidermek için diðer besinlerle birlikte pýrasa tüketmek faydalýdýr. K vitamini ayný zamanda kanýn akýþkanlýðýný da düzenlemektedir.\n\n" +
                "- Pýrasa kalsiyumun yaný sýra içerdiði magnezyum sayesinde kemiklerin ihtiyacý olan minerallerin belli bir kýsmýný karþýlamada rol alýr.\n\n" +
                "- Pýrasa içerisinde potasyum, kalsiyum, fosfor, demir, magnezyum, iyi bir diyet lifi,  B6 Vitamini, A Vitamini, C vitamini, K Vitamini ve iyi bir folat kaynaðý bulundurur. Bu özelliklerinden dolayý baðýþýklýk sistemi için oldukça önemlidir.\n\n" +
                "- Pýrasa tüketmek, kronik iltihap riskini azaltmada yardýmcý olur.\n\n" +
                "- Pýrasanýn idrar söktürücü özelliði vardýr.\n\n" +
                "- Pýrasa, vücudu temizler, cildin parlak görünmesini saðlar.\n\n" +
                "- Vücuda giren enfeksiyonlu hücrelerle antiseptik özelliði sayesinde savaþýr.\n\n";
        }

        if (urun == "Pirinç")
        {
            baslik.text = " Pirincin Faydalarý ";
            urunResmi.sprite = KeremResimler[42];

            konu.text = "\n ENERJÝ VERÝR\n\n - Pirinç zengin bir karbohidrat kaynaðýdýr ve çözünmesi zaman alan uzun karbohidrat zincirlerinden oluþur. Bu sayede, pirincin içindeki karbohidratlar sürekli bir enerji saðlayabilir. Yabani (kahverengi) pirinç, diyetisyen kontrolünde uygun miktarlarda tüketildiðinde diyabet hastalarý içinde bile fayda saðlayabilir.\n\n\n" +
                " YÜKSEK BESÝN DEÐERÝ\n\n - Hem beyaz hem de kahverengi pirincin kendine özgü besin deðeri bulunuyor. Beyaz pirinç kalsiyum ve demir gibi yüksek mineraller içerir, ayrýca niyasin, D vitamini, tiamin ve riboflavin gibi vitaminler açýsýndan da zengindir. Kahverengi pirinç ise lif açýsýndan zengindir, bu nedenle sindirimi iyileþtirmeye yardýmcý olabilir.\n\n\n" +
                " HASTALIKLARI ENGELLÝYOR\n\n - Pirincin çeþitli hastalýklarý kontrol ettiði biliniyor. Esmer pirinç, Alzheimer hastalýðýnýn oluþumunu engelleyen yüksek miktarda nöroiletkenler içerir. Ayrýca ister beyaz olsun, ister kahverengi olsun pirinç, kalp hastalýklarý ve kalp krizi oluþumunu engelleyebilen ve kalbi koruyabilen antioksidan içeriyor.\n\n\n" +
                " KABIZLIÐI ÖNLEMEYE YARDIMCI\n\n - Pirinçte çok düþük miktarda sodyum bulunuyor, bu sayede yüksek kan basýncýný kontrol etmeye yardýmcý olabiliyor. Yabani pirinç mükemmel bir saðlýklý lif kaynaðýdýr. Bunlar, sindirimi iyileþtiren ve baðýrsak hareketlerini düzenlemeye yardýmcý yararlý bakterilerin geliþmesine yardýmcý olabiliyor.\n\n\n" +
                " GLÜTENSÝZ GIDA\n\n - Pirinçte glüten bulunmamaktadýr, bu nedenle çölyak hastalýðýndan muzdarip olanlarýn ve buðday, arpa, çavdar ve yulafta bulunan proteinlere alerjisi olanlarýn diyetine kolaylýkla dahil edilebiliyor.\n\n";
        }

        if (urun == "Patates")
        {
            baslik.text = " Patatesin Faydalarý ";
            urunResmi.sprite = KeremResimler[43];

            konu.text = "\n- Ýçeriðinde bolca potasyum içeren patatesin kabuðunun faydalarý kan basýncýný dengeler.\n\n" +
                "- Kalp çarpýntýsý riskini azaltýr.\n\n" +
                "- Çið patatesin faydalarý arasýnda ciltteki morluklara iyi gelmesi yer alýr. Patatesi halka halka dilimler halinde gözünüze koyarak yorgun görünümü ve göz altý morluklarýný hafifletebilirsiniz.\n\n" +
                "- Ciddi olmayan yanýk ve kýzarýklýklar için çið patates faydalarý en doðal çözümlerden birisidir.\n\n" +
                "- Midedeki gazý ve asitleri gidererek sindirimi kolaylaþtýrýr, mideyi rahatlatýr.\n\n" +
                "- Patates vitamin ve mineral açýsýndan zengin bir sebze olduðu için, sinir sistemi üzerinde düzenleyici bir etki sunar.\n\n" +
                "- Ýçeriðinde yer alan selenyum ile tiroide, manganez ile cilt saðlýðýna iyi gelir.\n\n" +
                "- Fosfor içeriði sayesinde cinsel güce olumlu yönde katký saðlar.\n\n" +
                "- Patatesin ciltteki faydalarý arasýnda kuru ciltleri nemlendirmesi, göz çevresi kýrýþýklýklarýný önlemesi, güneþ yanýklarýný iyileþtirmesi, cildi yumuþatmasý ve leke giderici etkileri yer alýr.\n\n" +
                "- Haþlanmýþ patates faydalarý ishal için birebirdir. Bu rahatsýzlýðý yaþadýðýnýz günlerde bol bol haþlanmýþ patates tüketebilirsiniz.\n\n" +
                "- Ýçeriði B6 vitamini sayesinde stres ve kronik yorgunluða karþý tedavi görevi üstlenir.\n\n" +
                "- Anne sütünü artýran folat, patateste bolca bulunur. Emziren anneler patates tüketebilir.\n\n" +
                "- Saðlýklý ve yeni hücrelerin oluþmasýný saðlayan B9 vitamini ile patates, kanser riskini önler.\n\n" +
                "- Hazýmsýzlýk, þiþkinlik ve özellikle de kabýzlýk gibi durumlarda baðýrsaklarýnýzý patates yiyerek çalýþtýrabilirsiniz.\n\n" +
                "- Saç dökülmesine karþý, durulama suyuna patates suyu ekleyerek saçlarýnýzý yýkayabilir veya direkt patates suyuyla saç derinize masaj yapabilirsiniz.\n\n";
        }

        if (urun == "Pazý")
        {
            baslik.text = " Pazýnýn Faydalarý ";
            urunResmi.sprite = KeremResimler[44];

            konu.text = "\n- Pazý, lifli içeriði nedeniyle sindirim sisteminin dostu bir besin olarak ön plana çýkmaktadýr. Hazmý kolaylaþtýrmada, sindirim sistemini çalýþtýrma ve kabýzlýðý önlemede rahatlýkla kullanýlabilir. Bu özellikleri nedeniyle gaz sorununa da yol açmayan pazý, emziren anneler tarafýndan da rahatlýkla tüketilebilir.\n\n" +
                "- Pazý özellikle de pazý suyunun tüketilmesinin damar sertliðinin giderilmesinde etkili olduðu bilinmektedir.\n\n" +
                "- Pazý kalsiyum, magnezyum, K vitamini ve C vitamini bakýmýndan oldukça zengindir. Bu sebeple kemikleri güçlenmesinde oldukça etkilidir. Bunun yanýnda saçlarýn canlý görünmesi ve diþlerin güçlenmesin de rol oynar. Pazýnýn tüketilmesi ya da suyundan saç maskesi yapýlmasý saç saðlýðý bakýmýndan faydalý olabilmektedir.\n\n" +
                "- Pazý, çocuklar tarafýndan da rahatlýkla tüketilebilir. Çocuklarda özellikle kemiklerin büyümesi ve geliþimine yardýmcý olur.\n\n" +
                "- 100 gram pazýda yaklaþýk olarak 3.0 mg demir bulunmaktadýr. Kýrmýzý kan hücresi üretimini desteklediði için kansýzlýk yaþayan kiþilerin pazý tüketmesi olumlu sonuçlar vermektedir.\n\n" +
                "- Pazý antioksidan özelliði olan bir sebzedir. Ýçerdiði antioksidanlar sayesinde antikanser özelliðinin olmasý kansere karþý koruyucu olduðunu gösterir. Özellikle kolon kanserini önlemeye yardým eder.\n\n" +
                "- Demir eksikliði; halsizlik, sürekli yorgunluk hali, konsantrasyon sorunlarý ve ilgisizlik gibi belirtilerle kendini belli edebilir. Ýçeriðinde bulunan demir nedeniyle pazýnýn, demir eksikliðini önleyici özelliði olduðu bilinmektedir. Bu nedenle pazý tüketimi; halsizlik, depresyon ve yorgunluða iyi gelir.\n\n" +
                "- Pazý tüketimi, vücuttaki bazý deri hastalýklarýna iyi gelebilir.\n\n" +
                "- Ýdrar söktürücü özelliði olan pazý, özellikle idrar yolu iltihabýna iyi gelmektedir.\n\n";
                
        }
        #endregion

        // R ile baþlayanlar
        #region R ile baslayanlar
        if (urun == "Reyhan Bitkisi")
        {
            baslik.text = " Reyhan Bitkisinin Faydalarý ";
            urunResmi.sprite = KeremResimler[45];

            konu.text = "- Baðýþýklýk sistemini güçlendirerek hastalýklara karþý direncinizi arttýrýr.\n\n" +
                " - Kötü kolesterolü düþürerek kalp dostu bir tavýr sergiler.\n\n" +
                " - Mide asidini düzenler ve hazýmsýzlýk gibi sorunlarýnýzýn giderilmesine yardýmcý olur.\n\n" +
                " - Antienflamatuvar özelliði sayesinde ödem attýrýcý etki gösterir.\n\n" +
                " - Baþ aðrýsýna iyi gelir.\n\n" +
                " - Öksürüðe iyi gelir.\n\n" +
                " - Cilt bakýmý için kaynatýlýp suyu tonik olarak kullanýlabilir.\n\n";
        }

        if(urun=="Rezene Çayý")
        {
            baslik.text = " Rezene Çayýnýn Faydalarý ";
            urunResmi.sprite = KeremResimler[46];

            konu.text = "- Rezene çayý, rezene bitkisinin içerdiði yað asitleri sayesinde antidiyabetik ve antioksidan etkiye sahiptir. Antioksidan etkisi ile hücre hasarýný önlemeye yardýmcý olmakta, yeni hücrelerin oluþumunu desteklemekte ve yaþlanmayý geciktirici etki saðlamaktadýr.\n\n" +
                " - Bakteri ve mantar enfeksiyonlarý ile savaþmaya yardýmcý olmaktadýr.\n\n" +
                " - Kan pýhtýsý oluþumunu engellemekte, kadýn üreme sistemini destekleyerek anne sütü salgýlanmasýna katkýda bulunmaktadýr.\n\n" +
                " - Rezene çayý aðýz kokusuna iyi gelmekte, nefesi tazelemektedir.\n\n" +
                " - Sindirim sistemi kaslarýný rahatlatarak baðýrsak hareketlerini düzenlemekte ve kabýzlýða iyi gelmektedir.\n\n";
        }

        if (urun == "Romatizma")
        {
            baslik.text = " Romatizmaya Ýyi Gelen Besinler ";
            urunResmi.sprite = KeremResimler[47];

            konu.text = "\n  NAR\n\n - Nar ve nar özünün içinde bulunan flavonoid antosiyan bileþeni iltihap ile mücadelede oldukça etkilidir.\n" +
                " - Düzenli olarak nar yiyerek ya da nar suyu içerek romatizma aðrýlarýnýzýn þiddetini azaltabilirsiniz.\n\n\n" +
                "  YUMURTA\n\n - Yumurta içerisindeki B vitamini ve sülfür sayesinde kas, eklem, kýkýrdak ve bað dokularýnýn geliþmesini saðlar.\n" +
                " - Kemik saðlýðýný korur.\n - Romatizma hastalarý düzenli olarak yumurta tükettikleri takdirde hem aðrýlarý azalýr hem de kemikleri güçlenir.\n\n\n" +
                "  ZENCEFÝL\n\n - Antienflamatuar bir baharat olan zencefil, iltihap ile mücadelede oldukça etkilidir.\n - Zencefili çay olarak tüketebilir ya da yemeklerinize ekleyebilirsiniz.\n\n\n" +
                "  ÇÝLEK\n\n - En lezzetli yaz meyvelerinden biri olan çilek, içeriðindeki salisilik asit sayesinde romatizma aðrýlarýna da iyi geliyor.\n\n\n" +
                "  KELLE PAÇA ÇORBASI ve KEMÝK SUYU\n\n - Romatizma hastalýðýnýn en önemli sebeplerinden biri de vücuttaki kolajen üretiminin azalmasýdýr.\n" +
                " - Bol miktarda kolajen içeren kemik suyu ve kelle paça çorbasýný hayatýnýza dahil ederek romatizma aðrýlarýnýzý hafifletebilirsiniz.\n\n\n" +
                "  MAYDANOZ\n\n - Yapýlan araþtýrmalarda flavonoid luteolin içeren maydanozun iltihabý önlediði ortaya konmuþtur.\n - Antienflamatuar bir besin olan maydanoz hem aðrýlarý hafifletir hem de eklem sertliðini yok eder.\n\n\n" +
                "  ANANAS\n\n - Yüksek oranda C vitamini içeren ananas içeriðindeki bromelain enzimi sayesinde iltihabý, yangýyý ve eklem þiþliðini azaltýr.\n - Romatizmanýn sebep olduðu þikayetleri minimize etmek için ananas tüketebilir veya suyunu içebilirsiniz.\n" +
                " !! Düzenli olarak kullandýðýnýz herhangi bir ilaç varsa ananas tüketimi konusunu mutlaka doktorunuza danýþmalýsýnýz. Ananas ilaç ile etkileþime girerek farklý etkiler yaratabilir.\n\n";
        }

        if (urun == "Roka")
        {
            baslik.text = " Rokanýn Faydalarý ";
            urunResmi.sprite = KeremResimler[48];

            konu.text = "\n - Yapraklarý idrar söktürücü, yað yakýcý etkisinin yanýnda mideye de iyi gelmektedir. Diyetlerde sýklýkla yer alarak, ödem oluþumunu engellemesi, böylece yað kaybýnýn kesintisiz devam etmesi saðlanýr. Çið olarak kahvaltýlarda veya salatalarda tüketilmesinin yaný sýra maydanoz ve dereotu gibi bitkilerle içme sularýný aromalandýrmak için de kullanýlabilir.\n\n" +
                " - Roka, kanseri önleyici aktiviteye sahip enzimleri içerir. Bu enzimi uyaran aktivite dolaylý olarak kanser oluþumunu engelleyen, vücudun kendi kendini korumasýný saðlayan süreci güçlendirir.\n\n" +
                " - Tohum tahriþ edici ve uyarýcýdýr. Toz haline getirilmiþ tohum antibakteriyel aktiviteye sahiptir. Tohumdan elde edilen yað afrodizyak özelliklere sahiptir.\n\n" +
                " - Roka yaðý, masaj yapmak ve cildi yatýþtýrmak için kullanýlabilir.\n\n" +
                " - Roka salatasý, K vitamini için mükemmel sebze kaynaklarýndan biridir; 100 g, önerilen alýmýn yaklaþýk %90'ýný saðlar. K vitamini, kemik oluþumu ve güçlenmesi aktivitesini teþvik ederek kemik saðlýðýnda potansiyel bir role sahiptir.\n\n";
        }
        #endregion

        // U ile baþlayanlar
        #region U ile baslayanlar 
        if (urun == "Unutkanlýk")
        {
            baslik.text = " Unutkanlýða Ne Ýyi Gelir ";
            urunResmi.sprite = KeremResimler[49];

            konu.text = "\n YEÞÝL ÇAY\n\n - Yeþil çay hemen hemen her hastalýðýn tedavisinde kullanýlmaktadýr. Birçok faydasý olduðu bilinen yeþil çayýn unutkanlýða da oldukça iyi geldiði bilinmektedir. Ýçerdiði bileþenler sayesinde hafýzayý da güçlendiren yeþil çay mutlaka tüketilmesi gerekmektedir.\n\n\n" +
                " NAR SUYU\n\n - Eðer sürekli olarak unutkanlýk þikayeti yaþýyorsanýz nar suyu tüketebilirsiniz. Nar suyu da oldukça þifalý bir sudur. Nar suyu beyin hücrelerini korur ve onarýr. Bu þekilde unutkanlýða neden olan faktörleri ortadan kaldýrýr.\n\n\n" +
                " DOMATES\n\n - Domates yoðun miktarda likopen bileþeni içermektedir. Likopen bileþeni de hafýzayý tüm olumsuz faktörlerden korur. Bundan dolayý unutkanlýk problemi yaþayan kiþilere domates tüketilmesi önerilir. Vücudu tüm serbest radikallere koruduðu gibi beyin fonksiyonlarýný da iyileþtirmektedir. Daha güçlü bir hafýzaya sahip olmanýzý saðlar.\n\n\n\n" +
                " AÞIRI UNUTKANLIÐA ÝYÝ GELEN BESÝNLER\n\n\n" +
                " YABAN MERSÝNÝ\n\n - Hafýzayý güçlendirmesi ile bilinen yaban mersini tüketilmesi uzman doktorlar tarafýndan da sýklýkla önerilir. Yaban mersini ayný zamanda hem hafýzayý güçlendirir hem de zihnin geliþmesini saðlamaktadýr.\n\n\n" +
                " BÝTTER ÇÝKOLATA\n\n - Bitter çikolata en faydalý tatlýlardan bir tanesidir. Yoðun miktarda kafein içermektedir. Ayný zamanda bitter çikolata tüketmek hem iþ hayatýnda hem de okul hayatýnda konsantrasyonu arttýrmaktadýr. Bitter çikolata kiþiye ayný zamanda enerji takviyesi de yapmaktadýr. Sürekli olarak bitter çikolata tüketerek hafýzanýzý daha da diri bir hale getirebilirsiniz.\n\n\n" +
                " ISPANAK\n\n - Demir bakýmýndan en zengin gýdalardan olan ýspanak ayný zamanda folik asit içermektedir. Folik asitte yine hafýzayý güçlendirir ve diri tutar. Aþýrý unutkanlýk gibi problemlerinizi ýspanak ile geçirebilirsiniz.\n\n";
        }

        if (urun == "Uyku")
        {
            baslik.text = " Uykuya Geçiþi Kolaylaþtýran Besinler ";
            urunResmi.sprite = KeremResimler[50];

            konu.text = "\n - Süt ve süt ürünleri, uykuyu tetikleyici madde olan triptofan içerir. Kuruyemiþler ve yaðlý tohumlar, muz, bal ve yumurta da triptofan kaynaklarý arasýndadýr.\n\n" +
                " - Akþam yemeðinde yeterli olacak þekilde yemek yemediyseniz, midenizden gelen gurultular yüzünden uykuya dalmanýz zorlaþabilir. Karbonhidratlardan zengin besinler, uykuyu tetikleyen triptofanýn kandaki seviyesini arttýrýr.\n\n" +
                " - Bazý bireyleri kafein daha fazla etkiler, bazý bireyler ise hiç þikayet etmez eðer sizinde hassasiyetiniz olduðunu düþünüyorsanýz; daha iyi bir uyku için, yatmadan 4-6 saat önce kafein alýmý kesilmelidir. Bunun için çikolata, kolalý içecekler ve çay içiminizi kontrol etmelisiniz.\n\n" +
                " - Alkol, uykuya çabuk girmenize yarayabilir ancak sýk sýk uyanmanýza, rahatsýz bir uykuya, baþ aðrýsýna, terleme ve kâbus görmenize sebep olabilir. Eðer akþam alkol alýyorsanýz, etkilerini azaltmak için ayný miktarda su içmeye özen gösterin.  Ýyi bir uyku için yatmadan 2 ila 4 saat önce alkol alýmý kesilmelidir.\n\n" +
                " - Su tüketimin ne kadar önemli olduðu her zaman vurguluyoruz ancak kesintisiz bir uyku istiyorsanýz yatmadan 1 saat öncesine kadar sývý alýmýný kesmeniz olacaktýr. Aksi takdirde sýklýkla tuvalete kalkma ihtiyacý duyabilirsiniz, bu durum uykunuzun sürekli bölünmesine sebep olacaktýr.\n\n" +
                " - Proteinler, günlük beslenmemiz için çok önemli olmakla birlikte, yatmadan önce alýnan proteinler güzel bir uyku için iyi bir tercih sayýlamaz.  Proteinden zengin besinlerin sindirimi biraz daha zordur. Bunun için uykuya yardýmcý minik bir karbonhidrat alabilirsiniz.\n\n" +
                " - Uyku getiren yiyeceklerin baþýnda yer alan muz çok iyi bir yatýþtýrýcýdýr. Serotonin ve melatonin hormonlarýnýn yanýnda içerdiði magnezyumla da kaslarý gevþetip insaný rahatlatýr. Gerçek bir uyku hapý gibi olan muz, yatmadan bir iki saat önce yenirse, iyi bir uyku öncesi terapi gibi gelecektir.\n\n" +
                " - Uyku düzensizliði ve uyumaya yardýmcý olmasý için akþam saatlerinde anason çayý tüketilebilir. Kesintisiz bir uyku ile rahat bir gece geçirebilirsiniz. Anason çayýný tüketirken dikkat edilmesi gereken noktalar olduðunu hatýrlatalým, kullanmadan önce doktorunuza danýþmayý unutmayýn.\n\n" +
                " - Çok bilinmese de bal da uyumaya yardýmcý yiyecekler arasýndadýr. Akþamlarý bitki çayýnýza veya ýlýk sütünüze ekleyeceðiniz bir çay kaþýðý bal sizi gevþetip uyku hali oluþturacaktýr. Özellikle muz ve süt ile karýþtýrdýðýnýzda etkisini artýrýp uyku öncesi rahatlýðý yaþayabilirsiniz.\n";
        }

        if (urun == "Uyuz")
        {
            baslik.text = " Uyuza Ne Ýyi Gelir ";
            urunResmi.sprite = KeremResimler[51];

            konu.text = "\n - Uyuza iyi gelen yöntemlerden biriside çay aðacý yaðý kullanmaktýr. Çay aðacý yaðý antiparazitik, antibakteriyel ve antifungal özelliklere sahip bir doðal yaðdýr. Bu özellikle ile derinin altýnda yaþamýný sürdüren akarlarýn ölmesini saðlar.\n\n" +
                " - Bir diðer iyi gelen yöntem ise hemen hemen herkes tarafýndan bilinen bir yöntem olan sirke kullanýmýdýr. Beyaz sirke cildin pH dengesini deðiþtirir ve bu deðiþiklik sonucunda uyuz böceklerini öldürür.\n\n" +
                " - Uyuz tedavisi tuz yöntemi kýsa süre içerisinde sizi bu böceklerden kurtaracaktýr. Tuzu, bir su içerisinde eritip banyo yapmak uyuz tedavisine iyi gelen bir yöntemdir.\n\n" +
                " - Son olarak diðer bir iyi gelen yöntem ise Aloe Vera jeli yöntemidir. Bunun için öncelikle Aloe Vera jelini, uyuz olan bölgeye sürüp bekleyiniz.\n\n";
        }
        #endregion

        // Ü ile baþlayanlar
        #region Ü ile baslayanlar
        if (urun == "Ülser")
        {
            baslik.text = " Ülser ";
            urunResmi.sprite = KeremResimler[52];

            konu.text = "\n ÜLSER NEDÝR?\n\n - Ülser, mide asidi ve sindirim sývýlarý gibi tahriþ edici nitelikteki vücut sývýlarýnýn mide veya onikiparmak baðýrsaðýný (duodenum) tahrip etmesi ve bunun sonucunda doku kaybýnýn ortaya çýkmasýdýr. Mide ve onikiparmak baðýrsaðýný sindirim enzimlerinden koruyan mukus tabakasýnýn azalmasý, ülserin ortaya çýkmasýnýn en büyük nedenlerinden biridir.\n\n\n" +
                " ÝYÝ GELEN BESÝNLER\n\n" +
                " - Ülser tedavisinde öne çýkan en önemli vitamin, K vitaminidir. K vitamini, mide dokusundaki zarýn ve açýk yaralarýn iyileþmesinde etkilidir. K vitamini bakýmýndan zengin ve buna baðlý olarak ülsere iyi gelen besinler ise ýspanak, kuþkonmaz, lahana, avokado, soya, yonca ve çavdar unudur. \n\n" +
                " - Flavonoid içeren bazý besinler de ülserin tedavisinde katký saðlayabilir. Flavonoidler, ülser geliþimini engelleyerek mide zarýný korumaya yardýmcý olur. Sarýmsak, soðan, kereviz ve elma flavonoid bakýmýndan zengin besinler arasýndadýr.\n\n" +
                " - Lifli gýdalar parçalandýklarý zaman hidroklorik asidi kontrol ederler. Bu durum, mide ülserinde asidin hasar vermesini engeller. Ülsere iyi gelen besinlerden biri olan lifli besinler ise sebzeler, meyveler ve tahýl gruplarýdýr.\n\n";
                
        }

        if(urun=="Üzerlik Tohumu")
        {
            baslik.text = " Üzerlik Tohumu ";
            urunResmi.sprite = KeremResimler[53];

            konu.text = "\n ÜZERLÝK TOHUMU NASIL KULLANILIR?\n\n - Üzerlik tohumunun bir çok faydasý ve bir çok kullaným alaný vardýr. Bunlardan biri tohumunun çay olarak tüketilmesidir. Üzerlik tohumundan elde edilen çay saðlýk açýsýndan önemli bir yere sahiptir. Diðer bir kullaným alaný ise tütsü olarak yakýlmasýdýr. Evden kötülükleri uzaklaþtýrdýðý, büyü bozduðu ve nazardan koruduðu söylenir.\n\n\n" + 
                " FAYDALARI\n\n" +
                " - Burun týkanýklýklarýnda üzerlik tohumu yakýlýr ve dumaný çekilirse üst solunum yollarý açýlýr.\n\n" +
                " - Baðýrsaklarda ortaya çýkan kurtlarýn ortadan kalkmasýna yardýmcý olur.\n\n" +
                " - Alerjik reaksiyonlara karþý vücudu korur.\n\n" +
                " - Adet kanamalarýný söktürür. Hormonlarýn düzenli çalýþmasýný saðlar.\n\n" +
                " - Baþ aðrýlarýna iyi gelir.\n\n" +
                " - Daha rahat uyumanýza yardýmcý olur\n\n" +
                " - Kötü enerjilerden korur.\n\n" +
                " - Kanserle mücadelede ek takviye olarak kullanýlýr.\n\n" +
                " - Saçlarýn eski rengine dönmesini saðlar.\n\n" +
                " - Hafýzayý destekler.\n\n" +
                " - Göz iltihaplarýnda pamuk ile çayý göze sürüldüðünde iltihabý ortadan kaldýrýr.\n\n";
        }

        if (urun == "Üvez")
        {
            baslik.text = " Üvezin Faydalarý ";
            urunResmi.sprite = KeremResimler[54];

            konu.text = "\n - Balgam söktürücü bir etki oluþturuyor.\n\n" +
                " - Tansiyonu ve kan þekerini düþürücü bir etkide bulunuyor.\n\n" +
                " - C vitamini bakýmýndan zengin olduðundan baðýþýklýk sisteminin güçlenmesine yardýmlarý dokunuyor.\n\n" +
                " - Ýçinde üvez kullanýlarak hazýrlanan krem ve sabunlarýn cildi temizlediði, antioksidan etkisi gösterdiði söyleniyor.\n\n" +
                " - Vücutta oluþan iltihaplarýn daha hýzlý bir þekilde iyileþmesini saðlýyor.\n\n" +
                " - Kadýnlarýn regl dönemlerinin çok daha rahat bir þekilde geçmesine destek oluyor.\n\n" +
                " - Ýdrar söktürücü bir etki oluþturduðu söyleniyor.\n\n" +
                " - Vücutta biriken ödemin ve buna baðlý oluþan þiþliklerin yok edilmesine yardýmcý oluyor.\n\n" +
                " - Kan yapýcý bir etkisi olduðu da söyleniyor.\n\n" +
                " - Ayný zamanda kabýzlýk sorunu yaþayanlara çayýyla çare oluyor.\n\n";
        }
        #endregion

        // V ile baþlayanlar
        #region V ile baslayanlar
        if (urun == "Varis")
        {
            baslik.text = " Varis ";
            urunResmi.sprite = KeremResimler[55];

            konu.text = "\n VARÝS NEDÝR?\n\n - Varis birçok insanda görülen bir toplardamar hastalýðýdýr. Toplardamarlarýn deri altýnda çeþitli þekillere girerek kývrýmlar oluþturmasýna denir.\n" +
                " - Varis, sýklýkla gün içerisinde her türlü vücut yükünü taþýyan bacaklarda görülen bir toplardamar hastalýðýdýr. Varis, damarlarýn þiþ halinde görülmesiyle baþlasa da zamanla ve önlem alýnmadýðý takdirde damar çatlaklarýna kadar ciddi problemlere yol açabilir. Varis, ilk etapta sadece görüntü itibarýyla rahatsýzlýk verici olsa da ilerlediði zaman aðrýlý bir hastalýða dönüþebilir.\n\n\n\n" +
                " VARÝSE NE ÝYÝ GELÝR?\n\n\n ELMA SÝRKESÝ\n\n - Cilt, saç bakýmý, zayýflama ve birçok konuda adeta bitkisel iksir olarak karþýmýza çýkan elma sirkesi, varis doðal tedavisi için tercih edilen en etkili yöntemlerden biridir.\n\n" +
                " - Elma sirkesini pamuklu bir bez yardýmýyla ýslatýp varisli bölgede bitkisel tedaviye baþlayabilirsiniz. Elmalý sirkeye batýrdýðýnýz bezi 30 – 35 dakika varisin olduðu bölgeye sararak bekletebilirsiniz. Bu esnada bacaklarýnýzý vücut hizasýný geçer vaziyette yukarýya doðru uzatýn. Bu pozisyonda 10-15 dakika bekleyin.\n\n\n" +
                " MAYDANOZ SUYU\n\n - Maydanoz suyu iltihaplanma problemleriyle sýký sýkýya mücadele eden bir bitkisel çözümdür.\n\n" +
                " - Maydanoz çayý içeriðinde bulunan antioksidanlar sayesinde vücuttaki herhangi bir iltihap bulundurmaz.\n\n" +
                " - Dolaþým sisteminin daha saðlýklý ve düzenli çalýþmasýný saðlar.\n\n\n" +
                " ADAÇAYI\n\n - Damarlarda oluþan iltihaplanmalarý azaltýp bu süreci kontrol altýna alýr. Ýltihaplanmalarýn yayýlma hýzýný yavaþlatýr.\n\n\n" +
                " AT KESTANESÝ\n\n - At kestanesi, içeriðinde bulunan diüretik ve antienflamatuar özellikleri sayesinde dolaþým sorunlarýna çare olur.\n\n" +
                " - At kestanesi çayý içerek hem vücutta bulunan iltihabýn azalmasýný saðlayabilirsiniz.\n\n" +
                " - At kestanesi ile damar saðlýðýnýzý koruyabilirsiniz.\n\n";
        }

        if (urun == "Veba")
        {
            baslik.text = " Veba ";
            urunResmi.sprite = KeremResimler[56];

            konu.text = "\n VEBA NEDÝR\n\n - Veba, esas olarak pireler yoluyla bulaþan ve çok kýsa süre içerisinde ölüme yol açabilecek ciddi sonuçlarý olan bir bakteriyel enfeksiyondur. Vebaya neden olan bakteriyel organizmanýn adý Yersinia Pestis’tir. Günümüzde en yaygýn olarak Afrika, Asya ve Amerika kýtalarýnýn kýrsal ve yarý kýrsal bölgelerinde bulunan küçük kemirgenlerde görülür. Yersinia Pestis enfekte kemirgenlerle beslenen pireler tarafýndan ýsýrýlma yolu ile insanlara ya da hayvanlara bulaþýr. Enfekte hayvanlarla uðraþan insanlar da, bu hayvanlardan doðrudan enfekte olabilirler.\n\n" +
                " - Ortaçað’da Kara Ölüm olarak bilinen veba, günümüzde dünya çapýnda yýllýk 5.000'den az vaka sayýsýna sahiptir. Veba derhal antibiyotikler ile tedavi edilmezse sonuçlarý ölümcül olabilir.\n\n\n\n" +
                " VEBA NASIL ÖNLENÝR\n\n - Vebaya karþý henüz tam etkili bir aþý yoktur. Ancak bilim adamlarý bir veba aþýsý geliþtirmek için araþtýrmalarýný sürdürmektedir. Risk altýnda olan, veya vebaya maruz kalan bireylerde enfeksiyon geliþmesini antibiyotikler önlemeye yardýmcý olabilir.\n\n" +
                " - Veba vakalarýnýn ya da salgýnlarýnýn görüldüðü bilinen bölgelerde bireylerin çeþitli önlemleri almasý tavsiye edilir. Öncelikle kalýnan konutlar kemirgenlere karþý korunmalýdýr. Ev çevresindeki çalý, hurda, kaya, veya yakacak odun yýðýnlarý gibi kemirgenlerin olasý yuvalama alanlarýnýn temizlenmesi gereklidir. Eðer bir kemirgen istilasý mevcutsa, bunun kontrol altýna alýnmasý için gerekli adýmlar atýlmalýdýr. Böcek kovucu araçlarýn ve yöntemlerin uygulanmasý önemlidir.\n\n";
        }

        if (urun == "Viþne")
        {
            baslik.text = " Viþnenin Faydalarý ";
            urunResmi.sprite = KeremResimler[57];

            konu.text = "\n - Baðýþýklýk sistemini güçlendirir.\n\n" +
                " - Ýyi bir A ve C vitamini kaynaðýdýr.\n\n" +
                " - Kalsiyum, demir ve fosfor minerallerini içerir.\n\n" +
                " - Sinir sistemini düzenleyici etkisi vardýr.\n\n" +
                " - Prostat ve kolon kanserine karþý koruma saðlar.\n\n" +
                " - Uykusuzluða karþý oldukça faydalýdýr.\n\n" +
                " - Kuvvetli bir antioksidandýr.\n\n" +
                " - Kabýzlýk sorununu giderir.\n\n" +
                " - Kanser hücrelerinin büyümesini engeller.\n\n" +
                " - Bakterilerden ve mantarlardan korur.\n\n" +
                " - Kolesterolü düzenleyici etki yapar.\n\n" +
                " - Grip, nezle ve soðuk algýnlýðýna karþý önleyici etkisi vardýr.\n\n" +
                " - Parkinson hastalýðýna karþý koruma saðlar.\n\n" +
                " - Beyin ve sinir sistemi için oldukça yararlýdýr.\n\n" +
                " - Unutkanlýða karþý etkilidir.\n\n" +
                " - Depresyona, strese karþý faydalýdýr.\n\n" +
                " - Kalp atýþlarýný düzenler, kalp hastalýklarýna karþý korur.\n\n" +
                " - Yaþlanma karþýtý bir meyvedir. Anti-ageing özelliði vardýr.\n\n";
        }

        if (urun == "Vanilya")
        {
            baslik.text = " Vanilyanýn Faydalarý ";
            urunResmi.sprite = KeremResimler[58];

            konu.text = "\n - Antibakteriyeldir.\n\n" +
                " - Baðýþýklýk sistemini güçlendirir.\n\n" +
                " - Vücut üzerindeki stresi azaltmaya yardým eder.\n\n" +
                " - Yaralardan ve hastalýklardan kurtulmayý hýzlandýrýr.\n\n" +
                " - Saç için birçok sorunun çaresidir. Kýrýlmýþ saçlar ve saç dökülmesi sorunu olanlar için çok faydalýdýr. Vanilya kafa derisine kan akýþýný hýzlandýrdýðý için saçlarýn gürleþmesini ve büyümesini saðlar.\n\n" +
                " - Serbest radikaller yüzünden ortaya çýkan cilt rahatsýzlýklarýný engeller.\n\n" +
                " - Boðazdaki iltihabý ve tahriþi azaltmaya yardým eder.\n\n" +
                " - Öksürük, soðuk algýnlýðý ve solunum yolu hastalýklarý ile savaþýr.\n\n";
        }

        if (urun == "Verem Hastalýðý")
        {
            baslik.text = " Verem Hastalýðý ";
            urunResmi.sprite = KeremResimler[59];

            konu.text = "\n VEREM NEDÝR?\n\n - Verem hastalýðý, yani týbbi adýyla tüberküloz (TB) hava yoluyla bir bireyden diðerine yayýlan, bulaþýcý bir akciðer hastalýðýdýr. Verem hastalýðý Mycobacterium Tuberculosis isimli bakterilerden kaynaklanýr. Verem hastalýðý tedavi edilebilir ve verem aþýsý ile önlenebilir bir hastalýktýr.\n\n\n" +
                " VEREM HASTALIÐININ YAYILMASI NASIL ÖNLENÝR?\n\n - Verem hastalýðýnýn daha yaygýn olduðu ülkelerde bebekler, çocuklarda þiddetli verem hastalýðýný engelleyebileceði için, genellikle basil Calmette-Guerin (BCG) aþýsý, yani verem aþýsý ile aþýlanýr.\n\n" +
                " - BCG aþýsý yapýlmýþ çocuklara ayný aþý tekrar yapýlmaz. Bu aþý ile aþýlanmamýþ çocuklarda ise 6 yaþýndan sonra BCG aþýsý önerilmemektedir, çünkü aþý yaþ ilerledikçe etkinliðini yitirmektedir.\n\n" +
                " - Eðer bir birey yapýlan testlerde gizli verem hastalýðý enfeksiyonu için pozitif sonuç verirse, doktor aktif tüberküloz geliþtirme riskini azaltmak için ilaç kullanýmýný önerebilir. Bulaþýcý olan tek tüberküloz tipi, aktif olan ve akciðerleri etkileyen tiptir. Dolayýsýyla gizli verem hastalýðýnýn aktifleþmesi önlenirse, hastalýk baþkalarýna bulaþtýrýlmaz.\n\n" +
                " - Verem hastalýðýnýn yayýlmasýný önlemek için alýnacak önlemlerden ilki evde kalmaktýr. Doktorun tavsiye ettiði süre boyunca iþe, okula gidilmemeli, baþkalarýyla ayný odada uyunmamalýdýr.\n\n" +
                " - Kalýnan odalar mutlaka havalandýrýlmalýdýr. Verem mikroplarý kendi baþlarýna hareket edemezler, bu yüzden havanýn çok hareket etmediði küçük kapalý alanlarda daha kolay bulaþýrlar.\n\n" +
                " - Dýþarýsý çok soðuk olmadýðý sürece pencereleri açýp, içerideki havayý bir vantilatör ile dýþarý yönlendirmek etkili olacaktýr. Gülünce, hapþýrýnca, veya öksürünce aðzý bir mendil ile örtmek gereklidir.\n\n" +
                " - Kirlenen mendilleri ayrý bir torbaya koyup, torbayý baðladýktan sonra ayrýca atmak gereklidir. Hastalýðýn tedavisinin ilk üç haftasýnda baþkalarýnýn yanýndayken cerrahi maske takmak bulaþma riskini azaltmaya yardýmcý olabilir.\n\n";
        }
        #endregion

        // Y ile baþlayanlar
        #region Y ile baslayanlar
        if (urun == "Yoðurt")
        {
            baslik.text = " Yoðurdun Faydalarý ";
            urunResmi.sprite = KeremResimler[60];

            konu.text = " - Yoðurttaki probiyotikler vücudunuzun polen ve diðer alerjenlere reaksiyonunu azaltabilir.\n\n" +
                " - Yoðurdun birçok faydasýndan biri, baðýþýklýk arttýrýcý etkilere sahip olmasýdýr. Yoðurtun T hücrelerinizi veya enfeksiyonla savaþan hücreleri daha güçlü ve daha aktif hale getirdiði kanýtlanmýþtýr.\n\n" +
                " - Yoðurt yemek, vücudunuza sindirimi düzenli tutmak için çalýþan saðlýklý bakteriler saðlar. Hem kabýzlýk hem de ishal ile daha az sorun yaþamanýza yardýmcý olabilir.\n\n" +
                " - Ýnsanlarýn yaþadýðý hastalýklarýn çoðu diyabet, Crohn hastalýðý, kanser ve kronik yorgunluk sendromu gibi iltihaplanma ile ilgilidir. Yoðurdun probiyotik bakterileri vücuttaki iltihabý azaltmaya ve bu hastalýklarla ilgili riskleri veya etkilerini azaltmaya yardýmcý olabilir.\n\n" +
                " - Yoðurt tam bir protein kaynaðýdýr, yani vücutta kas ve diðer dokularý oluþturmak için gerekli tüm amino asitleri içerir.\n\n" +
                " - Yoðurt, kemik saðlýðýnda kilit rol oynayan vitaminler ve mineraller bakýmýndan zengindir. Düzenli olarak tüketilmesi osteoporoz riskini azaltabilir.\n\n" +
                " - Yoðurt, “iyi” HDL kolesterolü artýrýp, kan basýncýný düþürerek kalp saðlýðýna fayda saðlar.\n\n";
        }

        if (urun == "Yumurta")
        {
            baslik.text = " Yumurtanýn Faydalarý ";
            urunResmi.sprite = KeremResimler[61];

            konu.text = " - Yumurta içerisinde yüksek oranda yað bulunuyor. Bu yað ise kandaki iyi kolesterolü artmasýný saðlýyor. Vücutta bulunan iyi kolesterol baþta damar sistemi olmak üzere kalbin saðlýklý ve güçlü olmasýna yardýmcý oluyor.\n\n" +
                " - Yumurta son derece besleyici bir gýda olarak tüketiliyor. Düzenli yumurta tüketimi insan vücudunda kemiklerin güçlenmesinde büyük rol alýyor. Bu özelliði ile büyümeyi ve geliþmeyi hýzlandýrýyor. Ýlerleyen yaþlarda kemik erimesi riskinin azalmasýnda etkili oluyor.\n\n" +
                " - Kaslarýn geliþmesine de destek veriyor. Kaslarýn geliþiminde etkili olan protein sayesinde vücutta bulunan kas kütlesinin artmasýna yardýmcý oluyor. Özellikle vücut geliþtirme sporlarý ile birlikte yapýlan diyetlerde vazgeçilmez besin oluyor.\n\n" +
                " - Yumurta besleyici olduðu kadar duyu organlarýný güçlendirmesi ile de fayda saðlýyor. Gözlerin saðlýklý olmasý ve iyi görmesine büyük fayda saðlýyor.\n\n" +
                " - Vücudun ihtiyaç duyduðu enerjiyi saðlýyor. Hastalýklara karþý dirençli olmasýný saðlýyor. Baðýþýklýk sistemini güçlendiriyor.\n\n" +
                " - Baðýþýklýk sistemini güçlendirmesi ve bedeni beslemesi ile kanser olma riskini azaltýyor. Özellikle de meme kanserine karþý vücudu koruyor.\n\n" +
                " - Beyin geliþimini kuvvetlendiriyor. Hafýza problemlerinin oluþma riskini azaltýyor. Her yaþta zihnin geliþmesini ve saðlýklý olmasýný destekliyor.\n\n";
        }

        if(urun=="Yaban Mersini")
        {
            baslik.text = " Yaban Mersininin Faydalarý ";
            urunResmi.sprite = KeremResimler[62];

            konu.text = " - Yaban mersinine koyu mavi rengini veren antosiyanin kandaki serbest radikallerin atýlmasýna yardýmcý olur ve böylece vücudu kanser de dahil olmak üzere çeþitli hastalýklara karþý korur. Yaban mersininin düzenli tüketimi nörodejeneratif hastalýklar ve sindirim hastalýklarýna karþý da koruyucu olmaktadýr.\n\n" +
                " - Yaban mersini zengin antioksidan içeriði ile kolesterol seviyesini kontrol etmeye de yardýmcý olmaktadýr. Çalýþmalar, bu bileþenlerin kan yað dengesini iyileþtirmeye ve damarlarýn týkanmasýný önlemeye yardýmcý olduðunu ortaya koymuþtur. Ayrýca, kan basýncýný düþürmeye yardýmcý olarak kalp hastalýklarý riskini azaltýr. Bu nedenle yaban mersini kalbe iyi gelir ve kalp saðlýðýný destekler.\n\n" +
                " - Yaban mersini baðýþýklýk sistemini güçlendirir. Ýçerisinde bulunan antosiyaninler gibi flavonoidlerin yaný sýra yüksek C ve E vitamini içeriðiyle bakteri ve virüslerin yayýlmasýný önler, böylece baðýþýklýk sisteminin zayýflamasýný engeller. Yaban mersini ayrýca anti-inflamatuar özelliklere sahiptir, öksürük ve soðuk algýnlýðý riskini önemli ölçüde azaltabilir.\n\n" +
                " - Yaban mersini kan þekerini düzenler. Düþük bir glisemik indeksine sahip olduðu için diyabet ve insülin direnci gibi kan þekeri ile ilgili sorunlardan muzdarip olanlar için faydalýdýr. Yaban mersini þeker seviyesinin düzenlenmesine yardýmcý olur.\n\n" +
                " - Yaban mersini iyi bir vitamin, mineral ve lif kaynaðýdýr. Yüksek C vitamini içeriðiyle birlikte mineraller vücut tarafýndan daha iyi emilir ve kan oluþumunu ve hücrelere oksijen taþýnmasýný destekler. Yaban mersini iyi bir diyet lifi kaynaðýdýr, sindirime yardýmcý olur ve baðýrsak saðýlýðý üzerinde olumlu bir etkiye sahiptir.\n";
        }

        if(urun=="Yasemin Çayý")
        {
            baslik.text = " Yasemin Çayýnýn Faydalarý ";
            urunResmi.sprite = KeremResimler[63];

            konu.text = "\n - Yasemin çayý yüksek oranda antioksidan içerir. Bunun yanýnda vücudun baðýþýklýk sistemini güçlendirir.\n\n" +
                " - Kötü huylu kanser hücrelerinin üremesini engeller.\n\n" +
                " - Kalp ve damar saðlýðýný geliþtirmede oldukça etkilidir.\n\n" +
                " - Yasemin çayý kokusu ile sinirlerinizi yatýþtýrýr gerginliðinizi azaltýr.\n\n" +
                " - Kolesterolü dengede tutar ve kalp damar hastalýklarýna iyi gelir.\n\n" +
                " - Güzelliðe de katkýsý olan yasemin çayý yaþlanma belirtilerini geciktirir.\n\n" +
                " - Diyabet hastalýðýný önlemek için birebirdir.\n\n" +
                " - Ýçerisinde bulunan antiviral ve anti bakteriyel özellikle sayesinde grip ve soðuk algýnlýðý tedavisinde kullanýlýr.\n\n" +
                " - Metabolizmayý hýzlandýrýr. Bu nedenle kilo verilmesine yardýmcý olur.\n\n" +
                " - Yasemin çayý algýlarýnýzý açar ve uyanýk kalmanýzý saðlar.\n";
        }

        if(urun=="Yer Elmasý")
        {
            baslik.text = " Yer Elmasýnýn Faydalarý ";
            urunResmi.sprite = KeremResimler[64];

            konu.text = "\n - Yüksek A ve B vitamini içerir.\n\n" +
                " - Afrodizyak etkisi bulunur.\n\n" +
                " - Halsizlik ve yorgunluðu azaltýr.\n\n" +
                " - Ýdrar söktürücüdür.\n\n" +
                " - Sinir sistemini korur. Stresin etkilerini azaltýr, sakinleþtirir.\n\n" +
                " - Sindirim sistemini düzenler. Kabýzlýða iyi gelir.\n\n" +
                " - Mide aðrýlarýný hafifletir.\n\n" +
                " - Baðýþýklýk sistemini güçlendirir.\n\n" +
                " - Yaralarýn iyileþmesini hýzlandýrýr.\n\n" +
                " - Romatizma aðrýlarýný hafifletir.\n\n" +
                " - Düþük kalorilidir. Zayýflamak isteyenlerin kilo vermelerini destekler.\n\n" +
                " - Yer elmasý, þeker hastalýðý üzerinde olumlu etkilere sahiptir. Kan þekerini dengeler.\n\n" +
                " - Niþasta içermez.\n\n";
        }

        if (urun == "Yanýk")
        {
            baslik.text = " Yanýk ";
            urunResmi.sprite = KeremResimler[65];

            konu.text = "\n YANIK DERECELERÝ NE DEMEKTÝR\n\n\n  1. Derece Yanýk:\n- Bu küçük yanýk tipi, sadece cildin dýþ tabakasýný (epidermis) etkiler. Kýzarýklýk ve aðrýya neden olabilir.\n\n" +
                "  2. Derece Yanýk:\n- Bu tür yanýklar hem epidermisi, hem de ikinci deri tabakasýný (dermis) etkiler. Þiþmeye, kýrmýzý, beyaz veya lekeli cilde neden olabilir. Kabarcýklar geliþebilir ve aðrý þiddetli olabilir. Derin ikinci derece yanýklar, yara izine neden olabilir.\n\n" +
                "  3. Derece Yanýk:\n- Bilindiði gibi cildin altýnda bir yað tabakasý bulunmaktadýr. Bu tip yanýklarda yanýðýn etkisi cildi de aþarak bu yað tabakasýna ulaþýr. Cilt kösele görüntüsüne bürünür. Üçüncü derece yanýklar, sinirleri yok ederek bölgede hissizliðe ya da uyuþmaya neden olabilir. Acil týbbi müdahale gerektirir.\n\n" +
                "  4. Derece Yanýk:\n- Kemik ve eklemlere kadar iþleyen yanýklardýr. Acil týbbi müdahale gerektirir.\n\n\n" +
                " YANIÐA NE ÝYÝ GELÝR?\n\n\n  Buzlu Olmayan Soðuk Su\n\n - Küçük bir yanýk yaþadýðýnýzda yapmanýz gereken ilk þey, yaklaþýk 20 dakika boyunca yanýk alanýn üzerine serin su uygulamaktýr. Daha sonra yanmýþ bölgeyi yumuþak sabun ve su ile yýkayabilirsiniz. Burada dikkat edilmesi gereken þey suyun 0 dereceye yakýnlýkta soðuk olmamasýdýr. Serin su yeterlidir.\n\n\n" +
                "  Serin Kompresler\n\n - Yanýk bölgesinin üzerine yerleþtirilen serin bir kompres veya temiz ýslak bez, aðrýyý ve þiþmeyi hafifletmeye yardýmcý olur. Serin kompresleri 5-15 dakikalýk aralýklarla uygulayabilirsiniz. Aþýrý soðuk kompresleri kullanmaya çalýþmayýn çünkü bu yaklaþým, yanýklarý daha fazla tahriþ edebilir.\n\n\n" +
                "  Antibiyotikli Merhemler\n\n - Antibiyotikli merhemler ve kremler enfeksiyonlarý önlemeye yardýmcý olur. Yanýklarýnýza antibiyotik içeren ve yanýk için satýlan özel bir merhem uygulayabilir ve steril kalýn olmayan bir bezle örtebilirsiniz. Steril gazlý bezler, bu amaç için oldukça uygun olan pansuman yardýmcýlarýdýr.\n\n\n" +
                "  Aloe vera\n\n - Aloe vera, genellikle “yanýk bitkisi” olarak lanse edilir. Çalýþmalar, aloe veranýn birinci ila ikinci derece yanýklarýn iyileþmesinde etkili olduðuna dair kanýtlar göstermektedir. Aloe vera anti-enflamatuardýr. Dolaþýmý teþvik eder ve bakterilerin büyümesini engeller. Bir aloe vera bitkisinin yapraðýndan alýnan saf jeli, doðrudan etkilenen bölgeye uygulayýn.\n\n\n" +
                "  Bal\n\n - Bal bir anti-enflamatuardýr ve doðal olarak antibakteriyel ve antifungaldir. Bu nedenle, eski zamanlardan beri yara ve yanýk tedavisinde kullanýlmaktadýr. Evinizde hiçbir merhem bulamadýðýnýz takdirde etkilenen bölgeye ince bir tabaka saf bal uygulayabilirsiniz.\n\n";
                
        }
        #endregion

        //Z ile baþlayanlar
        #region Z ile baslayanlar
        if (urun == "Zeytin")
        {
            baslik.text = " Zeytinin Faydalarý ";
            urunResmi.sprite = KeremResimler[66];

            konu.text = "\n SÝNDÝRÝMÝ KOLAYLAÞTIRIR\n\n - Zeytinde bulunan E vitamini ve yað, baðýrsaklarýn daha verimli iþlemesini saðlar.\n\n" +
                " - Zeytinin yapýsýnda yer alan lifler, yediðiniz yemeklerin kolayca sindirilmesini gerçekleþtirir. Böylece baðýrsak sorunlarýndan epey uzak kalmýþ olursunuz.\n\n" +
                " - Her gün düzenli olarak zeytin tükettiðinizde, mide problemlerine karþý önlem alabilirsiniz.\n\n\n" +
                " SAÇ, CÝLT ve TIRNAK ÝÇÝN BESLEYÝCÝ\n\n - Zeytin özü ve zeytinyaðý içeren kozmetik ürünlerini reklamlarda sýkça görebilirsiniz Ýþte bu ürünlerin ana maddesi; zeytinde bulunan vitamin ve minerallerdir.\n\n" +
                " - Þampuanlarda yer almasýnýn nedeni saçlarýn ihtiyacý olan nemi kazandýrmaktýr.\n\n" +
                " - Sabun ve cilt kremlerinde ise; kolajen üretimini artýrdýðý için hücre yenilenmesini saðladýðý için kullanýlýr.\n\n" +
                " - Zeytin, ölü hücrelerin atýlmasýný ve yenilenmesini destekleyen doðal bir besindir.\n\n" +
                " - E vitaminleri sayesinde daha genç ve saðlýklý görünmenizi saðlar.\n\n" +
                " - Yaþlanmayý ertelemek ya da kamufle etmek için öðünlerinize zeytin eklemeyi ihmal etmeyiniz.\n\n\n" +
                " KANSERÝ ÖNLER\n\n - Kansere neden olan her ne neden varsa; zeytin o faktörleri temizlemek için tüketilebilir. Çünkü zeytinin yapýsýnda antioksidan maddeler yer alýr.\n\n" +
                " - Hasar gören hücreleri onarýr ve kiþinin eski saðlýðýný kazanmasý için yardým eder.\n\n" +
                " - Zeytin tüketerek, hücre zarlarýnýzý ömrünüz boyunca koruma altýna almýþ olursunuz.\n\n\n" +
                " UZUN SÜRE TOK TUTAR\n\n - Diyet sürecinde kahvaltý öðünü çok önemlidir. Kahvaltýda almanýz gereken yaðý zeytinden alabilirsiniz.\n\n" +
                " - Sizi uzun süre tok tutarken, metabolizmanýn hýzlanmasýný da saðlar.\n\n" +
                " - Ara öðünlerde ortalama 5 adet zeytin yerseniz, uzun süre açlýðýnýzý bastýrabilirsiniz.\n\n\n" +
                " KALP SAÐLIÐINI KORUR\n\n - Zeytin, sizi kalp hastalýklarýndan ve kalp krizinden koruyan bir besindir.\n\n" +
                " - Zeytin yapýsýnda doymamýþ yað bulunduðu için, kan basýncýný dengeler ve kalp ritmini düzenler.\n\n" +
                " - Kalp saðlýðýný koruma sürecinde yapýsýnda bulunan oleik asitten faydalanýr.\n\n\n" +
                " VÜCUT GELÝÞÝMÝNE DESTEK OLUR\n\n - A, D, E ve K vitaminleri yapýsýndan zengin olan zeytin büyüme çaðýndaki çocuklarýn vücut geliþimine destek olur.\n\n" +
                " - Daha güçlü kas ve kemik yapýsýnýn oluþmasýný saðlar.\n\n" +
                " - Beden geliþimini desteklediði gibi zihin geliþimine de katkýda bulunur çünkü zeytinde bolca omega yað asitleri yer alýr.\n\n\n" +
                " KAN YAPAR\n\n - Zeytin, kansýzlýk problemi için tavsiye edilen besinlerden biridir.\n\n" +
                " - Kandaki demir oranýný yükselterek anemi hastalýðýný ortadan kaldýrýr.\n\n" +
                " - Kolesterol seviyeniz çok yüksek çýktýysa, en ideal rakama indirir.\n\n" ;
                
        }

        if (urun == "Zencefil")
        {
            baslik.text = " Zencefilin Faydalarý ";
            urunResmi.sprite = KeremResimler[67];

            konu.text = "\n - Mide ve baðýrsaklardaki gazý söktürür.\n\n" +
                " - Kusmaya ve mide bulantýsýna karþý son derece etkilidir.\n\n" +
                " - Ýshali ve baðýrsak bozukluklarýný giderir.\n\n" +
                " - Baðýþýklýk sistemini güçlendirir.\n\n" +
                " - Regl aðrýlarýný azaltýr.\n\n" +
                " - Öksürüðü keser.\n\n" +
                " - Metabolizmayý hýzlandýrýr ve iþtah açar.\n\n" +
                " - Kas aðrýlarýný hafifletir.\n\n" +
                " - Soðuk algýnlýðý, grip ve bronþit gibi hastalýklarýn tedavisinde kullanýlýr.\n\n\n" +
                " NASIL TÜKETÝLÝR\n\n - Zencefil genel olarak içeceklerde, salatalarda ve çeþitli yemeklerde kullanýlmaktadýr. Zencefil toz þeklinde tüketilebilir. Toz zencefil baharat olarak yemeklerin içerisine, salatalara ve çeþitli içeceklerin içine katarak tüketilebilir." +
                " Ayrýca kurabiyelerin ve çeþitli atýþtýrmalýklarýn içerisine de konulabilir. Fakat en yaygýn zencefil tüketim þekli çayýnýn yapýlmasýdýr.";
                
        }

        if (urun == "Zerdeçal")
        {
            baslik.text = " Zerdeçalýn Faydalarý ";
            urunResmi.sprite = KeremResimler[68];

            konu.text = "\n ÝLTÝHAP GÝDERÝCÝDÝR\n\n - Zerdeçal, iltihap önleyici yani anti-enflamatuardýr. Sahip olduðu antioksidan özellikten dolayý bakterilere karþý savaþýr ve hücrelerimizi korur. Zerdeçal içindeki kürkümin sayesinde vücudun iyileþmesine katký saðlar.\n\n\n" +
                " SÝNDÝRÝM SÝSTEMÝNÝ KORUR\n\n - Düzenli bir sindirim sistemine sahip olmak istiyorsanýz mutlaka zerdeçal kullanmalýsýnýz. Zerdeçalýn lifli yapýsý sindirim sistemini iyileþtirir. Zerdeçal kabýzlýða iyi gelir. Þiþkinlik ve gaz sorunu yaþayanlar için de doðal bir tedavi yöntemidir.\n\n\n" +
                " KANSERE KARÞI KORUMA SAÐLAR\n\n - Yapýlan çalýþmalara göre zerdeçal içerdiði kürkümin ile hücrelerin DNA’sýnýn bozulmasýný engeller ve kansere karþý korur. Kanser hastalýðýnýn tedavi sürecinde de kanser hücrelerinin artmasýný yavaþlattýðý için tavsiye edilir.\n\n\n" +
                " DEPRESYONUN ETKÝSÝNÝ AZALTIR\n\n - Zerdeçal içinde bulundurduðu B6 vitamini sayesinde seratonin hormonunun salgýlanmasýný saðlar. Yani zerdeçal mutluluk verir. Depresyon ve melankoli yaþýyorsanýz kendinizi daha iyi hissetmenize yardýmcý olur.\n\n\n" +
                " AÐRI KESÝCÝDÝR\n\n - Aðrýyý azaltmada zerdeçal çok etkilidir. Aðrý kesici ilaçlar kullanmak yerine doðal çözümler istiyorsanýz zerdeçalý deneyin. Kas ve eklem aðrýlarý yaþayanlar, diþ aðrýsý yaþayanlar zerdeçal kullanabilir. Diþ aðrýnýz varsa bir çay kaþýðý zerdeçal, yarým çay kaþýðý tuzu ýlýk suyla karýþtýrarak gargara yapabilirsiniz. Adet dönemi aðrýlarý yaþayan kadýnlara da önerilir.\n\n\n" +
                " ALZHEÝMER RÝSKÝNÝ AZALTIR\n\n - Alzheimer hastalýðýnýn kesin tedavisi günümüzde bulunamamýþtýr. Bu nedenle Alzheimer oluþmadan önlemler almak gerekir. Zerdeçalýn unutkanlýk üzerine olumlu etkileri gözlenmiþtir. Zerdeçal tüketimi hastalýðýn risklerini azaltacaktýr. Bunlara ek olarak, zerdeçal odaklanma sorunu yaþayanlara da iyi bir arkadaþ olabilir.\n\n\n" +
                " !!! DÝKKAT !!!\n\n - Zerdeçal þifalý bir bitki olmasýna raðmen aþýrý tüketiminde mide bulantýsý, kalp çarpýntýsý, kan sulanmasý gibi yan etkileri olabilir. Özel bir hastalýðý olanlarýn tüketmeden doktoruna danýþmasýný tavsiye ederiz.\n";
        }

        if(urun=="Zemzem Suyu")
        {
            baslik.text = " Zemzem Suyunun Faydalarý ";
            urunResmi.sprite = KeremResimler[69];

            konu.text = "\n - Uykusuzluk problemi için birebir katký saðlar.\n\n" +
                " - Strese baðlý gerginlik ve öfkeyi azaltýr.\n\n" +
                " - Depresyon ve benzeri psikolojik sorunlarda oldukça etkilidir.\n\n" +
                " - Böbrek yetmezliði gibi problemlere karþý yardýmcý olduðu biliniyor.\n\n" +
                " - Akne ve sivilce ile beraber birçok cilt hastalýðý için fayda saðlar.\n\n" +
                " - Karaciðer hastalýklarýna karþý tedavi yöntemi olarak kullanýlýr.\n\n" +
                " - Kalp krizi riskini önemli oranda azalttýðý bilinir.\n\n" +
                " - Sýtma gibi hastalýklara karþý çözüm üretir.\n\n" +
                " - Kýþýn cilt üzerinde uygulandýðý zaman üþüme problemini ortadan kaldýrýr.\n";
        }

        if (urun == "Zehirlenme")
        {
            baslik.text = " Zehirlenme ";
            urunResmi.sprite = KeremResimler[70];

            konu.text = "\n ZEHÝRLENME HANGi YOLLARLA MEYDANA GELÝR\n\n\n  Sindirim Yoluyla\n\n- En sýk rastlanan zehirlenme yoludur. Sindirim yoluyla alýnan zehirler genellikle ev ya da bahçede kullanýlan kimyasal maddeler, zehirli mantarlar, bozuk besinler, ilaç ve aþýrý alkoldür.\n\n\n" +
                "  Solunum Yoluyla\n\n- Zehirli maddenin solunum yolu ile alýnmasýyla oluþur. Genellikle karbon monoksit (tüp kaçaklarý, þofben, bütan gaz sobalarý), laðým çukuru veya kayalarda biriken karbondioksit, havuz hijyeninde kullanýlan klor, yapýþtýrýcýlar, boyalar ev temizleyicileri gibi maddeler ile oluþur.\n\n\n" +
                "  Cilt Yoluyla\n\n- Zehirli madde vücuda direk deri aracýlýðý ile girer. Bu yolla olan zehirlenmeler böcek sokmalarý, hayvan ýsýrýklarý, ilaç enjeksiyonlarý, saç boyalarý, zirai ilaçlar gibi zehirli maddelerin deriden emilmesi ile oluþur.\n\n\n" +
                " SÝNDÝRÝM YOLU ÝLE ZEHÝRLENMELERDE ÝLKYARDIM\n\n - Bilinç kontrolü yapýlýr,\n\n" +
                " - Aðýz zehirli madde ile temas etmiþse su ile çalkalanýr, zehirli madde ele temas etmiþse el sabunlu su ile yýkanýr,\n\n" +
                " - Yaþam bulgularý deðerlendirilir,\n\n" +
                " - Kusma, bulantý, ishal gibi belirtiler deðerlendirilir,\n\n" +
                " - Kusturulmaya çalýþýlmaz, özellikle yakýcý maddelerin alýndýðý durumlarda hasta asla kusturulmaz,\n\n" +
                " - Bilinç kaybý varsa koma pozisyonu verilir,\n\n" +
                " - Üstü örtülür,\n\n" +
                " - Týbbi yardým istenir (112).\n\n" +
                " - Sindirim yolu ile olan zehirlenmelerde týbbi müdahaleye yardýmcý olmak için olayla ilgili bilgiler toplanarak kaydedilir.\n\n\n\n" +
                " SOLUNUM YOLU ÝLE ZEHÝRLENMELERDE ÝLKYARDIM\n\n - Hasta temiz havaya çýkarýlýr ya da cam ve kapý açýlarak ortam havalandýrýlýr,\n\n" +
                " - Yaþamsal belirtiler deðerlendirilir (ABC),\n\n" +
                " - Yarý oturur pozisyonda tutulur,\n\n" +
                " - Bilinç kapalý ise koma pozisyonu verilir,\n\n" +
                " - Týbbi yardým istenir (112),\n\n" +
                " - Ýlkyardýmcý müdahale sýrasýnda kendini ve çevresini korumak için gerekli önlemleri almalýdýr,\n\n" +
                " - Solunumu korumak için maske veya ýslak bez kullanýlýr,\n\n" +
                " - Elektrik düðmeleri ve diðer elektrikli aletler ve ýþýklandýrma cihazlarý kullanýlmaz,\n\n" +
                " - Yoðun duman varsa hastayý dýþarý çýkarmak için ip kullanýlmalýdýr,\n\n" +
                " - Derhal itfaiyeye haber verilir (110).\n\n\n" +
                " CÝLT YOLU ÝLE ZEHÝRLENMELERDE ÝLKYARDIM\n\n - Yaþam bulgularý deðerlendirilir,\n\n" +
                " - Ellerin zehirli madde ile temasý önlenmelidir,\n\n" +
                " - Zehir bulaþmýþ giysiler çýkartýlýr,\n\n" +
                " - 15–20 dakika boyunca deri bol suyla yýkanmalýdýr,\n\n" +
                " - Týbbi yardým istenir (112).\n";

        }
        #endregion
    }


   
}
  

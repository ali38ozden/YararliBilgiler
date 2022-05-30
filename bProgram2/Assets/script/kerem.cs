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
            baslik.text = " Armutun Faydalar� ";

            konu.text = "- Kilo kayb� sa�lar, zay�flat�r. Zengin bir lif kayna� olan armut, i�erdikleri ile uzun s�re tok kalman�z�; b�ylelikle kalori a���� olu�turarak zay�flaman�za olanak tan�r.\n\n"+
                "- Kanseri �nler. Anti kanserojen �zellikleri ile olas� kanser h�crelerinin olu�umunu engeller.\n\n"+
                "- Ba����kl��� g��lendirir. Yap�s�nda bulunan antioksidanlar sayesinde so�uk alg�nl���, grip ve nezle benzeri hastal�klara kar�� ba����kl��� g��l� tutar.\n\n" +
                "- Sindirim sistemini d�zenler.\n\n" +
                "- Kalp sa�l���na iyi gelir, kan ak���n� artt�r�r. Potasyum a��s�ndan zengin olmas�ndan dolay� kalp sa�l���na iyi gelir. �te yandan, v�cut genelinde kan ak���n� da artt�r�r.\n\n"+
                "- Y�ksek tansiyonu engeller.\n\n";


        }

        // L ile ba�layanlar
        #region L ile baslayanlar
        if (urun == "Lahana")
        {
            urunResmi.sprite = KeremResimler[1];
            baslik.text = " Lahanan�n Faydalar� ";

            konu.text = "- Lahana izotiyosiyanatlar denen fitokimyasallar deposudur. Bu bile�ikler antioksidand�r. Lahanada bulunan ��z�n�r lif ile birlikte kandaki k�t� kolesterol seviyesinin azalt�r.\n\n" +
                "- Lahanada bulunan potasyum �nemli bir mineral ve elektrolittir. Kalp h�z�n� ve kan bas�nc�n� kontrol alt�nda tutmaya yard�mc� olur. Potasyum, sodyumun v�cuttaki negatif etkilerine kar�� kan damar� duvarlar�n� rahatlat�r ve idrar yoluyla sodyumun salg�lanmas�na yard�mc� olur. Lahanada bulunan manganez de k�rm�z� kan h�cresi olu�umu i�in gereklidir.\n\n" +
                "- Lahana bir t�r karbonhidrat olan ba��rsak dostu ��z�nmez lifle doludur. ��z�nmez lif, ba��rsak hareketlerini te�vik ederek sindirim sistemini sa�l�kl� tutmaya yard�mc� olur, kab�zl��� �nler ve ba��rsaktaki yararl� bakterilerin artmas�na sebep olur.\n Bu bakteriler ba����kl�k sistemini korumak ve baz� vitaminleri (K2, B12 vitamini gibi) �retmek gibi �nemli i�levleri yerine getirirler. Yeterli lif t�ketimi, safra ve d��k� yoluyla toksinlerin at�lmas�n� kolayla�t�r�r. �drar s�kt�r�c� �zelli�i sayesinde de v�cuttan toksinlerin at�lmas�n� sa�lar. Lahana pi�ti�inde ortaya ��kan k�t� kokunun sebebi sindirim sisteminin d�zg�n �al��mas�n� sa�layan k�k�rtl� bile�iklerdir.\n\n" +
                "- Lahana g�z hastal�klar�n� engelleyen antioksidanlar i�erir. ��eri�indeki beta-karoten, A vitaminine d�n��erek g�z sa�l���na fayda sa�lar. A Vitamini g�zleri g��lendirerek gece g�rme fonksiyonlar�n� art�r�r ve g�zlerin ya�lanmas�n� engeller.\n\n";

        }

        if (urun == "Lavman")
        {

            baslik.text = " Lavman ";
            urunResmi.sprite = KeremResimler[2];

            konu.text = "- A��r� kab�zl�k, kar�n a�r�s� vs. gibi bir sebepten dolay� makattan kal�n ba��rsa�a veya idrar yapamayan kimse i�in kam��tan idrar torbas�na do�ru ila� g�nderme i�ine lavman denilmektedir.\n\n\n"+
                "Lavman S�ras�nda Kullan�lan Baz� �la�lar:\n\n"+
                "- G�lhatmi tohumu tozunun yumu�at�c� lavmanlara konulmas� gayet faydal�d�r.\n\n"+
                "- H�nnap; pi�irilerek, suda �s�t�larak, kaynat�larak ve lavman �eklinde de kullan�l�r.\n\n"+
                "- Ebe g�meci tohumunun tozu, lavman yapmak vs.de kullan�l�r.\n\n";
        }

        #endregion  

        // M ile ba�layanlar
        #region M ile baslayanlar

        if (urun == "Mandalina")
        {
            baslik.text = " Mandalina ";
            urunResmi.sprite = KeremResimler[3];

            konu.text = "- So�uk alg�nl���na iyi gelir. Turun�giller aras�nda yer alan mandalina so�uk alg�nl��� riskini azaltarak ki�ilerin hastalanmas�n� engeller. Mandalinan�n bunun yan�nda olduk�a fazla �zelli�i bulunmaktad�r. ��eri�inde bulunan C vitamini sayesinde so�uk alg�nl���na kar�� koruyucu �zellik bar�nd�r�r.\n\n" +
                "- Ba����kl��� g��lendirir. Ba����kl�k sistemi zay�flamas�na sebep olan bir�ok etken bulunmaktad�r. �zellikle stres ve yetersiz beslenme gibi etmenler ba����kl�k sisteminin zay�flamas�na ve ki�ilerin hastalanmas�na sebep olur. Mandalina C vitamini a��s�ndan olduk�a zengin bir meyve olarak ki�ilerin hastal�k riskini d���r�r.\n\n" +
                "- Kolestrol� d���r�r. Antioksidan a��s�ndan zengin olan mandalina t�ketilerek kolesterol� d���rd��� bilinmektedir.\n\n" +
                "- Tansiyonu d�zenler. Mandalinan�n i�erisinde bulunan y�ksek potasyum ve d���k sodyum i�eri�i tansiyonun dengelenmesini sa�lar.\n\n";

        }

        if (urun == "Mantar")
        {
            baslik.text = " Mantar�n Faydalar� ";
            urunResmi.sprite = KeremResimler[4];

            konu.text = "- Genel olarak, mantarlar kolesterol i�ermezler, fakat ayn� zamanda iyi bir kitin ve beta-glukan kayna��d�rlar, bu da kolesterol� d���ren liflerdir.\n\n" +
                "- Mantarlar, kalsiyumun emilimini sa�layarak kemiklere yard�mc� olan D vitamini kayna��d�r.\n\n"+
                "- Antioksidan bak�m�ndan zengin olan mantar v�cudun direncini art�rd���ndan hastal�lara yakalanma oran�n� azalt�r. Karaci�er, akci�er ve ba��rsaklardaki toksinleri temizleyerek v�cuttan atar.\n\n";
        }
        if (urun == "Marul")
        {
            baslik.text = " Marulun Faydalar� ";
            urunResmi.sprite = KeremResimler[5];

            konu.text = "- Marul, s�kl�kla kardiyovask�ler hastal�klara ve di�er tehlikeli durumlara yol a�an y�ksek kolesterol seviyelerini d���rmede faydal� olabilir. Y�ksek LDL kolesterol seviyeleri zararl�d�r, kalp krizine ve felce neden olabilir.\n\n" +
                "- E ve C vitamini bak�m�ndan zengin olan marul, cilt h�crelerini yeniler.\n\n"+
                "- Marul, g�rme sa�l���n� art�ran s�per bir antioksidan olan zeaksantin i�erir ve bunun ya�a ba�l� mak�ler dejenerasyonu �nledi�i bulunmu�tur.\n\n"+
                "- Maruldaki lif sindirimi art�r�r, kab�zl�k ve �i�kinlik gibi di�er sindirim hastal�klar�n� engeller. Ayr�ca mide a�r�s�n� hafifletebilir. Ayn� zamanda ba��rsak sa�l���n� da iyile�tirir.\n\n";
        }

        if(urun=="Meyan K�k�")
        {
            baslik.text = " Meyan K�k�n�n Faydalar� ";
            urunResmi.sprite = KeremResimler[6];

            konu.text = "- Meyan k�k�, B vitamini kompleksi, flavonoidler, fito�strojen, kolin, protein, potasyum, fosfor gibi pek �ok vitamin ve mineralle dolu zengin bir bitkidir.\n\n" +
                "- Meyan k�k�, i�erdi�i kumarin bile�eni ile v�cuttaki iltihapl� h�creleri temizlemeye yard�mc� oluyor. �zellikle k�� aylar�nda kuru �ks�r�k, balgam gibi sorunlara iyi geliyor.\n\n" +
                "- Meyan k�k�n�n �ok �e�itli kullan�m alan� bulunuyor. Bunlardan biri de �ay �eklinde t�ketilmesidir. Meyan k�k� �ay olarak t�ketildi�inde solunum ve sindirim sorunlar�n�n ��z�m�ne destek oluyor.\n\n" +
                "- Kab�zl��a iyi gelen meyan k�k�, ayn� zamanda kemik ve eklem a�r�lar�n� da dindiriyor.\n\n" +
                "- Meyan k�k�, a��z i�indeki yaralara da iyi geliyor. Baz� uzmanlar a��z yaralar� i�in meyan k�k�n�n kaynat�lmas�n� ve kaynat�lan bu su ile gargara yap�lmas�n� �neriyor.\n\n" +
                "- Meyan k�k� t�m bunlar�n yan� s�ra g�zellik i�in de kullan�lan bir bitki. Sa� ve cilt sa�l���na katk�da bulunuyor.\n\n" +
                "- Meyan k�k� nemlendirici �zelli�i ile sa� derisini nemli tutuyor. Kuru sa� derisi sorunu olanlar�n s�kl�kla kar��la�t��� kepek sorununa ve sa� derisinin pul pul d�k�lmesine kar�� da ektilidir.\n\n" +
                "- Meyan k�k�nden elde edilen �ay� birka� damla Hindistan cevizi ile kar��t�r�p sa� derisine uygularsan�z ve 1 saat bekletip y�karsan�z faydas�n� g�rebilirsiniz. Meyan k�k�n�n sa�lara bir faydas� da sa��n uzamas�n� sa�lamas�d�r.\n\n";

        }

        

        if (urun == "Masaj")
        {
            baslik.text = " Masaj�n V�cuda Faydalar� ";
            urunResmi.sprite = KeremResimler[8];

            konu.text = "\n- Masaj demek yenilenmektir. Masaj, v�cuttaki dokular� yeniler. G�n�m�zde bir�ok yerde bilin�siz �ekilde masaj yap�l�yor. Masaj� uzman mas�z veya mas�r fizyoterapistler uygulamal�.\n\n" +
                "- Masaj, kan dola��m�n� h�zland�r�r ve depresyonu yat��t�r�r. Ayr�ca masaj�n ba����kl�k sistemini g��lendirdi�ine ve a�r�lar�n azalmas�na yard�mc� olur. D�zenli masaj terapisi alan ki�iler stresten, depresyondan kurtulur.\n\n" +
                "- Yanl�� yap�lan masaj v�cudunuza zarar verebilir. Ancak masaj; do�ru ellerde, hijyenik ortamda, uzman mas�z veya mas�r fizyoterapistler taraf�ndan yap�l�rsa zarar vermez.\n\n";

        }

        if (urun == "Menek�e")
        {
            baslik.text = " Menek�enin Faydalar� ";
            urunResmi.sprite = KeremResimler[9];

            konu.text = "- �drar yollar� enfeksiyonlar�nda iyile�tirici etkisi vard�r.\n\n" +
                "- Egzama, akne ve �teki cilt sorunlar�nda iyile�tirici etkisi g�r�l�r.\n\n" +
                "- Ba� a�r�s�, sinirlilik hali ve uykusuzlu�a kar�� olumlu etkileri vard�r.\n\n" +
                "- G��s� yumu�at�r, balgam� s�kt�r�r.\n\n" +
                "- So�uk alg�nl���, anjin, bo�maca, �ks�r�k ve bron�it durumlar�nda iyile�tirici ve rahatlat�c�d�r.\n\n\n" +
                "Kullan�m �ekli : 1 tatl� ka���� yaprak, sap ve �i�ek kar���m�n�n �zerine 1 bardak kaynar su d�k�l�p 10-15 dakika s�reyle demlendirilir.";

        }

        if(urun=="Ye�il Mercimek")
        {
            baslik.text = " Ye�il Mercime�in Faydalar� ";
            urunResmi.sprite = KeremResimler[10];

            konu.text = "-Ye�il mercimek, �zellikle v�cudun kas yap�s�n�n d�zg�n �al��mas� i�in ihtiya� duydu�u t�m temel amino grup asitlerin takviyesini v�cuda yapabilmektedir.\n\n" +
                "- Ye�il mercimek, y�ksek d�zeyde ��z�n�r lif i�ermesi nedeniyle kandaki k�t� kolesterol� azaltmaya yard�mc� olabilmektedir. Kolesterol� seviyelerinin sa�l�kl� boyutlarda d���r�lmesi sayesinde arterleri temiz tutarak kalp hastal��� ve fel� riskini de azaltabilmektedir.\n\n" +
                "- Ye�il mercimek t�ketimi baz� kanser t�rleriyle m�cadele edebilmek i�in yard�mc� olabilmektedir. Mercimek, kanser sava���lar� olarak bilinen lektin bile�ikleri a��s�ndan zengindir. Lektinler, v�cuttaki kanserli h�crelerinin b�y�mesini kontrol alt�na alabilmektedir.\n\n" +
                "- Ye�il mercimek sahip oldu�u lif ve kompleks karbonhidratlar nedeniyle enerjiyi s�rekli art�rabilmektedir. Mercimek v�cuda oksijen ta��ma, enerji �retimi ve metabolizmay� h�zland�rma gibi fonksiyonlar i�in gerekli olan demir a��s�ndan olduk�a iyi bir kaynakt�r.\n\n" +
                "- Folat, do�um kusurlar�n�n �nlenmesi i�in gebelik �ncesi en az bir y�l s�reyle t�ketilmesi durumunda y�zde 50 veya daha fazla erken do�um �ans�n� azaltabilmektedir. Hastal�k Kontrol Merkezi do�urganl�k zaman�ndan en az y�l �nceden g�nl�k olarak 400 mikrogram folik asit t�ketmesini �nermektedir. Bir bardak ye�il mercimekte ise g�n boyunca ihtiya� duyulan folat miktar�n�n y�zde 90'� bulunmaktad�r.\n\n" +
                "- Mercimek sindirim ve sinir sistemlerini kuvvetlendirmeye katk�da bulunan B3 vitamini de d�hil olmak �zere pek �ok vitamini i�ermektedir. B3 vitamini, ayn� zamanda kolesterol kontrol�, Alzheimer hastal���, kataraktlar, osteoartrit ve diyabet gibi hastal�klar�n olu�ma riskini azaltmada �nemli bir rol oynamaktad�r.";
        }

        if(urun=="K�rm�z� Mercimek")
        {
            baslik.text = " K�rm�z� Mercime�in Faydalar� ";
            urunResmi.sprite = KeremResimler[11];

            konu.text = "- Cilde iyi gelir. ��erisindeki antioksidan bile�enler sayesinde ya�lanmay� engeller, ciltteki yara ve aknelere iyi gelir.\n\n " +
                "- Zengin lif i�eri�i sayesinde tok tutar, kilo kayb�na yard�mc� olur.\n\n" +
                "- Diyabet hastalar� i�in do�ru bir besindir. Lif i�eri�i sayesinde sindirimi kolayla�t�r�r, kan �ekerini d�zenler.\n\n" +
                "- Protein ve mineral bak�m�ndan zengindir.\n\n" +
                "- Kemik ve di� sa�l���na iyi gelir. Osteoporoz riskini azalt�r.\n\n\n" +
                " K�rm�z� Mercime�in Yan Etkileri \n\n"+ 
                "- K�rm�z� mercime�in fazla t�ketilmesi midedeki gaz oran�n�n artmas�na neden olur. Fazla t�ketim sonucu b�brek rahats�zl�klar�, potasyum zehirlenmesi gibi problemler olu�abilir. K�rm�z� mercime�i d�zenli t�ketmeye karar verdiyseniz mutlaka �ncelikle doktorunuza dan���n�z.\n\n";
        }

        if(urun=="Mersin Yapra��")
        {
            baslik.text = " Mersin Yapra��n�n Faydalar� ";
            urunResmi.sprite = KeremResimler[12];

            konu.text = "\n- Olduk�a ho� bir kokusu olan mersin yapra��n�n i�erisinde A vitamini, �eker ve tanen bulundurur.\n\n" +
                "- �drar yollar� enfeksiyonlar�n� gidermeye yard�mc� olur.\n\n" +
                "- Bron�it hastal���na olduk�a faydal�d�r.\n\n" +
                "- Akci�er iltihaplar�n�n tedavi i�in kullan�l�r.\n\n" +
                "- Egzama gibi cilt hastal�klar�n� giderir.\n\n" +
                "- �shali kesici �zelli�i vard�r.\n\n" +
                "- ��tahs�zl�k problemi ya�ayanlarda i�tah�n a��lmas�na yard�mc� olur.\n\n" +
                "- A vitamini i�ermesi nedeniyle g�rme yetene�ini art�r�r.\n\n" +
                "- Ba����kl�k sistemini g��lendirerek nezle grip gibi so�uk alg�nl��� hastal�klar�na iyi gelir.\n\n";

        }

        if(urun=="Mesane Hastal�klar�")
        {
            baslik.text = " Mesane Hastal�klar� ";
            urunResmi.sprite = KeremResimler[13];

            konu.text = 
                "\n S�ST�K (MESANE �LT�HABI)\n\n" +
                "- Mesanenin iltihab�na sistit denilir. Genellikle �e�itli bakterilerin neden oldu�u bir enfeksiyon �eklidir. Sistit idrar yollar�n�n en s�k rastlanan rahats�zl���d�r. Bu hastal�k b�y�klerde oldu�u gibi �ocuklarda da meydana gelebilir. Anatomik yatk�nl�k nedeniyle her kad�n hayat�nda en az bir kez idrar yollar� iltihab� ge�irir.\n\n\n" +
                " MESANE KANSER� - MESANE T�M�R�\n\n" +
                "- Mesaneyi olu�turan h�crelerin kontrols�z olarak �o�almas�na mesane kanseri denir. Mesane kanseri idrar kesesinin i�ini d��eyen h�cre tabakas�ndan kaynak al�r. E�er bu h�cre �o�almas� yaln�zca mesanenin y�zeyel katman� ile s�n�rl�ysa buna y�zeyel mesane kanseri denir. E�er h�cre �o�almas� derinle�ip kas ve ya� tabakas�na da ge�erse buna derin (invaziv) mesane kanseri denir.\n\n\n" +
                " �DRARINI TUTAMAMAK\n\n" +
                "- Mesanedeki idrar�n irade d��� olarak bo�almas�.\n\n"+
                " Faydal� Baz� Maddeler\n\n- �da�ac� tozu, idrar�n� tutamayan kimseler i�in faydal�d�r.\n\n" +
                "- Acur, mesane a�r�lar�na kar�� faydal�d�r. Tohumu ise idrar� s�kt�r�r.\n\n\n" +
                " �DRAR YAPMA ZORLU�U\n\n Sebepleri\n\n" +
                "- Mesanenin zay�f olmas� ve kuvvetli bas�n� yapamamas�.\n\n Tedavi:\n\n- A��z yoluyla idrar s�kt�r�c� ila�lar�n al�nmas�.\n\n\n" +
                " �DRARINI YAPAMAMAK\n\n Sebepleri\n\n" +
                "- �drar yollar�nda ta� meydana gelmesi, et bitmesi veya kan p�ht�s� meydana gelmesi gibi �eylerdir.\n\n" +
                " Faydal� Baz� Maddeler\n\n" +
                "- Bal, b�brek ve mesane t�kan�kl�klar�n� a�ar.\n\n" +
                "- �eker kam���,idrar� �o�alt�r. Mesaneyi ve nefes borusunu temizler.\n\n" +
                "- Kavun ve karpuz, b�brek ve mesane ta�lar�n� eritip s�kt�r�r.\n\n"
                ;
        }

        if (urun == "Mevsimler")
        {
            baslik.text = " Mevsimler ";
            urunResmi.sprite = KeremResimler[14];

            konu.text = "\n- Sa�l�k i�in en faydal� mevsim bahar mevsimidir. Zira bu mevsimde hastal�k ve �l�m azal�r.\n\n" +
                "- Sonbaharda ise hastal�klar ve �l�mler �o�al�r.\n\n" +
                "- Bahar mevsimini kan ald�rmak ve sebze yiyerek ge�irmelidir.\n\n" +
                "- Yaz mevsimini s�ca��n hararetini giderici so�uk yiyecek ve i�eceklerle, kan ald�rmaktan sak�narak ve �l�k su ile �ok�a du� yaparak ge�irmelidir.\n\n" +
                "- K���n bol bol et t�ketilmeli, kan ald�rmaktan sak�nmal� ve �ok�a hareket edilmelidir.\n\n";
        }

        if(urun=="Meyve Suyu")
        {
            baslik.text = " Meyve Suyunun Faydalar� ";
            urunResmi.sprite = KeremResimler[15];

            konu.text = "\n- Hastal�klardan korunman�n ve sa�l�kl� bir ya�am i�in g��l� bir ba����kl�k sistemi gerekti�ini belirten uzmanlar, g��l� bir ba����kl�k sistemi i�in de bol bol vitamin i�eren, antioksidan ve mineral a��s�ndan g��l� meyve sular�n�n t�ketilmesini �neriyor.\n\n\n" +
                " PORTAKAL SUYU\n\n - Y�ksek miktarda C vitamini i�eren portakal suyu, ba����kl�k sisteminizi destekleyerek enfeksiyonlara kar�� koruyucu etkide bulunur. Bitkisel kaynakl� besinlerdeki demirin v�cudunuzda emilmesine ve v�cudunuzdaki yaralanma ve kesilmelerin iyile�mesine yard�m eder.\n\n\n" +
                " ELMA SUYU\n\n - G��l� bir antioksidan kayna��. Yap�lan �al��malar elma t�ketiminin h�cresel hasar� �nleyici bir etkisi oldu�u; baz� kanser t�rleri, kardiyovask�ler hastal�klar, ast�m, tip 2 diyabet, obezite gibi hastal�k riskini azalt�c� potansiyel etkide bulundu�unu g�sterir.\n\n\n" +
                " V��NE SUYU\n\n - Stresin zararl� etkilerini azalt�r. Y�ksek oranda polifenolik bile�en i�erdi�inden kanser ve kalp hastal�klar� gibi hastal�k risklerinin azalt�lmas�nda potansiyel bir etkiye sahip.\n\n\n" +
                " KAYISI SUYU\n\n - Bir bardak kay�s� suyu,g�nl�k A vitamini gereksiniminin 4-8 ya� grubu i�in %48�ini, 9-13 ya� grubu i�in %32�sini, 14 ya� ve sonras� erkekler i�in %21�ini, 14 ya� ve sonras� kad�nlar i�in ise %27�sini kar��lar.\n\n\n" +
                " �Z�M SUYU\n\n - Potasyum, vitamin C, folat, fenolik ve flavonoid bile�enlerden zengin. H�crelere zarar veren bile�enlerin d�zeyini azalt�r. Kalp sa�l���n� ve baz� kanser t�rlerine kar�� koruyucu ve riski azalt�c� potansiyel bir etkisi oldu�u belirtilir.\n\n\n" +
                " NAR SUYU\n\n - Kalsiyum, potasyum ve i�erdi�i di�er bile�enlere ba�l� olarak �ok g��l� bir antioksidan. Buna ba�l� olarak k�t� kolesterol d�zeyini d���rebilir, iyi kolesterol d�zeyini y�kseltebilir ve koroner kalp hastal�klar� riskini azalt�r. Kan bas�nc�n�n d���r�lmesinde etkili. Karaci�ere koruyucu etkisi vard�r.\n\n" ;
        }

        if(urun== "Mide Rahats�zl���")
        {
            baslik.text = " Mide Rahats�zl���na �yi Gelecek �eyler ";
            urunResmi.sprite = KeremResimler[16];

            konu.text = "\n NANE\n - Nane mide rahats�zl�klar� i�in en �ok kullan�lan do�al ��z�mlerden biri olsa gerek. Ayn� zamanda haz�ms�zl��a ve bulant�ya da iyi gelen nanenin spazm giderici �zellikleri sizi ve sindirim sisteminizi sakinle�tiriyor.\n Bir bardak nane �ay� en iyi ��z�mlerden biri ama isterseniz naneli �eker ve hatta nane �z� ya��n� koklamak bile mide rahats�zl���n�za iyi gelebilir.\n\n " +
                " BEYAZ P�R�N�\n - Midenizin rahats�zl��� art�k dayan�lmaz bir dereceye geldiyse, hi�bir baharat ve ya� kat�lmam�� ve sadece ha�lanm�� beyaz pirin� sindirim sisteminizde dola�an o ekstra s�v�y� �ekip, sisteminizi �oka sokmadan ekstra lif de sa�layacakt�r.\n\n" +
                " ELMA S�RKES�\n - Mide kramplar�na ve mide ek�imesine iyi gelen elma sirkesini a� karna almamaya ve biraz su ile kar��t�r�p kullanmaya �zen g�sterin.\n\n" +
                " REZENE\n - �in�de hala mide rahats�zl�klar�na kar�� ila�lar yerine verilen rezeneyi, bir �ay ka���� kadar tohumunu ezip yiyebilir, ya da rezene �ay� ile beraber t�ketebilirsiniz.\n\n" +
                " MUZ\n - �zellikle ye�ili daha gitmemi� muzlar, olduk�a rahat sindirebildi�inden ve i�erdi�i pektin adl� do�al maddeden dolay� �zellikle bulant� durumlar�nda sindirim siteminizi yoluna sokmakta bire birdir.\n\n" +
                " ZENCEF�L\n - Mide rahats�zl�klar�na kar�� �o�u ila�tan daha etkili olan zencefili, zencefil �ay� ya da �ekersiz zencefilli �ekerlerden birini t�keterek kullanabilirsiniz.\n\n" +
                " PAPATYA\n - Mide kramp� ya da haz�ms�zl�k gibi bir sorununuz varsa, papatya �ay�n�n iltihaplanmaya kar�� etkisi mide zar�n�z� rahatlat�p, sindirim sisteminizin etraf�ndaki kaslar� gev�etecektir.\n\n" +
                " �EMEN\n - �emen, mide ek�imesine ve kab�zl��a birebir. Bol lif kayna�� oldu�undan sindirim sisteminize yard�mc� olan �emeni, tohumlar�n� hafif bir yeme�e ekleyerek ya da bulmas� biraz zor olsa da �ay�n� i�erek kullanabilirsiniz.\n\n";
        }

        if (urun == "Misk Otu")
        {
            baslik.text = " Misk Otunun Faydalar� ";
            urunResmi.sprite = KeremResimler[17];

            konu.text = "- ��tah art�r�c� etkisinin yan� s�ra hazm� kolayla�t�r�r.\n\n" +
                "- ��erdi�i vitaminler sayesinde ba����kl�k sisteminin desteklenmesine yard�mc� olur.\n\n" +
                "- �drar sorunlar� ya�ayanlar i�in idrar s�kt�r�c� �zelli�i ile vazge�ilmezdir.\n\n" +
                "- Kad�nlarda adet sanc�lar�n� hafifleterek d�zene sokar.\n\n" +
                "- Misk otu �ay�n�n balgam s�kt�r�c� etkisi vard�r.\n\n" +
                "- Misk otu �ay� cilt �zerine uyguland���nda egzama gibi cilt sorunlar�na iyi gelir.\n\n" +
                "- Sedatif etkisi sayesinde do�al sakinle�tirici, yat��t�r�c�d�r.\n\n" +
                "- Sindirim kanal�ndaki s�v�lar� ve safra salg�s�n� artt�rmada yard�mc� olur.\n\n" +
                "- Sinirsel zay�fl�k, nevroz, depresyon, gerginlik, uykusuzluk, kayg� hali gibi psikolojik rahats�zl�klar�n giderilmesinde yard�mc� olur.\n\n";
        }

        if (urun == "Misvak")
        {
            baslik.text = " Misvak�n Faydalar� ";
            urunResmi.sprite = KeremResimler[18];

            konu.text = "\n- Di� etlerini korur. Di� eti kanamalar�n� �nler. ��erdi�i minerallerle ayn� zamanda antioksidan(kanser �nleyici) �zelli�inden , di� eti ve di�lerin birle�iminde mikrop bar�nmas�n� engeller.\n\n" +
                "- Di� macunlar�nda k�p�rmeyi sa�layan teksapon maddesi i�ermez. Teksapon, kan h�crelerinde toksik etkiye, di� etlerinin �i�mesine, di� eti hastal�klar�na, di�lerin asitlere kar�� direncini d���rerek ��r�meye ve alerjik tepkimelere yol a�ar.\n\n" +
                "- Di� sa�l���n� temin eder. Sert k�llar� sayesinde di� aras�na girerek, di� minelerine zarar vermeden plak ve tartar olu�umunu engeller. Ayr�ca d�zenli kullan�mda sararmay� ortadan kald�r�r.\n\n" +
                "- A��z kokusunu yok eder. Yatmadan �nce di�ler f�r�alansa dahi mideden gelen gazlar k�t� kokuya neden olabilir. Misvaktaki do�al aroma, bu k�t� kokular� giderir. Mide gaz�n� gidermeye destek sunar.\n\n" +
                "- Ba� a�r�s�na iyi gelir. Yap�lan ara�t�rmalarda , misvak�n i�erdi�i maddeler ve do�al aromas�n�n d�zenli kullan�mda ba� a�r�lar�na da iyi geldi�i saptanm��t�r.\n\n"; 
                
        }

        if (urun == "M�shil")
        {
            baslik.text = " M�shil Etkisi Yapan Bitkiler ve Besinler ";
            urunResmi.sprite = KeremResimler[19];

            konu.text = "\n ELMA �AYI\n - Kab�zl�k �ekilen g�nlerde m�shil ilac� olarak elma �ay� t�ketilmesi �nerilir. Elma �ay� ba��rsaklar� k�sa s�rede uyar�r.\n\n\n" +
                " REZENE\n - Midede olu�an gaz� ve �i�li�i gideren rezene �ay�, m�shil g�revini ta��yan �aylardan biridir. K�sa zamanda ba��rsaklar�n temizlenmesine yard�m eder. Rezeneyi �l��l� ve d�zenli t�ketilmesi �nerilir.\n\n\n" +
                " YE��L �AY\n - Metabolizma dostu olan ye�il �ay, m�shil g�revini ta��maktad�r. G�n i�inde 3 fincan t�keterek ba��rsaklar�n aktif kalmas�na yard�m edebilirsiniz.\n\n\n" +
                " ZENCEF�L �AYI\n - Zencefil �ay�, ba��rsak durgunlu�unu �nleyen ve sindirim sistemine destek olan bir �ayd�r. Zencefil �ay�na 1 dilim limon ekleyerek m�shil �zelli�ini ikiye katlayabilirsiniz.\n\n\n" +
                " MEL�SA\n - Melisa �ay� vitamin de�eri y�ksek olan bitki �aylar�ndan biridir. M�shil etkili do�al �ay arayanlara tavsiye edilir.\n\n\n " +
                " EK�NEZYA\n - Ekinezya �ay�n� g�n i�inde t�keterek ba��rsaklar�n rahatlamas�na yard�m edebilirsiniz. Kab�zl�k ve �dem gibi sorunlar i�in �nerilmektedir.\n\n\n" +
                "---------------------------------------------\n\n\n" +
                " KARADUT\n - Antioksidan etkili karadut, m�shil g�revi �stlenen meyvelerden biridir.\n\n\n" +
                " CH�A TOHUMU\n - Diyet d�neminde chia tohumu t�keterek ba��rsaklar�n aktifle�mesine yard�m edersiniz. Chia tohumu, lifli yap�s� sayesinde m�shil etkisi olu�turacakt�r.\n\n\n" +
                " ��LEK\n - �ile�in %90�� su i�ermektedir. Bu meyveyi t�keterek m�shil etkisi olu�turabilirsiniz.\n\n\n" +
                " BEZELYE\n - Diyet liflerini i�eren bezelye, metabolizmay� h�zland�rmaktad�r. M�shil alman�z gereken durumlarda bezelye salatas� ya da bezelye yeme�i t�keterek do�al m�shil alabilirsiniz.\n\n\n" +
                " KAYISI\n - Do�al m�shil denildi�inde ak�llara hemen kay�s� gelir. G�n kurusu kay�s� t�keterek kab�zl�k ve �i�lik gibi durumlar�n �n�ne ge�ebilirsiniz. Kay�s� diyet liflerini yap�s�nda bar�nd�ran, metabolizmay� h�zland�ran bir meyvedir. Kuru ve ya� halinde tercih edebilirsiniz.\n\n\n" +
                " K�V�\n - Kivi, do�al m�shil �zelli�i olan bir meyvedir. T�ketti�iniz anda ba��rsaklar� uyar�r.\n\n\n" +
                " ZEYT�NYA�I\n - G�n i�inde t�ketilen besinlere zeytinya�� eklemeniz �nerilir. Zeytinya�� sayesinde kab�zl�k gibi sorunlar� �nleyebilirsiniz.\n\n\n " +
                " ISPANAK\n - Ispanak t�keterek ba��rsak sorunlar�n� tarihe g�mebilirsiniz. ��nk� �spanak ba��rsaklar�n daha sa�l�kl� �ekilde �al��mas�na yard�m eden sebzelerden biridir. Ispanakl� k�r, �spanak salatas� ve yeme�i ba��rsaklar�n aktifle�mesine destek olacakt�r.\n\n\n";
        }

        #endregion

        // N ile ba�layanlar
        #region N ile baslayanlar

        if (urun == "Nane")
        {
            baslik.text = " Taze Nanenin Faydalar� ";
            urunResmi.sprite = KeremResimler[7];

            konu.text = "- Antiseptik, antiviral (vir�s kar��t�) ve antibakteriyel (bakteri kar��t�) �zelliklere sahiptir.\n\n" +
                "- A��zda zararl� bakteri �remesini �nleyerek, dil ve di�leri temizleyerek, a��z sa�l���n� iyile�tirir.\n\n" +
                "- H�zl� ve etkili bir bulant� kesicidir.\n\n" +
                "- Akne semptomlar�n� rahatlat�r.\n\n" +
                "- Burun, bo�az ve akci�er t�kan�kl�klar�n� temizler.\n\n" +
                "- Do�al bir uyar�c�d�r zihinsel sa�l��� destekler, yorgunluk, anksiyete ve depresyonu rahatlat�r.\n\n" +
                "- Sinir ve kas a�r�lar�n� azaltmaya yard�mc�d�r.\n\n" +
                "- Ba� a�r�s� ve migreni azaltabilir.\n\n" +
                "- Sindirim sistemini (mide ek�imesi, ishal, haz�ms�zl�k, a��r� gaz) d�zenler.\n\n";

        }

        if (urun == "Nas�r")
        {
            baslik.text = " Nas�r Tedavisi ";
            urunResmi.sprite = KeremResimler[20];

            konu.text = " \n\n PONZA TA�I KULLANIMI\n - En basit ve en etkili y�ntemlerden biri olan ponza ta�� sert girintili ��k�nt�l� yap�ya sahip oluklu dikd�rtgen bir ta�t�r. �zellikle banyoda ya da banyo sonras�nda kullan�lmas� tavsiye edilir. Banyodan yumu�ayan sert nas�r kolayca ponza ta�� ile t�rp�lenebilir. Nas�r�n verdi�i rahats�zl�k hissi ve ac� �l� derinin at�lmas� ile ortadan kalkar. D�zenli ponza kullan�m� ile nas�rlar b�y�k �l��de tedavi edilir.\n\n\n" +
                " NASIR BANTLARI\n - Eczaneden sat�n alabilece�iniz nas�r bantlar�, nas�r tedavisinde etkin y�ntemlerden biridir. Salisilik asit veya trikloroasetik asit i�eren bu �r�nler �l� deri �zerinde kimyasala bir par�alanma sa�layarak, nas�r�n yok olmas�na yard�mc� olur. Uygulama s�ras�nda veya sonras�nda yanl�� kullan�ma ba�l� meydana gelebilecek alerji, k�zar�kl�k gibi bir belirti ile kar��la�t���n�zda �r�n� kullanmay� b�rakmal� ve hemen uzman bir hekimden yard�m alman�z gerekti�ini unutmay�n�z.\n\n\n" +
                " BEYAZ S�RKE ve L�MON\n - Nas�r kalemleri veya nas�r bantlar�nda oldu�u gibi beyaz sirke ve limon bol miktarda asit i�erir. Do�al besinlerden elde edilebilen bu asitler nas�r�n kimyasal reaksiyonla par�alanmas�n� sa�lar. Limon veya beyaz sirke ile nas�rl� b�lge iyice ovulur. Nas�rl� b�lge bandajl� olarak ertesi sabaha kadar bekletilir. Bandaj�n �ok s�k� olmamas�na ve aya��n hava almas�na �zen g�sterilmesi gerekir. Bandaj a��ld�ktan sonra �l� derilerin pul pul d�k�ld���n� g�zlemleyebilirsiniz. Nas�r tamamen yok olana kadar beyaz sirke ve limon uygulayabilirsiniz. Her uygulama sonras�nda cildi beslemek ve nemlendirmek i�in zeytinya��, hindistan cevizi ya�� veya badem ya�� ile masaj yap�lmas� gerekti�ini unutmay�n�z.\n\n\n";
        }

        if(urun=="Nefes Darl���")
        {
            baslik.text = " Nefes Darl���na Ne iyi Gelir ";
            urunResmi.sprite = KeremResimler[21];

            konu.text = "\n- Kendinizi rahat bir �ekilde konumland�rmay�, sakin kalmay� ve b�z�lm�� dudaktan nefes alma tekni�ini kullanmay� ��renmek, nefesinizin kontrol�n� yeniden kazanman�za ve akut nefes darl��� ata�� s�ras�nda endi�enizi azaltman�za yard�mc� olabilir. �u ad�mlar� takip edin:\n\n" +
                "- Durun ve rahat bir pozisyon al�n.\n\n" +
                "- M�mk�n oldu�unca sakin olun; omuzlar�n�z� gev�etin.\n\n" +
                "- Nefes al�n. Nefes almak i�in dudaklar�n�z� s�k��t�r�n.\n\n" +
                "- Nefes almaktan daha fazla zaman ay�rarak nefesinizi yava�lat�n. Ci�erlerinizi bo�almaya zorlamay�n.\n\n" +
                "- Dudaklar�n�z� b�zerken yava��a nefes vermeye devam edin. Hen�z yapmad�ysan�z burnunuzdan nefes almaya ba�lay�n.\n\n" +
                "- Dudak b�zme tekni�ine en az 5 dakika veya sakin nefes almaya d�nene kadar devam edin.\n\n";

        }

        if(urun=="Nergis �i�e�i")
        {
            baslik.text = " Nergis �i�e�inin Faydalar� ";
            urunResmi.sprite = KeremResimler[22];

            konu.text = "\n - Nergis �i�e�inin g�zel kokusu, geniz t�kan�kl���n�n a��lmas�na yard�mc� olmaktad�r.\n\n" +
                "- Nergis �i�e�inin temizleyici �zelli�i bulunur.\n\n" +
                "-  Nergis �i�e�inin kaynat�lmas� ile i�ilmesi ya da ha�lanmas� ile t�ketilmesi, kusmay� �nler ve midede bulunan nemi �eker.\n\n" +
                "- Abra� ve c�zzam rahats�zl�klar�na iyi gelir.\n\n" +
                "- Nergis �i�e�inin ���t�len k�k�, sinirlere ula�an yaralar�n iyile�tirilmesinde �nemli fayda sa�lar.\n\n" +
                "- Safra ve rutubet kaynakl� olan ba� a�r�lar�n� ortadan kald�r�r.\n\n" +
                "- So�uk kaynakl� olu�an nezleye kar�� yararl�d�r.\n\n";
        }

        if (urun == "Nezle")
        {
            baslik.text = " Nezleye Ne �yi Gelir ";
            urunResmi.sprite = KeremResimler[23];

            konu.text = "\n\n M�RVER\n - Ba����kl�k sistemini g��lendirir. Gribe, �ks�r��e ve nezleye faydal�d�r. So�uk alg�nl���n� giderip, g��s� yumu�at�r. Nane ile birlikte demlenerek t�ketilmesi �nerilir.\n\n\n " +
                " ZENCEF�L-L�MON\n - Limon ile birlikte t�ketildi�inde so�uk alg�nl���na, ya�l� bir yemek sonras� ise sindirime yard�mc� olur. Bo�az�n�zda veya v�cudunuzda k�r�kl�k, halsizlik, a�r� hissetti�inizde taze zencefil rendesi, limon suyu ve bal ile haz�rlayaca��n�z kar���m iyi gelecektir.\n\n\n" +
                " KU�BURNU\n - C vitamini zengini ku�burnu v�cuda diren� verir. Tam kurutulmu� meyveleri par�alay�p 10 dakika kaynatarak haz�rlanacak �ay hemen t�ketildi�inde i�eri�indeki C vitamininden y�ksek dozda faydalan�l�r.\n\n\n" +
                " IHLAMUR\n - Ihlamur �i�eklerinin iltihap giderici ve a�r� giderici �zelli�i bulunmaktad�r. So�uk alg�nl��� �ikayetlerinin ve bo�azdaki tahri�in azalmas�na, tedavinin h�zlanmas�na yard�mc� olur.\n\n\n" +
                " EK�NEZYA\n - Nezle ve so�uk alg�nl���ndan korunma ve tedaviye yard�mc�d�r.\n\n\n" +
                " KAKULE\n - So�uk alg�nl���, bron�it, �ks�r�k, ate� gibi �ikayetlerin hafifletilmesinde, a��z ve bo�az iltihaplar�n�n giderilmesinde etkilidir. Demleme usul�, �e�itli baharatlarla kar��t�r�larak i�ilmesi �nerilir.\n\n\n" +
                " KARAB�BER MEYVES�\n - Yemeklere lezzet vermesinin d���nda, a�r� kesici ve ate� d���r�c� etkisi bulunmaktad�r. Toz haline getirilmi� karabiber meyvesi ile haz�rlanan �ay gargara �eklinde uyguland���nda bo�az enfeksiyonlar�na ve a�r�n�n azalmas�na yard�mc� olacakt�r.\n\n\n";
        }

        if(urun=="Nil�fer �i�e�i")
        {
            baslik.text = " Nil�fer �i�e�inin Faydalar� ";
            urunResmi.sprite = KeremResimler[24];

            konu.text = "\n - Nil�fer �i�e�i s�k�larak elde edilen ya�� kozmetik fabrikalar�nda krem yap�m�nda kullan�l�r. Bu ya� v�cudun esnekle�mi� yap�lar�n� sertle�tirerek k�r��mas�n� �nler. Ay�rca h�creleri yenileyerek daha parlak ve diri olmas�n� sa�lar.\n\n" +
                "- Nil�fer �ay� d�zenli t�ketildi�inde ba��rsak floras�n� dengeler. Sindirim hastal�klar�n�n �n�ne ge�er. G��l� bir iltihap s�kt�r�c� olan nil�fer �i�e�i, kan damarlar�n� temizleyerek t�kan�kl��� engeller. B�ylece kalp hastal�klar�n�n ya�anmamas�n� sa�lar. Bunun yan� s�ra toksinlerden ar�nd�rd��� i�in ba����kl�k sistemini yeniler. H�crelerin mutasyonunun �n�n ge�er. Hastal�klarda y�kselen ate�lenmeyi engeller.\n\n" +
                "- B vitamini kompleksi bak�m�ndan zengin olan nil�fer �i�e�i, g��l� bir idrar s�kt�r�c� �zelli�ine sahiptir. Kas ve kemiklerde birikmeye meyilli olan asidi bu yolla atar. B�ylece v�cut fonksiyonlar�n� ve hareketlerini g��lendirir.\n\n" +
                "- Nil�fer �ay� en �ok ruhsal problemlere fayda sa�lar. Stres ve uykusuzlu�a ba�l� geli�en, sinirsel yorgunlu�un ya�anmas�n�n �n�ne ge�er. ��nk� sinir h�crelerini yat��t�r�r. D�zensiz olan kan ak���n� da d�zenleyerek panik atak ve kalp ritim bozukluklar�na da iyi gelir.\n\n";
        }

        if (urun == "Nohut")
        {
            baslik.text = " Nohutun Faydalar� ";
            urunResmi.sprite = KeremResimler[25];

            konu.text = "- Nohutta sindirimi optimize ederek kan �ekeri seviyelerini d�zenlemeye yard�mc� olan y�ksek miktarda ��z�n�r lif vard�r. Normal seviyelerde ins�lin ve kan �ekeri sa�layarak diyabet geli�imini �nleyebilir ve insanlar�n durumu y�netmesine yard�mc� olabilir.\n\n" +
                "- Nohutun, demir, fosfor, magnezyum, bak�r ve �inko y�n�nden zengin olmas� kemik sa�l��� i�in son derece �nemlidir. Bu minerallerin �o�u kemik mineral yo�unlu�unu iyile�tirmek ve osteoporoz gibi ya�a ba�l� ko�ullar� �nlemek i�in gereklidir.\n\n" +
                "- Mineral selenyum meyve ve sebzelerin �o�unda bulunmamakla birlikte, nohutlarda bulunur. Karaci�er enzimlerinin d�zg�n �al��mas�na ve v�cutta kansere neden olan baz� bile�iklerin detoksifikasyonuna yard�mc� olur. Ek olarak, selenyum iltihab� �nler ve t�m�r b�y�me oranlar�n� azalt�r. Nohut ayr�ca DNA sentezi ve onar�m�nda rol oynayan folat i�erir, b�ylece DNA�da kanser h�crelerinin olu�umunun �nlenmesine yard�mc� olur. Nohutta bulunan fitokimyasallar olan saponinler, kanser h�crelerinin v�cutta �o�alarak yay�lmas�n� �nler. Nohut ve di�er baklagillerden, tam tah�llardan, meyvelerden ve sebzelerden y�ksek lif al�m�, kolorektal kanser riskini azalt�r.\n\n" +
                "- Folat, �zellikle kad�nlar i�in bir�ok farkl� sebepten dolay� �nemli bir B vitaminidir. D���k folat seviyeleri, n�ral t�p defektleri ve �ocuklar�n do�umundaki di�er komplikasyonlarla yak�ndan ili�kilidir. Hamilelikte beslenmeye folat bak�m�ndan zengin nohutun eklenmesi, bebe�in sa�l�kl� do�umunu sa�lamak i�in lezzetli bir yoldur.\n\n" +
                "- Y�ksek protein ve demir i�eri�i nedeniyle nohut sa� d�k�lmesi ya�ayanlar i�in harika bir do�al takviye g�revi g�rebilir. Nohut ayr�ca A, B ve E vitaminleri kayna�� olup, hepsi kafa derisi sa�l���n� iyile�tiren ve kan dola��m�n� art�ran omega 6 ya� asitleri a��s�ndan olduk�a zengindir.\n\n" +
                "- Nohuttaki y�ksek lif, potasyum, C vitamini ve B-6 vitamini i�eri�i kalp sa�l���n� destekler. Nohut, kandaki toplam kolesterol miktar�n� d���rmeye yard�mc� olan �nemli miktarlarda lif i�erir ve b�ylece kalp hastal��� riskini azalt�r.\n\n" +
                "- Nohut, daha iyi bir g�r��e yard�mc� olan A, C ve E vitaminleri gibi iyi bir �inko ve vitamin kayna��d�r. D�zenli olarak nohut al�m� g�rme yetene�inizi art�rabilir.\n\n" +
                "- Nohuttaki manganezin varl��� cilt sa�l���n� artt�r�r, k�r���kl�klar�n ve ince �izgilerin olu�umunu �nler. Temel olarak, manganez, serbest radikallerin zararl� etkilerini tersine �evirerek k�r���kl�klar� �nler.\n\n";
        }

        if (urun == "Nektarin")
        {
            baslik.text = " Nektarinin Faydalar� ";
            urunResmi.sprite = KeremResimler[26];

            konu.text = "- Nektarin, i�erisinde bol miktarda polifenol ve C vitamini i�ermektedir. Bu y�zden antioksidan �zelli�e sahip olup, v�cuttaki zararl� at�klar� uzakla�t�r�r. Ayr�ca hastal�klara kar�� da v�cudumuzu korur.\n\n" +
                "- Obezite gibi hastal�klar�n tedavisinde nektarin kullan�lmaktad�r. Hem kalorisi az oldu�u i�in hem de kardiyak bozukluklar� engellemesiyle, bu tarz hastal�klarda yard�mc� g�da olarak kullan�labilir.\n\n" +
                "- Nektarin bol vitaminin yan�nda lutein maddesini i�erdi�i i�in g�z sa�l�n� da b�y�k �l��de korumaktad�r. Ayr�ca bu madde katarakt riskini de en aza indirmektedir.\n\n" +
                "- Bol miktarda potasyum minerali i�erdi�i i�in potasyum eksikli�i �eken hastalarda ek g�da olarak kullan�labilir.\n\n" +
                "- Nektarin �e�itli asit �e�itlerini de bar�nd�rd��� i�in v�cutta olu�an t�m�r gibi maddelerin b�y�mesini engeller.\n\n" +
                "- Son yap�lan ara�t�rmalarda nektarinin kanseri �nledi�i ke�fedilmi�tir. Genel olarak kolon kanserinin tedavisinde t�ketilebilir.\n\n"
                ;
        }
        #endregion

        // O ile ba�layanlar
        #region O ile baslayanlar
        if (urun=="Organ Ba����")
        {
            baslik.text = " Organ Ba����n�n �nemi ";
            urunResmi.sprite = KeremResimler[27];

            konu.text = "\n- Toplum �zerinde organ ba���� hakk�ndaki en b�y�k korkulardan biri, ki�inin organ ba�����s� oldu�unun ��renilerek k�t� niyetli ki�iler taraf�ndan bu bilginin kullan�lmas�d�r. Bu t�r ger�ek olmayan s�ylentiler y�z�nden pek �ok ki�i organ ba����ndan vazge�mektedir. Ki�inin organ ba�����s� olup olmad���n� yaln�zca Sa�l�k Bakanl��� yetkilileri bilir. Dolay�s�yla herhangi bir ki�inin, organ ba�����s� olup olmad���n�n ���nc� �ah�slar taraf�ndan ��renilmesi m�mk�n de�ildir.\n\n" +
                "- Organ nakli canl�dan canl�ya ya da kadavradan yap�labilir. Canl�dan canl�ya organ nakli genellikle b�brek, karaci�er ve akci�er gibi organlar i�in uygulan�r. �o�unlukla aile i�indeki ki�iler aras�nda yap�lan bu nakil tipi, hastan�n hayati tehlikesinin oldu�u ve ilgili organ�n nakil yolu ile yenilenmesi sayesinde iyile�me olas�l���n�n belirlenmesinden sonra yap�l�r. Bu durumda hastaya g�n�ll� olarak organ ba���layacak olan ki�i, sa�l�k taramalar�ndan ge�irilir. Kan ve doku uyumu kontrol edilir. Ba�����, tek b�brek ile hayat�n� devam ettirebilece�inden b�bre�inin biri hastaya nakledilir. Karaci�er ve akci�er gibi organlar ise ba�����dan tamamen al�nmaz. Bunun yerine ilgili organ�n bir b�l�m� al�narak hastaya nakledilir.\n\n" +
                "- Organ ba����n�n �nemi bu noktada ortaya ��kar. Canl�dan canl�ya yap�lan nakillerde, az da olsa ba����� i�in risk bulunur. Bu durum organ ba����n�n ne denli �nemli oldu�unun da bir kan�t�d�r. Toplum baz�nda yeterince organ ba���� olmas� durumunda canl�dan canl�ya doku ve organ nakli oran� olduk�a alt seviyelere iner. Don�r�n hayattayken ba����� olmas� durumunda ilgili doku ve organlar, organ nakli bekleyen hastalar i�in b�y�k bir umut olur. �zellikle kalp ve pankreas gibi hayati organlar�n nakli canl�dan canl�ya nakli m�mk�n de�ildir. Bu organlara ihtiyac� olan ki�ilerin hayata tutunmas�n�n tek yolu ba�����lard�r. Ki�inin beyin �l�m�n�n ger�ekle�memesi durumunda organlar�n�n al�nmas� ise m�mk�n de�ildir.";
        }

        if(urun=="Oru� Tutmak")
        {
            baslik.text = " Oru� Tutman�n Faydalar� ";
            urunResmi.sprite = KeremResimler[28];

            konu.text = "\n H�CRELER� ONARIR\n\n - Oru� tuttu�unuzda, v�cuttaki h�creler otofaji ad� verilen h�cresel bir i�lemi ba�lat�r. Bu i�lem, h�crelerin par�alanmas� ve zaman i�erisinde h�crelerde olu�an �l� ya da i�levsiz proteinlerin at�lmas�n� sa�lar. Otofaji oran�n�n artmas� kanser ve alzheimer gibi hastal�klara yakalanma riskini azalt�r.\n\n\n" +
                " KALP SA�LI�INI KORUR\n\n - Sa�l�ks�z beslenme, hareket azl��� gibi �e�itli fakt�rler kalp hastal��� riskinin artmas�n� sa�lar. Oru�, kalp sa�l���n� destekleyen fakt�rlerden iyi kolesterol olarak bilinen HDL kolesterol� artt�r�rken, k�t� kolesterol olan LDL ve trigliserid oranlar�nda d����e yard�mc� olmaktad�r.\n\n\n" +
                " KANSER� �NLEMEYE YARDIMCI OLUR\n\n - Oru�lu ki�ide organizma kendini kontrol etmeye vakit bulur ve b�ylelikle kanser h�crelerinin olu�umunu ba��ndan engellemi� olur. Ayn� zamanda kanser tedavisi i�in uygulanan kemoterapi s�ras�nda ortaya ��kan �e�itli yan etkileri azaltmas� da orucun faydalar� aras�nda yer al�r.\n\n\n" +
                " Z�H�NSEL FONKS�YONLARI ARTTIRIR\n\n - Ramazan ay�nda oru� tutarken uzakla�t���m�z fiziksel istekler, beynimizin yap�lan i�lere yo�unla�mas�n� sa�lar. Gereksiz metabolik aktivitelerle u�ra�mayan v�cut, alg�lama ve ��renmeye odaklanarak haf�zam�z�n daha iyi �al��mas�na katk�da bulunur. A�l�k, beyin sa�l��� i�in �nemli oldu�u saptanan �e�itli metabolik �zellikleri iyile�tirir.\n\n\n" +
                " OKS�DAT�F STRES ve �NFLAMASYONU (�LT�HAP) AZALTIR\n\n - Oksidatif stres, ya�lanman�n yan�nda daha pek �ok kronik hastal��a (diyabet, obezite, kanser vb.) neden olan durumlardan biridir. Yap�lan ara�t�rmalar oru� tutman�n v�cudun oksidatif strese kar�� direncini artt�rd���n� ortaya ��karm��t�r. Ayr�ca, uzun s�reli a�l���n inflamatuvar belirte�leri azaltarak bir�ok yayg�n hastal���n ana nedeni olan iltihaplara kar�� korunmay� sa�lad���n� g�stermi�tir.\n\n\n";
        }

        if(urun=="O�ul Otu")
        {
            baslik.text = " O�ul Otunun Faydalar� ";
            urunResmi.sprite = KeremResimler[29];

            konu.text = "- Kendisi sahip oldu�u bile�enler sayesinde stresle ba� etmede �ok yard�mc� oluyor. V�cudu stresin zararl� etkilerinden koruyor.\n\n" +
                "- Ba� a�r�s� ba�ta olmak �zere v�cudun �e�itli b�lgelerinde olu�an a�r�lar�n azalmas�na destek oluyor. �zellikle o�ul otuyla demlenen �ay�n banyo suyuna kar��t�r�lmas�yla bu etkisinden faydalan�l�yor.\n\n" +
                "- O�ul otu a��z yoluyla t�ketildi�inde kan dola��m�n� h�zland�r�c� bir etki yarat�yor. Bu �zelli�i sayesinde de kan�n damarlarda sa�l�kl� bir �ekilde akmas�n� sa�lad���ndan kalp ve damar rahats�zl�klar�ndan v�cudu koruyor.\n\n" +
                "- D�zenli olarak kullan�ld���nda ya�l� ciltlerin ya�dan ar�nmas�n� sa�l�yor.\n\n" +
                "- Mide bulant�s� ya�ayanlar�n bu sorundan kurtulmas�n� sa�l�yor.\n\n" +
                "- Ba��rsaklardaki hareketlili�i art�rarak �zellikle kab�zl�k sorunu ya�ayanlara �are oluyor.\n\n" +
                "- Metabolizmay� h�zland�rd���ndan haz�ms�zl�k sorununa da �are oluyor. Sindirim sisteminin sa�l�kl� bir �ekilde �al��mas�na destek oluyor.\n\n";
        }
        #endregion

        // � ile ba�layanlar
        #region � ile ba�layanlar
        if (urun=="�d A�ac�")
        {
            baslik.text = " �d A�ac� Faydalar� ";
            urunResmi.sprite = KeremResimler[30];

            konu.text = "\n �ERBET HAL�NDE T�KET�LD���NDE\n\n - Zehirlenmeye kar�� panzehir niteli�indedir.\n\n - Adet d�ng�s�n� d�zenler.\n\n - �drar s�kt�r�c�d�r.\n\n" +
                "- Kal�n ba��rsak hastal�klar�nda etkili rol oynar ve do�al bir m�shil ilac�d�r.\n\n - A�r� kesici niteli�indedir.\n\n - Ba����kl�k sistemini g��lendirir.\n\n\n" +
                " T�TS� OLARAK KULLANILDI�INDA\n\n - Depresyona, strese ve yorgunlu�a iyi gelir. Meditasyon esnas�nda ferahlat�c� bir etki yarat�r.\n\n - Konsantrasyonu artt�r�r ve huzur verir.\n\n" +
                "- Balgam emicidir ve kokusu �st solunum yollar� hastal�klar�na iyi gelir.\n\n - Kokusu v�cudu bakteri ve toksinlerden ar�nd�r�r.\n\n\n";
               
        }

       if(urun=="�ks�r�k Otu")
        {
            baslik.text = " �ks�r�k Otunun Faydalar� ";
            urunResmi.sprite = KeremResimler[31];

            konu.text = "- �ks�r�k otu neye faydal� sorusuna verilecek ilk cevap bitkinin ad�ndan da anla��ld��� gibi �ks�r��� kesmesidir.\n\n" + 
                "- Nezle, grip, so�uk alg�nl��� gibi solunum yolu hastal�klar�na iyi gelir.\n\n - Ast�m ve bron�it gibi nefes ile ilgili sorunlar�n minimuma indirilmesinde destek sa�lar.\n\n" +
                "- �drar s�k�c� �zelli�i vard�r ve bu y�zden �demleri azaltabilmektedir.\n\n - Kan dola��m� ile ilgili problemleri olanlar i�in kan suland�r�c� etkisi bulunmaktad�r.\n\n " +
                "- Sinir sistemini koruyucu �zelli�i sayesinde daha rahat hissetmeyi kolayla�t�r�r.\n\n - Yaralar, ��banlar, b�cek sokmalar� gibi durumlarda baz� y�relerde merhem olarak kullan�lmaktad�r.\n\n" +
                "- �i�mi� ayaklar ve eklem a�r�lar� i�in �ks�r�k otu i�eren suda ayak banyosu rahatlat�c� olabilmektedir.\n\n - Tazeyken s�k�lan �ks�r�k otundan elde edilen suyun kulak a�r�s�n� dindirdi�i s�ylenmektedir.\n\n";
                
        }

       if(urun=="�kse Otu")
        {
            baslik.text = " �kse Otunun Faydalar� ";
            urunResmi.sprite = KeremResimler[32];

            konu.text = "\n KANSERLE M�CADELE EDER\n\n - �kse otu kanser kar��t� aktiviteye sahiptir. Kemoterapi sonras�nda hastalar�n�n durumunu hafifletmek i�in yard�mc� olur. Ayr�ca, �kse otu kanser h�crelerinin �l�m�ne de neden olur.\n\n\n" +
                " TANS�YONU DENGELER\n\n - �kse otu, insanlar� etkileyen hipertansiyon �zerinde �l��lebilir bir etkisi vard�r. Hipertansiyonu azaltarak fel�, kalp krizi ve koroner kalp hastal���n� �nlemeye yard�mc� olur. Tansiyonun y�kselmesini de d��mesini de engeller.\n\n\n" +
                " D�YABETE �Y� GEL�R\n\n - G�nde 2-3 bardak i�ilen �kse otu �ay� kandaki �eker seviyelerini d���r�r. Ayr�ca, ins�lin �retimini y�netir.\n\n\n" +
                " �LT�HAPLANMALARLA M�CADELE EDER\n\n - �kse otunun do�al bir anti inflamatuard�r. Artrit ve di�er eklem a�r�lar�na neden olan enflamasyonu hem i� hem de d��tan tedavi eder. Anti inflamatuar yetene�i sayesinde �kse otu, sindirim ve mide a�r�lar�n�n da hafifletilmesine yard�mc� olur.\n\n\n" +
                " �ST SOLUNUM YOLLARINA �Y� GEL�R\n\n - Solunum sistemindeki tahri�i azalt�r. �ks�r�k, bo�az a�r�s�, bron�it ve g���s s�k��mas�n� tedavi etmek i�in de kullan�l�r.\n\n\n" +
                " STRESE �Y� GEL�R\n\n - �kse otu, uykusuzluk, anksiyete, stres ve depresyon gibi hastal�klara sahip olanlar�n sinir sistemini rahatlat�r, stres hormonlar�n� azalt�r.\n\n\n" +
                " REGL A�RILARINA �Y� GEL�R\n\n - A�r�l� ve krampl� regl d�nemi ge�iriyorsan�z, �kse otu �ay� regli d�neminde ya�ad���n�z gerginli�i ve kramplar� rahatlatacakt�r.\n\n\n" +
                " KANAMALARI DURDURUR\n\n - Burun, akci�er ya da ba��rsak kanaman�z varsa, �kse otu �ay� hemostatik etkisi sayesinde kanamay� durduracakt�r.";
                
        }

        if (urun == "�fke")
        {
            baslik.text = " �fkenin Zararlar� ";
            urunResmi.sprite = KeremResimler[33];

            konu.text = "\n- Kontrol edilemeyen �fke fiziksel olarak ba� a�r�lar�na, mide rahats�zl�klar�na, solunum problemlerine, cilt problemlerine, b�brek fonksiyonlar�nda problemlere, sinir sistemi rahats�zl�klar�na, dola��m sorunlar�na, var olan fiziksel rahats�zl�klar�n k�t�le�mesine ve duygusal rahats�zl�klara; " +
                "bili�sel olarak konsantrasyon bozuklu�una, d���k performansa, unutkanl��a, uykusuzlu�a ve dikkatsizli�e; davran��sal olarak alkolizme, sigara tiryakili�ine, huzursuzlu�a, acelecili�e, ila� kullan�m�na ve a��r� yemek yemeye; sosyal olarak da aile hayat�nda, i�/okul hayat�nda ve toplumsal hayatta sorunlara yol a�maktad�r.";
        }
        #endregion

        // P ile ba�layanlar
        #region P ile baslayanlar
        if (urun=="Pamuk�uk Hastal���")
        {
            baslik.text = " Pamuk�uk Nas�l Ge�er ";
            urunResmi.sprite = KeremResimler[34];

            konu.text = "\n KARBONAT\n\n - Pamuk�uk tedavisinde en �ok bilinen ve yayg�n bir �ekilde uygulanan bitkisel tedavi y�ntemi karbonatt�r.\n\n" +
                "- ��me suyunu kaynat�n, i�ine az bir miktar karbonat ekleyin. Daha sonra temiz bir bezi parma��n�za ge�irin ve bu kar���ma bat�r�n. Ard�ndan bu bezle a��z i�ini temizleyin. Pamuk�uk karbonat ile k�sa s�rede yok olacakt�r.\n\n" +
                "- Emziriyorsan�z ve bebe�inizde pamuk�uk ��kt�ysa g���s ucunuzu da her emzirme �ncesi bu kar���mla temizlemeniz gerekir.\n\n\n" +
                " S�RKE\n\n - Organik sirkeyi su ile seyrelterek gargara yapmak a��z i�indeki bakterilerin ve mantarlar�n yok olmas�na yard�mc� olur. Bu uygulamay� pamuk�uk olu�madan, a��z i�i hijyenini korumak amac�yla d�zenli olarak her di� f�r�alama eylemi sonras�nda yapabilirsiniz.\n\n" +
                "- Bebeklerde ise yine steril bir bezi parma��n�za ge�irip bu kar���ma bat�rd�ktan sonra bebe�inizin a��z i�ini temizleyebilirsiniz. Ancak bu y�ntemi bebe�inizde uygulamadan �nce mutlaka �ocuk doktorunuza dan��man�z� �neririz.\n\n\n" +
                " BAL\n\n - Pamuk�u�un �zerine bir miktar bal s�rerek iyile�me s�recini k�saltabilirsiniz.\n\n !! Ancak bu noktada, 1 ya� alt� bebeklere bal verilmemesi konusunda uyar�da bulunmal�y�z.\n\n\n" +
                " ADA�AYI\n\n - 1 tutam ada�ay�n� 1 su barda�� i�me suyuyla 5 dakika kadar kaynat�n. Bu �ay� so�uduktan sonra gargara �eklinde kullanabilirsiniz.\n\n\n" +
                " ZENCEF�L ve ZERDE�AL\n\n - Antibakteriyel besinler listesinin ilk s�ralar�nda yer alan zencefil ve zerde�al baharatlar�n� bir miktar i�me suyuyla kar��t�r�p kendinize bitkisel bir gargara yapabilirsiniz.\n\n\n" +
                " KARADUT\n\n - Do�al karadut re�elinden g�n i�inde 3 defa t�keterek dil �zerindeki pamuk�uklar�n giderilmesine yard�m edebilirsiniz. �zellikle de 6 aydan daha b�y�k bebekler i�in �ok az miktarda karadut re�eli �nerilir.\n\n" +
                "- �ocuklarda zaman zaman pamuk�uk ya�anabilir. Bu durumu k�sa s�rede iyile�tirmek i�in karadut �zleri ya da �uruplar� kullan�labilir. Yeni fark edilen pamuk�uklar i�in karadut suyu da etkili olacakt�r. Dilerseniz karadut suyuyla dil �zerindeki pamuk�uklar� silebilirsiniz.\n\n" +
                "- Daha etkili �ekilde yok etmek i�in her sabah 1 fincan karadut suyu t�ketmeniz �nerilir.\n\n";
        }

        if(urun=="Papatya �ay�")
        {
            baslik.text = " Papatya �ay�n�n Faydalar� ";
            urunResmi.sprite = KeremResimler[35];

            konu.text = "- Papatya �ay�n�n en bilinen �zelli�i sinirleri gev�etmesi ve uykusuzlu�a iyi gelmesidir.\n\n" +
                "- Sindirimi kolayla�t�r�r, mide kramplar�na ve a�r�lar� ge�irir.\n\n" +
                "- Di� a�r�lar�n� hafifletir. Di� sorunu ya��yorsan�z, papatya �ay� ile gargara yapabilirsiniz.\n\n" +
                "- Cildi g�zelle�tirir ve canl� bir g�r�n�m sa�lar. Papatya �ay�n� bir cilt toni�i gibi kullanabilir, y�z�n�z� silebilirsiniz.\n\n" +
                "- G�z kapaklar�nda meydana gelen iltihaplanmalar� tedavi eder.\n\n" +
                "- Solunum yolu hastal�klar�n�n tedavisinde kullan�l�r. Sin�zit, nezle gibi bir hastal�k ya��yorsan�z, papatya �ay�n�n buhar�n� solumak iyile�menize yard�m edecektir.\n\n" +
                "- Regl a�r�lar�na, s�rt ve bel a�r�lar�na iyi gelir.\n\n" +
                "- Kan �ekerini dengeler.\n\n";

        }

        if(urun=="Parmak Emme")
        {
            baslik.text = " Parmak Emme ";
            urunResmi.sprite = KeremResimler[36];

            konu.text = "\n- Emme fonksiyonu yeni do�mu� �ocuklarda �ok kuvvetlidir. Ancak parmak emme ve dil emme al��kanl�klar� ilk 1.5 sene normal olmakla birlikte 2 ya��n sonunda kaybolur." +
                " Ancak parmak emme, emzik emme al��kanl��� devam edecek olursa hen�z geli�mekte olan kas ve kemik yap�lar� �zerine bas�n� uygulayarak di�lerin yer de�i�tirmesine yol a�ar." +
                " Bu durumda �st �n di�ler �ne alt �n di�ler ise geriye do�ru e�ilir ve alt ve �st �n di�ler aras�nda a��kl�k meydana gelir.Al��kanl�k b�rak�l�rsa bu a��kl�k kapan�r ancak 3.5 ya��ndan sonra kal�c�l�k artar." +
                "Parmak emme al��kanl��� gece uyurken de devam ederse daha etkili olur ve bunun sonucunda �st �enede darl�k (V �eklinde bir �ene kavisi) meydana gelir.\n\n\n" +
                " ANNE ve BABALAR NE YAPMALI?\n\n - Karde�i do�du�u i�in anne ve babas�n�n ilgisini kaybetti�ine inanan bir �ocuk ilgiyi geri kazanmak i�in parmak emiyor olabilir. B�yle bir durumda, �ocu�un karde�i do�sa da kendisinin ayr� bir yeri oldu�una ve ebeveynlerinin onu sevmeye devam edece�ine inand�r�lmas� do�ru bir yol olacakt�r.\n\n" +
                "- �ocu�un kayg�l� oldu�u zamanlarda parma��n� emdi�i fark edildiyse kayg� yaratan durum �zerinde durulmal� ve �ocuk kayg� yaratan etkenlerden m�mk�n oldu�unca uzak tutulmaya �al���lmal�d�r.\n\n" +
                "- �ocu�un parmak emme davran��� �zerinde bask�c� bir �ekilde durulmamal�d�r. Anne ve babalar�n verdi�i tepkiler �ocu�un ilgisini bu konuya odaklayarak parmak emme davran���n�n artmas�na neden olabilir." +
                " �rne�in, parmak emen bir �ocu�un azarlanmas�, s�k s�k uyar�lmas�, ba�ka �ocuklarla k�yaslanmas� gibi durumlar parmak emme davran���n� peki�tirebilir ve �ocu�un kendini su�lu ya da cezaland�r�lm�� hissetmesine yol a�abilir.\n\n";
        }

        if (urun == "Patl�can")
        {
            baslik.text = " Patl�can�n Faydalar� ";
            urunResmi.sprite = KeremResimler[37];

            konu.text = "\n- Bol miktarda lif i�ermesiyle birlikte haz�ms�zl�k gibi sorunlar� giderir.\n\n" +
                "- Kalp �arp�nt�s� gibi stres yaratan hastal�klarda insan� sakinle�tirir.\n\n" +
                "- V�cutta doku s�v�lar�nda biriken �demi atmada ve ayn� zamanda idrar� s�kt�rmede �nemli bir besin kayna��d�r.\n\n" +
                "- Bol miktarda demir i�erdi�i i�in kans�zl�k �ekenler i�in kan �retimini artt�rmaya yard�m eder.\n\n" +
                "- �stemsiz bir �ekilde kas kas�lmas� olaylar�n� engeller.\n\n" +
                "- K�zlenmi� patl�can�n faydalar� ise normal patl�cana g�re biraz daha az olabilir. Bunun nedeni ise k�zlendi�i i�in i�erisindeki baz� yararl� bakterilerin �lmesi ve baz� vitaminlerin yok olmas�d�r. Bunlar�n haricinde yine normal patl�can gibi bir�ok yarar� bulunmaktad�r.\n\n" +
                "- Patl�can sap�n�n faydalar� da saymakla bitmemektedir. Patl�can�n g�vdesinin oldu�u kadar sap� da yararl�d�r. ��yle ki patl�can tutundu�u topraktan mineral ve baz� yararl� maddeleri sap�nda birikmektedir. Bu y�zden sap� kaynat�l�p t�ketildi�inde bir�ok hastal�k �nlenmi� olur.\n\n" +
                "- �i� patl�can�n faydalar� genel olarak sindirim sistemine etki etmektedir. Ba��rsaklar� yumu�atma �zelli�ine sahiptir ve ta� olu�umunu engeller. K�t� kolesterol gibi zararl� hastal�klar� engeller.\n\n";
        }

        if (urun == "Pekmez")
        {
            baslik.text = " Pekmezin Faydalar� ";
            urunResmi.sprite = KeremResimler[38];

            konu.text = "\n ANT�OKS�DAN �ZELL�KLER�\n\n - Di�er �ekerler ve tatland�r�c�larla kar��la�t�r�ld���nda pekmez, y�ksek oranda antioksidanlar i�erir. Antioksidanlar, v�cudu �e�itli bozukluklar ve dejeneratif hastal�klarla ili�kili oksidatif hasara kar�� korur. Bu da pekmezi, �o�u insan i�in rafine �ekere daha iyi bir alternatif yapar.\n\n\n" +
                " V�CUT A�IRLI�INI AZALTMADA YARDIMCIDIR\n\n - Pekmezde bulunan polifenollerin obeziteyi azaltmada ve kilo vermede etkili olabilecek antioksidan etkilere sahip oldu�unu g�stermektedir.\n\n\n" +
                " ADET KRAMPLARINI HAF�FLET�R\n\n - Pekmez, iyi bir demir kayna��d�r ve kan kayb� nedeniyle demir eksikli�i riski olan kad�nlar�n adetlerini kontrol etmede �ok etkili olabilir.\n\n\n" +
                " KEM�KLER� SA�LIKLI TUTAR\n\n - Pekmez iyi bir kalsiyum kayna��d�r. Kalsiyum, kemik sa�l���n�, enzimlerin i�leyi�ini ve h�cre zar� i�levini korumada �nemli bir rol oynar. Kalsiyum, sa�l�kl� di�lerin korunmas�n�n yan� s�ra v�cudun menopoz s�ras�nda s�k g�r�len kemik hastal�klar�na kar�� korunmas�nda da b�y�k rol oynar.\n\n\n" +
                " C�NSEL SA�LI�I GEL��T�R�R\n\n - Karadut pekmezi, cinsel hormonlar�n sa�l�kl� �retilmesine yard�mc� oldu�u d���n�len eser mineral manganez bak�m�ndan zengindir. Manganez, sinir sisteminin i�leyi�inde, kan p�ht�lar�n�n �nlenmesinde ve karbonhidratlardan enerji �retiminde hayati bir rol oynar. Manganez eksikli�i k�s�rl��a, genel yorgunlu�a ve kemiklerin zay�flamas�na neden olabilir.\n\n\n" +
                " ANT�-�NFLAMATUAR �ZELL�KLER\n\n - Pekmezin antienflamatuar ve antioksidan �zellikleri, bu t�r rahats�zl�klar� hafifletmek i�in g�venilir bir bile�endir. Romatizma ve nevralji gibi iltihapl� hastal�k durumlar�n� tedavi etmek i�in baz� ila� preparatlar�nda etkili bir �ekilde kullan�lm��t�r.\n\n\n\n" +
                " PEKMEZ�N T�RLER�NE G�RE FAYDALARI \n\n\n" +
                " DUT PEKMEZ�\n\n - Kan eksikli�i bulunan hastalarda �ok b�y�k faydalar sa�lar.\n - �lsere iyi gelir.\n - Ast�m ve bron�it hastalar�nda rahatlama sa�lar.\n - So�uk havalarda v�cut direncini art�r�r.\n - Sporcular i�in bir enerji deposudur.\n - Bebeklerin b�y�mesine ve geli�mesine yard�mc� olur.\n - �ocuklar�n zeka geli�iminde �nemli rol oynar.\n - A��z ve bo�az hastal�klar�nda etkilidir.\n\n\n" +
                " �Z�M PEKMEZ�\n\n - V�cuttaki kan� artt�r�r.\n - Enerji verir.\n - ��tah� a�ar.\n - Hamilelikte bebe�in geli�imi a��s�ndan �ok faydal�d�r.\n - Mideyi, ba��rsaklar�, b�brekleri kuvvetlendirir.\n - Damar sertli�ine iyi gelir.\n - Kan dola��m�n� rahatlat�r.\n\n\n" +
                " KU�BURNU PEKMEZ�\n\n - Solunum yolu enfeksiyonlar�na iyi gelir.\n - Vucuda zindelik katar.\n - Kan� temizler.\n - Mide kramplar�na ve sindirim sistemi problemlerine iyi gelir.\n\n\n" +
                " KE��BOYNUZU PEKMEZ�\n\n - Kolestrol� d���r�r ve tansiyonu dengeler.\n - Kalbi destekler.\n - Cinsel g�c� ve sperm say�s�n� art�r�r.\n - V�cudu g��lendirir.\n - Kans�zl��a kar�� �ok etkilidir.\n - Di�leri besler, kemikleri g��lendirir.\n - Ba��rsaklar� �al��t�r�r.\n - �ocuklar ve hamileler i�in faydal�d�r.\n\n\n" +
                " ANDIZ PEKMEZ�\n\n - Bron�it, �ks�r�k, sar�l�k, ka��nt�, egzama, mide bulant�s�na iyi gelir.\n - Akci�er ve karaci�ere destek sa�lar.\n - Kan yapar ve enerji verir.\n\n\n" +
                " KARADUT PEKMEZ�\n\n - Y�ksek miktarda demir i�erdi�inden kans�zl�kta destekleyici g�da olarak kullan�lmaktad�r.\n - Anne s�t�n� art�r�r.\n - Halsizli�i, a��r� yorgunlu�u giderir.\n - A��z ve bo�az enfeksiyonlar�nda kullan�l�r.\n -  Kan� temizler anemi hastalar� i�in tavsiye edilir.\n - Kan bas�nc�n� d���r�r.\n - Sindirim sistemi kronik hastal���na faydal�d�r.\n - Mide salg�lar�n� artt�r�r.\n - Sindirim sistemini d�zenler.\n - Sa�lar�n ve di�lerin g��lenmesini sa�lar.\n - Kronik gastrit ve hepatit tedavisinde kullan�labilir.\n\n\n"
                ;
        }

        if (urun == "Perhiz")
        {
            baslik.text = " Perhiz ";
            urunResmi.sprite = KeremResimler[39];

            konu.text = "\n PERH�Z NED�R?\n\n - Perhiz, sa�l�k durumundan dolay� ya da bedene �eki d�zen vermek i�in yap�lan k�s�tl� beslenme program�d�r.\n\n - Ya�am kalitesini daha iyi konuma getiren perhiz, asl�nda Yahudilerin ve Hristiyanlar�n k�lt�r�nde uygulanan, y�l�n belirli g�nlerinde et, hamur, ya�l� g�dalar� yememe d�zenidir.\n\n - Dini inan�lar�ndan kaynaklanan bu besin k�s�tlamas�, zaman i�inde di�er k�lt�rlerde diyet program� �eklini alm��t�r.\n\n\n" +
                " PERH�Z PROGRAMI NASIL UYGULANIR?\n\n - Perhiz, ki�inin ya� ve sa�l�k durumuna g�re ayarlanan beslenme program�na g�re uygulan�r. Bir �rnek ile netle�tirmek gerekirse; e�er gut hastal��� i�in diyet uygulanacaksa, guta neden olan besinlerin bir s�re t�ketilmemesi gerekir.\n\n\n" +
                " PERH�Z YAPMANIN FAYDALARI NELERD�R?\n\n - Ki�ilere �zel olarak uygulanan perhiz, her �eyden �nce az ve �z yemeyi hedefler. Bu ise beslenme d�zenini sa�lamaktad�r.\n\n - V�cut i�in zararl� olan maddelerin k�s�tlanmas�, ki�iyi daha sa�l�kl� k�lacakt�r.\n\n - Perhiz d�nemi boyunca, bedenden zararl� maddelerin at�lmas� daha kolay bir hal al�r. Bu ise ki�inin hem ruhen hem de bedenen rahatlamas�n� sa�lar.\n\n\n" +
                " NELERE D�KKAT ED�LMEL�?\n\n - Perhiz diyeti yaparken ataca��n�z ilk ad�m bilin�li olmal�d�r. Bu nedenle bir uzman yard�m� ile bedeninizi tan�y�p ona g�re beslenme d�zeni olu�turmal�s�n�z.\n\n - Sa�l�k sorununuz varsa e�er ���nlerinize ekleyece�iniz besinler, size iyi gelen yiyeceklerden se�ilmelidir.\n\n - Alerji veya hastal���n�z� tetikleyen besinlerin diyet listenizde olmamas� gerekli. Bu nedenle daha �nce alerji testi yapt�rmad�ysan�z, test yapt�rd�ktan sonra perhiz yapabilirsiniz.\n\n" +
                " - Hamilelik d�neminde de perhiz yap�labilir. Anne i�in gerekli olan besinler listeye eklenirken, sa�l���n� tehdit eden besinler ���nlerden ��kar�l�r. Bitki �aylar�, yo�un kafein, alkol gibi �r�nler listede yer almazken protein, vitamin ve sa�l�kl� yiyecekler perhiz yemekleri listesinde en �st s�rada yaz�lmaktad�r.\n\n"
                ;
        }

        if (urun == "Peynir")
        {
            baslik.text = " Peynirin Faydalar� ";
            urunResmi.sprite = KeremResimler[40];

            konu.text = "\n - Sinir sistemi i�in faydal�d�r.\n\n" +
                "- Haf�zay� g��lendirir.\n\n" +
                "- Di�leri g��lendirir. Di� minesine yararl�d�r.\n\n" +
                "- ��r�k di� olu�umunu engeller.\n\n" +
                "- V�cudun kalsiyum ihtiyac�n� kar��lar.\n\n " +
                "- Kemik erimesi olu�umunu engeller.\n\n" +
                "- Diyabete kar�� korur.\n\n" +
                "- Kilo vermeye kolayl�k sa�lar.\n\n" +
                "- Kalp hastal�klar� riskini aza indirir.\n\n" +
                "- Y�ksek tansiyonu d���r�r.\n\n" +
                "- T�m�r olu�umunu engeller.\n\n" +
                "- Migren a�r�s�na iyi gelir.\n\n" +
                "- Ba��rsak bakterilerini korur.\n\n";
                
        }

        if (urun == "P�rasa")
        {
            baslik.text = " P�rasan�n Faydalar� ";
            urunResmi.sprite = KeremResimler[41];

            konu.text = "\n - P�rasa, i�erisinde bulunan flavonoid olan kaempherol i�erir. Kan damarlar�n�n astarlar�n� serbest radikallere kar�� korular kaempherol i�eren p�rasa bu nedenle kalp sa�l��� i�in �ok faydal�d�r.\n\n" +
                "- P�rasada iyi bir potasyum kayna��d�r. Potasyum kan bas�nc�n�n ayarlanmas�nda sodyum kadar etkilidir. Bu nedenle p�rasa t�ketmek hipertansiyon riskini azalt�r.\n\n" +
                "- P�rasa i�eri�inde hem kalsiyum hem de K vitamini bulunmaktad�r. Kemiklerin g��lenmesinde g�revi olan kalsiyum ve K vitamini ihtiyac�n� gidermek i�in di�er besinlerle birlikte p�rasa t�ketmek faydal�d�r. K vitamini ayn� zamanda kan�n ak��kanl���n� da d�zenlemektedir.\n\n" +
                "- P�rasa kalsiyumun yan� s�ra i�erdi�i magnezyum sayesinde kemiklerin ihtiyac� olan minerallerin belli bir k�sm�n� kar��lamada rol al�r.\n\n" +
                "- P�rasa i�erisinde potasyum, kalsiyum, fosfor, demir, magnezyum, iyi bir diyet lifi,  B6 Vitamini, A Vitamini, C vitamini, K Vitamini ve iyi bir folat kayna�� bulundurur. Bu �zelliklerinden dolay� ba����kl�k sistemi i�in olduk�a �nemlidir.\n\n" +
                "- P�rasa t�ketmek, kronik iltihap riskini azaltmada yard�mc� olur.\n\n" +
                "- P�rasan�n idrar s�kt�r�c� �zelli�i vard�r.\n\n" +
                "- P�rasa, v�cudu temizler, cildin parlak g�r�nmesini sa�lar.\n\n" +
                "- V�cuda giren enfeksiyonlu h�crelerle antiseptik �zelli�i sayesinde sava��r.\n\n";
        }

        if (urun == "Pirin�")
        {
            baslik.text = " Pirincin Faydalar� ";
            urunResmi.sprite = KeremResimler[42];

            konu.text = "\n ENERJ� VER�R\n\n - Pirin� zengin bir karbohidrat kayna��d�r ve ��z�nmesi zaman alan uzun karbohidrat zincirlerinden olu�ur. Bu sayede, pirincin i�indeki karbohidratlar s�rekli bir enerji sa�layabilir. Yabani (kahverengi) pirin�, diyetisyen kontrol�nde uygun miktarlarda t�ketildi�inde diyabet hastalar� i�inde bile fayda sa�layabilir.\n\n\n" +
                " Y�KSEK BES�N DE�ER�\n\n - Hem beyaz hem de kahverengi pirincin kendine �zg� besin de�eri bulunuyor. Beyaz pirin� kalsiyum ve demir gibi y�ksek mineraller i�erir, ayr�ca niyasin, D vitamini, tiamin ve riboflavin gibi vitaminler a��s�ndan da zengindir. Kahverengi pirin� ise lif a��s�ndan zengindir, bu nedenle sindirimi iyile�tirmeye yard�mc� olabilir.\n\n\n" +
                " HASTALIKLARI ENGELL�YOR\n\n - Pirincin �e�itli hastal�klar� kontrol etti�i biliniyor. Esmer pirin�, Alzheimer hastal���n�n olu�umunu engelleyen y�ksek miktarda n�roiletkenler i�erir. Ayr�ca ister beyaz olsun, ister kahverengi olsun pirin�, kalp hastal�klar� ve kalp krizi olu�umunu engelleyebilen ve kalbi koruyabilen antioksidan i�eriyor.\n\n\n" +
                " KABIZLI�I �NLEMEYE YARDIMCI\n\n - Pirin�te �ok d���k miktarda sodyum bulunuyor, bu sayede y�ksek kan bas�nc�n� kontrol etmeye yard�mc� olabiliyor. Yabani pirin� m�kemmel bir sa�l�kl� lif kayna��d�r. Bunlar, sindirimi iyile�tiren ve ba��rsak hareketlerini d�zenlemeye yard�mc� yararl� bakterilerin geli�mesine yard�mc� olabiliyor.\n\n\n" +
                " GL�TENS�Z GIDA\n\n - Pirin�te gl�ten bulunmamaktad�r, bu nedenle ��lyak hastal���ndan muzdarip olanlar�n ve bu�day, arpa, �avdar ve yulafta bulunan proteinlere alerjisi olanlar�n diyetine kolayl�kla dahil edilebiliyor.\n\n";
        }

        if (urun == "Patates")
        {
            baslik.text = " Patatesin Faydalar� ";
            urunResmi.sprite = KeremResimler[43];

            konu.text = "\n- ��eri�inde bolca potasyum i�eren patatesin kabu�unun faydalar� kan bas�nc�n� dengeler.\n\n" +
                "- Kalp �arp�nt�s� riskini azalt�r.\n\n" +
                "- �i� patatesin faydalar� aras�nda ciltteki morluklara iyi gelmesi yer al�r. Patatesi halka halka dilimler halinde g�z�n�ze koyarak yorgun g�r�n�m� ve g�z alt� morluklar�n� hafifletebilirsiniz.\n\n" +
                "- Ciddi olmayan yan�k ve k�zar�kl�klar i�in �i� patates faydalar� en do�al ��z�mlerden birisidir.\n\n" +
                "- Midedeki gaz� ve asitleri gidererek sindirimi kolayla�t�r�r, mideyi rahatlat�r.\n\n" +
                "- Patates vitamin ve mineral a��s�ndan zengin bir sebze oldu�u i�in, sinir sistemi �zerinde d�zenleyici bir etki sunar.\n\n" +
                "- ��eri�inde yer alan selenyum ile tiroide, manganez ile cilt sa�l���na iyi gelir.\n\n" +
                "- Fosfor i�eri�i sayesinde cinsel g�ce olumlu y�nde katk� sa�lar.\n\n" +
                "- Patatesin ciltteki faydalar� aras�nda kuru ciltleri nemlendirmesi, g�z �evresi k�r���kl�klar�n� �nlemesi, g�ne� yan�klar�n� iyile�tirmesi, cildi yumu�atmas� ve leke giderici etkileri yer al�r.\n\n" +
                "- Ha�lanm�� patates faydalar� ishal i�in birebirdir. Bu rahats�zl��� ya�ad���n�z g�nlerde bol bol ha�lanm�� patates t�ketebilirsiniz.\n\n" +
                "- ��eri�i B6 vitamini sayesinde stres ve kronik yorgunlu�a kar�� tedavi g�revi �stlenir.\n\n" +
                "- Anne s�t�n� art�ran folat, patateste bolca bulunur. Emziren anneler patates t�ketebilir.\n\n" +
                "- Sa�l�kl� ve yeni h�crelerin olu�mas�n� sa�layan B9 vitamini ile patates, kanser riskini �nler.\n\n" +
                "- Haz�ms�zl�k, �i�kinlik ve �zellikle de kab�zl�k gibi durumlarda ba��rsaklar�n�z� patates yiyerek �al��t�rabilirsiniz.\n\n" +
                "- Sa� d�k�lmesine kar��, durulama suyuna patates suyu ekleyerek sa�lar�n�z� y�kayabilir veya direkt patates suyuyla sa� derinize masaj yapabilirsiniz.\n\n";
        }

        if (urun == "Paz�")
        {
            baslik.text = " Paz�n�n Faydalar� ";
            urunResmi.sprite = KeremResimler[44];

            konu.text = "\n- Paz�, lifli i�eri�i nedeniyle sindirim sisteminin dostu bir besin olarak �n plana ��kmaktad�r. Hazm� kolayla�t�rmada, sindirim sistemini �al��t�rma ve kab�zl��� �nlemede rahatl�kla kullan�labilir. Bu �zellikleri nedeniyle gaz sorununa da yol a�mayan paz�, emziren anneler taraf�ndan da rahatl�kla t�ketilebilir.\n\n" +
                "- Paz� �zellikle de paz� suyunun t�ketilmesinin damar sertli�inin giderilmesinde etkili oldu�u bilinmektedir.\n\n" +
                "- Paz� kalsiyum, magnezyum, K vitamini ve C vitamini bak�m�ndan olduk�a zengindir. Bu sebeple kemikleri g��lenmesinde olduk�a etkilidir. Bunun yan�nda sa�lar�n canl� g�r�nmesi ve di�lerin g��lenmesin de rol oynar. Paz�n�n t�ketilmesi ya da suyundan sa� maskesi yap�lmas� sa� sa�l��� bak�m�ndan faydal� olabilmektedir.\n\n" +
                "- Paz�, �ocuklar taraf�ndan da rahatl�kla t�ketilebilir. �ocuklarda �zellikle kemiklerin b�y�mesi ve geli�imine yard�mc� olur.\n\n" +
                "- 100 gram paz�da yakla��k olarak 3.0 mg demir bulunmaktad�r. K�rm�z� kan h�cresi �retimini destekledi�i i�in kans�zl�k ya�ayan ki�ilerin paz� t�ketmesi olumlu sonu�lar vermektedir.\n\n" +
                "- Paz� antioksidan �zelli�i olan bir sebzedir. ��erdi�i antioksidanlar sayesinde antikanser �zelli�inin olmas� kansere kar�� koruyucu oldu�unu g�sterir. �zellikle kolon kanserini �nlemeye yard�m eder.\n\n" +
                "- Demir eksikli�i; halsizlik, s�rekli yorgunluk hali, konsantrasyon sorunlar� ve ilgisizlik gibi belirtilerle kendini belli edebilir. ��eri�inde bulunan demir nedeniyle paz�n�n, demir eksikli�ini �nleyici �zelli�i oldu�u bilinmektedir. Bu nedenle paz� t�ketimi; halsizlik, depresyon ve yorgunlu�a iyi gelir.\n\n" +
                "- Paz� t�ketimi, v�cuttaki baz� deri hastal�klar�na iyi gelebilir.\n\n" +
                "- �drar s�kt�r�c� �zelli�i olan paz�, �zellikle idrar yolu iltihab�na iyi gelmektedir.\n\n";
                
        }
        #endregion

        // R ile ba�layanlar
        #region R ile baslayanlar
        if (urun == "Reyhan Bitkisi")
        {
            baslik.text = " Reyhan Bitkisinin Faydalar� ";
            urunResmi.sprite = KeremResimler[45];

            konu.text = "- Ba����kl�k sistemini g��lendirerek hastal�klara kar�� direncinizi artt�r�r.\n\n" +
                " - K�t� kolesterol� d���rerek kalp dostu bir tav�r sergiler.\n\n" +
                " - Mide asidini d�zenler ve haz�ms�zl�k gibi sorunlar�n�z�n giderilmesine yard�mc� olur.\n\n" +
                " - Antienflamatuvar �zelli�i sayesinde �dem att�r�c� etki g�sterir.\n\n" +
                " - Ba� a�r�s�na iyi gelir.\n\n" +
                " - �ks�r��e iyi gelir.\n\n" +
                " - Cilt bak�m� i�in kaynat�l�p suyu tonik olarak kullan�labilir.\n\n";
        }

        if(urun=="Rezene �ay�")
        {
            baslik.text = " Rezene �ay�n�n Faydalar� ";
            urunResmi.sprite = KeremResimler[46];

            konu.text = "- Rezene �ay�, rezene bitkisinin i�erdi�i ya� asitleri sayesinde antidiyabetik ve antioksidan etkiye sahiptir. Antioksidan etkisi ile h�cre hasar�n� �nlemeye yard�mc� olmakta, yeni h�crelerin olu�umunu desteklemekte ve ya�lanmay� geciktirici etki sa�lamaktad�r.\n\n" +
                " - Bakteri ve mantar enfeksiyonlar� ile sava�maya yard�mc� olmaktad�r.\n\n" +
                " - Kan p�ht�s� olu�umunu engellemekte, kad�n �reme sistemini destekleyerek anne s�t� salg�lanmas�na katk�da bulunmaktad�r.\n\n" +
                " - Rezene �ay� a��z kokusuna iyi gelmekte, nefesi tazelemektedir.\n\n" +
                " - Sindirim sistemi kaslar�n� rahatlatarak ba��rsak hareketlerini d�zenlemekte ve kab�zl��a iyi gelmektedir.\n\n";
        }

        if (urun == "Romatizma")
        {
            baslik.text = " Romatizmaya �yi Gelen Besinler ";
            urunResmi.sprite = KeremResimler[47];

            konu.text = "\n  NAR\n\n - Nar ve nar �z�n�n i�inde bulunan flavonoid antosiyan bile�eni iltihap ile m�cadelede olduk�a etkilidir.\n" +
                " - D�zenli olarak nar yiyerek ya da nar suyu i�erek romatizma a�r�lar�n�z�n �iddetini azaltabilirsiniz.\n\n\n" +
                "  YUMURTA\n\n - Yumurta i�erisindeki B vitamini ve s�lf�r sayesinde kas, eklem, k�k�rdak ve ba� dokular�n�n geli�mesini sa�lar.\n" +
                " - Kemik sa�l���n� korur.\n - Romatizma hastalar� d�zenli olarak yumurta t�kettikleri takdirde hem a�r�lar� azal�r hem de kemikleri g��lenir.\n\n\n" +
                "  ZENCEF�L\n\n - Antienflamatuar bir baharat olan zencefil, iltihap ile m�cadelede olduk�a etkilidir.\n - Zencefili �ay olarak t�ketebilir ya da yemeklerinize ekleyebilirsiniz.\n\n\n" +
                "  ��LEK\n\n - En lezzetli yaz meyvelerinden biri olan �ilek, i�eri�indeki salisilik asit sayesinde romatizma a�r�lar�na da iyi geliyor.\n\n\n" +
                "  KELLE PA�A �ORBASI ve KEM�K SUYU\n\n - Romatizma hastal���n�n en �nemli sebeplerinden biri de v�cuttaki kolajen �retiminin azalmas�d�r.\n" +
                " - Bol miktarda kolajen i�eren kemik suyu ve kelle pa�a �orbas�n� hayat�n�za dahil ederek romatizma a�r�lar�n�z� hafifletebilirsiniz.\n\n\n" +
                "  MAYDANOZ\n\n - Yap�lan ara�t�rmalarda flavonoid luteolin i�eren maydanozun iltihab� �nledi�i ortaya konmu�tur.\n - Antienflamatuar bir besin olan maydanoz hem a�r�lar� hafifletir hem de eklem sertli�ini yok eder.\n\n\n" +
                "  ANANAS\n\n - Y�ksek oranda C vitamini i�eren ananas i�eri�indeki bromelain enzimi sayesinde iltihab�, yang�y� ve eklem �i�li�ini azalt�r.\n - Romatizman�n sebep oldu�u �ikayetleri minimize etmek i�in ananas t�ketebilir veya suyunu i�ebilirsiniz.\n" +
                " !! D�zenli olarak kulland���n�z herhangi bir ila� varsa ananas t�ketimi konusunu mutlaka doktorunuza dan��mal�s�n�z. Ananas ila� ile etkile�ime girerek farkl� etkiler yaratabilir.\n\n";
        }

        if (urun == "Roka")
        {
            baslik.text = " Rokan�n Faydalar� ";
            urunResmi.sprite = KeremResimler[48];

            konu.text = "\n - Yapraklar� idrar s�kt�r�c�, ya� yak�c� etkisinin yan�nda mideye de iyi gelmektedir. Diyetlerde s�kl�kla yer alarak, �dem olu�umunu engellemesi, b�ylece ya� kayb�n�n kesintisiz devam etmesi sa�lan�r. �i� olarak kahvalt�larda veya salatalarda t�ketilmesinin yan� s�ra maydanoz ve dereotu gibi bitkilerle i�me sular�n� aromaland�rmak i�in de kullan�labilir.\n\n" +
                " - Roka, kanseri �nleyici aktiviteye sahip enzimleri i�erir. Bu enzimi uyaran aktivite dolayl� olarak kanser olu�umunu engelleyen, v�cudun kendi kendini korumas�n� sa�layan s�reci g��lendirir.\n\n" +
                " - Tohum tahri� edici ve uyar�c�d�r. Toz haline getirilmi� tohum antibakteriyel aktiviteye sahiptir. Tohumdan elde edilen ya� afrodizyak �zelliklere sahiptir.\n\n" +
                " - Roka ya��, masaj yapmak ve cildi yat��t�rmak i�in kullan�labilir.\n\n" +
                " - Roka salatas�, K vitamini i�in m�kemmel sebze kaynaklar�ndan biridir; 100 g, �nerilen al�m�n yakla��k %90'�n� sa�lar. K vitamini, kemik olu�umu ve g��lenmesi aktivitesini te�vik ederek kemik sa�l���nda potansiyel bir role sahiptir.\n\n";
        }
        #endregion

        // U ile ba�layanlar
        #region U ile baslayanlar 
        if (urun == "Unutkanl�k")
        {
            baslik.text = " Unutkanl��a Ne �yi Gelir ";
            urunResmi.sprite = KeremResimler[49];

            konu.text = "\n YE��L �AY\n\n - Ye�il �ay hemen hemen her hastal���n tedavisinde kullan�lmaktad�r. Bir�ok faydas� oldu�u bilinen ye�il �ay�n unutkanl��a da olduk�a iyi geldi�i bilinmektedir. ��erdi�i bile�enler sayesinde haf�zay� da g��lendiren ye�il �ay mutlaka t�ketilmesi gerekmektedir.\n\n\n" +
                " NAR SUYU\n\n - E�er s�rekli olarak unutkanl�k �ikayeti ya��yorsan�z nar suyu t�ketebilirsiniz. Nar suyu da olduk�a �ifal� bir sudur. Nar suyu beyin h�crelerini korur ve onar�r. Bu �ekilde unutkanl��a neden olan fakt�rleri ortadan kald�r�r.\n\n\n" +
                " DOMATES\n\n - Domates yo�un miktarda likopen bile�eni i�ermektedir. Likopen bile�eni de haf�zay� t�m olumsuz fakt�rlerden korur. Bundan dolay� unutkanl�k problemi ya�ayan ki�ilere domates t�ketilmesi �nerilir. V�cudu t�m serbest radikallere korudu�u gibi beyin fonksiyonlar�n� da iyile�tirmektedir. Daha g��l� bir haf�zaya sahip olman�z� sa�lar.\n\n\n\n" +
                " A�IRI UNUTKANLI�A �Y� GELEN BES�NLER\n\n\n" +
                " YABAN MERS�N�\n\n - Haf�zay� g��lendirmesi ile bilinen yaban mersini t�ketilmesi uzman doktorlar taraf�ndan da s�kl�kla �nerilir. Yaban mersini ayn� zamanda hem haf�zay� g��lendirir hem de zihnin geli�mesini sa�lamaktad�r.\n\n\n" +
                " B�TTER ��KOLATA\n\n - Bitter �ikolata en faydal� tatl�lardan bir tanesidir. Yo�un miktarda kafein i�ermektedir. Ayn� zamanda bitter �ikolata t�ketmek hem i� hayat�nda hem de okul hayat�nda konsantrasyonu artt�rmaktad�r. Bitter �ikolata ki�iye ayn� zamanda enerji takviyesi de yapmaktad�r. S�rekli olarak bitter �ikolata t�keterek haf�zan�z� daha da diri bir hale getirebilirsiniz.\n\n\n" +
                " ISPANAK\n\n - Demir bak�m�ndan en zengin g�dalardan olan �spanak ayn� zamanda folik asit i�ermektedir. Folik asitte yine haf�zay� g��lendirir ve diri tutar. A��r� unutkanl�k gibi problemlerinizi �spanak ile ge�irebilirsiniz.\n\n";
        }

        if (urun == "Uyku")
        {
            baslik.text = " Uykuya Ge�i�i Kolayla�t�ran Besinler ";
            urunResmi.sprite = KeremResimler[50];

            konu.text = "\n - S�t ve s�t �r�nleri, uykuyu tetikleyici madde olan triptofan i�erir. Kuruyemi�ler ve ya�l� tohumlar, muz, bal ve yumurta da triptofan kaynaklar� aras�ndad�r.\n\n" +
                " - Ak�am yeme�inde yeterli olacak �ekilde yemek yemediyseniz, midenizden gelen gurultular y�z�nden uykuya dalman�z zorla�abilir. Karbonhidratlardan zengin besinler, uykuyu tetikleyen triptofan�n kandaki seviyesini artt�r�r.\n\n" +
                " - Baz� bireyleri kafein daha fazla etkiler, baz� bireyler ise hi� �ikayet etmez e�er sizinde hassasiyetiniz oldu�unu d���n�yorsan�z; daha iyi bir uyku i�in, yatmadan 4-6 saat �nce kafein al�m� kesilmelidir. Bunun i�in �ikolata, kolal� i�ecekler ve �ay i�iminizi kontrol etmelisiniz.\n\n" +
                " - Alkol, uykuya �abuk girmenize yarayabilir ancak s�k s�k uyanman�za, rahats�z bir uykuya, ba� a�r�s�na, terleme ve k�bus g�rmenize sebep olabilir. E�er ak�am alkol al�yorsan�z, etkilerini azaltmak i�in ayn� miktarda su i�meye �zen g�sterin.  �yi bir uyku i�in yatmadan 2 ila 4 saat �nce alkol al�m� kesilmelidir.\n\n" +
                " - Su t�ketimin ne kadar �nemli oldu�u her zaman vurguluyoruz ancak kesintisiz bir uyku istiyorsan�z yatmadan 1 saat �ncesine kadar s�v� al�m�n� kesmeniz olacakt�r. Aksi takdirde s�kl�kla tuvalete kalkma ihtiyac� duyabilirsiniz, bu durum uykunuzun s�rekli b�l�nmesine sebep olacakt�r.\n\n" +
                " - Proteinler, g�nl�k beslenmemiz i�in �ok �nemli olmakla birlikte, yatmadan �nce al�nan proteinler g�zel bir uyku i�in iyi bir tercih say�lamaz.  Proteinden zengin besinlerin sindirimi biraz daha zordur. Bunun i�in uykuya yard�mc� minik bir karbonhidrat alabilirsiniz.\n\n" +
                " - Uyku getiren yiyeceklerin ba��nda yer alan muz �ok iyi bir yat��t�r�c�d�r. Serotonin ve melatonin hormonlar�n�n yan�nda i�erdi�i magnezyumla da kaslar� gev�etip insan� rahatlat�r. Ger�ek bir uyku hap� gibi olan muz, yatmadan bir iki saat �nce yenirse, iyi bir uyku �ncesi terapi gibi gelecektir.\n\n" +
                " - Uyku d�zensizli�i ve uyumaya yard�mc� olmas� i�in ak�am saatlerinde anason �ay� t�ketilebilir. Kesintisiz bir uyku ile rahat bir gece ge�irebilirsiniz. Anason �ay�n� t�ketirken dikkat edilmesi gereken noktalar oldu�unu hat�rlatal�m, kullanmadan �nce doktorunuza dan��may� unutmay�n.\n\n" +
                " - �ok bilinmese de bal da uyumaya yard�mc� yiyecekler aras�ndad�r. Ak�amlar� bitki �ay�n�za veya �l�k s�t�n�ze ekleyece�iniz bir �ay ka���� bal sizi gev�etip uyku hali olu�turacakt�r. �zellikle muz ve s�t ile kar��t�rd���n�zda etkisini art�r�p uyku �ncesi rahatl��� ya�ayabilirsiniz.\n";
        }

        if (urun == "Uyuz")
        {
            baslik.text = " Uyuza Ne �yi Gelir ";
            urunResmi.sprite = KeremResimler[51];

            konu.text = "\n - Uyuza iyi gelen y�ntemlerden biriside �ay a�ac� ya�� kullanmakt�r. �ay a�ac� ya�� antiparazitik, antibakteriyel ve antifungal �zelliklere sahip bir do�al ya�d�r. Bu �zellikle ile derinin alt�nda ya�am�n� s�rd�ren akarlar�n �lmesini sa�lar.\n\n" +
                " - Bir di�er iyi gelen y�ntem ise hemen hemen herkes taraf�ndan bilinen bir y�ntem olan sirke kullan�m�d�r. Beyaz sirke cildin pH dengesini de�i�tirir ve bu de�i�iklik sonucunda uyuz b�ceklerini �ld�r�r.\n\n" +
                " - Uyuz tedavisi tuz y�ntemi k�sa s�re i�erisinde sizi bu b�ceklerden kurtaracakt�r. Tuzu, bir su i�erisinde eritip banyo yapmak uyuz tedavisine iyi gelen bir y�ntemdir.\n\n" +
                " - Son olarak di�er bir iyi gelen y�ntem ise Aloe Vera jeli y�ntemidir. Bunun i�in �ncelikle Aloe Vera jelini, uyuz olan b�lgeye s�r�p bekleyiniz.\n\n";
        }
        #endregion

        // � ile ba�layanlar
        #region � ile baslayanlar
        if (urun == "�lser")
        {
            baslik.text = " �lser ";
            urunResmi.sprite = KeremResimler[52];

            konu.text = "\n �LSER NED�R?\n\n - �lser, mide asidi ve sindirim s�v�lar� gibi tahri� edici nitelikteki v�cut s�v�lar�n�n mide veya onikiparmak ba��rsa��n� (duodenum) tahrip etmesi ve bunun sonucunda doku kayb�n�n ortaya ��kmas�d�r. Mide ve onikiparmak ba��rsa��n� sindirim enzimlerinden koruyan mukus tabakas�n�n azalmas�, �lserin ortaya ��kmas�n�n en b�y�k nedenlerinden biridir.\n\n\n" +
                " �Y� GELEN BES�NLER\n\n" +
                " - �lser tedavisinde �ne ��kan en �nemli vitamin, K vitaminidir. K vitamini, mide dokusundaki zar�n ve a��k yaralar�n iyile�mesinde etkilidir. K vitamini bak�m�ndan zengin ve buna ba�l� olarak �lsere iyi gelen besinler ise �spanak, ku�konmaz, lahana, avokado, soya, yonca ve �avdar unudur. \n\n" +
                " - Flavonoid i�eren baz� besinler de �lserin tedavisinde katk� sa�layabilir. Flavonoidler, �lser geli�imini engelleyerek mide zar�n� korumaya yard�mc� olur. Sar�msak, so�an, kereviz ve elma flavonoid bak�m�ndan zengin besinler aras�ndad�r.\n\n" +
                " - Lifli g�dalar par�aland�klar� zaman hidroklorik asidi kontrol ederler. Bu durum, mide �lserinde asidin hasar vermesini engeller. �lsere iyi gelen besinlerden biri olan lifli besinler ise sebzeler, meyveler ve tah�l gruplar�d�r.\n\n";
                
        }

        if(urun=="�zerlik Tohumu")
        {
            baslik.text = " �zerlik Tohumu ";
            urunResmi.sprite = KeremResimler[53];

            konu.text = "\n �ZERL�K TOHUMU NASIL KULLANILIR?\n\n - �zerlik tohumunun bir �ok faydas� ve bir �ok kullan�m alan� vard�r. Bunlardan biri tohumunun �ay olarak t�ketilmesidir. �zerlik tohumundan elde edilen �ay sa�l�k a��s�ndan �nemli bir yere sahiptir. Di�er bir kullan�m alan� ise t�ts� olarak yak�lmas�d�r. Evden k�t�l�kleri uzakla�t�rd���, b�y� bozdu�u ve nazardan korudu�u s�ylenir.\n\n\n" + 
                " FAYDALARI\n\n" +
                " - Burun t�kan�kl�klar�nda �zerlik tohumu yak�l�r ve duman� �ekilirse �st solunum yollar� a��l�r.\n\n" +
                " - Ba��rsaklarda ortaya ��kan kurtlar�n ortadan kalkmas�na yard�mc� olur.\n\n" +
                " - Alerjik reaksiyonlara kar�� v�cudu korur.\n\n" +
                " - Adet kanamalar�n� s�kt�r�r. Hormonlar�n d�zenli �al��mas�n� sa�lar.\n\n" +
                " - Ba� a�r�lar�na iyi gelir.\n\n" +
                " - Daha rahat uyuman�za yard�mc� olur\n\n" +
                " - K�t� enerjilerden korur.\n\n" +
                " - Kanserle m�cadelede ek takviye olarak kullan�l�r.\n\n" +
                " - Sa�lar�n eski rengine d�nmesini sa�lar.\n\n" +
                " - Haf�zay� destekler.\n\n" +
                " - G�z iltihaplar�nda pamuk ile �ay� g�ze s�r�ld���nde iltihab� ortadan kald�r�r.\n\n";
        }

        if (urun == "�vez")
        {
            baslik.text = " �vezin Faydalar� ";
            urunResmi.sprite = KeremResimler[54];

            konu.text = "\n - Balgam s�kt�r�c� bir etki olu�turuyor.\n\n" +
                " - Tansiyonu ve kan �ekerini d���r�c� bir etkide bulunuyor.\n\n" +
                " - C vitamini bak�m�ndan zengin oldu�undan ba����kl�k sisteminin g��lenmesine yard�mlar� dokunuyor.\n\n" +
                " - ��inde �vez kullan�larak haz�rlanan krem ve sabunlar�n cildi temizledi�i, antioksidan etkisi g�sterdi�i s�yleniyor.\n\n" +
                " - V�cutta olu�an iltihaplar�n daha h�zl� bir �ekilde iyile�mesini sa�l�yor.\n\n" +
                " - Kad�nlar�n regl d�nemlerinin �ok daha rahat bir �ekilde ge�mesine destek oluyor.\n\n" +
                " - �drar s�kt�r�c� bir etki olu�turdu�u s�yleniyor.\n\n" +
                " - V�cutta biriken �demin ve buna ba�l� olu�an �i�liklerin yok edilmesine yard�mc� oluyor.\n\n" +
                " - Kan yap�c� bir etkisi oldu�u da s�yleniyor.\n\n" +
                " - Ayn� zamanda kab�zl�k sorunu ya�ayanlara �ay�yla �are oluyor.\n\n";
        }
        #endregion

        // V ile ba�layanlar
        #region V ile baslayanlar
        if (urun == "Varis")
        {
            baslik.text = " Varis ";
            urunResmi.sprite = KeremResimler[55];

            konu.text = "\n VAR�S NED�R?\n\n - Varis bir�ok insanda g�r�len bir toplardamar hastal���d�r. Toplardamarlar�n deri alt�nda �e�itli �ekillere girerek k�vr�mlar olu�turmas�na denir.\n" +
                " - Varis, s�kl�kla g�n i�erisinde her t�rl� v�cut y�k�n� ta��yan bacaklarda g�r�len bir toplardamar hastal���d�r. Varis, damarlar�n �i� halinde g�r�lmesiyle ba�lasa da zamanla ve �nlem al�nmad��� takdirde damar �atlaklar�na kadar ciddi problemlere yol a�abilir. Varis, ilk etapta sadece g�r�nt� itibar�yla rahats�zl�k verici olsa da ilerledi�i zaman a�r�l� bir hastal��a d�n��ebilir.\n\n\n\n" +
                " VAR�SE NE �Y� GEL�R?\n\n\n ELMA S�RKES�\n\n - Cilt, sa� bak�m�, zay�flama ve bir�ok konuda adeta bitkisel iksir olarak kar��m�za ��kan elma sirkesi, varis do�al tedavisi i�in tercih edilen en etkili y�ntemlerden biridir.\n\n" +
                " - Elma sirkesini pamuklu bir bez yard�m�yla �slat�p varisli b�lgede bitkisel tedaviye ba�layabilirsiniz. Elmal� sirkeye bat�rd���n�z bezi 30 � 35 dakika varisin oldu�u b�lgeye sararak bekletebilirsiniz. Bu esnada bacaklar�n�z� v�cut hizas�n� ge�er vaziyette yukar�ya do�ru uzat�n. Bu pozisyonda 10-15 dakika bekleyin.\n\n\n" +
                " MAYDANOZ SUYU\n\n - Maydanoz suyu iltihaplanma problemleriyle s�k� s�k�ya m�cadele eden bir bitkisel ��z�md�r.\n\n" +
                " - Maydanoz �ay� i�eri�inde bulunan antioksidanlar sayesinde v�cuttaki herhangi bir iltihap bulundurmaz.\n\n" +
                " - Dola��m sisteminin daha sa�l�kl� ve d�zenli �al��mas�n� sa�lar.\n\n\n" +
                " ADA�AYI\n\n - Damarlarda olu�an iltihaplanmalar� azalt�p bu s�reci kontrol alt�na al�r. �ltihaplanmalar�n yay�lma h�z�n� yava�lat�r.\n\n\n" +
                " AT KESTANES�\n\n - At kestanesi, i�eri�inde bulunan di�retik ve antienflamatuar �zellikleri sayesinde dola��m sorunlar�na �are olur.\n\n" +
                " - At kestanesi �ay� i�erek hem v�cutta bulunan iltihab�n azalmas�n� sa�layabilirsiniz.\n\n" +
                " - At kestanesi ile damar sa�l���n�z� koruyabilirsiniz.\n\n";
        }

        if (urun == "Veba")
        {
            baslik.text = " Veba ";
            urunResmi.sprite = KeremResimler[56];

            konu.text = "\n VEBA NED�R\n\n - Veba, esas olarak pireler yoluyla bula�an ve �ok k�sa s�re i�erisinde �l�me yol a�abilecek ciddi sonu�lar� olan bir bakteriyel enfeksiyondur. Vebaya neden olan bakteriyel organizman�n ad� Yersinia Pestis�tir. G�n�m�zde en yayg�n olarak Afrika, Asya ve Amerika k�talar�n�n k�rsal ve yar� k�rsal b�lgelerinde bulunan k���k kemirgenlerde g�r�l�r. Yersinia Pestis enfekte kemirgenlerle beslenen pireler taraf�ndan �s�r�lma yolu ile insanlara ya da hayvanlara bula��r. Enfekte hayvanlarla u�ra�an insanlar da, bu hayvanlardan do�rudan enfekte olabilirler.\n\n" +
                " - Orta�a�da Kara �l�m olarak bilinen veba, g�n�m�zde d�nya �ap�nda y�ll�k 5.000'den az vaka say�s�na sahiptir. Veba derhal antibiyotikler ile tedavi edilmezse sonu�lar� �l�mc�l olabilir.\n\n\n\n" +
                " VEBA NASIL �NLEN�R\n\n - Vebaya kar�� hen�z tam etkili bir a�� yoktur. Ancak bilim adamlar� bir veba a��s� geli�tirmek i�in ara�t�rmalar�n� s�rd�rmektedir. Risk alt�nda olan, veya vebaya maruz kalan bireylerde enfeksiyon geli�mesini antibiyotikler �nlemeye yard�mc� olabilir.\n\n" +
                " - Veba vakalar�n�n ya da salg�nlar�n�n g�r�ld��� bilinen b�lgelerde bireylerin �e�itli �nlemleri almas� tavsiye edilir. �ncelikle kal�nan konutlar kemirgenlere kar�� korunmal�d�r. Ev �evresindeki �al�, hurda, kaya, veya yakacak odun y���nlar� gibi kemirgenlerin olas� yuvalama alanlar�n�n temizlenmesi gereklidir. E�er bir kemirgen istilas� mevcutsa, bunun kontrol alt�na al�nmas� i�in gerekli ad�mlar at�lmal�d�r. B�cek kovucu ara�lar�n ve y�ntemlerin uygulanmas� �nemlidir.\n\n";
        }

        if (urun == "Vi�ne")
        {
            baslik.text = " Vi�nenin Faydalar� ";
            urunResmi.sprite = KeremResimler[57];

            konu.text = "\n - Ba����kl�k sistemini g��lendirir.\n\n" +
                " - �yi bir A ve C vitamini kayna��d�r.\n\n" +
                " - Kalsiyum, demir ve fosfor minerallerini i�erir.\n\n" +
                " - Sinir sistemini d�zenleyici etkisi vard�r.\n\n" +
                " - Prostat ve kolon kanserine kar�� koruma sa�lar.\n\n" +
                " - Uykusuzlu�a kar�� olduk�a faydal�d�r.\n\n" +
                " - Kuvvetli bir antioksidand�r.\n\n" +
                " - Kab�zl�k sorununu giderir.\n\n" +
                " - Kanser h�crelerinin b�y�mesini engeller.\n\n" +
                " - Bakterilerden ve mantarlardan korur.\n\n" +
                " - Kolesterol� d�zenleyici etki yapar.\n\n" +
                " - Grip, nezle ve so�uk alg�nl���na kar�� �nleyici etkisi vard�r.\n\n" +
                " - Parkinson hastal���na kar�� koruma sa�lar.\n\n" +
                " - Beyin ve sinir sistemi i�in olduk�a yararl�d�r.\n\n" +
                " - Unutkanl��a kar�� etkilidir.\n\n" +
                " - Depresyona, strese kar�� faydal�d�r.\n\n" +
                " - Kalp at��lar�n� d�zenler, kalp hastal�klar�na kar�� korur.\n\n" +
                " - Ya�lanma kar��t� bir meyvedir. Anti-ageing �zelli�i vard�r.\n\n";
        }

        if (urun == "Vanilya")
        {
            baslik.text = " Vanilyan�n Faydalar� ";
            urunResmi.sprite = KeremResimler[58];

            konu.text = "\n - Antibakteriyeldir.\n\n" +
                " - Ba����kl�k sistemini g��lendirir.\n\n" +
                " - V�cut �zerindeki stresi azaltmaya yard�m eder.\n\n" +
                " - Yaralardan ve hastal�klardan kurtulmay� h�zland�r�r.\n\n" +
                " - Sa� i�in bir�ok sorunun �aresidir. K�r�lm�� sa�lar ve sa� d�k�lmesi sorunu olanlar i�in �ok faydal�d�r. Vanilya kafa derisine kan ak���n� h�zland�rd��� i�in sa�lar�n g�rle�mesini ve b�y�mesini sa�lar.\n\n" +
                " - Serbest radikaller y�z�nden ortaya ��kan cilt rahats�zl�klar�n� engeller.\n\n" +
                " - Bo�azdaki iltihab� ve tahri�i azaltmaya yard�m eder.\n\n" +
                " - �ks�r�k, so�uk alg�nl��� ve solunum yolu hastal�klar� ile sava��r.\n\n";
        }

        if (urun == "Verem Hastal���")
        {
            baslik.text = " Verem Hastal��� ";
            urunResmi.sprite = KeremResimler[59];

            konu.text = "\n VEREM NED�R?\n\n - Verem hastal���, yani t�bbi ad�yla t�berk�loz (TB) hava yoluyla bir bireyden di�erine yay�lan, bula��c� bir akci�er hastal���d�r. Verem hastal��� Mycobacterium Tuberculosis isimli bakterilerden kaynaklan�r. Verem hastal��� tedavi edilebilir ve verem a��s� ile �nlenebilir bir hastal�kt�r.\n\n\n" +
                " VEREM HASTALI�ININ YAYILMASI NASIL �NLEN�R?\n\n - Verem hastal���n�n daha yayg�n oldu�u �lkelerde bebekler, �ocuklarda �iddetli verem hastal���n� engelleyebilece�i i�in, genellikle basil Calmette-Guerin (BCG) a��s�, yani verem a��s� ile a��lan�r.\n\n" +
                " - BCG a��s� yap�lm�� �ocuklara ayn� a�� tekrar yap�lmaz. Bu a�� ile a��lanmam�� �ocuklarda ise 6 ya��ndan sonra BCG a��s� �nerilmemektedir, ��nk� a�� ya� ilerledik�e etkinli�ini yitirmektedir.\n\n" +
                " - E�er bir birey yap�lan testlerde gizli verem hastal��� enfeksiyonu i�in pozitif sonu� verirse, doktor aktif t�berk�loz geli�tirme riskini azaltmak i�in ila� kullan�m�n� �nerebilir. Bula��c� olan tek t�berk�loz tipi, aktif olan ve akci�erleri etkileyen tiptir. Dolay�s�yla gizli verem hastal���n�n aktifle�mesi �nlenirse, hastal�k ba�kalar�na bula�t�r�lmaz.\n\n" +
                " - Verem hastal���n�n yay�lmas�n� �nlemek i�in al�nacak �nlemlerden ilki evde kalmakt�r. Doktorun tavsiye etti�i s�re boyunca i�e, okula gidilmemeli, ba�kalar�yla ayn� odada uyunmamal�d�r.\n\n" +
                " - Kal�nan odalar mutlaka havaland�r�lmal�d�r. Verem mikroplar� kendi ba�lar�na hareket edemezler, bu y�zden havan�n �ok hareket etmedi�i k���k kapal� alanlarda daha kolay bula��rlar.\n\n" +
                " - D��ar�s� �ok so�uk olmad��� s�rece pencereleri a��p, i�erideki havay� bir vantilat�r ile d��ar� y�nlendirmek etkili olacakt�r. G�l�nce, hap��r�nca, veya �ks�r�nce a�z� bir mendil ile �rtmek gereklidir.\n\n" +
                " - Kirlenen mendilleri ayr� bir torbaya koyup, torbay� ba�lad�ktan sonra ayr�ca atmak gereklidir. Hastal���n tedavisinin ilk �� haftas�nda ba�kalar�n�n yan�ndayken cerrahi maske takmak bula�ma riskini azaltmaya yard�mc� olabilir.\n\n";
        }
        #endregion

        // Y ile ba�layanlar
        #region Y ile baslayanlar
        if (urun == "Yo�urt")
        {
            baslik.text = " Yo�urdun Faydalar� ";
            urunResmi.sprite = KeremResimler[60];

            konu.text = " - Yo�urttaki probiyotikler v�cudunuzun polen ve di�er alerjenlere reaksiyonunu azaltabilir.\n\n" +
                " - Yo�urdun bir�ok faydas�ndan biri, ba����kl�k artt�r�c� etkilere sahip olmas�d�r. Yo�urtun T h�crelerinizi veya enfeksiyonla sava�an h�creleri daha g��l� ve daha aktif hale getirdi�i kan�tlanm��t�r.\n\n" +
                " - Yo�urt yemek, v�cudunuza sindirimi d�zenli tutmak i�in �al��an sa�l�kl� bakteriler sa�lar. Hem kab�zl�k hem de ishal ile daha az sorun ya�aman�za yard�mc� olabilir.\n\n" +
                " - �nsanlar�n ya�ad��� hastal�klar�n �o�u diyabet, Crohn hastal���, kanser ve kronik yorgunluk sendromu gibi iltihaplanma ile ilgilidir. Yo�urdun probiyotik bakterileri v�cuttaki iltihab� azaltmaya ve bu hastal�klarla ilgili riskleri veya etkilerini azaltmaya yard�mc� olabilir.\n\n" +
                " - Yo�urt tam bir protein kayna��d�r, yani v�cutta kas ve di�er dokular� olu�turmak i�in gerekli t�m amino asitleri i�erir.\n\n" +
                " - Yo�urt, kemik sa�l���nda kilit rol oynayan vitaminler ve mineraller bak�m�ndan zengindir. D�zenli olarak t�ketilmesi osteoporoz riskini azaltabilir.\n\n" +
                " - Yo�urt, �iyi� HDL kolesterol� art�r�p, kan bas�nc�n� d���rerek kalp sa�l���na fayda sa�lar.\n\n";
        }

        if (urun == "Yumurta")
        {
            baslik.text = " Yumurtan�n Faydalar� ";
            urunResmi.sprite = KeremResimler[61];

            konu.text = " - Yumurta i�erisinde y�ksek oranda ya� bulunuyor. Bu ya� ise kandaki iyi kolesterol� artmas�n� sa�l�yor. V�cutta bulunan iyi kolesterol ba�ta damar sistemi olmak �zere kalbin sa�l�kl� ve g��l� olmas�na yard�mc� oluyor.\n\n" +
                " - Yumurta son derece besleyici bir g�da olarak t�ketiliyor. D�zenli yumurta t�ketimi insan v�cudunda kemiklerin g��lenmesinde b�y�k rol al�yor. Bu �zelli�i ile b�y�meyi ve geli�meyi h�zland�r�yor. �lerleyen ya�larda kemik erimesi riskinin azalmas�nda etkili oluyor.\n\n" +
                " - Kaslar�n geli�mesine de destek veriyor. Kaslar�n geli�iminde etkili olan protein sayesinde v�cutta bulunan kas k�tlesinin artmas�na yard�mc� oluyor. �zellikle v�cut geli�tirme sporlar� ile birlikte yap�lan diyetlerde vazge�ilmez besin oluyor.\n\n" +
                " - Yumurta besleyici oldu�u kadar duyu organlar�n� g��lendirmesi ile de fayda sa�l�yor. G�zlerin sa�l�kl� olmas� ve iyi g�rmesine b�y�k fayda sa�l�yor.\n\n" +
                " - V�cudun ihtiya� duydu�u enerjiyi sa�l�yor. Hastal�klara kar�� diren�li olmas�n� sa�l�yor. Ba����kl�k sistemini g��lendiriyor.\n\n" +
                " - Ba����kl�k sistemini g��lendirmesi ve bedeni beslemesi ile kanser olma riskini azalt�yor. �zellikle de meme kanserine kar�� v�cudu koruyor.\n\n" +
                " - Beyin geli�imini kuvvetlendiriyor. Haf�za problemlerinin olu�ma riskini azalt�yor. Her ya�ta zihnin geli�mesini ve sa�l�kl� olmas�n� destekliyor.\n\n";
        }

        if(urun=="Yaban Mersini")
        {
            baslik.text = " Yaban Mersininin Faydalar� ";
            urunResmi.sprite = KeremResimler[62];

            konu.text = " - Yaban mersinine koyu mavi rengini veren antosiyanin kandaki serbest radikallerin at�lmas�na yard�mc� olur ve b�ylece v�cudu kanser de dahil olmak �zere �e�itli hastal�klara kar�� korur. Yaban mersininin d�zenli t�ketimi n�rodejeneratif hastal�klar ve sindirim hastal�klar�na kar�� da koruyucu olmaktad�r.\n\n" +
                " - Yaban mersini zengin antioksidan i�eri�i ile kolesterol seviyesini kontrol etmeye de yard�mc� olmaktad�r. �al��malar, bu bile�enlerin kan ya� dengesini iyile�tirmeye ve damarlar�n t�kanmas�n� �nlemeye yard�mc� oldu�unu ortaya koymu�tur. Ayr�ca, kan bas�nc�n� d���rmeye yard�mc� olarak kalp hastal�klar� riskini azalt�r. Bu nedenle yaban mersini kalbe iyi gelir ve kalp sa�l���n� destekler.\n\n" +
                " - Yaban mersini ba����kl�k sistemini g��lendirir. ��erisinde bulunan antosiyaninler gibi flavonoidlerin yan� s�ra y�ksek C ve E vitamini i�eri�iyle bakteri ve vir�slerin yay�lmas�n� �nler, b�ylece ba����kl�k sisteminin zay�flamas�n� engeller. Yaban mersini ayr�ca anti-inflamatuar �zelliklere sahiptir, �ks�r�k ve so�uk alg�nl��� riskini �nemli �l��de azaltabilir.\n\n" +
                " - Yaban mersini kan �ekerini d�zenler. D���k bir glisemik indeksine sahip oldu�u i�in diyabet ve ins�lin direnci gibi kan �ekeri ile ilgili sorunlardan muzdarip olanlar i�in faydal�d�r. Yaban mersini �eker seviyesinin d�zenlenmesine yard�mc� olur.\n\n" +
                " - Yaban mersini iyi bir vitamin, mineral ve lif kayna��d�r. Y�ksek C vitamini i�eri�iyle birlikte mineraller v�cut taraf�ndan daha iyi emilir ve kan olu�umunu ve h�crelere oksijen ta��nmas�n� destekler. Yaban mersini iyi bir diyet lifi kayna��d�r, sindirime yard�mc� olur ve ba��rsak sa��l��� �zerinde olumlu bir etkiye sahiptir.\n";
        }

        if(urun=="Yasemin �ay�")
        {
            baslik.text = " Yasemin �ay�n�n Faydalar� ";
            urunResmi.sprite = KeremResimler[63];

            konu.text = "\n - Yasemin �ay� y�ksek oranda antioksidan i�erir. Bunun yan�nda v�cudun ba����kl�k sistemini g��lendirir.\n\n" +
                " - K�t� huylu kanser h�crelerinin �remesini engeller.\n\n" +
                " - Kalp ve damar sa�l���n� geli�tirmede olduk�a etkilidir.\n\n" +
                " - Yasemin �ay� kokusu ile sinirlerinizi yat��t�r�r gerginli�inizi azalt�r.\n\n" +
                " - Kolesterol� dengede tutar ve kalp damar hastal�klar�na iyi gelir.\n\n" +
                " - G�zelli�e de katk�s� olan yasemin �ay� ya�lanma belirtilerini geciktirir.\n\n" +
                " - Diyabet hastal���n� �nlemek i�in birebirdir.\n\n" +
                " - ��erisinde bulunan antiviral ve anti bakteriyel �zellikle sayesinde grip ve so�uk alg�nl��� tedavisinde kullan�l�r.\n\n" +
                " - Metabolizmay� h�zland�r�r. Bu nedenle kilo verilmesine yard�mc� olur.\n\n" +
                " - Yasemin �ay� alg�lar�n�z� a�ar ve uyan�k kalman�z� sa�lar.\n";
        }

        if(urun=="Yer Elmas�")
        {
            baslik.text = " Yer Elmas�n�n Faydalar� ";
            urunResmi.sprite = KeremResimler[64];

            konu.text = "\n - Y�ksek A ve B vitamini i�erir.\n\n" +
                " - Afrodizyak etkisi bulunur.\n\n" +
                " - Halsizlik ve yorgunlu�u azalt�r.\n\n" +
                " - �drar s�kt�r�c�d�r.\n\n" +
                " - Sinir sistemini korur. Stresin etkilerini azalt�r, sakinle�tirir.\n\n" +
                " - Sindirim sistemini d�zenler. Kab�zl��a iyi gelir.\n\n" +
                " - Mide a�r�lar�n� hafifletir.\n\n" +
                " - Ba����kl�k sistemini g��lendirir.\n\n" +
                " - Yaralar�n iyile�mesini h�zland�r�r.\n\n" +
                " - Romatizma a�r�lar�n� hafifletir.\n\n" +
                " - D���k kalorilidir. Zay�flamak isteyenlerin kilo vermelerini destekler.\n\n" +
                " - Yer elmas�, �eker hastal��� �zerinde olumlu etkilere sahiptir. Kan �ekerini dengeler.\n\n" +
                " - Ni�asta i�ermez.\n\n";
        }

        if (urun == "Yan�k")
        {
            baslik.text = " Yan�k ";
            urunResmi.sprite = KeremResimler[65];

            konu.text = "\n YANIK DERECELER� NE DEMEKT�R\n\n\n  1. Derece Yan�k:\n- Bu k���k yan�k tipi, sadece cildin d�� tabakas�n� (epidermis) etkiler. K�zar�kl�k ve a�r�ya neden olabilir.\n\n" +
                "  2. Derece Yan�k:\n- Bu t�r yan�klar hem epidermisi, hem de ikinci deri tabakas�n� (dermis) etkiler. �i�meye, k�rm�z�, beyaz veya lekeli cilde neden olabilir. Kabarc�klar geli�ebilir ve a�r� �iddetli olabilir. Derin ikinci derece yan�klar, yara izine neden olabilir.\n\n" +
                "  3. Derece Yan�k:\n- Bilindi�i gibi cildin alt�nda bir ya� tabakas� bulunmaktad�r. Bu tip yan�klarda yan���n etkisi cildi de a�arak bu ya� tabakas�na ula��r. Cilt k�sele g�r�nt�s�ne b�r�n�r. ���nc� derece yan�klar, sinirleri yok ederek b�lgede hissizli�e ya da uyu�maya neden olabilir. Acil t�bbi m�dahale gerektirir.\n\n" +
                "  4. Derece Yan�k:\n- Kemik ve eklemlere kadar i�leyen yan�klard�r. Acil t�bbi m�dahale gerektirir.\n\n\n" +
                " YANI�A NE �Y� GEL�R?\n\n\n  Buzlu Olmayan So�uk Su\n\n - K���k bir yan�k ya�ad���n�zda yapman�z gereken ilk �ey, yakla��k 20 dakika boyunca yan�k alan�n �zerine serin su uygulamakt�r. Daha sonra yanm�� b�lgeyi yumu�ak sabun ve su ile y�kayabilirsiniz. Burada dikkat edilmesi gereken �ey suyun 0 dereceye yak�nl�kta so�uk olmamas�d�r. Serin su yeterlidir.\n\n\n" +
                "  Serin Kompresler\n\n - Yan�k b�lgesinin �zerine yerle�tirilen serin bir kompres veya temiz �slak bez, a�r�y� ve �i�meyi hafifletmeye yard�mc� olur. Serin kompresleri 5-15 dakikal�k aral�klarla uygulayabilirsiniz. A��r� so�uk kompresleri kullanmaya �al��may�n ��nk� bu yakla��m, yan�klar� daha fazla tahri� edebilir.\n\n\n" +
                "  Antibiyotikli Merhemler\n\n - Antibiyotikli merhemler ve kremler enfeksiyonlar� �nlemeye yard�mc� olur. Yan�klar�n�za antibiyotik i�eren ve yan�k i�in sat�lan �zel bir merhem uygulayabilir ve steril kal�n olmayan bir bezle �rtebilirsiniz. Steril gazl� bezler, bu ama� i�in olduk�a uygun olan pansuman yard�mc�lar�d�r.\n\n\n" +
                "  Aloe vera\n\n - Aloe vera, genellikle �yan�k bitkisi� olarak lanse edilir. �al��malar, aloe veran�n birinci ila ikinci derece yan�klar�n iyile�mesinde etkili oldu�una dair kan�tlar g�stermektedir. Aloe vera anti-enflamatuard�r. Dola��m� te�vik eder ve bakterilerin b�y�mesini engeller. Bir aloe vera bitkisinin yapra��ndan al�nan saf jeli, do�rudan etkilenen b�lgeye uygulay�n.\n\n\n" +
                "  Bal\n\n - Bal bir anti-enflamatuard�r ve do�al olarak antibakteriyel ve antifungaldir. Bu nedenle, eski zamanlardan beri yara ve yan�k tedavisinde kullan�lmaktad�r. Evinizde hi�bir merhem bulamad���n�z takdirde etkilenen b�lgeye ince bir tabaka saf bal uygulayabilirsiniz.\n\n";
                
        }
        #endregion

        //Z ile ba�layanlar
        #region Z ile baslayanlar
        if (urun == "Zeytin")
        {
            baslik.text = " Zeytinin Faydalar� ";
            urunResmi.sprite = KeremResimler[66];

            konu.text = "\n S�ND�R�M� KOLAYLA�TIRIR\n\n - Zeytinde bulunan E vitamini ve ya�, ba��rsaklar�n daha verimli i�lemesini sa�lar.\n\n" +
                " - Zeytinin yap�s�nda yer alan lifler, yedi�iniz yemeklerin kolayca sindirilmesini ger�ekle�tirir. B�ylece ba��rsak sorunlar�ndan epey uzak kalm�� olursunuz.\n\n" +
                " - Her g�n d�zenli olarak zeytin t�ketti�inizde, mide problemlerine kar�� �nlem alabilirsiniz.\n\n\n" +
                " SA�, C�LT ve TIRNAK ���N BESLEY�C�\n\n - Zeytin �z� ve zeytinya�� i�eren kozmetik �r�nlerini reklamlarda s�k�a g�rebilirsiniz ��te bu �r�nlerin ana maddesi; zeytinde bulunan vitamin ve minerallerdir.\n\n" +
                " - �ampuanlarda yer almas�n�n nedeni sa�lar�n ihtiyac� olan nemi kazand�rmakt�r.\n\n" +
                " - Sabun ve cilt kremlerinde ise; kolajen �retimini art�rd��� i�in h�cre yenilenmesini sa�lad��� i�in kullan�l�r.\n\n" +
                " - Zeytin, �l� h�crelerin at�lmas�n� ve yenilenmesini destekleyen do�al bir besindir.\n\n" +
                " - E vitaminleri sayesinde daha gen� ve sa�l�kl� g�r�nmenizi sa�lar.\n\n" +
                " - Ya�lanmay� ertelemek ya da kamufle etmek i�in ���nlerinize zeytin eklemeyi ihmal etmeyiniz.\n\n\n" +
                " KANSER� �NLER\n\n - Kansere neden olan her ne neden varsa; zeytin o fakt�rleri temizlemek i�in t�ketilebilir. ��nk� zeytinin yap�s�nda antioksidan maddeler yer al�r.\n\n" +
                " - Hasar g�ren h�creleri onar�r ve ki�inin eski sa�l���n� kazanmas� i�in yard�m eder.\n\n" +
                " - Zeytin t�keterek, h�cre zarlar�n�z� �mr�n�z boyunca koruma alt�na alm�� olursunuz.\n\n\n" +
                " UZUN S�RE TOK TUTAR\n\n - Diyet s�recinde kahvalt� ���n� �ok �nemlidir. Kahvalt�da alman�z gereken ya�� zeytinden alabilirsiniz.\n\n" +
                " - Sizi uzun s�re tok tutarken, metabolizman�n h�zlanmas�n� da sa�lar.\n\n" +
                " - Ara ���nlerde ortalama 5 adet zeytin yerseniz, uzun s�re a�l���n�z� bast�rabilirsiniz.\n\n\n" +
                " KALP SA�LI�INI KORUR\n\n - Zeytin, sizi kalp hastal�klar�ndan ve kalp krizinden koruyan bir besindir.\n\n" +
                " - Zeytin yap�s�nda doymam�� ya� bulundu�u i�in, kan bas�nc�n� dengeler ve kalp ritmini d�zenler.\n\n" +
                " - Kalp sa�l���n� koruma s�recinde yap�s�nda bulunan oleik asitten faydalan�r.\n\n\n" +
                " V�CUT GEL���M�NE DESTEK OLUR\n\n - A, D, E ve K vitaminleri yap�s�ndan zengin olan zeytin b�y�me �a��ndaki �ocuklar�n v�cut geli�imine destek olur.\n\n" +
                " - Daha g��l� kas ve kemik yap�s�n�n olu�mas�n� sa�lar.\n\n" +
                " - Beden geli�imini destekledi�i gibi zihin geli�imine de katk�da bulunur ��nk� zeytinde bolca omega ya� asitleri yer al�r.\n\n\n" +
                " KAN YAPAR\n\n - Zeytin, kans�zl�k problemi i�in tavsiye edilen besinlerden biridir.\n\n" +
                " - Kandaki demir oran�n� y�kselterek anemi hastal���n� ortadan kald�r�r.\n\n" +
                " - Kolesterol seviyeniz �ok y�ksek ��kt�ysa, en ideal rakama indirir.\n\n" ;
                
        }

        if (urun == "Zencefil")
        {
            baslik.text = " Zencefilin Faydalar� ";
            urunResmi.sprite = KeremResimler[67];

            konu.text = "\n - Mide ve ba��rsaklardaki gaz� s�kt�r�r.\n\n" +
                " - Kusmaya ve mide bulant�s�na kar�� son derece etkilidir.\n\n" +
                " - �shali ve ba��rsak bozukluklar�n� giderir.\n\n" +
                " - Ba����kl�k sistemini g��lendirir.\n\n" +
                " - Regl a�r�lar�n� azalt�r.\n\n" +
                " - �ks�r��� keser.\n\n" +
                " - Metabolizmay� h�zland�r�r ve i�tah a�ar.\n\n" +
                " - Kas a�r�lar�n� hafifletir.\n\n" +
                " - So�uk alg�nl���, grip ve bron�it gibi hastal�klar�n tedavisinde kullan�l�r.\n\n\n" +
                " NASIL T�KET�L�R\n\n - Zencefil genel olarak i�eceklerde, salatalarda ve �e�itli yemeklerde kullan�lmaktad�r. Zencefil toz �eklinde t�ketilebilir. Toz zencefil baharat olarak yemeklerin i�erisine, salatalara ve �e�itli i�eceklerin i�ine katarak t�ketilebilir." +
                " Ayr�ca kurabiyelerin ve �e�itli at��t�rmal�klar�n i�erisine de konulabilir. Fakat en yayg�n zencefil t�ketim �ekli �ay�n�n yap�lmas�d�r.";
                
        }

        if (urun == "Zerde�al")
        {
            baslik.text = " Zerde�al�n Faydalar� ";
            urunResmi.sprite = KeremResimler[68];

            konu.text = "\n �LT�HAP G�DER�C�D�R\n\n - Zerde�al, iltihap �nleyici yani anti-enflamatuard�r. Sahip oldu�u antioksidan �zellikten dolay� bakterilere kar�� sava��r ve h�crelerimizi korur. Zerde�al i�indeki k�rk�min sayesinde v�cudun iyile�mesine katk� sa�lar.\n\n\n" +
                " S�ND�R�M S�STEM�N� KORUR\n\n - D�zenli bir sindirim sistemine sahip olmak istiyorsan�z mutlaka zerde�al kullanmal�s�n�z. Zerde�al�n lifli yap�s� sindirim sistemini iyile�tirir. Zerde�al kab�zl��a iyi gelir. �i�kinlik ve gaz sorunu ya�ayanlar i�in de do�al bir tedavi y�ntemidir.\n\n\n" +
                " KANSERE KAR�I KORUMA SA�LAR\n\n - Yap�lan �al��malara g�re zerde�al i�erdi�i k�rk�min ile h�crelerin DNA�s�n�n bozulmas�n� engeller ve kansere kar�� korur. Kanser hastal���n�n tedavi s�recinde de kanser h�crelerinin artmas�n� yava�latt��� i�in tavsiye edilir.\n\n\n" +
                " DEPRESYONUN ETK�S�N� AZALTIR\n\n - Zerde�al i�inde bulundurdu�u B6 vitamini sayesinde seratonin hormonunun salg�lanmas�n� sa�lar. Yani zerde�al mutluluk verir. Depresyon ve melankoli ya��yorsan�z kendinizi daha iyi hissetmenize yard�mc� olur.\n\n\n" +
                " A�RI KES�C�D�R\n\n - A�r�y� azaltmada zerde�al �ok etkilidir. A�r� kesici ila�lar kullanmak yerine do�al ��z�mler istiyorsan�z zerde�al� deneyin. Kas ve eklem a�r�lar� ya�ayanlar, di� a�r�s� ya�ayanlar zerde�al kullanabilir. Di� a�r�n�z varsa bir �ay ka���� zerde�al, yar�m �ay ka���� tuzu �l�k suyla kar��t�rarak gargara yapabilirsiniz. Adet d�nemi a�r�lar� ya�ayan kad�nlara da �nerilir.\n\n\n" +
                " ALZHE�MER R�SK�N� AZALTIR\n\n - Alzheimer hastal���n�n kesin tedavisi g�n�m�zde bulunamam��t�r. Bu nedenle Alzheimer olu�madan �nlemler almak gerekir. Zerde�al�n unutkanl�k �zerine olumlu etkileri g�zlenmi�tir. Zerde�al t�ketimi hastal���n risklerini azaltacakt�r. Bunlara ek olarak, zerde�al odaklanma sorunu ya�ayanlara da iyi bir arkada� olabilir.\n\n\n" +
                " !!! D�KKAT !!!\n\n - Zerde�al �ifal� bir bitki olmas�na ra�men a��r� t�ketiminde mide bulant�s�, kalp �arp�nt�s�, kan sulanmas� gibi yan etkileri olabilir. �zel bir hastal��� olanlar�n t�ketmeden doktoruna dan��mas�n� tavsiye ederiz.\n";
        }

        if(urun=="Zemzem Suyu")
        {
            baslik.text = " Zemzem Suyunun Faydalar� ";
            urunResmi.sprite = KeremResimler[69];

            konu.text = "\n - Uykusuzluk problemi i�in birebir katk� sa�lar.\n\n" +
                " - Strese ba�l� gerginlik ve �fkeyi azalt�r.\n\n" +
                " - Depresyon ve benzeri psikolojik sorunlarda olduk�a etkilidir.\n\n" +
                " - B�brek yetmezli�i gibi problemlere kar�� yard�mc� oldu�u biliniyor.\n\n" +
                " - Akne ve sivilce ile beraber bir�ok cilt hastal��� i�in fayda sa�lar.\n\n" +
                " - Karaci�er hastal�klar�na kar�� tedavi y�ntemi olarak kullan�l�r.\n\n" +
                " - Kalp krizi riskini �nemli oranda azaltt��� bilinir.\n\n" +
                " - S�tma gibi hastal�klara kar�� ��z�m �retir.\n\n" +
                " - K���n cilt �zerinde uyguland��� zaman ���me problemini ortadan kald�r�r.\n";
        }

        if (urun == "Zehirlenme")
        {
            baslik.text = " Zehirlenme ";
            urunResmi.sprite = KeremResimler[70];

            konu.text = "\n ZEH�RLENME HANGi YOLLARLA MEYDANA GEL�R\n\n\n  Sindirim Yoluyla\n\n- En s�k rastlanan zehirlenme yoludur. Sindirim yoluyla al�nan zehirler genellikle ev ya da bah�ede kullan�lan kimyasal maddeler, zehirli mantarlar, bozuk besinler, ila� ve a��r� alkold�r.\n\n\n" +
                "  Solunum Yoluyla\n\n- Zehirli maddenin solunum yolu ile al�nmas�yla olu�ur. Genellikle karbon monoksit (t�p ka�aklar�, �ofben, b�tan gaz sobalar�), la��m �ukuru veya kayalarda biriken karbondioksit, havuz hijyeninde kullan�lan klor, yap��t�r�c�lar, boyalar ev temizleyicileri gibi maddeler ile olu�ur.\n\n\n" +
                "  Cilt Yoluyla\n\n- Zehirli madde v�cuda direk deri arac�l��� ile girer. Bu yolla olan zehirlenmeler b�cek sokmalar�, hayvan �s�r�klar�, ila� enjeksiyonlar�, sa� boyalar�, zirai ila�lar gibi zehirli maddelerin deriden emilmesi ile olu�ur.\n\n\n" +
                " S�ND�R�M YOLU �LE ZEH�RLENMELERDE �LKYARDIM\n\n - Bilin� kontrol� yap�l�r,\n\n" +
                " - A��z zehirli madde ile temas etmi�se su ile �alkalan�r, zehirli madde ele temas etmi�se el sabunlu su ile y�kan�r,\n\n" +
                " - Ya�am bulgular� de�erlendirilir,\n\n" +
                " - Kusma, bulant�, ishal gibi belirtiler de�erlendirilir,\n\n" +
                " - Kusturulmaya �al���lmaz, �zellikle yak�c� maddelerin al�nd��� durumlarda hasta asla kusturulmaz,\n\n" +
                " - Bilin� kayb� varsa koma pozisyonu verilir,\n\n" +
                " - �st� �rt�l�r,\n\n" +
                " - T�bbi yard�m istenir (112).\n\n" +
                " - Sindirim yolu ile olan zehirlenmelerde t�bbi m�dahaleye yard�mc� olmak i�in olayla ilgili bilgiler toplanarak kaydedilir.\n\n\n\n" +
                " SOLUNUM YOLU �LE ZEH�RLENMELERDE �LKYARDIM\n\n - Hasta temiz havaya ��kar�l�r ya da cam ve kap� a��larak ortam havaland�r�l�r,\n\n" +
                " - Ya�amsal belirtiler de�erlendirilir (ABC),\n\n" +
                " - Yar� oturur pozisyonda tutulur,\n\n" +
                " - Bilin� kapal� ise koma pozisyonu verilir,\n\n" +
                " - T�bbi yard�m istenir (112),\n\n" +
                " - �lkyard�mc� m�dahale s�ras�nda kendini ve �evresini korumak i�in gerekli �nlemleri almal�d�r,\n\n" +
                " - Solunumu korumak i�in maske veya �slak bez kullan�l�r,\n\n" +
                " - Elektrik d��meleri ve di�er elektrikli aletler ve ���kland�rma cihazlar� kullan�lmaz,\n\n" +
                " - Yo�un duman varsa hastay� d��ar� ��karmak i�in ip kullan�lmal�d�r,\n\n" +
                " - Derhal itfaiyeye haber verilir (110).\n\n\n" +
                " C�LT YOLU �LE ZEH�RLENMELERDE �LKYARDIM\n\n - Ya�am bulgular� de�erlendirilir,\n\n" +
                " - Ellerin zehirli madde ile temas� �nlenmelidir,\n\n" +
                " - Zehir bula�m�� giysiler ��kart�l�r,\n\n" +
                " - 15�20 dakika boyunca deri bol suyla y�kanmal�d�r,\n\n" +
                " - T�bbi yard�m istenir (112).\n";

        }
        #endregion
    }


   
}
  

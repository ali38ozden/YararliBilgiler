using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class ortakScript : MonoBehaviour
{
    public Image Bilgibackground;
    public GameObject keremPrefab, aliPrefab, burakPrefab, konum;
    
   

    public string urunisim;

    burak _burak;
    ali _ali;
    kerem _kerem;
    

    private void Awake()
    {
        _burak = Object.FindObjectOfType<burak>();
        _ali = Object.FindObjectOfType<ali>();
        _kerem = Object.FindObjectOfType<kerem>();
        
        

        //ALFABETÝK

        // A
        #region A ile baslayanlar
        GameObject Aðýz_Kokusu = Instantiate(aliPrefab, konum.transform); Tanlimla(Aðýz_Kokusu, "Aðýz Kokusu");
        GameObject Aðýz_Yarasi = Instantiate(aliPrefab, konum.transform); Tanlimla(Aðýz_Yarasi, "Aðýz Yarasý");
        GameObject Aðlamanin_Zararlari = Instantiate(aliPrefab, konum.transform); Tanlimla(Aðlamanin_Zararlari, "Aðlamanýn Zararlarý");       
        GameObject Akciðer = Instantiate(aliPrefab, konum.transform); Tanlimla(Akciðer, "Akciðer");
        GameObject Akraba_Evliliði = Instantiate(aliPrefab, konum.transform); Tanlimla(Akraba_Evliliði, "Akraba Evliliði");
        GameObject Akrep_Sokmasý = Instantiate(aliPrefab, konum.transform); Tanlimla(Akrep_Sokmasý, "Akrep Sokmasý");
        GameObject Alkolizm = Instantiate(aliPrefab, konum.transform); Tanlimla(Alkolizm, "Alkolizm");
        GameObject Ananas = Instantiate(burakPrefab, konum.transform); Tanlimla(Ananas, "Ananas");
        GameObject Apse = Instantiate(aliPrefab, konum.transform); Tanlimla(Apse, "Apse");
        GameObject Ari_Sokmasý = Instantiate(aliPrefab, konum.transform); Tanlimla(Ari_Sokmasý, "Arý Sokmasý");
        GameObject Armut = Instantiate(keremPrefab, konum.transform); Tanlimla(Armut, "Armut");
        GameObject Arpa = Instantiate(aliPrefab, konum.transform); Tanlimla(Arpa, "Arpa");
        GameObject Astim = Instantiate(aliPrefab, konum.transform); Tanlimla(Astim, "Astým");
        GameObject AyakMantari = Instantiate(aliPrefab, konum.transform); Tanlimla(AyakMantari, "Ayak Mantarý");
        GameObject Ayva = Instantiate(aliPrefab, konum.transform); Tanlimla(Ayva, "Ayva");
        GameObject Az_Yemek = Instantiate(aliPrefab, konum.transform); Tanlimla(Az_Yemek, "Az Yemek");
        #endregion

        // B
        #region B ile baslayanlar
        GameObject Badem = Instantiate(aliPrefab, konum.transform); Tanlimla(Badem, "Badem");
        GameObject Baðirsak = Instantiate(aliPrefab, konum.transform); Tanlimla(Baðirsak, "Baðýrsak");
        GameObject Bal = Instantiate(aliPrefab, konum.transform); Tanlimla(Bal, "Bal");
        GameObject Balýk = Instantiate(aliPrefab, konum.transform); Tanlimla(Balýk, "Balýk");
        GameObject Baþ_Aðrýsý = Instantiate(aliPrefab, konum.transform); Tanlimla(Baþ_Aðrýsý, "Baþ Aðrýsý");
        GameObject Baþ_Dönmesi = Instantiate(aliPrefab, konum.transform); Tanlimla(Baþ_Dönmesi, "Baþ Dönmesi");
        GameObject Bel_Agrisi = Instantiate(aliPrefab, konum.transform); Tanlimla(Bel_Agrisi, "Bel Aðrýsý");
        GameObject Beyin = Instantiate(aliPrefab, konum.transform); Tanlimla(Beyin, "Beyin");
        GameObject Bit = Instantiate(aliPrefab, konum.transform); Tanlimla(Bit, "Bit");
        GameObject Bogaz_Arisi = Instantiate(aliPrefab, konum.transform); Tanlimla(Bogaz_Arisi, "Boðaz Aðrýsý");
        GameObject Boðaz_Týkanmasý = Instantiate(aliPrefab, konum.transform); Tanlimla(Boðaz_Týkanmasý, "Boðaz Týkanmasý");
        GameObject Böbrek_Hastalýklarýnýn_Belirtileri = Instantiate(aliPrefab, konum.transform); Tanlimla(Böbrek_Hastalýklarýnýn_Belirtileri, "Böbrek Hastalýklarýnýn Belirtileri");
        GameObject Böbrek_Taþý = Instantiate(aliPrefab, konum.transform); Tanlimla(Böbrek_Taþý, "Böbrek Taþý");
        GameObject Buhur = Instantiate(aliPrefab, konum.transform); Tanlimla(Buhur, "Buhur");
        GameObject Bulantý = Instantiate(aliPrefab, konum.transform); Tanlimla(Bulantý, "Bulantý");
        GameObject Bunamak = Instantiate(aliPrefab, konum.transform); Tanlimla(Bunamak, "Bunamak");
        GameObject Buruna_Kanamasý = Instantiate(aliPrefab, konum.transform); Tanlimla(Buruna_Kanamasý, "Burun Kanamasý");
        GameObject Burun_týkanýklýgý = Instantiate(aliPrefab, konum.transform); Tanlimla(Burun_týkanýklýgý, "Burun Týkanýklýðý");
        GameObject Büyü = Instantiate(aliPrefab, konum.transform); Tanlimla(Büyü, "Büyü");
        #endregion

        // C 
        #region C ile baslayanlar
        GameObject Cenin = Instantiate(aliPrefab, konum.transform); Tanlimla(Cenin, "Cenin");
        GameObject Cerrah = Instantiate(aliPrefab, konum.transform); Tanlimla(Cerrah, "Cerrah");
        GameObject Ceviz = Instantiate(burakPrefab, konum.transform); Tanlimla(Ceviz, "Ceviz");
        GameObject Chia = Instantiate(burakPrefab, konum.transform); Tanlimla(Chia, "Chia");
        GameObject Cilt = Instantiate(aliPrefab, konum.transform); Tanlimla(Cilt, "Cilt");
        GameObject CiltHastalýgý = Instantiate(aliPrefab, konum.transform); Tanlimla(CiltHastalýgý, "Cilt Hastalýðý");
        GameObject Civit_Otu = Instantiate(aliPrefab, konum.transform); Tanlimla(Civit_Otu, "Civit Otu");
        GameObject Cucelik = Instantiate(aliPrefab, konum.transform); Tanlimla(Cucelik, "Cücelik");
        GameObject Cuzzam = Instantiate(aliPrefab, konum.transform); Tanlimla(Cuzzam, "Cüzzam");
        #endregion

        // Ç 
        #region Ç ile baslayanlar
        GameObject CakalKavunu = Instantiate(aliPrefab, konum.transform); Tanlimla(CakalKavunu, "Çakal Kavunu");
        GameObject CamFýstýgý = Instantiate(aliPrefab, konum.transform); Tanlimla(CamFýstýgý, "Çam Fýstýðý");
        GameObject CamurlaTedavi = Instantiate(aliPrefab, konum.transform); Tanlimla(CamurlaTedavi, "Çamurla Tedavi");
        GameObject Carpik = Instantiate(aliPrefab, konum.transform); Tanlimla(Carpik, "Çarpýk");
        GameObject Catlak = Instantiate(aliPrefab, konum.transform); Tanlimla(Catlak, "Çatlak");
        GameObject CemenOtu = Instantiate(aliPrefab, konum.transform); Tanlimla(CemenOtu, "Çemen Otu");
        GameObject Cýkýk = Instantiate(aliPrefab, konum.transform); Tanlimla(Cýkýk, "Çýkýk");
        GameObject CicekHastalýgý = Instantiate(aliPrefab, konum.transform); Tanlimla(CicekHastalýgý, "Çiçek Hastalýðý");
        GameObject Çilek = Instantiate(aliPrefab, konum.transform); Tanlimla(Çilek, "Çilek");
        GameObject Cok_Yemek = Instantiate(aliPrefab, konum.transform); Tanlimla(Cok_Yemek, "Çok Yemek");
        GameObject Çörek_Otu = Instantiate(aliPrefab, konum.transform); Tanlimla(Çörek_Otu, "Çörek Otu");
        GameObject Coven_Otu = Instantiate(aliPrefab, konum.transform); Tanlimla(Coven_Otu, "Çöven Otu");
        #endregion

        // D 
        #region D ile baslayanlar
        GameObject Dalak = Instantiate(aliPrefab, konum.transform); Tanlimla(Dalak, "Dalak");
        GameObject Damar = Instantiate(aliPrefab, konum.transform); Tanlimla(Damar, "Damar");
        GameObject Damar_Sertligi = Instantiate(aliPrefab, konum.transform); Tanlimla(Damar_Sertligi, "Damar Sertliði");
        GameObject Deniz_Suyu = Instantiate(aliPrefab, konum.transform); Tanlimla(Deniz_Suyu, "Deniz Suyu");
        GameObject Depresyon = Instantiate(aliPrefab, konum.transform); Tanlimla(Depresyon, "Depresyon");
        GameObject Deve_Hastalýgý = Instantiate(aliPrefab, konum.transform); Tanlimla(Deve_Hastalýgý, "Deve Hastalýðý");
        GameObject Dil = Instantiate(aliPrefab, konum.transform); Tanlimla(Dil, "Dil");
        GameObject Dilcik = Instantiate(aliPrefab, konum.transform); Tanlimla(Dilcik, "Dilcik");
        GameObject Diþ = Instantiate(aliPrefab, konum.transform); Tanlimla(Diþ, "Diþ");
        GameObject Diþ_Törpüleme = Instantiate(aliPrefab, konum.transform); Tanlimla(Diþ_Törpüleme, "Diþ Törpüleme");
        GameObject Doðum = Instantiate(aliPrefab, konum.transform); Tanlimla(Doðum, "Doðum");
        GameObject Dolama = Instantiate(aliPrefab, konum.transform); Tanlimla(Dolama, "Dolama");
        GameObject Dolunay = Instantiate(aliPrefab, konum.transform); Tanlimla(Dolunay, "Dolunay");
        GameObject Dudak = Instantiate(aliPrefab, konum.transform); Tanlimla(Dudak, "Dudak");
        GameObject Dut = Instantiate(aliPrefab, konum.transform); Tanlimla(Dut, "Dut");
        GameObject Düz_Taban = Instantiate(aliPrefab, konum.transform); Tanlimla(Düz_Taban, "Düz Taban");
        #endregion

        // E 
        #region E ile baslayanlar
        GameObject Ebe_Gümeci = Instantiate(aliPrefab, konum.transform); Tanlimla(Ebe_Gümeci, "Ebe Gümeci");
        GameObject Ebu_Cehil_Karpuzu = Instantiate(aliPrefab, konum.transform); Tanlimla(Ebu_Cehil_Karpuzu, "Ebu Cehil Karpuzu");
        GameObject Egzama = Instantiate(aliPrefab, konum.transform); Tanlimla(Egzama, "Egzama");
        GameObject Eklem = Instantiate(aliPrefab, konum.transform); Tanlimla(Eklem, "Eklem Aðrýsý");
        GameObject Ekmek = Instantiate(aliPrefab, konum.transform); Tanlimla(Ekmek, "Ekmek");
        GameObject Elma = Instantiate(aliPrefab, konum.transform); Tanlimla(Elma, "Elma");
        GameObject Epilepsi = Instantiate(aliPrefab, konum.transform); Tanlimla(Epilepsi, "Epilepsi");
        GameObject Erik = Instantiate(aliPrefab, konum.transform); Tanlimla(Erik, "Erik");
        GameObject Esnemek = Instantiate(aliPrefab, konum.transform); Tanlimla(Esnemek, "Esnemek");
        GameObject Estetik_Ameliyatý = Instantiate(aliPrefab, konum.transform); Tanlimla(Estetik_Ameliyatý, "Estetik Ameliyatý");
        GameObject Et = Instantiate(aliPrefab, konum.transform); Tanlimla(Et, "Et");
        GameObject Etli_Çorba = Instantiate(aliPrefab, konum.transform); Tanlimla(Etli_Çorba, "Etli Çorba");
        GameObject Evham = Instantiate(aliPrefab, konum.transform); Tanlimla(Evham, "Evham");
        #endregion

        // F 
        #region F ile baslayanlar
        GameObject FareKulaðý = Instantiate(aliPrefab, konum.transform); Tanlimla(FareKulaðý, "FareKulaðý");
        GameObject Felç = Instantiate(aliPrefab, konum.transform); Tanlimla(Felç, "Felç");
        GameObject Fýndýk = Instantiate(aliPrefab, konum.transform); Tanlimla(Fýndýk, "Fýndýk");
        GameObject Fýtýk = Instantiate(aliPrefab, konum.transform); Tanlimla(Fýtýk, "Fýstýk");
        GameObject FilHastalýðý = Instantiate(aliPrefab, konum.transform); Tanlimla(FilHastalýðý, "Fil Hastalýðý");
        GameObject FizikTedavi = Instantiate(aliPrefab, konum.transform); Tanlimla(FizikTedavi, "Fizik Tedavi");
        #endregion

        // G 
        #region G ile baslayanlar
        GameObject Gargara = Instantiate(aliPrefab, konum.transform); Tanlimla(Gargara, "Gargara");
        GameObject Gasil = Instantiate(aliPrefab, konum.transform); Tanlimla(Gasil, "Gasil");
        GameObject GebreOtu = Instantiate(aliPrefab, konum.transform); Tanlimla(GebreOtu, "Gebre Otu");
        GameObject GeceKorlugu = Instantiate(aliPrefab, konum.transform); Tanlimla(GeceKorlugu, "Gece Körlüðü");
        GameObject Geðirmek = Instantiate(aliPrefab, konum.transform); Tanlimla(Geðirmek, "Geðirmek");
        GameObject Göbek = Instantiate(aliPrefab, konum.transform); Tanlimla(Göbek, "Göbek");
        GameObject Göðüs = Instantiate(aliPrefab, konum.transform); Tanlimla(Göðüs, "Göðüs");
        GameObject Göz = Instantiate(aliPrefab, konum.transform); Tanlimla(Göz, "Göz Deðmesi");
        GameObject Göz_Yaþý = Instantiate(aliPrefab, konum.transform); Tanlimla(Göz_Yaþý, "Göz Yaþý");
        GameObject Gül = Instantiate(aliPrefab, konum.transform); Tanlimla(Gül, "Gül");
        GameObject Gülmek = Instantiate(aliPrefab, konum.transform); Tanlimla(Gülmek, "Gülmek");
        GameObject Gümüþ = Instantiate(aliPrefab, konum.transform); Tanlimla(Gümüþ, "Gümüþ");
        GameObject Güneþ_Iþýðý = Instantiate(aliPrefab, konum.transform); Tanlimla(Güneþ_Iþýðý, "Güneþ");
        #endregion

        // H
        #region H ile baslayanlar
        GameObject Hacamat = Instantiate(aliPrefab, konum.transform); Tanlimla(Hacamat, "Hacamat");
        GameObject Hafýza = Instantiate(aliPrefab, konum.transform); Tanlimla(Hafýza, "Hafýza");
        GameObject Hamam = Instantiate(aliPrefab, konum.transform); Tanlimla(Hamam, "Hamam");
        GameObject Hamam_Otu = Instantiate(aliPrefab, konum.transform); Tanlimla(Hamam_Otu, "Hamam Otu");
        GameObject Hapþýrmak = Instantiate(aliPrefab, konum.transform); Tanlimla(Hapþýrmak, "Hapþýrmak");
        GameObject Hurma = Instantiate(aliPrefab, konum.transform); Tanlimla(Hurma, "Hurma");
        #endregion

        // I (yok)


        // Ý
        #region Ý ile baslayanlar
        GameObject Ýncir = Instantiate(burakPrefab, konum.transform); Tanlimla(Ýncir, "Ýncir");
        #endregion

        // J (yok)


        // K 
        #region K ile baslayanlar
        GameObject Kaju = Instantiate(aliPrefab, konum.transform); Tanlimla(Kaju, "Kaju");
        GameObject Kakao = Instantiate(burakPrefab, konum.transform); Tanlimla(Kakao, "Kakao");
        GameObject Kabak = Instantiate(burakPrefab, konum.transform); Tanlimla(Kabak, "Kabak");
        GameObject Kabýzlýk = Instantiate(burakPrefab, konum.transform); Tanlimla(Kabýzlýk, "Kabýzlýk");
        GameObject Kafur = Instantiate(burakPrefab, konum.transform); Tanlimla(Kafur, "Kafur");
        GameObject Kalp_Çarpýntýsý = Instantiate(burakPrefab, konum.transform); Tanlimla(Kalp_Çarpýntýsý, "Kalp Çarpýntýsý");
        GameObject Kan = Instantiate(burakPrefab, konum.transform); Tanlimla(Kan, "Kan");
        GameObject Kan_Vermek = Instantiate(burakPrefab, konum.transform); Tanlimla(Kan_Vermek, "Kan Vermek");
        GameObject Kan_Tükürmek = Instantiate(burakPrefab, konum.transform); Tanlimla(Kan_Tükürmek, "Kan Tükürmek");
        GameObject Kangren = Instantiate(burakPrefab, konum.transform); Tanlimla(Kangren, "Kangren");
        GameObject Kanser = Instantiate(burakPrefab, konum.transform); Tanlimla(Kanser, "Kanser");
        GameObject Kansýzlýk = Instantiate(burakPrefab, konum.transform); Tanlimla(Kansýzlýk, "Kansýzlýk");
        GameObject Karabiber = Instantiate(burakPrefab, konum.transform); Tanlimla(Karabiber, "Karabiber");
        GameObject Karaciðer_Saðlýðý = Instantiate(burakPrefab, konum.transform); Tanlimla(Karaciðer_Saðlýðý, "Karaciðer Saðlýðý");
        GameObject Karaçiçek = Instantiate(burakPrefab, konum.transform); Tanlimla(Karaçiçek, "Karaçiçek");
        GameObject Karanfil = Instantiate(burakPrefab, konum.transform); Tanlimla(Karanfil, "Karanfil");
        GameObject Karasinek = Instantiate(burakPrefab, konum.transform); Tanlimla(Karasinek, "Karasinek");
        GameObject Karýn_Aðrýsý = Instantiate(burakPrefab, konum.transform); Tanlimla(Karýn_Aðrýsý, "Karýn Aðrýsý");
        GameObject Karpuz = Instantiate(burakPrefab, konum.transform); Tanlimla(Karpuz, "Karpuz");
        GameObject Kaþýntý = Instantiate(burakPrefab, konum.transform); Tanlimla(Kaþýntý, "Kaþýntý");
        GameObject Katarakt = Instantiate(burakPrefab, konum.transform); Tanlimla(Katarakt, "Katarakt");
        GameObject Katran = Instantiate(burakPrefab, konum.transform); Tanlimla(Katran, "Katran");
        GameObject Kavun = Instantiate(aliPrefab, konum.transform); Tanlimla(Kavun, "Kavun");
        GameObject Kayýsý = Instantiate(burakPrefab, konum.transform); Tanlimla(Kayýsý, "Kayýsý");
        GameObject Kaymak = Instantiate(burakPrefab, konum.transform); Tanlimla(Kaymak, "Kaymak");
        GameObject Keçiboynuzu = Instantiate(burakPrefab, konum.transform); Tanlimla(Keçiboynuzu, "Keçiboynuzu");
        GameObject Kekemelik = Instantiate(burakPrefab, konum.transform); Tanlimla(Kekemelik, "Kekemelik");
        GameObject Kekik = Instantiate(burakPrefab, konum.transform); Tanlimla(Kekik, "Kekik");
        GameObject Kellik = Instantiate(burakPrefab, konum.transform); Tanlimla(Kellik, "Kellik");
        GameObject Kemik = Instantiate(burakPrefab, konum.transform); Tanlimla(Kemik, "Kemik");
        GameObject Kepek = Instantiate(burakPrefab, konum.transform); Tanlimla(Kepek, "Kepek");
        GameObject Kereviz = Instantiate(burakPrefab, konum.transform); Tanlimla(Kereviz, "Kereviz");
        GameObject Kýna = Instantiate(burakPrefab, konum.transform); Tanlimla(Kýna, "Kýna");
        GameObject Kýna_Çiçeði = Instantiate(burakPrefab, konum.transform); Tanlimla(Kýna_Çiçeði, "Kýna Çiçeði");
        GameObject Kýrýk = Instantiate(burakPrefab, konum.transform); Tanlimla(Kýrýk, "Kýrýk");
        GameObject Kiraz = Instantiate(aliPrefab, konum.transform); Tanlimla(Kiraz, "Kiraz");
        GameObject Kirmizi_Mercimek = Instantiate(keremPrefab, konum.transform); Tanlimla(Kirmizi_Mercimek, "Kýrmýzý Mercimek");
        GameObject Kýrmýzý_Soðan = Instantiate(aliPrefab, konum.transform); Tanlimla(Kýrmýzý_Soðan, "Kýrmýzý Soðan");
        GameObject Kýsýrlýk = Instantiate(burakPrefab, konum.transform); Tanlimla(Kýsýrlýk, "Kýsýrlýk");
        GameObject Kýzamýk = Instantiate(burakPrefab, konum.transform); Tanlimla(Kýzamýk, "Kýzamýk");
        GameObject Kimyon = Instantiate(burakPrefab, konum.transform); Tanlimla(Kimyon, "Kimyon");
        GameObject Kolera = Instantiate(burakPrefab, konum.transform); Tanlimla(Kolera, "Kolera");
        GameObject Köselik = Instantiate(burakPrefab, konum.transform); Tanlimla(Köselik, "Köselik");
        GameObject Kuduz = Instantiate(burakPrefab, konum.transform); Tanlimla(Kuduz, "Kuduz");
        GameObject Kulak_Çýnlamasý = Instantiate(burakPrefab, konum.transform); Tanlimla(Kulak_Çýnlamasý, "Kulak Çýnlamasý");
        GameObject Kulunç_Aðrýsý = Instantiate(burakPrefab, konum.transform); Tanlimla(Kulunç_Aðrýsý, "Kulunç Aðrýsý");
        GameObject Kum_Banyosu = Instantiate(burakPrefab, konum.transform); Tanlimla(Kum_Banyosu, "Kum Banyosu");
        GameObject Kurdeþen = Instantiate(burakPrefab, konum.transform); Tanlimla(Kurdeþen, "Kurdeþen");
        GameObject Kuru_Fasulye = Instantiate(aliPrefab, konum.transform); Tanlimla(Kuru_Fasulye, "Kuru Fasülye");
        GameObject Kurutulmus_Et = Instantiate(aliPrefab, konum.transform); Tanlimla(Kurutulmus_Et, "Kurutulmuþ Et");
        GameObject Kuru_Üzüm = Instantiate(burakPrefab, konum.transform); Tanlimla(Kuru_Üzüm, "Kuru Üzüm");
        GameObject Kuþkonmaz = Instantiate(burakPrefab, konum.transform); Tanlimla(Kuþkonmaz, "Kuþkonmaz");
        GameObject Kuyruk_Yaðý = Instantiate(burakPrefab, konum.transform); Tanlimla(Kuyruk_Yaðý, "Kuyruk Yaðý");
        #endregion

        // L
        #region L ile baslayanlar
        GameObject Lahana = Instantiate(keremPrefab, konum.transform); Tanlimla(Lahana, "Lahana");
        GameObject Lavman = Instantiate(keremPrefab, konum.transform); Tanlimla(Lavman, "Lavman");
        GameObject L_Carnitine = Instantiate(burakPrefab, konum.transform); Tanlimla(L_Carnitine, "L-Karnitin");
        GameObject Limon = Instantiate(aliPrefab, konum.transform); Tanlimla(Limon, "Limon");
        #endregion

        // M 
        #region M ile baslayanlar
        GameObject Mandalina = Instantiate(keremPrefab, konum.transform); Tanlimla(Mandalina, "Mandalina");
        GameObject Mango = Instantiate(burakPrefab, konum.transform); Tanlimla(Mango, "Mango");
        GameObject Mantar = Instantiate(keremPrefab, konum.transform); Tanlimla(Mantar, "Mantar");
        GameObject Marul = Instantiate(keremPrefab, konum.transform); Tanlimla(Marul, "Marul");
        GameObject Masaj = Instantiate(keremPrefab, konum.transform); Tanlimla(Masaj, "Masaj");
        GameObject Menekse = Instantiate(keremPrefab, konum.transform); Tanlimla(Menekse, "Menekþe");
        GameObject Mersin_Yapragi = Instantiate(keremPrefab, konum.transform); Tanlimla(Mersin_Yapragi, "Mersin Yapraðý");
        GameObject Mesane_Hastaliklari = Instantiate(keremPrefab, konum.transform); Tanlimla(Mesane_Hastaliklari, "Mesane Hastalýklarý");
        GameObject Mevsimler = Instantiate(keremPrefab, konum.transform); Tanlimla(Mevsimler, "Mevsimler");
        GameObject Meyan_Koku = Instantiate(keremPrefab, konum.transform); Tanlimla(Meyan_Koku, "Meyan Kökü");
        GameObject Meyve_Suyu = Instantiate(keremPrefab, konum.transform); Tanlimla(Meyve_Suyu, "Meyve Suyu");
        GameObject Mide_Rahatsizligi = Instantiate(keremPrefab, konum.transform); Tanlimla(Mide_Rahatsizligi, "Mide Rahatsýzlýðý");
        GameObject Misk_Otu = Instantiate(keremPrefab, konum.transform); Tanlimla(Misk_Otu, "Misk Otu");
        GameObject Misvak = Instantiate(keremPrefab, konum.transform); Tanlimla(Misvak, "Misvak");
        GameObject Mushil = Instantiate(keremPrefab, konum.transform); Tanlimla(Mushil, "Müshil");
        GameObject Muz = Instantiate(burakPrefab, konum.transform); Tanlimla(Muz, "Muz");
        #endregion

        // N
        #region N ile baslayanlar
        GameObject Nane = Instantiate(keremPrefab, konum.transform); Tanlimla(Nane, "Nane");
        GameObject Nar = Instantiate(aliPrefab, konum.transform); Tanlimla(Nar, "Nar");
        GameObject Nasir = Instantiate(keremPrefab, konum.transform); Tanlimla(Nasir, "Nasýr");
        GameObject Nefes_Darligi = Instantiate(keremPrefab, konum.transform); Tanlimla(Nefes_Darligi, "Nefes Darlýðý");
        GameObject Nektarin = Instantiate(keremPrefab, konum.transform); Tanlimla(Nektarin, "Nektarin");
        GameObject Nergis_Cicegi = Instantiate(keremPrefab, konum.transform); Tanlimla(Nergis_Cicegi, "Nergis Çiçeði");
        GameObject Nezle = Instantiate(keremPrefab, konum.transform); Tanlimla(Nezle, "Nezle");
        GameObject Nilufer_Cicegi = Instantiate(keremPrefab, konum.transform); Tanlimla(Nilufer_Cicegi, "Nilüfer Çiçeði");
        GameObject Nohut = Instantiate(keremPrefab, konum.transform); Tanlimla(Nohut, "Nohut");
        #endregion

        // O
        #region O ile baslayanlar
        GameObject Ogul_Otu = Instantiate(keremPrefab, konum.transform); Tanlimla(Ogul_Otu, "Oðul Otu");
        GameObject Omega_3 = Instantiate(burakPrefab, konum.transform); Tanlimla(Omega_3, "Omega 3");
        GameObject Organ_Bagisi = Instantiate(keremPrefab, konum.transform); Tanlimla(Organ_Bagisi, "Organ Baðýþý");
        GameObject Oruc = Instantiate(keremPrefab, konum.transform); Tanlimla(Oruc, "Oruç Tutmak");
        #endregion

        // Ö 
        #region ö ile baslayanlar
        GameObject Od_Agaci = Instantiate(keremPrefab, konum.transform); Tanlimla(Od_Agaci, "Öd Aðacý");
        GameObject Ofke = Instantiate(keremPrefab, konum.transform); Tanlimla(Ofke, "Öfke");
        GameObject Okse_Otu = Instantiate(keremPrefab, konum.transform); Tanlimla(Okse_Otu, "Ökse Otu");
        GameObject Oksuruk_Otu = Instantiate(keremPrefab, konum.transform); Tanlimla(Oksuruk_Otu, "Öksürük Otu");
        #endregion

        // P
        #region P ile baslayanlar
        GameObject Pamukcuk_Hastaligi = Instantiate(keremPrefab, konum.transform); Tanlimla(Pamukcuk_Hastaligi, "Pamukçuk Hastalýðý");
        GameObject Papatya_Cayi = Instantiate(keremPrefab, konum.transform); Tanlimla(Papatya_Cayi, "Papatya Çayý");
        GameObject Parmak_Emme = Instantiate(keremPrefab, konum.transform); Tanlimla(Parmak_Emme, "Parmak Emme");
        GameObject Patates = Instantiate(keremPrefab, konum.transform); Tanlimla(Patates, "Patates");
        GameObject Patlican = Instantiate(keremPrefab, konum.transform); Tanlimla(Patlican, "Patlýcan");
        GameObject Pazi = Instantiate(keremPrefab, konum.transform); Tanlimla(Pazi, "Pazý");
        GameObject Pekmez = Instantiate(keremPrefab, konum.transform); Tanlimla(Pekmez, "Pekmez");
        GameObject Perhiz = Instantiate(keremPrefab, konum.transform); Tanlimla(Perhiz, "Perhiz");
        GameObject Peynir = Instantiate(keremPrefab, konum.transform); Tanlimla(Peynir, "Peynir");
        GameObject Pirasa = Instantiate(keremPrefab, konum.transform); Tanlimla(Pirasa, "Pýrasa");
        GameObject Pirinc = Instantiate(keremPrefab, konum.transform); Tanlimla(Pirinc, "Pirinç");
        GameObject Portakal = Instantiate(aliPrefab, konum.transform); Tanlimla(Portakal, "Portakal");
        #endregion

        // R 
        #region R ile baslayanlar
        GameObject Reyhan = Instantiate(keremPrefab, konum.transform); Tanlimla(Reyhan, "Reyhan Bitkisi");
        GameObject Rezene_Cayi = Instantiate(keremPrefab, konum.transform); Tanlimla(Rezene_Cayi, "Rezene Çayý");
        GameObject Roka = Instantiate(keremPrefab, konum.transform); Tanlimla(Roka, "Roka");
        GameObject Romatizma = Instantiate(keremPrefab, konum.transform); Tanlimla(Romatizma, "Romatizma");
        #endregion

        // S 
        #region S ile baslayanlar
        GameObject Saç_Kýran = Instantiate(burakPrefab, konum.transform); Tanlimla(Saç_Kýran, "Saç Kýran");
        GameObject Safra = Instantiate(burakPrefab, konum.transform); Tanlimla(Safra, "Safra");
        GameObject Safran = Instantiate(burakPrefab, konum.transform); Tanlimla(Safran, "Safran");
        GameObject Sakýz = Instantiate(burakPrefab, konum.transform); Tanlimla(Sakýz, "Sakýz");
        GameObject Salatalýk = Instantiate(aliPrefab, konum.transform); Tanlimla(Salatalýk, "Salatalýk");
        GameObject Sarhoþluk = Instantiate(burakPrefab, konum.transform); Tanlimla(Sarhoþluk, "Sarhoþluk");
        GameObject Sarýlýk = Instantiate(burakPrefab, konum.transform); Tanlimla(Sarýlýk, "Sarýlýk");
        GameObject Sarýmsak = Instantiate(burakPrefab, konum.transform); Tanlimla(Sarýmsak, "Sarýmsak");
        GameObject Sedef_Hastalýðý = Instantiate(burakPrefab, konum.transform); Tanlimla(Sedef_Hastalýðý, "Sedef Hastalýðý");
        GameObject Sedir_Aðacý = Instantiate(burakPrefab, konum.transform); Tanlimla(Sedir_Aðacý, "Sedir Aðacý");
        GameObject Semizotu = Instantiate(burakPrefab, konum.transform); Tanlimla(Semizotu, "Semizotu");
        GameObject Serum = Instantiate(burakPrefab, konum.transform); Tanlimla(Serum, "Serum");
        GameObject Ses_Kýsýklýðý = Instantiate(burakPrefab, konum.transform); Tanlimla(Ses_Kýsýklýðý, "Ses Kýsýklýðý");
        GameObject Sýtma = Instantiate(burakPrefab, konum.transform); Tanlimla(Sýtma, "Sýtma");
        GameObject Siðil = Instantiate(burakPrefab, konum.transform); Tanlimla(Siðil, "Siðil");
        GameObject Sinameki = Instantiate(burakPrefab, konum.transform); Tanlimla(Sinameki, "Sinameki");
        GameObject Sindirim_Bozukluðu = Instantiate(burakPrefab, konum.transform); Tanlimla(Sindirim_Bozukluðu, "Sindirim Bozukluðu");
        GameObject Sirke = Instantiate(burakPrefab, konum.transform); Tanlimla(Sirke, "Sirke");
        GameObject Siroz = Instantiate(burakPrefab, konum.transform); Tanlimla(Siroz, "Siroz");
        GameObject Sivilce = Instantiate(burakPrefab, konum.transform); Tanlimla(Sivilce, "Sivilce");
        GameObject Sivrisinek = Instantiate(burakPrefab, konum.transform); Tanlimla(Sivrisinek, "Sivrisinek");
        GameObject Siyatik = Instantiate(burakPrefab, konum.transform); Tanlimla(Siyatik, "Siyatik");
        GameObject Soðan = Instantiate(burakPrefab, konum.transform); Tanlimla(Soðan, "Soðan");
        GameObject Spor = Instantiate(burakPrefab, konum.transform); Tanlimla(Spor, "Spor");
        GameObject Su = Instantiate(burakPrefab, konum.transform); Tanlimla(Su, "Su");
        GameObject Su_Teresi = Instantiate(burakPrefab, konum.transform); Tanlimla(Su_Teresi, "Su Teresi");
        GameObject Su_Çiçeði = Instantiate(burakPrefab, konum.transform); Tanlimla(Su_Çiçeði, "Su Çiçeði");
        GameObject Susam = Instantiate(burakPrefab, konum.transform); Tanlimla(Susam, "Susam"); 
        GameObject Sürme = Instantiate(burakPrefab, konum.transform); Tanlimla(Sürme, "Sürme");
        GameObject Süt = Instantiate(burakPrefab, konum.transform); Tanlimla(Süt, "Süt");
        #endregion

        // Þ
        #region Þ ile baslayanlar
        GameObject Þalgam = Instantiate(burakPrefab, konum.transform); Tanlimla(Þalgam, "Þalgam");
        GameObject Þam_Fýstýðý = Instantiate(burakPrefab, konum.transform); Tanlimla(Þam_Fýstýðý, "Þam Fýstýðý");
        GameObject Þap_Hastalýðý = Instantiate(burakPrefab, konum.transform); Tanlimla(Þap_Hastalýðý, "Þap Hastalýðý");
        GameObject Þaþýlýk = Instantiate(burakPrefab, konum.transform); Tanlimla(Þaþýlýk, "Þaþýlýk");
        GameObject Þeftali = Instantiate(burakPrefab, konum.transform); Tanlimla(Þeftali, "Þeftali");
        GameObject Þeker = Instantiate(burakPrefab, konum.transform); Tanlimla(Þeker, "Þeker");
        GameObject Þeker_Hastalýðý = Instantiate(burakPrefab, konum.transform); Tanlimla(Þeker_Hastalýðý, "Þeker Hastalýðý");
        GameObject Þeker_Kamýþý = Instantiate(burakPrefab, konum.transform); Tanlimla(Þeker_Kamýþý, "Þeker Kamýþý");
        #endregion

        // T
        #region T ile baslayanlar
         GameObject Tansiyon = Instantiate(burakPrefab, konum.transform); Tanlimla(Tansiyon, "Tansiyon");
         GameObject Fasülye = Instantiate(aliPrefab, konum.transform); Tanlimla(Fasülye, "Taze Fasülye");
        #endregion

        // U 
        #region U ile baslayanlar
        GameObject Unutkanlik = Instantiate(keremPrefab, konum.transform); Tanlimla(Unutkanlik, "Unutkanlýk");
        GameObject Uyku = Instantiate(keremPrefab, konum.transform); Tanlimla(Uyku, "Uyku");
        GameObject Uyuz = Instantiate(keremPrefab, konum.transform); Tanlimla(Uyuz, "Uyuz");
        #endregion

        // Ü
        #region Ü ile baslayanlar
        GameObject Ulser = Instantiate(keremPrefab, konum.transform); Tanlimla(Ulser, "Ülser");
        GameObject Uvez = Instantiate(keremPrefab, konum.transform); Tanlimla(Uvez, "Üvez");
        GameObject Uzerlik_tohumu = Instantiate(keremPrefab, konum.transform); Tanlimla(Uzerlik_tohumu, "Üzerlik Tohumu");
        GameObject Uzum = Instantiate(burakPrefab, konum.transform); Tanlimla(Uzum, "Üzüm");
        #endregion

        // V
        #region V ile baslayanlar
        GameObject Vanilya = Instantiate(keremPrefab, konum.transform); Tanlimla(Vanilya, "Vanilya");
        GameObject Varis = Instantiate(keremPrefab, konum.transform); Tanlimla(Varis, "Varis");
        GameObject Veba = Instantiate(keremPrefab, konum.transform); Tanlimla(Veba, "Veba");
        GameObject Verem = Instantiate(keremPrefab, konum.transform); Tanlimla(Verem, "Verem Hastalýðý");
        GameObject Visne = Instantiate(keremPrefab, konum.transform); Tanlimla(Visne, "Viþne");
        #endregion

        // Y 
        #region Y ile baslayanlar
        GameObject Yaban_Mersini = Instantiate(keremPrefab, konum.transform); Tanlimla(Yaban_Mersini, "Yaban Mersini");
        GameObject Yanik = Instantiate(keremPrefab, konum.transform); Tanlimla(Yanik, "Yanýk");
        GameObject Yasemin_Cayi = Instantiate(keremPrefab, konum.transform); Tanlimla(Yasemin_Cayi, "Yasemin Çayý");
        GameObject Yer_Elmasi = Instantiate(keremPrefab, konum.transform); Tanlimla(Yer_Elmasi, "Yer Elmasý");
        GameObject Yesil_Mercimek = Instantiate(keremPrefab, konum.transform); Tanlimla(Yesil_Mercimek, "Yeþil Mercimek");
        GameObject Yogurt = Instantiate(keremPrefab, konum.transform); Tanlimla(Yogurt, "Yoðurt");
        GameObject Yulaf = Instantiate(aliPrefab, konum.transform); Tanlimla(Yulaf, "Yulaf");
        GameObject Yumurta = Instantiate(keremPrefab, konum.transform); Tanlimla(Yumurta, "Yumurta");
        #endregion

        // Z 
        #region Z ile baslayanlar
        GameObject Zehirlenme = Instantiate(keremPrefab, konum.transform); Tanlimla(Zehirlenme, "Zehirlenme");
        GameObject Zemzem_suyu = Instantiate(keremPrefab, konum.transform); Tanlimla(Zemzem_suyu, "Zemzem Suyu");
        GameObject Zencefil = Instantiate(keremPrefab, konum.transform); Tanlimla(Zencefil, "Zencefil");
        GameObject Zerdecal = Instantiate(keremPrefab, konum.transform); Tanlimla(Zerdecal, "Zerdeçal");
        GameObject Zeytin = Instantiate(keremPrefab, konum.transform); Tanlimla(Zeytin, "Zeytin");
        GameObject ZeytinYagi = Instantiate(aliPrefab, konum.transform); Tanlimla(ZeytinYagi, "Zeytinyaðý");
        #endregion
    }

    

    void Tanlimla(GameObject obje, string urunisimi)
    {
        obje.transform.name = urunisimi;
        obje.transform.GetChild(0).GetComponent<Text>().text = urunisimi;
        obje.transform.GetComponent<Button>().onClick.AddListener(() => _kerem.Urunler(urunisimi));
        obje.transform.GetComponent<Button>().onClick.AddListener(() => _ali.Urunler(urunisimi));
        obje.transform.GetComponent<Button>().onClick.AddListener(() => _burak.Urunler(urunisimi));
        obje.transform.GetComponent<Button>().onClick.AddListener(() => baslikButonunaBasildiginda());
 
    }

   
    public void baslikButonunaBasildiginda()
    {
        Bilgibackground.GetComponent<RectTransform>().DOLocalMoveX(0, 0.5f);
    }
}

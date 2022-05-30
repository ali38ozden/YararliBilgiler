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
        
        

        //ALFABET�K

        // A
        #region A ile baslayanlar
        GameObject A��z_Kokusu = Instantiate(aliPrefab, konum.transform); Tanlimla(A��z_Kokusu, "A��z Kokusu");
        GameObject A��z_Yarasi = Instantiate(aliPrefab, konum.transform); Tanlimla(A��z_Yarasi, "A��z Yaras�");
        GameObject A�lamanin_Zararlari = Instantiate(aliPrefab, konum.transform); Tanlimla(A�lamanin_Zararlari, "A�laman�n Zararlar�");       
        GameObject Akci�er = Instantiate(aliPrefab, konum.transform); Tanlimla(Akci�er, "Akci�er");
        GameObject Akraba_Evlili�i = Instantiate(aliPrefab, konum.transform); Tanlimla(Akraba_Evlili�i, "Akraba Evlili�i");
        GameObject Akrep_Sokmas� = Instantiate(aliPrefab, konum.transform); Tanlimla(Akrep_Sokmas�, "Akrep Sokmas�");
        GameObject Alkolizm = Instantiate(aliPrefab, konum.transform); Tanlimla(Alkolizm, "Alkolizm");
        GameObject Ananas = Instantiate(burakPrefab, konum.transform); Tanlimla(Ananas, "Ananas");
        GameObject Apse = Instantiate(aliPrefab, konum.transform); Tanlimla(Apse, "Apse");
        GameObject Ari_Sokmas� = Instantiate(aliPrefab, konum.transform); Tanlimla(Ari_Sokmas�, "Ar� Sokmas�");
        GameObject Armut = Instantiate(keremPrefab, konum.transform); Tanlimla(Armut, "Armut");
        GameObject Arpa = Instantiate(aliPrefab, konum.transform); Tanlimla(Arpa, "Arpa");
        GameObject Astim = Instantiate(aliPrefab, konum.transform); Tanlimla(Astim, "Ast�m");
        GameObject AyakMantari = Instantiate(aliPrefab, konum.transform); Tanlimla(AyakMantari, "Ayak Mantar�");
        GameObject Ayva = Instantiate(aliPrefab, konum.transform); Tanlimla(Ayva, "Ayva");
        GameObject Az_Yemek = Instantiate(aliPrefab, konum.transform); Tanlimla(Az_Yemek, "Az Yemek");
        #endregion

        // B
        #region B ile baslayanlar
        GameObject Badem = Instantiate(aliPrefab, konum.transform); Tanlimla(Badem, "Badem");
        GameObject Ba�irsak = Instantiate(aliPrefab, konum.transform); Tanlimla(Ba�irsak, "Ba��rsak");
        GameObject Bal = Instantiate(aliPrefab, konum.transform); Tanlimla(Bal, "Bal");
        GameObject Bal�k = Instantiate(aliPrefab, konum.transform); Tanlimla(Bal�k, "Bal�k");
        GameObject Ba�_A�r�s� = Instantiate(aliPrefab, konum.transform); Tanlimla(Ba�_A�r�s�, "Ba� A�r�s�");
        GameObject Ba�_D�nmesi = Instantiate(aliPrefab, konum.transform); Tanlimla(Ba�_D�nmesi, "Ba� D�nmesi");
        GameObject Bel_Agrisi = Instantiate(aliPrefab, konum.transform); Tanlimla(Bel_Agrisi, "Bel A�r�s�");
        GameObject Beyin = Instantiate(aliPrefab, konum.transform); Tanlimla(Beyin, "Beyin");
        GameObject Bit = Instantiate(aliPrefab, konum.transform); Tanlimla(Bit, "Bit");
        GameObject Bogaz_Arisi = Instantiate(aliPrefab, konum.transform); Tanlimla(Bogaz_Arisi, "Bo�az A�r�s�");
        GameObject Bo�az_T�kanmas� = Instantiate(aliPrefab, konum.transform); Tanlimla(Bo�az_T�kanmas�, "Bo�az T�kanmas�");
        GameObject B�brek_Hastal�klar�n�n_Belirtileri = Instantiate(aliPrefab, konum.transform); Tanlimla(B�brek_Hastal�klar�n�n_Belirtileri, "B�brek Hastal�klar�n�n Belirtileri");
        GameObject B�brek_Ta�� = Instantiate(aliPrefab, konum.transform); Tanlimla(B�brek_Ta��, "B�brek Ta��");
        GameObject Buhur = Instantiate(aliPrefab, konum.transform); Tanlimla(Buhur, "Buhur");
        GameObject Bulant� = Instantiate(aliPrefab, konum.transform); Tanlimla(Bulant�, "Bulant�");
        GameObject Bunamak = Instantiate(aliPrefab, konum.transform); Tanlimla(Bunamak, "Bunamak");
        GameObject Buruna_Kanamas� = Instantiate(aliPrefab, konum.transform); Tanlimla(Buruna_Kanamas�, "Burun Kanamas�");
        GameObject Burun_t�kan�kl�g� = Instantiate(aliPrefab, konum.transform); Tanlimla(Burun_t�kan�kl�g�, "Burun T�kan�kl���");
        GameObject B�y� = Instantiate(aliPrefab, konum.transform); Tanlimla(B�y�, "B�y�");
        #endregion

        // C 
        #region C ile baslayanlar
        GameObject Cenin = Instantiate(aliPrefab, konum.transform); Tanlimla(Cenin, "Cenin");
        GameObject Cerrah = Instantiate(aliPrefab, konum.transform); Tanlimla(Cerrah, "Cerrah");
        GameObject Ceviz = Instantiate(burakPrefab, konum.transform); Tanlimla(Ceviz, "Ceviz");
        GameObject Chia = Instantiate(burakPrefab, konum.transform); Tanlimla(Chia, "Chia");
        GameObject Cilt = Instantiate(aliPrefab, konum.transform); Tanlimla(Cilt, "Cilt");
        GameObject CiltHastal�g� = Instantiate(aliPrefab, konum.transform); Tanlimla(CiltHastal�g�, "Cilt Hastal���");
        GameObject Civit_Otu = Instantiate(aliPrefab, konum.transform); Tanlimla(Civit_Otu, "Civit Otu");
        GameObject Cucelik = Instantiate(aliPrefab, konum.transform); Tanlimla(Cucelik, "C�celik");
        GameObject Cuzzam = Instantiate(aliPrefab, konum.transform); Tanlimla(Cuzzam, "C�zzam");
        #endregion

        // � 
        #region � ile baslayanlar
        GameObject CakalKavunu = Instantiate(aliPrefab, konum.transform); Tanlimla(CakalKavunu, "�akal Kavunu");
        GameObject CamF�st�g� = Instantiate(aliPrefab, konum.transform); Tanlimla(CamF�st�g�, "�am F�st���");
        GameObject CamurlaTedavi = Instantiate(aliPrefab, konum.transform); Tanlimla(CamurlaTedavi, "�amurla Tedavi");
        GameObject Carpik = Instantiate(aliPrefab, konum.transform); Tanlimla(Carpik, "�arp�k");
        GameObject Catlak = Instantiate(aliPrefab, konum.transform); Tanlimla(Catlak, "�atlak");
        GameObject CemenOtu = Instantiate(aliPrefab, konum.transform); Tanlimla(CemenOtu, "�emen Otu");
        GameObject C�k�k = Instantiate(aliPrefab, konum.transform); Tanlimla(C�k�k, "��k�k");
        GameObject CicekHastal�g� = Instantiate(aliPrefab, konum.transform); Tanlimla(CicekHastal�g�, "�i�ek Hastal���");
        GameObject �ilek = Instantiate(aliPrefab, konum.transform); Tanlimla(�ilek, "�ilek");
        GameObject Cok_Yemek = Instantiate(aliPrefab, konum.transform); Tanlimla(Cok_Yemek, "�ok Yemek");
        GameObject ��rek_Otu = Instantiate(aliPrefab, konum.transform); Tanlimla(��rek_Otu, "��rek Otu");
        GameObject Coven_Otu = Instantiate(aliPrefab, konum.transform); Tanlimla(Coven_Otu, "��ven Otu");
        #endregion

        // D 
        #region D ile baslayanlar
        GameObject Dalak = Instantiate(aliPrefab, konum.transform); Tanlimla(Dalak, "Dalak");
        GameObject Damar = Instantiate(aliPrefab, konum.transform); Tanlimla(Damar, "Damar");
        GameObject Damar_Sertligi = Instantiate(aliPrefab, konum.transform); Tanlimla(Damar_Sertligi, "Damar Sertli�i");
        GameObject Deniz_Suyu = Instantiate(aliPrefab, konum.transform); Tanlimla(Deniz_Suyu, "Deniz Suyu");
        GameObject Depresyon = Instantiate(aliPrefab, konum.transform); Tanlimla(Depresyon, "Depresyon");
        GameObject Deve_Hastal�g� = Instantiate(aliPrefab, konum.transform); Tanlimla(Deve_Hastal�g�, "Deve Hastal���");
        GameObject Dil = Instantiate(aliPrefab, konum.transform); Tanlimla(Dil, "Dil");
        GameObject Dilcik = Instantiate(aliPrefab, konum.transform); Tanlimla(Dilcik, "Dilcik");
        GameObject Di� = Instantiate(aliPrefab, konum.transform); Tanlimla(Di�, "Di�");
        GameObject Di�_T�rp�leme = Instantiate(aliPrefab, konum.transform); Tanlimla(Di�_T�rp�leme, "Di� T�rp�leme");
        GameObject Do�um = Instantiate(aliPrefab, konum.transform); Tanlimla(Do�um, "Do�um");
        GameObject Dolama = Instantiate(aliPrefab, konum.transform); Tanlimla(Dolama, "Dolama");
        GameObject Dolunay = Instantiate(aliPrefab, konum.transform); Tanlimla(Dolunay, "Dolunay");
        GameObject Dudak = Instantiate(aliPrefab, konum.transform); Tanlimla(Dudak, "Dudak");
        GameObject Dut = Instantiate(aliPrefab, konum.transform); Tanlimla(Dut, "Dut");
        GameObject D�z_Taban = Instantiate(aliPrefab, konum.transform); Tanlimla(D�z_Taban, "D�z Taban");
        #endregion

        // E 
        #region E ile baslayanlar
        GameObject Ebe_G�meci = Instantiate(aliPrefab, konum.transform); Tanlimla(Ebe_G�meci, "Ebe G�meci");
        GameObject Ebu_Cehil_Karpuzu = Instantiate(aliPrefab, konum.transform); Tanlimla(Ebu_Cehil_Karpuzu, "Ebu Cehil Karpuzu");
        GameObject Egzama = Instantiate(aliPrefab, konum.transform); Tanlimla(Egzama, "Egzama");
        GameObject Eklem = Instantiate(aliPrefab, konum.transform); Tanlimla(Eklem, "Eklem A�r�s�");
        GameObject Ekmek = Instantiate(aliPrefab, konum.transform); Tanlimla(Ekmek, "Ekmek");
        GameObject Elma = Instantiate(aliPrefab, konum.transform); Tanlimla(Elma, "Elma");
        GameObject Epilepsi = Instantiate(aliPrefab, konum.transform); Tanlimla(Epilepsi, "Epilepsi");
        GameObject Erik = Instantiate(aliPrefab, konum.transform); Tanlimla(Erik, "Erik");
        GameObject Esnemek = Instantiate(aliPrefab, konum.transform); Tanlimla(Esnemek, "Esnemek");
        GameObject Estetik_Ameliyat� = Instantiate(aliPrefab, konum.transform); Tanlimla(Estetik_Ameliyat�, "Estetik Ameliyat�");
        GameObject Et = Instantiate(aliPrefab, konum.transform); Tanlimla(Et, "Et");
        GameObject Etli_�orba = Instantiate(aliPrefab, konum.transform); Tanlimla(Etli_�orba, "Etli �orba");
        GameObject Evham = Instantiate(aliPrefab, konum.transform); Tanlimla(Evham, "Evham");
        #endregion

        // F 
        #region F ile baslayanlar
        GameObject FareKula�� = Instantiate(aliPrefab, konum.transform); Tanlimla(FareKula��, "FareKula��");
        GameObject Fel� = Instantiate(aliPrefab, konum.transform); Tanlimla(Fel�, "Fel�");
        GameObject F�nd�k = Instantiate(aliPrefab, konum.transform); Tanlimla(F�nd�k, "F�nd�k");
        GameObject F�t�k = Instantiate(aliPrefab, konum.transform); Tanlimla(F�t�k, "F�st�k");
        GameObject FilHastal��� = Instantiate(aliPrefab, konum.transform); Tanlimla(FilHastal���, "Fil Hastal���");
        GameObject FizikTedavi = Instantiate(aliPrefab, konum.transform); Tanlimla(FizikTedavi, "Fizik Tedavi");
        #endregion

        // G 
        #region G ile baslayanlar
        GameObject Gargara = Instantiate(aliPrefab, konum.transform); Tanlimla(Gargara, "Gargara");
        GameObject Gasil = Instantiate(aliPrefab, konum.transform); Tanlimla(Gasil, "Gasil");
        GameObject GebreOtu = Instantiate(aliPrefab, konum.transform); Tanlimla(GebreOtu, "Gebre Otu");
        GameObject GeceKorlugu = Instantiate(aliPrefab, konum.transform); Tanlimla(GeceKorlugu, "Gece K�rl���");
        GameObject Ge�irmek = Instantiate(aliPrefab, konum.transform); Tanlimla(Ge�irmek, "Ge�irmek");
        GameObject G�bek = Instantiate(aliPrefab, konum.transform); Tanlimla(G�bek, "G�bek");
        GameObject G���s = Instantiate(aliPrefab, konum.transform); Tanlimla(G���s, "G���s");
        GameObject G�z = Instantiate(aliPrefab, konum.transform); Tanlimla(G�z, "G�z De�mesi");
        GameObject G�z_Ya�� = Instantiate(aliPrefab, konum.transform); Tanlimla(G�z_Ya��, "G�z Ya��");
        GameObject G�l = Instantiate(aliPrefab, konum.transform); Tanlimla(G�l, "G�l");
        GameObject G�lmek = Instantiate(aliPrefab, konum.transform); Tanlimla(G�lmek, "G�lmek");
        GameObject G�m�� = Instantiate(aliPrefab, konum.transform); Tanlimla(G�m��, "G�m��");
        GameObject G�ne�_I���� = Instantiate(aliPrefab, konum.transform); Tanlimla(G�ne�_I����, "G�ne�");
        #endregion

        // H
        #region H ile baslayanlar
        GameObject Hacamat = Instantiate(aliPrefab, konum.transform); Tanlimla(Hacamat, "Hacamat");
        GameObject Haf�za = Instantiate(aliPrefab, konum.transform); Tanlimla(Haf�za, "Haf�za");
        GameObject Hamam = Instantiate(aliPrefab, konum.transform); Tanlimla(Hamam, "Hamam");
        GameObject Hamam_Otu = Instantiate(aliPrefab, konum.transform); Tanlimla(Hamam_Otu, "Hamam Otu");
        GameObject Hap��rmak = Instantiate(aliPrefab, konum.transform); Tanlimla(Hap��rmak, "Hap��rmak");
        GameObject Hurma = Instantiate(aliPrefab, konum.transform); Tanlimla(Hurma, "Hurma");
        #endregion

        // I (yok)


        // �
        #region � ile baslayanlar
        GameObject �ncir = Instantiate(burakPrefab, konum.transform); Tanlimla(�ncir, "�ncir");
        #endregion

        // J (yok)


        // K 
        #region K ile baslayanlar
        GameObject Kaju = Instantiate(aliPrefab, konum.transform); Tanlimla(Kaju, "Kaju");
        GameObject Kakao = Instantiate(burakPrefab, konum.transform); Tanlimla(Kakao, "Kakao");
        GameObject Kabak = Instantiate(burakPrefab, konum.transform); Tanlimla(Kabak, "Kabak");
        GameObject Kab�zl�k = Instantiate(burakPrefab, konum.transform); Tanlimla(Kab�zl�k, "Kab�zl�k");
        GameObject Kafur = Instantiate(burakPrefab, konum.transform); Tanlimla(Kafur, "Kafur");
        GameObject Kalp_�arp�nt�s� = Instantiate(burakPrefab, konum.transform); Tanlimla(Kalp_�arp�nt�s�, "Kalp �arp�nt�s�");
        GameObject Kan = Instantiate(burakPrefab, konum.transform); Tanlimla(Kan, "Kan");
        GameObject Kan_Vermek = Instantiate(burakPrefab, konum.transform); Tanlimla(Kan_Vermek, "Kan Vermek");
        GameObject Kan_T�k�rmek = Instantiate(burakPrefab, konum.transform); Tanlimla(Kan_T�k�rmek, "Kan T�k�rmek");
        GameObject Kangren = Instantiate(burakPrefab, konum.transform); Tanlimla(Kangren, "Kangren");
        GameObject Kanser = Instantiate(burakPrefab, konum.transform); Tanlimla(Kanser, "Kanser");
        GameObject Kans�zl�k = Instantiate(burakPrefab, konum.transform); Tanlimla(Kans�zl�k, "Kans�zl�k");
        GameObject Karabiber = Instantiate(burakPrefab, konum.transform); Tanlimla(Karabiber, "Karabiber");
        GameObject Karaci�er_Sa�l��� = Instantiate(burakPrefab, konum.transform); Tanlimla(Karaci�er_Sa�l���, "Karaci�er Sa�l���");
        GameObject Kara�i�ek = Instantiate(burakPrefab, konum.transform); Tanlimla(Kara�i�ek, "Kara�i�ek");
        GameObject Karanfil = Instantiate(burakPrefab, konum.transform); Tanlimla(Karanfil, "Karanfil");
        GameObject Karasinek = Instantiate(burakPrefab, konum.transform); Tanlimla(Karasinek, "Karasinek");
        GameObject Kar�n_A�r�s� = Instantiate(burakPrefab, konum.transform); Tanlimla(Kar�n_A�r�s�, "Kar�n A�r�s�");
        GameObject Karpuz = Instantiate(burakPrefab, konum.transform); Tanlimla(Karpuz, "Karpuz");
        GameObject Ka��nt� = Instantiate(burakPrefab, konum.transform); Tanlimla(Ka��nt�, "Ka��nt�");
        GameObject Katarakt = Instantiate(burakPrefab, konum.transform); Tanlimla(Katarakt, "Katarakt");
        GameObject Katran = Instantiate(burakPrefab, konum.transform); Tanlimla(Katran, "Katran");
        GameObject Kavun = Instantiate(aliPrefab, konum.transform); Tanlimla(Kavun, "Kavun");
        GameObject Kay�s� = Instantiate(burakPrefab, konum.transform); Tanlimla(Kay�s�, "Kay�s�");
        GameObject Kaymak = Instantiate(burakPrefab, konum.transform); Tanlimla(Kaymak, "Kaymak");
        GameObject Ke�iboynuzu = Instantiate(burakPrefab, konum.transform); Tanlimla(Ke�iboynuzu, "Ke�iboynuzu");
        GameObject Kekemelik = Instantiate(burakPrefab, konum.transform); Tanlimla(Kekemelik, "Kekemelik");
        GameObject Kekik = Instantiate(burakPrefab, konum.transform); Tanlimla(Kekik, "Kekik");
        GameObject Kellik = Instantiate(burakPrefab, konum.transform); Tanlimla(Kellik, "Kellik");
        GameObject Kemik = Instantiate(burakPrefab, konum.transform); Tanlimla(Kemik, "Kemik");
        GameObject Kepek = Instantiate(burakPrefab, konum.transform); Tanlimla(Kepek, "Kepek");
        GameObject Kereviz = Instantiate(burakPrefab, konum.transform); Tanlimla(Kereviz, "Kereviz");
        GameObject K�na = Instantiate(burakPrefab, konum.transform); Tanlimla(K�na, "K�na");
        GameObject K�na_�i�e�i = Instantiate(burakPrefab, konum.transform); Tanlimla(K�na_�i�e�i, "K�na �i�e�i");
        GameObject K�r�k = Instantiate(burakPrefab, konum.transform); Tanlimla(K�r�k, "K�r�k");
        GameObject Kiraz = Instantiate(aliPrefab, konum.transform); Tanlimla(Kiraz, "Kiraz");
        GameObject Kirmizi_Mercimek = Instantiate(keremPrefab, konum.transform); Tanlimla(Kirmizi_Mercimek, "K�rm�z� Mercimek");
        GameObject K�rm�z�_So�an = Instantiate(aliPrefab, konum.transform); Tanlimla(K�rm�z�_So�an, "K�rm�z� So�an");
        GameObject K�s�rl�k = Instantiate(burakPrefab, konum.transform); Tanlimla(K�s�rl�k, "K�s�rl�k");
        GameObject K�zam�k = Instantiate(burakPrefab, konum.transform); Tanlimla(K�zam�k, "K�zam�k");
        GameObject Kimyon = Instantiate(burakPrefab, konum.transform); Tanlimla(Kimyon, "Kimyon");
        GameObject Kolera = Instantiate(burakPrefab, konum.transform); Tanlimla(Kolera, "Kolera");
        GameObject K�selik = Instantiate(burakPrefab, konum.transform); Tanlimla(K�selik, "K�selik");
        GameObject Kuduz = Instantiate(burakPrefab, konum.transform); Tanlimla(Kuduz, "Kuduz");
        GameObject Kulak_��nlamas� = Instantiate(burakPrefab, konum.transform); Tanlimla(Kulak_��nlamas�, "Kulak ��nlamas�");
        GameObject Kulun�_A�r�s� = Instantiate(burakPrefab, konum.transform); Tanlimla(Kulun�_A�r�s�, "Kulun� A�r�s�");
        GameObject Kum_Banyosu = Instantiate(burakPrefab, konum.transform); Tanlimla(Kum_Banyosu, "Kum Banyosu");
        GameObject Kurde�en = Instantiate(burakPrefab, konum.transform); Tanlimla(Kurde�en, "Kurde�en");
        GameObject Kuru_Fasulye = Instantiate(aliPrefab, konum.transform); Tanlimla(Kuru_Fasulye, "Kuru Fas�lye");
        GameObject Kurutulmus_Et = Instantiate(aliPrefab, konum.transform); Tanlimla(Kurutulmus_Et, "Kurutulmu� Et");
        GameObject Kuru_�z�m = Instantiate(burakPrefab, konum.transform); Tanlimla(Kuru_�z�m, "Kuru �z�m");
        GameObject Ku�konmaz = Instantiate(burakPrefab, konum.transform); Tanlimla(Ku�konmaz, "Ku�konmaz");
        GameObject Kuyruk_Ya�� = Instantiate(burakPrefab, konum.transform); Tanlimla(Kuyruk_Ya��, "Kuyruk Ya��");
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
        GameObject Menekse = Instantiate(keremPrefab, konum.transform); Tanlimla(Menekse, "Menek�e");
        GameObject Mersin_Yapragi = Instantiate(keremPrefab, konum.transform); Tanlimla(Mersin_Yapragi, "Mersin Yapra��");
        GameObject Mesane_Hastaliklari = Instantiate(keremPrefab, konum.transform); Tanlimla(Mesane_Hastaliklari, "Mesane Hastal�klar�");
        GameObject Mevsimler = Instantiate(keremPrefab, konum.transform); Tanlimla(Mevsimler, "Mevsimler");
        GameObject Meyan_Koku = Instantiate(keremPrefab, konum.transform); Tanlimla(Meyan_Koku, "Meyan K�k�");
        GameObject Meyve_Suyu = Instantiate(keremPrefab, konum.transform); Tanlimla(Meyve_Suyu, "Meyve Suyu");
        GameObject Mide_Rahatsizligi = Instantiate(keremPrefab, konum.transform); Tanlimla(Mide_Rahatsizligi, "Mide Rahats�zl���");
        GameObject Misk_Otu = Instantiate(keremPrefab, konum.transform); Tanlimla(Misk_Otu, "Misk Otu");
        GameObject Misvak = Instantiate(keremPrefab, konum.transform); Tanlimla(Misvak, "Misvak");
        GameObject Mushil = Instantiate(keremPrefab, konum.transform); Tanlimla(Mushil, "M�shil");
        GameObject Muz = Instantiate(burakPrefab, konum.transform); Tanlimla(Muz, "Muz");
        #endregion

        // N
        #region N ile baslayanlar
        GameObject Nane = Instantiate(keremPrefab, konum.transform); Tanlimla(Nane, "Nane");
        GameObject Nar = Instantiate(aliPrefab, konum.transform); Tanlimla(Nar, "Nar");
        GameObject Nasir = Instantiate(keremPrefab, konum.transform); Tanlimla(Nasir, "Nas�r");
        GameObject Nefes_Darligi = Instantiate(keremPrefab, konum.transform); Tanlimla(Nefes_Darligi, "Nefes Darl���");
        GameObject Nektarin = Instantiate(keremPrefab, konum.transform); Tanlimla(Nektarin, "Nektarin");
        GameObject Nergis_Cicegi = Instantiate(keremPrefab, konum.transform); Tanlimla(Nergis_Cicegi, "Nergis �i�e�i");
        GameObject Nezle = Instantiate(keremPrefab, konum.transform); Tanlimla(Nezle, "Nezle");
        GameObject Nilufer_Cicegi = Instantiate(keremPrefab, konum.transform); Tanlimla(Nilufer_Cicegi, "Nil�fer �i�e�i");
        GameObject Nohut = Instantiate(keremPrefab, konum.transform); Tanlimla(Nohut, "Nohut");
        #endregion

        // O
        #region O ile baslayanlar
        GameObject Ogul_Otu = Instantiate(keremPrefab, konum.transform); Tanlimla(Ogul_Otu, "O�ul Otu");
        GameObject Omega_3 = Instantiate(burakPrefab, konum.transform); Tanlimla(Omega_3, "Omega 3");
        GameObject Organ_Bagisi = Instantiate(keremPrefab, konum.transform); Tanlimla(Organ_Bagisi, "Organ Ba����");
        GameObject Oruc = Instantiate(keremPrefab, konum.transform); Tanlimla(Oruc, "Oru� Tutmak");
        #endregion

        // � 
        #region � ile baslayanlar
        GameObject Od_Agaci = Instantiate(keremPrefab, konum.transform); Tanlimla(Od_Agaci, "�d A�ac�");
        GameObject Ofke = Instantiate(keremPrefab, konum.transform); Tanlimla(Ofke, "�fke");
        GameObject Okse_Otu = Instantiate(keremPrefab, konum.transform); Tanlimla(Okse_Otu, "�kse Otu");
        GameObject Oksuruk_Otu = Instantiate(keremPrefab, konum.transform); Tanlimla(Oksuruk_Otu, "�ks�r�k Otu");
        #endregion

        // P
        #region P ile baslayanlar
        GameObject Pamukcuk_Hastaligi = Instantiate(keremPrefab, konum.transform); Tanlimla(Pamukcuk_Hastaligi, "Pamuk�uk Hastal���");
        GameObject Papatya_Cayi = Instantiate(keremPrefab, konum.transform); Tanlimla(Papatya_Cayi, "Papatya �ay�");
        GameObject Parmak_Emme = Instantiate(keremPrefab, konum.transform); Tanlimla(Parmak_Emme, "Parmak Emme");
        GameObject Patates = Instantiate(keremPrefab, konum.transform); Tanlimla(Patates, "Patates");
        GameObject Patlican = Instantiate(keremPrefab, konum.transform); Tanlimla(Patlican, "Patl�can");
        GameObject Pazi = Instantiate(keremPrefab, konum.transform); Tanlimla(Pazi, "Paz�");
        GameObject Pekmez = Instantiate(keremPrefab, konum.transform); Tanlimla(Pekmez, "Pekmez");
        GameObject Perhiz = Instantiate(keremPrefab, konum.transform); Tanlimla(Perhiz, "Perhiz");
        GameObject Peynir = Instantiate(keremPrefab, konum.transform); Tanlimla(Peynir, "Peynir");
        GameObject Pirasa = Instantiate(keremPrefab, konum.transform); Tanlimla(Pirasa, "P�rasa");
        GameObject Pirinc = Instantiate(keremPrefab, konum.transform); Tanlimla(Pirinc, "Pirin�");
        GameObject Portakal = Instantiate(aliPrefab, konum.transform); Tanlimla(Portakal, "Portakal");
        #endregion

        // R 
        #region R ile baslayanlar
        GameObject Reyhan = Instantiate(keremPrefab, konum.transform); Tanlimla(Reyhan, "Reyhan Bitkisi");
        GameObject Rezene_Cayi = Instantiate(keremPrefab, konum.transform); Tanlimla(Rezene_Cayi, "Rezene �ay�");
        GameObject Roka = Instantiate(keremPrefab, konum.transform); Tanlimla(Roka, "Roka");
        GameObject Romatizma = Instantiate(keremPrefab, konum.transform); Tanlimla(Romatizma, "Romatizma");
        #endregion

        // S 
        #region S ile baslayanlar
        GameObject Sa�_K�ran = Instantiate(burakPrefab, konum.transform); Tanlimla(Sa�_K�ran, "Sa� K�ran");
        GameObject Safra = Instantiate(burakPrefab, konum.transform); Tanlimla(Safra, "Safra");
        GameObject Safran = Instantiate(burakPrefab, konum.transform); Tanlimla(Safran, "Safran");
        GameObject Sak�z = Instantiate(burakPrefab, konum.transform); Tanlimla(Sak�z, "Sak�z");
        GameObject Salatal�k = Instantiate(aliPrefab, konum.transform); Tanlimla(Salatal�k, "Salatal�k");
        GameObject Sarho�luk = Instantiate(burakPrefab, konum.transform); Tanlimla(Sarho�luk, "Sarho�luk");
        GameObject Sar�l�k = Instantiate(burakPrefab, konum.transform); Tanlimla(Sar�l�k, "Sar�l�k");
        GameObject Sar�msak = Instantiate(burakPrefab, konum.transform); Tanlimla(Sar�msak, "Sar�msak");
        GameObject Sedef_Hastal��� = Instantiate(burakPrefab, konum.transform); Tanlimla(Sedef_Hastal���, "Sedef Hastal���");
        GameObject Sedir_A�ac� = Instantiate(burakPrefab, konum.transform); Tanlimla(Sedir_A�ac�, "Sedir A�ac�");
        GameObject Semizotu = Instantiate(burakPrefab, konum.transform); Tanlimla(Semizotu, "Semizotu");
        GameObject Serum = Instantiate(burakPrefab, konum.transform); Tanlimla(Serum, "Serum");
        GameObject Ses_K�s�kl��� = Instantiate(burakPrefab, konum.transform); Tanlimla(Ses_K�s�kl���, "Ses K�s�kl���");
        GameObject S�tma = Instantiate(burakPrefab, konum.transform); Tanlimla(S�tma, "S�tma");
        GameObject Si�il = Instantiate(burakPrefab, konum.transform); Tanlimla(Si�il, "Si�il");
        GameObject Sinameki = Instantiate(burakPrefab, konum.transform); Tanlimla(Sinameki, "Sinameki");
        GameObject Sindirim_Bozuklu�u = Instantiate(burakPrefab, konum.transform); Tanlimla(Sindirim_Bozuklu�u, "Sindirim Bozuklu�u");
        GameObject Sirke = Instantiate(burakPrefab, konum.transform); Tanlimla(Sirke, "Sirke");
        GameObject Siroz = Instantiate(burakPrefab, konum.transform); Tanlimla(Siroz, "Siroz");
        GameObject Sivilce = Instantiate(burakPrefab, konum.transform); Tanlimla(Sivilce, "Sivilce");
        GameObject Sivrisinek = Instantiate(burakPrefab, konum.transform); Tanlimla(Sivrisinek, "Sivrisinek");
        GameObject Siyatik = Instantiate(burakPrefab, konum.transform); Tanlimla(Siyatik, "Siyatik");
        GameObject So�an = Instantiate(burakPrefab, konum.transform); Tanlimla(So�an, "So�an");
        GameObject Spor = Instantiate(burakPrefab, konum.transform); Tanlimla(Spor, "Spor");
        GameObject Su = Instantiate(burakPrefab, konum.transform); Tanlimla(Su, "Su");
        GameObject Su_Teresi = Instantiate(burakPrefab, konum.transform); Tanlimla(Su_Teresi, "Su Teresi");
        GameObject Su_�i�e�i = Instantiate(burakPrefab, konum.transform); Tanlimla(Su_�i�e�i, "Su �i�e�i");
        GameObject Susam = Instantiate(burakPrefab, konum.transform); Tanlimla(Susam, "Susam"); 
        GameObject S�rme = Instantiate(burakPrefab, konum.transform); Tanlimla(S�rme, "S�rme");
        GameObject S�t = Instantiate(burakPrefab, konum.transform); Tanlimla(S�t, "S�t");
        #endregion

        // �
        #region � ile baslayanlar
        GameObject �algam = Instantiate(burakPrefab, konum.transform); Tanlimla(�algam, "�algam");
        GameObject �am_F�st��� = Instantiate(burakPrefab, konum.transform); Tanlimla(�am_F�st���, "�am F�st���");
        GameObject �ap_Hastal��� = Instantiate(burakPrefab, konum.transform); Tanlimla(�ap_Hastal���, "�ap Hastal���");
        GameObject �a��l�k = Instantiate(burakPrefab, konum.transform); Tanlimla(�a��l�k, "�a��l�k");
        GameObject �eftali = Instantiate(burakPrefab, konum.transform); Tanlimla(�eftali, "�eftali");
        GameObject �eker = Instantiate(burakPrefab, konum.transform); Tanlimla(�eker, "�eker");
        GameObject �eker_Hastal��� = Instantiate(burakPrefab, konum.transform); Tanlimla(�eker_Hastal���, "�eker Hastal���");
        GameObject �eker_Kam��� = Instantiate(burakPrefab, konum.transform); Tanlimla(�eker_Kam���, "�eker Kam���");
        #endregion

        // T
        #region T ile baslayanlar
         GameObject Tansiyon = Instantiate(burakPrefab, konum.transform); Tanlimla(Tansiyon, "Tansiyon");
         GameObject Fas�lye = Instantiate(aliPrefab, konum.transform); Tanlimla(Fas�lye, "Taze Fas�lye");
        #endregion

        // U 
        #region U ile baslayanlar
        GameObject Unutkanlik = Instantiate(keremPrefab, konum.transform); Tanlimla(Unutkanlik, "Unutkanl�k");
        GameObject Uyku = Instantiate(keremPrefab, konum.transform); Tanlimla(Uyku, "Uyku");
        GameObject Uyuz = Instantiate(keremPrefab, konum.transform); Tanlimla(Uyuz, "Uyuz");
        #endregion

        // �
        #region � ile baslayanlar
        GameObject Ulser = Instantiate(keremPrefab, konum.transform); Tanlimla(Ulser, "�lser");
        GameObject Uvez = Instantiate(keremPrefab, konum.transform); Tanlimla(Uvez, "�vez");
        GameObject Uzerlik_tohumu = Instantiate(keremPrefab, konum.transform); Tanlimla(Uzerlik_tohumu, "�zerlik Tohumu");
        GameObject Uzum = Instantiate(burakPrefab, konum.transform); Tanlimla(Uzum, "�z�m");
        #endregion

        // V
        #region V ile baslayanlar
        GameObject Vanilya = Instantiate(keremPrefab, konum.transform); Tanlimla(Vanilya, "Vanilya");
        GameObject Varis = Instantiate(keremPrefab, konum.transform); Tanlimla(Varis, "Varis");
        GameObject Veba = Instantiate(keremPrefab, konum.transform); Tanlimla(Veba, "Veba");
        GameObject Verem = Instantiate(keremPrefab, konum.transform); Tanlimla(Verem, "Verem Hastal���");
        GameObject Visne = Instantiate(keremPrefab, konum.transform); Tanlimla(Visne, "Vi�ne");
        #endregion

        // Y 
        #region Y ile baslayanlar
        GameObject Yaban_Mersini = Instantiate(keremPrefab, konum.transform); Tanlimla(Yaban_Mersini, "Yaban Mersini");
        GameObject Yanik = Instantiate(keremPrefab, konum.transform); Tanlimla(Yanik, "Yan�k");
        GameObject Yasemin_Cayi = Instantiate(keremPrefab, konum.transform); Tanlimla(Yasemin_Cayi, "Yasemin �ay�");
        GameObject Yer_Elmasi = Instantiate(keremPrefab, konum.transform); Tanlimla(Yer_Elmasi, "Yer Elmas�");
        GameObject Yesil_Mercimek = Instantiate(keremPrefab, konum.transform); Tanlimla(Yesil_Mercimek, "Ye�il Mercimek");
        GameObject Yogurt = Instantiate(keremPrefab, konum.transform); Tanlimla(Yogurt, "Yo�urt");
        GameObject Yulaf = Instantiate(aliPrefab, konum.transform); Tanlimla(Yulaf, "Yulaf");
        GameObject Yumurta = Instantiate(keremPrefab, konum.transform); Tanlimla(Yumurta, "Yumurta");
        #endregion

        // Z 
        #region Z ile baslayanlar
        GameObject Zehirlenme = Instantiate(keremPrefab, konum.transform); Tanlimla(Zehirlenme, "Zehirlenme");
        GameObject Zemzem_suyu = Instantiate(keremPrefab, konum.transform); Tanlimla(Zemzem_suyu, "Zemzem Suyu");
        GameObject Zencefil = Instantiate(keremPrefab, konum.transform); Tanlimla(Zencefil, "Zencefil");
        GameObject Zerdecal = Instantiate(keremPrefab, konum.transform); Tanlimla(Zerdecal, "Zerde�al");
        GameObject Zeytin = Instantiate(keremPrefab, konum.transform); Tanlimla(Zeytin, "Zeytin");
        GameObject ZeytinYagi = Instantiate(aliPrefab, konum.transform); Tanlimla(ZeytinYagi, "Zeytinya��");
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

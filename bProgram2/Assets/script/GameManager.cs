using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;



public class GameManager : MonoBehaviour
{
    [SerializeField] private Image Bilgibackground;

    [SerializeField] private  GameObject panel;

    //bilgi sayfasinin konumunu çekmek için ekran büyütünce gözüküyordu
    public Transform enSag;
    public Transform bilgiEnSol;
    public GameObject yararTextObje,kategoributonlarbosObje;
    public Image AnaResim,urunresimImage;
    
    bool bilgisayfasiacikmi,kategoripanelAcikmi,resimdonuyormu;

    public Text okyonuText,yararText,dondurmebutonText;

    public float urunresimdonushizi;

    ara _ara;
    

    private void Awake()
    {
        _ara = Object.FindObjectOfType<ara>();
    }

    private void Start()
    {

        resimdonuyormu = true;
        bilgisayfasiacikmi = false;
        kategoripanelAcikmi = false;

        okyonuText.text = ">";
        panel.GetComponent<RectTransform>().DOLocalMoveX(0, 0f);
        Bilgibackground.GetComponent<RectTransform>().DOLocalMoveX((enSag.GetComponent<RectTransform>().localPosition.x)-(bilgiEnSol.GetComponent<RectTransform>().localPosition.x), 0f);
    }

    private void FixedUpdate()
    {
      
     // ana resmin döndürülmesis
        AnaResim.transform.Rotate(Vector3.back * 10f * Time.deltaTime);

        if (Bilgibackground.GetComponent<RectTransform>().position.x == 0 )
        {
            bilgisayfasiacikmi = true;
            _ara.urunAra.text = "";
        }
        else
        {
            bilgisayfasiacikmi = false;
            urunresimImage.transform.rotation = new Quaternion(0,0,0,0);
            yararText.rectTransform.sizeDelta = new Vector2(0, yararText.text.Length);
        }

        // ürün resminin döndürülme ve durdurulma iþlemi
        if (bilgisayfasiacikmi == true && resimdonuyormu==true)
        {
            urunresimImage.transform.Rotate(Vector3.up * urunresimdonushizi * Time.fixedDeltaTime);
        }
        else
            urunresimImage.transform.rotation = new Quaternion(0, 0, 0, 0);


        if (bilgisayfasiacikmi == false)
        {
            _ara.sonrakiSayfaButon.SetActive(true);
            _ara.oncekiSayfaButon.SetActive(true);
        }
        
      

        if (panel.GetComponent<RectTransform>().position.x <=0)
        {
            kategoripanelAcikmi = true;
        }
        else 
        {
            kategoripanelAcikmi = false;
        }

        

    }

    //kategori panelini açýp kapama butonu basýlýnca kategori paneli ekrana gelir gider
    public  void panelkaydirmaButon()
    {
        okyonuText.GetComponent<RectTransform>().localScale *= -1;          //ok yönünü deðiþtirme (scaleden)

        if (panel.GetComponent<RectTransform>().localPosition.x <= 0)
        {
            panel.GetComponent<RectTransform>().DOLocalMoveX(160, 0.5f);
        }

        if (panel.GetComponent<RectTransform>().localPosition.x == 160)
        {
            panel.GetComponent<RectTransform>().DOLocalMoveX(0, 0.5f);
        }

        if (kategoripanelAcikmi==false)
        {
            kategoributonlarbosObje.GetComponent<RectTransform>().DOLocalMoveY(0, 0.1f).SetDelay(0.5f);
        }

    }

                                                                                                 //kategori butonlarýndan birine basýldýðýnda 
    public void baslikButonunaBasildiginda()
    {
            
        //bilgi kýsmý x ekseninde kayarak ekrana gelir
        Bilgibackground.GetComponent<RectTransform>().DOLocalMoveX(0, 0.5f);
        
        

    }                                                  //bütün ürünleri clon ile çekince bu kodu silcez

                                                                                                 //öncekisayfa butonu fonksiyonu basýldýðýnda anasayfaya döner
    public void öncekisayfaButon()
    {
        Bilgibackground.GetComponent<RectTransform>().DOLocalMoveX((enSag.GetComponent<RectTransform>().localPosition.x) - (bilgiEnSol.GetComponent<RectTransform>().localPosition.x), 0.5f);
        yararTextObje.GetComponent<RectTransform>().DOLocalMoveY(0, 0.1f).SetDelay(0.5f);
    }


    //resim döndürme butonu kodu döndürme iþlemi üstte burada sadece text ve bool deðiþtirme iþlemi yapýlmakta
    public void resimDondurmeAcKapa()
    {
        if (resimdonuyormu == true)
        {
            resimdonuyormu = false;
            dondurmebutonText.text = " Döndürmeyi Baþlat ";
        }
        else
        {
            resimdonuyormu = true;
            dondurmebutonText.text = " Döndürmeyi Durdur ";
        }
    }


}
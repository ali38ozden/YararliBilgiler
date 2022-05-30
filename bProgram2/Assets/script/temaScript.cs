using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class temaScript : MonoBehaviour
{
    #region ayarlar
    bool acikmi = true;
    public Text sesText;
    public GameObject ayarlar;
    public Image muzukImage;
    public Sprite[] muzukdurumlarý;

    public GameObject UrunlerBackGraund, BilgiBackGround, BackGraund, kategoriaçmaButon,bilgialtkisimCizgi, altkisimCizgi,bilgialtkisim, altkisim, ayar, ayar_1,ayarlarBackGraund,informationPanel;
    public Text bilgiText,BaþlýkText,faydaliBilgilerText,ayarlaryazisiText;

    public AudioSource muzik;

    #endregion
    
    private void Awake()
    {
        renkDegis();
    }
    void renkDegis()
    {
        if(PlayerPrefs.GetString("tema")== "koyu")
        {

            ayarlar.GetComponent<Image>().color = new Color(39f / 255f, 43f / 255f, 28f / 255f);
            BilgiBackGround.GetComponent<Image>().color = new Color(39f / 255f, 43f / 255f, 28f / 255f);
            BackGraund.GetComponent<Image>().color = new Color(39f / 255f, 43f / 255f, 28f / 255f);
            altkisim.GetComponent<Image>().color = new Color(52f / 255f,58f / 255f,34f / 255f);
            bilgialtkisim.GetComponent<Image>().color = new Color(52f / 255f,58f / 255f,34f / 255f);
            altkisimCizgi.GetComponent<Image>().color = new Color(68f / 255f, 77f / 255f, 42f / 255f);
            bilgialtkisimCizgi.GetComponent<Image>().color = new Color(68f / 255f, 77f / 255f, 42f / 255f);

            UrunlerBackGraund.GetComponent<Image>().color = new Color(82f / 255f, 103f / 255f, 80f / 255f);
            kategoriaçmaButon.GetComponent<Image>().color = new Color(82f / 255f, 103f / 255f, 80f / 255f);
            ayar.GetComponent<Image>().color = new Color(82f / 255f, 103f / 255f, 80f / 255f);
            ayar_1.GetComponent<Image>().color = new Color(82f / 255f, 103f / 255f, 80f / 255f);

            bilgiText.color = Color.white;
            BaþlýkText.color = Color.white;
            faydaliBilgilerText.color = Color.white;
            ayarlaryazisiText.color = Color.white;

        }
        else if (PlayerPrefs.GetString("tema") == "açýk")
        {
            ayarlar.GetComponent<Image>().color = new Color(112 / 255f, 166 / 255f, 96 / 255f);
            BilgiBackGround.GetComponent<Image>().color = new Color(112 / 255f, 166 / 255f, 96 / 255f);
            BackGraund.GetComponent<Image>().color = new Color(112 / 255f, 166 / 255f, 96 / 255f);
            altkisim.GetComponent<Image>().color = new Color(63f / 255f,111f / 255f,49f / 255f);
            bilgialtkisim.GetComponent<Image>().color = new Color(63f / 255f,111f / 255f,49f / 255f);
            altkisimCizgi.GetComponent<Image>().color = new Color(81f / 255f,135f / 255f,65f / 255f);
            bilgialtkisimCizgi.GetComponent<Image>().color = new Color(81f / 255f,135f / 255f,65f / 255f);

            UrunlerBackGraund.GetComponent<Image>().color = new Color(142 / 255f, 202 / 255f, 47 / 255f);
            kategoriaçmaButon.GetComponent<Image>().color = new Color(142 / 255f, 202 / 255f, 47 / 255f);
            ayar.GetComponent<Image>().color = new Color(142 / 255f, 202 / 255f, 47 / 255f);
            ayar_1.GetComponent<Image>().color = new Color(142 / 255f, 202 / 255f, 47 / 255f);

            bilgiText.color = Color.black;
            BaþlýkText.color = Color.black;
            faydaliBilgilerText.color = Color.black;
            ayarlaryazisiText.color = Color.black;

        }
        else if (PlayerPrefs.GetString("tema") == "siyah")
        {
            ayarlar.GetComponent<Image>().color = new Color(30 / 255f, 30 / 255f, 30 / 255f);
            BilgiBackGround.GetComponent<Image>().color = new Color(30 / 255f, 30 / 255f, 30 / 255f);
            BackGraund.GetComponent<Image>().color = new Color(30 / 255f, 30 / 255f, 30 / 255f);
            altkisim.GetComponent<Image>().color = new Color(19f / 255f, 16f / 255f, 16f / 255f);
            bilgialtkisim.GetComponent<Image>().color = new Color(19f / 255f, 16f / 255f, 16f / 255f);
            altkisimCizgi.GetComponent<Image>().color = new Color(46f / 255f,45f / 255f,45f / 255f);
            bilgialtkisimCizgi.GetComponent<Image>().color = new Color(46f / 255f,45f / 255f,45f / 255f);

            UrunlerBackGraund.GetComponent<Image>().color = new Color(125 / 255f, 125 / 255f, 125 / 255f);
            kategoriaçmaButon.GetComponent<Image>().color = new Color(125 / 255f, 125 / 255f, 125 / 255f);
            ayar.GetComponent<Image>().color = new Color(125 / 255f, 125 / 255f, 125 / 255f);
            ayar_1.GetComponent<Image>().color = new Color(125 / 255f, 125 / 255f, 125 / 255f);

            bilgiText.color = Color.white;
            BaþlýkText.color = Color.white;
            faydaliBilgilerText.color = Color.white;
            ayarlaryazisiText.color = Color.white;

        }
        else if (PlayerPrefs.GetString("tema") == "beyaz")
        {
            ayarlar.GetComponent<Image>().color = Color.white;
            BilgiBackGround.GetComponent<Image>().color = Color.white;
            BackGraund.GetComponent<Image>().color = Color.white;
            altkisim.GetComponent<Image>().color = new Color(138f / 255f, 138f / 255f, 138f / 255f);
            bilgialtkisim.GetComponent<Image>().color = new Color(138f / 255f, 138f / 255f, 138f / 255f);
            altkisimCizgi.GetComponent<Image>().color = new Color(193f/255f,193f/255f,193f/255f);
            bilgialtkisimCizgi.GetComponent<Image>().color = new Color(193f/255f,193f/255f,193f/255f);

            UrunlerBackGraund.GetComponent<Image>().color = new Color(125 / 255f, 125 / 255f, 125 / 255f);
            kategoriaçmaButon.GetComponent<Image>().color = new Color(125 / 255f, 125 / 255f, 125 / 255f);
            ayar.GetComponent<Image>().color = new Color(125 / 255f, 125 / 255f, 125 / 255f);
            ayar_1.GetComponent<Image>().color = new Color(125 / 255f, 125 / 255f, 125 / 255f);

            bilgiText.color = Color.black;
            BaþlýkText.color = Color.black;
            faydaliBilgilerText.color = Color.black;
            ayarlaryazisiText.color = Color.black;

        }
    }
    public void Ayarlar(string nerde)
    {
        if (nerde == "ekranda")
            ayarlar.GetComponent<RectTransform>().DOLocalMoveY(0, 0.5f);
        else if (nerde == "dýþarda")
            ayarlar.GetComponent<RectTransform>().DOLocalMoveY(-853, 0.5f);
       
    }

    public void HangiTema(string tema)
    {
        if (tema == "koyu")
        {
            PlayerPrefs.SetString("tema", "koyu");
            renkDegis();
        }
        else if (tema == "açýk")
        {
            PlayerPrefs.SetString("tema", "açýk");
            renkDegis();
        }
        else if (tema == "siyah")
        {
            PlayerPrefs.SetString("tema", "siyah");
            renkDegis();
        }
        else if (tema == "beyaz")
        {
            PlayerPrefs.SetString("tema", "beyaz");
            renkDegis();
        }

    }
    public void SesAcKapa()
    {

        if (acikmi == true)
        {
            acikmi = false;
            sesText.text = "Kapalý";
            
        }
        else
        {
            acikmi = true;
            sesText.text = "Açýk";
            
        }


        if (acikmi == true)
        {
            //buraya ses açýk yada kapalý ekliyce
            muzik.Play();
            muzukImage.sprite = muzukdurumlarý[0];
        }
        else if (acikmi == false)
        {
            //burayada
            muzik.Pause();
            muzukImage.sprite = muzukdurumlarý[1];
        }

    }




    //information paneli açan buton
    public void informationButton()
    {
        informationPanel.GetComponent<RectTransform>().DOScale(1, 0.5f);
    }


    //information paneli kapatan buton
    public void informationPanelKapatButon()
    {
        informationPanel.GetComponent<RectTransform>().DOScale(0, 0.5f);
    }
}

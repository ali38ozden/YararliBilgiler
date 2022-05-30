using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ara : MonoBehaviour
{
    public InputField urunAra;
    public List<GameObject> isimler = new List<GameObject>();
    public List<string> iName;
    public GameObject urunlerKonum,deleteButon,katagoriAcmaButon,favButon,anaFavButton,katagoriAcmaButtonKonum,oncekiSayfaButon,sonrakiSayfaButon;

    public RectTransform urunBoyutu;
    
    bool favBool;

    int toplamUrunSayisi;

    GameManager _gamemanager;

    private void Awake()
    {
        _gamemanager = Object.FindObjectOfType<GameManager>();
    }

    void Start()
    {
        deleteButon.SetActive(false);
        favBool = false;
        for (int d = 1; d < urunlerKonum.transform.childCount; d++)
        {
            urunlerKonum.transform.GetChild(d).gameObject.GetComponent<Button>().onClick.AddListener(() => favDaVarmý());
            isimler.Add(urunlerKonum.transform.GetChild(d).gameObject);
            iName.Add(urunlerKonum.transform.GetChild(d).gameObject.name.ToLower());
        }

        
    }

  
    public void yazilaniSil()
    {
        urunAra.text = "";
    }


    public void degis()
    {
        for (int k = 0; k < isimler.Count; k++)
        {
            isimler[k].SetActive(false);
            bool bumu = true;

            for (int i = 0; i < urunAra.text.Length; i++)
            {
                
                if (urunAra.text.Length<=iName[k].Length)
                {
                    if (urunAra.text[i] == iName[k][i])
                    {
                        for(int a=0;a<urunAra.text.Length;a++)
                        {                                                                       
                            if(i-a>=0)
                            {
                                if (urunAra.text[i - a] != iName[k][i - a])
                                {
                                    bumu = false;
                                }
                               
                            }
                        }
                        if (bumu == true)
                        {
                            isimler[k].SetActive(true);


                        }
                    }
                    else
                    {
                        isimler[k].SetActive(false);
                    }
                }
            }
        }
        
        if (urunAra.text == "")
        {
            for (int i = 0; i < isimler.Count; i++)
            {
                isimler[i].SetActive(true);
                deleteButon.SetActive(false);
                eskiBoyutunuGetir();
            }
        }

        if (urunAra.text != "")
        {
            deleteButon.SetActive(true);
            
        }
        

    }
    public void FavoriButtuon(string hangiButton)
    {
        toplamUrunSayisi = 0;
        
        if(hangiButton=="oncekiSayfa")
        {
            if(favBool==true)
            {
                anaFavButton.GetComponent<Image>().color = Color.white;

                KatagoriAcmaButon();
                    
                /*for
                    (int d = 1; d < urunlerKonum.transform.childCount; d--)
                {
                    urunlerKonum.transform.GetChild(d).gameObject.SetActive(true);
                }*/
                eskiBoyutunuGetir();
                favBool = false;
            }
        }
        else if(hangiButton=="anaFavButton")
        {
            if (favBool == false)
            {
                anaFavButton.GetComponent<Image>().color = new Color(142f/225f,202f/225f,47f/225f);
                KatagoriAcmaButon();

                for (int d = 1; d < urunlerKonum.transform.childCount; d++)
                {
                    urunlerKonum.transform.GetChild(d).gameObject.SetActive(false);
                }

                for (int d = 0; d < urunlerKonum.transform.childCount - 1; d++)
                {
                    if (PlayerPrefs.GetInt(isimler[d].name) == 1)
                    {
                        toplamUrunSayisi++;
                        urunlerKonum.transform.GetChild(d + 1).gameObject.SetActive(true);
                    }
                }
                favBool = true;
                urunBoyutu.sizeDelta = new Vector2(154.04f, toplamUrunSayisi * 35.5f);
            }
            else
            {
                anaFavButton.GetComponent<Image>().color = Color.white;
                KatagoriAcmaButon();
                for
                    (int d = 1; d < urunlerKonum.transform.childCount; d++)
                {
                    urunlerKonum.transform.GetChild(d).gameObject.SetActive(true);
                }
                eskiBoyutunuGetir();
                favBool = false;
            }
        }
    }

    public void Childbul(string buton)
    {
        
        if (buton == "sonraki")
        {
            for ( int d = 0; d < isimler.Count; d++)
            {
                oncekiSayfaButon.SetActive(true);

                if (PlayerPrefs.GetString("urunisim") == isimler[d].name)
                {
                    d = d + 2;
                    if (isimler.Count >= d)
                    {
                        
                        urunlerKonum.transform.GetChild(d).gameObject.GetComponent<Button>().onClick.Invoke();
                        _gamemanager.yararText.rectTransform.sizeDelta = new Vector2(0, _gamemanager.yararText.text.Length);

                        _gamemanager.yararTextObje.GetComponent<RectTransform>().DOLocalMoveY(0, 0.1f);

                        if (d == isimler.Count )
                        {
                            sonrakiSayfaButon.SetActive(false);
                        }
                    }
                }
            }

        }

        //bir önceki sayfa butonu kodu

        if (buton == "önceki")
        {


            for ( int d = 1; d < isimler.Count; d++)
            {
                sonrakiSayfaButon.SetActive(true);

                if (PlayerPrefs.GetString("urunisim") == isimler[d].name)
                {

                    if (isimler.Count >= d)
                    {
                        

                        urunlerKonum.transform.GetChild(d).gameObject.GetComponent<Button>().onClick.Invoke();
                        _gamemanager.yararText.rectTransform.sizeDelta = new Vector2(0, _gamemanager.yararText.text.Length);

                        _gamemanager.yararTextObje.GetComponent<RectTransform>().DOLocalMoveY(0, 0.1f);

                        if (d==1 )
                        {
                            oncekiSayfaButon.SetActive(false);

                        }
                        

                    }
                }
            }
        }


        favDaVarmý();
    }

    public void favEkle()
    {
        if (PlayerPrefs.GetInt(PlayerPrefs.GetString("urunisim"))==0)
        {
            PlayerPrefs.SetInt(PlayerPrefs.GetString("urunisim"), 1);
            favButon.GetComponent<Image>().color = Color.white;
        }else
        {
            PlayerPrefs.SetInt(PlayerPrefs.GetString("urunisim"), 0);
            favButon.GetComponent<Image>().color = Color.black;
        }
        
    }
    public void favDaVarmý()
    {
        //fav renk degismek icin 
        if (PlayerPrefs.GetInt(PlayerPrefs.GetString("urunisim")) == 1)
        {           
            favButon.GetComponent<Image>().color = Color.white;
        }
        else
        {
            favButon.GetComponent<Image>().color = Color.black;
        }
    }

    void eskiBoyutunuGetir()
    {
        toplamUrunSayisi = urunBoyutu.gameObject.transform.childCount;
        urunBoyutu.sizeDelta = new Vector2(154.04f, toplamUrunSayisi * 35.5f);
    }

    void KatagoriAcmaButon()
    {
        if (katagoriAcmaButtonKonum.GetComponent<RectTransform>().localPosition.x <= 0)
        {
            katagoriAcmaButon.GetComponent<Button>().onClick.Invoke();
        }

    }
   
}

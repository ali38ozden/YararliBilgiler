using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kaydirma : MonoBehaviour
{
    int toplamUrunSayisi;
    public RectTransform urun;

    void Start()
    {
        toplamUrunSayisi=this.gameObject.transform.childCount;
        urun.sizeDelta = new Vector2(154.04f, toplamUrunSayisi*35.5f);
    }
    public void sizeDuzenle()
    {
        toplamUrunSayisi = this.gameObject.transform.childCount;
        urun.sizeDelta = new Vector2(154.04f, toplamUrunSayisi* 35.5f);
    }
}

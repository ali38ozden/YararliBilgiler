using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class urunlerScript : MonoBehaviour
{
    string Urunname;
    private void Start()
    {
        Urunname = this.name;

        //PlayerPrefs.SetInt(Urunname, 0);
        //urunname hepisnin 0 eþitliycez ondan sonra burdaki kodu silcez yada bir kere çalýþcak þekilde ayarlýcaz
        //sonra fav eklediðinde 1 çevircez en sonda da da favgöster basýlýnca sadece 1 olanalarý true yapýcak
    }
}

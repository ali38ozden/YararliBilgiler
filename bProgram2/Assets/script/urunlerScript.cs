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
        //urunname hepisnin 0 e�itliycez ondan sonra burdaki kodu silcez yada bir kere �al��cak �ekilde ayarl�caz
        //sonra fav ekledi�inde 1 �evircez en sonda da da favg�ster bas�l�nca sadece 1 olanalar� true yap�cak
    }
}

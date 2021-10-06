using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class cekiconmouse : MonoBehaviour
{
   
    
    public static int can = 2;


    private void OnMouseDown()
    {  
        if (can >= 0)
        {
            can--;
            Animasyon.deger = true;
        }
        Destroy(gameObject);
        
    }
    private void OnTriggerEnter2D(Collider2D nesne)
    {
        if (nesne.gameObject.tag == "Vida")
        {
            Destroy(nesne.gameObject);
        }
        if (nesne.gameObject.tag == "Lehim")
        {
            Destroy(nesne.gameObject);
        }
        else if (nesne.gameObject.tag == "Çekiç")
        {
            Destroy(nesne.gameObject);
        }
    }
}
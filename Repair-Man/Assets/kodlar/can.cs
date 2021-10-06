using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class can : MonoBehaviour
{   
    public Text canmiktari;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string cani = cekiconmouse.can.ToString();
        canmiktari.text = cani;



        if (cekiconmouse.can == 0)
        {
            

            SceneManager.LoadScene(6);


           
            cekiconmouse.can = 2;
        }
    }
}

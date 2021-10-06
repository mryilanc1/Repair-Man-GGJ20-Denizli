using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sonuç : MonoBehaviour
{
    public UnityEngine.UI.Text text;
    public static float sayac=60;
    private void Update()
    {
        sayac = sayac - Time.deltaTime;
        text.text = "" + (int)sayac;
        if(sayac<0 )
        {

            SceneManager.LoadScene(6);

        }
    }
}

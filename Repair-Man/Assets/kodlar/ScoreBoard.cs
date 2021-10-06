using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreBoard : MonoBehaviour
{
    public UnityEngine.UI.Text score;
    void Start()
    {
        score.text ="" + (Sonuç.sayac*37);
    }
    public void yenile()
    {
        SceneManager.LoadScene(1);
        cekiconmouse.can = 2;
        Sonuç.sayac = 60;
    }
    public void cikis()
    {
        Application.Quit(0);
    }
}

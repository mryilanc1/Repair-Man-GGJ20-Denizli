using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sahnegecis : MonoBehaviour
{
    public GameObject kapanmauı;
   public void sahnegeci()
    {

        SceneManager.LoadScene(1);

    }
    public void yenidenoyun()
    {
        kapanmauı.SetActive(false);
        SceneManager.LoadScene(1);
        Sonuç.sayac = 60;

    }
    
}

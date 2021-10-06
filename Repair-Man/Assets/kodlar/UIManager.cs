using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public int alet1, alet2;
    public GameObject tv1, tv2, tv3, basarı, objesil, nexttext;
    public TMPro.TMP_Text vida, lehim;
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("vida", 0);
        PlayerPrefs.SetInt("lehim", 0);
        alet1 = PlayerPrefs.GetInt("vida");
        alet2 = PlayerPrefs.GetInt("lehim");
    }
    private void Update()
    {
        if (!PlayerPrefs.HasKey("vida"))
        {
            alet1 = 0;
            alet2 = 0;
        }
        lehim.text = "" + alet2;
        vida.text = "" + alet1;
        if (alet1 == 1 || alet2 == 1)
        {
            tv1.SetActive(false);
            tv2.SetActive(true);
        }
        if (alet1 == 2 && alet2 == 1)
        {
            tv2.SetActive(false);
            tv3.SetActive(true);
        }
        if (alet1>2)
        {
            alet1 = 2;
        }
        if (alet2>1)
        {
            alet2 = 1;
        }
        if (alet1 == 2 && alet2 == 1)
        {//vida ve lehim sayıları doğruysa sonraki seviyeye geçiliyor.
            basarı.SetActive(true);
            nexttext.SetActive(true);
            
            StartCoroutine(nextlevelbekle());
            
        }
       
    }
    public void vidatik()
    {
        //nesnenin tıklanması halinde vida sayısı arttırılıyor.
        alet1++;
        PlayerPrefs.SetInt("vida", alet1);
    }
    public void lehimtik()
    {
        //nesnenin tıklanması halinde lehim sayısı arttırılıyor.
        alet2++;
        PlayerPrefs.SetInt("lehim", alet2);
    }
    IEnumerator nextlevelbekle()
    {
        yield return new WaitForSeconds(0.17f);
        objesil.SetActive(false);
        yield return new WaitForSeconds(1.2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        PlayerPrefs.DeleteAll();
    }
}
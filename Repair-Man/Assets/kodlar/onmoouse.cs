﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onmoouse : MonoBehaviour
{
    AudioSource audio;
    public AudioClip odul;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void OnMouseDown()
    {//nesnenin tıklanması halinde scriptteki fonksiyon çağırılıp nesne yok ediliyor.
        UIManager.instance.vidatik();
        audio.PlayOneShot(odul);
        StartCoroutine(sesbekle());
        
    }
    private void OnTriggerEnter2D(Collider2D nesne)
    {
        if (nesne.gameObject.tag=="Çekiç")
        {
            Destroy(nesne.gameObject);
        }
        if (nesne.gameObject.tag == "Lehim")
        {
            Destroy(nesne.gameObject);
        }
        else if (nesne.gameObject.tag=="Vida")
        {
            Destroy(nesne.gameObject);
        }
    }
    IEnumerator sesbekle()
    {
        yield return new WaitForSeconds(0.28f);

        Destroy(gameObject, 0.1f);
    }
}
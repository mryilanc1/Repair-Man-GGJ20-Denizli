using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animasyon : MonoBehaviour
{

    Animator anim;
    public static bool deger = false;
    AudioSource audio;
    public AudioClip kalp1;


    void Start()
    {
        anim = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();

    }
    void Update()
    {

        if (deger == true)
        {
            StartCoroutine(deneme());
            deger = false;
        }


        
    }

    IEnumerator deneme ()
    {
        anim.SetBool("cankırma", true);

        audio.PlayOneShot(kalp1);
        

        yield return new WaitForSeconds(1f);

        anim.SetBool("cankırma", false);
    }
}


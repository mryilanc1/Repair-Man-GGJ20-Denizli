using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSil : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D nesne)
    {
        Destroy(nesne.gameObject);
    }
}

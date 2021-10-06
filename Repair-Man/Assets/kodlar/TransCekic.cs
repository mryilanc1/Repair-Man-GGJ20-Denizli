using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransCekic : MonoBehaviour
{
    GameObject Cekic;
    public float hız;
    // Start is called before the first frame update
    void Start()
    {
        Cekic = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -1 * hız * Time.deltaTime, 0);
    }
}

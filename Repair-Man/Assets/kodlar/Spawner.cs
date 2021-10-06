using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] Spawnpoint;
    public List<GameObject> dizim = new List<GameObject>();
    private void Start()
    {
        StartCoroutine(olustur());
    }
    private void Update()
    {
        
    }
    IEnumerator olustur()
    {
        Olusturucu();
        yield return new WaitForSeconds(0.4f);
        Olusturucu();
        yield return new WaitForSeconds(0.8f);
        Olusturucu();
        yield return new WaitForSeconds(0.8f);
        Olusturucu();
        yield return new WaitForSeconds(0.4f);
        StartCoroutine(olustur());
    }
    void Olusturucu()
    {
        int span = Random.Range(0, 3);
        int eleman = Random.Range(0, 3);
        GameObject go = Instantiate(dizim[eleman]) as GameObject;
        Transform Spawn = (Spawnpoint[span]) as Transform;
        go.transform.parent = Spawn;
        go.transform.localPosition = new Vector3(Random.Range(-125,125),6f, 0);
    }
}
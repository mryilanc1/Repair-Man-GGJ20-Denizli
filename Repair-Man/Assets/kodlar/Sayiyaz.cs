using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Sayiyaz : MonoBehaviour
{
    public int lvl1a, lvl1b, lvl2a, lvl2b, lvl3a, lvl3b, lvl4a, lvl4b;
    public void lvl1()
    {
        lvl1a = UIManager.instance.alet1;
        lvl1b = UIManager.instance.alet2;
    }
    public void lvl2()
    {
        lvl2a = UIManager.instance.alet1;
        lvl2b = UIManager.instance.alet2;
    }
    public void lvl3()
    {
        lvl3a = UIManager.instance.alet1;
        lvl3b = UIManager.instance.alet2;
    }
    public void lvl4()
    {
        lvl4a = UIManager.instance.alet1;
        lvl4b = UIManager.instance.alet2;
    }
}
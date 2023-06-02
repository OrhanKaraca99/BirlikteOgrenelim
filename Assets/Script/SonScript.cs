using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SonScript : MonoBehaviour
{

    public GameObject menu;
    private int toplam = 5, toplamaraba=4;
    private int i = 0;
    public void level_son()
    {
        i++;
        if (i == toplam)
        {
            menu.SetActive(true);
        }
    }

     public void level_son_matematik()
    {
            menu.SetActive(true);
    }

    public void level_son_araba()
    {
        i++;
        if (i == toplamaraba)
        {
            menu.SetActive(true);
        }
    }
    public void gerigitme()
    {
        SceneManager.LoadScene(0);
    }
    public void hayvansonraki()
    {
        SceneManager.LoadScene(2);
    }
    public void renksonraki()
    {
        SceneManager.LoadScene(3);
    }
    public void sekilsonraki()
    {
        SceneManager.LoadScene(4);
    }
    public void arabasonraki()
    {
        SceneManager.LoadScene(5);
    }
    public void matematiksonraki()
    {
        SceneManager.LoadScene(0);
    }
    




}

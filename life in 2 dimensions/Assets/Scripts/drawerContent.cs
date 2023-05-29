using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class drawerContent : MonoBehaviour
{
    public Image Background1;
    public Image Background2;
    public TextMeshProUGUI Clues1;
    public TextMeshProUGUI Clues2;
    public TextMeshProUGUI Clues3;
    public TextMeshProUGUI Clues4;
    public TextMeshProUGUI Clues5;
    public TextMeshProUGUI Clues6;
    public Button closeDrawerButton1;
    public Button closeDrawerButton2;
    public Button closeDrawerButton3;


    void Start()
    {
        Background1.enabled = false;
        Background2.enabled = false;
        Clues1.enabled = false;
        Clues2.enabled = false;
        Clues3.enabled = false;
        Clues4.enabled = false;
        Clues5.enabled = false;
        Clues6.enabled = false;
        closeDrawerButton1.gameObject.SetActive(false);
        closeDrawerButton2.gameObject.SetActive(false);
        closeDrawerButton3.gameObject.SetActive(false);
    }
    public void OpenDrawer()
    {
        Background1.enabled = true;
        Clues1.enabled = true;
        Clues2.enabled = true;
        closeDrawerButton1.gameObject.SetActive(true);

    }

    public void CloseDrawer()
    {
        Background1.enabled = false;
        Clues1.enabled = false;
        Clues2.enabled = false;
        closeDrawerButton1.gameObject.SetActive(false);
    }

    public void OpenDrawer2()
    {
        Background2.enabled = true;
        Clues3.enabled = true;
        Clues4.enabled = true;
        closeDrawerButton2.gameObject.SetActive(true);
    }

    public void CloseDrawer2()
    {
        Background2.enabled = false;
        Clues3.enabled = false;
        Clues4.enabled = false;
        closeDrawerButton2.gameObject.SetActive(false);
    }

    public void OpenDrawer3()
    {
        Background2.enabled = true;
        Clues5.enabled = true;
        Clues6.enabled = true;
        closeDrawerButton3.gameObject.SetActive(true);

    }

    public void CloseDrawer3()
    {
        Background2.enabled = false;
        Clues5.enabled = false;
        Clues6.enabled = false;
        closeDrawerButton3.gameObject.SetActive(false);
    }
}

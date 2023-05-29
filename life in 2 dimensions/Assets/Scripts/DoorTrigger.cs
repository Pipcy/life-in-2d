using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class DoorTrigger : MonoBehaviour
{
    public Button openDrawerButton;
    //public Button closeDrawerButton;
    
    


    private void Start()
    {
        openDrawerButton.gameObject.SetActive(false);
        
    
  
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("OldPlayer"))
        {
            openDrawerButton.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("OldPlayer"))
        {
            openDrawerButton.gameObject.SetActive(false);
        }
    }

    // public void OpenDrawer()
    // {
    //     openDrawerButton.gameObject.SetActive(false);
    //     closeDrawerButton.gameObject.SetActive(true);
    //     Background.enabled = true;
    //     Clues.enabled = true;
    //     Clues2.enabled = true;

    // }

    // public void CloseDrawer()
    // {
    //     closeDrawerButton.gameObject.SetActive(false);
    //     Background.enabled = false;
    //     Clues.enabled = false;
    //     Clues2.enabled = false;
    // }
    

}

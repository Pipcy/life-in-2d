// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class DoorTrigger : MonoBehaviour
// {
//     [SerializeField] GameObject door;
//     // Start is called before the first frame update
//     void Start()
//     {
//         door.GetComponent<BoxCollider2D>().enabled=true;//public BoxCollider2D collider
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }

//     private void OnCollisionStay2D(Collision2D collision) { 
//         if (collision.gameObject.tag == "Player") {
//             Debug.Log("Found player");
//             door.GetComponent<BoxCollider2D>().enabled=false;
//         }
//     }
// }

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DoorTrigger : MonoBehaviour
{
    public Button openDoorButton;
    public GameObject doorObject;
    
    private BoxCollider2D doorCollider;
    private bool isPlayerInRange = false;

    private void Start()
    {
        doorCollider = doorObject.GetComponent<BoxCollider2D>();
        openDoorButton.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //Debug.Log("See Player");
            isPlayerInRange = true;
            openDoorButton.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = false;
            openDoorButton.gameObject.SetActive(false);
        }
    }

    public void OpenDoor()
    {
        doorCollider.enabled = false;
        openDoorButton.gameObject.SetActive(false);

        StartCoroutine(EnableColliderAfterDelay(3f));
    }

    private IEnumerator EnableColliderAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        doorCollider.enabled = true;
    }
}


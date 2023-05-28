using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostAttack : MonoBehaviour
{
    DreamAttack PlayerAttackScript;

    void Start() {
        //GameObject player =  GameObject.Find("GetAttackedRange"); 
        //PlayerAttackScript = player.GetComponent<DreamAttack>();
    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the player enters the enemy's range
        // if (collision.CompareTag("PlayerAttackRange"))
        // {
        //     PlayerAttackScript.TakeDamage(10);
        // }

        if (collision.CompareTag("spear")){
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        // Check if the player exits the enemy's range
        // if (collision.CompareTag("PlayerAttackRange"))
        // {
        //     //
        // }
    }
}

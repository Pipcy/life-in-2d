using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DreamAttack : MonoBehaviour
{
    GameObject sword;
    private bool enemyInRange;//a small range, where enemy can hurt player

    private float currentHealth;
    private float maxHealth = 100f;
    public bool dead = false;
    private float initialBarWidth;
    public RectTransform healthBar;

    void Start()
    {
        initialBarWidth = healthBar.sizeDelta.x;
        //sword.SpriteRenderer.enabled = false;
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0)){
            Attack();
        }

        if(Input.GetMouseButtonDown(2))
            TakeDamage(10);
    }

    void Attack(){
        Debug.Log("Attacked");
        //sword.enabled = true;
    }


    public void TakeDamage(float _damage)
    {
        
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, maxHealth);
        float healthPercentage = currentHealth / maxHealth;
        healthBar.sizeDelta = new Vector2(initialBarWidth * healthPercentage, healthBar.sizeDelta.y);
        if (currentHealth > 0)//7.3
        {
            //player hurt
            //anim.SetTrigger("hurt");/
        }
        else
        {
            //player dead
            if (!dead)
            {
            //anim.SetTrigger("die");
            //GetComponent<PlayerMovement>().enabled = false;
            dead = true;
            }
            
        }
    }
}

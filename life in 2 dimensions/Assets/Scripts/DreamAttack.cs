using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//****

public class DreamAttack : MonoBehaviour
{
    GameObject sword;
    private bool enemyInRange;//a small range, where enemy can hurt player

    float period = 0;

    private float currentHealth;
    private float maxHealth = 100f;
    public bool dead = false;
    private float initialBarWidth;
    public RectTransform healthBar;
    public AudioSource damageAudio;

    void Start()
    {
        initialBarWidth = healthBar.sizeDelta.y;
        //sword.SpriteRenderer.enabled = false;
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("period: " + period + "         current Health: " + currentHealth);
        if (Input.GetMouseButtonDown(0)){
            Attack();
        }

        // if(Input.GetMouseButtonDown(2))
        //     TakeDamage(10);
        if (dead){
            SceneManager.LoadScene("EndingLost"); }
        
        
    }

    void Attack(){
        Debug.Log("Attacked");
        //sword.enabled = true;
    }


    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Enemy")) 
            {   
                period += UnityEngine.Time.deltaTime;
                
                if (period > 1f)//when ground color not equal to player color
                {
                    TakeDamage(3);
                    period = 0;
                }    
            }
            

    }
    public void TakeDamage(float _damage)
    {
        damageAudio.Play();
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, maxHealth);
        float healthPercentage = currentHealth / maxHealth;
        healthBar.sizeDelta = new Vector2(healthBar.sizeDelta.x,initialBarWidth * healthPercentage);
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

using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth = 10f;
    public float healthDecreaseRate = 10f;
    public RectTransform healthBar;

    private float initialBarWidth;

    Routine routine;

    void Start()
    {
        currentHealth = 10f;
        initialBarWidth = healthBar.sizeDelta.x;

        GameObject routinee =  GameObject.Find("Routine");
        routine = routinee.GetComponent<Routine>();
    }

    void Update()
    {
        if(routine.isDreaming == false)
        {
            // Decrease health over time
            currentHealth -= healthDecreaseRate * Time.deltaTime;
            currentHealth = Mathf.Clamp(currentHealth, 0f, maxHealth);

            // Update health bar UI
            float healthPercentage = currentHealth / maxHealth;
            healthBar.sizeDelta = new Vector2(initialBarWidth * healthPercentage, healthBar.sizeDelta.y);
            //healthBar.anchoredPosition = new Vector2(-initialBarWidth / 2 + newWidth / 2, healthBar.anchoredPosition.y);

            if(currentHealth < 10)
            {
                routine.Dream();
            }
        }


    }

    public void ResetHealth() {
        currentHealth = 100f;
    }
}



using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth = 100f;
    public float healthDecreaseRate = 10f;
    public RectTransform healthBar;

    private float initialBarWidth;

    void Start()
    {
        initialBarWidth = healthBar.sizeDelta.x;
    }

    void Update()
    {
        // Decrease health over time
        currentHealth -= healthDecreaseRate * Time.deltaTime;
        currentHealth = Mathf.Clamp(currentHealth, 0f, maxHealth);

        // Update health bar UI
        float healthPercentage = currentHealth / maxHealth;
        healthBar.sizeDelta = new Vector2(initialBarWidth * healthPercentage, healthBar.sizeDelta.y);
        //healthBar.anchoredPosition = new Vector2(-initialBarWidth / 2 + newWidth / 2, healthBar.anchoredPosition.y);
    }
}



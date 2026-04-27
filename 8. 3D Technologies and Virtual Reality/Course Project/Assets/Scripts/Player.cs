using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static Player Instance { get; private set; }

    [Header("Player Health")]
    public float maxHealth = 100f;
    private float currentHealth;
    
    [Header("UI")]
    public Image healthBar;
    public TMPro.TextMeshProUGUI healthText;

    public bool isDead { get; private set; } = false;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthUI();
    }

    public void TakeDamage(float amount)
    {
        if (isDead) return;

        currentHealth -= amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        
        UpdateHealthUI();

        Debug.Log($"Player took {amount} damage. Current Health: {currentHealth}");

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        isDead = true;
        Debug.Log("Player has died! Game Over.");

        // Tell all active enemies to play their victory animation
        Enemy[] allEnemies = FindObjectsOfType<Enemy>();
        foreach(Enemy e in allEnemies)
        {
            e.OnPlayerDeath();
        }

        if (GameManager.Instance != null)
        {
            GameManager.Instance.GameOver(false);
        }
    }

    private void UpdateHealthUI()
    {
        if (healthBar != null)
        {
            healthBar.fillAmount = currentHealth / maxHealth;
        }
        
        if (healthText != null)
        {
            healthText.text = $"{currentHealth} / {maxHealth}";
        }
    }
}

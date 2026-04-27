using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(AudioSource))]
public class Enemy : MonoBehaviour
{
    [Header("Enemy Details")]
    public string enemyName = "Enemy";
    public float maxHealth = 100f;
    private float currentHealth;

    [Header("Combat Details")]
    public float attackDamage = 10f;
    public float attackCooldown = 3f;
    private float attackTimer;
    private bool isDead = false;
    [Header("Attack SFX")]
    public AudioClip attackSfx;
    public float attackSfxDelay = 0.5f;

    [Header("References")]
    public Image healthBar;
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI nameText;
    public Image cooldownRadialImage; // WoW-style filled circle
    public GameObject selectionIndicator; 
    
    private Animator animator;
    private AudioSource audioSource;

    private void Start()
    {
        currentHealth = maxHealth;
        attackTimer = attackCooldown; // Start cooldown
        
        audioSource = GetComponent<AudioSource>();

        if (animator == null)
            animator = GetComponent<Animator>();
            
        if (animator == null)
            animator = GetComponentInChildren<Animator>();

        if (nameText != null)
        {
            nameText.text = enemyName;
        }

        UpdateHealthUI();
        SetSelected(false);
    }

    private void Update()
    {
        if (isDead) return;

        // Freeze combat if the game hasn't started or we lost a marker!
        if (GameManager.Instance != null && !GameManager.Instance.isGameActive) return;

        // Ensure Player exists and is alive before processing combat
        if (Player.Instance != null && !Player.Instance.isDead)
        {
            if (attackTimer > 0f)
            {
                attackTimer -= Time.deltaTime;
                
                // Update WoW style cooldown shadow (Radial UI)
                if (cooldownRadialImage != null)
                {
                    cooldownRadialImage.fillAmount = attackTimer / attackCooldown;
                }
            }
            else
            {
                AttackPlayer();
                attackTimer = attackCooldown;
                
                if (cooldownRadialImage != null)
                {
                    cooldownRadialImage.fillAmount = 1f; // Instantly fill the shadow back up
                }
            }
        }
    }

    private void AttackPlayer()
    {
        Debug.Log($"{enemyName} attacks the Player!");
        
        if (animator != null)
        {
            animator.SetTrigger("Attack");
        }

        // Play Sound with Delay
        if (attackSfx != null && audioSource != null)
        {
            Invoke(nameof(PlayAttackSound), attackSfxDelay);
        }

        if (Player.Instance != null)
        {
            // Deal damage to player.
            Player.Instance.TakeDamage(attackDamage);
        }
    }

    private void PlayAttackSound()
    {
        if (audioSource != null && attackSfx != null && !isDead)
        {
            audioSource.PlayOneShot(attackSfx);
        }
    }

    public void TakeDamage(float amount)
    {
        if (isDead) return;

        currentHealth -= amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        UpdateHealthUI();

        Debug.Log($"{enemyName} took {amount} damage! Health: {currentHealth}/{maxHealth}");

        if (currentHealth <= 0)
        {
            Die();
        }
        else
        {
            if (animator != null)
            {
                animator.SetTrigger("Hit");
            }
        }
    }

    private void Die()
    {
        isDead = true;
        CancelInvoke(nameof(PlayAttackSound)); // Cancel any pending attack sounds
        
        Debug.Log($"{enemyName} has been defeated!");
        
        if (animator != null)
        {
            animator.SetTrigger("Die");
        }
        
        if (SelectionManager.Instance.currentSelection == this)
        {
            SelectionManager.Instance.Select(null);
        }

        // Disable UI
        if (healthBar != null) healthBar.gameObject.SetActive(false);
        if (cooldownRadialImage != null) cooldownRadialImage.transform.parent.gameObject.SetActive(false);
        SetSelected(false);

        // Tell the GameManager that an enemy has fallen
        if (GameManager.Instance != null)
        {
            GameManager.Instance.ReportEnemyDeath();
        }
    }

    public void OnPlayerDeath()
    {
        if (isDead) return;
        
        Debug.Log($"{enemyName} celebrates victory!");
        if (animator != null)
        {
            animator.SetTrigger("Victory");
        }
    }

    public void SetSelected(bool isSelected)
    {
        if (selectionIndicator != null)
        {
            selectionIndicator.SetActive(isSelected);
        }

        if (nameText != null)
        {
            nameText.color = isSelected ? Color.red : Color.white;
        }
    }

    public void OnSelectCommand()
    {
        if (!isDead)
        {
            SelectionManager.Instance.Select(this);
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

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[System.Serializable]
public class SpellData
{
    public string spellName;
    public GameObject vfxPrefab;
    public AudioClip sfxClip;
    public float cooldownTime = 5f;
    
    [Header("UI References")]
    public TextMeshProUGUI nameText;
    public Image cooldownRadialImage;

    [HideInInspector] 
    public float currentCooldown = 0f;
}

[RequireComponent(typeof(AudioSource))]
public class SpellManager : MonoBehaviour
{
    public static SpellManager Instance { get; private set; }

    [Header("Player Spells")]
    public List<SpellData> playerSpells = new List<SpellData>();

    private AudioSource audioSource;

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

        audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        // Initialize UI names for spells
        foreach (SpellData spell in playerSpells)
        {
            if (spell.nameText != null)
            {
                spell.nameText.text = spell.spellName;
            }

            // Make sure the shadow starts fully empty (ready to cast)
            if (spell.cooldownRadialImage != null)
            {
                spell.cooldownRadialImage.fillAmount = 0f; 
            }
        }
    }

    private void Update()
    {
        // Freeze cooldowns if the game hasn't started or we lost a marker!
        if (GameManager.Instance != null && !GameManager.Instance.isGameActive) return;

        // Process cooldowns for all spells
        foreach (SpellData spell in playerSpells)
        {
            if (spell.currentCooldown > 0)
            {
                spell.currentCooldown -= Time.deltaTime;
                
                if (spell.currentCooldown <= 0)
                {
                    spell.currentCooldown = 0f; // Clamp exactly to 0
                    if (spell.cooldownRadialImage != null)
                    {
                        spell.cooldownRadialImage.fillAmount = 0f; // Completely hide the shadow
                    }
                }
                else
                {
                    // Update WoW style radial UI (Clock loading)
                    if (spell.cooldownRadialImage != null)
                    {
                        spell.cooldownRadialImage.fillAmount = spell.currentCooldown / spell.cooldownTime;
                    }
                }
            }
        }
    }

    public void CastSpell(string spellName)
    {
        // Don't allow casting before the fight begins!
        if (GameManager.Instance != null && !GameManager.Instance.isGameActive)
        {
            Debug.Log("Cannot cast spell: The fight has not started!");
            return;
        }

        Enemy target = SelectionManager.Instance.currentSelection;

        if (target == null)
        {
            Debug.LogWarning("Cannot cast spell: No target selected!");
            return;
        }

        // Find the spell in our list
        SpellData spellToCast = playerSpells.Find(s => s.spellName.ToLower() == spellName.ToLower());

        if (spellToCast == null)
        {
            Debug.LogWarning("Unknown spell: " + spellName);
            return;
        }

        // Check Cooldown
        if (spellToCast.currentCooldown > 0f)
        {
            Debug.Log($"{spellToCast.spellName} is on cooldown! ({spellToCast.currentCooldown:F1}s left)");
            return;
        }

        // Spawn VFX
        if (spellToCast.vfxPrefab != null)
        {
            // Use the target's exact rotation (including your -80 X fix) and parent it to the target
            // so if you move the AR paper, the spell moves with it!
            Instantiate(spellToCast.vfxPrefab, target.transform.position, target.transform.rotation, target.transform);
            Debug.Log($"Casted {spellToCast.spellName} on {target.enemyName}");
        }
        else
        {
            Debug.LogWarning($"Spell prefab for {spellToCast.spellName} is missing!");
        }

        // Play SFX
        if (spellToCast.sfxClip != null && audioSource != null)
        {
            audioSource.PlayOneShot(spellToCast.sfxClip);
        }

        // Start Cooldown
        spellToCast.currentCooldown = spellToCast.cooldownTime;
        if (spellToCast.cooldownRadialImage != null)
        {
            spellToCast.cooldownRadialImage.fillAmount = 1f; // Instantly fill the shadow
        }
    }
}

using UnityEngine;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;

public class SpeechInput : MonoBehaviour
{
    [Header("Debugging")]
    public TMPro.TextMeshProUGUI debugText;

    private KeywordRecognizer keywordRecognizer;
    private Dictionary<string, System.Action> actions = new Dictionary<string, System.Action>();

    private void Start()
    {
        // 1. Target Selection Commands
        actions.Add("select wizard", () => SelectEnemyByName("Wizard"));
        actions.Add("select orc", () => SelectEnemyByName("Grunt")); // Grunt model is now referred to as Orc
        actions.Add("select golem", () => SelectEnemyByName("Golem"));

        // 2. Dynamic Spell Casting Commands
        // We wait a tiny fraction of a second to ensure SpellManager is fully initialized
        Invoke(nameof(RegisterSpells), 0.1f);
    }

    private void RegisterSpells()
    {
        if (SpellManager.Instance != null && SpellManager.Instance.playerSpells.Count > 0)
        {
            foreach (SpellData spell in SpellManager.Instance.playerSpells)
            {
                string keyword = spell.spellName.ToLower();
                // Avoid adding duplicate keywords if names overlap
                if (!actions.ContainsKey(keyword))
                {
                    actions.Add(keyword, () => SpellManager.Instance.CastSpell(spell.spellName));
                }
            }
        }

        // Start Recognizer after everything is loaded
        if (actions.Keys.Count > 0)
        {
            // Set ConfidenceLevel to Low so it is much more forgiving with accents and background noise!
            keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray(), ConfidenceLevel.Low);
            keywordRecognizer.OnPhraseRecognized += RecognizedSpeech;
            keywordRecognizer.Start();
            Debug.Log("Speech Recognition Started! Registered spells: " + string.Join(", ", SpellManager.Instance.playerSpells.Select(s => s.spellName)));
            
            if (debugText != null)
            {
                debugText.text = "Mic Ready! Say a command...";
            }
        }
    }

    private void RecognizedSpeech(PhraseRecognizedEventArgs speech)
    {
        Debug.Log("Voice Recognized: " + speech.text);
        if (debugText != null)
        {
            debugText.text = "Heard: " + speech.text;
        }

        if (actions.ContainsKey(speech.text))
        {
            actions[speech.text].Invoke();
        }
    }

    private void SelectEnemyByName(string enemyName)
    {
        // Find all enemies in the scene
        Enemy[] enemies = FindObjectsOfType<Enemy>();
        Enemy target = null;
        
        foreach(Enemy e in enemies)
        {
            // Simple match: if the Enemy's configured name contains our requested name
            if (e.enemyName.ToLower().Contains(enemyName.ToLower()) || e.gameObject.name.ToLower().Contains(enemyName.ToLower()))
            {
                target = e;
                break;
            }
        }

        if (target != null)
        {
            SelectionManager.Instance.Select(target);
        }
        else
        {
            Debug.LogWarning($"Could not find an enemy named: {enemyName}");
        }
    }

    private void OnDestroy()
    {
        if (keywordRecognizer != null && keywordRecognizer.IsRunning)
        {
            keywordRecognizer.Stop();
            keywordRecognizer.Dispose();
        }
    }
}

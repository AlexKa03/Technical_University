using System.Collections;
using UnityEngine;
using System.Collections;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(AudioSource))]
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [Header("Game State")]
    public bool isGameActive = false;
    private bool hasGameStarted = false;
    private bool isGameOver = false;
    private int enemiesKilled = 0;

    [Header("Global SFX")]
    public AudioClip fightSfx;
    public AudioClip winSfx;
    public AudioClip loseSfx;
    private AudioSource audioSource;

    [Header("AR Tracking")]
    public int requiredTargets = 3;
    private int currentTargets = 0;

    [Header("UI References")]
    public TextMeshProUGUI statusText; // Top middle text
    public TextMeshProUGUI countdownText; // Center massive text

    private Coroutine countdownCoroutine;

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
        isGameActive = false;
        hasGameStarted = false;
        isGameOver = false;
        enemiesKilled = 0;
        
        if (countdownText != null) countdownText.text = "";
        UpdateStatusText();
    }

    // Called by Vuforia DefaultObserverEventHandler Unity Events
    public void TargetFound()
    {
        currentTargets++;
        currentTargets = Mathf.Min(currentTargets, requiredTargets);
        CheckGameState();
    }

    // Called by Vuforia DefaultObserverEventHandler Unity Events
    public void TargetLost()
    {
        currentTargets--;
        currentTargets = Mathf.Max(currentTargets, 0);
        CheckGameState();
    }

    private void CheckGameState()
    {
        if (isGameOver) return; // Don't interrupt if the game is already over

        UpdateStatusText();

        if (currentTargets >= requiredTargets)
        {
            // All targets found! Start countdown if the game hasn't fully started yet
            if (!hasGameStarted && countdownCoroutine == null)
            {
                countdownCoroutine = StartCoroutine(StartCountdown());
            }
            else if (hasGameStarted)
            {
                // If the game was already running and we just regained tracking, resume!
                isGameActive = true;
                if (statusText != null) statusText.gameObject.SetActive(false);
            }
        }
        else
        {
            // Missing targets! Pause the game and stop the countdown
            isGameActive = false;
            
            if (countdownCoroutine != null)
            {
                StopCoroutine(countdownCoroutine);
                countdownCoroutine = null;
                if (countdownText != null) countdownText.text = "";
            }

            if (statusText != null) statusText.gameObject.SetActive(true);
        }
    }

    private void UpdateStatusText()
    {
        if (statusText == null) return;

        if (currentTargets < requiredTargets)
        {
            statusText.color = Color.red;
            int missing = requiredTargets - currentTargets;
            statusText.text = $"Missing {missing} / {requiredTargets} enemies";
        }
        else
        {
            statusText.color = Color.green;
            statusText.text = "All enemies are visible!";
        }
    }

    private IEnumerator StartCountdown()
    {
        if (countdownText != null) countdownText.gameObject.SetActive(true);

        // WoW style 5 second countdown
        for (int i = 5; i > 0; i--)
        {
            if (countdownText != null) countdownText.text = i.ToString();
            yield return new WaitForSeconds(1f);
        }

        // Countdown finished!
        if (countdownText != null)
        {
            countdownText.text = "FIGHT!";
        }
        
        if (audioSource != null && fightSfx != null)
        {
            audioSource.PlayOneShot(fightSfx);
        }
        
        hasGameStarted = true;
        isGameActive = true;

        // Hide texts
        if (statusText != null) statusText.gameObject.SetActive(false);
        yield return new WaitForSeconds(1f);
        if (countdownText != null) countdownText.gameObject.SetActive(false);

        countdownCoroutine = null;
    }

    public void ReportEnemyDeath()
    {
        if (isGameOver) return;

        enemiesKilled++;
        Debug.Log($"Enemy killed! Total: {enemiesKilled} / {requiredTargets}");

        if (enemiesKilled >= requiredTargets)
        {
            GameOver(true);
        }
    }

    public void GameOver(bool playerWon)
    {
        if (isGameOver) return;

        isGameOver = true;
        isGameActive = false; // Freeze the game

        if (statusText != null)
        {
            statusText.gameObject.SetActive(true);
            
            if (playerWon)
            {
                statusText.color = Color.green;
                statusText.text = "You won!";
                if (audioSource != null && winSfx != null) audioSource.PlayOneShot(winSfx);
            }
            else
            {
                statusText.color = Color.red;
                statusText.text = "You have died!";
                if (audioSource != null && loseSfx != null) audioSource.PlayOneShot(loseSfx);
            }
        }
        
        Debug.Log(playerWon ? "Game Over: Player Wins!" : "Game Over: Player Lost!");
    }
}

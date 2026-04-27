using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    public static SelectionManager Instance { get; private set; }
    
    public Enemy currentSelection { get; private set; }

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

    public void Select(Enemy target)
    {
        if (currentSelection != null)
        {
            currentSelection.SetSelected(false);
        }

        currentSelection = target;
        
        if (currentSelection != null)
        {
            currentSelection.SetSelected(true);
            Debug.Log("SelectionManager: Selected " + target.enemyName);
        }
    }
}

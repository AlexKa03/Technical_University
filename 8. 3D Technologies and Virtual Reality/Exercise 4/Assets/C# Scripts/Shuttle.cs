using UnityEngine;

public class Shuttle : MonoBehaviour
{
    private Animator animator;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void OpenDoors()
    {
        animator.ResetTrigger("close");
        animator.SetTrigger("open");
    }
    public void CloseDoors()
    {
        animator.ResetTrigger("open");
        animator.SetTrigger("close");
    }
}

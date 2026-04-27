using UnityEngine;
using UnityEngine.InputSystem;

public class DetectPress : MonoBehaviour
{
    private Shuttle shuttle;
    public InputAction press;
    public InputAction position;
    private Vector2 currentPos;

    // Start is called before the first frame update
    void Awake()
    {
        shuttle = GetComponent<Shuttle>();
        press.Enable();
        press.performed += Press_performed;
        position.Enable();
        position.performed += x => currentPos = position.ReadValue<Vector2>();
    }

    private void Press_performed(InputAction.CallbackContext obj)
    {
        Ray r = Camera.main.ScreenPointToRay(currentPos);
        RaycastHit hitInfo;
        if (Physics.Raycast(r, out hitInfo) && hitInfo.collider.tag == "Shuttle")
        {
            shuttle.OpenDoors();
        }
    }
}

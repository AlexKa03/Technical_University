using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Color newColor;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ColorChanger")
        {
            GetComponent<Renderer>().material.color = newColor;
            Debug.Log(collision.gameObject.name);
        }
    }
}

using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject BulletPrefab;
    public float ShootForce = 1.0f;
    
    public void Shoot()
    {
        GameObject bullet = Instantiate(BulletPrefab, transform);
        Ray r = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2));
        bullet.GetComponent<Rigidbody>().AddForce(r.direction * ShootForce, ForceMode.Impulse);
    }
}

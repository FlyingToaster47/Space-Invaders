using UnityEngine;

public class bulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;

    public void shoot(Transform transform) {
        Instantiate(bulletPrefab, transform.position, transform.rotation);
    }
}

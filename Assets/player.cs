using UnityEngine;

public class player : MonoBehaviour
{
    public bulletSpawner bulletSpawner;

    public float moveSpeed = 3f;
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            shoot();
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Translate(Vector2.right * Time.deltaTime * moveSpeed);
        } else if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Translate(Vector2.left * Time.deltaTime * moveSpeed);
        }
    }


    void shoot() {
        bulletSpawner.shoot(transform);
    }
    
}

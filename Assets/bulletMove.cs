using UnityEngine;

public class bulletMove : MonoBehaviour
{
    public float moveSpeed = 2;

    void Start() {
        transform.Translate(Vector2.up);
    }

    void Update()
    {
        if (transform.position.y > 30) {
            Destroy(gameObject);
        }
        transform.Translate(Vector2.up * Time.deltaTime * moveSpeed);
    }

    void OnTriggerEnter2D(Collider2D collider) {
        if (collider.gameObject.layer == 8) {
            Destroy(gameObject);
        }
    }
}

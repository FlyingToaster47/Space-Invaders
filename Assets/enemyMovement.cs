using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    public float moveSpeed = 1;
    public Vector2 direction = Vector2.right;
    private Vector2 screenBounds;
    private Vector2 screenOrigo;
    void Start() {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height)); 
        screenOrigo = Camera.main.ScreenToWorldPoint(Vector2.zero);
    }

    void Update()
    {
        if (transform.position.x + 1 > screenBounds.x || transform.position.x - 1 < screenOrigo.x) {
            direction *= -1;
            transform.Translate(Vector2.down * 0.1f);
        }
        transform.Translate(direction *  Time.deltaTime * moveSpeed);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolicemanController : MonoBehaviour
{
    public float speed;
    public bool MoveRight;
    public float groundCheckRadius;
    public Transform groundCheckPoint;
    public LayerMask groundLayer;
    private bool isTouchingGround;
    private Rigidbody2D rigidBody;

    void Start() {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.freezeRotation = true;
    }

    void Update()
    {
        if (MoveRight) {
            transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(5, 4);
        } else {
            transform.Translate(2 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(-5, 4);
        }
    }

    void OnTriggerEnter2D(Collider2D trig) {
        if (trig.gameObject.CompareTag("turn")) {
            if (MoveRight) {
                MoveRight = false;
            } else {
                MoveRight = true;
            }
        }
    }
}

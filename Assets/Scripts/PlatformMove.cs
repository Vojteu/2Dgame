using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    public float speed = 1.5f;
    public bool MoveRight;
    private Rigidbody2D rigidBody;

    void Start() {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.freezeRotation = true;
    }

    void Update() {
        if (CompareTag("PlatformHorizontal") || CompareTag("FallDetector")) {
        
            if (MoveRight) {
                transform.localScale = new Vector2(5, 3);
                transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
            } else {
                transform.localScale = new Vector2(-5, 3);
                transform.Translate(2 * Time.deltaTime * speed, 0,0);
            }
         } else {
            if (MoveRight) {
                transform.Translate(0, -1 * Time.deltaTime * speed, 0);
            } else {
                transform.Translate(0, 1 * Time.deltaTime * speed, 0);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D trig) {
        if (trig.gameObject.CompareTag("turn")) {
            if (MoveRight) {
                MoveRight = false;
            } else{
                MoveRight = true;
            }
        }
       }
}

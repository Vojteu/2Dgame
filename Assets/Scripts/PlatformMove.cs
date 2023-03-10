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
            transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
            } else {
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

    //private void OnCollisionEnter2D(Collision2D collision) {
    //    if (collision.gameObject.name == "player1") {
    //        collision.gameObject.transform.SetParent(transform);
    //    }
    //}
    //private void OnCollisionExit2D(Collision2D collision) {
    //    if (collision.gameObject.name == "player1") {
    //        collision.gameObject.transform.SetParent(null);
    //    }
    //}
}

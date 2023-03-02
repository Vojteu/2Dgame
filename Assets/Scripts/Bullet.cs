using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour{

    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage = 40;
    public PlayerController gamePlayer;

    void Start(){
        gamePlayer = FindObjectOfType<PlayerController>();

        if(gamePlayer.transform.localScale.x > 0f) {
            rb.velocity = new Vector2(speed, rb.velocity.y);
            transform.localScale = new Vector2(3f, 3f);
        } else if(gamePlayer.transform.localScale.x < 0f) {
            rb.velocity = new Vector2((-1)*speed, rb.velocity.y);
            transform.localScale = new Vector2(-3f, 3f);
        } else {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
    }

    void OnTriggerEnter2D(Collider2D hitInfo) {
        //Debug.Log(hitInfo.name);
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if(enemy != null) {
            enemy.TakeDamage(damage);
        }
        if(hitInfo.name == "Police_minion") {
            Destroy(gameObject);
        }
    }
}

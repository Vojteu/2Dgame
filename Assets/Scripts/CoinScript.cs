using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    private LevelManager gameLevelManager;
    public int coinValue;

    void Start()
    {
        gameLevelManager = FindObjectOfType<LevelManager>();
    }

    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other) {
       if(other.tag == "Player2") {
            gameLevelManager.AddCoins(coinValue);
            Destroy(gameObject);
        }
    }
}

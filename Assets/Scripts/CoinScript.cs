using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScript : MonoBehaviour
{
    private LevelManager gameLevelManager;
    public int coinValue;
    public Text MyScoreText;
    private int ScoreNum;

    void Start()
    {
        gameLevelManager = FindObjectOfType<LevelManager>();
        ScoreNum = 0;
        MyScoreText.text = "Score: " + ScoreNum;
    }

    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other) {
       if(other.tag == "Player2") {
            gameLevelManager.AddCoins(coinValue);
            MyScoreText.text = "Score: " + gameLevelManager.getCoinValue();
            Destroy(gameObject);
        }
    }
}

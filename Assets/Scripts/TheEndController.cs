using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheEndController : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player2") {
            Application.Quit();
         }
        }
}

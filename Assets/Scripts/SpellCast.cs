using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellCast : MonoBehaviour {
    public Transform firePoint;
    public GameObject bulletPrefab;
    private PlayerController playerMovement;
    

    void Start() {
        playerMovement = GetComponent<PlayerController>();
    }

    void Update() {
        if (Input.GetButtonDown("Fire1") && playerMovement.canAttack()) {
            Shoot();
        }
    }

    void Shoot() {
        playerMovement.audioSource.PlayOneShot(playerMovement.shootingAudioClip);
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}

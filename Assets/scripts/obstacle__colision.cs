using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle__colision : MonoBehaviour
{
    //public AudioSource colisionSound;

    void OnTriggerEnter(Collider other) {
        this.gameObject.SetActive(false);
        player__status.lives -= 1;
        Debug.Log("Player live: " + player__status.lives);
    }
}

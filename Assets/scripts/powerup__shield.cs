using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup__shield : MonoBehaviour
{
    public static float powerup_speed__shield = 10;
    void OnTriggerEnter(Collider other){
        this.gameObject.GetComponent<Renderer>().enabled = false;
        Debug.Log("player.vulnerable = false");
        player__status.vulnerable = false;
        StartCoroutine(up_speed(powerup_speed__shield));
    }

    private IEnumerator up_speed(float waitTime){
        yield return new WaitForSeconds(waitTime);
        player__status.vulnerable = true;    
        this.gameObject.SetActive(false);
        Debug.Log("player.vulnerable = true");
    }
}

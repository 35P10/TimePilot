using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup_velocidad : MonoBehaviour
{
    public static float powerup_speed__time = 12f, powerup_speed__value=3f;
    private static float time_initial = player__movement.speed, time_final = time_final+powerup_speed__value;

    void OnTriggerEnter(Collider other){
        this.gameObject.GetComponent<Renderer>().enabled = false;
        Debug.Log("Speed ++");
        player__movement.speed = time_final;
        StartCoroutine(up_speed(powerup_speed__time));
    }

    private IEnumerator up_speed(float waitTime){
        yield return new WaitForSeconds(waitTime);
        player__movement.speed = time_initial;    
        this.gameObject.SetActive(false);
        Debug.Log("Speed --");
    }
}

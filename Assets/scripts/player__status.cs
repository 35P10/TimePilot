using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player__status : MonoBehaviour
{
    public static int lives = 3;
    public static float fuel  = 100;

    public static float getDistance(){
        float dist = Vector3.Distance(player__movement.pos_start,player__movement.pos_curr);
        return dist;
    }
}

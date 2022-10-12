using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;
using System;

public class ui__player_speed : MonoBehaviour
{
    void Update(){
        TextMeshPro textmeshPro = gameObject.GetComponent<TextMeshPro>();
        textmeshPro.text  = (player__movement.speed * 50).ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;
using System;

public class vida_controller : MonoBehaviour
{
    // Update is called once per frame
    void Update(){
        TextMeshPro textmeshPro = gameObject.GetComponent<TextMeshPro>();
        textmeshPro.text  = player__status.lives.ToString();
    }
}

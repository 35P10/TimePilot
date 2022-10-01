using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map__generator : MonoBehaviour{
    public GameObject[] section;
    public int zPos = 60;
    int selectSection;

    // Update is called once per frame
    void Update(){
        if(player__movement.pos_curr.z > zPos-60){
            StartCoroutine(GenerateSection());
        }
    }

    IEnumerator GenerateSection(){
        selectSection=Random.Range(0,2);
        Instantiate(section[selectSection], new Vector3(0,0,zPos),Quaternion.identity);
        zPos += 30;
        yield return new WaitForSeconds(10);
    }
}

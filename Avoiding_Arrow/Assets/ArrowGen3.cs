using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGen3 : MonoBehaviour
{
    public GameObject ArrowPrefab3;
    float span = 1.0f;
    float delta = 0;

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(ArrowPrefab3) as GameObject;
            int ran = Random.Range(-5,5);
            go.transform.position = new Vector3(-14,ran,0);
        }
    }
}

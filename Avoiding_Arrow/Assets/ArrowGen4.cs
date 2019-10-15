using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGen4 : MonoBehaviour
{
    public GameObject ArrowPrefab4;
    float span = 1.0f;
    float delta = 0;

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(ArrowPrefab4) as GameObject;
            int ran = Random.Range(-14,14);
            go.transform.position = new Vector3(ran,5,0);
        }
    }
}

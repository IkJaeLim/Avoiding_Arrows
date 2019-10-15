using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow)&&transform.position.x>-14)
        {
            transform.Translate(-1,0,0);
        }
        if(Input.GetKeyDown(KeyCode.UpArrow)&&transform.position.y<4)
        {
            transform.Translate(0,1,0);
        }
        if(Input.GetKeyDown(KeyCode.DownArrow)&&transform.position.y>-4)
        {
            transform.Translate(0,-1,0);
        }

        if(Input.GetKeyDown(KeyCode.RightArrow)&&transform.position.x<14)
        {
            transform.Translate(1,0,0);
        }
    }
}

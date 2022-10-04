using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handGenerator : MonoBehaviour
{
    public GameObject handPrefab;
    float span = 4.0f;
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {
        GameObject go = Instantiate(handPrefab) as GameObject;
        go.transform.position = new Vector3(-11, -0.3f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (HandScript.grabbed == false)
        {
            
            this.delta += Time.deltaTime;
            if (this.delta > this.span)
            {
                this.delta = 0;
                GameObject go = Instantiate(handPrefab) as GameObject;
                go.transform.position = new Vector3(-11, -0.3f, 0);
            }
        }
        
    }
}

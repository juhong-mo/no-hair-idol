using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hpGaugeScript : MonoBehaviour
{
    public float holdtime = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.holdtime -= Time.deltaTime;
        if (holdtime <= 0)
        {
            gameObject.SetActive(false);
            HandScript.grabbed = false;
            holdtime = 5.0f;
        }
    }
}

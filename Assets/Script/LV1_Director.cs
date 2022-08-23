using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LV1_Director : MonoBehaviour
{
    GameObject hpGauge;

    GameObject timer;
    float span = 60.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
        this.timer = GameObject.Find("Timer");
    }

    // Update is called once per frame
    void Update()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.01f;
        if (Input.GetKeyDown(KeyCode.Space)){
            this.hpGauge.GetComponent<Image>().fillAmount += 0.3f;
        }

        this.span -= Time.deltaTime;
        this.timer.GetComponent<Text>().text = "time : " + this.span.ToString("0");
        if(this.span<=0)
        {
            SceneManager.LoadScene("LobbyScene");
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LV1_Director : MonoBehaviour
{
    GameObject hpGauge;

    GameObject timer;
    float span = 60.0f; //60초 제한

    // Start is called before the first frame update
    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
        this.timer = GameObject.Find("Timer");
    }

    // Update is called once per frame
    void Update()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= Time.deltaTime; //게이지 까임
        if (Input.GetKeyDown(KeyCode.Space)){   //스페이스바를 누를 때마다
            this.hpGauge.GetComponent<Image>().fillAmount += 0.15f;  //게이지가 참
        }
        if(this.hpGauge.GetComponent<Image>().fillAmount == 0) //못버텨서 게이지가 다 까이면
        {
            SceneManager.LoadScene("LobbyScene");   //로비로 돌아감
        }

        this.span -= Time.deltaTime;    //타이머 1초씩 줄어듦
        this.timer.GetComponent<Text>().text = "time : " + this.span.ToString("0"); //UI로 글자 표시
        if(this.span<=0)    //타이머가 끝나면
        {
            SceneManager.LoadScene("LobbyScene");   //로비로 돌아감
        }
        
    }
}

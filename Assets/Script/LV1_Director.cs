using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LV1_Director : MonoBehaviour
{
    public GameObject hpGauge;

    GameObject timer;
    GameObject hair;
    float span = 30.0f; //30초 제한
    

    // Start is called before the first frame update
    void Start()
    {
        this.timer = GameObject.Find("Timer");
        this.hair = GameObject.Find("LV_1Hair");
    }

    // Update is called once per frame
    void Update()
    {       
        this.span -= Time.deltaTime;    //타이머 1초씩 줄어듦
        this.timer.GetComponent<Text>().text = "time : " + this.span.ToString("0"); //UI로 글자 표시
        if(this.span<=0)    //타이머가 끝나면
        {
            SceneManager.LoadScene("LobbyScene");   //로비로 돌아감
        }
        
        if(HandScript.grabbed == true)  //충돌했을 때
        {
            //hp게이지
            hpGauge.SetActive(true);
            hpGauge.GetComponent<Image>().fillAmount -= Time.deltaTime; //게이지 까임
            if (Input.GetKeyDown(KeyCode.Space))
            {   //스페이스바를 누를 때마다
                hpGauge.GetComponent<Image>().fillAmount += 0.15f;  //게이지가 참
            }
            if (hpGauge.GetComponent<Image>().fillAmount == 0) //못버텨서 게이지가 다 까이면
            {
                SceneManager.LoadScene("LobbyScene");   //로비로 돌아감
            }
            
        }
        if(HandScript.grabbed == false)
        {
            hpGauge.GetComponent<Image>().fillAmount = 1.0f;
            hair.SetActive(true);
        }

    }
}

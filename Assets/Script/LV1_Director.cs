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
    float span = 30.0f; //30�� ����
    

    // Start is called before the first frame update
    void Start()
    {
        this.timer = GameObject.Find("Timer");
        this.hair = GameObject.Find("LV_1Hair");
    }

    // Update is called once per frame
    void Update()
    {       
        this.span -= Time.deltaTime;    //Ÿ�̸� 1�ʾ� �پ��
        this.timer.GetComponent<Text>().text = "time : " + this.span.ToString("0"); //UI�� ���� ǥ��
        if(this.span<=0)    //Ÿ�̸Ӱ� ������
        {
            SceneManager.LoadScene("LobbyScene");   //�κ�� ���ư�
        }
        
        if(HandScript.grabbed == true)  //�浹���� ��
        {
            //hp������
            hpGauge.SetActive(true);
            hpGauge.GetComponent<Image>().fillAmount -= Time.deltaTime; //������ ����
            if (Input.GetKeyDown(KeyCode.Space))
            {   //�����̽��ٸ� ���� ������
                hpGauge.GetComponent<Image>().fillAmount += 0.15f;  //�������� ��
            }
            if (hpGauge.GetComponent<Image>().fillAmount == 0) //�����߼� �������� �� ���̸�
            {
                SceneManager.LoadScene("LobbyScene");   //�κ�� ���ư�
            }
            
        }
        if(HandScript.grabbed == false)
        {
            hpGauge.GetComponent<Image>().fillAmount = 1.0f;
            hair.SetActive(true);
        }

    }
}

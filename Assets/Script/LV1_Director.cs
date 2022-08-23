using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LV1_Director : MonoBehaviour
{
    GameObject hpGauge;

    GameObject timer;
    float span = 60.0f; //60�� ����

    // Start is called before the first frame update
    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
        this.timer = GameObject.Find("Timer");
    }

    // Update is called once per frame
    void Update()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= Time.deltaTime; //������ ����
        if (Input.GetKeyDown(KeyCode.Space)){   //�����̽��ٸ� ���� ������
            this.hpGauge.GetComponent<Image>().fillAmount += 0.15f;  //�������� ��
        }
        if(this.hpGauge.GetComponent<Image>().fillAmount == 0) //�����߼� �������� �� ���̸�
        {
            SceneManager.LoadScene("LobbyScene");   //�κ�� ���ư�
        }

        this.span -= Time.deltaTime;    //Ÿ�̸� 1�ʾ� �پ��
        this.timer.GetComponent<Text>().text = "time : " + this.span.ToString("0"); //UI�� ���� ǥ��
        if(this.span<=0)    //Ÿ�̸Ӱ� ������
        {
            SceneManager.LoadScene("LobbyScene");   //�κ�� ���ư�
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HandScript : MonoBehaviour
{
    public GameObject grabbedPrefab;
    GameObject hair;
    public static bool grabbed;

    // Start is called before the first frame update
    void Start()
    {
        grabbed = false;
        this.hair = GameObject.Find("LV_1Hair");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.1f, 0, 0);        
    }


    private void OnTriggerEnter2D(Collider2D collision) //�浹���� ��
    {
        grabbed = true;
        Destroy(gameObject);
        hair.SetActive(false);
        GameObject changeImg = Instantiate(grabbedPrefab) as GameObject;    //�տ� ���� �Ӹ�ī�� ������Ʈ�� ���
        changeImg.transform.position = new Vector3(-1.35f, -0.33f, 0);  
        
    }
}

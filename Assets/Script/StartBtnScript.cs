using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartBtnScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickToStart()
    {
        SceneManager.LoadScene("LobbyScene"); //스타트 버튼을 누르면 로비 화면으로 넘어감
    }
}

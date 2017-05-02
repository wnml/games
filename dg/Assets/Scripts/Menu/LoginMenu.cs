using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoginMenu : MonoBehaviour {

    public HomeController homeController;
    public Button loginBtn;
	// Use this for initialization
	void Start () {
        loginBtn.onClick.AddListener(LoginGame);

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void LoginGame()
    {
        Debug.logger.Log("登录服务器！");
        homeController.CloseWindow(WINDOW_ID.WINDOW_ID_LOGIN);
        homeController.OpenWindow(WINDOW_ID.WINDOW_ID_HOME);
    }
}

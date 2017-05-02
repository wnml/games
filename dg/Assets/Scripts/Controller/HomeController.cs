using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HomeController : MonoBehaviour {

    private Dictionary<WINDOW_ID, GameObject> windows = new Dictionary<WINDOW_ID, GameObject>();

    // Use this for initialization
    void Start () {
        windows.Add(WINDOW_ID.WINDOW_ID_CANVAS, GameObject.Find("Canvas"));
        windows.Add(WINDOW_ID.WINDOW_ID_LOGIN, GameObject.Find("Login"));
        windows.Add(WINDOW_ID.WINDOW_ID_HOME, GameObject.Find("Home"));
        windows[WINDOW_ID.WINDOW_ID_HOME].SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OpenWindow(WINDOW_ID id)
    {
        windows[id].SetActive(true);
        
    }
    public void CloseWindow(WINDOW_ID id)
    {
        windows[id].SetActive(false);

    }

}

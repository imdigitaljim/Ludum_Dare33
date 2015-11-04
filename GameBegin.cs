using UnityEngine;
using System.Collections;

public class GameBegin : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Application.LoadLevel("TestEnvironment");
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("quitting");
            Application.Quit();
        }

    }
}

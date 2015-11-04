using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CitizenTracker : MonoBehaviour {

    public static int remaining;
    private int lastUpdate;
    // Use this for initialization
    void Start()
    {
        remaining =  GameObject.FindGameObjectsWithTag("Citizen").Length;
        lastUpdate = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (lastUpdate != remaining)
        {
            GetComponent<Text>().text = remaining.ToString();
            lastUpdate = remaining;
        }
        if (remaining <= 0)
        {
            Application.LoadLevel("Win");
        }

    }
}

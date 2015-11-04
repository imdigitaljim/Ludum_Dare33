using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeTracker : MonoBehaviour {

    public float timeMax;
    private float currentTime;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        var displayTime = (int)timeMax - (int)currentTime;
        GetComponent<Text>().text = displayTime.ToString();

    }
}

using UnityEngine;
using System.Collections;

public class SpinItem : MonoBehaviour {

    public int spinSpeed = 6;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up * Time.deltaTime * spinSpeed, Space.World );
    }
}

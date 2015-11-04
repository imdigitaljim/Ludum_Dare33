using UnityEngine;
using System.Collections;

public class WeaponMovement : MonoBehaviour {

    public GameObject player;
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject == player)
        {
            Physics.IgnoreCollision(GetComponent<Collider>(), player.GetComponent<Collider>());
            Debug.Log("ignorings");
        }

    }

}

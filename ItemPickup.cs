using UnityEngine;
using System.Collections;

public class ItemPickup : MonoBehaviour {

    public string ItemName;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            InventoryManagement.hasWeapon = true;
            GetComponent<AudioSource>().Play();
            Destroy(gameObject, 1);
        }

    }
}

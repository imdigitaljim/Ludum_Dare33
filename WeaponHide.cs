using UnityEngine;
using System.Collections;

public class WeaponHide : MonoBehaviour {

    private bool itemFound = false;
	// Use this for initialization
	void Start () {
        GetComponent<Renderer>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (!itemFound && InventoryManagement.hasWeapon == true)
        {
            GetComponent<Renderer>().enabled = true;
            itemFound = true;
        }

    }
}

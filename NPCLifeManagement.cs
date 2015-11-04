using UnityEngine;
using System.Collections;

public class NPCLifeManagement : MonoBehaviour {

    public int health = 3;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "PlayerAttack")
        {
            GetComponent<AudioSource>().Play();
            foreach (var i in GetComponentsInChildren<Renderer>())
            {
                i.enabled = false;
            }
            foreach (var i in GetComponentsInChildren<Collider>())
            {
                i.enabled = false;
            }
            CitizenTracker.remaining--;
            health -= 1;
            if (health <= 0)
            {

                Destroy(gameObject, 1);
            }

        }

    }

}

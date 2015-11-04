using UnityEngine;
using System.Collections;

public class NPCMovement : MonoBehaviour {

    private GameObject player;
    private int runDistance = 10;
    private float runSpeed = 10f;
    private float moveTime = 0f;
    private float driftTime = 2f;
    private Vector3 driftLocation;
	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
        if (Vector3.Distance(player.transform.position, transform.position) < runDistance)
        {
            Vector3 direction = (transform.position - player.transform.position);
            direction.y = 0;
            direction.Normalize();
            GetComponent<Rigidbody>().AddForce(direction * runSpeed);
        }
        else
        {
            if (moveTime < driftTime)
            {
                moveTime += Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, driftLocation, .05f);
            }
            else {
                driftLocation = transform.position + new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
                moveTime = 0;
            }
        }
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }

	}

    void OnCollisonEnter(Collision col)
    {

        if (col.gameObject.tag != "Ground")
        {
            driftLocation = transform.position + new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
        }



    }



}

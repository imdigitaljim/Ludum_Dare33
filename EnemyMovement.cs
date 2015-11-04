using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{

    private GameObject player;
    private int trackDistance = 30;
    private float runSpeed = 1f;
    private float moveTime = 0f;
    private float driftTime = 5f;
    public bool lockedOn = false;
    public GameObject moveLocation;
    //values for internal use
    private Vector3 driftLocation;
    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("Player");
        driftLocation = transform.position + new Vector3(Random.Range(-30, 30), 0, Random.Range(-10, 10));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Vector3.Distance(player.transform.position, transform.position) < trackDistance)
        {
            lockedOn = true;
            transform.LookAt(player.transform);
            if (Vector3.Distance(player.transform.position, transform.position) > 10)
            {
                transform.position = Vector3.MoveTowards(transform.position, player.transform.position, .01f);
            }

        }
        else
        {
            lockedOn = false;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(driftLocation - transform.position), .1f);
            if (moveTime < driftTime)
            {
                moveTime += Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, driftLocation, .03f);
            }
            else
            {
                driftLocation = transform.position + new Vector3(Random.Range(-30, 30), 0, Random.Range(-10, 10));
                driftLocation.y = 0;
                moveTime = 0;
            }
        }
        if (transform.rotation.x != 0 || transform.rotation.z != 0)
        {
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
        }
    }

    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag != "Ground" && !lockedOn)
        {
            driftLocation = transform.position + new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
        }



    }



}

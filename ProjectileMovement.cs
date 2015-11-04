using UnityEngine;
using System.Collections;

public class ProjectileMovement : MonoBehaviour
{

    private Vector3 start;
    public float movementSpeed = 10f;
    public float hangTime = 1f;
    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, hangTime);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * movementSpeed);
    }
    void OnTriggerEnter(Collider col)
    {
        Destroy(gameObject);
    }

}

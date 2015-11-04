using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {

    private EnemyMovement status;
    private int counter;
    private int fireRateDelay = 90;
    public GameObject projectile;
	// Use this for initialization
	void Start () {
        status = gameObject.GetComponentInParent<EnemyMovement>();
        counter = fireRateDelay;
	}

    // Update is called once per frame
    void Update()
    {
        if (status.lockedOn)
        {
            counter += 1;
            if (counter > fireRateDelay && GetComponent<Renderer>().enabled)
            {
                Instantiate(projectile, transform.position + new Vector3(0,.7f,0) + transform.forward * 3, transform.rotation);
                counter = 0;
            }

        }
        else
        {
            counter = 0;
        }

    }
}

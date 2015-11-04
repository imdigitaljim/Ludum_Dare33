using UnityEngine;
using System.Collections;

public class PlayerAction : MonoBehaviour
{
    public GameObject projectile;
    private float lastFired = 0;
    public float fireRateDelay = .1f;
    // Use this for initialization
    void Start()
    {
        lastFired = fireRateDelay;
    }

    // Update is called once per frame
    void Update()
    {
        if (InventoryManagement.hasWeapon)
        {
            lastFired += Time.deltaTime;
            if (Input.GetMouseButtonDown(0))
            {
                if (lastFired > fireRateDelay)
                {
                    Instantiate(projectile, transform.position + transform.forward + new Vector3(0,1,0), Camera.main.transform.rotation);
                    lastFired = 0;
                }
            }
            else if (Input.GetMouseButton(0))
            {
                if (lastFired > fireRateDelay)
                {
                    Instantiate(projectile, transform.position + transform.forward + new Vector3(0, 1, 0), Camera.main.transform.rotation);
                    lastFired = 0;
                }

            }
        }

    }
}

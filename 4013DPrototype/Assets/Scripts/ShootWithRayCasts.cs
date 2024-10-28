using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootWithRayCasts : MonoBehaviour
{
    public float damage = 10f;
    public float range = 10f;
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) { Shoot(); };
    }

    void Shoot() {
        RaycastHit hitInfo;
        if ( Physics.Raycast(cam.transform.position, cam.transform.forward, out hitInfo, range)) 
        { 
            Debug.Log(hitInfo.transform.gameObject.name);

            Target target = hitInfo.transform.gameObject.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }
}

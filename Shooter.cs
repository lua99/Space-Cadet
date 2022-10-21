using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject projectilePrefub;
    
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var projectile = 
                Instantiate(projectilePrefub, new Vector3(2,0)+transform.position, projectilePrefub.transform.rotation);
        }
    }
}

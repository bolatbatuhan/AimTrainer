using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    private float damage = 10.0f;
    private float range = 100.0f;

    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        muzzleFlash.Play();

        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position,fpsCam.transform.forward,out hit, range))
        {
            

           Target target =  hit.transform.GetComponent<Target>();
           if(target != null)
           {
            target.TakeDamage(damage);
           }
        }
    }
}

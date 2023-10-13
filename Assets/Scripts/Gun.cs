using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    private float damage = 10.0f;
    private float range = 1000.0f;

    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    private Animator anim;

    private void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            

        }
        anim.SetBool("fire_idle",false);
    }

    void Shoot()
    {
        muzzleFlash.Play();

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {

            anim.SetTrigger("fire");
            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }
}

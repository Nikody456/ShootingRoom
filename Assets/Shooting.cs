using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public AudioSource source1;
    public Transform FirePoint;
    public Rigidbody Bullet;

    public float bulletForce = 1f;
    private void Start()
    {
        source1 = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        if (!PauseMenu.GameIsPaused)
        {
            Rigidbody bull = Instantiate(Bullet, FirePoint.position, FirePoint.rotation);
            bull.AddForce(FirePoint.up * bulletForce);
            source1.Play();
        }
    }
}

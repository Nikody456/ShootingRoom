using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Collis : MonoBehaviour
{
    public static Collis instance;

    public GameObject hitEffect;

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Ball"))
        {
            Destroy(collision.gameObject, 0.5f);
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 5f);
            ScoreManager.instance.AddPoint();
        }
    }

    public void PlaySound()
    {
        GetComponent<AudioSource>().Play();
    }
}

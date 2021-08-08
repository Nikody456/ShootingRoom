using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnball : MonoBehaviour
{
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ballWave());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Spawn()
    {
        GameObject a = Instantiate(ball) as GameObject;
        a.transform.position = new Vector3(Random.Range(-10, 12), Random.Range(10, 22));
    }

    IEnumerator ballWave()
    {
        while(true)
        {
            yield return new WaitForSeconds(3.0f);
            Spawn();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    private int count = 0;
    public TextMeshProUGUI scoreText1;
    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText1.text = "Current Score: " + count.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPoint()
    {
        count += 1;
        scoreText1.text = "Current Score: " + count.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetScore : MonoBehaviour
{
    private int score;
    private int stars;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore()
    {
        //Calculate scores and stars
        score++;
        if (score % 3 == 0)
        {
            stars++;
        }

        //Display scores and stars
        Debug.Log("Score:" + score + " Stars: " + stars);
    }
}

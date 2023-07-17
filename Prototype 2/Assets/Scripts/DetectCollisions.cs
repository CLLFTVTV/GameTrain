using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private GetScore Score;
    // Start is called before the first frame update
    void Start()
    {
        Score = GameObject.Find("Spawn Manager").GetComponent<GetScore>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0.5f;
    }

}

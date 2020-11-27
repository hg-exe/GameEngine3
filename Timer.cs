using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timeLimit = 10.0f;
    private float timeRemaining;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        timeRemaining = timeLimit;
    }

    // Update is called once per frame
    void Update()
    {
        timeRemaining -= Time.deltaTime;
        if(timeRemaining <= 0.0f)
        {
            Player.GetComponent<Player>().Respawn();
            timeRemaining = timeLimit;
        }
    }
}

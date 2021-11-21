using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    float timeSinceStarted = 0.0f;
    [SerializeField] int timeLimit = 10;
    bool isCounting = true;

    public Player player;

    // Update is called once per frame
    void Update()
    {

        if (isCounting)
        {
        timeSinceStarted += Time.deltaTime;
        //Debug.Log(timeSinceStarted);
        }


        if(timeSinceStarted >= timeLimit)
        {
            isCounting = false;
            Debug.Log("Game Over");
            timeSinceStarted = 0;
            player.Respawn();
        }
    }
}

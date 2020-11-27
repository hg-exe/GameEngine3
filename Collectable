using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() 
    {
        Debug.Log("Hello world, Start");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hello world, Update");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Player>())
        {
            Debug.Log("I have hit the player");
            Debug.Log("Trigger");
            other.gameObject.GetComponent<Player>().IncreaseScore();
            Destroy(gameObject);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    bool hasKey = false;
    Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
        Debug.Log(startPosition);
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Key")
        {
            Debug.Log("I have hit the key");
            hasKey = true;
            Destroy(hit.gameObject);
        }

        if(hit.gameObject.tag == "Door" && hasKey)
        {
            Destroy(hit.gameObject);
        }
    }


    public void Respawn()
    {
        GetComponent<CharacterController>().enabled = false;
        transform.SetPositionAndRotation(startPosition, Quaternion.identity);
        GetComponent<CharacterController>().enabled = true;
    }

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("Trigger");
    }
}

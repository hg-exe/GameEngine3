using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    int score = 0;
    bool hasKey = false;
    public float health = 100.0f;
    Vector3 respawnPos;

    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        respawnPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("I have pressed the mouse");      
            GameObject myBullet = GameObject.Instantiate(bullet);
            myBullet.transform.SetPositionAndRotation(transform.position, GetComponentInChildren<Camera>().transform.rotation);
        }
    }

    public void IncreaseScore()
    {
        score++;
        Debug.Log(score);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.gameObject.tag == "Key")
        {
            Debug.Log("I have collected the key");
            Destroy(hit.gameObject);
            hasKey = true;
        }

        if(hit.gameObject.tag == "Door" && hasKey)
        {
            Debug.Log("I have hit the door");
            Destroy(hit.gameObject);
        }
    }

    public void TakeDamage(float damage)
    {
        // this is the damage function
        health -= damage;
        Debug.Log(health);
        if(health <= 0.0f)
        {
            Respawn();
        }
    }

    public void Respawn()
    {
        transform.SetPositionAndRotation(respawnPos, Quaternion.identity);
        health = 100.0f;
    }
}

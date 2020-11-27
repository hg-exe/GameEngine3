using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float damage = 20.0f;
    float timeSinceLastHit = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastHit += Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Enemy has hit something");
        if (collision.gameObject.GetComponent<Player>())
        {
            if (timeSinceLastHit >= 3.0f)
            {
                collision.gameObject.GetComponent<Player>().TakeDamage(damage);
                timeSinceLastHit = 0.0f;
            }
            else
            {
                Debug.Log("Too soon to damage player");
            }
        }
    }

    /*
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enemy has hit something");
        if (other.gameObject.GetComponent<Player>())
        {
            other.gameObject.GetComponent<Player>().health -= damage;
            Debug.Log(other.gameObject.GetComponent<Player>().health);
        }
    }
    */
}

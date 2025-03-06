using System;
using UnityEngine;

public class shotScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Enemy") {
            
            // destroy the enemy
            Destroy(other.gameObject);
            
            // destroy yourself
            Destroy(gameObject);
        }
    }
}

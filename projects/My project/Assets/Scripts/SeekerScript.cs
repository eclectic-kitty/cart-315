using System;
using UnityEngine;

public class SeekerScript : MonoBehaviour {
    public float xMove, yMove;
    public float speed = 0.1f;
    public bool colliding = false;
    public Rigidbody2D body;

    public AudioSource marco;

    public static SeekerScript S;

    void Awake() {
        S = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
    }

    // Update is called once per frame
    void Update() {

        // Gets Input directions
        xMove = Input.GetAxis("Horizontal");
        yMove = Input.GetAxis("Vertical");

        // Sets player velocity according to the Input above
        body.linearVelocity = new Vector2(xMove, yMove).normalized * speed;


        if (Input.GetKeyDown(KeyCode.Space)) {
            marco.Play();
        }
    }
}
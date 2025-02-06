using UnityEngine;
using System;
using System.Collections.Generic;

public class ghost : MonoBehaviour {

    public List<Sprite> apparitions = new List<Sprite>();
    spriteRenderer = this.GetComponent<SpriteRenderer>();
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
    }

    // Update is called once per frame
    void Update() {
        if (UnityEngine.Random.Range(0, 60) == 0) {
            Debug.Log("Boo!");
            spriteRenderer = apparitions[UnityEngine.Random.Range(0, 3)];
        }
    }
}
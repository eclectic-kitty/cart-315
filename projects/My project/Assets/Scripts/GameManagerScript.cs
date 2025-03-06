using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManagerScript : MonoBehaviour {
    
    public GameObject hider;

    public static GameManagerScript S;

    void Awake() {
        S = this;
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        PlaceHider();
    }

    public void PlaceHider() {
        Debug.Log("Placing Hider");
        float xPos = Mathf.Round(Random.Range(-12f, 12f)) * 0.7f;
        float yPos = Mathf.Round(Random.Range(-6f, 6f)) * 0.7f;
        Instantiate(hider, new Vector3(xPos, yPos, 0), transform.rotation);
    }
}

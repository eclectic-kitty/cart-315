using UnityEngine;

public class hiderScript : MonoBehaviour {

    public AudioSource polo;
    public GameObject seeker;
    private Vector3 seekerPos;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        seekerPos = seekerPos.Transform.Position;
    }

    // Update is called once per frame
    void Update() {
        
    }
}

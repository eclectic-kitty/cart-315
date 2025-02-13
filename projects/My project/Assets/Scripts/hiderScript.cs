using UnityEngine;

public class hiderScript : MonoBehaviour {

    public AudioSource polo;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
    }

    // Update is called once per frame
    void Update() {
        //Debug.Log("Polo x:" + seekerScript.S.xLoc + " y: " + seekerScript.S.yLoc);
        Debug.Log("Polo pos:" + seekerScript.S.transform.position);
    }
}

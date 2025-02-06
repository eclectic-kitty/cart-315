using UnityEngine;

public class seekerScript : MonoBehaviour
{
    public float xLoc, yLoc;
    public float speed = 0.1f;

    public AudioSource marco;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        xLoc = 0;
        yLoc = 0;   
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.A)) {
            xLoc -= speed;
        }
        
        if (Input.GetKey(KeyCode.D)) {
            xLoc += speed;
        }
        
        if (Input.GetKey(KeyCode.W)) {
            yLoc += speed;
        }
        
        if (Input.GetKey(KeyCode.S)) {
            yLoc -= speed;
        }
        
        this.transform.position = new Vector3(xLoc, yLoc, 0);
        
        
        if (Input.GetKeyDown(KeyCode.Space)) {
            marco.Play();
        }
    }
}

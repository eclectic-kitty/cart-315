using UnityEngine;

public class seekerScript : MonoBehaviour
{
    public float xLoc, yLoc;
	public Vector3 pos;
    public float speed = 0.1f;

    public AudioSource marco;

	public static seekerScript S;

	void Awake() {
		S = this;
	}
    
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
		//pos = this.transform.position;
        
        
        if (Input.GetKeyDown(KeyCode.Space)) {
            marco.Play();
        }	
    }
}

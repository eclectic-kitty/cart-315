using UnityEngine;

public class brickLayer : MonoBehaviour {
    public GameObject brick;
    public int rows, columns;
    public int numBricks;
    public float bs_h, bs_v;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        Lay();
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void Lay() {
        for (int c = 0; c < columns; c++) {
            for (int r = 0; r < rows; r++) {
                float xPos = -columns + (c * bs_h);
                float yPos = rows - (r * bs_v);
                Debug.Log(xPos + ", " + yPos);
                
                Instantiate(brick, new Vector3(xPos, yPos, 0), transform.rotation, this.transform);
            }
        }
    }
}

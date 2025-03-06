using UnityEngine;

public class Shooting : MonoBehaviour {
    public GameObject shot;
    public float shotSpeed = 10;
    public KeyCode fireButton;
    public GameObject shotStart;

    public bool player;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        Fire();
    }

    // Update is called once per frame
    void Update()
    {
        if (player && Input.GetKeyDown(fireButton)) {Fire();}
    }

    public void Fire() {
        GameObject go = Instantiate<GameObject>(shot);
        go.transform.position = shotStart.transform.position;
        Rigidbody2D rb = go.GetComponent<Rigidbody2D>();
        rb.linearVelocityY = shotSpeed;
    }
}

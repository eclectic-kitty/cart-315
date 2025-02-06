using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour
{
    public float ballSpeed = 10;
    private int[] directions = {-1, 1};
    private int xDir, yDir;

    public int scoreL, scoreR;

    public AudioSource blip;

    private Rigidbody2D rb;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        StartCoroutine(Launch());
    }

    private void OnCollisionEx
    
    private void OnCollisionEnter2D(Collision2D wall)
    {
        //throw new NotImplementedException();

        if (wall.gameObject.name == "leftWall")
        {
            scoreL++;
            Reset();
        }
        else if (wall.gameObject.name == "rightWall")
        {
            scoreR++;
            Reset();
        }

        if (wall.gameObject.name == "topWall" || wall.gameObject.name == "bottomWall")
        {
            blip.pitch = 0.75f;
            blip.Play();
        }
        if (wall.gameObject.name == "paddleL" || wall.gameObject.name == "paddleR")
        {
            blip.pitch = 1f;
            blip.Play();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Launch()
    {
        // choose Random X dir
        xDir = directions[Random.Range(0, directions.Length)];
        // choose Random Y dir
        yDir = directions[Random.Range(0, directions.Length)];
        // wait for x seconds
        yield return new WaitForSeconds(1);
        
        // apply force
        rb.AddForce(transform.right * ballSpeed * xDir);
        rb.AddForce(transform.up * ballSpeed * yDir);
    }

    void Reset()
    {
        rb.linearVelocity = Vector2.zero;
        // reset to 0,0
        this.transform.localPosition = new Vector3(0, 0, 0);
        // Launch
        StartCoroutine(Launch());
    }
}

using System.Collections;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    public GameObject record;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(routine:Drop());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Drop() {
        // Instance Records
        Debug.Log("Drop");
        float rX = Random.Range(-6f, 6f);
        Vector3 loc = new Vector3(rX, 6, 0);
        Instantiate(record, loc, transform.rotation);
        // Wait
        float next = Random.Range(0.25f, 1.3f);
        yield return new WaitForSeconds(next);
        // Start again
        StartCoroutine(routine:Drop());
    }
}

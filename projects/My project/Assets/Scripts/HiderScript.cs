using UnityEngine;
using System.Collections;

public class HiderScript : MonoBehaviour {

    public AudioSource polo;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
    }

    // Update is called once per frame
    void Update() {
        
        if (Input.GetKeyDown(KeyCode.Space)) {
			StartCoroutine(Speak());
        }
    }
	
	private IEnumerator Speak() {
        Vector3 seekPos = SeekerScript.S.transform.position;
		float dist = Vector3.Distance(seekPos, transform.position);
		float adjVol;
		if (dist > 10f) {
			adjVol = Scale(15f, 10f, 0f, 0.04f, dist);
		} else if (dist > 5f) {
			adjVol = Scale(10f, 5f, 0.04f, 0.15f, dist);
		} else {
			adjVol = Scale(5f, 0f, 0.15f, 0.5f, dist);
		}
		polo.volume = adjVol;
        Debug.Log("Polo! Dist: " + dist + " & volume: " + adjVol);

		yield return new WaitForSeconds(1);
		
        polo.Play();
	}

	// Scaling function from this thread: https://discussions.unity.com/t/mapping-or-scaling-values-to-a-new-range/503453
	private float Scale(float oldMin, float oldMax, float newMin, float newMax, float oldValue) {
    	float oldRange = (oldMax - oldMin);
    	float newRange = (newMax - newMin);
    	float newValue = (((oldValue - oldMin) * newRange) / oldRange) + newMin;

    	return(newValue);
	}
}

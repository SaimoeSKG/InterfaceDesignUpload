using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnEnter : MonoBehaviour {

    private AudioSource source;
    [SerializeField] private AudioClip placesSound;
    // Use this for initialization
    void Start () {
		gameObject.GetComponent<Renderer>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    void OnTriggerEnter(Collider col)
    {
        Debug.Log("You've entered " + gameObject.name + " place.");
        source = col.GetComponent<AudioSource>();
        source.PlayOneShot(placesSound, 1f);
        Destroy(gameObject);
    }
}

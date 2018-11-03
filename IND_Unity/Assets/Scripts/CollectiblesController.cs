using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectiblesController : MonoBehaviour {
	public CollectiblesData[] cd;


	public void IncrementCount(GameObject go){
		if (go.name.Contains ("Heart")) {
			cd [0].collectibleNum++;
		} else if (go.name.Contains ("SoftStar")) {
			cd [1].collectibleNum++;
		} else if (go.name.Contains ("5 Side Diamond")) {
			cd [2].collectibleNum++;
		}
	}

	public void OutputCounts(){
		Debug.Log ("You've collected: " + cd [0] + cd [1] + cd [2]);

	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

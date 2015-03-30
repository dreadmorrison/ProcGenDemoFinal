using UnityEngine;
using System.Collections;

public class pathInstantiate : MonoBehaviour {

	public GameObject GridInstantiate;
	public GameObject floor;
	public int max_tiles;
	int counter = 0;
	float randomnum;
	float rotate_one;
	float rotate_two;
	Collider thingCurrentlyInside;

	// Use this for initialization
	void Start () {

		max_tiles = Random.Range (30,70);
		if (Random.value<.75f){
			rotate_one = 90f;
		} else {
			rotate_one = 0f;
	}
		if (Random.value<.75f){
			rotate_two = -90f;
		} else {
			rotate_two = 0f;
	}
}
	
	// Update is called once per frame
	void Update () {
	if (counter < max_tiles){
			randomnum = Random.Range(0.0f, 1.0f);
			Instantiate (floor, gameObject.transform.position, gameObject.transform.rotation);
							
			if (randomnum < 0.25f){
				transform.Rotate(0f, rotate_one, 0f);
			}
			else if (randomnum < 0.5f) {
				transform.Rotate (0, rotate_two, 0);
			}
			float a = Random.Range(0f, 1f);
			
			if ( a <= 0.1f){
				Instantiate(GridInstantiate, transform.position, Quaternion.identity);
			}
			counter += 1;
			transform.Translate (Vector3.forward *5);
		}

	else{
				Destroy(gameObject);
		}
		if ( thingCurrentlyInside != null ) {

			Destroy(thingCurrentlyInside);
		}
		
		
		
	}
	
	void OnTriggerEnter ( Collider activator ) {
		thingCurrentlyInside = activator; // want to remember the thing that entered the trigger
	}
	
	void OnTriggerExit ( Collider exiter ) {
		// "null" means nothing, empty, absence of anything
		thingCurrentlyInside = null;
	}
}


using UnityEngine;
using System.Collections;

public class cubeGod : MonoBehaviour {

	int cubeCountMax = 1000;
	public Transform blueprint;
	float cubeSpawnRadius = 10f;//assign this in inspectorr

	// Use this for initialization
	void Start () {

		cubeCountMax = Random.Range (100, 1000);
		cubeSpawnRadius = Random.Range (5f, 100f);

		int cubeCount = 0;
		while (cubeCount < cubeCountMax) {
		
			cubeCount += 1;
		}
	}

	void MakeRandomCube(){

		Instantiate ( 	blueprint, 
		             Random.onUnitSphere * cubeSpawnRadius, 
		             Random.rotation
		             ); 
	}

	// Update is called once per frame
	void Update () {
	//simple restart button
		if (Input.GetKeyDown (KeyCode.R)){
			Application.LoadLevel(Application.loadedLevel);
		}
		if (Input.GetKey (KeyCode.Space)){
			MakeRandomCube();
		}
	}

}

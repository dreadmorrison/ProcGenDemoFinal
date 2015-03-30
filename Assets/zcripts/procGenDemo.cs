using UnityEngine;
using System.Collections;

public class procGenDemo : MonoBehaviour {

	public GameObject prefab;


	// Use this for initialization
	void Start () {
		Instantiate( prefab, 
		            new Vector3 ( Random.Range (-100f, 100f), 0f, Random.Range (-50f, 50f)),
		            Quaternion.Euler(0f, Random.Range (0, 360), 0f)
		            );
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using System.Collections;

public class GridInstantiate : MonoBehaviour {

	public GameObject pathInstantiate;
	public int max_tiles;
	int counter = 0;
	float random_num ;

	public GameObject wall;
	public GameObject floor;

	void Start(){
		max_tiles = Random.Range (30,70);
	if (counter < max_tiles){
		for (int x = 0; x < 5; x++){
				for (int z = 0; z < 5; z++){
				Vector3 position = new Vector3(x * 5, 0, z * 5) + transform.position;
				random_num = Random.value;
				if (random_num < 0.7f){
					Instantiate(floor, position, gameObject.transform.rotation);
				} else if (random_num < 0.95f){
					Instantiate (wall, position, gameObject.transform.rotation);
				}
			}
				float a = Random.Range(0f,1f);
				
				if (a <= 0.01f){
					
					Instantiate(pathInstantiate, transform.position, Quaternion.identity);
					
				}
			counter++;
		}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

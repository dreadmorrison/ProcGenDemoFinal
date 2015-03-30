using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {
		
		void Update () {
			// did the player press [R] on the keyboard?
			if (Input.GetKeyDown (KeyCode.R)) {
				// if so, reload the current scene
				Application.LoadLevel ( Application.loadedLevel );
			}
		}
		
	}

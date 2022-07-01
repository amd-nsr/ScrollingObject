using UnityEngine;
 
public class Scroller : MonoBehaviour {
   private float xoff ,yoff;
	void Update() {
		xoff = Time.time * 1f;
		yoff = Time.time * 0f;
		GetComponent<Renderer> ().material.mainTextureOffset = new Vector2 (xoff, yoff);
	}   } 


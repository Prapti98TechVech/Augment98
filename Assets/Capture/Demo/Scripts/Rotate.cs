using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

    public float speed;
    private float yRotataion;
	
	// Update is called once per frame
	void FixedUpdate () 
    {
        yRotataion += speed;
        gameObject.transform.rotation = Quaternion.Euler(0f,yRotataion,0f);
	}
}

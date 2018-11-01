using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getSomeObj : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//transform.GetComponent<Rigidbody>().AddForce(transform.forward);  
        
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag=="Part")
        {
            Debug.Log(collision.collider.tag);
            collision.collider.transform.parent = null;
            collision.collider.gameObject.AddComponent<Rigidbody>();
            collision.collider.gameObject.GetComponent<Rigidbody>().mass = 0.1f;
            collision.collider.GetComponent<Rigidbody>().AddExplosionForce(500, collision.collider.transform.position,50 );
        }
        Destroy(this);
    }
}

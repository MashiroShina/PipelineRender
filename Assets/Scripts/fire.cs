using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    public GameObject obj;
	// Use this for initialization
	void Awake () {
	    Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        //shoot();
         shoots();
    }
    Vector3 dir;
    private void shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            shoots();
          Instantiate(obj, transform.position, Quaternion.identity);
        }    
    }
    private void shoots()
    {
        dir = Input.mousePosition;

        Ray ray = Camera.main.ScreenPointToRay(dir);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit,2000))

            Debug.DrawLine(transform.position, hit.point, Color.red);
        if (Input.GetMouseButtonDown(0))
        {           
          Rigidbody bt=  Instantiate(obj, transform.position, Quaternion.identity).GetComponent<Rigidbody>();
            bt.AddForce(ray.direction * 900);
        }

    }
   
}

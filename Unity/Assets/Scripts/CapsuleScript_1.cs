using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleScript_1 : MonoBehaviour {

    public float maxSpeed = 70.0f; // max horizontal speed

    public Rigidbody Rigidbody;
    //private Animator Animator;
    //private CapsuleCollider collider;
    private float angleY;

    // Use this for initialization
    void Start () {

        // get the component that will be used at each Update/FixedUpdate
        //Animator = GetComponent<Animator>();
        Rigidbody = GetComponent<Rigidbody>();
        /*NEW*/
        //collider = GetComponent<CapsuleCollider>();
        //Rigidbody.constraints = RigidbodyConstraints.FreezeRotationX;
        //Rigidbody.constraints = RigidbodyConstraints.FreezeRotationZ;



    }

    // Update is called once per frame
    void FixedUpdate () {
        Move();
	}



    private void Move()
    {   
        angleY = this.transform.eulerAngles.y * Mathf.PI / 180f;
        //Debug.Log("cos : " + Mathf.Cos(angleY));
        //Debug.Log("Sin : " + Mathf.Sin(angleY));
        Rigidbody.velocity = new Vector3(- maxSpeed * Mathf.Sin(angleY), 0, - maxSpeed * Mathf.Cos(angleY));
    }
}

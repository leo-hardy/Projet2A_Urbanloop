using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ralentisseur : MonoBehaviour {

    public GameObject capsule;

	// Use this for initialization
	void Start () {
		
	}

    void OnOnCollisionEnter(Collision coll)
    {
        capsule = GameObject.Find("capsule");

        if(coll.gameObject == capsule)
        {
            capsule.GetComponent<CapsuleScript_1>().maxSpeed = 3f;
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}

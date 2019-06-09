using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplierScript : MonoBehaviour {

    public GameObject rail;
    public int number = 3;
    public float longueur_rail = 43f;
    // rentrer +1 si on veut copier dans le sens du rail, et -1 si on veut copier derrière lui
    public float copier_vers_l_avant = 1.0f;

    private Vector3 v_pos;
    private Quaternion rot;
    private Vector3 new_pos;
    //private GameObject nv_rail;
    //private Rigidbody nv_rigidbody;
    //private float angleX;
    private float angleY;
    //private float angleZ;


    void Start()
    {
        

        v_pos = rail.transform.position;
        rot = rail.transform.rotation;
        //angleX = rail.transform.eulerAngles.x * Mathf.PI / 180f;
        angleY = rail.transform.eulerAngles.y * Mathf.PI / 180f;
        //angleZ = rail.transform.eulerAngles.z * Mathf.PI / 180f;

        // rot.eulerAngles.x; 

        for (int i = 1; i <= number; ++i)
        {   
            new_pos.x = v_pos.x + copier_vers_l_avant * (i * longueur_rail * Mathf.Sin(angleY));
            new_pos.y = v_pos.y; // + (i * longueur_rail * Mathf.Cos(angleY));
            new_pos.z = v_pos.z + copier_vers_l_avant * (i * longueur_rail * Mathf.Cos(angleY));
            Instantiate(rail, new Vector3(new_pos.x, new_pos.y, new_pos.z), rot);
            /*nv_rigidbody = nv_rail.GetComponent<Rigidbody>();
            nv_rigidbody.transform.position = new_pos;
            nv_rigidbody.transform.rotation = rot; */
            // Instantiate(rail);
        }
        
    }
}

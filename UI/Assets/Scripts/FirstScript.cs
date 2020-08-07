using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : Selector
{

    public GameObject cube;
    MeshRenderer mesh_cube;
    BoxCollider box_cube;
    Rigidbody rig_cube;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("1");
        Debug.Log(gameobj1.name);
        Debug.Log("2");
        mesh_cube = cube.GetComponent<MeshRenderer>();
        box_cube = cube.GetComponent<BoxCollider>();
        rig_cube = cube.GetComponent<Rigidbody>();
        //cube.transform.Translate(5f, 0, 0);
        //cube.transform.Translate(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //mesh_cube.material.color = Color.black;
        //mesh_cube.enabled = true;
        //rig_cube.constraints = RigidbodyConstraints.FreezePositionY;
        //cube.transform.Translate(0, 0, 0);
        //rig_cube.velocity = new Vector3(5f, 0, 0);
        // cube.transform.Rotate(1f,3f,3f);
        // cube.transform.localScale = new Vector3(2f,2f,2f);
        // cube.transform.position = new Vector3(0, 0, 0);
        //cube.transform.position = new Vector3(Mathf.PingPong(Time.time * 2.5f, 1), 0, 0);
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if(collision.gameObject.name == "cat_obj")
    //    {
    //        Debug.Log("Collosion");
    //    }
    //}
}

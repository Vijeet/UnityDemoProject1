using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    int flag;
    MeshRenderer renderer;
    Rigidbody rigidbody;
    [SerializeField] float timeToDrop = 3f;

    // Start is called before the first frame update
    void Start()
    {
        flag = 0;
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.useGravity = false;
        renderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        //Debug.Log("Elapsed time : "+Time.time);
        if (Time.time > timeToDrop && flag == 0) 
        {
            flag = 1;
            renderer.enabled = true;
            rigidbody.useGravity = true;
            //GetComponent<Rigidbody>().UseGravity = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 50f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = -1*Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        float y = 0;
        float z = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        
        transform.Translate(x,y,z);
    }
}

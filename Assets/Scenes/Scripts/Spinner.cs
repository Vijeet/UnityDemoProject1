using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
   
    [SerializeField] float rotateX = 0f;
    [SerializeField] float rotateY = 0f;
    [SerializeField] float rotateZ = 0f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateX,rotateY,rotateZ);
    }
}

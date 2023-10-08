using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int count;
    public void Start() 
    {
        count = 0;
    }

    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag != "Hit") 
        {
            Debug.Log("You've bumped into this thing this many times : "+ ++count);   
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipemovement : MonoBehaviour
{
    public float moveSpeed = 5;
    public double deadZone = 0.43;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        
        if(transform.position.x < deadZone)
        {
            Debug.Log("pipe deleted bro");
            Destroy(gameObject);
        }
    }
}

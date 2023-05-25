using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class middlepipescript : MonoBehaviour
{
   // public LogicScript logic;
    void Start()
    {
        //logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }
 
    // Start is called before the first frame update
     // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
       
        if(collision.gameObject.layer == 3)
        {
        
        Debug.Log("Enter");
        LogicScript.instance.AddScore();
        }
    }

  
}

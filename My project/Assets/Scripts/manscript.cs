using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manscript : MonoBehaviour
{
    public Rigidbody2D PlayerRB;
    public float FlapStrength = 10f;

    public float outOfscene = -4.5f;
    public bool gameOver ;
    public LogicScript GameOver;

    void Start()
    {
       
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            PlayerRB.velocity = Vector2.up * FlapStrength;
        }
        else if(transform.position.y < outOfscene)
        {
            gameOver = true;
            GameOver.Gameover();
        }



    }
    void OnCollisionEnter2D(Collision2D other)
    {
        GameOver.Gameover();
        
    }



}

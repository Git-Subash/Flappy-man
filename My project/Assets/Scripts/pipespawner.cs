using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipespawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawntime = 2;
    private float timer = 0;
    public float heightoffset = 10;
    private float Outofscene;
    public Transform Player;
    public LogicScript GameOver;

    void Start()
    {
        spawnpipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawntime)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnpipe();
            timer = 0;
        }
    }
    void spawnpipe()
    {
        float lowestPoint = transform.position.y - heightoffset;
        float highestPint = transform.position.y + heightoffset;
        if(Player.transform.position.y < Outofscene)
        {
            GameOver.Gameover();
        }
        else
        {
        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowestPoint,highestPint),0), transform.rotation);
        }
    }
}

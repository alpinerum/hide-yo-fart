using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
   
    public GameObject car;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;
    //public Sprite car;
    private Sprite cloneCar;
    private Vector3 target;
    private Vector2 startPos;
    public int test;
    // Start is called before the first frame update
    void Start()
    {
        test = 5;
        startPos = new Vector2(-19.17f, 0.95f);
        target = new Vector3(18.91f, 0.95f);
        
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    // Update is called once per frame
    public void SpawnObject()
    {
        //print(transform.position);
        spawnDelay = Random.Range(2.0f, 9.0f);
        //print(spawnDelay);
        //print(car);
        Instantiate(car, transform.position, transform.rotation);
        if (stopSpawning) {
            CancelInvoke("SpawnObject");
        }
    }

    // void Update() {
    //     //spawnObject();
    //     float step = moveSpeed * Time.deltaTime;
    //     transform.position = Vector2.MoveTowards(transform.position, target, step);
    //     if (transform.position == target) {
    //         //car.spriteRenderer.enabled = false;
    //     }
    // }
}

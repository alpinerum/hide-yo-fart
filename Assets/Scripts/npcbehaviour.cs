using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcbehaviour : MonoBehaviour
{
    public float moveSpeed;
    public Sprite mySprite;
    private Vector2 target;
    private Vector2 position;
    public bool isWalking;
    private SpriteRenderer spriteR;
    //Sprite npc;

    //public float walkTime;
    //private float walkCounter;
    //public float waitTime;
    //private float waitCounter;
    // Start is called before the first frame update
    void Start()
    {
        target = new Vector2(-3.14f, -3.29f);
        position = gameObject.transform.position;
        spriteR = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
        float step = moveSpeed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, target, step);
        Vector3 target2 = target;
        //print(transform.position);
        if(transform.position == target2) {
            //print(mySprite);
            //print(spriteR.sprite);
            spriteR.sprite = mySprite;
        }
    }
}

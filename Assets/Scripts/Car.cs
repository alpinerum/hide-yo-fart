using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    
    private float[] moveSpeed = {9.5f, 20.0f};
    public AudioClip[] engineSounds;
    public bool isSafe;
    private int random;
    private Vector3 target;
    public Sprite[] carSprites;
    public AudioSource sound;
    private float timer;
    
    // public AudioSource fart;
    // public GameObject farts;
    // public GameObject fartClone;
    // Start is called before the first frame update
    void Start()
    {
        //print("start");
        isSafe = false;
        target = new Vector3(18.91f, 0.95f);
        random = Random.Range(0,2);
        this.GetComponent<SpriteRenderer>().sprite = carSprites[random];
        timer = 0.0f;

        //fartClone = new GameObject();
        //InvokeRepeating("Check", 0.1f, 0.1f);
        //sound = GetComponent<AudioSource>();
    }

    void moveCar() {
        timer += Time.deltaTime;
        float step = moveSpeed[random] * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, target, step);
        sound.clip = engineSounds[random];
        sound.Play();
        //engineSounds[random].Play();
        if (transform.position.x > 18.9) {
            //print(random);
            //print("hi");
            Destroy(gameObject);
            sound.Stop();
            //print(timer);
        }

        // if(Input.GetKeyDown(KeyCode.Space)) {
        //     fart.Play();
        //     fartClone = Instantiate(farts, transform.position, transform.rotation);
        // }
        // else if (Input.GetKeyUp(KeyCode.Space)) {
        //     fart.Stop();
        //     Destroy(fartClone);
        // }
    }
    // Update is called once per frame
    void Update()
    {
        //print("hello");
        // if (sound.isPlaying) {
        //     isSafe = true;
        // }
        // else {
        //     isSafe = false;
        // }
        
        //print(isSafe);
        moveCar();
        isSafe = sound.isPlaying;               //intended for determining if car sound was playing
        fartEffect fart = gameObject.GetComponent<fartEffect>();
        //print(fart);
        //print(sound.isPlaying);
        //print(isSafe);
    }

    // void Check() {
    //     print(this.enabled);
    // }
}

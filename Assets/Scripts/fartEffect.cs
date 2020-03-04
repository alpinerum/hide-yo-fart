using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fartEffect : MonoBehaviour
{
    public AudioSource fart;
    public GameObject farts;
    public GameObject fartClone;
    public GameObject carSound;
    public bool safe;
    public float score;
    public Car car;
    //public GameObject test;
    // Start is called before the first frame update
    void Start()
    {
        score = 0.0f;
        fartClone = new GameObject();
        print(car);
        //InvokeRepeating("CheckScript", 0.1f, 0.1f);
        //test = GameObject.Find("car spawner");
        //Car car = test.GetComponent<Car>();
        //print(car);
        //gameObject.GetComponent<car>().sound.isPlaying;       //This code was intended to communicate with the car script
        //carSound = GameObject.Find("car spawner");            //to determine when sound starts and stop playing to determine
        //bool isSafe = gameObject.GetComponent<Car>().isSafe;  //whether fart can be triggered without losing
    }

    // Update is called once per frame
    void Update()
    {
        //spawner test2 = gameObject.GetComponent<spawner>();
        //print(test2.test);
        //print(Car);
        if(Input.GetKeyDown(KeyCode.Space)) {
            fart.Play();
            score += 100 * Time.deltaTime;
            fartClone = Instantiate(farts, transform.position, transform.rotation);
        }
        else if (Input.GetKeyUp(KeyCode.Space)) {
            fart.Stop();
            Destroy(fartClone);
        }
        print(car.isSafe);
        //if (car != null) {
        //    print(car.isSafe);
        //}
        //print(Car.isSafe);
        //if (!Car.sound.isPlaying && fart.isPlaying) {         //check to see if car sound is not playing when fart was triggered
        //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //}
        //print(score);
    }
    //  void CheckScript() {
    //      //Car car = gameObject.GetComponent<Car>();
    //      if (Car.enabled) {
    //          print("hello");
    //      }
    //  }
}

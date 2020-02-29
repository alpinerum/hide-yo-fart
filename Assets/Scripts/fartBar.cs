using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class fartBar : MonoBehaviour
{
    private Image barImage;
    private Fart fart;
    // Start is called before the first frame update
    void Start()
    {
        barImage = transform.Find("bar").GetComponent<Image>();
        barImage.fillAmount = 0.0f;

        fart = new Fart();
    }

    // Update is called once per frame
    void Update()
    {
        fart.Update();

        barImage.fillAmount = fart.GetFartNormalized();
        //print(fart.fartAmount);
        gameCheck();
        if(Input.GetKeyDown(KeyCode.Space)) {
            fart.spendFart(10);
        }
        if (fart.fartAmount == 100.0) {
            StartCoroutine(gameCheck());
            
            //yield return new WaitForSeconds(2);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        
    }

    IEnumerator gameCheck() {
        print (fart.fartAmount);
        
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }
}

public class Fart {
    public const int FART_MAX = 100;
    public float fartAmount;
    private float regenAmount;

    public Fart() {
        fartAmount = 0;
        regenAmount = 10f;
    }

    public void Update() {
        if(Input.GetKey(KeyCode.Space)) {
            //Debug.Log("fart");
            fartAmount -= 4 * Time.deltaTime;
        }
        else {
            fartAmount += regenAmount * Time.deltaTime;
        }
        //print(fartAmount);
        fartAmount = Mathf.Clamp(fartAmount, 0f, FART_MAX);
    }

    public void spendFart(int amount) {
        // if(Input.GetKeyDown(KeyCode.Space)) {
        //     fartAmount -= 10 * Time.deltaTime;
        // }
    }

    public float GetFartNormalized() {
        return fartAmount / FART_MAX;
    }
}

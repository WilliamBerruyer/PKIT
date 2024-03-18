using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BasketEgg : MonoBehaviour
{
    private int appleCounter = 0;
    private int boxCounter = 0;
    public TMP_Text counterNumber;

    public GameObject[] apples;
    public GameObject box1;
    public GameObject box2;
    public GameObject endDialog;
    public AudioSource audiosource;
    public AudioSource finalSound;

    int a = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Apple"))
        {
            appleCounter++;
            boxCounter++;
            if (appleCounter == 17)
            {
                end();
            }

            Debug.Log("Entered");
            audiosource.Play();
            
            counterNumber.text = appleCounter.ToString();
            Destroy(collision.gameObject);
            if(boxCounter < 6 && boxCounter > 0)
            {
                apples[boxCounter].SetActive(true);

            }
            else if(boxCounter >= 6)
            {
                for (int i = 0; i < 6; i++)
                {
                    apples[i].SetActive(false);
                }
                box1.SetActive(true);
                if(a == 1)
                {
                    box2.SetActive(true);
                }
                a = 1;
                boxCounter = 0;
            }
            
        }
    }

    private void end()
    {
        endDialog.SetActive(true);
        finalSound.Play();
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Basket : MonoBehaviour
{
    private int appleCounter = 0;
    private int boxCounter = 0;
    public TMP_Text counterNumber;

    public GameObject[] apples;
    public GameObject box1;
    public GameObject endDialog;
    public AudioSource audiosource;
    public AudioSource finalSound;

    public GameObject[] water;
    public GameObject bucket;
    private int bucketCounter = 0;
    private int waterCounter = 0;

    public GameObject lever;
    public GameObject rope;

    private Boolean dropped = false;

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
            if (appleCounter == 18)
            {
                end();
            }

            Debug.Log("Entered");
            audiosource.Play();
            
            counterNumber.text = appleCounter.ToString();
            Destroy(collision.gameObject);
            if(boxCounter < 9 && boxCounter > 0)
            {
                apples[boxCounter].SetActive(true);

            }
            else if(boxCounter >= 9)
            {
                for (int i = 0; i < 9; i++)
                {
                    apples[i].SetActive(false);
                }
                box1.SetActive(true);
                boxCounter = 0;
            }
        }

        if (collision.gameObject.CompareTag("Bucket"))
        {
            
            
            bucketCounter++;
            waterCounter++;
            bucket.GetComponentInChildren<Rigidbody>().useGravity = false;
            bucket.GetComponentInChildren<Rigidbody>().isKinematic = true;
            

            audiosource.Play();
            counterNumber.text = waterCounter.ToString() + "/3";

            if (bucketCounter == 1)
            {
                water[bucketCounter - 1].SetActive(true);
            }
            else if (bucketCounter == 2)
            {
                water[bucketCounter - 2].SetActive(false);
                water[bucketCounter - 1].SetActive(true);
            }
            else if (bucketCounter == 3)
            {
                water[bucketCounter - 2].SetActive(false);
                water[bucketCounter - 1].SetActive(true);
            }

            if (waterCounter == 3)
            {
                end();
            }

            bucket.transform.position = new Vector3(151.3521f, 4.7214f, 180.7826f);
            bucket.transform.eulerAngles = new Vector3(
                0,
                0,
                0
            );
            lever.transform.eulerAngles = new Vector3(
                0,
                lever.transform.eulerAngles.y,
                lever.transform.eulerAngles.z
            );
            rope.gameObject.transform.localScale = new Vector3(
                rope.transform.localScale.x,
                1,
                rope.transform.localScale.z);
            Debug.Log(bucketCounter);
            Debug.Log(waterCounter);
        }
    }

    

    private void end()
    {
        endDialog.SetActive(true);
        finalSound.Play();
    }

    public void changeDropped()
    {
        dropped = !dropped;
    }
}

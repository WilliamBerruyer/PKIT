using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class appleFallPitchfork : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        
        if (collision.gameObject.CompareTag("Pitchfork"))
        {
            
            gameObject.GetComponentInParent<Rigidbody>().isKinematic = false;
            gameObject.GetComponentInParent<Rigidbody>().useGravity = true;

            
        }
    }
}

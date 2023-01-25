using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSound : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(this.transform.parent.GetComponent<Rigidbody>().velocity.magnitude > 0){
        this.transform.GetComponent<AudioSource>().Play();
     }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bambuCopy : MonoBehaviour
{
    public GameObject bambu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void copy(){
        Instantiate (bambu, transform.position, transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

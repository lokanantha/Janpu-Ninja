using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bambu : MonoBehaviour
{
    float Ybambu;
    public float kecepatan;
    // Start is called before the first frame update
    void Start()
    {
        Ybambu = Random.Range (-2,4);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1){
            transform.localPosition = new Vector3 (transform.localPosition.x-kecepatan, Ybambu, 1f);
        }
    }
}

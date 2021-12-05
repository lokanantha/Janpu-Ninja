using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    public float berat, tinggiLoncat;
    public GameObject ninja, intruction, bambuCopy, skor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown() {
        if (Time.timeScale == 1){
            GameObject.Find ("suara wing").GetComponent<AudioSource> ().Play ();
            bambuCopy.SetActive (true);
            intruction.SetActive (false);
            skor.SetActive (true);
            ninja.GetComponent<Rigidbody2D> ().gravityScale = berat;
            ninja.GetComponent<Rigidbody2D>().velocity = new Vector2 (ninja.GetComponent<Rigidbody2D>().velocity.x, tinggiLoncat);
            ninja.GetComponent<Animator>().SetTrigger("jump");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.Escape)){
            Application.Quit ();
        }
    }
}

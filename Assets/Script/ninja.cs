using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ninja : MonoBehaviour
{
    public GameObject gameover, skor, emas, perak;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "grd"){
             GameObject.Find ("suara hit").GetComponent<AudioSource> ().Play ();
            skor.SetActive (false);
            gameover.SetActive (true);
            if(PlayerPrefs.GetInt("highscore") < skor.GetComponent<skor>().score){
               PlayerPrefs.SetInt ("highscore", skor.GetComponent<skor>().score); 
            }
            if(skor.GetComponent<skor>().score >30){
                emas.SetActive(true);
            }else if(skor.GetComponent<skor> ().score >15){
                perak.SetActive(true);
            }

            Time.timeScale = 0;
        }    
        if (other.gameObject.name == "addScore"){
             GameObject.Find ("suara score").GetComponent<AudioSource> ().Play ();
            skor.GetComponent<skor> ().score++;
        }    
    }
}

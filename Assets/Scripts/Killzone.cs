using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Killzone : MonoBehaviour{

    private int live;
    public TMP_Text liveTex; 

    public void Start(){
        live = 3;
    }

    public void Update(){
        if (live == 0) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void OnCollisionEnter(Collision collision){
        if(collision.transform.CompareTag("Player")){
            live--;
            liveTex.text = live.ToString();
        }
    }
}

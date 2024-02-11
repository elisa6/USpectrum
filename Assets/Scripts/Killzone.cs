using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Killzone : MonoBehaviour{

    private int live;
    public TMP_Text vidaTex; 

   
public void Start(){
        live = 3;
}



public void Update(){
        //vidaTex.text = vida.ToString();
        if (live == 0) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
}


public void OnCollisionEnter(Collision collision){
    if(collision.transform.CompareTag("Player")){
            live--;
       }


}

}  
    














using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveNextLvel : MonoBehaviour
{
  public AudioSource musicsource;
  

    void start(){
    }
    
   void OnTriggerEnter2D(Collider2D other)
 {
     if (other.tag == "Player"){
      musicsource.Play();
    SceneManager.LoadScene(1);

        
 }

  
 }
}

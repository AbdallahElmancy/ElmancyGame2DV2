using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectCoin : MonoBehaviour
{
    public AudioClip coinSound;
    void OnTriggerEnter2D(Collider2D other){
        
        if(other.gameObject.tag=="Player"){
        AudioSource.PlayClipAtPoint(coinSound, transform.position);
        Destroy(gameObject);
        score.instance.AddPoint();
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static score instance;
   public  Text scoretext;
    int scorenum=0;

    private void Awake(){
        instance = this;
    }

    void Start()
    {
        scoretext.text =scorenum.ToString() + " Points ";
        
    }

    public void AddPoint(){
        scorenum +=10;
        scoretext.text =scorenum.ToString() + " Points ";

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    void Start()
    {
        speed=20;
    }

    // Update is called once per frame
    void Update()
    {     
        float horizontal=Input.GetAxis("Horizontal")*Time.deltaTime*speed;
        
        transform.Translate(horizontal,0,0);
    }
}

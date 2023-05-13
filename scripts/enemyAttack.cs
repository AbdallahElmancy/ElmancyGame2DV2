using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAttack : MonoBehaviour
{
    public Rigidbody2D req;
    public float speed=1;
    // Start is called before the first frame update
    void Start()
    {
        req=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        req.velocity = -(new Vector2 (transform.localScale.x , 0 ) * speed);
    }
}

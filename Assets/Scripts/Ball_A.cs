using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_A : MonoBehaviour
{
    private Rigidbody ball = null;
    Vector3 force = new Vector3 (0.0f,3.0f,0.0f);

    public void Awake(){
        this.ball = this.GetComponent<Rigidbody>();
    }

    void start(){

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClickBall(){
        this.ball.AddForce(force,ForceMode.Impulse);
    }
}

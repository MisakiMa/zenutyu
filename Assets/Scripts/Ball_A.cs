using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_A : MonoBehaviour
{
    private Rigidbody ball = null;
    Vector3 forceDirection = new Vector3 (0.0f,1.0f,1.0f);
    Vector3 initPosition = new Vector3(0.0f,0.5f,0.0f);
    float forceMagnitude = 5.0f;
    Vector3 force;

    bool isFlying = false;

    bool isSpacePressed = false;

    public void Awake(){
        this.ball = this.GetComponent<Rigidbody>();
    }

    void start(){
        initPosition = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space)){
            isSpacePressed = true;
        }
    }

    public void onClickBall(){
        isFlying = true;
        //this.forceMagnitude = 5.0f;
        this.force = this.forceDirection * this.forceMagnitude;
        this.ball.AddForce(this.force,ForceMode.Impulse);
    }

    public void FixedUpdate(){
        if(isSpacePressed){
            if(isFlying){
                this.ball.velocity = Vector3.zero;
                this.ball.angularVelocity = Vector3.zero;

                gameObject.transform.position = initPosition;
                isFlying = !isFlying;
            }

            isSpacePressed = false;
        }
    }
}

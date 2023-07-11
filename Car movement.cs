using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carmovement : MonoBehaviour
{
    public Rigidbody2D CarRig;
    public Rigidbody2D backWheelRig;
    public Rigidbody2D frontWheelRig;

    public float speed;
    public float torque;

    private float movement;

    // Start is called before the first frame update
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
        {
    
        backWheelRig.AddTorque(-movement * speed * Time.deltaTime);
        frontWheelRig.AddTorque(-movement * speed * Time.deltaTime);
        CarRig.AddTorque(-movement * torque * speed * Time.deltaTime);
    }
}
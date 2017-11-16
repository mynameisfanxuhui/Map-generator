using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    private Rigidbody rig;
    private Vector3 velocity;
    private void Start()
    {
        rig = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        velocity = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized*10;
    }
    private void FixedUpdate()
    {
        //rig.velocity = velocity * 10;
        rig.MovePosition(rig.position + velocity * Time.fixedDeltaTime);
    }
}

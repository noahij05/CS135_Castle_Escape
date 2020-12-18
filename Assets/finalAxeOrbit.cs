using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalAxeOrbit : MonoBehaviour
{
    /*
    public Rigidbody playerRigidbody;
    public Vector3 moveDirection;

    void OnTriggerEnter(Collider hit)
    {    
        moveDirection = playerRigidbody.transform.position - this.transform.position;
        playerRigidbody.AddForce(moveDirection * -5000f);
    }
    */
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(new Vector3(0, 0.25f, 0));
    }
}

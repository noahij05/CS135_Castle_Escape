using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public Rigidbody boulder;
    public Rigidbody boulder2;
    public Rigidbody boulder3;
    public Rigidbody boulder4;
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "ball roller")
        {
            boulder.useGravity = true;
            boulder2.useGravity = true;
        }

        if (other.gameObject.tag == "boulder")
        {
            Vector3 moveDirection = new Vector3(5.0f, 1.0f, 0.0f);
            transform.position = (moveDirection);
        }

        if (other.gameObject.tag == "sword")
        {
            Vector3 moveDirection = new Vector3(60.0f, 21.0f, 0.0f);
            transform.position = (moveDirection);
        }

        if (other.gameObject.tag == "lava")
        {
            Vector3 moveDirection = new Vector3(110.0f, 25.0f, 0.0f);
            transform.position = (moveDirection);
        }

        if (other.gameObject.tag == "final_axe")
        {
            Vector3 moveDirection = new Vector3(183.5f, 26.0f, 0.0f);
            transform.position = (moveDirection);
        }

        if (other.gameObject.tag == "end")
        {
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #else
            Application.Quit();
            #endif
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        boulder.GetComponent<Rigidbody>();
        boulder2.GetComponent<Rigidbody>();
        //boulder3.GetComponent<Rigidbody>();
        //boulder4.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #else
            Application.Quit();
            #endif
        }
    }

  
}

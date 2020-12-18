using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe2spin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(new Vector3(0.0f, -1.75f, 0.0f));
    }
}

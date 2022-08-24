using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rd;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            rd.AddForce(0, 0, 200 * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rd.AddForce(0, 0, -200 * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            rd.AddForce(-200 * Time.deltaTime, 0,0 );
        }
        if (Input.GetKey("d"))
        {
            rd.AddForce(200 * Time.deltaTime, 0, 0);
        }
    }
}

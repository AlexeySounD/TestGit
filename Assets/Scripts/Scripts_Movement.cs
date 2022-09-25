using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scripts_Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            gameObject.GetComponent<Rigidbody>().transform.Translate(0, 0, 0.25f);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            gameObject.GetComponent<Rigidbody>().transform.Translate(0, 0, 0.25f);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            gameObject.GetComponent<Rigidbody>().transform.Translate(-0.25f, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            gameObject.GetComponent<Rigidbody>().transform.Translate(0.25f, 0, 0);
        }
    }
}

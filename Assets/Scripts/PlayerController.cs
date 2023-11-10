using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left"))
        {
            gameObject.transform.Translate(-50 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("right"))
        {
            gameObject.transform.Translate(50 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("down"))
        {
            gameObject.transform.Translate(0, -50 * Time.deltaTime, 0);
        }
        if (Input.GetKey("up"))
        {
            gameObject.transform.Translate(0, 50 * Time.deltaTime, 0);
        }
    }
}

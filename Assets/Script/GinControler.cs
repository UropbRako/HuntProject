using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GinControler : MonoBehaviour
{
    private float horuzontal;
    private float vertical;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxis("Mouse Y");
        horuzontal = Input.GetAxis("Mouse X");
        transform.Rotate(0, 0, vertical);
        transform.Rotate(0, horuzontal, 0);
    }
}
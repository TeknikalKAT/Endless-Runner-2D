using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input_Controller : MonoBehaviour
{
    //public float horizontal;
    public float vertical;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }
}

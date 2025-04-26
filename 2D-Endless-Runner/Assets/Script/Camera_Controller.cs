using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour
{
    public float camSpeed = 5f;
    public float time;
    public float speedIncrease = 2.5f;
    public float speedThreshold = 40f;

    float _time;

    // Start is called before the first frame update
    void Start()
    {
        _time = time;
    }

    // Update is called once per frame
    void Update()
    {
        _time -= Time.deltaTime;
        if (_time <= 0)
        {
            IncreaseSpeed();
            _time = time;
        }
        transform.position += new Vector3(camSpeed * Time.deltaTime, 0, 0);
    }

    void IncreaseSpeed()
    {
        if (camSpeed < speedThreshold)
            camSpeed += speedIncrease;
    }
}

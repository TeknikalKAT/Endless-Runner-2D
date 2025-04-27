using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_Loop : MonoBehaviour
{
    public float backgroundSpeed;
    public Renderer backgroundRenderer;
    public float time = 10f;
    public float increaseSpeed = 0.1f;
    public float speedTreshold = 1;

    float _time;
    void Start()
    {
        _time = time;

    }
    // Update is called once per frame
    void Update()
    {
        _time -= Time.deltaTime;
        if (_time <= 0)
            IncreaseSpeed();
        backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0);
    }
    void IncreaseSpeed()
    {
        if (backgroundSpeed < speedTreshold)
            backgroundSpeed += increaseSpeed;
        _time = time;
    }
}

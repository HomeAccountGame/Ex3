using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    float x = 0;
    float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Mathf.Cos(x) * Time.deltaTime * speed * 2, Mathf.Sin(x * 2) * Time.deltaTime * speed, 0);
        x += 0.01f;
    }
}  

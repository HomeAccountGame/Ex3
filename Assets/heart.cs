using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart : MonoBehaviour
{
    float max = 5f;
    float min = 0.2f;
    bool flag = false;
    float sizeC = 0.02f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dir();
        if (flag)
        {
            transform.localScale = new Vector3(transform.localScale.x + sizeC, transform.localScale.y + sizeC, transform.localScale.z + sizeC);
        }
        else
        {
            transform.localScale = new Vector3(transform.localScale.x - sizeC, transform.localScale.y - sizeC, transform.localScale.z - sizeC);
        }
    }
    void dir()
    {
        if (transform.localScale.x > max)
        {
            flag = false;
        }
        else if (transform.localScale.x < min)
        {
            flag = true;
        }
    }
}

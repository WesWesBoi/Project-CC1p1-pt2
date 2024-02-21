using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour
{

    float mySpeed = 1.5f;
    int integerrNumber = 5;

    // Start is called before the first frame update
    void Start()
    {
        mySpeed = 11f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Time.deltaTime * mySpeed, 1.5f, 11f);
    }
}

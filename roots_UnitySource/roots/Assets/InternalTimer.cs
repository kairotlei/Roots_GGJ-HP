using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InternalTimer : MonoBehaviour
{


    // var declaration

    public static float stopwatch = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        stopwatch =  stopwatch + Time.deltaTime;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loopAudio : MonoBehaviour
{

    AudioSource myLoop;

    // Start is called before the first frame update
    void Start()
    {
        myLoop = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

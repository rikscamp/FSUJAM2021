using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDup : MonoBehaviour
{
    private void Awake()
    {
        int numMusicPlayer = FindObjectsOfType<DestroyDup>().Length;

        if (numMusicPlayer != 1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
                
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

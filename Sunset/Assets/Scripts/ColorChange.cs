using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public SpriteRenderer player;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        



    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.color = Color.red;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        player.color = Color.green;
    }


}

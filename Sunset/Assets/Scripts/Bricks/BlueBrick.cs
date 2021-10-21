using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBrick : MonoBehaviour
{
    public SpriteRenderer player;
    public float lerpTime = 1;

    public bool isIn;
    





    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isIn == true)
        {
            player.color = Color.Lerp(player.color, Color.blue, lerpTime * Time.deltaTime);
        }

       


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //player.color = Color.red;
        //Debug.Log("enter");
        isIn = true;
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //Debug.Log("exit");
        isIn = false;
        
    }
}

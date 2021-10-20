using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public SpriteRenderer player;
    [Range(0, 1)] public float lerpTime;

    private bool isIn;
    private bool isOut;

    public Color colorToChangeTo;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isIn == true)
        {
            player.color = Color.Lerp(player.color, Color.red, lerpTime * Time.deltaTime);
        }
        else
        {
            player.color = Color.Lerp(player.color, Color.green, lerpTime * Time.deltaTime);
        }
        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //player.color = Color.red;
        Debug.Log("enter");
        isIn = true;
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("exit");
        isIn = false;
        
    }


}

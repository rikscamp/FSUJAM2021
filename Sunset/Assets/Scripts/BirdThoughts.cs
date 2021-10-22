using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdThoughts : MonoBehaviour
{

    private PlayerMove player;


    private BlueBrick isBlue;
    private ColorChange isRed;
    private CyanBrick isCyan;
    

    //brick colors
    public GameObject red;
    public GameObject blue;
    public GameObject cyan;

    public int d6;


    // Start is called before the first frame update
    void Awake()
    {
        StartCoroutine(ColorThink());

        isBlue = GameObject.FindObjectOfType<BlueBrick>();
        isCyan = GameObject.FindObjectOfType<CyanBrick>();
        isRed = GameObject.FindObjectOfType<ColorChange>();


        player = GameObject.FindObjectOfType<PlayerMove>();
    }

    // Update is called once per frame
    void Update()
    {
        




    }

    IEnumerator ColorThink()
    {

        yield return new WaitForSeconds(5);

        d6 = Random.Range(1, 4);

        if(d6 == 1)
        {
            red.SetActive(true);
            yield return new WaitForSeconds(4);
            
            if (isRed.isIn)
            {
                Debug.Log("yay!");
            }
            else
            {
                player.isDead = true;
            }

            red.SetActive(false);
        }
        if (d6 == 2)
        {
            blue.SetActive(true);
            yield return new WaitForSeconds(4);
            if (isBlue.isIn)
            {
                Debug.Log("yay!");
            }
            else
            {
                player.isDead = true;
            }
            blue.SetActive(false);
        }
        if (d6 == 3)
        {
            cyan.SetActive(true);
            yield return new WaitForSeconds(4);
            if (isCyan.isIn)
            {
                Debug.Log("yay!");
            }
            else
            {
                player.isDead = true;
            }
            
            cyan.SetActive(false);
        }

        

        StartCoroutine(ColorThink()); 


    }
}

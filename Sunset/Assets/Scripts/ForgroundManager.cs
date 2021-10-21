using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForgroundManager : MonoBehaviour
{
    public int d20;

    

    public Animator animator;
    
    public GameObject juniperJazz;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RollDice());
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(d20);

       


        if (d20 == 1)
        {
            //Juniper
            Debug.Log("Juniper Jazz is on the case!");
            juniperJazz.SetActive(true);
            d20 = 0;
           

        }

        if (d20 == 2)
        {
            //BottleMan

            d20 = 0;



        }

        if (d20 == 3)
        {
            //??

            d20 = 0;

        }
    }

    IEnumerator RollDice()
    {
        //Debug.Log("called");
       
        yield return new WaitForSeconds(8);
        d20 = Random.Range(1, 4);
        yield return new WaitForSeconds(8);
        StartCoroutine(RollDice());
    }

    
}

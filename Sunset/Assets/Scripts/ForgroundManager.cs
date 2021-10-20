using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForgroundManager : MonoBehaviour
{
    public int d20;

    public bool eventHappening = false;



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
            //PlayAnim
            
            
        }

        if (d20 == 2)
        {
            //PlayAnim


        }

        if (d20 == 3)
        {
            //PlayAnim


        }
    }

    IEnumerator RollDice()
    {
        //Debug.Log("called");
        eventHappening = true;
        yield return new WaitForSeconds(5) ;
        d20 = Random.Range(1, 7);
        StartCoroutine(RollDice());
    }
}

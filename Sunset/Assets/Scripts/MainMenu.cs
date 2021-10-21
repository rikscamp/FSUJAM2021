using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    private Controls controls;
    private ForgroundManager cameoInitiate;
    
    public Animator cam;

    private void Awake()
    {
        controls = new Controls();

        controls.Menu.StartGame.performed += ctx => StartGame();
        cameoInitiate = GameObject.FindObjectOfType<ForgroundManager>();

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void StartGame()
    {
        Debug.Log("StartGame");
        cam.SetTrigger("gameStart");

        //Tell Scripts to start working!!
        cameoInitiate.gameStart = true;

        
        Destroy(this);
    }

    private void OnEnable()
    {
        controls.Enable();
    }
    private void OnDisable()
    {
        controls.Disable();
    }
}

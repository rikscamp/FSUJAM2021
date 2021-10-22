using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Controls controls;

    //Special Bricks
    private ColorChange redBrick;
    private BlueBrick blueBrick;
    private CyanBrick cyanBrick;

    //Objects to disable upon death
    public GameObject foot1;
    public GameObject foot2;
    public GameObject thought1;
    public GameObject thought2;
    public GameObject birdT;


    public Animator animator;
    public Animator birb;
    private string currentState;
    

    Rigidbody2D rigidB;
    
    public SpriteRenderer player;

    //Animation States
    const string PLAYER_IDLE = "Idle";
    const string PLAYER_WALK = "Walk";

    const string BIRB_LEAVE = "FuckYou";

    public float speed;
    public int rotationSpeed;
    public bool isWalking;
    public bool isDead;

    public float lerpTime = 1;

    Vector2 inputValue;

    private void Awake()
    {
        controls = new Controls();
        redBrick = GameObject.FindObjectOfType<ColorChange>();
        blueBrick = GameObject.FindObjectOfType<BlueBrick>();
        cyanBrick = GameObject.FindObjectOfType<CyanBrick>();

        rigidB = GetComponent<Rigidbody2D>();
        

        controls.InGame.Move.performed += ctx => inputValue = ctx.ReadValue<Vector2>();
        controls.InGame.Move.canceled += ctx => inputValue = Vector2.zero;

        controls.InGame.Restart.performed += ctx => Restart();

        //player.color = Color.green;

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (!isDead) 
        {

            rigidB.velocity = inputValue * (speed * Time.fixedDeltaTime);

            if (redBrick.isIn == false && blueBrick.isIn == false && cyanBrick.isIn == false)
            {
                player.color = Color.Lerp(player.color, Color.green, lerpTime * Time.deltaTime);
            }


            RotatePlayer();
        }
        else
        {

            foot1.SetActive(false);
            foot2.SetActive(false);
            thought1.SetActive(false);
            thought2.SetActive(false);
            birdT.SetActive(false);


            ChangeAnimationStateBirb(BIRB_LEAVE);
        }
    }

    private void RotatePlayer()
    {
        if (inputValue.magnitude > 0.01f) {

            float rotation = Mathf.Atan2(inputValue.y, inputValue.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, 0f, rotation - 90);

            isWalking = true;

            //walking anim her
            ChangeAnimationState(PLAYER_WALK);

            

        }

        if (inputValue.magnitude < 0.01)
        {
            isWalking = false;

            //Idle anim here
            ChangeAnimationState(PLAYER_IDLE);
        }

    }

    
    

    void ChangeAnimationState(string newState)
    {
        //stop the anim from interrupting itself
        if (currentState == newState) return;

        //Play the animation
        animator.Play(newState);

        //reassign the current state
        currentState = newState;

    }

    void ChangeAnimationStateBirb(string newState)
    {
        //stop the anim from interrupting itself
        if (currentState == newState) return;

        //Play the animation
        birb.Play(newState);

        //reassign the current state
        currentState = newState;

    }

    void Restart()
    {
        SceneManager.LoadScene("Test");
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

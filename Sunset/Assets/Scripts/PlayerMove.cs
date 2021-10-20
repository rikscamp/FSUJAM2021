using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Controls controls;
    public Animator animator;
    private string currentState;

    Rigidbody2D rigidB;
    
    public SpriteRenderer player;

    //Animation States
    const string PLAYER_IDLE = "Idle";
    const string PLAYER_WALK = "Walk";

    public float speed;
    public int rotationSpeed;
    public bool isWalking;

    Vector2 inputValue;

    private void Awake()
    {
        controls = new Controls();
        rigidB = GetComponent<Rigidbody2D>();
        

        controls.InGame.Move.performed += ctx => inputValue = ctx.ReadValue<Vector2>();
        controls.InGame.Move.canceled += ctx => inputValue = Vector2.zero;

        player.color = Color.green;

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        rigidB.velocity = inputValue * (speed * Time.deltaTime);
        
        RotatePlayer();

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

    private void OnEnable()
    {
        controls.Enable();
    }
    private void OnDisable()
    {
        controls.Disable();
    }
}

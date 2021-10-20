using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Controls controls;

    Rigidbody2D rigidB;
    public Animator animator;
    public SpriteRenderer player;

    //Animation States



    public float speed;
    public int rotationSpeed;

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
        }
        //transform.LookAt(transform.position + inputValue);

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

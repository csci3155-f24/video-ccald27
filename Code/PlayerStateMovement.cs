using UnityEngine;
using TMPro;


public class PlayerStateMovement : MonoBehaviour
{
    public TMP_Text stateText;
    private enum PlayerState { Idle, Moving }
    private PlayerState currentState = PlayerState.Idle;
    public float moveSpeed = 5f;


    private Rigidbody rb;

    private float horizontalInput;
    private float verticalInput;

    void Start()
    {

        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        if (horizontalInput != 0 || verticalInput != 0)
        {
            ChangeState(PlayerState.Moving);
        }
        else
        {
            ChangeState(PlayerState.Idle);
        }

          stateText.text = "Current State: " + currentState;
    }

    void FixedUpdate()
    {

        MovePlayer();
    }

    void MovePlayer()
    {
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput) * moveSpeed * Time.deltaTime;
        rb.MovePosition(transform.position + movement);
    }


    void ChangeState(PlayerState newState)
    {
        if (currentState != newState)
        {
            currentState = newState;
            Debug.Log("Player state changed to: " + newState);
        }
    }
}

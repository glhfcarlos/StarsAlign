using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class VirMouseMov : MonoBehaviour
{
      public float moveSpeed = 5f; 
    public Rigidbody2D rb; 
    Vector2 movement; 

  void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");


           movement.x = horizontalInput;
        movement.y = verticalInput;

    }

    void FixedUpdate()
    {
        // Move the player's Rigidbody based on the movement input
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

//   private Rigidbody2D sphereRigidbody; 
//   private PlayerInput playerInput; 
//   private InputSystem playerInputActions; 

// private void Awake() 
// {
//   sphereRigidbody = GetComponent<Rigidbody2D>(); 
//   playerInput = GetComponent<PlayerInput>(); 


//   playerInputActions = new InputSystem(); 
//   playerInputActions.PlayerStar.Enable(); 
// }
// private void FixedUpdate() {

//     //Vector2 inputVector = playerInputActions.Player.Movement.ReadValue<Vector2>();
//     Vector2 inputVector = playerInputActions.PlayerStar.Move.ReadValue<Vector2>(); 
//     Debug.Log(inputVector); 
//     float speed = 5f; 
//     sphereRigidbody.AddForce(new Vector2(inputVector.x, inputVector.y) * speed, ForceMode2D.Force); 
// }



















  // [SerializeField] private Rigidbody2D rb2D; 
  // [SerializeField] private float speed; 
  // private Vector2 moveInputValue; 

  // private void OnMove(InputValue value) 
  // {
  //   moveInputValue = value.Get<Vector2>(); 
  //   Debug.Log(moveInputValue); 
  // }

  // private void MoveLogicMethod()
  // {
    
  //   Vector2 result = moveInputValue * speed * Time.fixedDeltaTime; 
  //   rb2D.velocity = result; 
  // }

  // private void FixedUpdate() {
  //   MoveLogicMethod(); 
  // }
}

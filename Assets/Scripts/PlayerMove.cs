using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
	// variables 
	public CharacterController controller;

	public float speed = 40f;
	public float gravity = -10f;

	public Transform groundCheck;
	public float groundDistance = 0.3f;
	public LayerMask groundMask;
	

	Vector3 velocity;

	bool isGrounded;

	// Update is called once per 
	void Update()
	{
		isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

		// capturador de controles en el eje x y y
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");

		Vector3 move = transform.right * x + transform.forward * z;

		controller.Move(move * speed * Time.deltaTime);

		velocity.y += gravity * Time.deltaTime;
		controller.Move(velocity * speed * Time.deltaTime);
	}
    
}

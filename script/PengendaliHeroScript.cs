using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PengendaliHeroScript : MonoBehaviour
{
	//Variabel untuk gerakan horizontal
	float dirX;

	//Variabel untuk kecepatan gerak dan dapat diatur di Inspector
	public float kecepatan = 10f, lompatan = 70f;

	//referensikan komponen RigidBody
	Rigidbody2D rb;


	// Start is called before the first frame update
	void Start()
	{
		//untuk mengoperasikan komponenRigidBody
		rb = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		dirX = CrossPlatformInputManager.GetAxis("Horizontal");

		if (CrossPlatformInputManager.GetButtonDown("Jump"))
			Lompat();
	}

	void FixedUpdate()
	{
		rb.velocity = new Vector2(dirX * kecepatan, rb.velocity.y);

	}

	public void Lompat()
	{
		if (rb.velocity.y == 0f)
			rb.AddForce(new Vector2(0, lompatan), ForceMode2D.Force);
	}
}
using UnityEngine;
using System.Collections;

public class prt_PlayerController : MonoBehaviour {

	private Rigidbody2D rb; //Player rigid body

	public Transform port;
	public Transform starboard;

	public float turnLength;
	public float acceleration;
	public float maxSpeed;
	public float rotationSpeed = 5.0f;

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate () { //fixed update is for physics calculations

		float speed = acceleration * Time.deltaTime;
		rb.AddForce(transform.right * acceleration, ForceMode2D.Force);

		if(rb.velocity.magnitude > maxSpeed) //speed limit
         {
         	rb.velocity = rb.velocity.normalized * maxSpeed;
         }

		if (Input.GetAxis("Horizontal") > 0) {
			Quaternion targetQuat = Quaternion.Euler(port.localEulerAngles);
			Quaternion myQuat = Quaternion.Euler(transform.localEulerAngles);
			while(myQuat!=targetQuat)
			 {
				 transform.localRotation = Quaternion.RotateTowards(myQuat, targetQuat, rotationSpeed);
				 myQuat = Quaternion.Euler(transform.localEulerAngles);
			 }
		}
		if (Input.GetAxis("Horizontal") < 0)  {
			turnRight();
		}

	}

	void turnLeft() { //turns 90 degrees to the left
		//rb.rotation
		//rb.AddTorque (rotationSpeed * -1, ForceMode2D.Force); 


	}

	void turnRight() { //turns 90 degrees to the right
		rb.AddTorque (rotationSpeed * 1, ForceMode2D.Force);
	}

	public void goToOrigin() {
		Debug.Log("Good Job!");
	}
}

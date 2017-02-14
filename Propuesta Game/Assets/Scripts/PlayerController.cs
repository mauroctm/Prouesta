using UnityEngine;
using System.Collections;


public class PlayerController : MonoBehaviour {

	public float speed;
	private Rigidbody rb;
	private Rigidbody rbpickUp;
	private float x = -6f;
	private float y = 35f;
	private float z = -23f;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		rb.useGravity = true;
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0, moveVertical);

		rb.AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other) 
	{
		print ("Entro");
		if (other.gameObject.CompareTag ("Pick Up"))
		{
			other.gameObject.SetActive (false);
			//other.gameObject.transform.position = new Vector3(x,y,z);
			other.gameObject.transform.localPosition  = new Vector3(x,y,z);
			rbpickUp = other.gameObject.GetComponent<Rigidbody> ();
			rbpickUp.velocity = Vector3.zero;
			other.gameObject.SetActive (true);
		}
	}
}

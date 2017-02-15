using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformGame : MonoBehaviour {
private Rigidbody rbpickUp;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other) 
	{
		print ("Entro");
		if (other.gameObject.CompareTag ("Pick Up"))
		{
			other.gameObject.SetActive (false);
			Vector3 nuevolugar = GameObject.FindGameObjectWithTag("Player").transform.position;
			nuevolugar [1] = 30;
		    nuevolugar [2] += 1;
			other.gameObject.transform.localPosition  = nuevolugar;
			rbpickUp = other.gameObject.GetComponent<Rigidbody> ();
			rbpickUp.Sleep();
			rbpickUp.velocity = Vector3.zero;
			

			other.gameObject.SetActive (true);
		}
		if (other.gameObject.CompareTag ("Mole"))
			{
				other.gameObject.SetActive (false);
				Vector3 nuevolugar = GameObject.FindGameObjectWithTag("Player").transform.position;
				nuevolugar [1] = 40;
				nuevolugar [0] += 1;
						
			    rbpickUp.Sleep();
						
				other.gameObject.transform.localPosition  = nuevolugar;
				rbpickUp = other.gameObject.GetComponent<Rigidbody> ();
				rbpickUp.velocity = new Vector3(0.0f,-15.0f,0.0f);
				other.gameObject.SetActive (true);
			}
	}
}

using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {


	public float forcetoAdd=100;





	void Start () {
		//gives it force
		GetComponent<Rigidbody2D> ().velocity = Vector2.up * 10;

	}


	void Update () {

		if (Input.GetKey (KeyCode.A))  
			GetComponent<Rigidbody2D> ().AddForce(-Vector2.right*forcetoAdd);

		if (Input.GetKey (KeyCode.D))  
			GetComponent<Rigidbody2D> ().AddForce(Vector2.right*forcetoAdd);
	}			
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
	public float speed;
	private Rigidbody rb;
	public Text countText;
	public Text winText;
	private int count;

	// Use this for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		countText.text = "Count: " + count.ToString();
		winText.text = "";
	}

	// just called before performing any physics action
	void FixedUpdate()
	{
		//if (Input.GetKeyDown ("w")) {
		//	Vector3 jump = new Vector3 (0.0f, 200.0f, 0.0f);
		//	GetComponent<Rigidbody>().AddForce (jump);
        //}
		float moveHorizontal = Input.GetAxis(@"Horizontal");
		float moveVertical = Input.GetAxis(@"Vertical");

		Vector3 movemet = new Vector3(moveHorizontal, 0, moveVertical);

		rb.AddForce(movemet * speed);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag(@"Pick Up"))
		{
			other.gameObject.SetActive(false);
			count += 1;
			countText.text = "Count: " + count.ToString();
			if (count == 4)
				winText.text = "You Win!";
		}
	}
}

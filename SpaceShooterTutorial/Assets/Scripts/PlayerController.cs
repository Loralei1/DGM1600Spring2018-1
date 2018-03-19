using System.Collections;
using UnityEngine;

[System.Serializable]
public class Boundary
{
	public float xMin, xMax, zMin, zMax;
}

public class PlayerController : MonoBehaviour {

	private Rigidbody rb; 
	public float Speed;
	public float Tilt; 
	public Boundary boundary;
	public GameObject shot; 
	public Transform ShotSpawn;
	public float FireRate;
	private float nextFire;
	private AudioSource audioSource; 

	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
		audioSource = GetComponent<AudioSource> ();
	}
		
	void Update ()
	{
		if (Input.GetButton ("Fire1") && Time.time > nextFire) {
			nextFire = Time.time + FireRate;
			Instantiate (shot, ShotSpawn.position, ShotSpawn.rotation);
			audioSource.Play ();
		}

	}

		void FixedUpdate ()
		{
			float moveHorizontal = Input.GetAxis ("Horizontal"); 
			float moveVertical = Input.GetAxis ("Vertical");

			Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rb.velocity = movement * Speed;

		rb.position = new Vector3 (
			Mathf.Clamp (rb.position.x, boundary.xMin, boundary.xMax), 
			0.0f, 
			Mathf.Clamp (rb.position.z, boundary.zMin, boundary.zMax)
		); 

		rb.rotation = Quaternion.Euler (0.0f, 0.0f, rb.velocity.x * -Tilt); 
	
		}


}

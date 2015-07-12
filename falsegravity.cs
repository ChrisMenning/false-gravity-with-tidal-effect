using UnityEngine;
using System.Collections;

//Attach this script to every object that you would like to be affected by the pull of both the planet and the moon.

public class falsegravity : MonoBehaviour {
	public float gravitationalAcceleration = 3; //The force with which the object will be attracted toward the planet.
	public float gravitationalAcceleration2 = 1; //The force with which the object will be attracted toward the moon.
	private Transform PlanetObject;
	private Transform MoonObject;
	public static bool useFalseGravity;

	void Start () 
	{
		useFalseGravity = true;
	}
	
	void FixedUpdate () 
	{
		if (useFalseGravity == true) 
		{
			MoonObject = GameObject.Find("moon").transform; //For every frame, locate the moon in the scene.
			PlanetObject = GameObject.Find ("planet").transform; //For every frame, locate the planet in the scene.

			//Add a velocity force to this object that is equal to the pull of the planet times the interval between frame updates times the difference between the planet's coordinates and this object's coordinates.
			GetComponent<Rigidbody>().velocity += gravitationalAcceleration * Time.fixedDeltaTime * (PlanetObject.transform.position - transform.position);
			//Also, add a velocity force to this object that is equal to the pull of the moon times the interval between frame updates times the difference between the moon's coordinates and this object's coordinates.
			GetComponent<Rigidbody>().velocity += gravitationalAcceleration2 * Time.fixedDeltaTime * (MoonObject.transform.position - transform.position);
		}
	}
}

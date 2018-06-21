using UnityEngine;

/* ----------------------------------------
 * class to demonstrate how to implement
 * a mini-map using a second camera
 */ 
public class MiniMap : MonoBehaviour
{
	// Gameobject variable fot the UI panel for the compass
	public GameObject mapUI;
	
	// Transform variable to be populated with the player's character, car, etc.
	private Transform target;
	
	/* ----------------------------------------
	 * At Start, (a) get the Camera component, (b) set initial camera rotation
	 */
	void Start()
	{
		// get reference to the MsLazer player characer
		target = GameObject.FindGameObjectWithTag("Player").transform;
	}

	/* ----------------------------------------
	 * During update, get target's position, adjust camera's position and rotation, 
	 * set camera's ortographic projection size, and update UI's marker position
	 */
	void Update()
	{
		// new Vector3 for rotating UI elements
		Vector3 compassAngle = new Vector3();

		// Set camera's rotation on Y-axis as UI element's rotation on Z-axis 
		compassAngle.z = target.transform.eulerAngles.y;

		// rotate minimap UI elements...
		mapUI.transform.eulerAngles = compassAngle;

	}
}

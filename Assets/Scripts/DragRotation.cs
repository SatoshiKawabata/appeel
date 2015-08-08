using UnityEngine;
using System.Collections;

public class DragRotation : MonoBehaviour {
	public float speed = 1.5f;
	public bool enableX = true;
	public bool enableY = true;

	private Vector3 screenPoint;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		screenPoint = Camera.main.WorldToScreenPoint(transform.position);
		Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		previous = Camera.main.ScreenToWorldPoint(currentScreenPoint);
	}

	private Vector3 previous;
	void OnMouseDrag() {
		Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenPoint);
		Vector3 rotation = currentPosition - previous;
		Vector3 final = new Vector3 ();

		if (enableY)
			final.y = -rotation.x;
		if (enableX)
			final.x = rotation.y;

		transform.Rotate (final * speed);
		previous = currentPosition;
	}
}

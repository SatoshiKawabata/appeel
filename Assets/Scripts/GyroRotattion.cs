using UnityEngine;
using System.Collections;

public class GyroRotattion : MonoBehaviour {
	public bool enableX = true;
	public Vector2 mapX = new Vector2(0f, 360f);
	public bool enableY = true;
	public Vector2 mapY = new Vector2(0f, 360f);
	public bool enableZ = true;
	public Vector2 mapZ = new Vector2(0f, 360f);
	public bool isLocal = false;

	void Start () {
	
	}

	void Update () {

		Vector3 eulerAngles = new Vector3();

		Quaternion attitude = AccelerationManager.instance ().getAttitude ();

		if (enableX)
			eulerAngles.x = Util.map(attitude.eulerAngles.x, 0f, 360f, mapX.x, mapX.y);

		if (enableY)
			eulerAngles.y = Util.map(attitude.eulerAngles.y, 0f, 360f, mapY.x, mapY.y);

		if (enableZ)
			eulerAngles.z = Util.map(attitude.eulerAngles.z, 0f, 360f, mapZ.x, mapZ.y);

//		transform.rotation = Quaternion.Euler (eulerAngles);
//		transform.Rotate (new Vector3 (1f, 0f, 0f));
//		transform.RotateAround (Vector3.zero, Vector3.right, 1f);
//		transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.Euler (attitude.eulerAngles.x, 0f, 0f), 0.1f);
//		transform.rotation = attitude;

		if (isLocal)
			transform.localRotation = Quaternion.Slerp (transform.localRotation, Quaternion.Euler (eulerAngles), 0.1f);
		else
			transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.Euler (eulerAngles), 0.1f);
	}
}

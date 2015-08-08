using UnityEngine;
using System.Collections;

public class AccelerationTest : MonoBehaviour {

	private Vector3 acceleration_raw;
	private TextOutput textOutput;
	
	void Start () {
		textOutput = GameObject.Find ("TextFiled").GetComponent<TextOutput> ();

		acceleration_raw = Input.acceleration;
//		textOutput.addData ("raw x", acceleration_raw.x.ToString ());
//		textOutput.addData ("raw y", acceleration_raw.y.ToString ());
//		textOutput.addData ("raw z", acceleration_raw.z.ToString ());

	}

	void Update () {
		acceleration_raw = Input.acceleration;
//		textOutput.updateData ("raw x", acceleration_raw.x.ToString ());
//		textOutput.updateData ("raw y", acceleration_raw.y.ToString ());
//		textOutput.updateData ("raw z", acceleration_raw.z.ToString ());
	}
}

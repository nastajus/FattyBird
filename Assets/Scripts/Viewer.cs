using UnityEngine;
using System.Collections;

public class Viewer : MonoBehaviour {

	private Vector3 positionAwayFromPlayer = new Vector3(0, 0.45f, 0);

	public void MoveTo(Transform transform) { 
		this.transform.parent = transform;
		this.transform.forward = transform.forward;
		this.transform.position = transform.position + positionAwayFromPlayer;
	}
}

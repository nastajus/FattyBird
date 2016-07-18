using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Active : MonoBehaviour {

	public bool Activated;
	private bool activated;

	private List<Active> playables;

	void Start () {
	}
	
	void Update () {
		UpdateActivePlayable();
	}
		
	void UpdateActivePlayable() {

		if (isUpdatingToActivePlayer()){
			activated = Activated;
			playables = GameObject.FindObjectsOfType<Active>().ToList();
			RemoveAllOtherActivePlayables(playables);
			MoveCamera();
		}
	}

	bool isUpdatingToActivePlayer(){
		bool result = (Activated && !activated) ? true : false; 
		return result;
	}

	void RemoveAllOtherActivePlayables(List<Active> playables){
		foreach (Active playable in playables){
			playable.Activated = false;
		}
	}

	void MoveCamera(){
		Camera.main.GetComponent<Viewer>().MoveTo(transform);
	}
}

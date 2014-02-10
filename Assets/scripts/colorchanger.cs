using UnityEngine;
using System.Collections;

public class colorchanger : MonoBehaviour {
	void OnCollisionEnter (Collider info)
	{
		if(info.tag == "Player") renderer.material.color = Color.blue;
	}
}
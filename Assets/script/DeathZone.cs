using UnityEngine;
using System.Collections;

public class DeathZone : MonoBehaviour {

	public void OnTriggerEnter( Collider col )	{
		if (col.tag == "Player") {
			Application.LoadLevel ( Application.loadedLevel );
		}
	}

}

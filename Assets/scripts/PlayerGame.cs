using System;
using UnityEngine;
using System.Collections; 
public class PlayerGame: MonoBehaviour
{

	public PlayerGame ()
	{
	}

	void Update()
	{

	}


	void OnGUI(){
		 {
			if (GUILayout.Button ("2PC")) {
			
			}
			if (GUILayout.Button ("3PC")) {
			
			}
			if (GUILayout.Button ("1PC")) {
				this.enabled = false;
				GameState gs = gameObject.AddComponent<GameState> ();
				gs.init(1);
			}
		}
	}


	 



}
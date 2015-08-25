using UnityEngine;
using System.Collections;

// We reccomend that for each project you keep tags and subjects in a class to make
// your life simpler. Here's how we usually do it:

public class TagIndex {
	public const int Controller = 0;		//For controller ralated things (think creating new players etc)
	public const int PlayerUpdate = 1;		//For player changeing things like change of animation/position/rotation etc
	public const int PlayerMessage = 2;
	public const int PlayerLobby = 3;
	public const int PlyerGame = 4;
	// By the way, there's no problem with using enums for the following,
	// it's just casting can be confusing so we dont.

	public class ControllerSubjects{
		public const int JoinMessage = 0;			//Tells everyone we've joined and need to who who's there.
		public const int SpawnPlayer = 1;			//Teell people to spawn a new player for us.
	}

	public class PlayerUpdateSubjects{
		public const int Position = 0;		//Move the player to (Vector3)Data
		public const int Rotation = 1;		//Rotate the player to (Quaternion)Data
	}

	public class PlayerMessageSubjects
	{
		public const int Emotion = 0;
		public const int Text = 1; 
	}


	//-----------------for createing and joing room -------------
	public class PlayerLobbySubjects
	{
		public const int CreateRoom = 0;
		public const int JoinRoom = 1; 
	}

	//--------------------for in game action - ------------
	public class PlayerGameSubjects
	{
		public const int Aadd = 0;
		public const int Finish = 1; 
	}
}
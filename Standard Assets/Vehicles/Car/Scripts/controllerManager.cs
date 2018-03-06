using UnityEngine;
using System.Collections;

public class controllerManager : MonoBehaviour {

	public int Xbox_One_Controller = 0;
	public int PS4_Controller = 0;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		checkControllerType ();
	}

		private void checkControllerType(){

			string[] names = Input.GetJoystickNames();
			for (int x = 0; x < names.Length; x++)
			{
				if (names[x].Length == 19)
				{
					print("PS4 CONTROLLER IS CONNECTED");
					PS4_Controller = 1;
					Xbox_One_Controller = 0;
				}
				if (names[x].Length == 33)
				{
					print("XBOX ONE CONTROLLER IS CONNECTED");
					//set a controller bool to true
					PS4_Controller = 0;
					Xbox_One_Controller = 1;
				}
			}
}
}
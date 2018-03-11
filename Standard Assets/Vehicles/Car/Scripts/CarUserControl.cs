using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
	[RequireComponent(typeof (CarController))]
	public class CarUserControl : MonoBehaviour
	{
		private CarController m_Car; // the car controller we want to use
		public controllerManager controllerManager;
		public int playerNumber;



		private void Awake()
		{
			// get the car controller
			m_Car = GetComponent<CarController>();
		}


		private void FixedUpdate()
		{


			float v = CrossPlatformInputManager.GetAxis ("accelerate");
			float h = CrossPlatformInputManager.GetAxis("Horizontal");
			float handbrake = CrossPlatformInputManager.GetAxis("Handbrake");
			m_Car.Move(h, v, v, handbrake);

		}



		}
	}


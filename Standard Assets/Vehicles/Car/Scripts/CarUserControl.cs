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



		private void Awake()
		{
			// get the car controller
			m_Car = GetComponent<CarController>();
		}


		private void FixedUpdate()
		{

			//If the keyboard is being used keep vertical axis as W and UP
			float v = CrossPlatformInputManager.GetAxis ("Vertical");

			//If a controller is being used change verticle acces to A or X
			if (controllerManager.PS4_Controller == 1 || controllerManager.Xbox_One_Controller == 1) {
				v = CrossPlatformInputManager.GetAxis ("Fire1");
			}

			float h = CrossPlatformInputManager.GetAxis("Horizontal");
			float handbrake = CrossPlatformInputManager.GetAxis("Jump");
			m_Car.Move(h, v, v, handbrake);

		}



		}
	}


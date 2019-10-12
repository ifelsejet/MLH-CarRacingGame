using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {
        // add code here
        private CarController gangCar;


        private void Awake()
        {
            // add code here 
            gangCar = GetComponent<CarController>();

        }


        private void FixedUpdate()
        {
            // add code here 
            float v = Input.GetAxis("Vertical");
            float h = Input.GetAxis("Horizontal");
            float handbrake = Input.GetAxis("Jump");

            gangCar.Move(h, v, v, handbrake);
        }
    }
}

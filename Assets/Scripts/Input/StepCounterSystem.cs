using Beweegmaatje.Variables;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.UI;
using PedometerU;

namespace Beweegmaatje.Input
{
    /// <summary>
    ///  Keeps track of steps
    /// </summary>
    public class StepCounterSystem : MonoBehaviour
    {

        [SerializeField]
        IntVariable _steps;

        // Start is called before the first frame update
        void Start()
        {
            StartPedometer();
        }

        private void StartPedometer()
        {
            // Initialize the pedometer
            var stepCounter = new Pedometer(OnStep);
        }

        private void OnStep(int steps, double distance)
        {
            // Add a step
            _steps.Value++;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Beweegmaatje.Variables;
using Beweegmaatje.Events;

namespace Beweegmaatje
{
    public class StepGoal : MonoBehaviour
    {

        [SerializeField]
        int _goalAmount = 50;
        [SerializeField]
        IntVariable _currentSteps;
        [SerializeField]
        VoidEvent _goalReached;

        // Start is called before the first frame update
        void Start()
        {
            // Make sure the value is reset to 0
            _currentSteps.SetValue(0);
        }

        // Update is called once per frame
        void Update()
        {
            if(_currentSteps.Value >= _goalAmount)
            {
                _goalReached.Raise();
                _currentSteps.SetValue(0);
                Handheld.Vibrate();
            }
        }
    }
}

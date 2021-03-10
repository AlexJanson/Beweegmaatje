using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Beweegmaatje.Variables;
using Beweegmaatje.Events;

namespace Beweegmaatje.Steps
{
    /// <summary>
    /// Defines a stepgoal to be used in further gamelogic
    /// </summary>
    public class StepGoal : MonoBehaviour
    {

        [SerializeField]
        IntVariable _goalAmount;
        [SerializeField]
        IntVariable _currentSteps;
        [SerializeField]
        VoidEvent _goalReached;

        // Start is called before the first frame update
        void Start()
        {
            // Make sure the value is reset to 0
            _currentSteps.Value = 0;
        }

        // Update is called once per frame
        void Update()
        {
            // If stepgoal is reached: Fire event & reset steps
            if(_currentSteps.Value >= _goalAmount)
            {
                _goalReached.Raise();
                _currentSteps.Value = 0;
                Handheld.Vibrate();
            }
        }
    }
}

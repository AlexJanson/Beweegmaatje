using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Beweegmaatje.Variables;
using UnityEngine.UI;

namespace Beweegmaatje
{
    public class StepGoalUI : MonoBehaviour
    {
        [SerializeField]
        IntVariable _goalAmount;
        [SerializeField]
        IntVariable _currentAmount;
        [SerializeField]
        Text _goalText;
        [SerializeField]
        Text _currentText;

        // Update is called once per frame
        void Update()
        {
            _goalText.text = _goalAmount.ToString();
            _currentText.text = _currentAmount.ToString();
        }
    }
}

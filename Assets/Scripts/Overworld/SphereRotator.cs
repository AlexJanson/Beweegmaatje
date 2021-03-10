using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Beweegmaatje.Variables;

/// <summary>
/// This is a really simple script that just converts the stepcount to the rotation of the planet
/// It requires input from a scriptable object
/// </summary>
namespace Overworld
{
    public class SphereRotator : MonoBehaviour
    {
        [SerializeField] IntVariable _steps;
        [SerializeField] float _speed = 1;

        void Update()
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(-_steps, 0, 0), _speed * Time.deltaTime);
        }
    }
}

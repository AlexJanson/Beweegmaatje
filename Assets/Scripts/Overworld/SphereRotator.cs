using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Beweegmaatje.Variables;

public class SphereRotator : MonoBehaviour
{
    [SerializeField] IntVariable _steps;
    [SerializeField] float _speed = 1;

    void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(-_steps, 0, 0), _speed * Time.deltaTime);
    }
}

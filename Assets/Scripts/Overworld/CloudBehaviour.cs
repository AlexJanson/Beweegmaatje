using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Beweegmaatje.Variables;

namespace Beweegmaatje
{

    public class CloudBehaviour : MonoBehaviour
    {
        [SerializeField] IntVariable _steps;
        public int _startStep;
        [SerializeField] Vector3 _resetTriggers, _spawnPosition, _direction;
        [SerializeField] Vector2 _speed;

        private void Start()
        {
            _startStep = -_steps + (int)transform.position.z;
        }

        void FixedUpdate()
        {
            transform.position += _direction * _speed.x;
            transform.position = Vector3.Lerp(transform.position,new Vector3(transform.position.x, transform.position.y, -(_steps - _startStep)), _speed.y);
            if (transform.position.x >= _resetTriggers.x || transform.position.z <= _resetTriggers.z) Reset();
        }

        void Reset()
        {
            transform.position = _spawnPosition;
            _startStep = _steps + (int)transform.position.z;
        }
    }
}

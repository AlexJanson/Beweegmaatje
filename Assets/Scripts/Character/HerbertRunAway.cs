using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Beweegmaatje
{
    public class HerbertRunAway : MonoBehaviour
    {

        [SerializeField]
        private GameObject _herbert;

        private float _animLength = 2.9f;

        private float _movementSpeed;

        private bool _canRun;

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            if (_canRun == true)
                _herbert.transform.position += transform.right * Time.deltaTime;
               
        }

        public void moveCharacter()
        {
            StartCoroutine(WaitTurnAndRun());
        }

        IEnumerator WaitTurnAndRun()
        {
            while (_animLength > 0)
            {

                yield return new WaitForSeconds(2.9f);

                _herbert.transform.Rotate(0, -90, 0);

                _canRun = true;

                _animLength = 0;
            }
        }
    }
}

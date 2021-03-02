using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Beweegmaatje.Events;
using Beweegmaatje.Variables;

namespace Beweegmaatje.Player
{
    public class Player : MonoBehaviour
    {
        public FloatVariable HP;
        public FloatReference StartingHP;

        public bool ResetHP = true;

        public VoidEvent PlayerDied;

        void Awake()
        {
            if (ResetHP)
                HP.SetValue(StartingHP);
        }

        void Update()
        {
            if (HP.Value <= 0.0f)
                Die();
        }

        private void Die()
        {
            PlayerDied.Raise();
        }
    }
}

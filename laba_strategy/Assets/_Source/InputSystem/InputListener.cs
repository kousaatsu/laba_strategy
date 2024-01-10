using AttackSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InputSystem
{
    public class InputListener : MonoBehaviour
    {
        private AttackPerforemer _attackPerf;

        private void Awake()
        {
            _attackPerf = new AttackPerforemer();
        }

        private void Update()
        {
            InputAttack();
        }

        private void InputAttack()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _attackPerf.Attack("Attack!");
            }
        }
    }
}
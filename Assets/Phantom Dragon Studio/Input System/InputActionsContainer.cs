using System;
using System.Collections;
using System.Collections.Generic;
using PhantomDragonStudio.Input;
using UnityEngine;

namespace PhantomDragonStudio.Input
{
    [CreateAssetMenu(fileName = "New Input Actions Container", menuName = "Phantom Dragon Studio/Input/Input Actions Container")]
    public class InputActionsContainer : ScriptableObject
    {
        private KeyboardAndMouseInput KBM_Scheme;
        public Vector2 input;

        public void SetupControls()
        {
            KBM_Scheme = new KeyboardAndMouseInput();
            KBM_Scheme.PlayerControls.Move.performed += ctx => input = ctx.ReadValue<Vector2>();
        }

        private void ProcessInput(Vector2 input)
        {
            Debug.Log(input);
        }
    }
}
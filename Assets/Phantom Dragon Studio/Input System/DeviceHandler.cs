
using PhantomDragonStudio.Input;
using UnityEngine;
using UnityEngine.XR;

public class DeviceHandler : MonoBehaviour
{
    [SerializeField] private InputActionsContainer inputActions = default;

    private void Awake()
    {
        inputActions.SetupControls();
    }
}

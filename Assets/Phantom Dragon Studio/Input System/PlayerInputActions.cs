// GENERATED AUTOMATICALLY FROM 'Assets/Phantom Dragon Studio/Input System/PlayerInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace PhantomDragonStudio.Input
{
    public class @KeyboardAndMouseInput : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @KeyboardAndMouseInput()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Player Controls"",
            ""id"": ""033661a7-7812-4df0-8f46-9d37007a68de"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8842e55d-abb8-4510-b337-cb638fda34b2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FireDirection"",
                    ""type"": ""PassThrough"",
                    ""id"": ""38d8295b-001a-4163-a6c6-962522281908"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Button"",
                    ""id"": ""b7d4b0ad-a4c3-4033-b2be-8ba0d38e1b40"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""c2413126-f75b-4c0c-974e-3c5291e9dda6"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2136e40c-f022-4c8c-a327-f14f1c3da4b7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3047d365-f14e-4f56-98fd-dc0a8471935b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c4ace6cd-9636-45fb-970e-aaddad61bf96"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2f2f7707-0bfd-4d05-a4bb-ab119ca07812"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""c79eb390-3367-4cc7-a092-bce94e6020c7"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FireDirection"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0608c256-97b1-4cb5-ab7f-5fba03b736bf"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""FireDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e5c09588-98ab-484a-8837-029faa5aeb83"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""FireDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""87907497-a3de-4cd5-aedc-6ffe30637ebc"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""FireDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""496cf3c6-88a9-4d40-9a26-ebe968b19810"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""FireDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5b79c993-c61a-4696-8d04-4697829d15a3"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard & Mouse"",
            ""bindingGroup"": ""Keyboard & Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Oculus"",
            ""bindingGroup"": ""Oculus"",
            ""devices"": [
                {
                    ""devicePath"": ""<OpenVROculusTouchController>{LeftHand}"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<OpenVROculusTouchController>{RightHand}"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<XRHMD>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // Player Controls
            m_PlayerControls = asset.FindActionMap("Player Controls", throwIfNotFound: true);
            m_PlayerControls_Move = m_PlayerControls.FindAction("Move", throwIfNotFound: true);
            m_PlayerControls_FireDirection = m_PlayerControls.FindAction("FireDirection", throwIfNotFound: true);
            m_PlayerControls_Look = m_PlayerControls.FindAction("Look", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }

        // Player Controls
        private readonly InputActionMap m_PlayerControls;
        private IPlayerControlsActions m_PlayerControlsActionsCallbackInterface;
        private readonly InputAction m_PlayerControls_Move;
        private readonly InputAction m_PlayerControls_FireDirection;
        private readonly InputAction m_PlayerControls_Look;
        public struct PlayerControlsActions
        {
            private @KeyboardAndMouseInput m_Wrapper;
            public PlayerControlsActions(@KeyboardAndMouseInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_PlayerControls_Move;
            public InputAction @FireDirection => m_Wrapper.m_PlayerControls_FireDirection;
            public InputAction @Look => m_Wrapper.m_PlayerControls_Look;
            public InputActionMap Get() { return m_Wrapper.m_PlayerControls; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
            public void SetCallbacks(IPlayerControlsActions instance)
            {
                if (m_Wrapper.m_PlayerControlsActionsCallbackInterface != null)
                {
                    @Move.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove;
                    @FireDirection.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnFireDirection;
                    @FireDirection.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnFireDirection;
                    @FireDirection.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnFireDirection;
                    @Look.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnLook;
                    @Look.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnLook;
                    @Look.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnLook;
                }
                m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                    @FireDirection.started += instance.OnFireDirection;
                    @FireDirection.performed += instance.OnFireDirection;
                    @FireDirection.canceled += instance.OnFireDirection;
                    @Look.started += instance.OnLook;
                    @Look.performed += instance.OnLook;
                    @Look.canceled += instance.OnLook;
                }
            }
        }
        public PlayerControlsActions @PlayerControls => new PlayerControlsActions(this);
        private int m_KeyboardMouseSchemeIndex = -1;
        public InputControlScheme KeyboardMouseScheme
        {
            get
            {
                if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard & Mouse");
                return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
            }
        }
        private int m_OculusSchemeIndex = -1;
        public InputControlScheme OculusScheme
        {
            get
            {
                if (m_OculusSchemeIndex == -1) m_OculusSchemeIndex = asset.FindControlSchemeIndex("Oculus");
                return asset.controlSchemes[m_OculusSchemeIndex];
            }
        }
        public interface IPlayerControlsActions
        {
            void OnMove(InputAction.CallbackContext context);
            void OnFireDirection(InputAction.CallbackContext context);
            void OnLook(InputAction.CallbackContext context);
        }
    }
}

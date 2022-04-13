//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Ball_Controlls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Ball_Controlls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Ball_Controlls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Ball_Controlls"",
    ""maps"": [
        {
            ""name"": ""Ball_Controls"",
            ""id"": ""7a496669-29ea-428f-818c-b08b2132b862"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""47d38134-e55d-4ba6-a7d2-bacc752f1fc2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""3a2b234e-172f-479c-8df8-73f16afc89d6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Camera"",
                    ""type"": ""Button"",
                    ""id"": ""5a85611c-47c8-40d7-9173-a2eee5c413df"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""7f773e03-1dc9-49ce-92bd-248546f37b04"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0de321b5-7164-4513-ae7d-be9888e73005"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""98120518-90b4-4fd5-898b-f3dede0072b0"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""853fb9ff-24eb-4622-9747-76322ee5c0fe"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ecb29722-bb12-495e-b528-b2b44d54b499"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8b28fcd0-6b9b-4c96-b569-a702771749d5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4ffbb2cc-9513-49c1-b11f-6a88b9901b41"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Ball_Controls
        m_Ball_Controls = asset.FindActionMap("Ball_Controls", throwIfNotFound: true);
        m_Ball_Controls_Movement = m_Ball_Controls.FindAction("Movement", throwIfNotFound: true);
        m_Ball_Controls_Jump = m_Ball_Controls.FindAction("Jump", throwIfNotFound: true);
        m_Ball_Controls_Camera = m_Ball_Controls.FindAction("Camera", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Ball_Controls
    private readonly InputActionMap m_Ball_Controls;
    private IBall_ControlsActions m_Ball_ControlsActionsCallbackInterface;
    private readonly InputAction m_Ball_Controls_Movement;
    private readonly InputAction m_Ball_Controls_Jump;
    private readonly InputAction m_Ball_Controls_Camera;
    public struct Ball_ControlsActions
    {
        private @Ball_Controlls m_Wrapper;
        public Ball_ControlsActions(@Ball_Controlls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Ball_Controls_Movement;
        public InputAction @Jump => m_Wrapper.m_Ball_Controls_Jump;
        public InputAction @Camera => m_Wrapper.m_Ball_Controls_Camera;
        public InputActionMap Get() { return m_Wrapper.m_Ball_Controls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Ball_ControlsActions set) { return set.Get(); }
        public void SetCallbacks(IBall_ControlsActions instance)
        {
            if (m_Wrapper.m_Ball_ControlsActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_Ball_ControlsActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_Ball_ControlsActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_Ball_ControlsActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_Ball_ControlsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_Ball_ControlsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_Ball_ControlsActionsCallbackInterface.OnJump;
                @Camera.started -= m_Wrapper.m_Ball_ControlsActionsCallbackInterface.OnCamera;
                @Camera.performed -= m_Wrapper.m_Ball_ControlsActionsCallbackInterface.OnCamera;
                @Camera.canceled -= m_Wrapper.m_Ball_ControlsActionsCallbackInterface.OnCamera;
            }
            m_Wrapper.m_Ball_ControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Camera.started += instance.OnCamera;
                @Camera.performed += instance.OnCamera;
                @Camera.canceled += instance.OnCamera;
            }
        }
    }
    public Ball_ControlsActions @Ball_Controls => new Ball_ControlsActions(this);
    public interface IBall_ControlsActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnCamera(InputAction.CallbackContext context);
    }
}

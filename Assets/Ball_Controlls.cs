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
                    ""name"": ""Look Around"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5a85611c-47c8-40d7-9173-a2eee5c413df"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PauseMenu"",
                    ""type"": ""Button"",
                    ""id"": ""83a7d61e-86df-46ac-a252-5a40fe742188"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
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
                    ""name"": ""Controller"",
                    ""id"": ""3e2d9071-2e06-46cb-b5c7-e3348aa466ef"",
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
                    ""id"": ""dcf41627-5bcd-4f58-b156-81a7f0ffdad3"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""42b2ddc2-e1f0-4b84-8471-ef540880a0a9"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ddf75a92-a6b7-46ca-9e87-6db6f2971ea1"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""da8e8dd9-867d-4b61-b498-cfc529992df8"",
                    ""path"": ""<Gamepad>/leftStick/right"",
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
                    ""id"": ""ea02db53-da51-4dcf-bace-94df549e7b92"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0bf1225a-cb4a-48ff-ad83-0f3d6613974a"",
                    ""path"": ""<Gamepad>/rightTrigger"",
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
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look Around"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8c1e2f1f-89b2-4016-b8c4-b92b9febfa00"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look Around"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""47603eb8-1da8-4bb7-9e32-c54df40d5e31"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PauseMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0b3d8367-c10f-4f1f-9221-c2a2ea7806a9"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PauseMenu"",
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
        m_Ball_Controls_LookAround = m_Ball_Controls.FindAction("Look Around", throwIfNotFound: true);
        m_Ball_Controls_PauseMenu = m_Ball_Controls.FindAction("PauseMenu", throwIfNotFound: true);
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
    private readonly InputAction m_Ball_Controls_LookAround;
    private readonly InputAction m_Ball_Controls_PauseMenu;
    public struct Ball_ControlsActions
    {
        private @Ball_Controlls m_Wrapper;
        public Ball_ControlsActions(@Ball_Controlls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Ball_Controls_Movement;
        public InputAction @Jump => m_Wrapper.m_Ball_Controls_Jump;
        public InputAction @LookAround => m_Wrapper.m_Ball_Controls_LookAround;
        public InputAction @PauseMenu => m_Wrapper.m_Ball_Controls_PauseMenu;
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
                @LookAround.started -= m_Wrapper.m_Ball_ControlsActionsCallbackInterface.OnLookAround;
                @LookAround.performed -= m_Wrapper.m_Ball_ControlsActionsCallbackInterface.OnLookAround;
                @LookAround.canceled -= m_Wrapper.m_Ball_ControlsActionsCallbackInterface.OnLookAround;
                @PauseMenu.started -= m_Wrapper.m_Ball_ControlsActionsCallbackInterface.OnPauseMenu;
                @PauseMenu.performed -= m_Wrapper.m_Ball_ControlsActionsCallbackInterface.OnPauseMenu;
                @PauseMenu.canceled -= m_Wrapper.m_Ball_ControlsActionsCallbackInterface.OnPauseMenu;
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
                @LookAround.started += instance.OnLookAround;
                @LookAround.performed += instance.OnLookAround;
                @LookAround.canceled += instance.OnLookAround;
                @PauseMenu.started += instance.OnPauseMenu;
                @PauseMenu.performed += instance.OnPauseMenu;
                @PauseMenu.canceled += instance.OnPauseMenu;
            }
        }
    }
    public Ball_ControlsActions @Ball_Controls => new Ball_ControlsActions(this);
    public interface IBall_ControlsActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnLookAround(InputAction.CallbackContext context);
        void OnPauseMenu(InputAction.CallbackContext context);
    }
}

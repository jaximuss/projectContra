//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/XboxControls.inputactions
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

public partial class @XboxControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @XboxControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""XboxControls"",
    ""maps"": [
        {
            ""name"": ""move"",
            ""id"": ""41917c88-98b8-4277-b0a2-3d94ab04cef6"",
            ""actions"": [
                {
                    ""name"": ""Analog"",
                    ""type"": ""Button"",
                    ""id"": ""821d7bbc-5103-4a63-ab47-d0451d7edae8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""jump"",
                    ""type"": ""Button"",
                    ""id"": ""4445e1c2-89cc-4d7c-a794-5e3f33b74915"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""dash"",
                    ""type"": ""Button"",
                    ""id"": ""0fec2164-49ee-4418-b1e4-3d7a5499dd1a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""535ecb4b-102f-4ee3-8d43-9e0e44ad91b3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Accept"",
                    ""type"": ""Button"",
                    ""id"": ""4a0dfd00-4611-453c-8229-3a77347c9bf7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Back"",
                    ""type"": ""Button"",
                    ""id"": ""b384213b-89c6-4fb1-8ab3-a363002bcac3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""d741203b-5e39-4184-95c5-24f5b3eaf2f4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""left and right"",
                    ""id"": ""c38025f5-ccbb-4b4e-92a4-fe2d4299a317"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Analog"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b0edcfe3-cb5f-41f4-8fad-04f32710e03e"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Analog"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""d2509937-0c25-4939-b209-e271957e317a"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Analog"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""leftStick"",
                    ""id"": ""4aae1ff8-eaed-4fa5-91de-7462760b178a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Analog"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""44198882-4b0b-4f5f-86d9-2b7396244657"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Analog"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""aa040ec8-755d-4b29-b078-e015f9cbf8c5"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Analog"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""28a38a12-dfbb-4839-abce-be63b449a7e5"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cb00799b-8081-4894-98d8-1307a3e1713b"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8ee5909c-4218-4190-89bc-fe9ef6dc32c8"",
                    ""path"": ""<XInputController>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c88908f9-5397-4dcd-af9c-5420f6c3c16e"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accept"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ef831c43-cdb5-47e3-8f92-59d762d01fbd"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5a10b3aa-1595-46a0-b0a0-fa0338c0b19c"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // move
        m_move = asset.FindActionMap("move", throwIfNotFound: true);
        m_move_Analog = m_move.FindAction("Analog", throwIfNotFound: true);
        m_move_jump = m_move.FindAction("jump", throwIfNotFound: true);
        m_move_dash = m_move.FindAction("dash", throwIfNotFound: true);
        m_move_Attack = m_move.FindAction("Attack", throwIfNotFound: true);
        m_move_Accept = m_move.FindAction("Accept", throwIfNotFound: true);
        m_move_Back = m_move.FindAction("Back", throwIfNotFound: true);
        m_move_Pause = m_move.FindAction("Pause", throwIfNotFound: true);
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

    // move
    private readonly InputActionMap m_move;
    private List<IMoveActions> m_MoveActionsCallbackInterfaces = new List<IMoveActions>();
    private readonly InputAction m_move_Analog;
    private readonly InputAction m_move_jump;
    private readonly InputAction m_move_dash;
    private readonly InputAction m_move_Attack;
    private readonly InputAction m_move_Accept;
    private readonly InputAction m_move_Back;
    private readonly InputAction m_move_Pause;
    public struct MoveActions
    {
        private @XboxControls m_Wrapper;
        public MoveActions(@XboxControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Analog => m_Wrapper.m_move_Analog;
        public InputAction @jump => m_Wrapper.m_move_jump;
        public InputAction @dash => m_Wrapper.m_move_dash;
        public InputAction @Attack => m_Wrapper.m_move_Attack;
        public InputAction @Accept => m_Wrapper.m_move_Accept;
        public InputAction @Back => m_Wrapper.m_move_Back;
        public InputAction @Pause => m_Wrapper.m_move_Pause;
        public InputActionMap Get() { return m_Wrapper.m_move; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MoveActions set) { return set.Get(); }
        public void AddCallbacks(IMoveActions instance)
        {
            if (instance == null || m_Wrapper.m_MoveActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MoveActionsCallbackInterfaces.Add(instance);
            @Analog.started += instance.OnAnalog;
            @Analog.performed += instance.OnAnalog;
            @Analog.canceled += instance.OnAnalog;
            @jump.started += instance.OnJump;
            @jump.performed += instance.OnJump;
            @jump.canceled += instance.OnJump;
            @dash.started += instance.OnDash;
            @dash.performed += instance.OnDash;
            @dash.canceled += instance.OnDash;
            @Attack.started += instance.OnAttack;
            @Attack.performed += instance.OnAttack;
            @Attack.canceled += instance.OnAttack;
            @Accept.started += instance.OnAccept;
            @Accept.performed += instance.OnAccept;
            @Accept.canceled += instance.OnAccept;
            @Back.started += instance.OnBack;
            @Back.performed += instance.OnBack;
            @Back.canceled += instance.OnBack;
            @Pause.started += instance.OnPause;
            @Pause.performed += instance.OnPause;
            @Pause.canceled += instance.OnPause;
        }

        private void UnregisterCallbacks(IMoveActions instance)
        {
            @Analog.started -= instance.OnAnalog;
            @Analog.performed -= instance.OnAnalog;
            @Analog.canceled -= instance.OnAnalog;
            @jump.started -= instance.OnJump;
            @jump.performed -= instance.OnJump;
            @jump.canceled -= instance.OnJump;
            @dash.started -= instance.OnDash;
            @dash.performed -= instance.OnDash;
            @dash.canceled -= instance.OnDash;
            @Attack.started -= instance.OnAttack;
            @Attack.performed -= instance.OnAttack;
            @Attack.canceled -= instance.OnAttack;
            @Accept.started -= instance.OnAccept;
            @Accept.performed -= instance.OnAccept;
            @Accept.canceled -= instance.OnAccept;
            @Back.started -= instance.OnBack;
            @Back.performed -= instance.OnBack;
            @Back.canceled -= instance.OnBack;
            @Pause.started -= instance.OnPause;
            @Pause.performed -= instance.OnPause;
            @Pause.canceled -= instance.OnPause;
        }

        public void RemoveCallbacks(IMoveActions instance)
        {
            if (m_Wrapper.m_MoveActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMoveActions instance)
        {
            foreach (var item in m_Wrapper.m_MoveActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MoveActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MoveActions @move => new MoveActions(this);
    public interface IMoveActions
    {
        void OnAnalog(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnAccept(InputAction.CallbackContext context);
        void OnBack(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
}

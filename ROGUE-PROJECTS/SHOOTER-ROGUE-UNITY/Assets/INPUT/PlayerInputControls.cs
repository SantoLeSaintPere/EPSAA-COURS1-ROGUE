//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/INPUT/PlayerInputControls.inputactions
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

public partial class @PlayerInputControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""ce85e170-82cd-43ad-86cc-7fadea0dce23"",
            ""actions"": [
                {
                    ""name"": ""MOVE"",
                    ""type"": ""PassThrough"",
                    ""id"": ""cb577e6a-a274-44bf-b32a-635838e8220e"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""JUMP"",
                    ""type"": ""Button"",
                    ""id"": ""0e0b0945-ee73-48d5-b13e-0549a65acb54"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SHOOT"",
                    ""type"": ""Button"",
                    ""id"": ""ec65f782-68c9-4cce-8305-bbea3ee468af"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""CRUNCH"",
                    ""type"": ""Button"",
                    ""id"": ""bf4a5444-0cc0-4bc8-8cc8-9bd0f293a43c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""1eb5e305-dde5-4eaa-8f0f-b55bdc25f6d4"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""0d7bbf96-07a7-4bac-b9a6-780c24d65cea"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""eb7f6337-2720-4912-92b6-c429d4d2c606"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""acf504e4-cd50-4e0e-9288-9fc69f9233bc"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""4bc5cedb-edf5-4563-8ac1-9b507cd418e1"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""966d80ef-bfef-49ac-b409-27dfc6ae8f3f"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""331ddab0-c5d2-4a10-8048-18964daf95c3"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""da1af44d-395f-4908-8344-25d304dce82b"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""365ff8e4-aaa8-488d-ae60-a7229afccad5"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1601850e-3fb0-4fb9-8aa3-8e77f60701f1"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JUMP"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""56ff0433-fffd-4c94-88b3-f9e178e623cb"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JUMP"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d04a742d-f718-4fe8-828d-13dc0fd0b512"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SHOOT"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9f997d1d-ba76-44af-af85-50421cd80da2"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SHOOT"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1b2fb871-8e4e-44c0-83d2-c8025451d1ba"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SHOOT"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d38b593e-c252-4eb9-888f-7ac6c16773d8"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SHOOT"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d23c9199-25b6-464e-9733-362e095369d4"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CRUNCH"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d18d13f8-9837-4705-af40-9dc5d41466d6"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CRUNCH"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_MOVE = m_Player.FindAction("MOVE", throwIfNotFound: true);
        m_Player_JUMP = m_Player.FindAction("JUMP", throwIfNotFound: true);
        m_Player_SHOOT = m_Player.FindAction("SHOOT", throwIfNotFound: true);
        m_Player_CRUNCH = m_Player.FindAction("CRUNCH", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
    private readonly InputAction m_Player_MOVE;
    private readonly InputAction m_Player_JUMP;
    private readonly InputAction m_Player_SHOOT;
    private readonly InputAction m_Player_CRUNCH;
    public struct PlayerActions
    {
        private @PlayerInputControls m_Wrapper;
        public PlayerActions(@PlayerInputControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MOVE => m_Wrapper.m_Player_MOVE;
        public InputAction @JUMP => m_Wrapper.m_Player_JUMP;
        public InputAction @SHOOT => m_Wrapper.m_Player_SHOOT;
        public InputAction @CRUNCH => m_Wrapper.m_Player_CRUNCH;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
            @MOVE.started += instance.OnMOVE;
            @MOVE.performed += instance.OnMOVE;
            @MOVE.canceled += instance.OnMOVE;
            @JUMP.started += instance.OnJUMP;
            @JUMP.performed += instance.OnJUMP;
            @JUMP.canceled += instance.OnJUMP;
            @SHOOT.started += instance.OnSHOOT;
            @SHOOT.performed += instance.OnSHOOT;
            @SHOOT.canceled += instance.OnSHOOT;
            @CRUNCH.started += instance.OnCRUNCH;
            @CRUNCH.performed += instance.OnCRUNCH;
            @CRUNCH.canceled += instance.OnCRUNCH;
        }

        private void UnregisterCallbacks(IPlayerActions instance)
        {
            @MOVE.started -= instance.OnMOVE;
            @MOVE.performed -= instance.OnMOVE;
            @MOVE.canceled -= instance.OnMOVE;
            @JUMP.started -= instance.OnJUMP;
            @JUMP.performed -= instance.OnJUMP;
            @JUMP.canceled -= instance.OnJUMP;
            @SHOOT.started -= instance.OnSHOOT;
            @SHOOT.performed -= instance.OnSHOOT;
            @SHOOT.canceled -= instance.OnSHOOT;
            @CRUNCH.started -= instance.OnCRUNCH;
            @CRUNCH.performed -= instance.OnCRUNCH;
            @CRUNCH.canceled -= instance.OnCRUNCH;
        }

        public void RemoveCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnMOVE(InputAction.CallbackContext context);
        void OnJUMP(InputAction.CallbackContext context);
        void OnSHOOT(InputAction.CallbackContext context);
        void OnCRUNCH(InputAction.CallbackContext context);
    }
}

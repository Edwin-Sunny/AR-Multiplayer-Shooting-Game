//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/InputActions/PlayerControlsInputAction.inputactions
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

public partial class @PlayerControlsInputAction: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControlsInputAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControlsInputAction"",
    ""maps"": [
        {
            ""name"": ""PlayerControlsMap"",
            ""id"": ""123cc5b0-a5fa-4424-ac9b-8e5dd950f516"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""5385de38-2460-484a-97c5-22c1a0415eb6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""1492b90b-f7ff-4e19-85d9-b7dd14b54685"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ShootAngle"",
                    ""type"": ""Value"",
                    ""id"": ""09a1751c-909b-4477-899c-9a129e4f5c49"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""82eee8af-5b08-4314-9763-74dac770f59a"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""61ad11b7-3c4d-4805-b8bf-98f5549b182f"",
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
                    ""id"": ""4d8349fb-b963-4298-88ca-c7cc1237c14d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8c8d523f-e8a8-4e41-8993-806a91229624"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""aa52cd9b-eed4-4b5a-b192-0043d106b6a9"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d2d0eef6-4478-414b-838c-4be319f69b44"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bbfcf2c5-3b62-45c6-8d81-b2e4040da34c"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bbc16651-ad5a-46c9-a315-a029e2b2848d"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootAngle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerControlsMap
        m_PlayerControlsMap = asset.FindActionMap("PlayerControlsMap", throwIfNotFound: true);
        m_PlayerControlsMap_Move = m_PlayerControlsMap.FindAction("Move", throwIfNotFound: true);
        m_PlayerControlsMap_Shoot = m_PlayerControlsMap.FindAction("Shoot", throwIfNotFound: true);
        m_PlayerControlsMap_ShootAngle = m_PlayerControlsMap.FindAction("ShootAngle", throwIfNotFound: true);
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

    // PlayerControlsMap
    private readonly InputActionMap m_PlayerControlsMap;
    private List<IPlayerControlsMapActions> m_PlayerControlsMapActionsCallbackInterfaces = new List<IPlayerControlsMapActions>();
    private readonly InputAction m_PlayerControlsMap_Move;
    private readonly InputAction m_PlayerControlsMap_Shoot;
    private readonly InputAction m_PlayerControlsMap_ShootAngle;
    public struct PlayerControlsMapActions
    {
        private @PlayerControlsInputAction m_Wrapper;
        public PlayerControlsMapActions(@PlayerControlsInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerControlsMap_Move;
        public InputAction @Shoot => m_Wrapper.m_PlayerControlsMap_Shoot;
        public InputAction @ShootAngle => m_Wrapper.m_PlayerControlsMap_ShootAngle;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControlsMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlsMapActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerControlsMapActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerControlsMapActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerControlsMapActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Shoot.started += instance.OnShoot;
            @Shoot.performed += instance.OnShoot;
            @Shoot.canceled += instance.OnShoot;
            @ShootAngle.started += instance.OnShootAngle;
            @ShootAngle.performed += instance.OnShootAngle;
            @ShootAngle.canceled += instance.OnShootAngle;
        }

        private void UnregisterCallbacks(IPlayerControlsMapActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Shoot.started -= instance.OnShoot;
            @Shoot.performed -= instance.OnShoot;
            @Shoot.canceled -= instance.OnShoot;
            @ShootAngle.started -= instance.OnShootAngle;
            @ShootAngle.performed -= instance.OnShootAngle;
            @ShootAngle.canceled -= instance.OnShootAngle;
        }

        public void RemoveCallbacks(IPlayerControlsMapActions instance)
        {
            if (m_Wrapper.m_PlayerControlsMapActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerControlsMapActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerControlsMapActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerControlsMapActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerControlsMapActions @PlayerControlsMap => new PlayerControlsMapActions(this);
    public interface IPlayerControlsMapActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnShootAngle(InputAction.CallbackContext context);
    }
}

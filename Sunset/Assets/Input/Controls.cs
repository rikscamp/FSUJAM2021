// GENERATED AUTOMATICALLY FROM 'Assets/Input/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""InGame"",
            ""id"": ""0a4ac72b-0b6c-4b83-8df4-9327033af138"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0cec152f-bd0c-4e73-8368-ca2a44617201"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Tounge"",
                    ""type"": ""Button"",
                    ""id"": ""db2765ed-110d-4164-951a-ca458d99f6ea"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Restart"",
                    ""type"": ""Button"",
                    ""id"": ""53dfb117-3504-4acf-a843-a54e78c40781"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Escape"",
                    ""type"": ""Button"",
                    ""id"": ""6fd8178f-3988-4b7f-b2d3-9fd153882bc5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0ecfc1b4-6e90-4551-90f1-b03118de2fae"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2fdd3c14-2a10-4870-b093-2429e93aceca"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tounge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4faae097-e046-47e9-86cf-b1b95b5ab3ea"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Restart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6b34a6a4-3005-467a-9cc5-80f161484660"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Escape"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""3c69d873-dd46-4b30-b0df-ac2c0da914fe"",
            ""actions"": [
                {
                    ""name"": ""StartGame"",
                    ""type"": ""Button"",
                    ""id"": ""236bb406-8e98-4ff9-8da4-e52d765a711b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2755f0fb-5656-41dc-8e34-d5b4598c03ec"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StartGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // InGame
        m_InGame = asset.FindActionMap("InGame", throwIfNotFound: true);
        m_InGame_Move = m_InGame.FindAction("Move", throwIfNotFound: true);
        m_InGame_Tounge = m_InGame.FindAction("Tounge", throwIfNotFound: true);
        m_InGame_Restart = m_InGame.FindAction("Restart", throwIfNotFound: true);
        m_InGame_Escape = m_InGame.FindAction("Escape", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_StartGame = m_Menu.FindAction("StartGame", throwIfNotFound: true);
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

    // InGame
    private readonly InputActionMap m_InGame;
    private IInGameActions m_InGameActionsCallbackInterface;
    private readonly InputAction m_InGame_Move;
    private readonly InputAction m_InGame_Tounge;
    private readonly InputAction m_InGame_Restart;
    private readonly InputAction m_InGame_Escape;
    public struct InGameActions
    {
        private @Controls m_Wrapper;
        public InGameActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_InGame_Move;
        public InputAction @Tounge => m_Wrapper.m_InGame_Tounge;
        public InputAction @Restart => m_Wrapper.m_InGame_Restart;
        public InputAction @Escape => m_Wrapper.m_InGame_Escape;
        public InputActionMap Get() { return m_Wrapper.m_InGame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InGameActions set) { return set.Get(); }
        public void SetCallbacks(IInGameActions instance)
        {
            if (m_Wrapper.m_InGameActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnMove;
                @Tounge.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnTounge;
                @Tounge.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnTounge;
                @Tounge.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnTounge;
                @Restart.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnRestart;
                @Restart.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnRestart;
                @Restart.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnRestart;
                @Escape.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnEscape;
                @Escape.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnEscape;
                @Escape.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnEscape;
            }
            m_Wrapper.m_InGameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Tounge.started += instance.OnTounge;
                @Tounge.performed += instance.OnTounge;
                @Tounge.canceled += instance.OnTounge;
                @Restart.started += instance.OnRestart;
                @Restart.performed += instance.OnRestart;
                @Restart.canceled += instance.OnRestart;
                @Escape.started += instance.OnEscape;
                @Escape.performed += instance.OnEscape;
                @Escape.canceled += instance.OnEscape;
            }
        }
    }
    public InGameActions @InGame => new InGameActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_StartGame;
    public struct MenuActions
    {
        private @Controls m_Wrapper;
        public MenuActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @StartGame => m_Wrapper.m_Menu_StartGame;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @StartGame.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnStartGame;
                @StartGame.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnStartGame;
                @StartGame.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnStartGame;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @StartGame.started += instance.OnStartGame;
                @StartGame.performed += instance.OnStartGame;
                @StartGame.canceled += instance.OnStartGame;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    public interface IInGameActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnTounge(InputAction.CallbackContext context);
        void OnRestart(InputAction.CallbackContext context);
        void OnEscape(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnStartGame(InputAction.CallbackContext context);
    }
}

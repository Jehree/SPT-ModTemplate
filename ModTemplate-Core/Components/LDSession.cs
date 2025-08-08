using Comfort.Common;
using EFT;
using System;
using UnityEngine;

namespace ModTemplate.Components
{
    internal class ModTemplateSession : MonoBehaviour
    {
        private ModTemplateSession() { }
        private static ModTemplateSession _instance = null;

        public Player Player { get; private set; }
        public GameWorld GameWorld { get; private set; }
        public GamePlayerOwner GamePlayerOwner { get; private set; }
        public static ModTemplateSession Instance
        {
            get
            {
                if (_instance == null)
                {
                    if (!Singleton<GameWorld>.Instantiated)
                    {
                        throw new Exception("Can't get session Instance when GameWorld is not instantiated!");
                    }

                    _instance = Singleton<GameWorld>.Instance.MainPlayer.gameObject.GetOrAddComponent<LDSession>();
                }
                return _instance;
            }
        }

        private void Awake()
        {
            GameWorld = Singleton<GameWorld>.Instance;
            Player = GameWorld.MainPlayer;
            GamePlayerOwner = Player.gameObject.GetComponent<GamePlayerOwner>();
        }
    }
}

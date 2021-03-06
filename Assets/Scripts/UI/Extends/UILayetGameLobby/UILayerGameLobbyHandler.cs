﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace Assets.Scripts.UI
{
    class UILayerGameLobbyHandler : MonoBehaviour
    {
        public void HandleOnActivateLayer()
        {
            if (null != this._gotoGameButton)
            {
                this._gotoGameButton.onClick.AddListener(_HandleOnClickGotoLobby);
                
            }
        }
        public void HandleOnDeActivateLayer()
        {
            if (null != this._gotoGameButton)
            {
                this._gotoGameButton.onClick.RemoveListener(_HandleOnClickGotoLobby);

            }
        }
        public void _HandleOnClickGotoLobby()
        {
            UIManager.Instance.DeactivateUiLayer(UILayerType.GAMELOBBY);
            UIManager.Instance.ActivateUILayer(UILayerType.GAMESCENE);
        }
        [SerializeField]
        private Button _gotoGameButton = null;
    }
}


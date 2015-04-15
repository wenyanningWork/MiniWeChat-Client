﻿using UnityEngine;
using System;
using UnityEngine.UI;
using System.Collections;
using protocol;

namespace MiniWeChat
{
    public class ChatFrame : MonoBehaviour
    {
        public Image _imageHead;
        public Text _labelUserName;
        public Text _labelLastChat;
        public Text _labelDate;

        public Button _buttonChatFrame;

        private UserItem _userItem;
        private ChatLog _chatLog;

        // Use this for initialization
        void Start()
        {
            _buttonChatFrame.onClick.AddListener(OnClickChatFrameButton);
        }

        public void Show(ChatLog chatLog)
        {
            _userItem = GlobalContacts.GetInstance().GetUserItemById(chatLog.userId);
            _chatLog = chatLog;

            // Set UserItem //
            if (_userItem != null)
            {
                UIManager.GetInstance().SetImage(_imageHead, EAtlasName.Head, "00" + _userItem.headIndex);
                _labelUserName.text = _userItem.userName;
            }

            // Set ChatItem //
            _labelLastChat.text = GlobalChat.GetInstance().GetLastChat(chatLog.userId).chatBody;
            _labelDate.text = new DateTime(chatLog.date).ToString("yyyy/MM/dd HH:mm");
        }

        public void OnClickChatFrameButton()
        {
            StateManager.GetInstance().PushState<ChatPanel>(EUIType.ChatPanel, _chatLog);
        }

    }
}


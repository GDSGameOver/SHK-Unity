﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class GameOverMenu : MonoBehaviour
{
    [SerializeField] protected Button _restartButton;
    [SerializeField] protected Button _exitButton;

    public UnityAction RestartButtonClickReached;
    public UnityAction ExitButtonClickReached;

    private void OnEnable()
    {
        _restartButton.onClick.AddListener(RestartButtonClick);
        _exitButton.onClick.AddListener(ExitButtonClick);
    }

    private void OnDisable()
    {
        _restartButton.onClick.RemoveListener(RestartButtonClick);
        _exitButton.onClick.RemoveListener(ExitButtonClick);
    }

    private void RestartButtonClick()
    {
        RestartButtonClickReached?.Invoke();
    }

    private void ExitButtonClick()
    {
        ExitButtonClickReached?.Invoke();
    }
}

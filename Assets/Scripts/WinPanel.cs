using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WinPanel : MonoBehaviour
{
    public TMP_Text winText;
    public Button restartButton;
    public Button exceptionButton;

    public Action OnRestartClicked;

    private void Start()
    {
        restartButton.onClick.AddListener(() => OnRestartClicked?.Invoke());
        exceptionButton.onClick.AddListener(OnExceptionClicked);
    }

    public void SetText(string text)
    {
        winText.SetText(text);
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }

    private static void OnExceptionClicked()
    {
        throw new Exception("Generated by clicking the exception button.");
    }
}
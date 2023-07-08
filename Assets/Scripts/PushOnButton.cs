using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Serialization;

[RequireComponent(typeof(TMP_Text))]

public class PushOnButton : MonoBehaviour
{
    [SerializeField] private GameObject _gameObjectText;

    private Color _colorOfText = new Color();
    private TMP_Text _text;

    private void Start()
    {
        _text = _gameObjectText.GetComponent<TMP_Text>();
    }

    public void ProcessPushOnButton()
    {
        _gameObjectText.SetActive(true);
        _colorOfText.r += 0.1f;
        _colorOfText.a = 1f;
        _text.color = _colorOfText;
    }
}
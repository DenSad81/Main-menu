using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class PushOnButtonOld : MonoBehaviour
{
    private const int Play = 0;
    private const int AboutAutors = 1;
    private const int Exit = 2;

    [SerializeField] private GameObject[] _gameObjectButtons;
    [SerializeField] private GameObject[] _gameObjectTextFields;

    private List<Color> _colorsOfTextFields = new List<Color>();
    private List<TMP_Text> _textFields = new List<TMP_Text>();

    private void Start()
    {
        for (int i = 0; i < _gameObjectTextFields.Length; i++)
        {
            _colorsOfTextFields.Add(new Color(0, 0, 0));
            _textFields.Add(_gameObjectTextFields[i].GetComponent<TMP_Text>());
        }
    }

    public void ProcessPushOnButtonPlay()
    {
        _gameObjectTextFields[Play].SetActive(true);
        ChangeColor(Play);
    }

    public void ProcessPushOnButtonAboutAutors()
    {
        _gameObjectTextFields[AboutAutors].SetActive(true);
        ChangeColor(AboutAutors);
    }

    public void ProcessPushOnButtonExit()
    {
        _gameObjectTextFields[Exit].SetActive(true);
        ChangeColor(Exit);
    }

    public void ChangeColor(int positionInList)
    {
        var color = _colorsOfTextFields[positionInList];
        color.r += 0.1f;
        _colorsOfTextFields[positionInList] = color;
        _textFields[positionInList].color = color;
    }
}


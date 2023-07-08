using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class PushOnButtonWeryOld : MonoBehaviour
{
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

        foreach (var gameObjectTextField in _gameObjectTextFields)
        {
            gameObjectTextField.SetActive(false);
        }
    }

    public void ProcessPushOnButton()
    {
        int k = 0;
        var posMouse = Input.mousePosition;

        foreach (var gameObject in _gameObjectButtons)
        {
            var positionButton = gameObject.GetComponent<RectTransform>().position;
            var widthButton = gameObject.GetComponent<RectTransform>().rect.width;
            var heightButton = gameObject.GetComponent<RectTransform>().rect.height;

            var leftLimitOfPositionButton = positionButton.x - widthButton / 2;
            var rightLimitOfPositionButton = positionButton.x + widthButton / 2;
            var upLimitOfPositionButton = positionButton.y - heightButton / 2;
            var dovnLimitOfPositionButton = positionButton.y + heightButton / 2;

            if (leftLimitOfPositionButton < posMouse.x & posMouse.x < rightLimitOfPositionButton)
                if (upLimitOfPositionButton < posMouse.y & posMouse.y < dovnLimitOfPositionButton)
                    break;

            k++;
        }

        _gameObjectTextFields[k].SetActive(true);

        var color = _colorsOfTextFields[k];
        color.r += 0.1f;
        _colorsOfTextFields[k] = color;

        _textFields[k].color = color;
    }
}

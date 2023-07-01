using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PushOnButtonExit : MonoBehaviour
{
    [SerializeField] private GameObject _gameObject;

    private bool _isActiv = false;
    private TMP_Text _text;
    private Color _color = new Color(0, 0, 0);

    private void Start()
    {
        _gameObject.SetActive(false);
        _text = _gameObject.GetComponent<TMP_Text>();
    }

    public void ProcessPushOnButton()
    {
        _isActiv = true;
        _gameObject.SetActive(_isActiv);

        _color.b += 0.1f;
        _text.color = _color;
    }
}

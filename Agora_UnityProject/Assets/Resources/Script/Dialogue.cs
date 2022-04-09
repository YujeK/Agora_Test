using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{

    [SerializeField] private GameObject _dialogueBubble;
    private TextMeshPro _textMesh;

    [SerializeField]
    private string[] _lines;
    [SerializeField] private float _textSpeed;

    private int _i;

    // Start is called before the first frame update
    void Start()
    {
        if (_dialogueBubble.GetComponentInChildren<TextMeshPro>())
            _textMesh = _dialogueBubble.GetComponentInChildren<TextMeshPro>();
        else
        {
            Debug.Log("No TextMeshPro Component found on the Dialogue bubble of :" + name);
            return;
        }
        _textMesh.text = string.Empty;
    }

    public void StartDialogue()
    {
        _i = 0;
        _textMesh.text = string.Empty;
        StartCoroutine(WriteLine());
    }

    IEnumerator WriteLine()
    {
        foreach (char c in _lines[_i].ToCharArray())
        {
            _textMesh.text += c;
            yield return new WaitForSeconds(_textSpeed);
        }
    }


    public void GetNextLine()
    {
        if (_textMesh.text == _lines[_i])
            NextLine();
        else
        {
            StopAllCoroutines();
            _textMesh.text = _lines[_i];
        }
    }

    void NextLine()
    {
        if (_i < _lines.Length - 1)
        {
            _i++;
            _textMesh.text = string.Empty;
            StartCoroutine(WriteLine());
        }
        else
        {
            _i = 0;
        }
    }
}

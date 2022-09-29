using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;
    [TextArea]
    [SerializeField] string _startingText;
    [TextArea]
    [SerializeField] string _missionTextTwo;
    [TextArea]
    [SerializeField] string _missionTextThree;
    [TextArea]
    [SerializeField] string _missionTextFour;
    [TextArea]
    [SerializeField] string _missionTextFive;
    string _currentText;

    void Start()
    {
        _currentText = _startingText;
    }

    void Update()
    {
        _text.text = _currentText;
    }
    public void HoveredBody()
    {
        _currentText = _missionTextTwo;
    }
    public void ExitingHover()
    {
        _currentText = _missionTextFour;
    }
    public void PlacedBody()
    {
        _currentText = _missionTextThree;
    }
    public void RemoveBody()
    {
        _currentText = _missionTextFive;
    }
}

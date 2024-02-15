using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    // Start is called before the first frame update
    private float _maxScore = 100000;
    private float _finalScore = 0;
    private string _grade;
    [SerializeField] private StepController _stepController;
    [SerializeField] private TimeController _timeController;
    void Start()
    {
        _finalScore = _maxScore -_stepController.ReturnSteps() * _timeController.ReturnTime();
    }

    // Update is called once per frame
    void Update()
    {
        if (_finalScore<= 0)
        {
            _finalScore = 0;
            _grade = ("F");
        }
        if (_finalScore <= 10000)
        {
            _grade = ("D");
        }
        if (_finalScore <= 20000)
        {
            _grade = ("C");
        }
        if (_finalScore<= 30000)
        {
            _grade = ("B");
        }
        if (_finalScore <= 40000)
        {
            _grade = ("A");
        }
        else
        {
            _grade = ("S");
        }
    }
    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 20),("Grade: ") + _grade + ("   Score: ") + _finalScore);
    }
}

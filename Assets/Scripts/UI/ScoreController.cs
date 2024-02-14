using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private StepController _stepController;
    [SerializeField] private TimeController _timeController;
    private float _score;
    private float _maxScore;
    private string _grade;
    void Start()
    {
        _score = -_stepController.FinalSteps() * (_timeController.FinalTime()*2);
        _maxScore = 100000;

    }

    // Update is called once per frame
    void Update()
    {
        if (_maxScore-_score <0) 
        {
            _grade = ("F");
        }
        if (_maxScore - _score < 10000)
        {
            _grade = ("D");
        }
        if (_maxScore - _score < 20000)
        {
            _grade = ("c");
        }
        if (_maxScore - _score < 30000)
        {
            _grade = ("B");
        }
        if (_maxScore - _score < 50000)
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

        GUI.Label(new Rect(10, 10, 200, 20), _grade );
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{
    // Start is called before the first frame update
    private float _maxScore = 100000;

    private float _finalScore = 0;
    private string _grade;
    static List<string> _scoreBoard;
    [SerializeField] private StepHandler _stepHandler;
    [SerializeField] private TimeController _timeController;

    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        _finalScore = _maxScore - _stepHandler.ReturnSteps() * _timeController.ReturnTime();

        if (_finalScore <= 0)
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
        if (_finalScore <= 30000)
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
        _scoreBoard.Add(_finalScore.ToString());
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("GamePlay");
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 20), ("Grade: ") + _grade + ("   Score: ") + _finalScore);
        GUI.Label(new Rect(200, 10, 200, 20), ("Press enter to restart"));
        GUI.Label(new Rect(100, 10, 200, 20), ("Press esc to exit"));
        
    }
}
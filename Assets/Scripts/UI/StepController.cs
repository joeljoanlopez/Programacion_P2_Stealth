using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepController : MonoBehaviour
{
    static float _steps = 0;
    private string _stepsText;
    [SerializeField] private bool _show;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnGUI()
    {
        if (_show)
        {
            GUI.Label(new Rect(10, 10, 200, 20), _stepsText);

        }
        else
        {

        }
    }
    void Update()
    {
        _stepsText = ("Steps: ") + _steps;
    }
    public void IncreaseSteps()
    {
        _steps = _steps + 1;
    }
    public float FinalSteps()
    {
        return _steps;
    }


}

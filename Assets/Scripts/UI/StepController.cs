using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepController : MonoBehaviour
{
    public float _steps = 0;
    private string _stepsText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 20), _stepsText);
    }
    void Update()
    {
        _stepsText = ("Steps: ") + _steps;
    }
    public void IncreaseSteps()
    {
        _steps = _steps + 1;
    }


}

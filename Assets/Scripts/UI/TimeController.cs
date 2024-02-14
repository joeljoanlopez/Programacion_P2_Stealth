using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    // Start is called before the first frame update
    public float _timer, _minutes, _seconds;
    private string _timerText;

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 20), _timerText);
    }
    // Update is called once per frame
    void Update()
    {
        _timer = _timer + Time.deltaTime;
        if(_timer >= 1)
        {
            _seconds = _seconds + 1;
            _timer = 0;
        }
        if (_seconds >= 60)
        {
            _minutes = _minutes + 1;
            _seconds = 0;
        }
        if (_seconds >= 10)
        {
            _timerText = ("Current Time:") + _minutes.ToString() + (":") + _seconds.ToString();

        }
        if (_seconds < 10) 
        {
            _timerText = ("Current Time: ") + _minutes.ToString() + (":0") + _seconds.ToString();

        }
    }
}

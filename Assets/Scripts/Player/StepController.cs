using UnityEngine;

public class StepController : MonoBehaviour
{
    [SerializeField] private StepHandler _stepHandler;
    private Vector2 posicionAnterior;

    // Start is called before the first frame update
    private void Start()
    {
        posicionAnterior = transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        float distanciaRecorrida = Vector2.Distance(posicionAnterior, transform.position);

        if (distanciaRecorrida > 0.5f)
        {
            _stepHandler.IncreaseSteps();

            posicionAnterior = transform.position;
        }
    }
}
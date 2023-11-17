using UnityEngine;
using UnityEngine.UI;

public class ModelSwitcher : MonoBehaviour
{
    public GameObject model1; // Reference to the first 3D model
    public GameObject model2; // Reference to the second 3D model

    private GameObject currentModel; // Reference to the currently active model

    private void Start()
    {
        // Set the initial model
        currentModel = model1;
        model1.SetActive(true);
        model2.SetActive(false);
    }

    public void SwitchModel()
    {
        // Toggle between models
        if (currentModel == model1)
        {
            model1.SetActive(false);
            model2.SetActive(true);
            currentModel = model2;
        }
        else
        {
            model1.SetActive(true);
            model2.SetActive(false);
            currentModel = model1;
        }
    }
}

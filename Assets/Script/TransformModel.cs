using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine;

public class TransformModel : MonoBehaviour
{
    public Transform modelToControl; // Reference to the 3D model's transform
    public Transform modelToControl2;
    public float rotationDuration = 1.0f;
    public float scaleDuration = 1.0f;
    public float scaleMultiplier = 1.5f;
    public Button rotateButton;
    public Button scaleUpButton;
    public Button scaleDownButton;

    private void Start()
    {
        rotateButton.onClick.AddListener(RotateModel);
        scaleUpButton.onClick.AddListener(ScaleUpModel);
        scaleDownButton.onClick.AddListener(ScaleDownModel);
    }

    public void RotateModel()
    {
        // Rotate the models by 180 and 100 degrees around the Y-axis
        modelToControl.DORotate(new Vector3(0, 180, 0), rotationDuration, RotateMode.WorldAxisAdd);
        modelToControl2.DORotate(new Vector3(0, 180, 0), rotationDuration, RotateMode.WorldAxisAdd);
    }

    public void ScaleUpModel()
    {
        // Scale up the models by a factor of scaleMultiplier
        modelToControl.DOScale(modelToControl.localScale * scaleMultiplier, scaleDuration);
        modelToControl2.DOScale(modelToControl2.localScale * scaleMultiplier, scaleDuration);
    }

    public void ScaleDownModel()
    {
        // Scale down the models by a factor of 1/scaleMultiplier
        modelToControl.DOScale(modelToControl.localScale / scaleMultiplier, scaleDuration);
        modelToControl2.DOScale(modelToControl2.localScale / scaleMultiplier, scaleDuration);
    }
}

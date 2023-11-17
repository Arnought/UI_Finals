using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    /*private bool isFaded = false;
    public float fadeDuration = 1.0f;
    public Transform modelTransform;

    public void Fade()
    {
        Renderer renderer = modelTransform.GetComponent<Renderer>();
        if (renderer != null)
        {
            float targetAlpha = isFaded ? 1.0f : 0.0f;

            renderer.material.DOFade(targetAlpha, fadeDuration);

            isFaded = !isFaded;
        }
    }*/

    public void Quit()
    {
        Application.Quit();
    }
}

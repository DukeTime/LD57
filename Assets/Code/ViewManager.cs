using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ViewManager : MonoBehaviour
{
    public static ViewManager instance;

    [SerializeField]
    private LerpAlpha fadeMask;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
    }

    public void SetBlack()
    {
        fadeMask.SetColor(Color.black);
        fadeMask.intendedAlpha = 1f;
    }

    public void FadeIn()
    {
        fadeMask.SetColor(Color.black);
        fadeMask.intendedAlpha = 0f;
    }

    public void FadeOut()
    {
        fadeMask.SetColor(new Color(0f,0f,0f,0f));
        fadeMask.intendedAlpha = 1f;
    }

    public void FadeInRed()
    {
        fadeMask.speed = 20f;
        fadeMask.SetColor(new Color(1f, 0f, 0f, 0f));
        fadeMask.intendedAlpha = 1f;
    }

    public void FadeOutRed()
    {
        fadeMask.SetColor(Color.red);
        fadeMask.intendedAlpha = 0f;
        fadeMask.speed = 2.5f;
    }
}
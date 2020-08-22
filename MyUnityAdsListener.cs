using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using Ludiq;
using Bolt;

public class MyUnityAdsListener : MonoBehaviour, IUnityAdsListener
{
    public void OnUnityAdsDidError(string message)
    {
        CustomEvent.Trigger(gameObject, "OnUnityAdsDidError", message);
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        CustomEvent.Trigger(gameObject, "OnUnityAdsDidFinish", placementId, showResult);
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        CustomEvent.Trigger(gameObject, "OnUnityAdsDidStart", placementId);
    }

    public void OnUnityAdsReady(string placementId)
    {
        CustomEvent.Trigger(gameObject, "OnUnityAdsReady", placementId);
    }

    void Start()
    {
        Advertisement.AddListener(this);
    }
}

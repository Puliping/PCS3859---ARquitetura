using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeepLinkManager : MonoBehaviour
{
    public static DeepLinkManager Instance { get; private set; }
    public string deeplinkURL;
    public GameObject menuUI;
    public GameObject rotate;
    public GameObject surfaceManager;
    public GameObject movel;
    
    public ObjectSelector objectSelector;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;                
            Application.deepLinkActivated += onDeepLinkActivated;
            if (!string.IsNullOrEmpty(Application.absoluteURL))
            {
                // Cold start and Application.absoluteURL not null so process Deep Link.
                onDeepLinkActivated(Application.absoluteURL);
            }
            // Initialize DeepLink Manager global variable.
            else deeplinkURL = "[none]";
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
 
    private void onDeepLinkActivated(string url)
    {
        menuUI.SetActive(false);
        rotate.SetActive(true);

        if (url.Contains("1"))
        {
            objectSelector.Chair();
        }
        if (url.Contains("2"))
        {
            objectSelector.Stove();
        }
        if (url.Contains("3"))
        {
            objectSelector.Fridge();
        }
        
        surfaceManager.SetActive(true);
        movel.SetActive(true);
    }
}

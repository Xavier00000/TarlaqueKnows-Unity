using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentRoot : MonoBehaviour
{
    private void Awake()
    {
        // Make the root GameObject persistent across scenes
        DontDestroyOnLoad(gameObject);
    }
}

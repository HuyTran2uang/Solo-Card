using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Helpers
{
    public static void DestroyChildren(this Transform T)
    {
        foreach (Transform child in T) Object.Destroy(child.gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MemoryUnityFixUtility : MonoBehaviour
{

    public static void GetMissingScript(out IEnumerable<MonoMemoryUnityFix> list) { list = GameObject.FindObjectsOfType<MonoMemoryUnityFix>().Where(k => k.m_missingScriptDetected); }
    public static void GetMemoryScript(out IEnumerable<MonoMemoryUnityFix> list) { list = GameObject.FindObjectsOfType<MonoMemoryUnityFix>(); }


    public static void RemoveAllMemoryScriptOfScene() {
        GetMemoryScript(out IEnumerable<MonoMemoryUnityFix> list);
        foreach (var item in list)
        {
            DestroyImmediate(item);
        }
    }

}

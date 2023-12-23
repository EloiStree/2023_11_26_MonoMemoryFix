using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MemoryListMissingScriptMono : MonoBehaviour
{

    public MonoMemoryUnityFix[] m_listOfMissingScripts;
    public MonoMemoryUnityFix[] m_listOfMemoryScripts;

    [ ContextMenu("Refresh")]
    void Refresh()
    {
        m_listOfMissingScripts = GameObject.FindObjectsOfType<MonoMemoryUnityFix>().Where(k => k.m_missingScriptDetected).ToArray();
        m_listOfMemoryScripts = GameObject.FindObjectsOfType<MonoMemoryUnityFix>().ToArray();

    }

    [ContextMenu("Remove All Memory Script")]
    public void RemoveAllMemoryScript() {
        MemoryUnityFixUtility.RemoveAllMemoryScriptOfScene();
    }

}

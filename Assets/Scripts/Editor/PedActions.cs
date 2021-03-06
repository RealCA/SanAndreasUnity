﻿using Fclp.Internals.Extensions;
using SanAndreasUnity.Behaviours;
using SanAndreasUnity.Utilities;
using System.Linq;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEditor.SceneManagement;
using UnityEngine;

[InitializeOnLoad]
public class PedActions
{
    //private const bool onStateChanged = false;

    static PedActions()
    {
        EditorApplication.playModeStateChanged += OnPlayModeChanged;
    }

    private static void OnPlayModeChanged(PlayModeStateChange currentMode)
    {
        if (currentMode == PlayModeStateChange.EnteredEditMode)
            RemoveUnnamed(); //AssetDatabase.Refresh();
    }

    [DidReloadScripts]
    private static void OnScriptsReloaded()
    {
        if (!Application.isPlaying)
            RemoveUnnamed();
    }

    private static void RemoveUnnamed()
    {
        GameObject playerModel = GameObject.Find("PlayerModel");
		if (null == playerModel)
			return;

        //playerModel.GetComponents<FrameContainer>().ForEach(x => x.SafeDestroy());

        
       	//playerModel.GetComponentsInChildren<Component>().Where(x => x.GetType() != typeof(Transform) && x.transform.parent == playerModel.transform).Select(x => x.gameObject).ForEach(x => x.SafeDestroy());
        
        
        //EditorSceneManager.SaveOpenScenes();
    }
}
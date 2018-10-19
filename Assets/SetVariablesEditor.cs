using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(SetVariables))]
public class SetVariablesEditor : Editor
{
    private SetVariables myTarget;
    private SerializedObject soTarget;

    private SerializedProperty mainTime;
    private SerializedProperty mainTimeEnabled;
    private SerializedProperty mainTimeSO;
    private SerializedProperty mainTimeEnabledSO;

    private void OnEnable()
    {
        myTarget = (SetVariables)target;
        soTarget = new SerializedObject(target);

        mainTime = soTarget.FindProperty("mainTime");
        mainTimeEnabled = soTarget.FindProperty("mainTimeEnabled");
        mainTimeSO = soTarget.FindProperty("mainTimeSO");
        mainTimeEnabledSO = soTarget.FindProperty("mainTimeEnabledSO");

    }

    public override void OnInspectorGUI()
    {
        soTarget.Update();
		EditorGUI.BeginChangeCheck();

        myTarget.currentTab = GUILayout.Toolbar(myTarget.currentTab, new string[] { "Network", "Time", "Node" });
        
		switch (myTarget.currentTab)
        {
            case 0:
				myTarget.currentTabString = "Network";
                break;
            case 1:
			    EditorGUILayout.LabelField("Variables", EditorStyles.boldLabel);
                EditorGUILayout.PropertyField(mainTime);
                EditorGUILayout.PropertyField(mainTimeEnabled);
				EditorGUILayout.LabelField("ScriptableObjects", EditorStyles.boldLabel);
                EditorGUILayout.PropertyField(mainTimeSO);
                EditorGUILayout.PropertyField(mainTimeEnabledSO);
				myTarget.currentTabString = "Time";
                break;
            case 2:
				myTarget.currentTabString = "Node";
                break;
        }

		if(EditorGUI.EndChangeCheck()){
			soTarget.ApplyModifiedProperties();
		//	GUI.FocusControl(null);
		}

		// EditorGUI.BeginChangeCheck();

		// switch (myTarget.currentTabString){
		// 	case "Network":
		// 		break;
		// 	case "Time":
		// 		EditorGUILayout.PropertyField(mainTime);
        //         EditorGUILayout.PropertyField(mainTimeEnabled);
        //         EditorGUILayout.PropertyField(mainTimeSO);
        //         EditorGUILayout.PropertyField(mainTimeEnabledSO);
		// 		break;
		// 	case "Node":
		// 		break;
		// }

		// if(EditorGUI.EndChangeCheck()){
		// 	soTarget.ApplyModifiedProperties();
		// }
    }

}

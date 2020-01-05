//using UnityEngine;
//using UnityEditor;
//using System.Collections.Generic;
//using System;

//[CustomEditor(typeof(Hero))]
//public class StatEditorDisplay : Editor
//{
//    public override void OnInspectorGUI()
//    {
//        //base.OnInspectorGUI();
//        DrawDefaultDisplay();
//    }

//    private void DrawDefaultDisplay()
//    {
//        throw new NotImplementedException();
//    }

//    void OnEnable()
//    {
//        var heroScript = ((MonoBehaviour)target).gameObject.GetComponent<Hero>();
//        heroScript.GetStats.ToString();
//    }
//}

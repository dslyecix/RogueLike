// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEditor;
// using UnityEditorInternal;
// using System.IO;
// using System;

// [System.Serializable]
// public class AssetInfo
// {
//     public string assetPath;
// }


// [CustomEditor(typeof(MixinCollection))]
// public class MixinCollectionInspector : Editor {

//     MixinCollection mixinCollection;
// 	ReorderableList mixinList;

//     float lineHeight;
//     float lineHeightSpace;

//     void OnEnable()
//     {
//         if (target == null)
//         {
//             return;
//         }        

//         lineHeight = EditorGUIUtility.singleLineHeight;
//         lineHeightSpace = lineHeight + 3f;

//         mixinCollection = (MixinCollection)target;        

//         mixinList = new ReorderableList(serializedObject, serializedObject.FindProperty("actionMixins"), true, true, true, true);

//         // mixinList.drawHeaderCallback = (Rect rect) =>
//         // {
//         //     EditorGUI.LabelField(rect, new GUIContent("Action Mixins"));
//         // };

//         mixinList.drawElementCallback = (Rect rect, int index, bool isActive, bool isFocus) => 
//         {
//             SerializedProperty element = mixinList.serializedProperty.GetArrayElementAtIndex(index);

//             SerializedObject elementObject = new SerializedObject(element.objectReferenceValue);    
//             elementObject.Update();

//             EditorGUI.LabelField(new Rect(rect.x, rect.y, rect.width - 80, lineHeight), elementObject.FindProperty("Name").stringValue);
//             EditorGUIUtility.labelWidth = 70;
//             EditorGUI.PropertyField(new Rect(rect.width - 80, rect.y, 80, lineHeight), elementObject.FindProperty("showMixin"));
//             EditorGUIUtility.labelWidth = 0;


//             elementObject.FindProperty("showInfo").boolValue = EditorGUI.Foldout(new Rect(rect.x, rect.y + lineHeightSpace, rect.width, lineHeight), elementObject.FindProperty("showInfo").boolValue, "Info"); 
//             if (elementObject.FindProperty("showInfo").boolValue)
//             {
//                 EditorGUI.ObjectField(new Rect(rect.x, rect.y + (lineHeightSpace * 2), rect.width, lineHeight), element, new GUIContent("Object"));

//                 SerializedProperty propertyIterator = elementObject.GetIterator();

//                 int i = 3;
//                 bool showChildren = true;
//                 while(propertyIterator.NextVisible(showChildren))
//                 {
//                     EditorGUI.PropertyField(new Rect(rect.x, rect.y + lineHeightSpace * i, rect.width, lineHeight), propertyIterator);
//                     i++;
//                     if (propertyIterator.isArray)
//                     {
//                         showChildren = propertyIterator.isExpanded;
//                     }
//                 }
//             }
//             elementObject.ApplyModifiedProperties();
//         };

//         mixinList.elementHeightCallback = (int index) =>
//         {
//             float height = 0;
//             int i = 2;

//             SerializedProperty element = mixinList.serializedProperty.GetArrayElementAtIndex(index);
//             SerializedObject elementObject = new SerializedObject(element.objectReferenceValue);
            
//             if (elementObject.FindProperty("showInfo").boolValue)
//             {
//                 i++;
//                 elementObject.Update();

//                 SerializedProperty propertyIterator = elementObject.GetIterator();

            
//                 bool showChildren = true;
//                 while(propertyIterator.NextVisible(showChildren))
//                 {
//                     i++;
//                     if (propertyIterator.isArray)
//                     {
//                         showChildren = propertyIterator.isExpanded;
//                     }

//                 }
//             }

//             height = lineHeightSpace * i;
//             return height;
//         };
//     }
//     //     mixinList.onAddDropdownCallback = (Rect rect, ReorderableList list) =>
//     //     {
//     //         GenericMenu dropdownMenu = new GenericMenu();
//     //         string[] mixinGUIDs = AssetDatabase.FindAssets("l:Mixin");

//     //         for (int i = 0; i < mixinGUIDs.Length; i++)
//     //         {
//     //             string path = AssetDatabase.GUIDToAssetPath(mixinGUIDs[i]);
//     //             string menuPath = path.Replace("Assets/Game Resources/Scripts/", "");

//     //             dropdownMenu.AddItem (new GUIContent(menuPath), false, AddItem, new AssetInfo { assetPath = path } );
//     //         }

//     //         dropdownMenu.ShowAsContext();
//     //     };

//     //     mixinList.onRemoveCallback = (ReorderableList List) =>
//     //     {
//     //         int i = mixinList.index;
//     //         mixinCollection.actionMixins[i].showMixin = true;
//     //         mixinCollection.actionMixins[i].hideFlags = HideFlags.None;
//     //         mixinCollection.actionMixins.RemoveAt(i);
//     //     };

//     // }

//     // public void AddItem( object obj)
//     // {
//     //     AssetInfo assetInfo = (AssetInfo)obj;

//     //     string assetName = Path.GetFileNameWithoutExtension(assetInfo.assetPath);

//     //     Type assetType = Type.GetType(assetName + ", Assembly-CSharp");

//     //     MixinBase newMixin = (MixinBase)mixinCollection.gameObject.AddComponent(assetType);
//     //     newMixin.showInfo = true;
//     //     newMixin.Name = assetName;
//     //     newMixin.showMixin = false;

//     //     int index = mixinList.serializedProperty.arraySize ++;
//     //     mixinList.serializedProperty.GetArrayElementAtIndex(index).objectReferenceValue = newMixin;

//     //     serializedObject.ApplyModifiedProperties();
//     // }

//     public override void OnInspectorGUI()
//     {
//         DrawDefaultInspector();

//         mixinList.DoLayoutList();

//         for(int i = 0; i < mixinCollection.actionMixins.Count; i++)
//         {
//             if(!mixinCollection.actionMixins[i].showMixin && mixinCollection.actionMixins[i].hideFlags == HideFlags.None)
//             {
//                 mixinCollection.actionMixins[i].hideFlags = HideFlags.HideInInspector;
//             } else if (mixinCollection.actionMixins[i].hideFlags == HideFlags.HideInInspector)
//             {
//                 mixinCollection.actionMixins[i].hideFlags = HideFlags.None;
//             }
//         }
//     }


// }

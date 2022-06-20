using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RoomNodeGraph", menuName = "Scriptable Object/Dungeon/Room Node Graph")]
public class RoomNodeGraphSO : ScriptableObject
{
    [HideInInspector] public RoomNodeTypeListSO roomNodeTypeList;
    [HideInInspector] public List<RoomNodeSO> roomNodeList = new List<RoomNodeSO>();
    [HideInInspector] public Dictionary<string, RoomNodeSO> roomNodeDictionary = new Dictionary<string, RoomNodeSO>();

    private void Awake()
    {
        LoadRoomNOdeDictionary();
    }

    private void LoadRoomNOdeDictionary()
    {
        roomNodeDictionary.Clear();

        foreach (RoomNodeSO node in roomNodeList)
        {
            roomNodeDictionary[node.id] = node;
        }
    }

    public RoomNodeSO GetRoomNode(string roomNodeID)
    {
        if(roomNodeDictionary.TryGetValue(roomNodeID, out RoomNodeSO roomNode))
        {
            return roomNode;
        }

        return null;
    }

    #region Editor code
#if UNITY_EDITOR
    [HideInInspector] public RoomNodeSO roomNodeToDrawLinefrom = null;
    [HideInInspector] public Vector2 linePosition;

    public void OnValidate()
    {
        LoadRoomNOdeDictionary();
    }
    public void SetNodeToDrawConnectionLinefrom(RoomNodeSO node, Vector2 position)
    {
        roomNodeToDrawLinefrom = node;
        linePosition = position;
    }
#endif
    #endregion Editor code
}

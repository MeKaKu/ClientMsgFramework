
using Assets.Scripts.MsgFramework;
using Assets.Scripts.MsgFramework.Game;
using UnityEngine;

public class TestMsg : GameBase
{
    public int toArea;
    public int eventCode;
    public string msg;

    public int bind;
    
    [ContextMenu("Bind")]
    void BindEvent(){
        Bind(bind);
    }

    [ContextMenu("Unbind")]
    void UnbindEvent(){
        Unbind();
    }

    [ContextMenu("TestSendMsg")]
    void TestSendMsg(){
        Dispatch(toArea, eventCode, $"from<{areaCode}>to<{toArea}>,event<{eventCode}>,msg={msg}");
    }

    public override void Execute(int eventCode, object arg)
    {
        Debug.Log(areaCode + " - " + eventCode + " - " + arg.ToString());
    }
}

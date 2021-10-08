using UnityEngine;
using UnityEditor;
using Looxid.Link;
using UnityEngine.Playables;


[CustomEditor(typeof(Record))]
public class buttonininspector : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        Record a = (Record)target;
        if (GUILayout.Button("01"))
        {
            //a.flag = true;
            //timeline = GetComponent<a.PlayableDirector>();
            //for(int i = 0; i< 30; i++)
            //{
            //timelime_loop_count(a.timeline1,0);
            //}
            a.timeline1.Play();
            //a.timeline1.Play();
            // Debug.Log(a.timeline1);
            a.number = 0;
            a.startrecord();
        }
        else if (GUILayout.Button("02"))
        {
            //a.flag = true;
            a.timeline2.Play();
            a.number = 1;
            a.startrecord();
        }
        else if (GUILayout.Button("03"))
        {
            //a.flag = true;
            a.timeline3.Play();
            a.number = 2;
            a.startrecord();
        }
        else if (GUILayout.Button("04"))
        {
            //a.flag = true;
            a.timeline4.Play();
            a.number = 3;
            a.startrecord();
        }
        else if (GUILayout.Button("write to excel 1"))
        {
            a.number = 0;
            a.savetoexcel();
        }
        else if (GUILayout.Button("write to excel 2"))
        {
            a.number = 1;
            a.savetoexcel();
        }
        else if (GUILayout.Button("write to excel 3"))
        {
            a.number = 2;
            a.savetoexcel();
        }
        else if (GUILayout.Button("write to excel 4"))
        {
            a.number = 3;
            a.savetoexcel();
        }
    }
}

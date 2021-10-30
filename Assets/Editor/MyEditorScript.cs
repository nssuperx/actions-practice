using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Build.Reporting;

class MyEditorScript
{
    static void PerformBuild()
    {
        List<string> scenePaths = new List<string>();
        foreach (EditorBuildSettingsScene editorBuildSettingsScene in EditorBuildSettings.scenes)
        {
            if (editorBuildSettingsScene.enabled == true)
            {
                scenePaths.Add(editorBuildSettingsScene.path);
            }
        }

        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = scenePaths.ToArray();
        buildPlayerOptions.locationPathName = "WebGLBuild";
        buildPlayerOptions.target = BuildTarget.WebGL;
        buildPlayerOptions.options = BuildOptions.None; // set whatever you want here
        BuildPipeline.BuildPlayer(buildPlayerOptions);  // apply the setting changes
    }
}
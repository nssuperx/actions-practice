using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Build.Reporting;
using UnityEngine;

class MyEditorScript
{
    static void BuildWebGL()
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
        buildPlayerOptions.targetGroup = BuildTargetGroup.WebGL;
        buildPlayerOptions.target = BuildTarget.WebGL;
        buildPlayerOptions.options = BuildOptions.StrictMode;
        BuildReport report = BuildPipeline.BuildPlayer(buildPlayerOptions);
        BuildSummary summary = report.summary;

        if (summary.result == BuildResult.Succeeded)
        {
            Debug.Log("Build succeeded: " + summary.totalSize + " bytes");
            Debug.Log("Loaded scene:" + scenePaths.Count);
            foreach(string scenePath in scenePaths){
                Debug.Log(scenePath);
            }
        }else if(summary.result == BuildResult.Failed){
            Debug.Log("Build failed");
        }
    }

    static void BuildWindowsMono()
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
        buildPlayerOptions.locationPathName = "WindowsBuild";
        buildPlayerOptions.targetGroup = BuildTargetGroup.Standalone;
        buildPlayerOptions.target = BuildTarget.StandaloneWindows64;
        buildPlayerOptions.options = BuildOptions.StrictMode;
        BuildReport report = BuildPipeline.BuildPlayer(buildPlayerOptions);
        BuildSummary summary = report.summary;

        if (summary.result == BuildResult.Succeeded)
        {
            Debug.Log("Build succeeded: " + summary.totalSize + " bytes");
            Debug.Log("Loaded scene:" + scenePaths.Count);
            foreach(string scenePath in scenePaths){
                Debug.Log(scenePath);
            }
        }else if(summary.result == BuildResult.Failed){
            Debug.Log("Build failed");
        }
    }
}
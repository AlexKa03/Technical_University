#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;
using UnityEditor.Animations;
using System.Linq;

public class EnemyAnimatorSetup : EditorWindow
{
    [MenuItem("Tools/Setup Enemy Animators")]
    public static void SetupAnimators()
    {
        // Find all animator controllers in the project
        string[] guids = AssetDatabase.FindAssets("t:AnimatorController");
        int setupCount = 0;

        foreach (string guid in guids)
        {
            string path = AssetDatabase.GUIDToAssetPath(guid);
            AnimatorController controller = AssetDatabase.LoadAssetAtPath<AnimatorController>(path);
            
            if (controller == null) continue;

            // We specifically want to target the Grunt, Golem, and Lich/Wizard controllers
            string nameLower = controller.name.ToLower();
            if (nameLower.Contains("grunt") || nameLower.Contains("golem") || nameLower.Contains("lich") || nameLower.Contains("wizard"))
            {
                SetupController(controller);
                setupCount++;
                Debug.Log($"Successfully set up Animator Controller: {controller.name}");
            }
        }

        Debug.Log($"Finished setting up {setupCount} Animator Controllers!");
    }

    private static void SetupController(AnimatorController controller)
    {
        // 1. Add Trigger Parameters if they don't exist
        AddTrigger(controller, "Hit");
        AddTrigger(controller, "Die");
        AddTrigger(controller, "Victory");
        AddTrigger(controller, "Attack");

        // 2. Map AnyState Transitions to the correct state blocks based on screenshots
        AnimatorStateMachine rootStateMachine = controller.layers[0].stateMachine;

        // "Hit" parameter triggers the "GetHit" state
        CreateAnyStateTransition(rootStateMachine, "GetHit", "Hit");

        // "Die" parameter triggers the "Die" or "die" state
        CreateAnyStateTransition(rootStateMachine, "Die", "Die");
        CreateAnyStateTransition(rootStateMachine, "die", "Die"); // handles Lich lowercase

        // "Victory" parameter triggers the "Victory" or "victory" state
        CreateAnyStateTransition(rootStateMachine, "Victory", "Victory");
        CreateAnyStateTransition(rootStateMachine, "victory", "Victory"); // handles Lich lowercase

        // "Attack" parameter triggers the "Attack01" or "attack01" state
        CreateAnyStateTransition(rootStateMachine, "Attack01", "Attack");
        CreateAnyStateTransition(rootStateMachine, "attack01", "Attack"); // handles Lich lowercase
        
        EditorUtility.SetDirty(controller);
        AssetDatabase.SaveAssets();
    }

    private static void AddTrigger(AnimatorController controller, string paramName)
    {
        // Check if parameter already exists
        if (controller.parameters.Any(p => p.name == paramName))
            return;

        controller.AddParameter(paramName, AnimatorControllerParameterType.Trigger);
    }

    private static void CreateAnyStateTransition(AnimatorStateMachine stateMachine, string targetStateName, string triggerCondition)
    {
        // Find the target state by name
        ChildAnimatorState targetChildState = stateMachine.states.FirstOrDefault(s => s.state.name == targetStateName);
        
        // If the state doesn't exist in this specific controller, skip it
        if (targetChildState.state == null)
            return;

        AnimatorState targetState = targetChildState.state;

        // Check if a transition with this trigger already exists from AnyState to prevent duplicates
        bool transitionExists = stateMachine.anyStateTransitions.Any(t => 
            t.destinationState == targetState && 
            t.conditions.Any(c => c.parameter == triggerCondition)
        );

        if (!transitionExists)
        {
            AnimatorStateTransition newTransition = stateMachine.AddAnyStateTransition(targetState);
            newTransition.AddCondition(AnimatorConditionMode.If, 0, triggerCondition);
            newTransition.hasExitTime = false; // Triggers should happen immediately
            newTransition.duration = 0.1f; // Quick crossfade
        }
    }
}
#endif

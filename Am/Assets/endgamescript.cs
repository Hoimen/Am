using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationEndSceneTransition : MonoBehaviour
{
    private Animator animator;
    public string nextSceneName = "loser screen";

    void Start()
    {
        // Assuming the Animator component is attached to the same GameObject as this script
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Check if the animation has reached the end
        if (IsAnimationAtEnd())
        {
            // Transition to the next scene
            TransitionToNextScene();
        }
    }

    bool IsAnimationAtEnd()
    {
        // Assuming you have a trigger parameter named "AnimationEnd" in the animator
        return animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f;
    }

    void TransitionToNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}

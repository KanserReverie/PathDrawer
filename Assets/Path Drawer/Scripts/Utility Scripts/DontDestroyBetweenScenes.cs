using UnityEngine;
namespace Path_Drawer.Scripts.Utility_Scripts
{
    /// <summary>
    /// Add this to any GameObjects you want to persist between scenes.
    /// </summary>
    public class DontDestroyBetweenScenes : MonoBehaviour
    {
        private void Awake()
        {
            DontDestroyOnLoad(this);
        }
        private void Start()
        {
            DontDestroyOnLoad(this);
        }
        private void OnEnable()
        {
            DontDestroyOnLoad(this);
        }
    }
}

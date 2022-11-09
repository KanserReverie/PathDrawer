using Path_Drawer.Scripts.Utility_Scripts;
using UnityEngine;

namespace Path_Drawer.Scripts.Menus
{
    public class MainMenuManager : MonoBehaviour
    {
        public void OpenLevel(string sceneName)
        {
            CommonlyUsedStaticMethods.OpenSceneWithSceneName(sceneName);
        }
    }
}

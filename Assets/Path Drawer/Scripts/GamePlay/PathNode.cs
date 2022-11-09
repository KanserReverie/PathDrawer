using UnityEngine;
using UnityEngine.EventSystems;

namespace Path_Drawer.Scripts.GamePlay
{
    public class PathNode : MonoBehaviour, IPointerClickHandler 
    {
        [SerializeField] private bool canBeDrawnAt;
        [SerializeField] private bool currentlySelected;
        private PathDrawer pathDrawer;

        public void Start()
        {
            canBeDrawnAt = true;
            currentlySelected = false;
            pathDrawer = FindObjectOfType<PathDrawer>();
        }
        
        public void OnPointerClick(PointerEventData eventData)
        {
            SelectThisNode();
        }
        
        private void SelectThisNode()
        {
            currentlySelected = true;
            Debug.Log($"SelectThisNode = {currentlySelected}");
            pathDrawer.SelectedNode(this);
        }
        
    }
}

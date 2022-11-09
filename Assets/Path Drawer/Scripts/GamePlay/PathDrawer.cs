using UnityEditor.Experimental.GraphView;
using UnityEngine;
namespace Path_Drawer.Scripts.GamePlay
{
    public class PathDrawer : MonoBehaviour
    {
        [SerializeField] private GameObject nodeLine;
        [SerializeField] private PathNode selectedNode1;
        [SerializeField] private PathNode selectedNode2;
        
        public void SelectedNode(PathNode node)
        {
            if (selectedNode1 == null)
            {
                selectedNode1 = node;
                return;
            }
            else if (selectedNode2 == null && selectedNode1 != node)
            {
                selectedNode2 = node;
                CreateBoxLine(selectedNode1.gameObject.transform.position, selectedNode2.gameObject.transform.position);
                ClearNodes();
            }
        }
        
        public void ClearNodes()
        {
            selectedNode1 = null;
            selectedNode2 = null;
        }
        
        
        public void CreateBoxLine(Vector3 nodeOrigin1, Vector3 nodeOrigin2)
        {
            Vector3 spawnLocation =  Vector3.Lerp(nodeOrigin1, nodeOrigin2, 0.5f);
            GameObject newPath = Instantiate(nodeLine, spawnLocation, transform.rotation);
            newPath.transform.LookAt(nodeOrigin2);
            float distanceBetweenNodes = Vector3.Distance(nodeOrigin1, nodeOrigin2);
            newPath.transform.localScale = new Vector3(1,1,distanceBetweenNodes);
            Debug.Log("distanceBetweenNodes " + distanceBetweenNodes);
        }
    }
}

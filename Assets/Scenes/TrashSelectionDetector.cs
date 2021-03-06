namespace Mapbox.Examples
{
	using UnityEngine;
	using Mapbox.Unity.MeshGeneration.Data;
	using System.Linq;

	public class TrashSelectionDetector : MonoBehaviour
	{
		private FeatureUiMarker _marker;
		private VectorEntity _feature;

		public void OnMouseUpAsButton()
		{
			Debug.Log("OnMouseUpAsButton : "  );
				//_selectedFeature.Feature.Properties.Select(x => x.Key + " - " + x.Value.ToString()).ToArray()
			GameObject.Find("Canvas");
		}

		internal void Initialize(FeatureUiMarker marker, VectorEntity ve)
		{
			_marker = marker;
			_feature = ve;
			Debug.Log("TrashSelectionDetector Initialize : "  );
		}
	}
}
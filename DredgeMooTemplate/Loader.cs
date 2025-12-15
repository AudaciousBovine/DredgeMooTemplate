using UnityEngine;

namespace DredgeMooTemplate
{
	public class Loader
	{
		/// <summary>
		/// This method is run by Winch to initialize your mod
		/// </summary>
		public static void Initialize()
		{
			var gameObject = new GameObject(nameof(DredgeMooTemplate));
			gameObject.AddComponent<DredgeMooTemplate>();
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
}
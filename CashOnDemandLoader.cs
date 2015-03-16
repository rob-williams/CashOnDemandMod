namespace CashOnDemand {

    using ICities;
    using UnityEngine;

    public class CashOnDemandLoader : ILoadingExtension {

        private static CashOnDemandComponent component = null;

        public void OnCreated(ILoading loading) {
        }

        public void OnLevelLoaded(LoadMode mode) {
            // Create object and attach component if a game is being loaded or started
            if (mode == LoadMode.LoadGame || mode == LoadMode.NewGame) {
                GameObject obj = new GameObject("CashOnDemandObject");
                CashOnDemandLoader.component = obj.AddComponent<CashOnDemandComponent>();
            }
        }

        public void OnLevelUnloading() {
            if (CashOnDemandLoader.component != null) {
                GameObject.Destroy(CashOnDemandLoader.component.gameObject);
                CashOnDemandLoader.component = null;
            }
        }

        public void OnReleased() {
        }
    }
}

using UnityEngine;


namespace GrigorichIndieGames_CosmoLoader
{
    internal sealed class GameController :
        MonoBehaviour
    {
        #region Fields

        [SerializeField] private Data _data;

        private ControllersRepository _controllersRepository;

        #endregion


        #region UnityMethods

        private void Start()
        {
            _data.SystemRoot = transform.parent;
            _controllersRepository = new ControllersRepository();
            new GameInitializator(_controllersRepository, _data);
        }

        private void Update()
        {
            var delta = Time.deltaTime;
            _controllersRepository.LogicUpdate(delta);
        }

        private void FixedUpdate()
        {
            var delta = Time.deltaTime;
            _controllersRepository.PhysicUpdate(delta);
        }

        private void LateUpdate()
        {
            var delta = Time.deltaTime;
            _controllersRepository.LateUpdate(delta);
        }

        #endregion
    }
}

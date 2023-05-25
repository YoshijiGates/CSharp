using DiSample.Daos;
using DiSample.Services;
using NX.DependencyInjection;
using System.Diagnostics;

namespace DiSample.Logics
{

    [Logic(Scope = ComponentScope.Singleton, TargetType = typeof(DiLogic))]
    public class DiLogic
    {
        private readonly IDiDao _diDao;

        // コンストラクタ
        public DiLogic(IDiDao diDao)
        {
            _diDao = diDao;
        }
        public string Get()
        {
            // 実行確認
            Debug.Print("Run DiLogic");

            return _diDao.Get();
        }
    }
}

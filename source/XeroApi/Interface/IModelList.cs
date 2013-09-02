using System.Collections;
using System.Collections.Generic;

namespace XeroApi.Interface
{
    public interface IModelList : IList
    {
    }

    public interface IModelList<TModel> : IModelList, IList<TModel>
        where TModel : IModelBase
    {
    }
}

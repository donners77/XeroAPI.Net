using System;
using System.Collections;
using System.Collections.Generic;
using XeroApi.Interface;

namespace XeroApi.Model
{
    public abstract class ModelList<TModel> : List<TModel>, IModelList<TModel>
        where TModel : IModelBase
    {
    }
}

﻿using Microsoft.AspNetCore.Http;

namespace Xendor.QueryModel.Criteria
{
    public interface IFactoryExpression<TMetaData, out TCriteria>
        where TMetaData : IMetaDataExpression
        where TCriteria : IExpression<TMetaData>
    {
        TCriteria Create(IQueryCollection queryCollection);
    }
}
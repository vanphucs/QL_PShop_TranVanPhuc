﻿
namespace PShop.SQL.FolderSQL
{
    public interface IDataAccess
    {
        void ExecuteCommand<U>(string sql, U parameters);
        List<T> Query<T, U>(string sql, U parameters);
        T QueryFirst<T, U>(string sql, U parameters);
        T QuerySingle<T, U>(string sql, U parameters);
    }
}
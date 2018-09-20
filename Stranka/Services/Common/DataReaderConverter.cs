using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace Stranka.Services.Common
{
    public static class DataReaderConverter
    {
        public static List<T> ToList<T>(IDataReader dr)
        {
            List<T> list = new List<T>();
            T obj = default(T);
            while (dr.Read())
            {
                obj = Activator.CreateInstance<T>();
                foreach (PropertyInfo prop in obj.GetType().GetProperties())
                {
                    if (!object.Equals(dr[prop.Name], DBNull.Value))
                    {
                        prop.SetValue(obj, dr[prop.Name], null);
                    }
                }
                list.Add(obj);
            }
            return list;
        }

        public static long ToBigInt(IDataReader dr)
        {
            while (dr.Read())
            {
                long insertedId = dr.GetInt64(0);
                return insertedId;
            }
            return 0;
        }

        public static T ToObject<T>(IDataReader dr)
        {
            T obj = default(T);
            while (dr.Read())
            {
                obj = Activator.CreateInstance<T>();
                foreach (PropertyInfo prop in obj.GetType().GetProperties())
                {
                    if (!object.Equals(dr[prop.Name], DBNull.Value))
                    {
                        prop.SetValue(obj, dr[prop.Name], null);
                    }
                }
                return obj;
            }
            return obj;
        }
    }
}

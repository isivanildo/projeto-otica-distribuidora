using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;

namespace MRUtil
{
    public static class DataReaderExtensions
    {
        /// <summary>
        /// Recebe o nome da Coluna e retorna seu Index
        /// </summary>
        public static int GetColumnIndex(this IDataReader reader, string columnName)
        {
            try
            {
                return reader.GetOrdinal(columnName);
            }

            catch (Exception e)
            {
                // Gera um erro SQL com o nome da coluna caso não encontrada
                string errorMessage = string.Format("Coluna não encontrada na consulta : [{0}]", columnName);
                var ctor = typeof(SqlException).GetConstructors(BindingFlags.NonPublic | BindingFlags.Instance)[0];
                SqlException sqlException = ctor.Invoke(new object[] { errorMessage, null, null, Guid.NewGuid() }) as SqlException;

                throw sqlException;
            }
        }

        /// <summary>
        /// Retorna string com dados da consulta, se nula retorna uma string vazia
        /// </summary>
        public static string GetStringOrEmpty(this IDataReader reader, string columnName)
        {
            int columnIndex = reader.GetColumnIndex(columnName);
            return reader.IsDBNull(columnIndex) ? string.Empty : reader.GetString(columnIndex);
        }

        /// <summary>
        /// Retorna string com dados da consulta, se nula retorna null
        /// </summary>
        public static string GetStringOrNull(this IDataReader reader, string columnName)
        {
            int columnIndex = reader.GetColumnIndex(columnName);
            return reader.IsDBNull(columnIndex) ? null : reader.GetString(columnIndex);
        }

        /// <summary>
        /// Retorna int com dados da consulta, se nulo retorna 0
        /// </summary>
        public static int GetInt(this IDataReader reader, string columnName)
        {
            int columnIndex = reader.GetColumnIndex(columnName);
            return reader.IsDBNull(columnIndex) ? Convert.ToInt16(0) : (int)reader[columnName];
        }

        /// <summary>
        /// Retorna int com dados da consulta, se nulo retorna null
        /// </summary>
        public static int? GetIntOrNull(this IDataReader reader, string columnName)
        {
            int columnIndex = reader.GetColumnIndex(columnName);

            if (reader.IsDBNull(columnIndex))
            {
                return null;
            }

            return reader.GetInt16(columnIndex);
        }

        /// <summary>
        /// Retorna Int16 com dados da consulta, se nulo retorna 0
        /// </summary>
        public static Int16 GetInt16(this IDataReader reader, string columnName)
        {
            int columnIndex = reader.GetColumnIndex(columnName);
            return reader.IsDBNull(columnIndex) ? Convert.ToInt16(0) : reader.GetInt16(columnIndex);
        }

        /// <summary>
        /// Retorna Int16 com dados da consulta, se nulo retorna null
        /// </summary>
        public static Int16? GetInt16OrNull(this IDataReader reader, string columnName)
        {
            int columnIndex = reader.GetColumnIndex(columnName);

            if (reader.IsDBNull(columnIndex))
            {
                return null;
            }

            return reader.GetInt16(columnIndex);
        }

        /// <summary>
        /// Retorna Int32 com dados da consulta, se nulo retorna 0
        /// </summary>
        public static Int32 GetInt32(this IDataReader reader, string columnName)
        {
            int columnIndex = reader.GetColumnIndex(columnName);
            return reader.IsDBNull(columnIndex) ? 0 : reader.GetInt32(columnIndex);
        }

        /// <summary>
        /// Retorna Int32 com dados da consulta, se nulo retorna 0
        /// </summary>
        public static Int32? GetInt32OrNull(this IDataReader reader, string columnName)
        {
            int columnIndex = reader.GetColumnIndex(columnName);

            if (reader.IsDBNull(columnIndex))
            {
                return null;
            }

            return reader.GetInt32(columnIndex);
        }

        /// <summary>
        /// Retorna Int64 com dados da consulta, se nulo retorna 0
        /// </summary>
        public static Int64 GetInt64(this IDataReader reader, string columnName)
        {
            int columnIndex = reader.GetColumnIndex(columnName);
            return reader.IsDBNull(columnIndex) ? 0 : reader.GetInt64(columnIndex);
        }

        /// <summary>
        /// Retorna Int64 com dados da consulta, se nulo retorna null
        /// </summary>
        public static Int64? GetInt64OrNull(this IDataReader reader, string columnName)
        {
            int columnIndex = reader.GetColumnIndex(columnName);

            if (reader.IsDBNull(columnIndex))
            {
                return null;
            }

            return reader.GetInt64(columnIndex);
        }

        /// <summary>
        /// Retorna Float com dados da consulta, se nulo retorna 0
        /// </summary>
        public static float GetFloat(this IDataReader reader, string columnName)
        {
            int columnIndex = reader.GetColumnIndex(columnName);
            if (reader.IsDBNull(columnIndex))
            {
                return 0;
            }

            return reader.GetFloat(columnIndex);
        }

        /// <summary>
        /// Retorna Float com dados da consulta, se nulo retorna null
        /// </summary>
        public static float? GetFloatOrNull(this IDataReader reader, string columnName)
        {
            int columnIndex = reader.GetColumnIndex(columnName);
            if (reader.IsDBNull(columnIndex))
            {
                return null;
            }

            return reader.GetFloat(columnIndex);
        }

        /// <summary>
        /// Retorna double com dados da consulta, se nulo retorna 0
        /// </summary>
        public static double GetDouble(this IDataReader reader, string columnName)
        {
            int columnIndex = reader.GetColumnIndex(columnName);
            if (reader.IsDBNull(columnIndex))
            {
                return 0;
            }

            return reader.GetDouble(columnIndex);
        }

        /// <summary>
        /// Retorna double com dados da consulta, se nulo retorna null
        /// </summary>
        public static double? GetDoubleOrNull(this IDataReader reader, string columnName)
        {
            int columnIndex = reader.GetColumnIndex(columnName);
            if (reader.IsDBNull(columnIndex))
            {
                return null;
            }

            return reader.GetDouble(columnIndex);
        }

        /// <summary>
        /// Retorna decimal com dados da consulta, se nulo retorna 0
        /// </summary>
        public static decimal GetDecimal(this IDataReader reader, string columnName)
        {
            int columnIndex = reader.GetColumnIndex(columnName);
            if (reader.IsDBNull(columnIndex))
            {
                return 0;
            }

            return reader.GetDecimal(columnIndex);
        }

        /// <summary>
        /// Retorna decimal com dados da consulta, se nulo retorna null
        /// </summary>
        public static decimal? GetDecimalOrNull(this IDataReader reader, string columnName)
        {
            int columnIndex = reader.GetColumnIndex(columnName);
            if (reader.IsDBNull(columnIndex))
            {
                return null;
            }

            return reader.GetDecimal(columnIndex);
        }

        /// <summary>
        /// Retorna Boolean com dados da consulta, se nulo retorna false
        /// </summary>
        public static Boolean GetBoolean(this IDataReader reader, string columnName)
        {
            int columnIndex = reader.GetColumnIndex(columnName);
            return reader.IsDBNull(columnIndex) ? false : reader.GetBoolean(columnIndex);
        }

        /// <summary>
        /// Retorna Boolean com dados da consulta, se nulo retorna null
        /// </summary>
        public static Boolean? GetBooleanOrNull(this IDataReader reader, string columnName)
        {
            int columnIndex = reader.GetColumnIndex(columnName);
            if (reader.IsDBNull(columnIndex))
            {
                return null;
            }
            return reader.GetBoolean(columnIndex);
        }

        /// <summary>
        /// Retorna DateTime com dados da consulta, se nulo retorna null
        /// </summary>
        public static DateTime? GetDateTimeOrNull(this IDataReader reader, string columnName)
        {
            int columnIndex = reader.GetColumnIndex(columnName);
            if (reader.IsDBNull(columnIndex))
            {
                return null;
            }
            return reader.GetDateTime(columnIndex);
        }

        /// <summary>
        /// Retorna DateTime com dados da consulta, se nulo retorna MinValue (Data Minima)
        /// </summary>
        public static DateTime GetDateTimeOrMinValue(this IDataReader reader, string columnName)
        {
            int columnIndex = reader.GetColumnIndex(columnName);
            if (reader.IsDBNull(columnIndex))
            {
                return DateTime.MinValue;
            }
            return reader.GetDateTime(columnIndex);
        }

        /// <summary>
        /// Retorna Byte[] (ByteArray) com dados da consulta, se nulo retorna null
        /// </summary>
        public static Byte[] GetByteArrayOrNull(this IDataReader reader, string columnName)
        {
            int columnIndex = reader.GetColumnIndex(columnName);
            if (reader.IsDBNull(columnIndex))
            {
                return null;
            }

            return (byte[])reader[columnIndex];
        }

        /// <summary>
        /// Retorna Byte com dados da consulta, se nulo retorna null
        /// </summary>
        public static Byte? GetByteOrNull(this IDataReader reader, string columnName)
        {
            int columnIndex = reader.GetColumnIndex(columnName);
            if (reader.IsDBNull(columnIndex))
            {
                return null;
            }

            return reader.GetByte(columnIndex);
        }

        /// <summary>
        /// Retorna char com dados da consulta, se nulo retorna null
        /// </summary>
        public static char? GetCharOrNull(this IDataReader reader, string columnName)
        {
            int columnIndex = reader.GetColumnIndex(columnName);
            if (reader.IsDBNull(columnIndex))
            {
                return null;
            }

            return reader.GetChar(columnIndex);
        }

    }
}

﻿namespace XyTodo.Cross
{
    public interface ICrossUserPreferences
    {
        void PutString( string key, string value );
        string GetString( string key );

        void PutInt( string key, int value );
        int GetInt( string key );

        void Clear();
    }
}

using StudentHelper.DAL.Contracts.Entities;
using StudentHelper.DAL.Contracts.Exceptions;
using StudentHelper.DAL.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace VegaIT.Timesheet.DAL.Repositories
{
    public class LanguageRepository : ILanguageRepository
    {
        private SqlConnection _connection;

        public LanguageRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public void Add(Language language)
        {
            try
            {
                string insertCommand = "insert into Language (LanguageName) values (@LanguageName)";
                using (var command = new SqlCommand(insertCommand, _connection))
                {
                    command.Parameters.AddWithValue("@LanguageName", language.LanguageName);
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new DataAccessException(ex.Message, ex);
            }
        }


        public void Edit(Language language)
        {
            try
            {
                string updateCommand = "update Language set LanguageName = @LanguageName where LanguageId = @LanguageId";
                using (var command = new SqlCommand(updateCommand, _connection))
                {
                    command.Parameters.AddWithValue("@LanguageName", language.LanguageName);
                    command.Parameters.AddWithValue("@LanguageId", language.LanguageId);
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new DataAccessException(ex.Message, ex);
            }
        }

        public IEnumerable<Language> GetAll()
        {
            string selectCommand = "select LanguageId, LanguageName from Language";
            try
            {
                var languages = new List<Language>();
                using (var command = new SqlCommand(selectCommand, _connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var language = new Language
                        {
                            LanguageId = reader.GetInt32(0),
                            LanguageName = reader.GetString(1)
                        };
                        languages.Add(language);
                    }
                }
                return languages;
            }
            catch (SqlException ex)
            {
                throw new DataAccessException(ex.Message, ex);
            }
        }

        public Language GetById(int id)
        {
            string selectCommand = "Select LanguageId, LanguageName from Language where LanguageId = @LanguageId";
            try
            {
                using (var command = new SqlCommand(selectCommand, _connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        var language = new Language();
                        while (reader.Read())
                        {
                            language.LanguageId = reader.GetInt32(0);
                            language.LanguageName = reader.GetString(1);
                        }
                        return language;
                    }

                }
            }
            catch (SqlException ex)
            {
                throw new DataAccessException(ex.Message, ex);
            }
        }

        public void Remove(int id)
        {
            try
            {
                string deleteCommand = "delete from Language where LanguageId = @LanguageId";
                using (var command = new SqlCommand(deleteCommand, _connection))
                {
                    command.Parameters.AddWithValue("@LanguageId", id);
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new DataAccessException(ex.Message, ex);
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
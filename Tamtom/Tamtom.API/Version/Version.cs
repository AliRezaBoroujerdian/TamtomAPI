using System;
using System.Threading.Tasks;
using Tamtom.Database.Dapper.Crud;

namespace Tamtom.API.Version
{
    public class Version : Crud, ICrud
    {
        public Version() : base("Version", "Application") { }

        #region Not implemented method
        public Task<int> DeActive(CrudModels.PrimaryKeyID id)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeActive(CrudModels.PrimaryKeyGuid id)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeActiveLanguage(CrudModels.DeActiveLanguageModelWithID model)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeActiveLanguage(CrudModels.DeActiveLanguageModelWithGuid model)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(CrudModels.PrimaryKeyID id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(CrudModels.PrimaryKeyGuid id)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteLanguage(CrudModels.DeleteLanguageModelWithID model)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteLanguage(CrudModels.DeleteLanguageModelWithGuid model)
        {
            throw new NotImplementedException();
        }

        public Task<int> Insert<InputType>(InputType model)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAndReturnInsertedID<InputType>(InputType model)
        {
            throw new NotImplementedException();
        }

        public Task<ReturnType> SelectSingle<ReturnType>(CrudModels.SelectSingleModelWithID model)
        {
            throw new NotImplementedException();
        }

        public Task<ReturnType> SelectSingle<ReturnType>(CrudModels.SelectSingleModelWithGuid model)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update<InputType>(InputType model)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}

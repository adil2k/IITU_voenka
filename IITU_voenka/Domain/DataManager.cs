using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IITU_voenka.Domain.Repositories.Abstract;

namespace IITU_voenka.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public IServiceItemsRepository ServiceItems { get; set; }

        public DataManager(ITextFieldsRepository textFieldsRepository, IServiceItemsRepository serviceItemsRepository)
        {
            TextFields = textFieldsRepository;
            ServiceItems = serviceItemsRepository;
        }
    }
}

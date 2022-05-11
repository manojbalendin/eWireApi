﻿namespace eWireApi.Service
{
    public interface IRepositoryService
    {
        public IAccountService _accountService { get; set; }
        public ICustomerService _customerService { get; set; }
        public IFundTransferService _fundTransferService { get; set; }
        public ISchemeService _schemeService { get; set; }
    }
}
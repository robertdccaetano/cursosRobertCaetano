using secao14Ex01.Entities;
using System;

namespace secao14Ex01.Services
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);

                double updateQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, i);

                double fullQuota = updateQuota + _onlinePaymentService.PaymentFee(updateQuota);

                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}

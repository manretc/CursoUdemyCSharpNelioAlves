using ExercicioFixacao.Entities;

namespace ExercicioFixacao.Services {
    internal class ContractService {

        public IOnlinePaymentService _onlinePaymentService { get; set; }

        public ContractService(int months, IOnlinePaymentService onlinePaymentService) {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months) {
            double fixInstallment = contract.TotalValue / months;
            Console.WriteLine("Installments:");
            for (int i = 1; i <= months; i++) {

                double value = fixInstallment + _onlinePaymentService.Interest(fixInstallment, i);
                value = value + _onlinePaymentService.PaymentFee(value);
                DateTime date = contract.Date.AddMonths(i);
                contract.AddInstallment(new Installment(date, value));

            }


        }

    }
}

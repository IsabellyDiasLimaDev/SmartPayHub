namespace SmartPayHub.Domain.Entities
{
    public class MerchantEntity
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string DocumentNumber { get; private set; } // CNPJ ou CPF
        public string Email { get; private set; }
        public List<UserEntity> Users { get; private set; } = new();
        public List<PaymentTerminalEntity> Terminals { get; private set; } = new();
        public BankAccountEntity BankAccount { get; private set; }

        protected MerchantEntity() { } // For EF

        public MerchantEntity(string name, string documentNumber, string email, BankAccountEntity bankAccount)
        {
            Id = Guid.NewGuid();
            Name = name;
            DocumentNumber = documentNumber;
            Email = email;
            BankAccount = bankAccount;
        }

        public void AddUser(UserEntity user) => Users.Add(user);
        public void AddTerminal(PaymentTerminalEntity terminal) => Terminals.Add(terminal);
    }
}

namespace SmartPayHub.Domain.Entities;

public class Merchant
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string DocumentNumber { get; private set; } // CNPJ ou CPF
    public string Email { get; private set; }
    public List<User> Users { get; private set; } = new();
    public List<PaymentTerminal> Terminals { get; private set; } = new();
    public BankAccount BankAccount { get; private set; }

    protected Merchant() {} // For EF

    public Merchant(string name, string documentNumber, string email, BankAccount bankAccount)
    {
        Id = Guid.NewGuid();
        Name = name;
        DocumentNumber = documentNumber;
        Email = email;
        BankAccount = bankAccount;
    }

    public void AddUser(User user) => Users.Add(user);
    public void AddTerminal(PaymentTerminal terminal) => Terminals.Add(terminal);
}

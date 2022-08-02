namespace Heranca01.Entities
{
    internal class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount)
        {
            Balance -= amount;
        }

        /* 
        Utilizando base. podemos reutilizar o método da Superclasse em nossa subclasse
        e aplicar outras regras, no caso, além dos 5 reais de taxa para saque, a conta corrente terá
        2 reais de taxa adicionais 
        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
        */
    }
}

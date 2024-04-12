namespace ContaBancaria
{
    public class Conta
    {
        
        public double saldo { get; set; }	
        public double limite { get; set; }
        public int id { get; set; }
        //public Dictionary<int, List<double>> listaConta = new Dictionary<int, List<double>>

        public Conta()
        {
            saldo = 0;
            limite = 5000.0;
            //listaConta.Add(id, new List<double>{saldo});
            
        }

        public double Sacar(double valor)
        {
                saldo-=valor;
                Tarifar();
                return saldo;
            
        }

        public double Depositar(double valor)
        {
            saldo+=valor;
            Tarifar();
            return saldo;
            
        }

        public void VerificarSaldo(int id)
        {
            
        }

        private double Tarifar()
        {
            return saldo -=0.5;
        } 

    }

}




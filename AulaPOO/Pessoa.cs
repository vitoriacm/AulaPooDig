namespace AulaPOO
{
    public class Pessoa
    {

       private int calcularDigitoVerificador()  // private outras classes n tem acesso
       {
         int multiplicador = 2;
         int DigitoVerificador = (NumeroDoRegistro * multiplicador) + 11;
         return DigitoVerificador;
       }

        public String Nome {get;set;}
        public DateTime DataNascimento {get;set;}
        public int NumeroDoRegistro {get:set;}
        public int DigitoVerificador {get;}

        public int Idade {
            get {
                return DateTime.Now.Year - DataNascimento.Year;
            }
        }

    }
}
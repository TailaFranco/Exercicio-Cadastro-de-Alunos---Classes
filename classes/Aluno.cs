namespace Aula_02_12_2020
{
//     Vamos desenvolver um programa que cadastre e mostre um aluno. Criando uma classe aluno com as seguintes
// propriedades: Nome, Curso, Idade, RG, Bolsista (boolean), Média Final e Valor da Mensalidade. Também teremos os métodos: VerMediaFinal() e VerMensalidade(), caso seja bolsista faremos o cálculo da mensalidade.
    public class Aluno
    {
        public string nome;
        public string curso;
        public string rg;
        public int idade;
        public bool bolsista;
        public float mediaFinal;
        public float valorMensalidade;
        
        public int VerMediaAluno();
        {
            return this.mediaFinal;
        }
        public float valorMensalidade(bool bolsista && mediaFinal >=8)
        {
            if(bolsista)
            {
                float valor = (valorMensalidade * 0.5f);
            }
            else
            {
                float valor = valorMensalidade;
            }
            return valor;
        }
    }
}
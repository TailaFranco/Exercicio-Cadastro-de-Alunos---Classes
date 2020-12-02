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
        
        public float VerMediaAluno()
        {
            return this.mediaFinal;
        }
        float valor;
        public float VerMensalidade(bool bolsista, float mediaFinal)
        {
            if(this.bolsista && this.mediaFinal >=8)
            {
                valor = this.valorMensalidade * 0.5f;
            }
            else
            {
                valor = this.valorMensalidade;
            }
            return valor;
        }
    }
}
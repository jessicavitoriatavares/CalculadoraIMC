public class Individuo{
    public string Nome { get; set; }
    public double Peso { get; set; }
    public double Altura { get; set; }
    public double IMC { get => Peso / (Altura * Altura);}
    public Individuo(string nome, double peso, double altura)
    {
        Nome = nome;
        Peso = peso;
        Altura = altura;
    }

    public string ClassificacaoIMC(){
        if(IMC < 17 ){
                return "Está muito abaixo do peso.";
            }

            else if(IMC >= 17 && IMC < 18.5 ){
                return "Está abaixo do peso";
            }

            else if(IMC >= 18.5 && IMC < 25){
                 return "Está com peso normal";
            }

            else if(IMC >= 25 && IMC < 30){
                 return "Está acima do peso.";
            }

            else if(IMC >= 30 && IMC < 35){
                 return "Está com obsidade I.";
            }

            else if(IMC >= 35 && IMC < 40){
                return "Está com obsidade II. ";
            }
            
            return "Está com obsidade III.";

    }

    public string ParaPesoIdeal(){
        double pesoNormalMinimo = Altura * Altura * 18.5;
        double pesoNormalMaximo = Altura * Altura * 25;
        double pesoFaltante = pesoNormalMinimo - Peso;
        double pesoExcesso = Peso - pesoNormalMaximo;

        if(IMC < 17 ){
            return "Deveria receber mais "+ pesoFaltante + "Kg";
        }

        return "Deveria perder " + pesoExcesso + "Kg";
    }
}
